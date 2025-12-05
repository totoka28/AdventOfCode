namespace Day1
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            //foreach (var item in File.ReadAllLines("data.txt"))
            //{
            //    if (item[0].ToString() == "L")
            //    {
            //        rotation = rotation - Convert.ToInt32(item.Substring(1));
            //    }
            //    if (item[0].ToString() == "R")
            //    {
            //        rotation = rotation + Convert.ToInt32(item.Substring(1));
            //    }
            //    bool calculating = true;
            //    Console.WriteLine("1 - " + item + " - " + rotation);
            //    while (calculating)
            //    {
            //        if (rotation == 0)
            //        {
            //            //sum += 1;
            //            calculating = false;
            //        }
            //        else if (rotation < 0)
            //        {
            //            rotation += 100;
            //            sum = sum + 1;
            //        }
            //        else if (rotation > 99)
            //        {
            //            rotation -= 100;
            //            sum = sum + 1;
            //        }
            //        else
            //        {
            //            calculating = false;
            //        }

            //    }
            //    Console.WriteLine("2 - " + item + " - " + rotation + "  - - -- - - sum: " + sum);
            //}

            //int last = 1;
            //foreach (var item in File.ReadAllLines("data.txt"))
            //{
            //    if (item[0].ToString() == "L")
            //    {
            //        rotation = rotation - Convert.ToInt32(item.Substring(1));
            //    }
            //    if (item[0].ToString() == "R")
            //    {
            //        rotation = rotation + Convert.ToInt32(item.Substring(1));
            //    }

            //    bool calc = true;
            //    bool ignore = false;
            //    while (calc)
            //    {
            //        if (Math.Abs(rotation) > 99)
            //        {
            //            if (rotation > 0)
            //            {
            //                if (rotation == 100)
            //                {
            //                    ignore = true;
            //                }
            //                rotation -= 100;
            //                sum += 1;
            //            }
            //            else
            //            {
            //                if (rotation == -100)
            //                {
            //                    ignore = true;
            //                }
            //                rotation += 100;
            //                sum += 1;
            //            }
            //        }
            //        else
            //        {
            //            calc = false;
            //        }
            //    }

            //    if (rotation == 0 && !ignore)
            //    {
            //        sum += 1;
            //    }

            //    if (rotation < 0 && last != 0) //Ha negativ akkor rakjuk pizitvra ha előző 0 volt akkor ne
            //    {
            //        rotation += 100;
            //        sum += 1;
            //    }

            //    if (rotation > 99 && last != 0)
            //    {
            //        rotation -= 100;
            //        sum += 1;
            //    }


            //    last = rotation;
            //}


            

            


            Console.WriteLine(first() + " - 1.");
            Console.WriteLine(second() + " - 2.");
        }

        public static int first()
        {
            string path = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "Day1", "data.txt");
            path = Path.GetFullPath(path);

            int rotation = 50;
            int sum = 0;
            foreach (var item in File.ReadAllLines(path))
            {
                if (item[0].ToString() == "L")
                {
                    rotation = rotation - Convert.ToInt32(item.Substring(1));
                }
                if (item[0].ToString() == "R")
                {
                    rotation = rotation + Convert.ToInt32(item.Substring(1));
                }
                if (rotation < -99)
                {
                    rotation = Convert.ToInt32(Math.Abs(rotation).ToString().Substring(1)) * -1;
                }
                if (rotation < 0)
                {
                    rotation += 100;
                }
                if (rotation > 99)
                {
                    rotation = Convert.ToInt32(rotation.ToString().Substring(1));
                }
                if (rotation == 0)
                {
                    sum += 1;
                }
            }
            return sum;
        } 

        public static int second()
        {
            string path = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "Day1", "data.txt");
            path = Path.GetFullPath(path);

            int rotation = 50;
            int sum = 0;
            int valtozas = 0;
            foreach (var item in File.ReadAllLines(path))
            {
                if (item[0].ToString() == "L")
                {
                    valtozas = Convert.ToInt32(item.Substring(1)) * -1;
                }
                if (item[0].ToString() == "R")
                {
                    valtozas = Convert.ToInt32(item.Substring(1));
                }

                if (valtozas < 0)
                {
                    while (valtozas != 0)
                    {
                        valtozas++;
                        rotation--;
                        if (rotation == 0 || rotation % 100 == 0)
                        {
                            sum += 1;
                        }
                    }
                }
                else
                {
                    while (valtozas != 0)
                    {
                        valtozas--;
                        rotation++;
                        if (rotation == 0 || rotation % 100 == 0)
                        {
                            sum += 1;
                        }
                    }
                }
            }
            return sum;
        }
    }
}
