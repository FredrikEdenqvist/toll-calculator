namespace TollFeeCalculator;

public interface Vehicle
{
    string GetVehicleType();
    bool PaysTollFee { get; }
}

public static class VehicleExtensions
{
    public static bool IsTollFreeVehicle(this Vehicle? vehicle)
    {
        return !(vehicle?.PaysTollFee ?? true);
    }
}

// Side note:
// TollFreeVehicles:
// Motorbike
// Tractor
// Emergency
// Diplomat
// Foreign
// Military