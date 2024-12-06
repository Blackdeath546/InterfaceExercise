namespace InterfaceExercise;

public class SUV : ICompany, IVehicle
{
    public int Rows { get; set; }
    public string CargoSpace { get; set; }
    public string Logo { get; set; }
    public string Headquarters { get; set; }
    public string Name { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
}