Console.WriteLine("Welcome to the restocking tool.");

Console.WriteLine();

int sodaStock = 100;
int sodaRestock = 40;
int chipsStock = 40;
int chipsRestock = 20;
int candyStock = 60;
int candyRestock = 40;

Console.WriteLine("How many Sodas have beed sold today? " + sodaStock + " are in stock");
int sodaSold = int.Parse(Console.ReadLine());
if (sodaSold <= sodaStock)
{
    sodaStock -= sodaSold;
    Console.WriteLine("There are " + sodaStock + " Sodas left");
}
else
{
    Console.WriteLine("That values is too high. Stock not adjusted");
}

Console.WriteLine();

Console.WriteLine("How many Chips have been sold today? " + chipsStock + " are in stock");
int chipsSold = int.Parse(Console.ReadLine());
if (chipsSold <= chipsStock)
{
    chipsStock -= chipsSold;
    Console.WriteLine("There are " + chipsStock + " Chips left");
}
else
{
    Console.WriteLine("That values is too high. Stock not adjusted");
}

Console.WriteLine();

Console.WriteLine("How many Candy have been sold today? " + candyStock + " are in stock");
int candySold = int.Parse(Console.ReadLine());
if (candySold <= candyStock)
{
    candyStock -= candySold;
}
else
{
    Console.WriteLine("That values is too high. Stock not adjusted");
}

Console.WriteLine();

Console.WriteLine("Thank you for filling out the values. Here's what needs to be restocked.");
if (sodaStock <= sodaRestock)
{
    Console.WriteLine("Soda needs to be restocked");
}
if (chipsStock <= chipsRestock)
{
    Console.WriteLine("Chips needs to be restocked");
}
if(candyStock <= candyRestock)
{
    Console.WriteLine("Candy needs to be restocked");
}

Console.WriteLine();

Console.WriteLine("Goodbye!");