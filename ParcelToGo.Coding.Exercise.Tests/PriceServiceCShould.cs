using ParcelToGo.Coding.Exercise.PriceServices;
using FluentAssertions;
namespace ParcelToGo.Coding.Exercise.Tests;
public class PriceServiceCShould
{
    private readonly PriceServiceC _subject;

    public PriceServiceCShould()
    {
        _subject = new PriceServiceC();
    }

    [Fact]
    public void GetTotalPriceShouldReturnZeroWhenQuantityZero()
    {
        _subject.GetTotalPrice(0).Should().Be(0);
    }

    [Fact]
    public void GetTotalPriceShouldReturnUnitPriceWhenQuantityIsOne()
    {
        _subject.GetTotalPrice(1).Should().Be(15);
    }

    [Fact]
    public void GetTotalPriceShouldReturnNoDiscount()
    {
        _subject.GetTotalPrice(3).Should().Be(45);
    }

}
