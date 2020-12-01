using System;
using System.Collections.Generic;

namespace Save
{
    class Program
    {
        static String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//contacts.xml";
        static void Main(string[] args)
        {
            List<Contact> contacts = new List<Contact>();
            contacts.Add(new Contact("joe", "0588888888"));
            contacts.Add(new Contact("aly", "0499999999"));
            WriteXML(contacts);
            readXML();
            Console.ReadKey(true);
        }

        public static void WriteXML(List<Contact> myLists)
        {
            System.Xml.Serialization.XmlSerializer writer =
                           new System.Xml.Serialization.XmlSerializer(typeof(List<Contact>));

            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, myLists);
            file.Close();

        }

        public static void readXML()
        {
            System.Xml.Serialization.XmlSerializer reader =
                            new System.Xml.Serialization.XmlSerializer(typeof(List<Contact>));
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            List<Contact> contacts = (List<Contact>)reader.Deserialize(file);
            file.Close();

            foreach (Contact c in contacts)
            {
                Console.WriteLine(c);
            }

        }
    }
}
