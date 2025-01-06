//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Selenium_Test
//{
//    internal class Register
//    {
//        static void Main(string[] args)
//        {
//            ChromeOptions options = new ChromeOptions();
//            options.AddArgument("--ignore-certificate-errors");
//            IWebDriver driver = new ChromeDriver(options);
//            try
//            {
//                driver.Navigate().GoToUrl("https://responde.bsite.net/Home/Register");

//                IWebElement username = driver.FindElement(By.Name("userName"));
//                username.SendKeys("aziescala");

//                IWebElement email = driver.FindElement(By.Name("email"));
//                email.SendKeys("aziescala@gmail.com");

//                IWebElement passwordField = driver.FindElement(By.Name("userPassword"));
//                passwordField.SendKeys("Admin123-");

//                IWebElement confirmPassField = driver.FindElement(By.Name("confirmPassword"));
//                confirmPassField.SendKeys("Admin123-");

//                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
//                IWebElement submitButton = driver.FindElement(By.XPath("//input[@type='submit' and @value='Register']"));
//                js.ExecuteScript("arguments[0].scrollIntoView(true);", submitButton);
//                submitButton.Click();

//                Console.WriteLine("IT - 005 PASSED - Register");

//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"IT - 005 FAILED - Register");
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
//            //    driver.Navigate().GoToUrl("https://responde.bsite.net/Home/Register");

//            //    IWebElement username = driver.FindElement(By.Name("userName"));
//            //    username.SendKeys("aziescala");

//            //    IWebElement email = driver.FindElement(By.Name("email"));
//            //    email.SendKeys("aziescala@email.com");

//            //    IWebElement passwordField = driver.FindElement(By.Name("userPassword"));
//            //    passwordField.SendKeys("Admin123-");

//            //    IWebElement confirmPassField = driver.FindElement(By.Name("confirmPassword"));
//            //    confirmPassField.SendKeys("Admin123-1");

//            //    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
//            //    IWebElement submitButton = driver.FindElement(By.XPath("//input[@type='submit' and @value='Register']"));
//            //    js.ExecuteScript("arguments[0].scrollIntoView(true);", submitButton);
//            //    submitButton.Click();

//            //    Console.WriteLine("IT - 006 PASSED - Register");

//            //}
//            //catch (Exception ex)
//            //{
//            //    Console.WriteLine($"IT - 006 FAILED - Register");
//            //}
//            //finally
//            //{
//            //    driver.Close();
//            //}
//        }
//    }
//}
