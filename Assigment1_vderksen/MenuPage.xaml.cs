// Student name: Valentina Derksen
// Student id: vderksen
// Student number: 153803184

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Assigment1_vderksen.Models;
using Xamarin.Forms;

namespace Assigment1_vderksen
{
    public partial class MenuPage : ContentPage
    {
        Manager manager;

        public MenuPage(Manager m)
        {
            InitializeComponent();
            manager = m;
        }

        // NAVIGATION TO MY CURRENT ORDER PAGE
        async void currentOrderView(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MyOrder(manager));
        }

        // NAVIGATION TO UPDATE ORDER PAGE
        async void updateCurrentOrder(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MainPage(manager));
        }

        // NAVIGATION TO PREVIOUS ORDER PAGE
        async void previousOrderView(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new PreviousOrder(manager));
        }

        // NAVIGATION TO NEW ORDER PAGE
        async void newOrderView(System.Object sender, System.EventArgs e)
        {
            // reset the current order to empty state
            manager.resetOrder();

            // navigate to main page
            await Navigation.PushAsync(new MainPage(manager));
        }
    }
}
