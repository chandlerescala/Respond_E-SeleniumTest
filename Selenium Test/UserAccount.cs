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
//    internal class UserAccount
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

//                IWebElement manageDropDown = driver.FindElement(By.Id("navbarDropdownMenuLink"));
//                manageDropDown.Click();

//                IWebElement manage = driver.FindElement(By.XPath("//a[@href='/UserAccount/UserAccount']"));
//                manage.Click();


//                IWebElement button = driver.FindElement(By.XPath("//a[@href='/UserAccount/Create']"));
//                button.Click();

//                IWebElement user = driver.FindElement(By.Name("userName"));
//                user.SendKeys("testingAccount");

//                IWebElement email = driver.FindElement(By.Name("email"));
//                email.SendKeys("testing@.com");

//                IWebElement pass = driver.FindElement(By.Name("userPassword"));
//                pass.SendKeys("admin123");

//                IWebElement dropdown = driver.FindElement(By.Id("roleId"));
//                SelectElement select = new SelectElement(dropdown);
//                select.SelectByValue("1");


//                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
//                IWebElement submitButton = driver.FindElement(By.XPath("//input[@type='submit' and @value='Create']"));
//                js.ExecuteScript("arguments[0].scrollIntoView(true);", submitButton);
//                submitButton.Click();

//                Console.WriteLine("PASSED");

//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"FAILED");
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

//            //    IWebElement manageDropDown = driver.FindElement(By.Id("navbarDropdownMenuLink"));
//            //    manageDropDown.Click();

//            //    IWebElement manage = driver.FindElement(By.XPath("//a[@href='/UserAccount/UserAccount']"));
//            //    manage.Click();

//            //    IList<IWebElement> buttons = driver.FindElements(By.CssSelector("button.btn3.btn-info"));
//            //    buttons[0].Click();


//            //    Console.WriteLine("PASSED");

//            //}
//            //catch (Exception ex)
//            //{
//            //    Console.WriteLine($"FAILED");
//            //}
//            //finally
//            //{
//            //    driver.Close();
//            //}

//            //try
//            //{
//            //    driver.Navigate().GoToUrl("https://responde.bsite.net/Home/Login");

//            //    IWebElement username = driver.FindElement(By.Name("userName"));
//            //    username.SendKeys("admin");

//            //    IWebElement password = driver.FindElement(By.Name("userPassword"));
//            //    password.SendKeys("Admin123-");

//            //    IWebElement loginButton = driver.FindElement(By.XPath("//input[@value='Login']"));
//            //    loginButton.Click();

//            //    IWebElement manageDropDown = driver.FindElement(By.Id("navbarDropdownMenuLink"));
//            //    manageDropDown.Click();

//            //    IWebElement manage = driver.FindElement(By.XPath("//a[@href='/UserAccount/UserAccount']"));
//            //    manage.Click();


//            //    IWebElement icon = driver.FindElement(By.CssSelector("i.ti-pencil-alt"));
//            //    icon.Click();

//            //    IWebElement email = driver.FindElement(By.Name("email"));
//            //    email.Clear();
//            //    email.SendKeys("escalachandler@gmail.com");

//            //    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
//            //    IWebElement submitButton = driver.FindElement(By.XPath("//input[@type='submit' and @value='Save']"));
//            //    js.ExecuteScript("arguments[0].scrollIntoView(true);", submitButton);
//            //    submitButton.Click();

//            //    Console.WriteLine("PASSED");

//            //}
//            //catch (Exception ex)
//            //{
//            //    Console.WriteLine($"FAILED");
//            //}
//            //finally
//            //{
//            //    driver.Close();
//            //}

//            //try
//            //{
//            //    driver.Navigate().GoToUrl("https://responde.bsite.net/Home/Login");

//            //    IWebElement username = driver.FindElement(By.Name("userName"));
//            //    username.SendKeys("admin");

//            //    IWebElement password = driver.FindElement(By.Name("userPassword"));
//            //    password.SendKeys("Admin123-");

//            //    IWebElement loginButton = driver.FindElement(By.XPath("//input[@value='Login']"));
//            //    loginButton.Click();

//            //    IWebElement manageDropDown = driver.FindElement(By.Id("navbarDropdownMenuLink"));
//            //    manageDropDown.Click();

//            //    IWebElement manage = driver.FindElement(By.XPath("//a[@href='/UserAccount/UserAccount']"));
//            //    manage.Click();


//            //    IWebElement button = driver.FindElement(By.XPath("//button[text()='Activate']"));
//            //    button.Click();

//            //    IWebElement anchor = driver.FindElement(By.Id("confirmToggleBtn"));

//            //    anchor.Click();


//            //    Console.WriteLine("PASSED");

//            //}
//            //catch (Exception ex)
//            //{
//            //    Console.WriteLine($"FAILED");
//            //}
//            //finally
//            //{
//            //    driver.Close();
//            //}

//        }
//    }
//}
