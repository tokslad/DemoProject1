using DemoProject1.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject1.PageObject
{
    class DataDrivenWithParameterPage
    {
        public DataDrivenWithParameterPage()
        {
            driver = Hooks1.driver;

        }
        IWebDriver driver;


        IWebElement usernameInput => driver.FindElement(By.XPath("//input[@placeholder = 'Username']"));

        IWebElement emailInput => driver.FindElement(By.XPath("//input[@placeholder = 'Email']"));


        IWebElement passwordInput => driver.FindElement(By.XPath("//input[@type = 'password']"));

        IWebElement signUpButton => driver.FindElement(By.XPath("//button[@type = 'submit']"));

        IWebElement userLogin => driver.FindElement(By.XPath("//a[@class='nav-link ng-binding']"));

















        public void Enterusername(string username)
        {
            usernameInput.SendKeys(username);
           Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            usernameInput.SendKeys(username + randomInt);
            //usernameInput.SendKeys(username);
                
        }

        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);

        }
        public void EnterEmaiil(string eba)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            emailInput.SendKeys(eba + randomInt + "@gmail.com");
            //emailInput.SendKeys(eba); 

        }
        public void EnterPassword(string password)
        {
            passwordInput.SendKeys(password);

        }
        public void ClickSignUpButton()
        {
            signUpButton.Click();
        }
        public bool IsUserLoginDisplayed()
        {
            return userLogin.Displayed;
        }
    }
}
