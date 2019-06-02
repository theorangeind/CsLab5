namespace CsLab5
{
    class Place : IHasArea
    {
        private float area;

        public Place()
        {
            this.area = 0;
        }

        public Place(float area)
        {
            this.area = area;
        }

        public float getArea()
        {
            return this.area;
        }

        public void setArea(float area)
        {
            this.area = area;
        }

        public static float findPlace(Place[] array, float area)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i].getArea() == area) return i;
            }
            return -1;
        }
    }
}
