using System.Reflection;

var books = new List<string>();
books.Add("The Yellow King");

var numbers = new List<int>
{
    3,
    7,
    13
};

Console.WriteLine(books[0]);

foreach (var value in numbers)
{
    Console.WriteLine(value);
}

var myNullable = new Nullable<int>(3);
Console.WriteLine("Has value? " + myNullable.HasValue);
Console.WriteLine("Value: " + myNullable.GetValueOrDefault());

var myNullable2 = new Nullable<int>();
Console.WriteLine("Has value? " + myNullable2.HasValue);
Console.WriteLine("Value: " + myNullable2.GetValueOrDefault());
