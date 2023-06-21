using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OKRKPIAP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer(4000, 4, 4096, 980);
            Console.WriteLine(computer);
            NetBook book = new NetBook(5600, 8, 8190, 2000, 120);
            Console.WriteLine(book);
            XmlSerializer serializer = new XmlSerializer(typeof(NetBook));
            using(FileStream f = new FileStream("Computer.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(f, book);
            }
            using(FileStream f = new FileStream("NetBook.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(f, book);
            }    
            Console.ReadLine();
        }
        
        
    }
}
