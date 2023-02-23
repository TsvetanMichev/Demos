namespace OlympicsComparators11TM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Olympic> listOlymp = new List<Olympic>();
            for (int i = 0; i < n; i++)
            {
                var data = Console.ReadLine().Split();
                Olympic olympic = new Olympic(data[0], int.Parse(data[1]));
                listOlymp.Add(olympic);
            }
            //TODO: fix the comparing (and printing?)
            listOlymp.Sort();
            //Console.WriteLine(string.Join(", ", listOlymp));
            foreach (var item in listOlymp)
            {
                item.Print();
            }
        }
    }
}