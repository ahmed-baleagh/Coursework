namespace TransportationAccountingSystemWFA.Entities;

public abstract class Vehicle
{
    public int VehicleId { get; set; }
    public string StateNumber { get; set; }
    public int Model { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int Mileage { get; set; }
}
