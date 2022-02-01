using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMauiShell.Models;
using TestMauiShell.Pages;

namespace TestMauiShell.ViewModels
{
    public class ShellViewModel
    {
        public AppSection Home { get; set; }
        public AppSection Counter { get; set; }

        public ShellViewModel()
        {
            Home = new AppSection() { Title = "Home",TargetType = typeof(HomePage)};
            Counter = new AppSection() { Title = "Counter", TargetType = typeof(CounterPage)};
        }
    }
}
