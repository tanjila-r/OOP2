using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletBuddy.Model
{
  class Payment
  {
    //properties
    public int PaymentId { set; get; }
    public string UserName { set; get; }
    public string PaymentName { set; get; }
    public string PaymentReciever { set; get; }
    public string Description { set; get; }
    public int Amount { set; get; }
    public DateTime Date { set; get; }

    //default constructor
    //parameterized constructor
    public Payment()
    {
      PaymentId = 0;
      UserName = "";
      PaymentName = "";
      PaymentReciever = "";
      Description = "";
      Amount = 0;
      Date = DateTime.Now;
    }

    //parameterized constructor
    public Payment(int paymentId, string userName, string paymentName, string paymentReciever, string description, int amount, DateTime date)
    {
      PaymentId = paymentId;
      UserName = userName;
      PaymentName = paymentName;
      PaymentReciever = paymentReciever;
      Description = description;
      Amount = amount;
      Date = date;
    }
  }
}
