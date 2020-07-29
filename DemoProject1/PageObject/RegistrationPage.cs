using DemoProject1.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DemoProject1.PageObject
{
    class RegistrationPage
    {
        public RegistrationPage()
        {
            driver = Hooks1.driver;

        }

        IWebDriver driver;

        IWebElement helloSignin => driver.FindElement(By.XPath("//span[text()= 'Hello, Sign in']"));

        IWebElement createYourAmazonAccount1 => driver.FindElement(By.CssSelector("#createAccountSubmit"));

        IWebElement YourName => driver.FindElement(By.XPath("//*[@id='ap_customer_name']"));

        IWebElement Email => driver.FindElement(By.XPath("//*[@id='ap_email']"));

        IWebElement Password => driver.FindElement(By.CssSelector("#ap_password"));

        IWebElement reEnterPassword => driver.FindElement(By.CssSelector("#ap_password_check"));

        IWebElement createYourAmazonAccount2 => driver.FindElement(By.CssSelector("#continue"));

        IWebElement confirmHelloDemo => driver.FindElement(By.XPath("//span[text()='Hello, Demo']"));

        public void ClickOnHelloSignin()

        {
            
            helloSignin.Click();
        }

        public void ClickOnCreateYourAmazonAccount()
        {
            createYourAmazonAccount1.Click();
        }

        public void EnterYourName()

        {
            YourName.SendKeys("Demo Test");
        }


        public void EnterEmail()

        {
            Email.SendKeys("bagirabalo099@gmail.com");
        }


        public void EnterPassword1()

        {
            Password.SendKeys("Shola007");
        }


        public void EnterReEnterPassword2()

        {
            reEnterPassword.SendKeys("Shola007");
        }


        public void ClickOnCreateAmazonAccount2()

        {
            createYourAmazonAccount2.SendKeys("Demo Test");
        }

        public bool IsHelloDemoDisplayed()
        {
            return confirmHelloDemo.Displayed;
        }



        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("Https://www.amazon.co.uk");
        }
        
       


    

}   }     


     


 
        


    
    
