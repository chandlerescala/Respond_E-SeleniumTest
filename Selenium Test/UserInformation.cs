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
//    internal class UserInformation
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

//                IWebElement manageDropDown = driver.FindElement(By.Id("dropdownUser1"));
//                manageDropDown.Click();

//                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
//                IWebElement profileButton = wait.Until(d => d.FindElement(By.XPath("//a[@class='dropdown-item' and @href='/Home/MyProfile']")));
//                profileButton.Click();

//                IWebElement pencilIcon = driver.FindElement(By.CssSelector("i.ti-pencil-alt"));
//                pencilIcon.Click();

//                IWebElement userIdNum = driver.FindElement(By.Name("userIdNum"));
//                userIdNum.Clear();
//                userIdNum.SendKeys("1898576211");

//                IWebElement firstName = driver.FindElement(By.Name("firstName"));
//                firstName.Clear();
//                firstName.SendKeys("Chandler");


//                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
//                IWebElement submitButton = driver.FindElement(By.XPath("//input[@type='submit' and @value='Save']"));
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

//            //    IWebElement manageDropDown = driver.FindElement(By.Id("dropdownUser1"));
//            //    manageDropDown.Click();

//            //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
//            //    IWebElement profileButton = wait.Until(d => d.FindElement(By.XPath("//a[@class='dropdown-item' and @href='/Home/MyProfile']")));
//            //    profileButton.Click();

//            //    IWebElement pencilIcon = driver.FindElement(By.CssSelector("i.ti-pencil-alt"));
//            //    pencilIcon.Click();


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

//            //    IWebElement manageDropDown = driver.FindElement(By.Id("dropdownUser1"));
//            //    manageDropDown.Click();

//            //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
//            //    IWebElement profileButton = wait.Until(d => d.FindElement(By.XPath("//a[@class='dropdown-item' and @href='/Home/MyProfile']")));
//            //    profileButton.Click();

//            //    IWebElement pencilIcon = driver.FindElement(By.CssSelector("i.ti-pencil-alt"));
//            //    pencilIcon.Click();

//            //    IWebElement userIdNum = driver.FindElement(By.Name("userIdNum"));
//            //    userIdNum.Clear();
//            //    userIdNum.SendKeys("18985761");



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
//        }
//    }
//}
