// Student name: Valentina Derksen
// Student id: vderksen
// Student number: 153803184

using System;
using System.Collections.Generic;
using Assigment1_vderksen.Models;
using Xamarin.Forms;

namespace Assigment1_vderksen
{
    public partial class PreviousOrder : ContentPage
    {
        Manager manager;

        public PreviousOrder(Manager m)
        {
            InitializeComponent();
            manager = m;
            ordersList.ItemsSource = manager.History; // initialize list view and bind it to the collection of Orders History
        }
    }
}
