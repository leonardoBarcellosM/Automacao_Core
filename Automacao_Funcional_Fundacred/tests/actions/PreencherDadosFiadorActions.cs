using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace Automacao_Funcional.tests.steps
{
    class PreencherDadosFiadorActions : PreencherDadosFiadorMap
    {
        private ClassUtilities util = new ClassUtilities();
        private MassaDeDados massa = new MassaDeDados();

        public PreencherDadosFiadorActions()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public bool PreencherDadosFiador()
        {
            bool _result = false;

            string rg = util.GerarRg();
            try
            {
                util.WaitForElementVisible(InputRg, 15);
                if (InputRg.Displayed)
                {
                    InputRg.Click();
                    Thread.Sleep(300);
                    InputRg.SendKeys(rg);
                    Thread.Sleep(300);
                    util.ClickJS(RadioNacio);
                    Thread.Sleep(300);
                    InputNomeMae.Click();
                    Thread.Sleep(300);
                    InputNomeMae.SendKeys(massa.nomeMae);
                    Thread.Sleep(300);
                    ListEstCivil.Click();
                    Thread.Sleep(300);
                    var selectElement = new SelectElement(ListEstCivil);
                    selectElement.SelectByIndex(1);
                    ListEstCivil.Click();
                    Thread.Sleep(300);
                    util.ClickJS(RadioUniao);
                    Thread.Sleep(300);
                    SelectProfissao.Click();
                    Thread.Sleep(300);
                    OptProfissao.Click();
                    Thread.Sleep(300);

                    _result = true;
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool PreencherContatoEndereco()
        {
            bool _result = false;

            try
            {
                util.WaitForElementVisible(InputDdd, 15);
                if (InputDdd.Displayed)
                {
                    InputDdd.Click();
                    Thread.Sleep(300);
                    InputDdd.SendKeys(massa.ddd);
                    Thread.Sleep(300);
                    InputTel.Click();
                    Thread.Sleep(300);
                    InputTel.SendKeys(massa.numTel);
                    Thread.Sleep(300);
                    InputRamal.Click();
                    Thread.Sleep(300);
                    InputRamal.SendKeys(massa.ramal);
                    Thread.Sleep(300);
                    util.ClickJS(InputCep);
                    Thread.Sleep(300);
                    InputCep.SendKeys(massa.cep);
                    Thread.Sleep(2000);
                    util.ScrollElementoPage(BtnBuscarCep);
                    Thread.Sleep(2000);
                    //BtnBuscarCep.Click();
                    Thread.Sleep(500);
                    util.ScrollElementoPage(InputNumEnder);
                    InputNumEnder.Click();
                    Thread.Sleep(300);
                    InputNumEnder.SendKeys(massa.numero);
                    Thread.Sleep(300);
                    InputComplemento.Click();
                    Thread.Sleep(300);
                    InputComplemento.SendKeys(massa.complemento);

                    Campoendereco.Clear();
                    Campoendereco.Click();
                    Campoendereco.SendKeys("Av Júlio De Castilhos");
                    Thread.Sleep(300);

                    CampoBairro.Clear();
                    CampoBairro.Click();
                    CampoBairro.SendKeys("Centro Histórico");
                    Thread.Sleep(300);

                    CampoCidade.Clear();
                    CampoCidade.Click();
                    CampoCidade.SendKeys("Porto Alegre");
                    Thread.Sleep(300);

                    var selectElement = new SelectElement(SelectUf);
                    selectElement.SelectByIndex(21);

                    _result = true;
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool Prosseguir()
        {
            bool _result = false;

            try
            {
                util.WaitForElementVisible(BtnProximo, 10);
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

        public bool ValidarDirecionamentoDadosCurso()
        {
            bool _result = false;
            try
            {
                IWebElement Validar = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//h2[text()='Dados do Curso']"));
                util.WaitForElementVisible(Validar, 15);
                if (Validar.Displayed)
                {
                    util.ScrollElementoPage(Validar);

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
    }
}