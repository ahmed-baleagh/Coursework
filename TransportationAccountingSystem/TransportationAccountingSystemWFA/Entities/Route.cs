namespace TransportationAccountingSystemWFA.Entities;

public class Route
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int MyProperty { get; set; }
    public string IdFrom {  get; set; }
    public string IdDestination { get; set; }
    public string Vehicle { get; set; }
    public int Volume {  get; set; }
    public int Passenger {  get; set; }
}
