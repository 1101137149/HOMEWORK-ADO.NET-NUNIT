//using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WebApplication1
{
    public class Cal
    {
        public enum YearFormat { 
            C=0,
            W=1
        }
        public int GetBirthYear(int age, YearFormat format) {
            int WestYear = (DataTime.Now.Year - age);
            if (format == YearFormat.C)
                return (WestYear - 1911);
            else if(format == YearFormat.W)
                return (WestYear);

            return 0;
        }
    }
}