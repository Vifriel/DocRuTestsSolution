namespace DocRuTests
{
    public class PyramidOfNumbers
    {
        public int[][] Pyramid { get; private set; } = new int[5][];

        public PyramidOfNumbers()
        {
            Pyramid[0] = new int[] { 1 };
            Pyramid[1] = new int[] {3, 5};
            Pyramid[2] = new int[] {7, 9, 11};
            Pyramid[3] = new int[] {13, 15, 17, 19};
            Pyramid[4] = new int[] {21, 23, 25, 27, 29};
        }

        public int GetSumOfTheSpecificFloor(int floorNumber)
        {
            int actualIndex = floorNumber - 1;
            if (actualIndex < 0 || actualIndex > this.Pyramid.Length)
            {
                throw new IndexOutOfRangeException();
            }

            return this.Pyramid[actualIndex].Sum();
        }
    }
}
