namespace AutoFact2.Views
{
    class Quote
    {
        private int _id;

        public Quote(int id)
        {
            this._id = id;
        }

        public int GetId()
        {
            return _id;
        }

        public void SetId(int value)
        {
            this._id = value;
        }
    }
}
