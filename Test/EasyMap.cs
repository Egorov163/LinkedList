using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    public class EasyMap<TKey, TValue> : IEnumerable
    {
        private List<Item<TKey, TValue>> Items = new List<Item<TKey, TValue>>();
        private List<TKey> Keys = new List<TKey>();

        public int Count => Items.Count;

        public EasyMap()
        {

        }

        public void Add(Item<TKey, TValue> item)
        {
            if (!Keys.Contains(item.Key))
            {
                Keys.Add(item.Key);
                Items.Add(item);
            }
        }
        public TValue Search(TKey key)
        {
            if (Keys.Contains(key))
            {
                return Items.Single(i => Equals(i.Key, key)).Value;
            }

            // Или исключение
            return default(TValue);
        }
        public void Remove(TKey key)
        {
            if (Keys.Contains(key))
            {
                Items.Remove(Items.Single(i => Equals(i.Key, key)));
                Keys.Remove(key);
            }
        }

        public IEnumerator GetEnumerator()
        {
            return Items.GetEnumerator();
        }
    }
}
