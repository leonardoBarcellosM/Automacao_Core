using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automacao_Funcional.tests.steps
{
    class SelecionarDocumentosMap
    {
        [FindsBy(How = How.XPath, Using = "//ng-form[@name='documentosForm']/./div[2]//div/./div[1]/./div[1]//div[1]//div[1]//div//span")]
        [CacheLookup]
        public IWebElement BtnId01Frente { get; set; }

        [FindsBy(How = How.XPath, Using = "//ng-form[@name='documentosForm']/./div[2]//div/./div[1]/./div[1]//div[2]//div//span[1]")]
        [CacheLookup]
        public IWebElement BtnId01Verso { get; set; }

        [FindsBy(How = How.XPath, Using = "//ng-form[@name='documentosForm']/./div[2]//div/./div[1]/./div[1]//div[3]//div//span[1]")]
        [CacheLookup]
        public IWebElement BtnCpfFrente { get; set; }

        [FindsBy(How = How.XPath, Using = "//ng-form[@name='documentosForm']/./div[2]//div/./div[1]/./div[1]//div[4]//div//span[1]")]
        [CacheLookup]
        public IWebElement BtnResidencia { get; set; }

        [FindsBy(How = How.XPath, Using = "//ng-form[@name='documentosForm']/./div[2]//div/./div[1]/./div[1]//div[5]//div//span[1]//a")]
        [CacheLookup]
        public IWebElement BtnRenda { get; set; }

        [FindsBy(How = How.XPath, Using = "//ng-form[@name='documentosForm']/./div[2]//div/./div[1]/./div[1]//div[6]//div//span[1]//a")]
        [CacheLookup]
        public IWebElement BtnMatricula { get; set; }

        [FindsBy(How = How.XPath, Using = "//ng-form[@name='documentosForm']//div[@class='m-t-30 panel-online ng-scope']//div[1]//div[1]//div[1]//span[1]//a[1]")]
        [CacheLookup]
        public IWebElement BtnIdGF { get; set; }

        [FindsBy(How = How.XPath, Using = "//ng-form[@name='documentosForm']//div[@class='m-t-30 panel-online ng-scope']//div[2]//div[1]//div[1]//span[1]//a[1]")]
        [CacheLookup]
        public IWebElement BtnIdGF2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//ng-form[@name='documentosForm']//div[@class='m-t-30 panel-online ng-scope']//div[3]//div[1]//div[1]//span[1]//a[1]")]
        [CacheLookup]
        public IWebElement BtnCpfGF { get; set; }

        [FindsBy(How = How.XPath, Using = "//ng-form[@name='documentosForm']//div[@class='m-t-30 panel-online ng-scope'][2]//div[1]//div[1]//div[1]//span[1]//a[1]")]
        [CacheLookup]
        public IWebElement BtnRendaFamiliar { get; set; }

        [FindsBy(How = How.XPath, Using = "//ng-form[@name='documentosForm']//div[@class='m-t-50'][1]//div[1]//div[1]//div[1]//span[1]//a[1]")]
        [CacheLookup]
        public IWebElement BtnIdFiadorFrente { get; set; }

        [FindsBy(How = How.XPath, Using = "//ng-form[@name='documentosForm']//div[@class='m-t-50'][1]//div[1]//div[2]//div[1]//span[1]//a[1]")]
        [CacheLookup]
        public IWebElement BtnIdFiadorVerso { get; set; }

        [FindsBy(How = How.XPath, Using = "//ng-form[@name='documentosForm']//div[@class='m-t-50'][1]//div[1]//div[3]//div[1]//span[1]//a[1]")]
        [CacheLookup]
        public IWebElement BtnCpfFiador { get; set; }

        [FindsBy(How = How.XPath, Using = "//ng-form[@name='documentosForm']//div[@class='m-t-50'][1]//div[1]//div[4]//div[1]//span[1]//a[1]")]
        [CacheLookup]
        public IWebElement BtnFiadorResidencia { get; set; }

        [FindsBy(How = How.XPath, Using = "//ng-form[@name='documentosForm']//div[@class='m-t-50'][2]//div[1]//div[1]//div[1]//span[1]//a[1]")]
        [CacheLookup]
        public IWebElement BtnExtra { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//ng-form[@name='documentosForm']//div[@class='m-t-50'][2]//div[2]//div[2]//div[1]//div[1]//span[1]//a")]
        [CacheLookup]
        public IWebElement BtnImpostoRenda { get; set; }

        [FindsBy(How = How.XPath, Using = "//ng-form[@name='documentosForm']//div[@class='m-t-50'][2]//div[1]//div[1]//div[1]//label[6]")]
        [CacheLookup]
        public IWebElement BtnRendimentos { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div/div/ng-view/section/form/div/div/div/div[4]/div/div/div[1]/ng-form/div[2]/div/div[5]/div[2]/div/div/button")]
        [CacheLookup]
        public IWebElement BtnConcluir { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='modal-dialog']//div/./div[3]//button[1]")]
        [CacheLookup]
        public IWebElement BtnConfirmImg { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='modal-dialog']//div/./button")]
        [CacheLookup]
        public IWebElement BtnClose { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div/div/ng-view/section/form/div/div/div/div[4]/div/div/div[1]/ng-form/div[2]/div/div[5]/div[2]/div/div/button")]
        [CacheLookup]
        public IWebElement BtnConcluirSolic { get; set; }

    }
}
