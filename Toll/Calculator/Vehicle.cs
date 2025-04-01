namespace TollFeeCalculator;

/// <summary>
/// TollFreeVehicles:
/// Motorbike
/// Tractor
/// Emergency
/// Diplomat
/// Foreign
/// Military
/// </summary>
public interface Vehicle
{
    string GetVehicleType();
    bool PaysTollFee { get; }
}
