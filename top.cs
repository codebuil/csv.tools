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
            int topss = 3;
            int n = 0;
            int nn = 0;
            float maxsss = 0;
            int indexss = 0;
            int arg = 0;
            int poss = 0;
            float values = 0;
            float[] iii = new float[topss];
            int[] iiii = new int[topss];
            if (args.Count()>1)
            {
                Console.WriteLine(args[0]);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
                try
                    
                {

                    arg = int.Parse(args[1]);
                    string[] lines = System.IO.File.ReadAllLines("" + args[0]);
                    string s = "";
                    
                    for (n = 1; n < lines.Count(); n++)
                    {
                        string[] sss = lines[n].Split(',');
                        try
                        {
                            float ff = float.Parse(sss[arg]);

                            if (n == 1)
                            {
                                for (nn = 0; nn < topss; nn++)
                                {
                                    string[] ssss = lines[n+1].Split(',');
                                    float fff = float.Parse(sss[arg]);
                                    iii[nn] = fff;
                                    iiii[nn] = nn+1;
                                }
                                values = ff;
                                poss = 1;
                            }
                            else
                            {
                                if (ff > values)
                                {
                                    iii[poss] = ff;                               
                                    iiii[poss] = n;
                                    values = iii[0];
                                    poss = 0;
                                    for (nn = 1; nn < topss; nn++)
                                    {
                                        if (iii[nn] < values)
                                        {
                                            values = iii[nn];
                                            poss = nn;
                                        }
                                        
                                    }
                                }
                            }
                            
                           
                            
                        }
                        catch (Exception ee)
                        {
                        }
                        
                    }
                    for (nn = 0; nn < topss; nn++)
                    {
                        int mm = iiii[nn];
                        Console.WriteLine(lines[mm]);
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
