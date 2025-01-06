//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Selenium_Test
//{
//    internal class GenerateReport
//    {
//        static void Main(string[] args)
//        {
//            ChromeOptions options = new ChromeOptions();
//            options.AddArgument("--ignore-certificate-errors");
//            IWebDriver driver = new ChromeDriver(options);

//            try
//            {
//                driver.Navigate().GoToUrl("https://responde.bsite.net/Home/Login");
//                IWebElement username = driver.FindElement(By.Name("userName"));
//                username.SendKeys("chandlerescala");

//                IWebElement password = driver.FindElement(By.Name("userPassword"));
//                password.SendKeys("Admin123-");

//                IWebElement loginButton = driver.FindElement(By.XPath("//input[@value='Login']"));
//                loginButton.Click();

//                driver.FindElement(By.Id("savePdf")).Click();

//                Console.WriteLine("PASSED - Generate Report");

//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"FAILED - Exception occurred: {ex.Message}");
//            }
//            finally
//            {
//                driver.Close();
//            }
//        }

//    }
//}
