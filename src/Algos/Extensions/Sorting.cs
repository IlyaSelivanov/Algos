namespace Algos.Algorithmes
{
    public static class Sorting
    {
        public static T[] InsertionSortAsc<T>(this T[] array)
            where T : IComparable
        {
            for (int i = 1; i < array.Count(); i++)
            {
                var key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j].CompareTo(key) > 0)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }

                array[j + 1] = key;
            }

            return array;
        }

        public static T[] InsertionSortDesc<T>(this T[] array)
            where T : IComparable
        {
            for (int i = 1; i < array.Count(); i++)
            {
                var key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j].CompareTo(key) < 0)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }

                array[j + 1] = key;
            }

            return array;
        }

        public static T[] SelectionSortAsc<T>(this T[] array)
            where T : IComparable
        {
            for(int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                int j = i + 1;

                while(j < array.Length)
                {
                    if(array[j].CompareTo(array[i]) < 0)
                        minIndex = j;
                }

                var tmp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = tmp;
            }

            return array;
        }

        public static T[] SelectionSortDesc<T>(this T[] array)
            where T : IComparable
        {
            for(int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                int j = i + 1;

                while(j < array.Length)
                {
                    if(array[j].CompareTo(array[i]) > 0)
                        minIndex = j;
                }

                var tmp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = tmp;
            }

            return array;
        }
    }
}