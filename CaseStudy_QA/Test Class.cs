using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using POMExample.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_QA
{
    public class TestClass
    {
        IWebDriver driver = new ChromeDriver(@"C:\Users\HP\Downloads");


        public void  DriverRedirection(string url)
        {

            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            
        }

        public void CloseBrowser()
        {
            driver.Close();
        }

        public void EndTest()
        {
            driver.Quit();
        }

        public void WikiAssertTitle()
        {
            Assert.AreEqual("Wikipedia", driver.Title);
            Console.WriteLine(driver.Title);
        }

        public void WikiAssertSearch()
        {
            IWebElement searchbox = driver.FindElement(By.Id("searchInput"));
            searchbox.SendKeys("furry rabbits");

            IWebElement searchbutton = driver.FindElement(By.XPath("/html/body/div[2]/form/fieldset/button/i"));
            searchbutton.Click();

            IWebElement DYM = driver.FindElement(By.XPath("/html/body/div[3]/div[3]/div[3]/div[3]"));
            Assert.AreEqual("Did you mean: fury rabbit", DYM.Text);

            //List<IWebElement> searchresults = driver.FindElementByClassName("mw-search-result");
            //Console.WriteLine(searchresults.Count());


            //Here you can the list of elements and count them , others function can also be performed but because of time limit, i am ignoring for now. 

        }


       public void travelexResize()
        {
            driver.Manage().Window.Size = new System.Drawing.Size(550, 320);
            Console.WriteLine(driver.Manage().Window.Size);


        }

    }
    
}
