using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automacao_Funcional.tests.steps
{
    class SelecaoDeInstituicaoMap
    {

        [FindsBy(How = How.Id, Using = "listaIES_chosen")]
        [CacheLookup]
        public IWebElement lista { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='col-sm-6 col-xs-12 checkbox']//input")]
        [CacheLookup]
        public IWebElement CheckAceite { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@class='chosen-results'][1]//li[72]")]
        [CacheLookup]
        public IWebElement Option_01 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='col-sm-6 col-xs-12']//button[@class='btn btn-laranja btn-block']")]
        [CacheLookup]
        public IWebElement BtnSubmit { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='formCadastroEstudante']/div[3]/div/div/div/div/label[2]/span")]
        [CacheLookup]
        public IWebElement OpResponsavel { get; set; }
    }
}
