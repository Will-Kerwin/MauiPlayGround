using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMauiShell.ViewModels
{
    public class HomeViewModel
    {

        public ICommand NavigateCounterCommand { get; }
        public HomeViewModel() {

            NavigateCounterCommand = new Command(NavigateToCounter);
        }

        async void NavigateToCounter()
        {
            await Shell.Current.GoToAsync($"{nameof(CounterPage)}");
        }
    }
}
