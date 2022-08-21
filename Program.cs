using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace WebDriverMail
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program is started!");

            //create the reference for the browser  
            IWebDriver driver = new ChromeDriver();

            // navigate to URL 
            driver.Navigate().GoToUrl("https://accounts.ukr.net/login?client_id=9GLooZH9KjbBlWnuLkVX/");
            Thread.Sleep(1700);

            // identify the "Login" text box  
            IWebElement ele = driver.FindElement(By.Name("login"));

            //enter the value in the "Login" text box  
            ele.SendKeys("testuseremail@ukr.net");

            // identify the "Password" text box  
            IWebElement ele1 = driver.FindElement(By.Name("password"));

            //enter the value in "Password" text box  
            ele1.SendKeys("A19082022st");
            Thread.Sleep(1700);

            //identify the "Continue" button  
            IWebElement ele2 = driver.FindElement(By.XPath("//button[@type='submit']"));
            
            //click on the "Continue" button  
            ele2.Click();
            Thread.Sleep(1700);
            
            //identify the "Write an email" button
            IWebElement ele3 = driver.FindElement(By.CssSelector("#content > aside > button"));

            //click on the "Write an email" button  
            ele3.Click();
            Thread.Sleep(1700);
          
            //identify the "To Whom" text box
            IWebElement ele4 = driver.FindElement(By.Name("toFieldInput"));

            //enter the value in "To Whom" text box
            ele4.SendKeys("goosunchez@gmail.com");

            //identify the "Letter" text box
            IWebElement ele5 = driver.FindElement(By.XPath("//textarea[@class='mce-plaintext-area']"));  
            ele5.Click();

            //type the message
            ele5.SendKeys("Test message.");
            Thread.Sleep(500);
           
            //identify the "Send" button  
            IWebElement ele6 = driver.FindElement(By.XPath("//*[@id='screens']/div/div[1]/div/button"));

            //click on the "Send" button  
            ele6.Click();
            Thread.Sleep(2000);

            //close the browser  
            driver.Close();
            Console.WriteLine("Program is ended!");
            
        }
    }
}
