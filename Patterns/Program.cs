using System;
using GarageLibrary;

namespace Program;

public static class Program
{
    public static void Main()
    {
        string address = "address1";
        var repaired_brands = new List<string>()
        {
            GarageLibrary.Brands.Bmw,
            GarageLibrary.Brands.Citroen,
            GarageLibrary.Brands.Opel
        };
        
        var employees = new List<Employee>()
        {
            new Employee("firstname1", "secondname1"),
            new Employee("firstname2", "secondname2"),
            new Employee("firstname3", "secondname3"),
            new Employee("firstname4", "secondname4"),
        };
        var cars = new List<Car>()
        {
            new Car("111", GarageLibrary.Brands.Bmw, "111", new DateTime(2022, 10, 3), new DateTime(2022, 10, 26)),
            new Car("112", GarageLibrary.Brands.Citroen, "211", new DateTime(2021, 4, 1), new DateTime(2021, 5, 1)),
            new Car("113", GarageLibrary.Brands.Opel, "311", new DateTime(2022, 7, 3), new DateTime(2022, 7, 10)),
            new Car("114", GarageLibrary.Brands.Ford, "411", new DateTime(2021, 8, 2), new DateTime(2021, 10, 23)),
            new Car("115", GarageLibrary.Brands.Bmw, "511", new DateTime(2022, 10, 4), new DateTime(2022, 11, 4)),
        };
        GarageLibrary.Garage garage = new Garage(address, repaired_brands, employees, cars);
        Facade facade = Facade.GetInstance(garage);
        Console.WriteLine(Client.GetRepairCount(facade));

    }
}
