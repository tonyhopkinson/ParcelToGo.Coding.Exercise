using ParcelToGo.Coding.Exercise.PriceServices;
using FluentAssertions;
namespace ParcelToGo.Coding.Exercise.Tests;
public class PriceServiceFShould
{
    private readonly PriceServiceF _subject;

    public PriceServiceFShould()
    {
        _subject = new PriceServiceF();
    }

    [Fact]
    public void GetTotalPriceShouldReturnZeroWhenQuantityZero()
    {
        _subject.GetTotalPrice(0).Should().Be(0);
    }

    [Fact]
    public void GetTotalPriceShouldReturnUnitPriceWhenQuantityIsOne()
    {
        _subject.GetTotalPrice(1).Should().Be(8);
    }

    [Fact]
    public void GetTotalPriceShouldReturnDiscountedPriceWhenQuantityMeetsDiscount()
    {
        _subject.GetTotalPrice(2).Should().Be(15);
    }

    [Fact]
    public void GetTotalPriceShouldReturnSumOfDiscountedandUnitPricesWhenQuanityIsOdd()
    {
        _subject.GetTotalPrice(3).Should().Be(23);
    }

}
