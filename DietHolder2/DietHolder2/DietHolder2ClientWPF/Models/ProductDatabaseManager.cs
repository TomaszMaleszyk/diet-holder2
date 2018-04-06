using System;
using System.Collections.Generic;
using System.Net.Http;
using DietHolder2ClientWPF.Interfaces;
using Newtonsoft.Json;

namespace DietHolder2ClientWPF.Models
{
    public class ProductDatabaseManager : IProductDatabaseManager
    {
        public IEnumerable<IProduct> GetAll()
        {
            using(var client = new HttpClient())
            {
                var response = client.GetAsync("http://localhost:61885/api/Products/").Result;

                if(response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<IEnumerable<Product>>(content);
                }
            }
           throw ErrorMessage();
        }

        public Product GetSingle(int id)
        {
            using(var client = new HttpClient())
            {
                var response = client.GetAsync($"http://localhost:61885/api/Products/{id}").Result;

                if(response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<Product>(content);
                }
            }
            throw ErrorMessage();
        }

        public string Put()
        {
            throw new NotImplementedException();
        }

        public string Post(IProduct product)
        {
            string result;
            using(var client = new HttpClient())
            {
                result = client.PostAsJsonAsync("http://localhost:61885/api/Products/", product).Result.Content
                    .ReadAsStringAsync().Result;
            }
            return result ?? "Http client connection error";
            //            if(result != null)
            //            {
            //                return result;
            //            }
            //            return "Http client connection error";
        }

        public string Delete(int id)
        {
            string result;
            using(var client = new HttpClient())
            {
                result = client.DeleteAsync($"http://localhost:61885/api/Products/{id}").Result.Content
                    .ReadAsStringAsync().Result;
            }
            return result ?? "Http client connection error"; // czy ten if potrzebny
        }

        private static Exception ErrorMessage()
        {
            throw new Exception("Something goes wrong"); //tutaj uściślić o co chodzi
        }
    }
}
