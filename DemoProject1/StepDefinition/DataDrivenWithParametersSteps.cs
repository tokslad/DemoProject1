using DemoProject1.PageObject;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace DemoProject1.StepDefinition
{
    [Binding]
    public class DataDrivenWithParametersSteps

   

    {
        DataDrivenWithParameterPage dataDrivenWithParameterpage;

        public DataDrivenWithParametersSteps()
        {
            dataDrivenWithParameterpage = new DataDrivenWithParameterPage();

        }




        [When(@"I click on Sign in buuton")]
        public void WhenIClickOnSignInBuuton()
        {
            ScenarioContext.Current.Pending();
        }
        


        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            dataDrivenWithParameterpage.NavigateToWebsite(url);
        }
        
        [When(@"I enter username test ""(.*)""")]
        public void WhenIEnterUsernameTest(string username)
        {
            dataDrivenWithParameterpage.Enterusername(username);
        }
        
        [When(@"I enter email test ""(.*)""")]
        public void WhenIEnterEmailTest(string eba)
        {
            dataDrivenWithParameterpage.EnterEmaiil(eba);
        }
        
        [When(@"I enter password test ""(.*)""")]
        public void WhenIEnterPasswordTest(string password)
        {
            dataDrivenWithParameterpage.EnterPassword(password);
        }
        
        [When(@"I click on Sign in button")]
        public void WhenIClickOnSignInButton()
        {
            dataDrivenWithParameterpage.ClickSignUpButton();
        }
        
        [Then(@"I am logged in with my username displayed")]
        public void ThenIAmLoggedInWithMyUsernameDisplayed()
        {
            Assert.That(dataDrivenWithParameterpage.IsUserLoginDisplayed);
        }

       
        

    }
}
