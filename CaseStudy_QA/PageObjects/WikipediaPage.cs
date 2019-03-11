using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaseStudy_QA;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace POMExample.PageObjects
    {
    public class WikipediaPage
    {

        public void WikiChromeMethod()
        {
            TestClass TC = new TestClass();
            TC.DriverRedirection("https://wikipedia.org");
            TC.WikiAssertTitle();
            TC.WikiAssertSearch();
            TC.CloseBrowser();
            TC.EndTest();
        }


    
    }
    }
