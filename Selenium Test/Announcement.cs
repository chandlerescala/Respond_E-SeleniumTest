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
//    internal class Announcement
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

//            //    IWebElement username = driver.FindElement(By.Name("userName"));
//            //    username.SendKeys("chandlerescala");

//            //    IWebElement password = driver.FindElement(By.Name("userPassword"));
//            //    password.SendKeys("Admin123-");

//            //    IWebElement loginButton = driver.FindElement(By.XPath("//input[@value='Login']"));
//            //    loginButton.Click();

//            //    IWebElement manageDropDown = driver.FindElement(By.Id("navbarDropdownMenuLink"));
//            //    manageDropDown.Click();

//            //    IWebElement manage = driver.FindElement(By.XPath("//a[@href='/ManageAnnouncement/Announcement']"));
//            //    manage.Click();


//            //    IWebElement create = driver.FindElement(By.XPath("//a[@href='/ManageAnnouncement/CreateAnnouncement']"));
//            //    create.Click();


//            //    IWebElement announcementName = driver.FindElement(By.Id("announcementName"));
//            //    announcementName.SendKeys("");

//            //    IWebElement announcementMessage = driver.FindElement(By.Name("announcementMessage"));
//            //    announcementMessage.SendKeys("Please evacuate immediately");

//            //    IWebElement submitButton = driver.FindElement(By.XPath("//input[@type='submit' and @value='Create']"));
//            //    submitButton.Click();

//            //    Console.WriteLine("IT - 022 PASSED - Create Announcement");

//            //}
//            //catch (Exception ex)
//            //{
//            //    Console.WriteLine($"IT - 022 FAILED - Create Announcement");
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

//            //    IWebElement manage = driver.FindElement(By.XPath("//a[@href='/ManageAnnouncement/Announcement']"));
//            //    manage.Click();


//            //    IList<IWebElement> buttons = driver.FindElements(By.CssSelector("button.btn3.btn-info"));
//            //    buttons[0].Click();

//            //    Console.WriteLine("IT - 023 PASSED - View Announcement");

//            //}
//            //catch (Exception ex)
//            //{
//            //    Console.WriteLine($"IT - 022 FAILED - View Announcement");
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

//            //    IWebElement manage = driver.FindElement(By.XPath("//a[@href='/ManageAnnouncement/Announcement']"));
//            //    manage.Click();

//            //    IList<IWebElement> buttons = driver.FindElements(By.CssSelector("button.btn3.btn-info"));
//            //    buttons[0].Click();

//            //    IWebElement anchor = driver.FindElement(By.CssSelector("a.btn1.btn-primary.col-12"));
//            //    anchor.Click();

//            //    IWebElement textarea = driver.FindElement(By.Id("announcementMessage"));
//            //    textarea.Clear();

//            //    IWebElement submitButton = driver.FindElement(By.XPath("//input[@type='submit' and @value='Save']"));
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

//                IWebElement manage = driver.FindElement(By.XPath("//a[@href='/ManageAnnouncement/Announcement']"));
//                manage.Click();

//                IWebElement deleteButton = driver.FindElement(By.XPath("//button[contains(@onclick, 'confirmDeleteModal')]"));
//                deleteButton.Click();

//                IWebElement confirmDeleteButton = driver.FindElement(By.Id("confirmDeleteButton"));
//                confirmDeleteButton.Click();


//                Console.WriteLine("PASSED - Delete Announcement");

//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"FAILED - Delete Announcement");
//            }
//            finally
//            {
//                driver.Close();
//            }

//        }
//    }
//}
