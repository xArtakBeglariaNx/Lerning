using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OOP_step_122_SysIO_SimpleSerialize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Fun with object Serialization ===\n");

            JamesBondCar jbc = new JamesBondCar()
            {
                canFly = true,
                canSubmerge = false,
                isHatchBack = true
            };
            jbc.theRadio.stationPresets = new double[] { 89.3, 97.5, 105.1 };
            jbc.theRadio.hasTweeters = true;
            jbc.theRadio.hasSubWoofers = true;

            //Save object JameBondCar in binary format
            SaveAsBinaryFormat(jbc, "CarData.dat");

            //Load from file
            LoadFromBinaryFormater("CarData.dat");

            //Save object JamesBondcar in Soap format
            SaveAsSoapFormater(jbc, "CarData.soap");

            //Load ojbect from file (CarData.soap)
            LoadFromSoapFormater("CarData.soap");

            //Save object in xml format
            SaveAsXmlFormater(jbc, "CarData.xml");

            //Save object (List) in xml
            SaveListOfCarsAsXml();

            //Save object (List) in binaryData
            SaveListOfCarsAsBinary();
            Console.ReadLine();
        }

        #region Methods
        static void SaveAsBinaryFormat(object objGraph, string fileName)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fStream, objGraph);
            }
            Console.WriteLine("=> Saved car in binary format!");
        }

        static void LoadFromBinaryFormater(string fileName)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = File.OpenRead(fileName))
            {
                JamesBondCar carFromDisk = (JamesBondCar)binFormat.Deserialize(fStream);
                Console.WriteLine($"Can this car fly? {carFromDisk.canFly}\n");
            }
        }

        static void SaveAsSoapFormater(object objGraph, string fileName)
        {
            SoapFormatter soapFormat = new SoapFormatter();
            using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                soapFormat.Serialize(fStream, objGraph);
            }
            Console.WriteLine("Save car in soap format!");
        }

        static void LoadFromSoapFormater(string fileName)
        {
            SoapFormatter soapFormat = new SoapFormatter();
            using (Stream fStream = File.OpenRead(fileName))
            {
                JamesBondCar carFromDisk = (JamesBondCar)soapFormat.Deserialize(fStream);
                Console.WriteLine($"Can car Submerge? {carFromDisk.canSubmerge}\n");
            }
        }

        static void SaveAsXmlFormater(object objGraph, string fileName)
        {
            //save file as CarData.xml
            XmlSerializer xmlFormat = new XmlSerializer(typeof(JamesBondCar));
            using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                xmlFormat.Serialize(fStream, objGraph);
            }
            Console.WriteLine("Save car in xml format\n");
        }

        static void SaveListOfCarsAsXml()
        {
            List<JamesBondCar> myCars = new List<JamesBondCar>();
            myCars.Add(new JamesBondCar(true, true));
            myCars.Add(new JamesBondCar(true, false));
            myCars.Add(new JamesBondCar(false, true));
            myCars.Add(new JamesBondCar(false, false));
            using (Stream fStream = new FileStream("CarCollection.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer xmlFormat = new XmlSerializer(typeof(List<JamesBondCar>));
                xmlFormat.Serialize(fStream, myCars);
            }
            Console.WriteLine("=> Save list of Cars in XML");
        }

        static void SaveListOfCarsAsBinary()
        {
            List<JamesBondCar> myCars = new List<JamesBondCar>();
            BinaryFormatter binFormat = new BinaryFormatter();

            using (Stream fStream = new FileStream("CarCollectionAsBinary.dat", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fStream, myCars);
            }
            Console.WriteLine("=> Save cars in list in binaryData!");
        }
        #endregion

    }

    #region Classes
    [Serializable]
    public class Radio
    {
        public bool hasTweeters;
        public bool hasSubWoofers;
        public double[] stationPresets;

        [NonSerialized]
        public string radioID = "XF-552RR6";

        public Radio() { }
    }

    [Serializable]
    public class Car
    {
        public Radio theRadio = new Radio();
        public bool isHatchBack;
    }

    [Serializable]
    [XmlRoot(Namespace = "http://www.MyCompany.com")]
    public class JamesBondCar : Car
    {
        [XmlAttribute]
        public bool canFly;
        [XmlAttribute]
        public bool canSubmerge;

        public JamesBondCar(bool fly, bool subMerge)
        {
            canFly = fly;
            canSubmerge = subMerge;
        }

        public JamesBondCar() { }
    }

    [Serializable]
    class Person
    {
        public bool isAlive;

        private int personAge = 21;

        private string fName = string.Empty;
        public string FirstName
        {
            get { return fName; }
            set { fName = value; }
        }
    }
    #endregion

}
