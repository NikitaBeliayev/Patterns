using GarageLibrary;

namespace Program;

public sealed class Facade
{
    private GarageLibrary.Garage Garage;
    private static Facade _instance;


    private Facade(Garage garage)
    {
        this.Garage = garage;
    }

    public static Facade? GetInstance(GarageLibrary.Garage garage)
    {
        if (_instance is null)
        {
            _instance = new Facade(garage);
        }

        return _instance;
    }

    public int GetRepairCountDuringTime(DateTime startRepair, DateTime finishRepair)
    {
        int count = 0;
        foreach (var repairedCar in Garage.RepairedCar)
        {
            if (repairedCar.RepairStart >= startRepair && repairedCar.RepairFinish <= finishRepair)
            {
                count++;
            }
        }

        return count;
    }
}