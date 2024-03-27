namespace ParcelToGo.Coding.Exercise.Tests;
using FluentAssertions;
using ParcelToGo.Coding.Exercise.PriceServices;

public class CodingExerciseTestsShould
{
    private readonly Checkout _subject;
    private readonly PriceServiceCollection _priceServices;
    public CodingExerciseTestsShould()
    {
        _priceServices = new PriceServiceCollection();
        _priceServices.Add(new PriceServiceB());
        _priceServices.Add(new PriceServiceC());
        _priceServices.Add(new PriceServiceF());
        _subject = new Checkout(_priceServices);
    }

    [Fact]
    public void Example1ShouldReturnCorrectPrice()
    {
        _subject.Scan("B");
        _subject.Scan("B");
        _subject.GetTotalPrice().Should().Be(20);
    }

    [Fact]
    public void Example2ShouldReturnCorrectPrice()
    {
        _subject.Scan("F");
        _subject.Scan("C");
        _subject.GetTotalPrice().Should().Be(23);
    }

    [Fact]
    public void Example3ShouldReturnCorrectPrice()
    {
        _subject.Scan("F");
        _subject.Scan("F");
        _subject.Scan("B");
        _subject.GetTotalPrice().Should().Be(27);
    }



}