using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium_Test
{
    internal class Location
    {
        static void Main(string[] args)
        {
            // Set ChromeOptions to bypass SSL certificate errors
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--ignore-certificate-errors");
            IWebDriver driver = new ChromeDriver(options);
            //try
            //{
            //    driver.Navigate().GoToUrl("https://responde.bsite.net/Home/Login");
            //    IWebElement username = driver.FindElement(By.Name("userName"));
            //    username.SendKeys("chandlerescala");
            //    IWebElement password = driver.FindElement(By.Name("userPassword"));
            //    password.SendKeys("Admin123-");
            //    IWebElement loginButton = driver.FindElement(By.XPath("//input[@value='Login']"));
            //    loginButton.Click();

            //    IWebElement manageDropDown = driver.FindElement(By.Id("navbarDropdownMenuLink"));
            //    manageDropDown.Click();

            //    IWebElement departmentLink = driver.FindElement(By.XPath("//a[@href='/ManageLocation/Location']"));
            //    departmentLink.Click();

            //    IWebElement createDepartmentButton = driver.FindElement(By.XPath("//a[@href='/ManageLocation/CreateLocation']"));
            //    createDepartmentButton.Click();

            //    IWebElement locationName = driver.FindElement(By.Id("locationName"));
            //    locationName.SendKeys("");

            //    IWebElement longitude = driver.FindElement(By.Id("longitude"));
            //    longitude.SendKeys("123.23");

            //    IWebElement latitude = driver.FindElement(By.Id("latitude"));
            //    latitude.SendKeys("124.32");

            //    IWebElement address = driver.FindElement(By.Id("address"));
            //    address.SendKeys("UCLM");

            //    IWebElement submitButton = driver.FindElement(By.XPath("//input[@type='submit' and @value='Create']"));
            //    submitButton.Click();

            //    Console.WriteLine("PASSED");

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"FAILED - Exception occurred: {ex.Message}");
            //}
            //finally
            //{
            //    driver.Close();
            //}

            //try
            //{
            //    driver.Navigate().GoToUrl("https://responde.bsite.net/Home/Login");
            //    IWebElement username = driver.FindElement(By.Name("userName"));
            //    username.SendKeys("chandlerescala");
            //    IWebElement password = driver.FindElement(By.Name("userPassword"));
            //    password.SendKeys("Admin123-");
            //    IWebElement loginButton = driver.FindElement(By.XPath("//input[@value='Login']"));
            //    loginButton.Click();

            //    IWebElement manageDropDown = driver.FindElement(By.Id("navbarDropdownMenuLink"));
            //    manageDropDown.Click();

            //    IWebElement departmentLink = driver.FindElement(By.XPath("//a[@href='/ManageLocation/Location']"));
            //    departmentLink.Click();

            //    IList<IWebElement> buttons = driver.FindElements(By.CssSelector("button.btn3.btn-info"));
            //    buttons[0].Click();

            //    Console.WriteLine("PASSED");

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"FAILED - Exception occurred: {ex.Message}");
            //}
            //finally
            //{
            //    driver.Close();
            //}

            //try
            //{
            //    driver.Navigate().GoToUrl("https://responde.bsite.net/Home/Login");
            //    IWebElement username = driver.FindElement(By.Name("userName"));
            //    username.SendKeys("chandlerescala");
            //    IWebElement password = driver.FindElement(By.Name("userPassword"));
            //    password.SendKeys("Admin123-");
            //    IWebElement loginButton = driver.FindElement(By.XPath("//input[@value='Login']"));
            //    loginButton.Click();

            //    IWebElement manageDropDown = driver.FindElement(By.Id("navbarDropdownMenuLink"));
            //    manageDropDown.Click();

            //    IWebElement departmentLink = driver.FindElement(By.XPath("//a[@href='/ManageLocation/Location']"));
            //    departmentLink.Click();

            //    IList<IWebElement> buttons = driver.FindElements(By.CssSelector("button.btn3.btn-info"));
            //    buttons[0].Click();

            //    IWebElement anchor = driver.FindElement(By.CssSelector("a.btn1.btn-primary.col-12"));
            //    anchor.Click();

            //    IWebElement locationName = driver.FindElement(By.Id("locationName"));
            //    locationName.Clear();

            //    IWebElement submitButton = driver.FindElement(By.XPath("//input[@type='submit' and @value='Save']"));
            //    submitButton.Click();

            //    Console.WriteLine("PASSED");

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"FAILED - Exception occurred: {ex.Message}");
            //}
            //finally
            //{
            //    driver.Close();
            //}

            try
            {
                driver.Navigate().GoToUrl("https://responde.bsite.net/Home/Login");
                IWebElement username = driver.FindElement(By.Name("userName"));
                username.SendKeys("chandlerescala");
                IWebElement password = driver.FindElement(By.Name("userPassword"));
                password.SendKeys("Admin123-");
                IWebElement loginButton = driver.FindElement(By.XPath("//input[@value='Login']"));
                loginButton.Click();

                IWebElement manageDropDown = driver.FindElement(By.Id("navbarDropdownMenuLink"));
                manageDropDown.Click();

                IWebElement departmentLink = driver.FindElement(By.XPath("//a[@href='/ManageLocation/Location']"));
                departmentLink.Click();

                IWebElement deleteButton = driver.FindElement(By.XPath("//button[contains(@onclick, 'confirmDeleteModal')]"));
                deleteButton.Click();

                IWebElement confirmDeleteButton = driver.FindElement(By.Id("confirmDeleteButton"));
                confirmDeleteButton.Click();

                Console.WriteLine("PASSED");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"FAILED - Exception occurred: {ex.Message}");
            }
            finally
            {
                driver.Close();
            }
        }
    }
}
