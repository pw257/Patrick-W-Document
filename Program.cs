using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PatrickW_Document
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Document\n");

            Console.Write("Enter the name of your document: ");
            string name = Console.ReadLine();

            Console.Write("Enter the content of your document: ");
            string content = Console.ReadLine();

            try
            {
                StreamWriter streamWriter = new StreamWriter(name + ".txt");
                streamWriter.WriteLine(content);
                streamWriter.Close();
                Console.WriteLine("{0} was successfully saved. The document contains {1} characters.", name, content.Length);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}

