using System;
using ConsoleApp4;

public class ReverseExample
{
    public static void Main(string[] args)
    {
        Animals dog = new Animals("Hachiko", "Peach white",11);
        

        Animals cat = new Animals("Garfield", "Orange tabby",40);
        //cat.name = "Garfield";
        //cat.color = "Orange tabby";
        //cat.age = 40;
        //dog.name = "Hachiko";
        //dog.color = "Peach white";
        //dog.age = 11;

        Console.WriteLine(dog.GetFullDeatials());
        Console.WriteLine(cat.GetFullDeatials());

    }
}


