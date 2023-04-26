namespace GarageLibrary;

public sealed class Employee : IComparable<Employee>
{
    public string FirstName { get; private set; }
    public string SecondName { get; private set; }
    
    public bool Busy { get; private set; }

    public Employee(string firstName, string secondName)
    {
        this.FirstName = firstName;
        this.SecondName = secondName;
        Busy = false;
    }

    public int CompareTo(Employee employee)
    {
        return this.FirstName == employee.FirstName && this.SecondName == employee.SecondName ? 0 : 1; 
        
    }
}