namespace InterfaceExercise;

public class Truck : IVehicle, ICompany
{
    public bool hasTruckBed { get; set; }
    public string truckBedSpace { get; set; }
    public string Name { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public string Logo { get; set; }
    public string Headquarters { get; set; }
}