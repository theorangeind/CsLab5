using System;

namespace CsLab5
{
    class City : Place, IHasPopulation, IHasName
    {
        private int population;
        private bool regionCenter;
        private string name;

        public City()
        {
            this.population = 0;
            this.name = "NoName";
        }

        public City(string name, int population, float area)
        {
            this.name = name;
            this.population = population;
            this.setArea(area);
        }

        public City(string name, int population, float area, bool isRegionCenter)
        {
            this.name = name;
            this.population = population;
            this.setArea(area);
            this.regionCenter = isRegionCenter;
        }

        public int getPopulation()
        {
            return this.population;
        }

        public void setPopulation(int value)
        {
            this.population = value;
        }

        public bool isRegionCenter()
        {
            return this.regionCenter;
        }

        public void setRegionCenter(bool value)
        {
            this.regionCenter = value;
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public static float findCity(City[] array, string name)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].getName() == name) return i;
            }
            return -1;
        }

        public void printName() { Console.WriteLine(getName()); }
        public void printArea() { Console.WriteLine(getArea().ToString()); }
        public void printPopulation() { Console.WriteLine(getPopulation().ToString()); }
        public void printRegCenterStatus() { Console.WriteLine(isRegionCenter().ToString()); }

        public void setValues()
        {
            setName("NoName");
            setArea(0);
            setPopulation(0);
            setRegionCenter(false);
        }
    }
}
