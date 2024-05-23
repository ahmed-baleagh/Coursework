using TransportationAccountingSystemWFA.Entities;
using TransportationAccountingSystemWFA.Repositories.Interfaces;

namespace TransportationAccountingSystemWFA.Helpers;

public class PassengerVehicle : Vehicle, IPassenger
{
    public int PassengerCapacity { get; set; }
}
