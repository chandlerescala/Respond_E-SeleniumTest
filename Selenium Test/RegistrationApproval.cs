//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OpenQA.Selenium.Support.UI;

//namespace Selenium_Test
//{
//    internal class RegistrationApproval
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
//                username.SendKeys("admin");

//                IWebElement password = driver.FindElement(By.Name("userPassword"));
//                password.SendKeys("Admin123-");

//                IWebElement loginButton = driver.FindElement(By.XPath("//input[@value='Login']"));
//                loginButton.Click();

//                IWebElement registrationApproval = driver.FindElement(By.XPath("//a[@href='/Home/RegisterApproval']"));
//                registrationApproval.Click();

//                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

//                driver.FindElement(By.XPath("//button[text()='Approve']")).Click();

//                IWebElement confirmButton = wait.Until(d => d.FindElement(By.Id("confirmButton")));
//                confirmButton.Click();

//               Console.WriteLine("IT - 007 PASSED - Registration Approval");

//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"IT - 007 FAILED - Registration Approval");
//            }
//            finally
//            {
//                driver.Close();
//            }

//            //try
//            //{
//            //    driver.Navigate().GoToUrl("https://responde.bsite.net/Home/Login");

//            //    IWebElement username = driver.FindElement(By.Name("userName"));
//            //    username.SendKeys("admin");

//            //    IWebElement password = driver.FindElement(By.Name("userPassword"));
//            //    password.SendKeys("Admin123-");

//            //    IWebElement loginButton = driver.FindElement(By.XPath("//input[@value='Login']"));
//            //    loginButton.Click();

//            //    IWebElement registrationApproval = driver.FindElement(By.XPath("//a[@href='/Home/RegisterApproval']"));
//            //    registrationApproval.Click();

//            //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

//            //    driver.FindElement(By.XPath("//button[text()='Decline']")).Click();


//            //    IWebElement confirmButton = wait.Until(d => d.FindElement(By.Id("confirmButton")));
//            //    confirmButton.Click();


//            //    Console.WriteLine("IT - 008 PASSED - Admin Registration Approval");

//            //}
//            //catch (Exception ex)
//            //{
//            //    Console.WriteLine($"IT - 008 FAILED - Admin Registration Approval");
//            //}
//            //finally
//            //{
//            //    driver.Close();
//            //}
//        }
//    }
//}
