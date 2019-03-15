using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automacao_Funcional.tests.steps
{
    class LoginMap
    {

        [FindsBy(How = How.XPath, Using = "//*[@id='topo']/div/a")]
        [CacheLookup]
        public IWebElement BtnEntrar { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='txtCpfLogin']")]
        [CacheLookup]
        public IWebElement InputCpf { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='frmLogin']/fieldset/ul/li[2]/label")]
        [CacheLookup]
        public IWebElement InputSenha { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='txtSenhaLogin']")]
        [CacheLookup]
        public IWebElement Pass { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='frmLogin']/fieldset/div/button")]
        [CacheLookup]
        public IWebElement BtnSubmit { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/input[1]")]
        [CacheLookup]
        public IWebElement CampoUsername { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/input[2]")]
        [CacheLookup]
        public IWebElement CampoPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/button")]
        [CacheLookup]
        public IWebElement BtnSignIn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='linkSair']")]
        [CacheLookup]
        public IWebElement BtnSair { get; set; }
        
    }
}
