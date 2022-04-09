using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBL.Dataclass
{
    class Consumer
    {
        public FBLer fblType = FBLer.Consumer;

        public Consumer() { }

        public void requestOrderSubmission() { }
        public void makeOrder() { }
        public void payForOrder() { }
        public void selectCarrier() { }
        public void selectDeliveryLocation() { }
        public void checkStatusOfOrder() { }
        public void pingCarrier() { }
    }
}
