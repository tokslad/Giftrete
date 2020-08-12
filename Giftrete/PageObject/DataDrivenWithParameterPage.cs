using Giftrete.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Giftrete.PageObject
{
    class DataDrivenWithParameterPage
    {
        public DataDrivenWithParameterPage()
        {
            driver = Hooks1.driver;
            // ImplicitWait;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }

        IWebDriver driver; 

        IWebElement createAccount => driver.FindElement(By.XPath("(//*[@href='/account/authentication?ref=2'])[1]"));
        IWebElement enterFirstName => driver.FindElement(By.XPath("//input[@placeholder='Enter your first name']"));
        IWebElement enterLastName => driver.FindElement(By.XPath("//input[@id='last_name']"));
        IWebElement enterEmail => driver.FindElement(By.XPath("//*[@id='email']"));
        IWebElement flagContainer => driver.FindElement(By.XPath("//div[@class='flag-container']"));
        IWebElement selectUnitedKingdom => driver.FindElement(By.XPath("(//*[@id='iti-item-gb'])[1]"));
        IWebElement enterMobileNumber => driver.FindElement(By.XPath("//*[@id='mobile']"));
        IWebElement enterPassword1 => driver.FindElement(By.XPath("//*[@id='password']"));
        IWebElement reEnterPassword2 => driver.FindElement(By.XPath("//*[@id='confirm_password']"));
        IWebElement clickOnRegister => driver.FindElement(By.XPath("//*[@id='btn_register']"));
        IWebElement clickOnSignIn => driver.FindElement(By.XPath("//*[@id='btn_signin']"));
        IWebElement isSingInPageDisplayed => driver.FindElement(By.XPath("//*[@id='nav-signin-tab']"));













        public void ClickOnCreateAccount()
        {
            Thread.Sleep(5000);
            createAccount.Click();
        }

        public void ClickOnFlagContainer()
        {
            Thread.Sleep(5000);
            flagContainer.Click();
        }

        public void SelectUnitedKingdom()
        {
            selectUnitedKingdom.Click();
        }

        public void ClickOnRegister()
        {
            clickOnRegister.Click();
        }

        public void EnterFirstName(string name)
        {
            enterFirstName.SendKeys(name);
        }

        public void EnterLastName(string boo)
        {
            enterLastName.SendKeys(boo);
        }

        public void EnterEmail(string paint)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            enterEmail.SendKeys(paint + randomInt + "@gmail.com");
            //enterEmail.SendKeys(paint);
        }

        public void EnterPassword(string frog)
        {
            enterPassword1.SendKeys(frog);
        }

        public void ReEnterPassword(string frog2)
        {
            reEnterPassword2.SendKeys(frog2);
        }

        public void EnterMobileNumber()
        {
            enterMobileNumber.SendKeys("07989564912");
        }

        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public bool IsSignInPageDisplayed()
        {
            return isSingInPageDisplayed.Displayed;
        }

      







        
       
            
    }
}
