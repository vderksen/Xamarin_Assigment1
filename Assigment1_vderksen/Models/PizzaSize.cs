// Student name: Valentina Derksen
// Student id: vderksen
// Student number: 153803184

using System;
namespace Assigment1_vderksen.Models
{
    public class PizzaSize
    {
        private string _sizeName;

        public string name 
        {
            get { return _sizeName; }
            set { _sizeName = value; }
        }

        public PizzaSize(string n)
        {
            this._sizeName = n;
        }
    }
}
