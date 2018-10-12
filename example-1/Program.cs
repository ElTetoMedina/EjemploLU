using System;
using Classes;
namespace example_1

{
    class Program
{
    static void Main(string[] args)
    {
        //User newUser = new User();
        Console.WriteLine("Ingrese nombre de usuario");
        string name = Console.ReadLine();
        User newUser = new User(name);
        //newUser.SetName(name);
        Console.WriteLine("Ingrese su apellido");
        //string LastName = Console.ReadLine();
        newUser.SetLastName(Console.ReadLine());
        //string message = newUser.GetFullName();
        Console.WriteLine(newUser.GetFullName());


    }
}
}