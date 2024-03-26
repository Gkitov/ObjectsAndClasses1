using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Box> boxes = new List<Box>();

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "end")
                break;

            string[] boxInfo = input.Split();
            string serialNumber = boxInfo[0];
            string itemName = boxInfo[1];
            int itemQuantity = int.Parse(boxInfo[2]);
            decimal itemPrice = decimal.Parse(boxInfo[3]);

            Item item = new Item(itemName, itemPrice);
            decimal boxPrice = itemQuantity * itemPrice;

            Box box = new Box(serialNumber, item, itemQuantity, boxPrice);
            boxes.Add(box);
        }

        foreach (var box in boxes.OrderByDescending(b => b.BoxPrice))
        {
            Console.WriteLine(box);
        }
    }
}


class Item
{
    public string Name { get; private set; }
    public decimal Price { get; private set; }

    public Item(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}

class Box
{
    public string SerialNumber { get; private set; }
    public Item Item { get; private set; }
    public int ItemQuantity { get; private set; }
    public decimal BoxPrice { get; private set; }

    public Box(string serialNumber, Item item, int itemQuantity, decimal boxPrice)
    {
        SerialNumber = serialNumber;
        Item = item;
        ItemQuantity = itemQuantity;
        BoxPrice = boxPrice;
    }

    public override string ToString()
    {
        return $"{SerialNumber}\n" +
               $"-- {Item.Name} - ${Item.Price:F2}: {ItemQuantity}\n" +
               $"-- ${BoxPrice:F2}";
    }
}

