using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace FSolution
{
    class Program
    {
                
        static void Main (string[] args)
        {

            string line;
            try
            {
                StreamReader sr = new StreamReader("MailingList.txt");
                //StreamWriter sw = new StreamWriter("resources/Mailing List.txt", false, Encoding.Unicode);

                
                do
                {
                    line = sr.ReadLine();
                    Console.WriteLine(line);
                    Match m = Regex.Match("sssdd ddd@yahoo.com", @"(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
           + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
             + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
           + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})");

                    if (m.Success)
                    {
                        Person p = new Person(line.Substring(0, m.Index), m.Value);

                    }


                    //Console.WriteLine(ValidEmail(line.ToString()));
                    // Person p = new Person(name, mail);

                    // Console.WriteLine("{0},{1}", name, mail);
                    //sw.Write("{0},{1}",p.Name, p.Email);
                    //sw.Write(p.Name, p.Email);


                }
                while (line != null);

                sr.Close();
                //sw.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("exception: " + e.Message);
            }

            finally
            {
                Console.WriteLine("execute finnaly block");
            }
        }
    }
}
