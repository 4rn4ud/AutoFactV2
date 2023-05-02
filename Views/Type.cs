namespace AutoFact2.Views
{
    class Type
    {
        private int _id;
        private string _libel;

        public Type(int id, string libel)
        {
            this._id = id;
            this._libel = libel;
        }

        public int GetId()
        {
            return _id;
        }

        public void SetId(int value)
        {
            this._id = value;
        }

        public string GetLibel()
        {
            return _libel;
        }

        public void SetLibel(string value)
        {
            this._libel = value;
        }
    }
}
