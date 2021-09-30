using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_2___F
{
    static class Extensions
    {
        public static string ToMonth(this int month)
        {
            Enum.TryParse(typeof(months), month.ToString(), out object str);
            return str.ToString();
        }

        public static int CalculateAge(this user user)
        {
                var age = DateTime.Today.Year - user.birthday.Year;

                if (user.birthday.Date > DateTime.Today.AddYears(-age)) age--;

                return age;
        }
    }
}
