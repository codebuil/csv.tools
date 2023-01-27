using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvsView
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int nn = 0;
            float maxsss = 0;
            int indexss = 0;
            if (args.Count()>2)
            {
                Console.WriteLine(args[0]);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
                try
                {

                    
                    string[] lines = System.IO.File.ReadAllLines("" + args[0]);
                    string s = "";
                    for (n = 0; n < lines.Count(); n++)
                    {
                        try
                        {
                            s = s + lines[n].Replace(args[1], args[2])+"\r\n";
                            
                        }
                        catch (Exception ee)
                        { 
                        }
                        
                    }
                    System.IO.File.WriteAllText(args[0] + ".out", s);
                }
                catch (Exception ee)
                {
                    Console.WriteLine("\n" + Directory.GetCurrentDirectory() + ",file error:");
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n" + Directory.GetCurrentDirectory() + ",file error:");
            }
        }
    }
}
