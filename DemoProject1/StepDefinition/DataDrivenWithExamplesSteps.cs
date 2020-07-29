using DemoProject1.PageObject;
using System;
using TechTalk.SpecFlow;

namespace DemoProject1.StepDefinition
{
    [Binding]
    public class DataDrivenWithExamplesSteps
    {
        DataDrivenWithExamplesPage dataDrivenWithExamplesPage;


        public DataDrivenWithExamplesSteps()
        {
            dataDrivenWithExamplesPage = new DataDrivenWithExamplesPage();
        }








    

        
     
    
       
    



        [When(@"the user enter Username text ""(.*)""")]
        public void WhenTheUserEnterUsernameText(string Username)
        {
            dataDrivenWithExamplesPage.Enterusername(Username); 
        }
        
        [When(@"the user enter email text ""(.*)""")]
        public void WhenTheUserEnterEmailText(string Email)
        {
            dataDrivenWithExamplesPage.EnterEmaiil(Email);
        }
        
        [When(@"the user enter password text ""(.*)""")]
        public void WhenTheUserEnterPasswordText(string Password)
        {
            dataDrivenWithExamplesPage.EnterPassword(Password);
        }
    }
}
