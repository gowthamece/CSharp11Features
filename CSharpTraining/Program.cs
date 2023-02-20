// See https://aka.ms/new-console-template for more information



//--------------------------------------//

//-----Raw string literals ---------------//
var str = """"<input text="""Test""">"""";
//var jsonStr = "{\n   \"name\":\"Gowtham\"  \n}";

var jsonStr = """
    {  
    "name":"Gowtham" 
    }
    """;
Console.WriteLine(jsonStr); 
Console.WriteLine(str);

//--------------------------------------//

//-----List pattern matching ---------------//

int[] numbers = {1,2,3};
Console.WriteLine(numbers is [1, 2, 3]); // True 
Console.WriteLine(numbers is [1, 2, 4]); // False 
Console.WriteLine(numbers is [1, 2, 3,4]); // False
Console.WriteLine(numbers is [0 or 1, <= 2, <= 3]);//True
Console.WriteLine(numbers is [1, _, _]);//True

var emptyName=Array.Empty<string>();
var myName = new[] { "Gowtham" };

var text = myName switch
{
    [] => "Name was empty",
    [var fullName] => $"My Name is {fullName}"
};
Console.WriteLine(text);
Console.ReadKey();




