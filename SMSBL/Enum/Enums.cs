using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSBL.Enum
{
    public enum Status
    {
        Active = 1,
        Passive = 2,
        Block = 3,
        Sold = 4,
        ReturnRequest = 5,
        ReturnApproved = 6,
        Pending = 7,
        Received = 8,
        Forwarded = 9,
        Canceled = 10,
        ReturnCancel = 11
    }
    public enum SMSError : int
    {
        SUCCESS = 0,

        Exception_Caught = -1,
        Unauthenticated_User = -2,
        Access_Denied = -3,

        User_Not_Logged_In = -6401,
        Login_Token_Not_Exist = -6402,

        User_Login_Not_Exist = -6101,
        User_Login_ID_Not_Exist = -6102,
        User_Login_Already_Exist = -6103,
        User_Login_ID_Already_Exist = -6104,
        Incorrect_Login_Password = -6105,
        Invalid_Login_Account_Status = -6106,
        Account_Disabled = -6107,

        Invalid_Product_Face_Value = -7101,
        No_stock_for_this_product_is_available = -7102,
        No_Stock_Found = 99999,
        unKnown_Exception_Found = 88888
    }

}
