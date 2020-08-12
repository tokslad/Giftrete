using Giftrete.PageObject;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Giftrete.StepsDefinition
{
    [Binding]
    public class DataDrivenWithParameterSteps
    {
        DataDrivenWithParameterPage dataDrivenWithParameterPage;
        public DataDrivenWithParameterSteps()
        {
            dataDrivenWithParameterPage = new DataDrivenWithParameterPage();
        }


        [Given(@"I navigate to site ""(.*)""")]
        public void GivenINavigateToSite(string url)
        {
            dataDrivenWithParameterPage.NavigateToWebsite(url);
        }


        [When(@"I click on craete account")]
        public void WhenIClickOnCraeteAccount()
        {
            dataDrivenWithParameterPage.ClickOnCreateAccount();
        }
        
        [When(@"I enter first Name ""(.*)""")]
        public void WhenIEnterFirstName(string name)
        {
            dataDrivenWithParameterPage.EnterFirstName(name);
        }
        
        [When(@"I enter Last name ""(.*)""")]
        public void WhenIEnterLastName(string boo)
        {
            dataDrivenWithParameterPage.EnterLastName(boo);
        }
        
        [When(@"I enter Email ""(.*)""")]
        public void WhenIEnterEmail(string paint)
        {
            dataDrivenWithParameterPage.EnterEmail(paint);
        }

        [When(@"I select the flag container")]
        public void WhenISelectTheFlagContainer()
        {
            dataDrivenWithParameterPage.ClickOnFlagContainer();
        }


        [When(@"I select United Kingdom as country")]
        public void WhenISelectUnitedKingdomAsCountry()
        {
            dataDrivenWithParameterPage.SelectUnitedKingdom();
            
        }

        [When(@"I type in mobile number")]
        public void WhenITypeInMobileNumber()
        {
            dataDrivenWithParameterPage.EnterMobileNumber();
        }

        [When(@"I enter Password ""(.*)""")]
        public void WhenIEnterPassword(string frog)
        {
            dataDrivenWithParameterPage.EnterPassword(frog);
        }
        
        [When(@"I Reenter password ""(.*)""")]
        public void WhenIReenterPassword(string frog2)
        {
            dataDrivenWithParameterPage.ReEnterPassword(frog2);
        }

        [When(@"I click on Register")]
        public void WhenIClickOnRegister()
        {
            dataDrivenWithParameterPage.ClickOnRegister();
        }



        [Then(@"I'm taking to sign in page")]
        public void ThenIMTakingToSignInPage()
        {
            Assert.That(dataDrivenWithParameterPage.IsSignInPageDisplayed);
        }







    }
}
