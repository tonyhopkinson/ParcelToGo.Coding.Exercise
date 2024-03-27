using ParcelToGo.Coding.Exercise.PriceServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using ParcelToGo.Coding.Exercise.Interfaces;
using NSubstitute;
namespace ParcelToGo.Coding.Exercise.Tests;
public class PriceServiceCollectionShould
{
    private readonly PriceServiceCollection _subject;

    public PriceServiceCollectionShould()
    {
        _subject = new PriceServiceCollection();
    }

    [Fact]
    public void GetShouldReturnNullWhenNoServices()
    {
        _subject.Get("Don'tCare").Should().BeNull();
    }

    [Fact]
    public void GetShouldReturnNullWhenServiceDoesNotExist()
    {
        IPriceService service = Substitute.For<IPriceService>();
        service.Name.Returns("Exists");
        _subject.Add(service);

        _subject.Get("Doesn't Exist").Should().BeNull();
    }

    [Fact]
    public void GetShouldReturnService()
    {
        IPriceService serviceA = Substitute.For<IPriceService>();
        serviceA.Name.Returns("A");
        _subject.Add(serviceA);
        IPriceService serviceB = Substitute.For<IPriceService>();
        serviceB.Name.Returns("B");
        _subject.Add(serviceB);

        _subject.Get("A").Should().Be(serviceA);
    }
}
