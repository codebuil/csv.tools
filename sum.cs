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
            int indexss = 1;
            if (args.Count()>1)
            {
                Console.WriteLine(args[0]);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
                try
                {

                    int nnnn = int.Parse(args[1].Trim());
                    string[] lines = System.IO.File.ReadAllLines("" + args[0]);

                    for (n = 0; n < lines.Count(); n++)
                    {
                        
                        string[] fields = lines[n].Split(',');
                        
                            
                            try
                            {
                               float maxssss = float.Parse(fields[nnnn].Trim());
                                
                                    indexss = n;
                                    maxsss = maxsss + maxssss;
                                
                            }
                            catch (Exception ee)
                            {
                                
                            }
                        

                    }
                    Console.Write(maxsss.ToString() + "\r\n");

                    Console.Write("\r\n");
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
