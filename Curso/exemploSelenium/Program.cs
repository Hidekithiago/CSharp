using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace exemploSelenium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChromeDriver driver = IniciarChrome();
            CapturarInformacoes(driver);
        }

        public static ChromeDriver IniciarChrome()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            ChromeDriver driver = new ChromeDriver(options);

            driver.Navigate().GoToUrl(@"https://cnpj.linkana.com/");
            driver.FindElement(By.XPath(@"/html/body/div/div/main/div/div[1]/div/div[2]/form/div/input")).SendKeys("18.236.120/0001-58"); //Digitar o CNPJ no Campo de buscar
            driver.FindElement(By.XPath(@"/html/body/div/div/main/div/div[1]/div/div[2]/form/div/button")).Click(); //Clicar no botao de Buscar
            Thread.Sleep(2000);
            driver.FindElement(By.XPath(@"/html/body/div/div/main/div/div/a/div/div[1]/p[1]")).Click(); //Clicar na empresa da NuBank
            return driver;
        }

        public static void CapturarInformacoes(ChromeDriver driver)
        {
            Thread.Sleep(2000);
            string razaoSocial = driver.FindElement(By.XPath("/html/body/div/div/main/div/p[2]")).Text;
            string cnpj = driver.FindElement(By.XPath("/html/body/div/div/main/div/p[3]")).Text;
            string capitalSocial = driver.FindElement(By.XPath("/html/body/div/div/main/div/div[1]/div[10]/p")).Text;
        }

    }
}
