namespace TollFeeCalculator;

public class Motorbike : Vehicle
{
    public string GetVehicleType() => "Motorbike";
    public bool PaysTollFee => false;
}
