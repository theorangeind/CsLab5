using System.Collections.Generic;

namespace CsLab5
{
    class Region : Place, IHasPopulation
    {
        private List<City> cities;

        public Region()
        {
            this.cities = new List<City>(3);
            addCity(new City());
            this.cities[0].setRegionCenter(true);
        }

        public Region(List<City> cities, float area)
        {
            this.cities = cities;
            this.setArea(area);
            bool flag = false;
            for(int i = 0; i < this.cities.Count; i++)
            {
                if (flag && this.cities[i].isRegionCenter()) this.cities[i].setRegionCenter(false);
                if (this.cities[i].isRegionCenter()) flag = true;
            }
        }

        public int getPopulation()
        {
            int sumPop = 0;
            for(int i = 0; i < cities.Count; i++)
            {
                sumPop += cities[i].getPopulation();
            }
            return sumPop;
        }

        public List<City> getCities()
        {
            return this.cities;
        }

        public City getRegionCenter()
        {
            for(int i = 0; i < this.cities.Count; i++)
            {
                if (this.cities[i].isRegionCenter()) return this.cities[i];
            }
            return this.cities[0];
        }

        public void addCity(City city)
        {
            this.cities.Add(city);
        }

        public void removeCity(int indexInArray)
        {
            if (cities[indexInArray].isRegionCenter()) cities[0].setRegionCenter(true);
            cities.Remove(cities[indexInArray]);
        }

        public void removeCity(string name)
        {
            for(int i = 0; i < this.cities.Count; i++)
            {
                if (this.cities[i].getName().Equals(name))
                {
                    removeCity(i);
                }
            }
        }
    }
}
