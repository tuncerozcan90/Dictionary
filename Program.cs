namespace Dictionary
{
     class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> siraAd = new MyDictionary<int, string>();

            siraAd.Add(1, "Özcan");
            siraAd.Add(5, "Ahmet");
            siraAd.Add(6, "Veli");
            siraAd.Add(4, "Hasan");
            siraAd.Add(3, "Sevda");
            siraAd.Add(2, "Melek");


            siraAd.ListItems();

            Console.WriteLine("eleman sayısı :" +siraAd.Count);
            Console.ReadLine();

        }
    }

   
}