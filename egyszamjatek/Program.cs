using System.Transactions;

namespace egyszamjatek
{
    internal class Program
    {
        public static List<Reading> list = new();
        static void Main(string[] args)
        {
            DataReading("../../../data/egyszamjatek.txt");
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();
            Feladat7();
            Feladat8(Feladat7());
        }

        private static void Feladat8(int roundIndex)
        {
            //TODO
            int min = list[0].tips[roundIndex];
            int winIndex = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (min > list[i].tips[roundIndex])
                {
                    min = list[i].tips[roundIndex];
                }
                if (min == list[i].tips[roundIndex])
                {

                }
            }

            Console.WriteLine("8. feladat: " +
                "A nyertes tipp a megadott fordulóban: ");


        }

        private static int Feladat7()
        {
            Console.Write("7. feladat: " +
                $"Kérem a forduló sorszámát [{1}-{list[0].tips.Length}]: ");
            int playerChoice = Convert.ToInt32(Console.ReadLine())-1;

            if (playerChoice < 0 || playerChoice > list[0].tips.Length-1)
            {
                playerChoice = 0;
            }

            return playerChoice;
        }

        private static void Feladat6()
        {
            int maxTipp = 0;

            for (int i = 0; i < list.Count; i++)
                for (int j = 0; j < list[i].tips.Length; j++)
                    if (maxTipp < list[i].tips[j])
                        maxTipp = list[i].tips[j];

            Console.WriteLine("6. feladat: " +
                $"A legnagyobb tipp a fordulók során: {maxTipp}");
        }

        private static void Feladat5()
        {
            bool have = false;

            foreach (var i in list)
                if (i.tips[1] == 1)
                    have = true;

            Console.WriteLine("5. feladat: " + 
                ((have) 
                ? "Az első fordulóban volt egyes tipp!" 
                : "Az első fordulóban nem volt egyes tipp!"));
        }

        private static void Feladat4()
            => Console.WriteLine($"4. feladat: " +
                $"Fordulók száma: {list[0].tips.Length}");

        private static void Feladat3()
            => Console.WriteLine("3. feladat: " +
                $"Játékosok száma: {list.Count}");
        private static void DataReading(string dataLocation)
        {
            StreamReader sr = new(dataLocation);

            while (!sr.EndOfStream)
                list.Add(new Reading(sr.ReadLine()));

            sr.Close();
        }
    }
}