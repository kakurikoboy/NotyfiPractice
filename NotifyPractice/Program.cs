using System;


namespace NotifyPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ObservableList<NotifyItem<int>>();
            var a = new NotifyItem<int>(3);
            var b = new NotifyItem<int>(3);

            list.Add(a);
            Console.WriteLine($"Add a!");
            ShowList(list);
            list.Add(b);
            Console.WriteLine($"Add b!");
            ShowList(list);
            list[0].Limit = 3;
            Console.WriteLine($"Change a!");
            ShowList(list);
            list[1].Limit = 3;
            Console.WriteLine($"Change b!");
            ShowList(list);
            list[0].Limit = 0;
            Console.WriteLine($"Change a -> 0!");
            ShowList(list);
        }

        static void ShowList(ObservableList<NotifyItem<int>> list)
        {
            Console.Write($"[");
            foreach (var item in list)
            {
                Console.Write($" (item:{item.Item},limit:{item.Limit}) ;");
            }
            Console.WriteLine($"]");
        }
    }
}
