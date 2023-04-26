namespace Program;

public class Client
{
    public static int GetRepairCount(Facade facade)
    {
        DateTime start = new DateTime(2022, 7, 1);
        DateTime finish = new DateTime(2022, 11, 25);
        return facade.GetRepairCountDuringTime(start, finish);
    }
}