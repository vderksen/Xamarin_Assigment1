// Student name: Valentina Derksen
// Student id: vderksen
// Student number: 153803184

using System;
namespace Assigment1_vderksen.Models
{
    public class OrderInfo
    {
        double _totalSum;
        DateTime _orderPlaced;
        string _orderDate;
        string _orderSum;

        public double totalSum
        {
            get { return _totalSum; }
            set { _totalSum = value; }
        }

        public DateTime orderPlaced
        {
            get { return _orderPlaced; }
            set { _orderPlaced = value; }
        }

        public string orderDate
        {
            get { return _orderDate; }
            set { _orderDate = value; }
        }

        public string orderSum
        {
            get { return _orderSum; }
            set { _orderSum = value; }
        }

        public OrderInfo()
        {
            totalSum = 0;
            orderSum = "$ " + totalSum;
            this.orderPlaced = DateTime.Now;
            this.orderDate = orderPlaced.ToString("MM/dd/yyyy HH:mm");
        }

        public OrderInfo(double total)
        {
            this.totalSum = total;
            orderSum = "$" + totalSum;
            this.orderPlaced = DateTime.Now;
            this.orderDate = orderPlaced.ToString("MM/dd/yyyy HH:mm");
        }
    }
}
