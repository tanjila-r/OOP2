using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletBuddy.Model
{
  public class User
  {
    //properties
    public int UserId { set; get; }
    public string UserName { set; get; }
    public string UserEmail { set; get; }
    public string UserPassword { set; get; }
    public string UserType { set; get; }
    public byte[] Image { set; get; }

    //default constructor
    public User()
    {
      UserId = 0;
      UserName = "";
      UserEmail = "";
      UserPassword = "";
      UserType = "";
    }

    //param constructor
    public User(int userId, string userName, string userEmail, string userPassword, string userType)
    {
      UserId = userId;
      UserName = userName;
      UserEmail = userEmail;
      UserPassword = userPassword;
      UserType = userType;
    }

  }
}
