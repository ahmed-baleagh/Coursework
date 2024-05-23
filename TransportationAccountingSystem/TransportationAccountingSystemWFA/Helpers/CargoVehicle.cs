using TransportationAccountingSystemWFA.Entities;
using TransportationAccountingSystemWFA.Repositories.Interfaces;

namespace TransportationAccountingSystemWFA.Helpers;

public class CargoVehicle : Vehicle, ICargo
{
    public int CargoCapacity { get; set; }
}
