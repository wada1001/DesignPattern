using System;
namespace CorporateMerger
{
    public static class CoreporateMergerApp
    {
        public static void Perform()
        {
            //var pan = new PancakeHouseMenu();
            //var diner = new DinerMenu();

            //var panItr = pan.GetIterator();
            //var dinerItr = diner.GetIterator();

            //Console.WriteLine("breakfast");

            //while (panItr.HasNext())
            //{
            //    var menu = panItr.Next();
            //    Console.WriteLine(menu.Name);
            //    Console.WriteLine(menu.Description);
            //    Console.WriteLine(menu.Vegetarian);
            //    Console.WriteLine(menu.Price);
            //}

            //Console.WriteLine("diner");

            //while (dinerItr.HasNext())
            //{
            //    var menu = dinerItr.Next();
            //    Console.WriteLine(menu.Name);
            //    Console.WriteLine(menu.Description);
            //    Console.WriteLine(menu.Vegetarian);
            //    Console.WriteLine(menu.Price);
            //}

            var allMenu = new Menu("all menu", "all in one");

            var cm1 = new Menu("pancake", "breakfast");
            var cm2 = new Menu("sandwitch", "lunch");
            var cm3 = new MenuItem("steak", "diner", false, 2.00);
            var cm4 = new MenuItem("berry", "desert", false, 2.00);

            cm1.Add(new MenuItem("breakfast pancake", "egg, toast, pancake", true, 2.99));
            cm1.Add(new MenuItem("classic pancake", "egg, meat, pancake", false, 2.99));
            cm1.Add(new MenuItem("blueberry pancake", "blueberry, pancake", true, 3.49));
            cm1.Add(new MenuItem("waffle", "blueberry, pancake", true, 3.59));

            cm2.Add(new MenuItem("vegetarian blt", "lettuce, tomato, sandwitch", true, 2.99));
            cm2.Add(new MenuItem("blt", "lettuce, tomato, bacon", false, 3.29));
            cm2.Add(new MenuItem("soup", "today soup, potaosalada", false, 3.29));
            cm2.Add(new MenuItem("hotdog", "sauekraut, onion, cheese, hotdog", false, 3.05));

            allMenu.Add(cm1);
            allMenu.Add(cm2);
            allMenu.Add(cm3);
            allMenu.Add(cm4);

            allMenu.Print();
        }
    }
}
