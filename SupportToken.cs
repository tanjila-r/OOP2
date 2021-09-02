using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletBuddy.Model
{
  class SupportToken
  {
    //properties
    public int TokenId { set; get; }
    public string SenderName { set; get; }
    public string SenderEmail { set; get; }
    public string Description { set; get; }
    public string Status { set; get; }

    //Default constructor
    public SupportToken()
    {
      TokenId = 0;
      SenderName = "";
      SenderEmail = "";
      Description = "";
      Status = "";
    }

    //Paremeterized constructor
    public SupportToken(int tokenId, string senderName, string senderEmail, string description, string status)
    {
      TokenId = tokenId;
      SenderName = senderName;
      SenderEmail = senderEmail;
      Description = description;
      Status = status;
    }
  }
}
