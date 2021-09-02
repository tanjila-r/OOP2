using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletBuddy.Model
{
  class Income
  {
    //Properties
    public int TransactionId { set; get; }
    public string UserName { set; get; }
    public int Amount { set; get; }
    public string PaymentFrom { set; get; }
    public string Description { set; get; }
    public string AccountName { set; get; }
    public DateTime Date { set; get; }

    //default constructor
    public Income()
    {
      TransactionId = 0;
      UserName = "";
      Amount = 0;
      PaymentFrom = "";
      Description = "";
      AccountName = "";
      Date = DateTime.Now;
    }

    //parameterized constructor
    public Income(int transactionId, string userName, int amount, string paymentFrom, string description, string accountName, DateTime date)
    {
      TransactionId = transactionId;
      UserName = userName;
      Amount = amount;
      PaymentFrom = paymentFrom;
      Description = description;
      AccountName = accountName;
      Date = date;
    }
  }
}
