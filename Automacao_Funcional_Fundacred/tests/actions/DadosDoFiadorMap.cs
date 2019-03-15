using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automacao_Funcional.tests.steps
{
    class DadosDoFiadorMap
    {
        [FindsBy(How = How.XPath, Using = "//div[@class='row'][2]//div[1]//div//input[1]")]
        [CacheLookup]
        public IWebElement InputNome { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='row'][2]//div[2]//div//input[1]")]
        [CacheLookup]
        public IWebElement InputCpf { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='row'][3]//div[1]//div//input[1]")]
        [CacheLookup]
        public IWebElement InputDtaNasc { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='row'][3]//div[2]//div//input[1]")]
        [CacheLookup]
        public IWebElement InputRenda { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-laranja btn-block']")]
        [CacheLookup]
        public IWebElement BtnEnviar { get; set; }
    }
}
