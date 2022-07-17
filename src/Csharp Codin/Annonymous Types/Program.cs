using AnnonymousTypes;

//https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/types/anonymous-types
Console.WriteLine("-------------------------- 1 ---------------------------");
var example = new { Greeting = "Bismi" , Name = "llah" };
Console.WriteLine($"{example.Greeting}{example.Name}!");
Console.WriteLine("\n\n");





Console.WriteLine("-------------------------- 2 ---------------------------");
var Products = new[] { new { Color = "White", Price = 5000 }, new { Color = "Black", Price = 500} };  // an array of anonymously typed elements by combining an implicitly typed local variable and an implicitly typed array 

var productQuery =
            from prod in Products
            select new { prod.Color, prod.Price };

foreach (var v in productQuery)
{
    Console.WriteLine("Color={0}    and     Price={1}", v.Color, v.Price);
}
Console.WriteLine("\n\n");








Console.WriteLine("-------------------------- 3 ---------------------------");
var apple = new { Item = "apples", Price = 1.35 };
var onSale = apple with { Price = 0.79 };
Console.WriteLine(apple);
Console.WriteLine(onSale);
Console.WriteLine("\n\n");


Console.WriteLine("-------------------------- 4 ---------------------------");
//https://www.tutorialsteacher.com/csharp/csharp-anonymous-type
var student = new { 
                     Id = 1, Firstname = "Muhammad", LastName = "Salman" , 
                     Address = new { City = "London", Country = "UK" }   // Nested Anonymous Type
};

Console.WriteLine(student.Id);
Console.WriteLine(student.Firstname);
Console.WriteLine(student.LastName);
Console.WriteLine(student.Address.City);
Console.WriteLine(student.Address.Country);
Console.WriteLine(student.Address);


var arr = new[]                                         // Array of Anonymous Types
{
    new { Firstname = "Muhammad", Lastname = "Salman"},
    new { Firstname = "x", Lastname = "y"},
    new { Firstname = "t" , Lastname = "z"}

};
Console.WriteLine(arr[0]);
Console.WriteLine(arr[2]);
Console.WriteLine("\n\n");








Console.WriteLine("-------------------------- 5 ---------------------------");
//https://www.infoworld.com/article/3536470/how-to-use-anonymous-types-in-csharp.html important link for annonymous type
//https://www.javatpoint.com/csharp-anonymous-types
//https://csharp.net-tutorials.com/data-types/anonymous-types/ 




Console.WriteLine("-------------------------- 6 ---------------------------");
Membership membership = new Membership();
dynamic result = membership.CreateUser("jalaluddin", "1234");

Console.WriteLine(result.status);
Console.WriteLine(result.user.Username);








Console.WriteLine("\n\n"); 











Console.WriteLine("--------------------------7---------------------------");




