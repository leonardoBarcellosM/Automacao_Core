using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Threading;
using OpenQA.Selenium.Support.UI;


namespace Automacao_Funcional.tests.steps
{
    class AprovacaoIesActions : AprovacaoIesMap
    {
        private ClassUtilities util = new ClassUtilities();
        private ConsultaDB db = new ConsultaDB();

        public AprovacaoIesActions()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public bool AcessarAprovacao()
        {
            bool _result = false;

            try
            {
                util.WaitForElementVisible(OptAprovacao, 45);
                if (OptAprovacao.Displayed)
                {
                    OptAprovacao.Click();
                    _result = true;
                }
            }
            catch
            {

            }

            return _result;
        }

        public bool PesquisarSolicitacao(string cpf)
        {
            bool _result = false;
            ConsultaDB.Cpf(cpf);
            try
            {
                Thread.Sleep(4000);
                if (InputCpf.Displayed)
                {
                    InputCpf.Click();
                    Thread.Sleep(300);
                    InputCpf.SendKeys(cpf);
                    Thread.Sleep(3000);
                    _result = true;
                }
            }
            catch
            {

            }

            return _result;
        }

        public bool ClicarEmProsseguir()
        {
            bool _result = false;

            try
            {
                util.WaitForElementVisible(BtnAprovar, 45);
                if (BtnAprovar.Displayed)
                {
                    BtnAprovar.Click();
                    _result = true;
                }
            }
            catch
            {

            }

            return _result;
        }


        public bool ValidarTelaAprovar()
        {
            bool _result = false;

            try
            {
                WebDriverWait wait = new WebDriverWait(ClassDriver.GetInstance().Driver, TimeSpan.FromSeconds(40));
                IWebElement Validar = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//div[@class='modal-content'][1]//div//h2"));
                Thread.Sleep(5000);
                if (Validar.Displayed)
                {
                    _result = true;
                }
            }
            catch
            {

            }
            return _result;
        }



        public bool InserirDadosPendentes()
        {
            bool _result = false;

            try
            {
                util.WaitForElementVisible(InputPercentual, 30);
                if (InputPercentual.Displayed)
                {
                     InputPercentual.Click();
                     Thread.Sleep(300);
                     InputPercentual.SendKeys("85");
                     _result = true;
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool InserirValores()
        {
            bool _result = false;
           // string path = @"C:\Users\leonardo.barcellos\Desktop\Imagens\teste.jpg";
            util.WaitForElementVisible(InputValor_01, 30);
            try
            {
                if (InputValor_01.Displayed)
                {
                    util.ScrollElementoPage(InputValor_01);

                    InputValor_01.Click();
                    Thread.Sleep(300);
                    InputValor_01.SendKeys("5.000,00");

                    InputValor_02.Click();
                    Thread.Sleep(300);
                    InputValor_02.SendKeys("4.750,00");

                    InicioContrato.Click();
                    Thread.Sleep(300);
                    InicioContrato.SendKeys("01/2019");

                    FinalContrato.Click();
                    Thread.Sleep(300);
                    FinalContrato.SendKeys("12/2021");

                    _result = true;
                }
                else
                {
                    
                }
            }
            catch
            {
                util.ScrollElementoPage(SelectTipo);
                var selectElement = new SelectElement(SelectTipo);
                selectElement.SelectByIndex(1);
                Thread.Sleep(500);

                InputContrato.Click();
                Thread.Sleep(1000);
                //SendKeys.SendWait(path);
                Thread.Sleep(300);
                //SendKeys.SendWait(@"{Enter}");
                Thread.Sleep(500);
                _result = true;
            }
            return _result;
        }

        public bool ClicarEmAprovar()
        {
            bool _result = false;
            try
            {
                Thread.Sleep(2000);

                if (BtnAprovar02.Displayed)
                {
                    BtnAprovar02.Click();
                    Thread.Sleep(5000);
                    _result = true;
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool ValidarAprovacao()
        {
            bool _result = true;
            try
            {
                Thread.Sleep(4000);
                IWebElement Validar = ClassDriver.GetInstance().Driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]/h2"));

                if (Validar.Displayed)
                {
                    _result = false;
                }
                else
                {
                    _result = true;
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool ClicarEmReprovar()
        {
            bool _result = false;

            try
            {
                util.WaitForElementVisible(BtnReprovar, 45);
                if (BtnReprovar.Displayed)
                {
                    BtnReprovar.Click();
                    _result = true;
                }
            }
            catch
            {

            }

            return _result;
        }

        public bool ValidarModalReprovar()
        {
            bool _result = false;
            try
            {
                Thread.Sleep(4000);
                IWebElement Validar = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//html/body/div[1]/div/div/div[1]/h2"));

                if (Validar.Displayed)
                {
                    _result = true;
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool SelecionarJustificativa()
        {
            bool _result = false;
            try
            {
                util.WaitForElementVisible(SelectMotivo, 30);
                if (SelectMotivo.Displayed)
                {
                    var selectElement = new SelectElement(SelectMotivo);
                    selectElement.SelectByIndex(3);
                    _result = true;
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool SelecionarJustificativaOutros()
        {
            bool _result = false;
            try
            {
                util.WaitForElementVisible(SelectMotivo, 30);
                if (SelectMotivo.Displayed)
                {
                    var selectElement = new SelectElement(SelectMotivo);
                    selectElement.SelectByIndex(10);

                    Thread.Sleep(500);

                    TextArea.SendKeys("... Teste reprovação fundacred! ...");
                    _result = true;
                    Thread.Sleep(500);
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool Reprovar()
        {
            bool _result = false;

            try
            {
                if (BtnReprovarConfirm.Displayed)
                {
                    BtnReprovarConfirm.Click();
                    _result = true;
                }
            }
            catch
            {

            }

            return _result;
        }

        public bool ValidarReprovacaoComSucesso()
        {
            bool _result = true;
            try
            {
                Thread.Sleep(4000);
                IWebElement Validar = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//html/body/div[1]/div/div/div[1]/h2"));

                if (Validar.Displayed)
                {
                    _result = false;
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool ValidarSolicReproNoDb()
        {
            bool _result = false;

            try
            {
                string[] list = db.ConsultaSolicitacao();

                if (list[0] == "RIES" && list[1] == "C" && list[2] == "R")
                {
                    _result = true;
                    db.AlterarStatus();
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

        public bool ValidarSolicAprovNoDb()
        {
            bool _result = false;

            try
            {
                string[] list = db.ConsultaSolicitacao();

                if (list[0] == "A" && list[1] == "C" && list[2] == "A")
                {
                    _result = true;
                    db.AlterarStatus();
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
