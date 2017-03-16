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
    public void CalculateMortgageDate() {
      var subject = new BillGraceDateCalculator();

      var dueDate = new DateTime(2017, 3, 16);
      var result = subject.CalculateMortgageDate(dueDate);
    }
  }
}
