using System.IO;

namespace Day4
{
    public class Program
    {
        static void Main(string[] args)
        { }
        public static int day(bool part2)
        {
            string path = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "Day4", "data.txt");
            path = Path.GetFullPath(path);


            char[][] adat = File.ReadAllLines(path)
                .Select(s => s.ToCharArray())
                .ToArray();
            int sum = 0; int lastsum = 0;
            do
            {
                lastsum = sum;
                for (int i = 0; i < adat.Length; i++) // sor
                {
                    for (int a = 0; a < adat[i].Length; a++) // oszlop
                    {
                        if (adat[i][a] == '@' || adat[i][a] == 'X')
                        {
                            int db = 0;

                            if (a > 0)
                            {
                                if (adat[i][a - 1] == '@' || adat[i][a - 1] == 'X')
                                {
                                    db++; //bal  
                                }
                            }
                            if (adat[i].Length > a + 1)
                            {
                                if (adat[i][a + 1] == '@' || adat[i][a + 1] == 'X')
                                {
                                    db++;//jobb
                                }
                            }
                            if (adat.Length > i + 1)
                            {
                                if (adat[i + 1][a] == '@' || adat[i + 1][a] == 'X')
                                {
                                    db++; //lent
                                }
                                if (a >= 1)
                                {
                                    if (adat[i + 1][a - 1] == '@' || adat[i + 1][a - 1] == 'X')
                                    {
                                        db++; //lent ball
                                    }
                                }
                                if (adat[i].Length > a + 1)
                                {
                                    if (adat[i + 1][a + 1] == '@' || adat[i + 1][a + 1] == 'X')
                                    {
                                        db++; // lent jobb
                                    }
                                }
                            }
                            if (i > 0)
                            {
                                if (adat[i - 1][a] == '@' || adat[i - 1][a] == 'X')
                                {
                                    db++; //fent 
                                }
                                if (a >= 1)
                                {
                                    if (adat[i - 1][a - 1] == '@' || adat[i - 1][a - 1] == 'X')
                                    {
                                        db++; //fent bal
                                    }
                                }
                                if (adat[i].Length > a + 1)
                                {
                                    if (adat[i - 1][a + 1] == '@' || adat[i - 1][a + 1] == 'X')
                                    {
                                        db++; //fent jobb 
                                    }
                                }
                            }
                            if (!(db > 3))
                            {
                                sum++;
                                adat[i][a] = 'X';
                            }
                        }
                    }
                }
                adat = adat.Select(row => row.Select(c => c == 'X' ? '.' : c).ToArray()).ToArray();
            } while (sum != lastsum && part2);
            return (sum);
        }
    }
}
