using System;
using System.Numerics;

namespace Day3
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int sum = 0;
            //foreach (var item in File.ReadAllLines("data.txt"))
            //{
            //    int nagy = 0;
            //    for (int i = 0; i < item.Length; i++)
            //    {
            //        for (int a = 0; a < item.Length; a++)
            //        {
            //            if (i < a)
            //            {
            //                if (nagy < Convert.ToInt32(item[i] + item[a].ToString()))
            //                {
            //                    nagy = Convert.ToInt32(item[i] + item[a].ToString());
            //                }
            //            }
            //        }
            //    }
            //    sum += nagy;
            //}
            //Console.WriteLine(sum);


            //foreach (var item in File.ReadLines("data.txt"))
            //{
            //    List<char> eredeti = item.ToList();
            //    int nagy = 0; int index = 0;
            //    for (int i = 0; i < eredeti.Count - 11; i++)
            //    {
            //        if (nagy < Convert.ToInt32(eredeti[i].ToString()))
            //        {
            //            nagy = Convert.ToInt32(eredeti[i].ToString());
            //            index = i;
            //        }
            //    }
            //    eredeti.RemoveRange(0, index + 1);

            //    List<char> szamok = new List<char>();

            //    while (szamok.Count != 12)
            //    {

            //    }
            //}


        }
        public static int first()
        {
            string path = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "Day3", "data.txt");
            path = Path.GetFullPath(path);

            int sum = 0;
            foreach (var item in File.ReadAllLines(path))
            {
                int nagy = 0;
                for (int i = 0; i < item.Length; i++)
                {
                    for (int a = 0; a < item.Length; a++)
                    {
                        if (i < a)
                        {
                            if (nagy < Convert.ToInt32(item[i] + item[a].ToString()))
                            {
                                nagy = Convert.ToInt32(item[i] + item[a].ToString());
                            }
                        }
                    }
                }
                sum += nagy;
            }
            return sum;
        }

        public static long second()
        {
            string path = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "Day3", "data.txt");
            path = Path.GetFullPath(path);

            long sum = 0;
            foreach (var item in File.ReadLines(path))
            {
                string szamok = "";
                List<char> eredeti = item.ToList();
                int db = 12;

                while (szamok.Count() != 12)
                {
                    int nagy = 0; int index = 0;
                    if (eredeti.Count() < db - szamok.Count())
                    {
                        for (int i = 0; i < db - szamok.Count(); i++)
                        {
                            szamok = szamok + eredeti[eredeti.Count() + 1 - i];
                        }
                    }
                    else
                    {
                        for (int i = 0; i < eredeti.Count - ((db - 1) - szamok.Count()); i++)
                        {
                            if (nagy < Convert.ToInt32(eredeti[i].ToString()))
                            {
                                nagy = Convert.ToInt32(eredeti[i].ToString());
                                index = i;
                            }
                        }
                        eredeti.RemoveRange(0, index + 1);
                    }

                    szamok = szamok + nagy;
                }
                sum += long.Parse(szamok);
            }
            return sum;
        }
        
    }
}
