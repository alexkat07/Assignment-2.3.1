using System.IO;
using System.Transactions;



namespace Assignment_2._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteFile();
            ReadFile();

        }
        static void ReadFile() 
        {
            try
            {
                
                StreamReader sr = new StreamReader("C:\\MSSA-CCAD14\\assignment.txt");
                //Read the first line of text
                string line = sr.ReadLine();
                
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            

        }
        static void WriteFile()
        {
            Console.WriteLine("Enter your name: ");
            string myName = Console.ReadLine();

            Console.WriteLine("Enter your city: ");
            string myCity = Console.ReadLine();
            try 
            {
                StreamWriter sw = new StreamWriter("C:\\MSSA-CCAD14\\assignment.txt");

                sw.WriteLine($"Your name is {myName}, and you live in {myCity}");


                sw.Close();
            
            
            }
            catch (Exception e) 
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            
        }

            

        
    }
}
