using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BL.Enum
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
}
