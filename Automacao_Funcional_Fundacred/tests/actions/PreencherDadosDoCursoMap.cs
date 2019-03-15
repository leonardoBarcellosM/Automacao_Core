using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automacao_Funcional.tests.steps
{
    class PreencherDadosDoCursoMap
    {
        [FindsBy(How = How.XPath, Using = "//ng-form[@name='dadosCursoForm']/./div[1]//div//div[1]//input[1]")]
        [CacheLookup]
        public IWebElement InputMatricula { get; set; }

        [FindsBy(How = How.XPath, Using = "//ng-form[@name='dadosCursoForm']/./div[1]//div[2]//div[1]//input[1]")]
        [CacheLookup]
        public IWebElement InputPerc { get; set; }


        [FindsBy(How = How.XPath, Using = "//ng-form[@name='dadosCursoForm']/./div[2]//div[1]//div[1]/./select[1]")]
        [CacheLookup]
        public IWebElement SelectAno { get; set; }

        [FindsBy(How = How.XPath, Using = "//ng-form[@name='dadosCursoForm']/./div[2]//div[1]//div[1]/./select[1]/./option[2]")]
        [CacheLookup]
        public IWebElement OptAno { get; set; }


        [FindsBy(How = How.XPath, Using = "//ng-form[@name='dadosCursoForm']/./div[2]//div[2]//div[1]/./select[1]")]
        [CacheLookup]
        public IWebElement SelectSemestre { get; set; }

        [FindsBy(How = How.XPath, Using = "//ng-form[@name='dadosCursoForm']/./div[2]//div[2]//div[1]/./select[1]//option[2]")]
        [CacheLookup]
        public IWebElement OptSemestre { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@class='nav nav-tabs']//li[4]")]
        [CacheLookup]
        public IWebElement Btndocumentos { get; set; }
    }
}
