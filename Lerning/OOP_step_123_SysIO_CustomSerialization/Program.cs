using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace OOP_step_123_SysIO_CustomSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Fun with Custom Serialization ===\n");

            StringData myData = new StringData();

            SoapFormatter soapFormat = new SoapFormatter();
            using (Stream fStream = new FileStream("MyData.soap", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                soapFormat.Serialize(fStream, myData);
            }
            Console.WriteLine("=> Save StringData complete\n");

            MoreData myData2 = new MoreData();
            SoapFormatter soapFormat2 = new SoapFormatter();
            using (Stream fStream2 = new FileStream("MoreData.soap", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                soapFormat2.Serialize(fStream2, myData2);
            }
            Console.WriteLine("=> Save MoreData complete");
            Console.ReadLine();
        }
    }

    [Serializable]
    class StringData : ISerializable
    {
        private string dataItemOne = "Fist data block";
        private string dataItemTwo = "More data";

        public StringData() { }

        protected StringData(SerializationInfo si, StreamingContext ctx)
        {
            dataItemOne = si.GetString("First_Item".ToLower());
            dataItemTwo = si.GetString("SecondItem".ToLower());
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("First_Item", dataItemOne.ToUpper());
            info.AddValue("SecondItem", dataItemTwo.ToUpper());
        }
    }

    [Serializable]
    class MoreData
    {
        private string dataItemOne = "Fist data block";
        private string dataItemTwo = "More data";

        public MoreData() { }

        [OnSerializing]
        private void OnSerializing(StreamingContext ctx)
        {
            dataItemOne = dataItemOne.ToUpper();
            dataItemTwo = dataItemTwo.ToUpper();
        }

        [OnSerialized]
        private void OnSerialized(StreamingContext context)
        {
            dataItemOne = dataItemOne.ToLower();
            dataItemTwo = dataItemTwo.ToLower();
        }
    }
}
