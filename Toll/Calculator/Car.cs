namespace TollFeeCalculator;

public class Car : Vehicle
{
    public String GetVehicleType() => "Car";
    public bool PaysTollFee => true;
}