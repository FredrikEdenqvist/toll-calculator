namespace TollFeeCalculator;

public static class VehicleExtensions
{
    public static bool IsTollFreeVehicle(this Vehicle? vehicle)
    {
        return !(vehicle?.PaysTollFee ?? true);
    }
}
