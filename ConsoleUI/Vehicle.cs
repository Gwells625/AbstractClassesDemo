using System;

namespace ConsoleUI;

public abstract class Vehicle
{
    public int Year { get; set; } = 2018;
    public string Make { get; set; } = "Toyota";
    public string Model { get; set; } = "Tacoma";

    public abstract void DriveAbstract();//stubbed out method, has no implementation.

    public virtual void DriveVirtual()
    {
        Console.WriteLine($"This {GetType().Name} is virtually in drive");
    }
}