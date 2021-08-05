using System;

namespace Assginments
{
    class CalculateDateOfBirth
    {
       public static int[] UserDateOfBirth(DateTime dob)
        {
            int[] dateOfBirthContainer = new int[3];

            DateTime today = DateTime.Today;   

            int years = new DateTime(DateTime.Now.Subtract(dob).Ticks).Year - 1;
            DateTime pastYearDate = dob.AddYears(years);
            
            int months = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (pastYearDate.AddMonths(i) == today)
                {
                    months = i;
                    break;
                }
                else if (pastYearDate.AddMonths(i) >= today)
                {
                    months = i - 1;
                    break;
                }
            }
            int days    = today.Subtract(pastYearDate.AddMonths(months)).Days;
           
            
            dateOfBirthContainer[0] = years;
            dateOfBirthContainer[1] = months;
            dateOfBirthContainer[2] = days;
            return dateOfBirthContainer;
        }
    }
}
