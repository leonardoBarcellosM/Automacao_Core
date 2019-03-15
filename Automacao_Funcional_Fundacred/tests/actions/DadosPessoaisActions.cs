using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace Automacao_Funcional.tests.steps
{
    class DadosPessoaisActions : DadosPessoaisMap
    {
        private ClassUtilities util = new ClassUtilities();
        private MassaDeDados massa = new MassaDeDados();

        public DadosPessoaisActions()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public bool PreencherDadosPessoais()
        {
            bool _result = false;

            util.ScrollElementoPage(InputRg);
            Thread.Sleep(3000);
            string rg = util.GerarRg();

            try
            {
                util.WaitForElementVisible(InputRg, 30);
                if (InputRg.Displayed)
                {
                    Thread.Sleep(300);
                    InputRg.Click();
                    Thread.Sleep(300);
                    InputRg.SendKeys(rg);
                    Thread.Sleep(300);
                    InputDtaNasc.Click();
                    Thread.Sleep(300);
                    InputDtaNasc.SendKeys(massa.dtaNasc);
                    Thread.Sleep(300);
                    RadioMasc.Click();
                    Thread.Sleep(300);
                    RadioNacio.Click();
                    Thread.Sleep(300);
                    ListEstCivil.Click();
                    Thread.Sleep(300);
                    var selectElement = new SelectElement(ListEstCivil);
                    selectElement.SelectByIndex(1);
                    Thread.Sleep(300);
                    RadioUniao.Click();
                    Thread.Sleep(1000);

                    _result = true;
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool PreencherEndereco()
        {
            bool _result = false;

            Thread.Sleep(4000);
            try
            {
                if (Campoendereco.Displayed)
                {
                    InputCep.Click();
                    Thread.Sleep(600);
                    InputCep.SendKeys(massa.cep);
                    Thread.Sleep(600);
                    //BtnBuscarEnder.Click();
                    Thread.Sleep(600);

                    InputNumero.Click();
                    Thread.Sleep(600);
                    InputNumero.SendKeys(massa.numero);
                    Thread.Sleep(600);

                    InputComplemento.Click();
                    Thread.Sleep(600);
                    InputComplemento.SendKeys(massa.complemento);
                    Thread.Sleep(600);

                    Campoendereco.Clear();
                    Thread.Sleep(600);
                    Campoendereco.Click();
                    Thread.Sleep(600);
                    Campoendereco.SendKeys("Av Júlio De Castilhos");
                    Thread.Sleep(600);

                    CampoBairro.Clear();
                    Thread.Sleep(600);
                    CampoBairro.Click();
                    Thread.Sleep(600);
                    CampoBairro.SendKeys("Centro Histórico");
                    Thread.Sleep(600);

                    CampoCidade.Clear();
                    Thread.Sleep(600);
                    CampoCidade.Click();
                    Thread.Sleep(600);
                    CampoCidade.SendKeys("Porto Alegre");
                    Thread.Sleep(600);

                    var selectElement = new SelectElement(SelectUf);
                    Thread.Sleep(600);
                    selectElement.SelectByIndex(21);
                    Thread.Sleep(600);

                    InputNomePai.Click();
                    Thread.Sleep(600);
                    InputNomePai.SendKeys(massa.nomePai);
                    Thread.Sleep(600);

                    InputCpfPai.Click();
                    Thread.Sleep(600);
                    InputCpfPai.SendKeys(util.GerarCpf());
                    Thread.Sleep(600);

                    util.ScrollPage(1);

                    InputNomeMae.Click();
                    Thread.Sleep(600);
                    InputNomeMae.SendKeys(massa.nomeMae);
                    Thread.Sleep(600);

                    InputCpfMae.Click();
                    Thread.Sleep(600);
                    InputCpfMae.SendKeys(util.GerarCpf());
                    Thread.Sleep(600);

                    InputDdd.Click();
                    Thread.Sleep(600);
                    InputDdd.SendKeys(massa.ddd);
                    Thread.Sleep(600);

                    InputNumeroTel.Click();
                    Thread.Sleep(600);
                    InputNumeroTel.SendKeys(massa.numTel);
                    Thread.Sleep(600);

                    InputRamal.Click();
                    Thread.Sleep(600);
                    InputRamal.SendKeys(massa.ramal);
                    Thread.Sleep(600);

                    _result = true;
                }
                else
                {

                }
            }
            catch
            {

            }
            return _result;
        }

        public bool ClicarEmProximo()
        {
            bool _result = false;

            try
            {
                if (BtnProximo.Displayed) 
                {
                    BtnProximo.Click();
                    _result = true;
                }
                else
                {
                    
                }
            }
            catch
            {
               
            }
            return _result;
        }

        public bool ValidarDirecionamentoFiador()
        {
            bool _result = false;
            try
            {
                IWebElement Validar = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//h2[text()='Dados do Fiador ']"));
                util.WaitForElementVisible(Validar, 5);
                if (Validar.Displayed)
                {
                    util.ScrollElementoPage(Validar);
                    _result = true;
                    Thread.Sleep(5000);
                }
                else
                {
                    
                }
            }
            catch
            {
               
            }
            return _result;
        }

    }
}
