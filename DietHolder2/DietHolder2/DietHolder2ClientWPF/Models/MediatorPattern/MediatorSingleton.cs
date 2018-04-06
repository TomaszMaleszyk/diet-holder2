using System;
using System.Collections.Generic;
using System.Linq;

namespace DietHolder2ClientWPF.Models.MediatorPattern
{
    public class MediatorSingleton
    {
        private static IDictionary<string, object> properties;
        private static MediatorSingleton instance;
        public static MediatorSingleton Instance => instance ?? (instance = new MediatorSingleton());


        private MediatorSingleton()
        {
            properties = new Dictionary<string, object>();
        }
        static MediatorSingleton() { }


        public void Register(KeyValuePair<string, object> data)
        {
            if(!properties.ContainsKey(data.Key))
            {
                properties.Add(data.Key, data.Value);
            }
            else
            { 
                properties[data.Key] = data.Value;
            }
        }
        public void Unregister(string token)
        {
            if(properties.ContainsKey(token))
            {
                properties.Remove(properties.First(x => x.Key == token));
            }
        }
        public object GetPropertyValue(string token)
        {
            if(!properties.ContainsKey(token))
                return null;

            var result = properties[token];
            return result;
        }
    }
}
