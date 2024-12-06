namespace InterfaceExercise;

public class Car : IVehicle, ICompany
{
    public bool HasTrunk { get; set; }
    public int NumberOfSeats { get; set; }
    public string Name { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public string Logo { get; set; }
    public string Headquarters { get; set; }
}