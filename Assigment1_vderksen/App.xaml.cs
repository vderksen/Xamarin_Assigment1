// Student name: Valentina Derksen
// Student id: vderksen
// Student number: 153803184

using System;
using Assigment1_vderksen.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assigment1_vderksen
{
    public partial class App : Application
    {
        Manager manager;

        public App()
        {
            InitializeComponent();
            manager = new Manager();
            MainPage = new NavigationPage(new MainPage(manager));
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
