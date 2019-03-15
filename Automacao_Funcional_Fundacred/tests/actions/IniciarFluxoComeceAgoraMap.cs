using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automacao_Funcional.tests.steps
{
    class IniciarFluxoComeceAgoraMap
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='inicio']/div/div[3]/a/b[1]")]
        [CacheLookup]
        public IWebElement BtnIniciar { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='txtNome']")]
        [CacheLookup]
        public IWebElement campoNome { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='frmCadastro']/fieldset/ul/li[2]/label[1]")]
        [CacheLookup]
        public IWebElement LabelCpf { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='txtCpf']")]
        [CacheLookup]
        public IWebElement InputCpf { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='txtTelefone']")]
        [CacheLookup]
        public IWebElement campoTelefone { get; set; }

        [FindsBy(How = How.Id, Using = "txtEmail")]
        [CacheLookup]
        public IWebElement campoEmail { get; set; }

        [FindsBy(How = How.Id, Using = "txtEmailConfirmar")]
        [CacheLookup]
        public IWebElement campoEmailConf { get; set; }

        [FindsBy(How = How.Id, Using = "txtSenha")]
        [CacheLookup]
        public IWebElement campoSenha { get; set; }

        [FindsBy(How = How.Id, Using = "txtSenhaConfirmar")]
        [CacheLookup]
        public IWebElement senhaConf { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='frmCadastro']/fieldset/ul/li[8]/button")]
        [CacheLookup]
        public IWebElement btnCadastro { get; set; }

    }
}
