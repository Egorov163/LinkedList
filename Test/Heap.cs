using System.Collections;
using System.Collections.Generic;

namespace Test
{
    public class Heap : IEnumerable
    {
        private List<int> items = new List<int>();
        public int Count => items.Count;

        public int? Peek()
        {
            if (Count > 0)
            {
                return items[0];
            }
            else
            {
                return null;
            }
        }

        public Heap() { }
        public Heap(List<int> items)
        {
            this.items.AddRange(items);
            for (int i = Count; i >= 0; i--)
            {
                Sort(i);
            }
        }

        public void Add(int item)
        {
            items.Add(item);

            var currentIndex = Count - 1;
            var parrentIndex = GetParrentIndex(currentIndex);

            while (currentIndex > 0 && items[parrentIndex] < items[currentIndex])
            {
                Swap(currentIndex, parrentIndex);

                currentIndex = parrentIndex;
                parrentIndex = GetParrentIndex(currentIndex);
            }
        }

        public int GetMax()
        {
            var result = items[0];
            items[0] = items[Count - 1];
            items.RemoveAt(Count - 1);
            Sort(0);
            return result;
        }

        private void Sort(int currentIndex)
        {
            int maxIndex = currentIndex;
            int leftIndex;
            int rightIndex;

            while (currentIndex < Count)
            {
                leftIndex = 2 * currentIndex + 1;
                rightIndex = 2 * currentIndex + 2;

                if (leftIndex < Count && items[leftIndex] > items[maxIndex])
                {
                    maxIndex = leftIndex;
                }

                if (rightIndex < Count && items[rightIndex] > items[maxIndex])
                {
                    maxIndex = rightIndex;
                }

                if (maxIndex == currentIndex)
                {
                    break;
                }

                Swap(currentIndex, maxIndex);
                currentIndex = maxIndex;
            }
        }

        private void Swap(int currentIndex, int parrentIndex)
        {
            var temp = items[currentIndex];
            items[currentIndex] = items[parrentIndex];
            items[parrentIndex] = temp;
        }

        private static int GetParrentIndex(int currentIndex)
        {
            return (currentIndex - 1) / 2;
        }

        public IEnumerator GetEnumerator()
        {
            while (Count > 0)
            {
                yield return GetMax();
            }
        }
    }
}
