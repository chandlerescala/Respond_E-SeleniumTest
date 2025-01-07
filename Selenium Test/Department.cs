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
//            //try
//            //{
//            //    driver.Navigate().GoToUrl("https://responde.bsite.net/Home/Login");
//            //    Thread.Sleep(2000);

//            //    IWebElement username = driver.FindElement(By.Name("userName"));
//            //    username.SendKeys("chandlerescala");
//            //    Thread.Sleep(2000);

//            //    IWebElement password = driver.FindElement(By.Name("userPassword"));
//            //    password.SendKeys("Admin123-");
//            //    Thread.Sleep(2000);

//            //    IWebElement loginButton = driver.FindElement(By.XPath("//input[@value='Login']"));
//            //    loginButton.Click();
//            //    Thread.Sleep(3000);


//            //    IWebElement manageDropDown = driver.FindElement(By.Id("navbarDropdownMenuLink"));
//            //    manageDropDown.Click();
//            //    Thread.Sleep(3000);


//            //    IWebElement departmentLink = driver.FindElement(By.XPath("//a[@href='/ManageDepartment/Department']"));
//            //    departmentLink.Click();

//            //    IWebElement createDepartmentButton = driver.FindElement(By.XPath("//a[@href='/ManageDepartment/CreateDepartment']"));
//            //    createDepartmentButton.Click();

//            //    IWebElement departmentName = driver.FindElement(By.Id("departmentName"));
//            //    departmentName.SendKeys("");

//            //    IWebElement departmentHead = driver.FindElement(By.Id("departmentHead"));
//            //    departmentHead.SendKeys("");

//            //    IWebElement submitButton = driver.FindElement(By.XPath("//input[@type='submit' and @value='Create']"));
//            //    submitButton.Click();

//            //    Console.WriteLine("PASSED");

//            //}
//            //catch (Exception ex)
//            //{
//            //    Console.WriteLine($"FAILED - Exception occurred: {ex.Message}");
//            //}
//            //finally
//            //{
//            //    driver.Close();
//            //}

//            //try
//            //{
//            //    driver.Navigate().GoToUrl("https://responde.bsite.net/Home/Login");
//            //    Thread.Sleep(2000);

//            //    IWebElement username = driver.FindElement(By.Name("userName"));
//            //    username.SendKeys("chandlerescala");
//            //    Thread.Sleep(2000);

//            //    IWebElement password = driver.FindElement(By.Name("userPassword"));
//            //    password.SendKeys("Admin123-");
//            //    Thread.Sleep(2000);

//            //    IWebElement loginButton = driver.FindElement(By.XPath("//input[@value='Login']"));
//            //    loginButton.Click();
//            //    Thread.Sleep(3000);


//            //    IWebElement manageDropDown = driver.FindElement(By.Id("navbarDropdownMenuLink"));
//            //    manageDropDown.Click();
//            //    Thread.Sleep(3000);


//            //    IWebElement departmentLink = driver.FindElement(By.XPath("//a[@href='/ManageDepartment/Department']"));
//            //    departmentLink.Click();

//            //    IList<IWebElement> buttons = driver.FindElements(By.CssSelector("button.btn3.btn-info"));
//            //    buttons[0].Click();

//            //    Console.WriteLine("PASSED");

//            //}
//            //catch (Exception ex)
//            //{
//            //    Console.WriteLine($"FAILED - Exception occurred: {ex.Message}");
//            //}
//            //finally
//            //{
//            //    driver.Close();
//            //}

//            //try
//            //{
//            //    driver.Navigate().GoToUrl("https://responde.bsite.net/Home/Login");

//            //    IWebElement username = driver.FindElement(By.Name("userName"));
//            //    username.SendKeys("chandlerescala");

//            //    IWebElement password = driver.FindElement(By.Name("userPassword"));
//            //    password.SendKeys("Admin123-");

//            //    IWebElement loginButton = driver.FindElement(By.XPath("//input[@value='Login']"));
//            //    loginButton.Click();

//            //    IWebElement manageDropDown = driver.FindElement(By.Id("navbarDropdownMenuLink"));
//            //    manageDropDown.Click();

//            //    IWebElement departmentLink = driver.FindElement(By.XPath("//a[@href='/ManageDepartment/Department']"));
//            //    departmentLink.Click();

//            //    IList<IWebElement> buttons = driver.FindElements(By.CssSelector("button.btn3.btn-info"));
//            //    buttons[0].Click();

//            //    IWebElement anchor = driver.FindElement(By.CssSelector("a.btn1.btn-primary.col-12"));
//            //    anchor.Click();

//            //    IWebElement departmentName = driver.FindElement(By.Id("departmentName"));
//            //    departmentName.Clear();

//            //    IWebElement departmentHead = driver.FindElement(By.Id("departmentHead"));
//            //    departmentHead.Clear();
//            //    departmentHead.SendKeys("New Head");

//            //    IWebElement submitButton = driver.FindElement(By.XPath("//input[@type='submit' and @value='Save']"));
//            //    submitButton.Click();

//            //    Console.WriteLine("PASSED");

//            //}
//            //catch (Exception ex)
//            //{
//            //    Console.WriteLine($"FAILED - Exception occurred: {ex.Message}");
//            //}
//            //finally
//            //{
//            //    driver.Close();
//            //}

//            try
//            {
//                driver.Navigate().GoToUrl("https://responde.bsite.net/Home/Login");

//                IWebElement username = driver.FindElement(By.Name("userName"));
//                username.SendKeys("chandlerescala");

//                IWebElement password = driver.FindElement(By.Name("userPassword"));
//                password.SendKeys("Admin123-");

//                IWebElement loginButton = driver.FindElement(By.XPath("//input[@value='Login']"));
//                loginButton.Click();

//                IWebElement manageDropDown = driver.FindElement(By.Id("navbarDropdownMenuLink"));
//                manageDropDown.Click();

//                IWebElement departmentLink = driver.FindElement(By.XPath("//a[@href='/ManageDepartment/Department']"));
//                departmentLink.Click();

//                IWebElement deleteButton = driver.FindElement(By.XPath("//button[contains(@onclick, 'confirmDeleteModal')]"));
//                deleteButton.Click();

//                IWebElement confirmDeleteButton = driver.FindElement(By.Id("confirmDeleteButton"));
//                confirmDeleteButton.Click();

//                Console.WriteLine("PASSED");

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
