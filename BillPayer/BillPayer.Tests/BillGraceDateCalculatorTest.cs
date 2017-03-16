using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BillPayer.Tests {
  [TestFixture]
  public class BillGraceDateCalculatorTest {

    [Test]
    public void CalculateMortgageDate_Returns_DueDate_When_DueDate_Is_A_Business_Day() {
      var dueDate = new DateTime(2017, 3, 16);

      var subject = new BillGraceDateCalculator();
      var result = subject.CalculateMortgageDate(dueDate);

      Assert.That(result, Is.EqualTo(dueDate));
    }
  }
}
