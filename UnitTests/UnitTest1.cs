using Program;

namespace UnitTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GetRepairedCountDuringTime_EqualTest1()
    {
        string address = "address1";
        var repaired_brands = new List<string>()
        {
            GarageLibrary.Brands.Bmw,
            GarageLibrary.Brands.Citroen,
            GarageLibrary.Brands.Opel
        };
        
        var employees = new List<GarageLibrary.Employee>()
        {
            new GarageLibrary.Employee("firstname1", "secondname1"),
            new GarageLibrary.Employee("firstname2", "secondname2"),
            new GarageLibrary.Employee("firstname3", "secondname3"),
            new GarageLibrary.Employee("firstname4", "secondname4"),
        };
        var cars = new List<GarageLibrary.Car>()
        {
            new GarageLibrary.Car("111", GarageLibrary.Brands.Bmw, "111", new DateTime(2022, 10, 3), new DateTime(2022, 10, 26)),
            new GarageLibrary.Car("112", GarageLibrary.Brands.Citroen, "211", new DateTime(2021, 4, 1), new DateTime(2021, 5, 1)),
            new GarageLibrary.Car("113", GarageLibrary.Brands.Opel, "311", new DateTime(2022, 7, 3), new DateTime(2022, 7, 10)),
            new GarageLibrary.Car("114", GarageLibrary.Brands.Ford, "411", new DateTime(2021, 8, 2), new DateTime(2021, 10, 23)),
            new GarageLibrary.Car("115", GarageLibrary.Brands.Bmw, "511", new DateTime(2022, 10, 4), new DateTime(2022, 11, 4)),
        };
        GarageLibrary.Garage garage = new GarageLibrary.Garage(address, repaired_brands, employees, cars);
        Program.Facade facade =  Program.Facade.GetInstance(garage);
        Assert.AreEqual(Client.GetRepairCount(facade), 3);
    }
    
    [Test]
    public void GetRepairedCountDuringTime_EqualTest2()
    {
        string address = "address1";
        var repaired_brands = new List<string>()
        {
            GarageLibrary.Brands.Bmw,
            GarageLibrary.Brands.Citroen,
            GarageLibrary.Brands.Opel
        };
        
        var employees = new List<GarageLibrary.Employee>()
        {
            new GarageLibrary.Employee("firstname1", "secondname1"),
            new GarageLibrary.Employee("firstname2", "secondname2"),
            new GarageLibrary.Employee("firstname3", "secondname3"),
            new GarageLibrary.Employee("firstname4", "secondname4"),
        };
        var cars = new List<GarageLibrary.Car>()
        {
            new GarageLibrary.Car("111", GarageLibrary.Brands.Bmw, "111", new DateTime(2017, 10, 3), new DateTime(2017, 10, 26)),
            new GarageLibrary.Car("112", GarageLibrary.Brands.Citroen, "211", new DateTime(2018, 4, 1), new DateTime(2021, 5, 1)),
            new GarageLibrary.Car("113", GarageLibrary.Brands.Opel, "311", new DateTime(2023, 7, 3), new DateTime(2023, 7, 10)),
            new GarageLibrary.Car("114", GarageLibrary.Brands.Ford, "411", new DateTime(2020, 8, 2), new DateTime(2021, 10, 23)),
            new GarageLibrary.Car("115", GarageLibrary.Brands.Bmw, "511", new DateTime(2021, 10, 4), new DateTime(2021, 11, 4)),
        };
        GarageLibrary.Garage garage = new GarageLibrary.Garage(address, repaired_brands, employees, cars);
        Program.Facade facade =  Program.Facade.GetInstance(garage);
        Assert.AreEqual(Client.GetRepairCount(facade), 0);
    }
}