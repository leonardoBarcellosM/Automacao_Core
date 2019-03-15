using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automacao_Funcional.tests.steps
{
    class DadosPessoaisMap
    {

        [FindsBy(How = How.XPath, Using = "//div[@class='row'][1]//div[2]//div//input[1]")]
        [CacheLookup]
        public IWebElement InputRg { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='row'][2]//div[1]//div//input[1]")]
        [CacheLookup]
        public IWebElement InputDtaNasc { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='row'][2]//div[2]//div//div//label[2]")]
        [CacheLookup]
        public IWebElement RadioMasc { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='row'][2]//div[3]//div//div//label[1]")]
        [CacheLookup]
        public IWebElement RadioNacio { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='row'][3]//div//div//div//select[1]")]
        [CacheLookup]
        public IWebElement ListEstCivil { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='row'][3]//div//div//div//select[1]//option[2]")]
        [CacheLookup]
        public IWebElement OptEstCivil { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='row'][3]//div[2]//div//label[2]")]
        [CacheLookup]
        public IWebElement RadioUniao { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='row'][4]//div//div//div//input[1]")]
        [CacheLookup]
        public IWebElement InputCep { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='row'][4]//div//div//div//a[1]")]
        [CacheLookup]
        public IWebElement BtnBuscarEnder { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='row'][5]//div[2]//div//input")]
        [CacheLookup]
        public IWebElement InputNumero { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='row'][5]//div[3]//div//input")]
        [CacheLookup]
        public IWebElement InputComplemento { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='row'][7]//div[1]//div//input[1]")]
        [CacheLookup]
        public IWebElement InputNomePai { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='row'][7]//div[2]//div//input[1]")]
        [CacheLookup]
        public IWebElement InputCpfPai { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='row'][8]//div[1]//div//input[1]")]
        [CacheLookup]
        public IWebElement InputNomeMae { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='row'][8]//div[2]//div//input[1]")]
        [CacheLookup]
        public IWebElement InputCpfMae { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='row ng-scope']//div[1]//div//input[1]")]
        [CacheLookup]
        public IWebElement InputDdd { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='row ng-scope']//div[2]//div//input[1]")]
        [CacheLookup]
        public IWebElement InputNumeroTel { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='row ng-scope']//div[3]//div//input[1]")]
        [CacheLookup]
        public IWebElement InputRamal { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@class='nav nav-tabs']//li[2]")]
        [CacheLookup]
        public IWebElement BtnProximo { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div/div/ng-view/section/form/div/div/div/div[1]/div/div/ng-form/div[5]/div[1]/div/input")]
        [CacheLookup]
        public IWebElement Campoendereco { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div/div/ng-view/section/form/div/div/div/div[1]/div/div/ng-form/div[6]/div[2]/div/input")]
        [CacheLookup]
        public IWebElement CampoCidade { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div/div/ng-view/section/form/div/div/div/div[1]/div/div/ng-form/div[6]/div[1]/div/input")]
        [CacheLookup]
        public IWebElement CampoBairro { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div/div/ng-view/section/form/div/div/div/div[1]/div/div/ng-form/div[6]/div[3]/div/div/select")]
        [CacheLookup]
        public IWebElement SelectUf { get; set; }
    }
}
