using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace Automacao_Funcional.tests.steps
{
    class DadosDoEstudanteActions : DadosDoEstudanteMap
    {
        private ClassUtilities util = new ClassUtilities();
        private MassaDeDados Massa = new MassaDeDados();
        private ConsultaDB db = new ConsultaDB();

        public DadosDoEstudanteActions()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public bool InserirIntegrantes(string arg)
        {
            bool _result = false;
            try
            {
                util.WaitForElementVisible(InputIntegrantes, 45);
                if (InputIntegrantes.Displayed)
                {
                    util.ScrollElementoPage(InputIntegrantes);
                    InputIntegrantes.Click();
                    Thread.Sleep(300);
                    InputIntegrantes.SendKeys(arg);
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

        public bool InserirRenda(string arg)
        {
            bool _result = false;
            try
            {
                util.WaitForElementVisible(InputRenda, 45);
                if (InputRenda.Displayed)
                {
                    InputRenda.Click();
                    Thread.Sleep(300);
                    InputRenda.SendKeys(arg);
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

        public bool ClicarEnviar()
        {
            bool _result = false;
            try
            {
                util.WaitForElementVisible(BtnSubmit, 45);
                if (BtnSubmit.Displayed && BtnSubmit.Enabled)
                {
                    BtnSubmit.Click();
                    Thread.Sleep(2000);
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

        public bool PreencherDados()
        {
            bool _result = false;

            try
            {
                util.WaitForElementVisible(InputNome, 45);
                if (InputNome.Displayed)
                {
                    InputNome.Click();
                    Thread.Sleep(250);
                    InputNome.SendKeys(Massa.nome + " " + Massa.sobrenome);

                    InputCpf.Click();
                    Thread.Sleep(250);
                    //InputCpf.SendKeys(UpdateStatusDB.PegarCpf());

                    InputRg.Click();
                    Thread.Sleep(250);
                    InputRg.SendKeys(util.GerarRg());

                    InputDtaNasc.Click();
                    Thread.Sleep(250);
                    InputDtaNasc.SendKeys(Massa.dtaNasc);

                    InputNMatric.Click();
                    Thread.Sleep(250);
                    InputNMatric.SendKeys(Massa.matricula);

                    Thread.Sleep(500);

                    _result = true;
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool ValidarDirecionamentoEtapa3()
        {
            bool _result = false;
            
            try
            {
                IWebElement Validar = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//section[@class='ng-scope']//h2[text()='Dados do Fiador']"));
                util.WaitForElementVisible(Validar, 45);
                if (Validar.Displayed)
                {
                    _result = true;
                }
                else
                {
                    ClassInfo.GetInstance().LogMessage = "else - Erro Validar etapa 3";
                }

            }
            catch
            {
                util.ScreenshotPrepare();
                ClassInfo.GetInstance().LogMessage = "try - Erro Validar etapa 3";
            }

            return _result;
        }

        public bool ValidarEstudanteNoDb()
        {
            bool _result = false;

            try
            {
                string[] list = db.ConsultaSolicitacao();

                if (list[0] == "PAF" && list[1] == "PDBF" && list[2] == "PDBF")
                {
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

        public bool ValidarFiadorNoDb()
        {
            bool _result = false;

            try
            {
                string[] list = db.ConsultaSolicitacao();

                if (list[0] == "PAF" && list[1] == "PDC" && list[2] == "PDC")
                {
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
