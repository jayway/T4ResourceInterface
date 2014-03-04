using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringResourceDemo.UnitTest
{
    using Services;

    class TestKeyValueStore : IKeyValueStore
    {
        private readonly Dictionary<string, object> _storage = new Dictionary<string, object>();

        public T GetValue<T>(string key, T defaultValue)
        {
            return _storage.ContainsKey(key) ? (T)_storage[key] : defaultValue;
        }

        public void SetValue<T>(string key, T value)
        {
            _storage[key] = value;
        }
    }
}
