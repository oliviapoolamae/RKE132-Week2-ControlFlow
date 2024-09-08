
//rakendus küsib kasutajhal sisestada tema vanuse
//kui kasutaja vanus on väiksem kui, siis konsoolis kuvatakse:
//"You are too young tob use this"
//muul juhul konsoolis kuvatakse "Welcome to this"

using System.Transactions;

Console.WriteLine("Enter your age:");

int userAge = Int32.Parse (Console.ReadLine()); 

if (userAge >= 13)
{
    Console.WriteLine("Welcome to This!");
}
else 
{
    Console.WriteLine("You are too young to use This!");
}