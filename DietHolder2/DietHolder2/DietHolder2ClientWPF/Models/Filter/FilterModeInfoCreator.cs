using System;
using System.Collections.Generic;

namespace DietHolder2ClientWPF.Models.Filter
{
    public enum FilterOperationValue
    {
        Off,
        Max,
        Average,
        Min
    }
    public enum FilterOperationKind
    {
        Carbo,
        Protein,
        Fat,
        Calories,
        Price
    }

    public class FilterModeInfoCreator
    {
        private string modeInformations;

        public FilterModeInfoCreator()
        {
            modeInformations = "";
        }

        public string UpdateSummary(KeyValuePair<FilterOperationKind, FilterOperationValue> filter)
        {
            if(filter.Value.Equals(null))
            {
                goto Here;
            }

            if(modeInformations.Contains(filter.Key.ToString()))
            {
                var filterKeyPosition = modeInformations.IndexOf(filter.Key.ToString(), 0, StringComparison.Ordinal) + filter.Key.ToString().Length;
                filterKeyPosition++;
                modeInformations = modeInformations.Remove(filterKeyPosition, filter.Value.ToString().Length);

                if(filter.Value.Equals(FilterOperationValue.Off))
                {
                    filterKeyPosition--;
                    modeInformations = modeInformations.Remove(filterKeyPosition - filter.Key.ToString().Length, filter.Key.ToString().Length + 1);
                    goto Here;
                }

                modeInformations = modeInformations.Insert(filterKeyPosition, filter.Value.ToString());
            }


            modeInformations += $" {filter.Key.ToString()} {filter.Value}";

            Here:
            return modeInformations;
        }
    }
}
