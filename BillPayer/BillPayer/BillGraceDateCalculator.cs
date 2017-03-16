using System;

namespace BillPayer {
  public class BillGraceDateCalculator {
    public DateTime CalculateMortgageDate(DateTime dueDate) {
      if (dueDate.DayOfWeek == DayOfWeek.Saturday)
        return dueDate.AddDays(2);
      if (dueDate.DayOfWeek == DayOfWeek.Sunday)
        return dueDate.AddDays(1);

      return dueDate;
    }
  }
}
