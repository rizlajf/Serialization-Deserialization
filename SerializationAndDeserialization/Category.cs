using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationAndDeserialization
{
    public class Category
    {
        private int _CatID;
        private string _CatName;
        private Item[] _Item;

        public int CateboryID
        {
            get
            {
                return _CatID;
            }
            set
            {
                _CatID = value;
            }
        }

        public string CategoryName
        {
            get
            {
                return _CatName;
            }
            set
            {
                _CatName = value;
            }
        }


        public Item[] Item
        {
            get
            {
                return _Item;
            }
            set
            {
                _Item = value;
            }
        }
    }
}
