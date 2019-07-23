namespace HackerRank
{
    class PilesOfBoxes : IHackerRankContract
    {
        /// <summary>
        /// Gets the minimum steps required to moves the piles to the same height.
        /// </summary>
        /// <param name="data">Array of piles</param>
        /// <returns>Minimum steps</returns>
        public int GetMinimumSteps(int[] data)
        {
            int min = MinValue(data);
            int steps = 0;
            while (CheckHeight(data, min))
            {
                int secondLargestValue = SecodLargestNumber(data, data.Length);
                for (int i = 0; i < data.Length; i++)
                {
                    if (secondLargestValue < data[i])
                    {
                        data[i] = secondLargestValue;
                        steps++;
                    }
                }
            }
            return steps;
        }
        private int SecodLargestNumber(int[] arr, int arr_size)
        {
            int i, first, second;
            first = second = int.MinValue;
            for (i = 0; i < arr_size; i++)
            {
                if (arr[i] > first)
                {
                    second = first;
                    first = arr[i];
                }
                else if (arr[i] > second && arr[i] != first)
                    second = arr[i];
            }
            return second;
        }
        private bool CheckHeight(int[] data, int minValue)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] != minValue)
                    return true;
            }
            return false;
        }
        private int MinValue(int[] data)
        {
            int min = int.MaxValue;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < min)
                    min = data[i];
            }
            return min;
        }
    }
}
