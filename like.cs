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
            if (args.Count()>1)
            {
                Console.WriteLine(args[0]);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
                try
                {

                    
                    string[] lines = System.IO.File.ReadAllLines("" + args[0]);

                    for (n = 0; n < lines.Count(); n++)
                    {
                        try
                        {
                            int i = lines[n].IndexOf(args[1]);
                            if(i>-1)Console.WriteLine(lines[n]);
                        }
                        catch (Exception ee)
                        { 
                        }
                        
                    }  
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
