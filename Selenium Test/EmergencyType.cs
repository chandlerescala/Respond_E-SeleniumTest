//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace Selenium_Test
//{
//    internal class EmergencyType
//    {
//        static void Main(string[] args)
//        {
//            // Set ChromeOptions to bypass SSL certificate errors
//            //ChromeOptions options = new ChromeOptions();
//            //options.AddArgument("--ignore-certificate-errors");
//            //IWebDriver driver = new ChromeDriver(options);
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

//            //    IWebElement emergencyTypeLink = driver.FindElement(By.XPath("//a[@href='/ManageEmergency/Emergency']"));
//            //    emergencyTypeLink.Click();


//            //    IWebElement createEmergencyButton = driver.FindElement(By.XPath("//a[@href='/ManageEmergency/CreateEmergency']"));
//            //    createEmergencyButton.Click();

//            //    //IWebElement emergencyName = driver.FindElement(By.Id("emergencyName"));
//            //    //emergencyName.SendKeys("Testing Selenium Emergency");

//            //    IWebElement submitButton = driver.FindElement(By.XPath("//input[@type='submit' and @value='Create']"));
//            //    submitButton.Click();

//            //    Console.WriteLine("PASSED - Create Emergency Type");

//            //}
//            //catch (Exception ex)
//            //{
//            //    Console.WriteLine($"FAILED - Exception occurred: {ex.Message}");
//            //}
//            //finally
//            //{
//            //    driver.Close();
//            //}

//            //ChromeOptions options = new ChromeOptions();
//            //options.AddArgument("--ignore-certificate-errors");
//            //IWebDriver driver = new ChromeDriver(options);
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

//            //    IWebElement emergencyTypeLink = driver.FindElement(By.XPath("//a[@href='/ManageEmergency/Emergency']"));
//            //    emergencyTypeLink.Click();

//            //    IList<IWebElement> buttons = driver.FindElements(By.CssSelector("button.btn3.btn-info"));
//            //    buttons[0].Click();

//            //    Console.WriteLine("PASSED - View Emergency Type");

//            //}
//            //catch (Exception ex)
//            //{
//            //    Console.WriteLine($"FAILED - Exception occurred: {ex.Message}");
//            //}
//            //finally
//            //{
//            //    driver.Close();
//            //}

//            // Set ChromeOptions to bypass SSL certificate errors
//            //ChromeOptions options = new ChromeOptions();
//            //options.AddArgument("--ignore-certificate-errors");
//            //IWebDriver driver = new ChromeDriver(options);
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

//            //    IWebElement emergencyTypeLink = driver.FindElement(By.XPath("//a[@href='/ManageEmergency/Emergency']"));
//            //    emergencyTypeLink.Click();

//            //    IList<IWebElement> buttons = driver.FindElements(By.CssSelector("button.btn3.btn-info"));
//            //    buttons[0].Click();

//            //    IWebElement anchor = driver.FindElement(By.CssSelector("a.btn1.btn-primary.col-12"));
//            //    anchor.Click();


//            //    IWebElement emergency = driver.FindElement(By.Id("emergencyName"));
//            //    emergency.Clear();

//            //    //IWebElement emergencyName = driver.FindElement(By.Id("emergencyName"));
//            //    //emergencyName.SendKeys("Editing");

//            //    IWebElement submitButton = driver.FindElement(By.XPath("//input[@type='submit' and @value='Save']"));
//            //    submitButton.Click();

//            //    Console.WriteLine("PASSED - Edit Emergency Type");

//            //}
//            //catch (Exception ex)
//            //{
//            //    Console.WriteLine($"FAILED - Exception occurred: {ex.Message}");
//            //}
//            //finally
//            //{
//            //    driver.Close();
//            //}

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

//                IWebElement manageDropDown = driver.FindElement(By.Id("navbarDropdownMenuLink"));
//                manageDropDown.Click();

//                IWebElement emergencyTypeLink = driver.FindElement(By.XPath("//a[@href='/ManageEmergency/Emergency']"));
//                emergencyTypeLink.Click();

//                driver.FindElement(By.CssSelector("i.ti-trash")).Click();

//                driver.FindElement(By.Id("confirmDeleteButton")).Click();


//                Console.WriteLine("PASSED - Delete Emergency Type");

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