using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automacao_Funcional.tests.steps
{
    class ValidarTelaPesquisaMap
    {
        [FindsBy(How = How.XPath, Using = "///html/body/div[2]/h1")]
        [CacheLookup]
        public IWebElement TelaPesquisa { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/p/strong[2]")]
        [CacheLookup]
        public IWebElement TotalTelaPesquisa { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/form/div/div[2]/div/div[4]/div/select")]
        [CacheLookup]
        public IWebElement CampoFiltro { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/div/div[1]/div[1]/div[1]/h3")]
        [CacheLookup]
        public IWebElement NomeEstudante { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/div/div[1]/div[1]/div[2]/div[1]")]
        [CacheLookup]
        public IWebElement CpfEstudante { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/div/div[1]/div[1]/div[2]/div[2]")]
        [CacheLookup]
        public IWebElement DtSolicitacao { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/div/div[1]/div[1]/div[2]/div[3]")]
        [CacheLookup]
        public IWebElement Curso { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/div/div[1]/div[1]/div[3]/div[1]")]
        [CacheLookup]
        public IWebElement Matricula { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/div/div[1]/div[1]/div[3]/div[2]")]
        [CacheLookup]
        public IWebElement Convenio { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/div/div[1]/div[1]/div[3]/div[3]")]
        [CacheLookup]
        public IWebElement Etapa { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/div/div[1]/div[1]/div[3]/div[2]")]
        [CacheLookup]
        public IWebElement Campus { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/div/div[2]/div[2]")]
        [CacheLookup]
        public IWebElement PercSolicitado { get; set; }

        //[FindsBy(How = How.XPath, Using = "/html/body/div[2]/p/strong[2]")]
        //[CacheLookup]
        //public IWebElement TotalTelaPesquisa { get; set; }

        //[FindsBy(How = How.XPath, Using = "/html/body/div[2]/form/div/div[2]/div/div[4]/div/select")]
        //[CacheLookup]
        //public IWebElement CampoFiltro { get; set; }

    }
}
