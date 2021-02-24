namespace DataStructuresAndAlgorithms.Algorithms.SortingAlgorithms
{
    public class InsertionSort : ISortingAlgorithm
    {
        public int[] Sort(int[] arrayToBeSorted) //int dizinin sıralanması
        {
            for (int i = 1; i < arrayToBeSorted.Length; i++)
            {
                int key = arrayToBeSorted[i];

                int j = i - 1;

                while (j >= 0 && key < arrayToBeSorted[j])
                {
                    arrayToBeSorted[j + 1] = arrayToBeSorted[j];
                    j--;
                }

                arrayToBeSorted[j + 1] = key;
            }

            return arrayToBeSorted;
        }

        public string[] Sort(string[] arrayToBeSorted) //string dizinin sıralanması
        {
            for (int i = 1; i < arrayToBeSorted.Length; i++)
            {
                string key = arrayToBeSorted[i];

                int j = i - 1;

                while (j >= 0 && key.IsLower(arrayToBeSorted[j]))
                {
                    arrayToBeSorted[j + 1] = arrayToBeSorted[j];
                    j--;
                }

                arrayToBeSorted[j + 1] = key;
            }

            return arrayToBeSorted;
        }
    }
}
