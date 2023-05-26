namespace AlgorithmsTestProject
{
    public static class ArraySortProblems
    {
        public static void MySort1(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        ArrayProblems.Swap(array, i, j);
                    }
                }
            }
        }

        public static void MySort2(int[] array)
        {
            var current = array.ToList();
            var result = new List<int>();
            while (current.Count > 0)
            {
                var x = current.Min();
                result.Add(x);
                current.Remove(x);
            }
            result.CopyTo(array);
        }

        public static void MergeSort(int[] array)
        {
            if (array.Length < 2)
                return;
            var min = array[0];
            var max = array[0];
            foreach (var item in array)
            {
                if (item < min)
                    min = item;
                if (item > max)
                    max = item;
            }
            var counts = new int[max - min + 1];
            foreach (var item in array)
                counts[item - min]++;
            var index = 0;
            for (var i = 0; i < counts.Length; i++)
            {
                for (var j = 0; j < counts[i]; j++)
                {
                    array[index] = i + min;
                    index++;
                }
            }
        }

        public static void HeapSort(int[] array)
        {
            if (array.Length < 2)
                return;
            var min = array[0];
            var max = array[0];
            foreach (var item in array)
            {
                if (item < min)
                    min = item;
                if (item > max)
                    max = item;
            }
            var counts = new int[max - min + 1];
            foreach (var item in array)
                counts[item - min]++;
            var index = 0;
            for (var i = 0; i < counts.Length; i++)
            {
                for (var j = 0; j < counts[i]; j++)
                {
                    array[index] = i + min;
                    index++;
                }
            }
        }

        public static void BubbleSort(int[] array)
        {
            bool swapped;
            var n = array.Length;
            do
            {
                swapped = false;

                for (var i = 1; i < n; ++i)
                {
                    if (array[i - 1] > array[i])
                    {
                        ArrayProblems.Swap(array, i-1, i);
                        swapped = true;
                    }
                }

                --n;
            } 
            while (swapped && n > 0);
        }

        public static void ShuffleSort(int[] array)
        {
            if (array.Length < 2)
                return;
            var min = array[0];
            var max = array[0];
            foreach (var item in array)
            {
                if (item < min)
                    min = item;
                if (item > max)
                    max = item;
            }
            var counts = new int[max - min + 1];
            foreach (var item in array)
                counts[item - min]++;
            var index = 0;
            for (var i = 0; i < counts.Length; i++)
            {
                for (var j = 0; j < counts[i]; j++)
                {
                    array[index] = i + min;
                    index++;
                }
            }
        }

        public static void IntroSort(int[] array)
        {
            if (array.Length < 2)
                return;
            var min = array[0];
            var max = array[0];
            foreach (var item in array)
            {
                if (item < min)
                    min = item;
                if (item > max)
                    max = item;
            }
            var counts = new int[max - min + 1];
            foreach (var item in array)
                counts[item - min]++;
            var index = 0;
            for (var i = 0; i < counts.Length; i++)
            {
                for (var j = 0; j < counts[i]; j++)
                {
                    array[index] = i + min;
                    index++;
                }
            }
        }

        public static void CocktailSort(int[] array)
        {
            if (array.Length < 2)
                return;
            var min = array[0];
            var max = array[0];
            foreach (var item in array)
            {
                if (item < min)
                    min = item;
                if (item > max)
                    max = item;
            }
            var counts = new int[max - min + 1];
            foreach (var item in array)
                counts[item - min]++;
            var index = 0;
            for (var i = 0; i < counts.Length; i++)
            {
                for (var j = 0; j < counts[i]; j++)
                {
                    array[index] = i + min;
                    index++;
                }
            }
        }

        public static void QuickSort(int[] array)
        {
            if (array.Length < 2)
                return;
            var min = array[0];
            var max = array[0];
            foreach (var item in array)
            {
                if (item < min)
                    min = item;
                if (item > max)
                    max = item;
            }
            var counts = new int[max - min + 1];
            foreach (var item in array)
                counts[item - min]++;
            var index = 0;
            for (var i = 0; i < counts.Length; i++)
            {
                for (var j = 0; j < counts[i]; j++)
                {
                    array[index] = i + min;
                    index++;
                }
            }
        }

        public static void BlockSort(int[] array)
        {
            if (array.Length < 2)
                return;
            var min = array[0];
            var max = array[0];
            foreach (var item in array)
            {
                if (item < min)
                    min = item;
                if (item > max)
                    max = item;
            }
            var counts = new int[max - min + 1];
            foreach (var item in array)
                counts[item - min]++;
            var index = 0;
            for (var i = 0; i < counts.Length; i++)
            {
                for (var j = 0; j < counts[i]; j++)
                {
                    array[index] = i + min;
                    index++;
                }
            }
        }

        public static void BogoSort(int[] array)
        {
            if (array.Length < 2)
                return;
            var min = array[0];
            var max = array[0];
            foreach (var item in array)
            {
                if (item < min)
                    min = item;
                if (item > max)
                    max = item;
            }
            var counts = new int[max - min + 1];
            foreach (var item in array)
                counts[item - min]++;
            var index = 0;
            for (var i = 0; i < counts.Length; i++)
            {
                for (var j = 0; j < counts[i]; j++)
                {
                    array[index] = i + min;
                    index++;
                }
            }
        }

        public static void DoNothingSort(int[] array)
        {
        }

        public static void EvilSort(int[] array)
        {
            Array.Fill(array, 0);
        }

        public static void GnomeSort(int[] array)
        {
            var position = 0;
            while (position < array.Length) 
            {
                if (position == 0 || array[position] >= array[position - 1])
                {
                    position += 1;
                }
                else {
                    ArrayProblems.Swap(array, position, position - 1);
                    position -= 1;
                }
            }
        }

        public static void SelectionSort(int[] array)
        {
            // /* a[0] to a[aLength-1] is the array to sort */
            // int i,j;
            // int aLength; // initialise to a's length
            // 
            // /* advance the position through the entire array */
            // /*   (could do i < aLength-1 because single element is also min element) */
            // for (i = 0; i < aLength-1; i++)
            // {
            //     /* find the min element in the unsorted a[i .. aLength-1] */
            // 
            //     /* assume the min is the first element */
            //     int jMin = i;
            //     /* test against elements after i to find the smallest */
            //     for (j = i+1; j < aLength; j++)
            //     {
            //         /* if this element is less, then it is the new minimum */
            //         if (a[j] < a[jMin])
            //         {
            //             /* found new minimum; remember its index */
            //             jMin = j;
            //         }
            //     }
            // 
            //     if (jMin != i) 
            //     {
            //         swap(a[i], a[jMin]);
            //     }
            // }

            if (array.Length < 1)
            {
                throw new IndexOutOfRangeException();
            }
            else {
                var min = array[0];
                var max = array[0];
                foreach (var item in array)
                {
                    if (item < min)
                        min = item;
                    if (item > max)
                        max = item;
                }
                var counts = new int[max - min + 1];
                foreach (var item in array)
                    counts[item - min]++;
                var index = 0;
                for (var i = 0; i < counts.Length; i++)
                {
                    for (var j = 0; j < counts[i]; j++)
                    {
                        array[index] = i + min;
                        index++;
                    }
                }
            }
        }
    }
}