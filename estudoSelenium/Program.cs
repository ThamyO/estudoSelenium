using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;
using AutoIt;



namespace estudoSelenium
{
    public class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            AutoItX3 auto = new AutoItX3();

         
            driver.Navigate().GoToUrl("https://www.google.com/");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input")).SendKeys("Rhitmo Tech");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input")).SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(1000);

            var allresults = driver.FindElements(By.ClassName("LC20lb"));

            var pathtxt = "C:\\Users\\myres\\OneDrive\\Área de Trabalho\\Estudo automação.txt";

            AutoItX.Run("notepad.exe", "");

            for (int i = 0; i < allresults.Count; i++)
            {
                if (i == 0)
                {
                    AutoItX.WinWaitActive("Sem título - Bloco de notas");
                    AutoItX.Send(allresults[i].Text + "\n");
                }
                else
                {
                    AutoItX.WinWaitActive("*Sem título - Bloco de notas");
                    AutoItX.Send(allresults[i].Text + "\n");
                }

                

            }

        }

    }
}
