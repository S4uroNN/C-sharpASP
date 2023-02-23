using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion3_Værksted
{
    internal class MedarbejderCollection<TKey>
    {
        private readonly Dictionary<TKey, IHarAdresse> _collection = new Dictionary<TKey, IHarAdresse>();

        public void AddElement(TKey k, IHarAdresse a)
        {
            if (!_collection.ContainsKey(k))
            {
                _collection.Add(k, a);
            } else
            {
                throw new Exception("Key findes allerede");
            }
        }

        public IHarAdresse GetElement(TKey k)
        {
            IHarAdresse result = null;

            if (_collection.ContainsKey(k))
            {
                result = _collection[k];
            }
            return result;
        }

        public int Size()
        {
            return _collection.Count;
        }

    }
}
