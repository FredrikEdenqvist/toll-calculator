using TollFeeCalculator;

namespace CalculatorTests.Calculator.GetTollFeeTests;
public class HourPeriodTests
{
    [Fact]
    public void Given_vehicle_Motorbike_fee_is_zero()
    {
        int fee = new TollCalculator().GetTollFee(new Motorbike(), [
            new DateTime(2014, 1, 1, 7, 0, 0), // => 18
            new DateTime(2014, 1, 1, 8, 0, 0)  // => 13
        ]);

        Assert.Equal(0, fee);
    }

    [Fact]
    public void Given_vehicle_with_fee_only_pay_once_during_one_hour()
    {
        int fee = new TollCalculator().GetTollFee(new Car(), [
            new DateTime(2014, 1, 1, 7, 0, 0), // => 18
            new DateTime(2014, 1, 1, 7, 59, 0), // => 18
        ]);

        Assert.Equal(18, fee);
    }

    [Fact]
    public void Given_vehicle_with_fee_only_pay_twice_during_two_hour()
    {
        int fee = new TollCalculator().GetTollFee(new Car(), [
            new DateTime(2014, 1, 1, 7, 0, 0), // => 18
            new DateTime(2014, 1, 1, 7, 59, 0), // => 18
            new DateTime(2014, 1, 1, 8, 0, 0), // => 13
        ]);

        Assert.Equal(18 + 13, fee);
    }

    [Fact]
    public void Given_vehicle_with_fee_only_pay_once_every_hour()
    {
        int fee = new TollCalculator().GetTollFee(new Car(), [
            new DateTime(2014, 1, 1, 7, 0, 0), // => 18
            new DateTime(2014, 1, 1, 8, 0, 0), // => 13
            new DateTime(2014, 1, 1, 9, 30, 0), // => 8
            new DateTime(2014, 1, 1, 10, 30, 0), // => 8
            new DateTime(2014, 1, 1, 11, 30, 0) // => 8
        ]);

        Assert.Equal(18 + 13 + 8 + 8 + 8, fee);
    }

    [Fact]
    public void Given_vehicle_with_fee_only_pay_maximum_60()
    {
        int fee = new TollCalculator().GetTollFee(new Car(), [
            new DateTime(2014, 1, 1, 7, 0, 0), // => 18
            new DateTime(2014, 1, 1, 8, 0, 0), // => 13
            new DateTime(2014, 1, 1, 9, 30, 0), // => 8
            new DateTime(2014, 1, 1, 10, 30, 0), // => 8
            new DateTime(2014, 1, 1, 11, 30, 0), // => 8
            new DateTime(2014, 1, 1, 12, 30, 0) // => 8

        ]);

        Assert.Equal(60, fee);
    }
}
