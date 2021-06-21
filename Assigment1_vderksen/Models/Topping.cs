// Student name: Valentina Derksen
// Student id: vderksen
// Student number: 153803184

using System;
namespace Assigment1_vderksen.Models
{
    public class Topping
    {
        private string _toppingName;

        public string name 
        {
            get { return _toppingName; }
            set { _toppingName = value; }
        }

        public Topping(string n)
        {
            this._toppingName = n;
        }
    }
}
