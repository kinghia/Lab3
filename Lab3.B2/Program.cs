using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    private static string content;
    static void Data()
    {
        string username = "Nghĩa";
        string password = "50124141";
        string time = DateTime.Now.ToString();

        using (StringWriter sw = new StringWriter())
        {
            string content = sw.ToString();

            sw.WriteLine("UserName: " + username);
            sw.WriteLine("PassWord: " + password);

            Console.WriteLine(content);
        }
        using (StringReader sr = new StringReader(content))
        {

            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

    }
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Data();
    }
    
}