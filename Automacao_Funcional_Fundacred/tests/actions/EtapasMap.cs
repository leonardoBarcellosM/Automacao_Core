using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automacao_Funcional.tests.steps
{
    class EtapasMap
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[2]/div/div/ng-view/section/div[1]/div[1]/a")]
        [CacheLookup]
        public IWebElement OptionSolicitacao { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-laranja btn-line-wrap btn-destaque btn-block']")]
        [CacheLookup]
        public IWebElement BtnQueroSolicitarCrd { get; set; }
    }


}
