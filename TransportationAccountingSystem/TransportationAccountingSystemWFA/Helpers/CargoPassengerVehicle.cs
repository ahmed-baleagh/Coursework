using TransportationAccountingSystemWFA.Entities;
using TransportationAccountingSystemWFA.Repositories.Interfaces;

namespace TransportationAccountingSystemWFA.Helpers;

public class CargoPassengerVehicle : Vehicle, ICargo, IPassenger
{
    public int CargoCapacity { get; set; }
    public int PassengerCapacity { get; set; }
}
