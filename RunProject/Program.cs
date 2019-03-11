using POMExample.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunProject
{
    class Program
    {
        static void Main(string[] args)
        {


            WikipediaPage wiki = new WikipediaPage();
            wiki.WikiChromeMethod();

            CaseStudy_QA.PageObjects.TravelexPage tp = new CaseStudy_QA.PageObjects.TravelexPage();
            tp.travelexChromeMethod();



        }
    }
}
