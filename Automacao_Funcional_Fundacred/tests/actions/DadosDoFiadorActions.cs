using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;


namespace Automacao_Funcional.tests.steps
{
    class DadosDoFiadorActions : DadosDoFiadorMap
    {
        private ClassUtilities util = new ClassUtilities();

        public DadosDoFiadorActions()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public bool InserirNomeECpf(string arg)
        {
            bool _result = false;
            string cpf = util.GerarCpf();
            
            try
            {
                util.WaitForElementVisible(InputNome, 45);
                if (InputNome.Displayed)
                {
                    InputNome.Click();
                    Thread.Sleep(300);
                    InputNome.SendKeys(arg);
                    Thread.Sleep(300);
                    InputCpf.Click();
                    Thread.Sleep(300);
                    InputCpf.SendKeys(cpf);
                    //InputCpf.SendKeys("01781619859");
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

        public bool InserirDtaERenda(string[] arg)
        {
            bool _result = false;
            try
            {
                util.WaitForElementVisible(InputDtaNasc, 45);
                if (InputDtaNasc.Displayed)
                {
                    InputDtaNasc.Click();
                    Thread.Sleep(300);
                    InputDtaNasc.SendKeys(arg[1]);
                    Thread.Sleep(300);
                    InputRenda.Click();
                    Thread.Sleep(300);
                    InputRenda.SendKeys(arg[0]);
                    Thread.Sleep(1000);

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

        public bool ClicarEnviarEtapa3()
        {
            bool _result = false;
            try
            {
                util.WaitForElementVisible(BtnEnviar, 45);
                if (BtnEnviar.Displayed && BtnEnviar.Enabled)
                {
                    BtnEnviar.Click();
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

        public bool ValidarDirecionamentoEtapa4()
        {
            bool _result = false;
            
            try
            {
                IWebElement Validar = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//h2[text()='Dados Pessoais']"));
                util.WaitForElementVisible(Validar, 45);
                if (Validar.Displayed)
                {
                    _result = true;
                }
                else
                {
                    ClassInfo.GetInstance().LogMessage = "else - Erro Validar etapa 4";
                }

            }
            catch
            {
                util.ScreenshotPrepare();
                ClassInfo.GetInstance().LogMessage = "try - Erro Validar etapa 4";
            }

            return _result;
        }

        //public bool ValidarPosFiadorNoDb()
        //{
        //    bool _result = false;

        //    try
        //    {
        //        //string[] list = db.ConsultaSolicitacao();

        //        if (list[0] == "PAF" && list[1] == "PDC" && list[2] == "PDC")
        //        {
        //            _result = true;
        //        }
        //        else
        //        {
        //        }
        //    }
        //    catch
        //    {
        //    }

        //    return _result;
        //}
    }
}
