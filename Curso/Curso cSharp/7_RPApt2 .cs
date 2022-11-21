using OpenQA.Selenium; //Install Selenium.WebDriver
using OpenQA.Selenium.Chrome;  //Selenium.WebDriver.ChromeDriver
using System.Diagnostics;  //Usado para fechar o chrome

using System.Threading;


//Selenium.WebDriver.ChromeDriver

public class _7_RPApt2
{
    private static IWebDriver driver;
    private static void SeleniumGoogle()
    {
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl(@"https://www.b3.com.br/pt_br/produtos-e-servicos/negociacao/renda-variavel/empresas-listadas.htm");
        Thread.Sleep(1000);
        driver.SwitchTo().Frame(0);
        driver.FindElement(By.XPath("/html/body/app-root/app-companies-home/div/div/div/div/div[1]/div[2]/div/app-companies-home-filter-name/form/div/div[4]/button")).Click();
        Thread.Sleep(1000);
        driver.FindElement(By.XPath("/html/body/app-root/app-companies-search/div/form/div[1]/div/div/div[2]/nav/div/a[2]")).Click();

        for (int i = 1; i < 10; i++)
        {
            Thread.Sleep(1000);
            var razaoSocial = driver.FindElement(By.XPath($"/html/body/app-root/app-companies-search/div/form/div[2]/div[2]/table/tbody/tr[{i}]/td[1]/a")).Text;
            var nomePregao = driver.FindElement(By.XPath($"/html/body/app-root/app-companies-search/div/form/div[2]/div[2]/table/tbody/tr[{i}]/td[2]/a")).Text;
            var segmento = driver.FindElement(By.XPath($"/html/body/app-root/app-companies-search/div/form/div[2]/div[2]/table/tbody/tr[{i}]/td[3]/label[1]")).Text;
            var codigo = driver.FindElement(By.XPath($"/html/body/app-root/app-companies-search/div/form/div[2]/div[2]/table/tbody/tr[{i}]/td[4]")).Text;

            if (codigo.Equals("GRDR")){
                driver.FindElement(By.XPath($"/html/body/app-root/app-companies-search/div/form/div[2]/div[2]/table/tbody/tr[{i}]/td[1]/a")).Click();
                Thread.Sleep(1000);
                var cnpj = driver.FindElement(By.XPath($"/html/body/app-root/app-companies-menu-select/div/app-companies-overview/div/div[1]/div/div/div[1]/p[2]")).Text;
            }


        }
        
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