using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automacao_Funcional.tests.actions
{
    class DependenteCadastroMap
    {

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[2]/div/div/ng-view/section/form/div[2]/div/div/input")]
        [CacheLookup]
        public IWebElement NumMatricula01 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[2]/div/div/ng-view/section/form/div[2]/div[1]/div[1]/div//*[@id='nomecompleto']")]
        [CacheLookup]
        public IWebElement InputNomeDep { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[2]/div/div/ng-view/section/form/div[2]/div[1]/div[2]//*[@id='cpf']")]
        [CacheLookup]
        public IWebElement InputCpfDep { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[2]/div/div/ng-view/section/form/div[2]/div[2]/div[1]/div/input")]
        [CacheLookup]
        public IWebElement InputRgDep { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='dataNascimentoEstudante']")]
        [CacheLookup]
        public IWebElement InputDtDep { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[2]/div/div/ng-view/section/form/div[2]/div[3]/div/div/input")]
        [CacheLookup]
        public IWebElement NumMatricula02 { get; set; }

    }
}
