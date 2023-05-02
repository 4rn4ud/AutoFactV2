namespace AutoFact2.Views
{
    class Moral : Customer
    {
        private string _companyName;

        public Moral(int id, string companyName, string address, string postalCode, string city, string mail, string tel) : base(id, address, postalCode, city, mail, tel)
        {
            this._companyName = companyName;
        }

        public string GetCompanyName()
        {
            return _companyName;
        }

        public void SetCompanyName(string value)
        {
            this._companyName = value;
        }
    }
}
