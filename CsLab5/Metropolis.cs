namespace CsLab5
{
    class Metropolis : City
    {
        private double justVariable;

        public Metropolis()
        {
            this.setRegionCenter(true);
        }

        public Metropolis(string name, int population, float area)
        {
            this.setName(name);
            this.setPopulation(population);
            this.setArea(area);
            this.setRegionCenter(true);
        }

        public double getSomeVariable() { return this.justVariable; }

        public void setSomeVariable(double value) { this.justVariable = value; }
    }
}
