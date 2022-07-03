﻿using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDSpecFlowProject.Pages
{
  public  class LoginPage
    {

        //Classical way of initializing Pages via POM concept - Until Selenium 3.10.0

        //public LoginPage(IWebDriver driver)
        //{
        //    PageFactory.InitElements(driver, this);
        //}

        //[FindsBy(How = How.Name, Using = "UserName")]
        //public IWebElement txtUserName { get; set; }

        //[FindsBy(How = How.Name, Using = "Password")]
        //public IWebElement txtPassword { get; set; }

        //[FindsBy(How = How.Name, Using = "Login")]
        //public IWebElement btnLogin { get; set; }



        private IWebDriver _driver;
        public LoginPage(IWebDriver driver) => _driver = driver;

      // IWebElement rl => _driver.FindElement(By.Id("dd"));
        IWebElement txtUserName => _driver.FindElement(By.Name("UserName"));
        IWebElement txtPassword => _driver.FindElement(By.Name("Password"));
        IWebElement btnLogin => _driver.FindElement(By.CssSelector("input[class='btn btn-default']"));




        public void EnterUserNameAndPassword(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }

        public void ClickLogin()
        {
            btnLogin.Click();
        }


    }
}
