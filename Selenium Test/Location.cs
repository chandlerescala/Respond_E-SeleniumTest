//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace Selenium_Test
//{
//    internal class Location
//    {
//        static void Main(string[] args)
//        {
//            // Set ChromeOptions to bypass SSL certificate errors
//            ChromeOptions options = new ChromeOptions();
//            options.AddArgument("--ignore-certificate-errors");
//            IWebDriver driver = new ChromeDriver(options);
//            try
//            {
//                driver.Navigate().GoToUrl("http://responde.somee.com/Home/Login");
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


//                IWebElement departmentLink = driver.FindElement(By.XPath("//a[@href='/ManageLocation/Location']"));
//                departmentLink.Click();
//                Thread.Sleep(3000);

//                IWebElement createDepartmentButton = driver.FindElement(By.XPath("//a[@href='/ManageLocation/CreateLocation']"));
//                createDepartmentButton.Click();
//                Thread.Sleep(3000);

//                IWebElement locationName = driver.FindElement(By.Id("locationName"));
//                locationName.SendKeys("Location C");
//                Thread.Sleep(2000);

//                IWebElement longitude = driver.FindElement(By.Id("longitude"));
//                longitude.SendKeys("123.23");
//                Thread.Sleep(2000);

//                IWebElement latitude = driver.FindElement(By.Id("latitude"));
//                latitude.SendKeys("124.32");
//                Thread.Sleep(2000);

//                IWebElement submitButton = driver.FindElement(By.XPath("//input[@type='submit' and @value='Create']"));
//                submitButton.Click();
//                Thread.Sleep(3000);

//                Console.WriteLine("IT - 043 PASSED - Create Location");

//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"IT - 043 FAILED - Exception occurred: {ex.Message}");
//            }
//            finally
//            {
//                driver.Close();
//            }
//        }
//    }
//}
