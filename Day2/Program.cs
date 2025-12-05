namespace Day2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. - " + first());
            Console.WriteLine("2. - " + second());
        }

        public static long first()
        {
            string path = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "Day2", "data.txt");
            path = Path.GetFullPath(path);

            long sum = 0;
            string[] ids = File.ReadAllText(path).ToString().Split(',');
            foreach (var item in ids)
            {
                for (long i = long.Parse(item.Split('-')[0]); i < long.Parse(item.Split('-')[1]) + 1; i++)
                {
                    if (i.ToString()[..(i.ToString().Length / 2)] == i.ToString()[(i.ToString().Length / 2)..])
                    {
                        sum += i;
                    }
                }
            }
            return sum;
        }

        public static long second()
        {
            string path = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "Day2", "data.txt");
            path = Path.GetFullPath(path);

            long sum = 0;
            string[] ids = File.ReadAllText(path).ToString().Split(',');
            foreach (var item in ids)
            {
                HashSet<long> szamok = new HashSet<long>();
                for (long i = long.Parse(item.Split('-')[0]); i < long.Parse(item.Split('-')[1]) + 1; i++)
                {
                    string fuzzo = "";
                    foreach (var alma in i.ToString()[..(i.ToString().Length / 2)])
                    {
                        fuzzo = fuzzo + alma;
                        for (int v = 2; v < (i.ToString().Length / fuzzo.Length) + 1; v++)
                        {
                            if (i.ToString() == string.Concat(Enumerable.Repeat(fuzzo, v)))
                            {
                                //Console.WriteLine(i);
                                szamok.Add(i);
                            }
                        }
                    }
                }
                sum = sum + szamok.Sum(x => x);
            }
            return sum;
        }
    }
}
