using System;
using System.Collections.Generic;

namespace GolfNow.Mobile.API.Utilities
{
    // TODO: This should be implemented to lookup from a token store cache

    /// <summary>
    /// Implements a customer token store as a dictionary.  
    /// </summary>
    public class CustomerTokenStore : IDictionary<string, string>
    {
        private IDictionary<string, string> _dictionary = new Dictionary<string, string>(StringComparer.CurrentCultureIgnoreCase);

        public ICollection<string> Keys
        {
            get
            {
                return this._dictionary.Keys;
            }
        }

        public ICollection<string> Values
        {
            get
            {
                return this._dictionary.Values;
            }
        }

        public int Count
        {
            get
            {
                return this._dictionary.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return this._dictionary.IsReadOnly;
            }
        }

        public string this[string key]
        {
            get
            {
                return this._dictionary[key];
            }
            set
            {
                this._dictionary[key] = value;
            }
        }

        public void Add(string key, string value)
        {
            this._dictionary.Add(key, value);
        }

        public bool ContainsKey(string key)
        {
            return this._dictionary.ContainsKey(key);
        }

        public bool Remove(string key)
        {
            return this._dictionary.Remove(key);
        }

        public bool TryGetValue(string key, out string value)
        {
            return this._dictionary.TryGetValue(key, out value);
        }

        public void Add(KeyValuePair<string, string> item)
        {
            this._dictionary.Add(item);
        }

        public void Clear()
        {
            this._dictionary.Clear();
        }

        public bool Contains(KeyValuePair<string, string> item)
        {
            return this._dictionary.Contains(item);
        }

        public void CopyTo(KeyValuePair<string, string>[] array, int arrayIndex)
        {
            this._dictionary.CopyTo(array, arrayIndex);
        }

        public bool Remove(KeyValuePair<string, string> item)
        {
            return this._dictionary.Remove(item);
        }

        IEnumerator<KeyValuePair<string, string>> IEnumerable<KeyValuePair<string, string>>.GetEnumerator()
        {
            return this._dictionary.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this._dictionary.GetEnumerator();
        }
    }
}