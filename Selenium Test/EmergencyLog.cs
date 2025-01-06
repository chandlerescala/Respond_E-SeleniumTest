//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;
//using OpenQA.Selenium.Interactions;

//namespace Selenium_Test
//{
//    internal class EmergencyLog
//    {
//        static void Main(string[] args)
//        {
//            // Set ChromeOptions to bypass SSL certificate errors
//            ChromeOptions options = new ChromeOptions();
//            options.AddArgument("--ignore-certificate-errors");
//            IWebDriver driver = new ChromeDriver(options);
//            try
//            {
//                driver.Navigate().GoToUrl("https://responde.bsite.net/Home/Logi");
//                Thread.Sleep(2000);

//                IWebElement username = driver.FindElement(By.Name("userName"));
//                username.SendKeys("chandlerescala");
//                Thread.Sleep(2000);

//                IWebElement password = driver.FindElement(By.Name("userPassword"));
//                password.SendKeys("Admin123-");
//                Thread.Sleep(2000);

//                IWebElement loginButton = driver.FindElement(By.XPath("//input[@value='Login']"));
//                loginButton.Click();
//                Thread.Sleep(3000);


//                IWebElement manageDropDown = driver.FindElement(By.Id("navbarDropdownMenuLink"));
//                manageDropDown.Click();
//                Thread.Sleep(3000);


//                IWebElement departmentLink = driver.FindElement(By.XPath("//a[@href='/ManageEmergencyLog/EmergencyLog']"));
//                departmentLink.Click();

//                IWebElement create = driver.FindElement(By.XPath("//a[@href='/ManageEmergencyLog/CreateEmergencyLog']"));
//                create.Click();

//                IWebElement name = driver.FindElement(By.Name("name"));
//                name.SendKeys("Earthquake case at Location C");

//                IWebElement actionTaken = driver.FindElement(By.Name("actionTaken"));
//                actionTaken.SendKeys("We Evacuate the civilians immediately...");

//                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
//                IWebElement submitButton = driver.FindElement(By.XPath("//input[@type='submit' and @value='Create']"));
//                js.ExecuteScript("arguments[0].scrollIntoView(true);", submitButton);
//                submitButton.Click();

//                Console.WriteLine("PASSED - Create Emergency Log");

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
