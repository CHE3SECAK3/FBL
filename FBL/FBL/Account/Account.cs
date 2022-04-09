using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBL.Account
{
    class Account
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int PhoneNumber { get; set; }
        public string DefaultDeliveryLocation { get; set; }
        public bool IsSubscribed { get; set; }
        public dynamic PaymentMethod { get; set; } // TODO


    }
}
