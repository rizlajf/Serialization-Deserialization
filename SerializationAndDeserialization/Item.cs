namespace SerializationAndDeserialization
{
    public class Item
    {
        private int _ItemID;
        private string _ItemName;
        private int _ItemPrice;
        private int _ItemQtyInStock;

        public int ItemID
        {
            get
            {
                return _ItemID;
            }
            set
            {
                _ItemID = value;
            }
        }

        public string ItemName
        {
            get
            {
                return _ItemName;
            }
            set
            {
                _ItemName = value;
            }
        }

        public int ItemPrice
        {
            get
            {
                return _ItemPrice;
            }
            set
            {
                _ItemPrice = value;
            }
        }

        public int ItemQtyInStock
        {
            get
            {
                return _ItemQtyInStock;
            }
            set
            {
                _ItemQtyInStock = value;
            }
        }
    }
}