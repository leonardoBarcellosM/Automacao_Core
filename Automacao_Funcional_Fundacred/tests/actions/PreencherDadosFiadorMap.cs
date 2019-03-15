using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automacao_Funcional.tests.steps
{
    class PreencherDadosFiadorMap
    {
        [FindsBy(How = How.XPath, Using = "//ng-form[@class='ng-pristine ng-invalid ng-invalid-required ng-valid-pattern ng-valid-maxlength ng-valid-cpf ng-valid-cep ng-valid-minlength']//div//div[2]//div//input[1]")]
        [CacheLookup]
        public IWebElement InputRg { get; set; }

        [FindsBy(How = How.XPath, Using = "//ng-form[@name='dadosFiadorForm']//div[@class='row'][2]//div//div//div//label//input")]
        [CacheLookup]
        public IWebElement RadioNacio { get; set; }

        [FindsBy(How = How.XPath, Using = "//ng-form[@name='dadosFiadorForm']//div[@class='row'][3]//div//div//div//select")]
        [CacheLookup]
        public IWebElement ListEstCivil { get; set; }

        [FindsBy(How = How.XPath, Using = "//ng-form[@name='dadosFiadorForm']//div[@class='row'][3]//div//div//div//select//option[2]")]
        [CacheLookup]
        public IWebElement OptEstCivil { get; set; }

        [FindsBy(How = How.XPath, Using = "//ng-form[@name='dadosFiadorForm']//div[@class='row'][3]//div[2]//div//div//label[2]//input")]
        [CacheLookup]
        public IWebElement RadioUniao { get; set; }

        [FindsBy(How = How.XPath, Using = "//ng-form[@name='dadosFiadorForm']//div[@class='row'][2]//div[2]//div[1]//input[1]")]
        [CacheLookup]
        public IWebElement InputNomeMae { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//ng-form[@name='dadosFiadorForm']//div[@class='row'][4]//div[1]//div[1]//div[1]/./div[1]//a")]
        [CacheLookup]
        public IWebElement SelectProfissao { get; set; }

        [FindsBy(How = How.XPath, Using = "//ng-form[@name='dadosFiadorForm']//div[@class='row'][4]//div[1]//div[1]//div[1]//div/./div//ul//li[30]")]
        [CacheLookup]
        public IWebElement OptProfissao { get; set; }

        [FindsBy(How = How.XPath, Using = "//ng-form[@name='dadosFiadorForm']//div[@class='row ng-scope']//div[1]//div[1]//input")]
        [CacheLookup]
        public IWebElement InputDdd { get; set; }

        [FindsBy(How = How.XPath, Using = "//ng-form[@name='dadosFiadorForm']//div[@class='row ng-scope']//div[2]//div[1]//input")]
        [CacheLookup]
        public IWebElement InputTel { get; set; }

        [FindsBy(How = How.XPath, Using = "//ng-form[@name='dadosFiadorForm']//div[@class='row ng-scope']//div[3]//div[1]//input")]
        [CacheLookup]
        public IWebElement InputRamal { get; set; }

        [FindsBy(How = How.XPath, Using = "//ng-form[@name='dadosFiadorForm']//div[@class='row'][5]//div[1]/./div[1]/./input")]
        [CacheLookup]
        public IWebElement InputCep { get; set; }

        [FindsBy(How = How.XPath, Using = "//ng-form[@name='dadosFiadorForm']//div[6]//div[1]//div[1]//div[1]//span//a")]
        [CacheLookup]
        public IWebElement BtnBuscarCep { get; set; }

        [FindsBy(How = How.XPath, Using = "//ng-form[@name='dadosFiadorForm']//div[@class='row'][6]//div[2]//div[1]//input[1]")]
        [CacheLookup]
        public IWebElement InputNumEnder { get; set; }

        [FindsBy(How = How.XPath, Using = "//ng-form[@name='dadosFiadorForm']//div[@class='row'][6]//div[3]//div[1]//input[1]")]
        [CacheLookup]
        public IWebElement InputComplemento { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@class='nav nav-tabs']//li[3]")]
        [CacheLookup]
        public IWebElement BtnProximo { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div/div/ng-view/section/form/div/div/div/div[2]/div/div/ng-form/div[7]/div[1]/div/input")]
        [CacheLookup]
        public IWebElement Campoendereco { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div/div/ng-view/section/form/div/div/div/div[2]/div/div/ng-form/div[8]/div[2]/div/input")]
        [CacheLookup]
        public IWebElement CampoCidade { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div/div/ng-view/section/form/div/div/div/div[2]/div/div/ng-form/div[8]/div[1]/div/input")]
        [CacheLookup]
        public IWebElement CampoBairro { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div/div/ng-view/section/form/div/div/div/div[2]/div/div/ng-form/div[8]/div[3]/div/div/select")]
        [CacheLookup]
        public IWebElement SelectUf { get; set; }
    }
}
