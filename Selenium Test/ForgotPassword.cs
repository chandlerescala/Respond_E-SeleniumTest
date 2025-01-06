//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Selenium_Test
//{
//    internal class ForgotPassword
//    {
//        static void Main(string[] args)
//        {
//            ChromeOptions options = new ChromeOptions();
//            options.AddArgument("--ignore-certificate-errors");
//            IWebDriver driver = new ChromeDriver(options);
//            try
//            {
//                driver.Navigate().GoToUrl("https://responde.bsite.net/Home/ForgotPassword");

//                IWebElement email = driver.FindElement(By.Name("email"));
//                email.SendKeys("escalachandler@gmail.com");

//                IWebElement loginButton = driver.FindElement(By.XPath("//input[@value='Submit']"));
//                loginButton.Click();

//                Console.WriteLine("IT - 003 PASSED - Forgot Password");

//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"IT - 003 FAILED - Forgot Password");
//            }
//            finally
//            {
//                driver.Close();
//            }

//            //ChromeOptions options = new ChromeOptions();
//            //options.AddArgument("--ignore-certificate-errors");
//            //IWebDriver driver = new ChromeDriver(options);
//            //try
//            //{
//            //    driver.Navigate().GoToUrl("https://responde.bsite.net/Home/ForgotPassword");

//            //    IWebElement email = driver.FindElement(By.Name("email"));
//            //    email.SendKeys("chandler111@gmail.com");

//            //    IWebElement loginButton = driver.FindElement(By.XPath("//input[@value='Submit']"));
//            //    loginButton.Click();

//            //    Console.WriteLine("IT - 004 PASSED - Forgot Password");

//            //}
//            //catch (Exception ex)
//            //{
//            //    Console.WriteLine($"IT - 004 FAILED - Forgot Password");
//            //}
//            //finally
//            //{
//            //    driver.Close();
//            //}
//        }
//    }
//}
