using System;
using NUnit.Framework;

namespace BillPayer.Tests {
  [TestFixture]
  public class BillGraceDateCalculatorTest {
    private BillGraceDateCalculator subject;

    [SetUp]
    public void SetUp() {
      subject = new BillGraceDateCalculator();
    }

    [Test]
    public void CalculateMortgageDate_Returns_DueDate_When_DueDate_Is_A_Business_Day() {
      var dueDate = new DateTime(2017, 3, 16);

      var result = subject.CalculateMortgageDate(dueDate);

      Assert.That(result, Is.EqualTo(dueDate));
    }

    [Test]
    public void CalculateMortgageDate_Returns_Next_Monday_When_DueDate_Is_A_Sunday() {
      var dueDate = new DateTime(2017, 3, 19);
      var nextMonday = new DateTime(2017, 3, 20);

      var result = subject.CalculateMortgageDate(dueDate);

      Assert.That(result, Is.EqualTo(nextMonday));
    }

    [Test]
    public void CalculateMortgageDate_Returns_Next_Monday_When_DueDate_Is_A_Saturday() {
      var dueDate = new DateTime(2017, 3, 18);
      var nextMonday = new DateTime(2017, 3, 20);

      var result = subject.CalculateMortgageDate(dueDate);

      Assert.That(result, Is.EqualTo(nextMonday));
    }
  }
}
