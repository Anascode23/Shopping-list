List<string> list = [];


while (true)
{
    Console.WriteLine("Please enter what you want to do with you list:  \nadd, \nremove, \nshow list, \nexit:  ");
    var choice = Console.ReadLine();
    if (choice == "exit" || choice == "quit")
        break;

    switch (choice)
    {
        case "add":
            if (choice == "add")
            {
                 Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("Please enter the items spearted by comma eg.(apple, banana)");
                var addingItem = Console.ReadLine();

                Console.WriteLine("----------------------------------------------------------------");
                if (!string.IsNullOrWhiteSpace(addingItem))
                {
                    var items = addingItem.Trim().Split(',');
                    list.AddRange(items);
                    Console.WriteLine("Item(s) added");
                }


                else
                    Console.WriteLine("Invaild item please try again");
            }
            break;


        case "remove":
            if (choice == "remove")
            {
                 Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("Please enter the item you want to remove");
                var itemToRemove = Console.ReadLine();
                Console.WriteLine("----------------------------------------------------------------");
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    if(!string.IsNullOrWhiteSpace(itemToRemove)){
                    if (list[i] == itemToRemove)
                    {
                        list.RemoveAt(i);
                        Console.WriteLine("Item removed!");
                        
                        break;
                    }
                     Console.WriteLine("----------------------------------------------------------------");
                    }
                    
                    else
                        Console.WriteLine("Item not found please try again");
                
                }
            }

            break;

        case "show list":
            if (choice == "show list")
            {
                Console.WriteLine("----------------------------------------------------------------");
                foreach (var item in list)
                    Console.WriteLine("Grocery list: " + item);

                Console.WriteLine("----------------------------------------------------------------");
            }

            break;

        default:
            Console.WriteLine("Invaild choice please try again");
            continue;
    }
}