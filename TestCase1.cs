using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscribe
{
	class CSS						
    {
        IWebDriver m_driver;

        [Test]
		public void SubscribeDemo()
        {
            m_driver = new ChromeDriver("C:\Users\User\Desktop");
            m_driver.Url = "https://www.theinformation.com";
            m_driver.Manage().Window.Maximize();

             
			// Store locator values of email text box and sign up button				
            IWebElement emailTextBox = m_driver.FindElement(By.CssSelector("input[id=footer-email]"));
            IWebElement signUpButton = m_driver.FindElement(By.CssSelector("input[css=.col-md-4 > .submit]"));

            emailTextBox.SendKeys("pesho@mail.com");
            signUpButton.Click();

             
        }
    }
}			