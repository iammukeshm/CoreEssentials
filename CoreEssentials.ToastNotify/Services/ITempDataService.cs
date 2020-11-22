using System;
using System.Collections.Generic;
using System.Text;

namespace CoreEssentials.ToastNotify.Services
{
    public interface ITempDataService
    {
        /// <summary>
        /// Get the value of a given key from <see cref="ITempDataDictionary"/>
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        T Get<T>(string key) where T : class
;
        T Peek<T>(string key) where T : class
;
        void Add(string key, object value);
        /// <summary>
        /// Remove value with a given key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        bool Remove(string key);
    }
}
