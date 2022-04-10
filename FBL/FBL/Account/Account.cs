using FBL.Dataclass;

namespace FBL.Account
{
    class Account
    {
        public FBLer accType { get; set; }
        public (string, string) Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int PhoneNumber { get; set; }
        public string DefaultDeliveryLocation { get; set; }
        public bool IsSubscribed { get; set; }
        public dynamic PaymentMethod { get; set; } // TODO
        public decimal balance { get; set; }

        public Account((string, string) name, string username, string password, int phoneNumber)
            => (Name, Username, Password, PhoneNumber) = (name, username, password, phoneNumber);
        public void buySubscription() { }
        public void changeUsername(string newUserName) { }
        public void addToBalance(decimal balance) { }
    }
}
