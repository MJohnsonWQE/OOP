using System.Diagnostics;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(" welcome to the Cat's Protection Trust management system. Do you want to:");
        Console.WriteLine("1 - Add a new Cat");
        Console.WriteLine("2 - Retrieve a Cat's details");
        Console.WriteLine("3 - Update a Cat's details");
        Console.WriteLine("4 - Quit the program");
        string input = Console.ReadLine();
        if (input == "1")
        {
            Cat ACat = new Cat();
        }
        else if (input == "2")
        {
            Console.WriteLine("What detail would you like to retrieve?");
            Console.WriteLine("1 - update cat weight");
            Console.WriteLine("2 - update cat vaccination status");
            Console.WriteLine("3 - update cat neutering status");
            Console.WriteLine("4 - update cat rehoming status");
            Console.WriteLine("5 - Return to main menu");
        }
        else if (input == "3")
        {
            Console.WriteLine("What detail would you like to update?");
            Console.WriteLine("1 - update cat weight");
            Console.WriteLine("2 - update cat vaccination status");
            Console.WriteLine("3 - update cat neutering status");
            Console.WriteLine("4 - update cat rehoming status");
            Console.WriteLine("5 - Return to main menu");
        }
        else if (input == "4")
        {
            Console.WriteLine("Test: 4");
        }
        else
        {
            Console.WriteLine("Test: Please enter a valid input");
        }
    }
}

class Cat
{
    public string catName;
    public string catBreed;
    public char catGender;
    public double catWeight;
    public bool neutered;
    public bool vaccinated;
    public bool rehomeReady;

    public Cat()
    {
        
    }
    public void ViewCatDetails()
    {

    }
    public string GetCatName()
    {
        return catName;
    }
    public void ChangeWeight(double newWeight)
    {
        catWeight = newWeight;
    }
    public void ChangeVaccStatus(bool newStatus)
    {
        vaccinated = newStatus;
    }
    public void ChangeNeutered(bool newNeutered)
    {
        neutered = newNeutered;
    }
    public void ChangeReHome(bool reHome)
    {
        rehomeReady = reHome;
    }
}