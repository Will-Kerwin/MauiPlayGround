using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMauiShell.Pages;
using TestMauiShell.ViewModels;

namespace TestMauiShell.Services
{
    public static class VMService
    {
        public static MauiAppBuilder ConfigureViewModels(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<AppShell>();
            builder.Services.AddSingleton<ShellViewModel>();
            builder.Services.AddSingleton<HomeViewModel>();
            builder.Services.AddSingleton<CounterViewModel>();

            return builder;
        }
    }
}
