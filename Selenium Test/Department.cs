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
//    internal class Department
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


//                IWebElement departmentLink = driver.FindElement(By.XPath("//a[@href='/ManageDepartment/Department']"));
//                departmentLink.Click();
//                Thread.Sleep(3000);

//                IWebElement createDepartmentButton = driver.FindElement(By.XPath("//a[@href='/ManageDepartment/CreateDepartment']"));
//                createDepartmentButton.Click();
//                Thread.Sleep(3000);

//                IWebElement departmentName = driver.FindElement(By.Id("departmentName"));
//                departmentName.SendKeys("CCS- Testing");
//                Thread.Sleep(2000);

//                IWebElement departmentHead = driver.FindElement(By.Id("departmentHead"));
//                departmentHead.SendKeys("Head - Testing");
//                Thread.Sleep(2000);

//                IWebElement contactDetails = driver.FindElement(By.Id("contactDetails"));
//                contactDetails.SendKeys("Head@gmail.com");
//                Thread.Sleep(2000);

//                IWebElement submitButton = driver.FindElement(By.XPath("//input[@type='submit' and @value='Create']"));
//                submitButton.Click();
//                Thread.Sleep(3000);

//                Console.WriteLine("IT - 037 PASSED - Create Department");

//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"IT - 037 FAILED - Exception occurred: {ex.Message}");
//            }
//            finally
//            {
//                driver.Close();
//            }
//        }
//    }
//}
