using System;
using EAWinAppDriverTest.Base;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace EAWinAppDriverTest.Pages
{
    public class CalcPage : BasePage
    {

        public WindowsElement btnFive => WindowsDriver.FindElementByName("Five");
        public WindowsElement btnSix => WindowsDriver.FindElementByName("Six");
        public WindowsElement btnSeven => WindowsDriver.FindElementByName("Seven");
        public WindowsElement btnPlus => WindowsDriver.FindElementByName("Plus");

        public WindowsElement btnEquals => WindowsDriver.FindElementByName("Equals");

        public WindowsElement txtResult => WindowsDriver.FindElementByAccessibilityId("CalculatorResults");

        public AppiumWebElement txtResultHistory => WindowsDriver.FindElementByName("History").FindElementByAccessibilityId("resultTextBlock");


        public void PerformAddition()
        {
            btnFive.Click();
            btnSix.Click();
            btnSeven.Click();
            btnPlus.Click();
            btnFive.Click();
            btnEquals.Click();
        }

        internal void ClickPlus()
        {
            btnPlus.Click();
        }

        internal void ClickEquals()
        {
            btnEquals.Click();
        }

        internal void ClickFollowingNumber(Table table)
        {
            dynamic datas = table.CreateDynamicSet();

            foreach (var data in datas)
            {
                //Click button
                if ((string)data.Numbers == "Five")
                    btnFive.Click();
                else if ((string)data.Numbers == "Six")
                    btnSix.Click();
                else if ((string)data.Numbers == "Seven")
                    btnSeven.Click();
            }

        }

        internal string GetResult()
        {
            return txtResult.Text;
        }

        internal String GetHistory()
        {
            return txtResultHistory.Text;
        }
    }
}
