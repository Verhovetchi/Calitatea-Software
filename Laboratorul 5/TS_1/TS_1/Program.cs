using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS_1
{
     class Program
     {
          static void Main(string[] args)
          {
               IWebDriver driver = new ChromeDriver("C:\\chromedriver_win32");
               driver.Url = "https://www.youtube.com/";
               driver.Manage().Window.Maximize();
               object p = driver.Manage().Timeouts().ImplicitWait;

               driver.FindElement(By.Name("search_query")).Click();
               driver.FindElement(By.Name("search_query")).SendKeys("computer");
               driver.FindElement(By.Id("search-icon-legacy")).Click();
               bool result = driver.FindElement(By.Id("logo-icon-container")).Displayed;
               Console.WriteLine($"The icon is displayed!!! + {result}");
          }
     }
}
