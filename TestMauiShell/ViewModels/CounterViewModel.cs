using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMauiShell.ViewModels
{
    public class CounterViewModel : BindableObject
    {

        int count = 0;

        public int Count
        {
            get => count;
            set
            {
                if(count == value)
                    return;
                count = value;
                OnPropertyChanged();
            }
        }

        string counterLabel = "Current count: 0";

        public string CounterLabel
        { 
            get => counterLabel; 
            set
            {
                if (counterLabel == value)
                    return;
                counterLabel = value;
                OnPropertyChanged();
            }
        }

        public ICommand IncrementCountCommand { get; }
        public ICommand GoHomeCommand { get; }

        public CounterViewModel() {
            IncrementCountCommand = new Command(IncrementCount);
            GoHomeCommand = new Command(GoHome);
        }

        void IncrementCount() { 
            Count++; 
            CounterLabel = $"Current count: {count}";
            SemanticScreenReader.Announce(CounterLabel);
        }

        async void GoHome()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
