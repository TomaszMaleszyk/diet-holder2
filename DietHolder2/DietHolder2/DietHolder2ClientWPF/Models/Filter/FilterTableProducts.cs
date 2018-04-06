using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using DietHolder2ClientWPF.Interfaces;

namespace DietHolder2ClientWPF.Models.Filter
{
    public static class FilterTableProducts
    {
        public static List<IProduct> StartFiltration(List<IProduct> productsList,
                                                     List<KeyValuePair<FilterOperationKind, FilterOperationValue>> filtrationOperations, int recordsToGet)
        {
            var query = QueryCreator(filtrationOperations);
            productsList = productsList.OrderBy(query).Take(recordsToGet).ToList();
            return productsList;
        }

        private static string QueryCreator(IEnumerable<KeyValuePair<FilterOperationKind, FilterOperationValue>> filtrationOperations)
        {
            var query = "";
            var actualRow = 0;
            var keyValuePairs = filtrationOperations 
                                as IList<KeyValuePair<FilterOperationKind, FilterOperationValue>> ?? filtrationOperations.ToList(); //???
            foreach(var operation in keyValuePairs)
            {

                if(operation.Value == FilterOperationValue.Off)
                {
                    // usuwanie i nie dodawanie
                }

                switch(operation.Key)
                {
                    case FilterOperationKind.Carbo:
                        query += "ProductCarboValue";
                        break;
                    case FilterOperationKind.Protein:
                        query += "ProductProteinValue";
                        break;
                    case FilterOperationKind.Fat:
                        query += "ProductFatValue";
                        break;
                    case FilterOperationKind.Calories:
                        //   productsList = productsList.Where(x => x.ProductCarboValue > 0).OrderBy(x => x.).Take(recordsNumber).ToList(); // dać liczenie kcal
                        break;
                    case FilterOperationKind.Price:
                        query += "ProductPrice";
                        break;
                }

                if(operation.Value == FilterOperationValue.Max)
                {
                    query += " desc";
                }

                actualRow++;

                if(actualRow++ < keyValuePairs.ToList().Count)
                {
                    query += ", ";
                }
            }
            return query;
        }
    }
}
