using System.Net.Http;
using DietHolder2ClientWPF.Interfaces;

namespace DietHolder2ClientWPF.Models
{
    public static class CalculatorTdee
    {
        public static string GetTdee(IPerson person)
        {
            var postStatus = SendData(person);
            //            if(!postStatus.Equals(HttpStatusCode.OK.ToString()))      //poprawić
            //            {
            //                throw new ArgumentNullException();
            //            }

            return GetTdeeValue();
        }

        private static string SendData(IPerson person)
        {
            string result;
            using(var client = new HttpClient())
            {
                result = client.PostAsJsonAsync("http://localhost:61885/api/CalculatorTdee/", person).Result.Content
                    .ReadAsStringAsync().Result; //result nic nie oznacza - pusty string
            }
            return result ?? "Http client connection error";
        }
        private static string GetTdeeValue()//inna nazwa
        {
            using(var client = new HttpClient())
            {
                var tdeeValue = client.GetAsync("http://localhost:61885/api/CalculatorTdee/").Result.Content
                    .ReadAsStringAsync().Result;

//                double.TryParse(result, out tdeeValue);

                return tdeeValue;
            }
        }
    }
}
