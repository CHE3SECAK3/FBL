using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBL.Dataclass
{
    class Carrier
    {
        FBLer fblType = FBLer.Carrier;

        public Carrier() { }

        public void requestOrderValidation() { }
        public void receiveOrder() { }
        public void updateStatusOfOrder() { }
        public void receivePayment() { }
        public void checkStatusOfOrder() { }
        public void pingConsumer() { }
        public void clockIn() { }
        public void clockOut() { }
        public void receiveLocationOfDelivery() { }
    }
}
