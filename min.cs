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

                    for (n = 1; n < lines.Count(); n++)
                    {
                        
                        string[] fields = lines[n].Split(',');
                        if (n == 1)
                        {
                            indexss = 1;
                            try
                            {
                                maxsss = float.Parse(fields[nnnn].Trim());
                            }
                            catch(Exception ee)
                            {
                                maxsss = 0;
                            }
                        }
                        else
                        {
                            indexss = 0;
                            try
                            {
                               float maxssss = float.Parse(fields[nnnn].Trim());
                                if (maxssss < maxsss)
                                {
                                    indexss = n;
                                    maxsss = maxssss;
                                }
                            }
                            catch (Exception ee)
                            {
                                
                            }
                        }

                    }
                    Console.Write(lines[indexss] + "\r\n");

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
