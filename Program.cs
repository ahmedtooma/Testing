using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Windows.Forms;



namespace Selinum_Test_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver Driver = new ChromeDriver(@"D:\variety\chromedriver_win32");
            //   Driver.Url= "http://www.google.com";
            //Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));

            //  Driver.FindElement(By.ClassName("gsfi")).SendKeys("class name");
            //  Driver.FindElement(By.ClassName("gsfi")).SendKeys(Keys.Enter);
            //      System.Threading.Thread.Sleep(5000);
            //   WebDriverWait web = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            //    web.Until(ExpectedConditions.ElementIsVisible(By.ClassName("r")));

            //  Driver.FindElements(By.ClassName("r"))[2].Click();

            //    Driver.Url = "file:///C:/Users/ahmedfarrag/documents/visual%20studio%202015/Projects/Selinum_Test_Demo/Selinum_Test_Demo/HTMLPage1.html";
            //    Driver.FindElements(By.Name("gender"))[2].Click();
            //    Driver.FindElement(By.Name("status")).Click();
            //    System.Threading.Thread.Sleep(3000);
            //    Driver.FindElement(By.Name("status")).Click();
            //   Driver.FindElement(By.XPath("html/body/form/select")).SendKeys("four");
            //    System.Threading.Thread.Sleep(2000);
            //    Driver.FindElements(By.TagName("option"))[3].Click();
            //    System.Threading.Thread.Sleep(2000);

            /*  
             ________________________________________________________________  
               
              
          _________________________________________________________________
    */
            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            Driver.Url = "http://www.google.com";
            
            Driver.FindElements(By.ClassName("gb_P"))[1].Click();
            Driver.FindElement(By.Id("qbi")).Click();
            Driver.FindElement(By.XPath(".//*[@id='qbug']/div/a")).Click();
            //first with sendcase without pressing button
            //Driver.FindElement(By.Id("qbfile")).SendKeys("C:\\Users\\ahmedfarrag\\Desktop\\iti\\Instagram.png");
            
                 Driver.FindElement(By.Id("qbfile")).Click();
            System.Threading.Thread.Sleep(3000);

            SendKeys.SendWait(@"C:\Users\ahmedfarrag\Desktop\iti\Instagram.png");
            SendKeys.SendWait("{Enter}");


        }
    }
}
