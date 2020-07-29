using DemoProject1.PageObject;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace DemoProject1.StepDefinition
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registrationPage;

        public RegistrationSteps()
        {
            registrationPage = new RegistrationPage();
        }



        [Given(@"I navigate to Amazon website")]
        public void GivenINavigateToAmazonWebsite()
        {
            registrationPage.NavigateToWebsite();
        }

        
        [When(@"I click on the hello sign in")]
        public void WhenIClickOnTheHelloSignIn()
        {
            
            registrationPage.ClickOnHelloSignin();
        }
        


        [When(@"I click on create your amazon account on page")]
        public void WhenIClickOnCreateYourAmazonAccountOnPage()
        {
            registrationPage.ClickOnCreateYourAmazonAccount();
        }
        
        [When(@"I enter my name")]
        public void WhenIEnterMyName()
        {
            registrationPage.EnterYourName();
        }
        
        [When(@"I enter my email")]
        public void WhenIEnterMyEmail()
        {
            registrationPage.EnterEmail();
        }
        
        [When(@"I enter my password on page")]
        public void WhenIEnterMyPasswordOnPage()
        {
            registrationPage.EnterPassword1();
        }
        
        [When(@"I reenter my password again")]
        public void WhenIReenterMyPasswordAgain()
        {
            registrationPage.EnterReEnterPassword2();
        }
        
        [When(@"I click on create your account on registration page")]
        public void WhenIClickOnCreateYourAccountOnRegistrationPage()
        {
            registrationPage.ClickOnCreateAmazonAccount2();
        }
        
        [Then(@"my account should be created")]
        public void ThenMyAccountShouldBeCreated()
        {
            // Different types of Assertion
            // 1. Nunit Assertion
            // 2. Junit Assertion
            // 3. MSTest
           // Assert.That(registrationPage.IsHelloDemoDisplayed);
        }

        [Then(@"I created another step for demo purpose")]
        public void WhenICreatedAnotherStepForDemoPurpose()
        { 
        
        
        }








    }
}
