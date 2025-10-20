using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    public class Dict<TKey, TValue> : IEnumerable
    {
        private int size = 100;
        private Item<TKey, TValue>[] Items;
        private List<TKey> Keys = new List<TKey>();

        public Dict()
        {
            Items = new Item<TKey, TValue>[size];
        }

        public void Add(Item<TKey, TValue> item)
        {
            var hash = GetHash(item.Key);

            if (Keys.Contains(item.Key))
            {
                return;
            }

            if (Items[hash] == null)
            {
                Keys.Add(item.Key);
                Items[hash] = item;
            }
            else
            {
                var placed = false;

                for (int i = hash; i < size; i++)
                {
                    if (Items[i] == null)
                    {
                        Keys.Add(item.Key);
                        Items[i] = item;
                        placed = true;
                        break;
                    }

                    if (Equals(Items[i].Key, item.Key))
                    {
                        return;
                    }
                }

                if (!placed)
                {
                    for (int i = 0; i < hash; i++)
                    {
                        if (Items[i] == null)
                        {
                            Keys.Add(item.Key);
                            Items[i] = item;
                            placed = true;
                            break;
                        }

                        if (Equals(Items[i].Key, item.Key))
                        {
                            return;
                        }
                    }
                }

                if (!placed)
                {
                    throw new Exception("Словарь заполнен");
                }
            }
        }
        public void Remove(TKey key)
        {
            var hash = GetHash(key);

            if (!Keys.Contains(key))
            {
                return;
            }

            if (Items[hash] == null)
            {
                for (int i = 0; i < size; i++)
                {
                    if (Items[i] != null &&  Equals(Items[i].Key, key))
                    {
                        Items[i] = null;
                        Keys.Remove(key);
                        return;
                    }
                }
            }

            if (Equals(Items[hash].Key, key))
            {
                Items[hash] = null;
                Keys.Remove(key);
            }
            else
            {
                var placed = false;

                for (int i = hash; i < size; i++)
                {
                    if (Items[i] == null)
                    {
                        return;
                    }

                    if (Equals(Items[i].Key, key))
                    {
                        Items[i] = null;
                        Keys.Remove(key);
                        return;
                    }
                }

                if (!placed)
                {
                    for (int i = 0; i < hash; i++)
                    {
                        if (Items[i] == null)
                        {
                            return;
                        }

                        if (Equals(Items[i].Key, key))
                        {
                            Items[i] = null;
                            Keys.Remove(key);
                            return;
                        }
                    }
                }
            }
        }
        public TValue Search(TKey key)
        {
            var hash = GetHash(key);

            if (!Keys.Contains(key))
            {
                return default(TValue);
            }

            if (Items[hash] == null)
            {
                foreach (var item in Items)
                {
                    if (Equals(item.Key, key))
                    {
                        return item.Value;
                    }
                }

                return default(TValue);
            }

            if (Equals(Items[hash].Key, key))
            {
                return Items[hash].Value;
            }
            else
            {
                var placed = false;

                for (int i = hash; i < size; i++)
                {
                    if (Items[i] == null)
                    {
                        return default(TValue);
                    }

                    if (Equals(Items[i].Key, key))
                    {
                        return Items[i].Value;
                    }
                }

                if (!placed)
                {
                    for (int i = 0; i < hash; i++)
                    {
                        if (Items[i] == null)
                        {
                            return default(TValue);
                        }

                        if (Equals(Items[i].Key, key))
                        {
                            return Items[i].Value;
                        }
                    }
                }
            }

            return default(TValue);
        }
        private int GetHash(TKey key)
        {
            return key.GetHashCode() % size;
        }
        public IEnumerator GetEnumerator()
        {
            foreach (var item in Items)
            {
                if (item != null)
                {
                    yield return item;
                }
            }
        }
    }
}
