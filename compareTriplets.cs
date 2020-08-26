class Program
    {
        //compare 2 lists index by index which is greater then 1 pkt plus
        static List<int> compareTriplets(List<int> a, List<int> b)
        {   
            int bob = 0;
            int alice = 0;
            for (int i = 0; i < a.Count; i++) {
                bob = (a[i] > b[i]) ? ++bob : bob;
                alice = (a[i] < b[i]) ? ++alice : alice;
            }
            return new List<int> { bob, alice };
        }

        static void Main(string[] args)
        {
            List<int> l1 = new List<int> { 0, 0, 0 };
            List<int> l2 = new List<int> { 2, 2, 2 };

            foreach (int x in compareTriplets(l1, l2))
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
