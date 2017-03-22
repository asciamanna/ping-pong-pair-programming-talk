using System;

namespace BillPayer {
  public class GraceDateCalculator {
    public DateTime CalculateMortgageGraceDate(DateTime dueDate) {
      return CalculateGraceDate(dueDate, 2, 1);
    }

    private static DateTime CalculateGraceDate(DateTime dueDate, int saturdayModifier, int sundayModifier) {
      if (dueDate.DayOfWeek == DayOfWeek.Saturday)
        return dueDate.AddDays(saturdayModifier);
      if (dueDate.DayOfWeek == DayOfWeek.Sunday)
        return dueDate.AddDays(sundayModifier);

      return dueDate;
    }

    public DateTime CalculateWaterBillGraceDate(DateTime dueDate) {
     return CalculateGraceDate(dueDate, -1, -2);
    }
  }
}
