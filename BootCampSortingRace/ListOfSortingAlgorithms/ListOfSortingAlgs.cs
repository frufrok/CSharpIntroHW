namespace ListOfSortingAlgorithms
{
    public class ListOfSortingAlgs
    {
        static void Swap(ref int val1, ref int val2)
        {
            int temp = val1;
            val1 = val2;
            val2 = temp;
        }

        static int GetPivotIndex(int[] array, int left, int rigth)
        {
            int pivot = left - 1;
            for (int i = left; i <= rigth; i++)
            {
                if (array[i] < array[rigth])
                {
                    pivot++;
                    Swap(ref array[i], ref array[pivot]);
                }
            }
            pivot++;
            Swap(ref array[pivot], ref array[rigth]);
            return pivot;
        }

        static void QuickSortRec(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex) return;
            else
            {
                int pivot = GetPivotIndex(array, minIndex, maxIndex);
                QuickSortRec(array, minIndex, pivot - 1);
                QuickSortRec(array, pivot + 1, maxIndex);
            }
        }

        public static void QickSort(int[] array)
        {
            QuickSortRec(array, 0, array.Length - 1);
        }

        public static void BubbleSort(int[] array)
        {
            int count = array.Length;
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count - 1 - i; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }

        public static void SelectionSort(int[] array)
        {
            int count = array.Length;
            for (int i = 0; i < count - 1; i++)
            {
                int min = i;
                for (int j = i+1; j<count; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                Swap(ref array[min], ref array[i]);
            }
        }

        public static void CountingSort(int[] array)
        {
            // Поиск минимального и максимального значений
            var min = array[0];
            var max = array[0];
            foreach(int value in array)
            {
                if (value > max) max = value;
                else if (value < min) min = value;
            }

            // Поправка
            var correctionValue = min != 0 ? -min : 0;
            max += correctionValue;

            var count = new int[max + 1];
            int length = array.Length;
            for (int i = 0; i<length; i++)
            {
                count[array[i] + correctionValue]++;
            }
            int index = 0;            
            for (int i = 0; i<length; i++)
            {
                for (int j = 0; j < count[i]; j++)
                {
                    array[index] = i - correctionValue;
                    index++;
                }
            }
        }

        public static void ShakerSort(int[] array)
        {
            int left = 0,
                right = array.Length - 1,
                count = 0;

            while(left<right)
            {
                for (int i = left; i < right; i++)
                {
                    count++;
                    if (array[i] > array[i + 1])
                        Swap(ref array[i], ref array[i + 1]);
                }
                right--;

                for (int i = right; i>left; i--)
                {
                    count++;
                    if (array[i - 1] > array[i])
                        Swap(ref array[i - 1], ref array[i]);
                }
                left++;
            }
        }
    }
}