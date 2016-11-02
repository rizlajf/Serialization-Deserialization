using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace SerializationAndDeserialization
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.Serialization();

            XmlDocument doc = new XmlDocument();
            string exeLocation = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string exeDir = System.IO.Path.GetDirectoryName(exeLocation);
            string dataFile = Path.Combine(exeDir, "myfilename.xml");
            doc.Load(dataFile);
            string xmlcontents = doc.InnerXml;
            p.DeSerialize(xmlcontents);
        }

        public void Serialization()
        {
            Category Cat = new Category();
            Cat.CateboryID = 1;
            Cat.CategoryName = "Phone";
            Item[] Itm = new Item[5];
            for (int i = 0; i < 5; i++)
            {
                Itm[i] = new Item();
                Itm[i].ItemID = i;
                Itm[i].ItemPrice = i * 10;
                Itm[i].ItemQtyInStock = i + 10;
                Itm[i].ItemName = " Item Name : " + i.ToString();

            }
            Cat.Item = Itm;
            XmlSerializer ser = new XmlSerializer(Cat.GetType());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            System.IO.StringWriter writer = new System.IO.StringWriter(sb);
            ser.Serialize(writer, Cat);     // Here Classes are converted to XML String. 
                                            // This can be viewed in SB or writer.
                                            // Above XML in SB can be loaded in XmlDocument object
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(sb.ToString());
            doc.Save("myfilename.xml");
        }

        public void DeSerialize(string XmlString)
        {
            Category Cat = new Category();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(XmlString);
            XmlNodeReader reader = new XmlNodeReader(doc.DocumentElement);
            XmlSerializer ser = new XmlSerializer(Cat.GetType());
            object obj = ser.Deserialize(reader);
            // Then you just need to cast obj into whatever type it is, e.g.:
            Category myObj = (Category)obj;
        }
    }
}
