namespace AOC2025Day5
{
    public class Program
    {
        public static string PartOne(string data)
        {
            bool areAvaliableLines = false;
            List<Tuple<long, long>> ranges = new List<Tuple<long, long>>();
            List<long> availableIDs = new List<long>();
            foreach (string line in data.Split(Environment.NewLine))
            {
                if (line == "")
                {
                    areAvaliableLines = true;
                }
                else if (areAvaliableLines)
                {
                    availableIDs.Add(Convert.ToInt64(line));
                }
                else
                {
                    long startID = Convert.ToInt64(line.Split("-")[0]);
                    long endID = Convert.ToInt64(line.Split("-")[1]);
                    ranges.Add(new Tuple<long, long>(startID, endID));
                }
            }
            int freshIDs = 0;
            foreach (long id in availableIDs)
            {
                foreach (Tuple<long, long> range in ranges)
                {
                    long startID = range.Item1;
                    long endID = range.Item2;
                    if (id >= startID && id <= endID)
                    {
                        freshIDs++;
                        break;
                    }
                }
            }
            return Convert.ToString(freshIDs);
        }
        public static string PartTwo(string data)
        {
            List<long> foundFresh = new List<long>();
            int n = 0;
            int length = data.Split(Environment.NewLine).Length;
            foreach (string line in data.Split(Environment.NewLine))
            {
                Console.WriteLine(n/length);
                if (line == "")
                {
                    break;
                }
                else
                {
                    long startID = Convert.ToInt64(line.Split("-")[0]);
                    long endID = Convert.ToInt64(line.Split("-")[1]);
                    for (long freshID = startID; freshID <= endID; freshID++)
                    {
                        if (!foundFresh.Contains(freshID))
                        {
                            foundFresh.Add(freshID);
                        }
                    }
                }
                n++;
            }
            return Convert.ToString(foundFresh.Count);
        }
        static void Main()
        {
            string file = File.ReadAllText(@"../../../input.txt");
            Console.WriteLine(PartOne(file));
            Console.WriteLine(PartTwo(file));
        }
    }
}
