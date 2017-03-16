using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillPayer
{
    public class BillGraceDateCalculator
    {
      public object CalculateMortgageDate(DateTime dueDate) {
        if (dueDate.DayOfWeek == DayOfWeek.Sunday)
          return dueDate.AddDays(1);
        return dueDate;
      }
    }
}
