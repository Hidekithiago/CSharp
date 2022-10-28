using OpenQA.Selenium; //Install Selenium.WebDriver
using OpenQA.Selenium.Chrome;  //Selenium.WebDriver.ChromeDriver
using System.Diagnostics;  //Usado para fechar o chrome

using System.Threading;


//Selenium.WebDriver.ChromeDriver

public class _7_RPA
{
    private static IWebDriver driver;
    private static void SeleniumGoogle()
    {
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl(@"https://www.google.com.br/");

        driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input")).Click();
        driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input")).SendKeys("Climatempo");
        driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input")).SendKeys(Keys.Enter);
    }
    private static void FechaChrome()
    {
        Process[] chromeInstances = Process.GetProcessesByName("chrome");
        foreach (Process p in chromeInstances) p.Kill();
    }

    static void Main(string[] args)
    {
        SeleniumGoogle();
    }

}