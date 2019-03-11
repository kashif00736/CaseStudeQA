using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_QA.PageObjects
{
    public class TravelexPage
    {
        public void travelexChromeMethod()
        {
            TestClass TC = new TestClass();
            TC.DriverRedirection("https://travelex.co.uk");
            TC.travelexResize();
            TC.CloseBrowser();
            TC.EndTest();
        }

       
    }
}
