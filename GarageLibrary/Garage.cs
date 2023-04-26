using System;

namespace GarageLibrary;


public class Garage
{
    public string Address { get; private set; }
    public List<String> RepairedBrands { get; private set; }
    public List<Employee> Employees { get; private set; }
    
    public List<Car> RepairedCar { get; private set; }
    
    private Dictionary<Employee, List<Car>> EmployeeCar { get; set; } 

   
    public Garage(string address, IEnumerable<string> repairedbrands, IEnumerable<Employee> employees, IEnumerable<Car> repairedCars)
    {
        this.Address = address;
        this.RepairedBrands = new List<string>(repairedbrands);
        this.Employees = new List<Employee>(employees);
        this.RepairedCar = new List<Car>(repairedCars);
        EmployeeCar = new Dictionary<Employee, List<Car>>();
    }


    private bool CanBeRepair(Car car)
    {
        return this.RepairedBrands.Contains(car.Brand);
    }

    public void AddCarForRepair(Car car)
    {
        if (CanBeRepair(car))
        {
            if (Employees.Any(employee => !employee.Busy))
            {
                foreach (var employee in Employees)
                {
                    if (!employee.Busy)
                    {
                        EmployeeCar.Add(employee, new List<Car>(){ car });
                        break;
                    }
                }
            }
            else
            {
                int index = new Random().Next(0, Employees.Count);
                EmployeeCar[Employees[index]].Add(car);
            }
        }
        else
        {
            Console.WriteLine($@"This car can't be repaired because it has {car.Brand} brand");
        }
    }
    
}