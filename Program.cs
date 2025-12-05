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
            List<Tuple<long, long>> ranges = new List<Tuple<long, long>>();
            foreach (string line in data.Split(Environment.NewLine))
            {
                if (line == "")
                {
                    break;
                }
                else
                {
                    long startID = Convert.ToInt64(line.Split("-")[0]);
                    long endID = Convert.ToInt64(line.Split("-")[1]);
                    for (int i=0; i <= ranges.Count; i++)
                    {
                        Tuple<long, long> range = ranges[i];
                        long rangeStart = range.Item1;
                        long rangeEnd = range.Item2;
                        bool extendedRange = false;
                        
                    }
                    ranges.Add(new Tuple<long, long>(startID, endID));
                }
            }
            // load in, then iteratively do this, moving to next first after extrendedRange, and repeat until no changes
            foreach (Tuple<long, long> potentiallyOverwrittenRange in ranges)
            {
                long potentiallyOverwrittenRangeStart = potentiallyOverwrittenRange.Item1;
                long potentiallyOverwrittenRangeEnd = potentiallyOverwrittenRange.Item2;
                foreach (Tuple<long, long> potentiallyOverwritingRange in ranges)
                {
                    long potentiallyOverwritingRangeStart = potentiallyOverwritingRange.Item1;
                    long potentiallyOverwritingRangeEnd = potentiallyOverwritingRange.Item2;
                }
            }
            return "";
        }
        static void Main()
        {
            string file = File.ReadAllText(@"../../../input.txt");
            Console.WriteLine(PartOne(file));
            Console.WriteLine(PartTwo(file));
        }
    }
}
