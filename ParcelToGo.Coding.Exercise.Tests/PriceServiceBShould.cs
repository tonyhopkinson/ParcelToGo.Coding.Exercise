using ParcelToGo.Coding.Exercise.PriceServices;
using FluentAssertions;
namespace ParcelToGo.Coding.Exercise.Tests;
public class PriceServiceBShould
{
    private readonly PriceServiceB _subject;

    public PriceServiceBShould()
    {
        _subject = new PriceServiceB();
    }

    [Fact]
    public void GetTotalPriceShouldReturnZeroWhenQuantityZero()
    {
        _subject.GetTotalPrice(0).Should().Be(0);
    }

    [Fact]
    public void GetTotalPriceShouldReturnUnitPriceWhenQuantityIsOne()
    {
        _subject.GetTotalPrice(1).Should().Be(12);
    }

    [Fact]
    public void GetTotalPriceShouldReturnDiscountedPriceWhenQuantityMeetsDiscount()
    {
        _subject.GetTotalPrice(2).Should().Be(20);
    }

    [Fact]
    public void GetTotalPriceShouldReturnSumOfDiscountedandUnitPricesWhenQuanityIsOdd()
    {
        _subject.GetTotalPrice(3).Should().Be(32);
    }

}
