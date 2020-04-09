using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Helpers
{
    public class Validate
    {
        public DateTime ValidateDateTime(DateTime _dateTime)
        {
            string validatedObject = _dateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
            DateTime valid = Convert.ToDateTime(validatedObject);
            return valid;
        }
    }
}
