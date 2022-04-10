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

        public void requestOrderSubmission() { } //requires API
        public void makeOrder() { }   //requires API
        public void payForOrder() { } //requires API
        public void selectCarrier() { }
        public void selectDeliveryLocation() { }
        public void checkStatusOfOrder() { }
        public void pingCarrier() { }
    }
}
