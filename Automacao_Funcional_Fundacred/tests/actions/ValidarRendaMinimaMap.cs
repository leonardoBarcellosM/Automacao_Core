using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automacao_Funcional.tests.steps
{
    class ValidarRendaMinimaMap
    {

        [FindsBy(How = How.XPath, Using = "//form[@name='formCadastroFiador']//div[@class='row'][3]//div[2]//div[1]//div[1] //div[1]//div[1]//div[2 and text()=' Seu fiador precisa comprovar renda bruta mínima de R$3.808,14. ']")]
        [CacheLookup]
        public IWebElement MsgRenda { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[2]/div/div/ng-view/section/form/div[3]/div[2]/div/renda-minima-fiador/div/div/div[2]/div/div/label")]
        [CacheLookup]
        public IWebElement BtnContinuar { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[2]/div/div/ng-view/section/form/div[6]/div[3]/div[2]/div/renda-minima-fiador/div/div/div[2]/div/div/label")]
        [CacheLookup]
        public IWebElement BtnContinuar2 { get; set; }
        
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[2]/div/div/ng-view/section/form/div[3]/div[2]/div/renda-minima-fiador/div/div/div/div[2]")]
        [CacheLookup]
        public IWebElement MsgConfirma { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[2]/div/div/ng-view/section/form/div[6]/div[3]/div[2]/div/renda-minima-fiador/div/div/div[1]/div[2]")]
        [CacheLookup]
        public IWebElement MsgConfirma2 { get; set; }


        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[2]/div/div/ng-view/section/form/div[3]/div[2]/div/renda-minima-fiador/div/div/div[1]/div[2]")]
        [CacheLookup]
        public IWebElement MsgRendaInvalida { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='row'][3]//div[2]//div//input[1]")]
        [CacheLookup]
        public IWebElement InputRenda { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[2]/div/div/ng-view/section/form/div[6]/button")]
        [CacheLookup]
        public IWebElement BtnEnviar { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[2]/div/div/ng-view/section/form/div[7]/button")]
        [CacheLookup]
        public IWebElement btnEnviarDoisFiadores { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='row'][2]//div[2]//div//input[1]")]
        [CacheLookup]
        public IWebElement InputCpf { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[2]/div/div/ng-view/section/form/div[5]/div/div/div/label")]
        [CacheLookup]
        public IWebElement Check2Fiadores { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[2]/div/div/ng-view/section/form/div[6]/div[3]/div[2]/div/renda-minima-fiador/input")]
        [CacheLookup]
        public IWebElement InputRenda2 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[2]/div/div/ng-view/section/form/div[6]/div[3]/div[2]/div/renda-minima-fiador/div/div/div[1]/div[2]/text()")]
        [CacheLookup]
        public IWebElement MsgRendaInvalida2 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[2]/div/div/ng-view/section/form/div[6]/div[1]/div/input")]
        [CacheLookup]
        public IWebElement BtnRemoverFiador { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div[3]/button[1]")]
        [CacheLookup]
        public IWebElement BtnRmvSim { get; set; }

    }
}
