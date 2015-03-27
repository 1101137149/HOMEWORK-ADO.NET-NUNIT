using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class Class2
    {

        [Test]
        public void CalYear() {
            WebApplication1.Cal cal = new WebApplication1.Cal();
            int inputAge = 30;
            int exoect = 1895;

            Assert.AreEqual(expect, cal, GetBirthYear(inputAge, WebApplication1.Cal.YearFormat.W));
        
        }
    }
}