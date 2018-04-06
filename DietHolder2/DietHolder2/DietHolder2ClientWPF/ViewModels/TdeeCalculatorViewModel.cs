using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using DietHolder2ClientWPF.Commands;
using DietHolder2ClientWPF.Interfaces;
using DietHolder2ClientWPF.Models;
using DietHolder2ClientWPF.Models.MediatorPattern;
using DietHolder2ClientWPF.ViewModels.Base;

namespace DietHolder2ClientWPF.ViewModels
{
    public class TdeeCalculatorViewModel : ViewModelBase
    {
        private readonly Person person;

        private string tdeeValue;
        public ICommand SayHi => new RelayCommand(GetTdeeValue, CanSayHiExcute);
        public CollectionView SomaticTypeEntries { get; }
        public CollectionView SexEntries { get; }
        public CollectionView DailyActivityEntries { get; }
        public CollectionView GoalToRealizeEntries { get; }
        public string TdeeValue
        {
            get { return tdeeValue; }
            set
            {
                tdeeValue = value;
                OnPropertyChanged("TdeeValue");
                MediatorSingleton.Instance.Register(new KeyValuePair<string, object>("TdeeValue", tdeeValue));
            }
        }
        public double Height
        {
            get
            {
                return person.Height;

            }
            set
            {
                person.Height = value;
                OnPropertyChanged("Height");
            }
        }
        public double Weight
        {
            get
            {
                return person.Weight;
            }
            set
            {
                person.Weight = value;
                OnPropertyChanged("Weight");
            }
        }
        public int Age
        {
            get
            {
                return person.Age;
            }
            set
            {
                person.Age = value;
                OnPropertyChanged("Age");
            }
        }
        public Sex Sex
        {
            get
            {
                return person.Sex;
            }
            set
            {
                person.Sex = value;
                OnPropertyChanged("Sex");
            }
        }
        public SomaticType SomaticType
        {
            get
            {
                return person.SomaticType;
            }
            set
            {
                person.SomaticType = value;
                OnPropertyChanged("SomaticType");
            }
        }
        public DailyActivity DailyActivity
        {
            get
            {
                return person.DailyActivity;
            }
            set
            {
                person.DailyActivity = value;
                OnPropertyChanged("DailyActivity");
            }
        }
        public GoalToRealize GoalToRealize
        {
            get
            {
                return person.GoalToRealize;
            }
            set
            {
                person.GoalToRealize = value;
                OnPropertyChanged("GoalToRealize");
            }
        }

        public TdeeCalculatorViewModel()
        {
            person = new Person
            {
                Age = 0,
                DailyActivity = DailyActivity.Low,
                GoalToRealize = GoalToRealize.WeightGain,
                Height = 0,
                Sex = Sex.Male,
                SomaticType = SomaticType.Ectomorphic,
                Weight = 0
            };

            var sexTypesList = new List<Sex>
            {
                Sex.Female,
                Sex.Male
            };
            SexEntries = new CollectionView(sexTypesList);

            var somaticTypesList = new List<SomaticType>
            {
                SomaticType.Ectomorphic,
                SomaticType.EndoMorphic,
                SomaticType.Mesomorphic
            };
            SomaticTypeEntries = new CollectionView(somaticTypesList);

            var dailyActivityEntriesList = new List<DailyActivity>
            {
                DailyActivity.Low,
                DailyActivity.Medium,
                DailyActivity.High,
                DailyActivity.VeryHigh
            };
            DailyActivityEntries = new CollectionView(dailyActivityEntriesList);

            var goalToRealizeList = new List<GoalToRealize>
            {
                GoalToRealize.WeightGain,
                GoalToRealize.WeightReduction
            };
            GoalToRealizeEntries = new CollectionView(goalToRealizeList);

        }
        private void GetTdeeValue()
        {
            if(!PersonExists(person))
            {
                TdeeValue = GetTdee(person);
                MessageBox.Show(TdeeValue.ToString(CultureInfo.InvariantCulture));
            }
            else
            {
                MessageBox.Show("Problem...");
            }

        }

        private static string GetTdee(IPerson person)
        {
            return CalculatorTdee.GetTdee(person);
        }

        private bool CanSayHiExcute()
        {
            return !PersonExists(person); //tutaj coś podziergać jeszcze
        }

        private static bool PersonExists(Person person)
        {
            //Some logic
            return false;
        }
    }
}
