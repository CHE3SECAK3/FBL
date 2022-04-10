
namespace FBL.Dataclass
{
    class Carrier
    {
        FBLer fblType = FBLer.Carrier;
        private bool status;

        public Carrier() { }

        public void requestOrderValidation() { } //needs API
        public void receiveOrder() { }
        public void updateStatusOfOrder() { }
        public void receivePayment() { }
        public void checkStatusOfOrder() { }  //needs API
        public void pingConsumer() { }
        public void clockIn() { status = true; }
        public void clockOut() { status = false; }
        public void receiveLocationOfDelivery() { }
        public bool getStatus()
        {
            return this.status;
        }
    }
}
