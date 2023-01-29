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
            int indexss = 0;
            int arg = 0;
            int poss = 0;
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
                    string[] sss = new string[lines.Count() + 1];
                    int[] iii = new int[lines.Count() + 1];
                    string[] sssss = lines[1].Split(',');
                    sss[0] = lines[0];
                    sss[1] = String.Copy(sssss[arg]);
                    iii[0] = 0;
                    iii[1] = 1;
                    for (n = 2; n < lines.Count(); n++)
                    {
                        string[] ssss = lines[n].Split(',');
                        sss[n] = String.Copy(ssss[arg]);
                        try
                        {
                            iii[n] = n;
                            indexss = n;
                            for (nn = 1; nn < n; nn++)
                            {
                                int uuu = iii[nn];
                                if (String.Compare(sss[uuu],sss[indexss], comparisonType: StringComparison.CurrentCultureIgnoreCase ) > 0)
                                {
                                    poss = iii[nn];
                                    iii[nn] = indexss;
                                    indexss = poss;
                                }
                            }
                            iii[n] = indexss;

                        }

                        catch (Exception ee)
                        {
                        }

                    }
                    for (n = 0; n < lines.Count(); n++)
                    {
                        int k = iii[n];
                        Console.WriteLine(lines[k]);
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
