using System;

namespace BillPayer {
  public class GraceDateCalculator {
    public DateTime CalculateMortgageGraceDate(DateTime dueDate) {
      if (dueDate.DayOfWeek == DayOfWeek.Saturday)
        return dueDate.AddDays(2);
      if (dueDate.DayOfWeek == DayOfWeek.Sunday)
        return dueDate.AddDays(1);

      return dueDate;
    }

    public DateTime CalculateWaterBillGraceDate(DateTime dueDate) {
      return dueDate;
    }
  }
}
