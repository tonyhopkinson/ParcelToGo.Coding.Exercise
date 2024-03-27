using ParcelToGo.Coding.Exercise.PriceServices;
using FluentAssertions;
namespace ParcelToGo.Coding.Exercise.Tests;
public class PriceServiceAShould
{
    private readonly PriceServiceA _subject;

    public PriceServiceAShould()
    {
        _subject = new PriceServiceA();
    }

    [Fact]
    public void GetTotalPriceShouldReturnZeroWhenQuantityZero()
    {
        _subject.GetTotalPrice(0).Should().Be(0);
    }

    [Fact]
    public void GetTotalPriceShouldReturnUnitPriceWhenQuantityIsOne()
    {
        _subject.GetTotalPrice(1).Should().Be(10);
    }

    [Fact]
    public void GetTotalPriceShouldReturnDiscountedPriceWhenQuantityMeetsDiscount()
    {
        _subject.GetTotalPrice(3).Should().Be(25);
    }

    [Fact]
    public void GetTotalPriceShouldReturnSumOfDiscountedandUnitPricesWhenQuanityIsNotDivisibleByThree()
    {
        _subject.GetTotalPrice(5).Should().Be(45);
    }

}
