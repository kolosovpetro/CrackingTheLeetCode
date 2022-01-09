using FluentAssertions;
using NUnit.Framework;

namespace CrackingTheLeetCode.Tests;

[TestFixture]
public class InitialTest
{
    [Test]
    public void Initial_Test()
    {
        "test".Length.Should().Be(4);
    }
}