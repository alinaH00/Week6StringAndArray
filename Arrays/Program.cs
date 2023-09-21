string[] fruitBasket = { "apples", "bananas", "orange" };

Console.WriteLine($"There are {fruitBasket.Length} fruit in your basket");

//Console.WriteLine(fruitBasket[0]);
//Console.WriteLine(fruitBasket[1]);
//Console.WriteLine(fruitBasket[2]);

fruitBasket[0] = "poine-apple";
fruitBasket[1] = "peaches";


//Console.WriteLine(fruitBasket[0]);
//Console.WriteLine(fruitBasket[1]);
//Console.WriteLine(fruitBasket[2]);

for (int i = 0; i < fruitBasket.Length; i++)
{
    Console.WriteLine(fruitBasket[i]);
}