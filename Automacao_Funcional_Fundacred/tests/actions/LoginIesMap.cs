using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automacao_Funcional.tests.steps
{
    class LoginIesMap
    {
        [FindsBy(How = How.Id, Using = "email")]
        [CacheLookup]
        public IWebElement InputEmail { get; set; }

        [FindsBy(How = How.Id, Using = "senha")]
        [CacheLookup]
        public IWebElement InputSenha { get; set; }

        [FindsBy(How = How.XPath, Using = "//form[@id='formLogin']//div/../button[1]")]
        [CacheLookup]
        public IWebElement BtnEntrar { get; set; }
    }
}
