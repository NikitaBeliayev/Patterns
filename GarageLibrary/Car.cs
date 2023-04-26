namespace GarageLibrary;

public sealed class Car
{
    public string GovernmentNumber { get; private set; }
    public string Brand { get; private set; }
    public string TechnicalNumber { get; private set; }
    
    public DateTime RepairStart { get; set; }
    public DateTime RepairFinish { get; set; }

    public Car(string governmentNumber, string brand, string techicalNumber, DateTime repairFinish, DateTime repairStart)
    {
        this.Brand = brand;
        this.GovernmentNumber = governmentNumber;
        this.TechnicalNumber = techicalNumber;
        this.RepairFinish = repairFinish;
        this.RepairStart = repairStart;
    }
    
}