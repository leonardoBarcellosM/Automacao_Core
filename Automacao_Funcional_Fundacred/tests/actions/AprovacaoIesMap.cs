using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automacao_Funcional.tests.steps
{
    class AprovacaoIesMap
    {
        [FindsBy(How = How.XPath, Using = "//ul[@class='items'][1]//li[2]//a[1]")]
        [CacheLookup]
        public IWebElement OptAprovacao { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='panel panel-default ng-scope'][1]//div/./button[1]")]
        [CacheLookup]
        public IWebElement BtnAprovar { get; set; }

        [FindsBy(How = How.XPath, Using = "//form[@name='formBusca']//div[1]//div[1]//div[1]//div[1]//div[1]//input")]
        [CacheLookup]
        public IWebElement InputCpf { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal - aprovacao']/form/div/div[2]/div[2]/div/div[1]/input")]
        [CacheLookup]
        public IWebElement InputMatricula { get; set; }
    
        [FindsBy(How = How.XPath, Using = "//*[@id='modal-aprovacao']/form/div/div[2]/div[2]/div/div[3]/input")]
        [CacheLookup]
        public IWebElement InputPercentual { get; set; }

        [FindsBy(How = How.XPath, Using = ".//form[@name='formCalculo']/./div[2]//div[2]//div[1]//div[2]//select")]
        [CacheLookup]
        public IWebElement SelectSemestre { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-aprovacao']/form/div/div[4]/div[3]/div/div/div[1]/div/div/div/div[2]/div/div/div[1]/input")]
        [CacheLookup]
        public IWebElement InputValor_01 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-aprovacao']/form/div/div[4]/div[3]/div/div/div[1]/div/div/div/div[2]/div/div/div[2]/input")]
        [CacheLookup]
        public IWebElement InputValor_02 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-aprovacao']/form/div/div[4]/div[3]/div/div/div[2]/div/div/div/div[2]/div/div/div[1]/input")]
        [CacheLookup]
        public IWebElement InicioContrato { get; set; }

        [FindsBy(How = How.XPath, Using = "//*/form/div/div[4]/div[3]/div/div/div[2]/div/div/div/div[2]/div/div/div[2]/input")]
        [CacheLookup]
        public IWebElement FinalContrato { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='modal-footer ng-scope']/./button[1]")]
        [CacheLookup]
        public IWebElement BtnAprovar02 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//form[@name='formCalculo']/./div[3]//div[1]//div[1]//div[2]//select[1]")]
        [CacheLookup]
        public IWebElement SelectTipo { get; set; }

        [FindsBy(How = How.XPath, Using = ".//form[@name='formCalculo']/./div[4]//div[2]//div[2]//div[1]//input[1]")]
        [CacheLookup]
        public IWebElement InputContrato { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[1]/div[3]/div/div/div/div[2]/div/button[3]")]
        [CacheLookup]
        public IWebElement BtnReprovar { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='textMotivo']")]
        [CacheLookup]
        public IWebElement SelectMotivo { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div/div[3]/button[1]")]
        [CacheLookup]
        public IWebElement BtnReprovarConfirm { get; set; }

        [FindsBy(How = How.XPath, Using = "//TEXTAREA[@id='observacao']/self::TEXTAREA")]
        [CacheLookup]
        public IWebElement TextArea { get; set; }
        //
    }
}


