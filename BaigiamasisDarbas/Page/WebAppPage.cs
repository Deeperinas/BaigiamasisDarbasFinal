using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas.Page
{
    public class WebAppPage : BasePage
    {
        private const string pageAddress = "https://maps.staging.deeper.eu/en-gb";

        private IWebElement firstLoginButton => Driver.FindElement(By.CssSelector("#app > div > div.MuiDrawer-root.MuiDrawer-docked.noPrint > div > div.menu-drawer_container-div__2X8k9 > div > div.landing-drawer-content_buttons__2vceR > button.MuiButtonBase-root.MuiButton-root.jss9.MuiButton-text.landing-drawer-content_login-button__3dstT > span"));
        private IWebElement emailField => Driver.FindElement(By.CssSelector("body > div.MuiDialog-root.dialog_root__13fMJ > div.MuiDialog-container.dialog_container__aAEue.MuiDialog-scrollBody > div > div > div > form > div.login-content_input-content__3j9YG > div:nth-child(2) > div > div > input"));
        private IWebElement passwordField => Driver.FindElement(By.CssSelector("body > div.MuiDialog-root.dialog_root__13fMJ > div.MuiDialog-container.dialog_container__aAEue.MuiDialog-scrollBody > div > div > div > form > div.login-content_input-content__3j9YG > div:nth-child(4) > div > div > input"));
        private IWebElement secondLoginButtonButton => Driver.FindElement(By.CssSelector("body > div.MuiDialog-root.dialog_root__13fMJ > div.MuiDialog-container.dialog_container__aAEue.MuiDialog-scrollBody > div > div > div > form > div.login-content_input-content__3j9YG > button > span"));
        private IWebElement burgerMenu => Driver.FindElement(By.CssSelector("#app > div > div > div > div > div.menu-drawer_container-div__2X8k9 > div.main-menu-items-list_banner__1maUs > img"));
        private IWebElement accountsAndAgreements => Driver.FindElement(By.CssSelector("body > div.MuiDrawer-root.jss30.MuiDrawer-modal > div.MuiPaper-root.MuiDrawer-paper.jss31.MuiDrawer-paperAnchorLeft.MuiPaper-elevation16 > div > div.menu-overlay-content_menu-items__3sQGL > div:nth-child(12) > div > span"));
        private IWebElement termsAndConditions => Driver.FindElement(By.CssSelector("#app > div > div > div > div > div.menu-drawer_container-div__2X8k9 > div.main-menu-items-list_items__24rE8 > div:nth-child(8) > div > span"));
        private IWebElement declineTermsAndConditions => Driver.FindElement(By.CssSelector("body > div.MuiDialog-root.dialog_root__13fMJ > div.MuiDialog-container.dialog_container__aAEue.MuiDialog-scrollBody > div > div > div > div > div.agreement-dialog-content_buttons__kSrG9 > button.MuiButtonBase-root.MuiButton-root.jss32.MuiButton-text > span"));
        private IWebElement declineAndDelete => Driver.FindElement(By.CssSelector("body > div.MuiDialog-root.small-info-dialog_root__2Nt-p > div.MuiDialog-container.MuiDialog-scrollPaper > div > div.MuiDialogActions-root.small-info-dialog_actions__1ISXl.MuiDialogActions-spacing > button.MuiButtonBase-root.MuiButton-root.MuiButton-text.small-info-dialog_red-left-button__OIfd1 > span"));
        private IWebElement goBackFromTermsAndConditions => Driver.FindElement(By.CssSelector("body > div.MuiDialog-root.small-info-dialog_root__2Nt-p > div.MuiDialog-container.MuiDialog-scrollPaper > div > div.MuiDialogActions-root.small-info-dialog_actions__1ISXl.MuiDialogActions-spacing > button.MuiButtonBase-root.MuiButton-root.MuiButton-text.small-info-dialog_right-button__1T_Iz > span"));
        private IWebElement closeTermsAndConditions => Driver.FindElement(By.CssSelector("body > div.MuiDialog-root.dialog_root__13fMJ > div.MuiDialog-container.dialog_container__aAEue.MuiDialog-scrollBody > div > div > button > span.MuiIconButton-label > svg"));
        private IWebElement privacyPolicy => Driver.FindElement(By.CssSelector("#app > div > div > div > div > div.menu-drawer_container-div__2X8k9 > div.main-menu-items-list_items__24rE8 > div:nth-child(10) > div > span"));
        private IWebElement declinePrivacyPolicy => Driver.FindElement(By.CssSelector("body > div.MuiDialog-root.dialog_root__13fMJ > div.MuiDialog-container.dialog_container__aAEue.MuiDialog-scrollBody > div > div > div > div > div.agreement-dialog-content_buttons__kSrG9 > button.MuiButtonBase-root.MuiButton-root.jss32.MuiButton-text > span"));


        private IWebElement tryDemoLogin => Driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[2]/div/div[2]/button[3]/span"));
        private IWebElement laurelLakeScan => Driver.FindElement(By.CssSelector("#scanItem2432004 > div.MuiListItemText-root.MuiListItemText-multiline > h5 > div.scan-item_title-summary__3RX2D"));
        private IWebElement mapSettings => Driver.FindElement(By.CssSelector("#mapView > div:nth-child(1) > div > div.leaflet-control-container > div.leaflet-top.leaflet-right > div:nth-child(4) > div > div > div:nth-child(1) > button > span.MuiIconButton-label > img")); 
        private IWebElement personalPalettes => Driver.FindElement(By.CssSelector("body > div.popover-control_popover__2LXUT.noPrint > div > div > label:nth-child(7) > div > div > div > button > span.MuiIconButton-label > svg > image"));
        private IWebElement caribbeanPalette => Driver.FindElement(By.CssSelector("body > div.color-palette-control_popover__3FGp5.noPrint > div > div:nth-child(6) > div > svg > image")); 
        private IWebElement mapPolygon => Driver.FindElement(By.CssSelector("#mapView > div:nth-child(1) > div > div.leaflet-pane.leaflet-map-pane > div.leaflet-pane.leaflet-overlay-pane > svg > g > path:nth-child(99)"));
        
        public WebAppPage(IWebDriver webDriver) : base(webDriver) { }

        public void NavigateToPage()
        {
            if (Driver.Url != pageAddress)
            {
                Driver.Url = pageAddress;
            }
        }

        public void AcceptCookies()
        {
            Cookie myCookie = new Cookie("CookieConsent",
                "true",
                "maps.staging.deeper.eu",
                "/",
                DateTime.Now.AddDays(5));
            Driver.Manage().Cookies.AddCookie(myCookie);
            Driver.Navigate().Refresh();
        }

        public void Login()
        {
            firstLoginButton.Click();
            emailField.SendKeys("dprtest@protonmail.com");
            passwordField.SendKeys("");
            secondLoginButtonButton.Click();
        }

        public void DeclineAgreements()
        {
            burgerMenu.Click();
            accountsAndAgreements.Click();
            termsAndConditions.Click();
            declineTermsAndConditions.Click();

            if (declineAndDelete.Displayed)
            {
                goBackFromTermsAndConditions.Click();
                closeTermsAndConditions.Click();
                privacyPolicy.Click();              
                declinePrivacyPolicy.Click();
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                wait.Until(tempDriver => tempDriver.FindElement(By.CssSelector("body > div.MuiDialog-root.small-info-dialog_root__2Nt-p > div.MuiDialog-container.MuiDialog-scrollPaper > div > div.MuiDialogActions-root.small-info-dialog_actions__1ISXl.MuiDialogActions-spacing > button.MuiButtonBase-root.MuiButton-root.MuiButton-text.small-info-dialog_red-left-button__OIfd1 > span")).Displayed);

                if (declineAndDelete.Displayed)
                {
                    goBackFromTermsAndConditions.Click();
                    closeTermsAndConditions.Click();
                    Assert.Pass();
                }
            }

        }

        public void LoginDemoUser()
        {
            tryDemoLogin.Click();

        }

        public void SelectScan()
        {
            laurelLakeScan.Click();
        }

        public void ChangeColorPalette()
        {
            mapSettings.Click();
            personalPalettes.Click();
            caribbeanPalette.Click();
        }

        public void VerifyPaletteWorks()
        {
            Assert.AreEqual("rgb(82, 214, 252)", mapPolygon.GetAttribute("fill"));
        }


    }
}
