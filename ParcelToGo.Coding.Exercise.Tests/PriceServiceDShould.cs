using ParcelToGo.Coding.Exercise.PriceServices;
using FluentAssertions;
namespace ParcelToGo.Coding.Exercise.Tests;
public class PriceServiceDShould
{
    private readonly PriceServiceD _subject;

    public PriceServiceDShould()
    {
        _subject = new PriceServiceD();
    }

    [Fact]
    public void GetTotalPriceShouldReturnZeroWhenQuantityZero()
    {
        _subject.GetTotalPrice(0).Should().Be(0);
    }

    [Fact]
    public void GetTotalPriceShouldReturnUnitPriceWhenQuantityIsOne()
    {
        _subject.GetTotalPrice(1).Should().Be(25);
    }

    [Fact]
    public void GetTotalPriceShouldReturnNoDiscount()
    {
        _subject.GetTotalPrice(3).Should().Be(75);
    }

}
