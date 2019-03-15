using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Threading;

namespace Automacao_Funcional.tests.steps
{
    class EtapasActions : EtapasMap
    {

        private ClassUtilities util = new ClassUtilities();

        public EtapasActions()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public bool ClicarSolicitacao()
        {
            bool _result = false;
            Thread.Sleep(5000);
            try
            {
                util.WaitForElementVisible(OptionSolicitacao, 60);
                if(OptionSolicitacao.Displayed)
                {
                    OptionSolicitacao.Click();
                    _result = true;
                }
            }
            catch(Exception)
            {
            
            }
            return _result;
        }


        public bool ClicarSolicitarCredito()
        {
            bool _result = false;

            try
            {
                IWebElement BtnQueroSolicitar = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//a[@class='btn btn-laranja btn-line-wrap btn-destaque btn-block']"));
                util.WaitForElementVisible(BtnQueroSolicitar, 15);
                if (BtnQueroSolicitar.Displayed)
                {
                    //Clicar com JavaScript
                    util.ClickJS(BtnQueroSolicitar);
                    _result = true;
                }
                else
                {
                    ClassInfo.GetInstance().LogMessage = "Erro else";
                }
            }
            catch
            {
                ClassInfo.GetInstance().LogMessage = "Erro try";
            }
            return _result;
        }

        public bool ValidarDirecionamentoTermosDeUso()
        {
            bool _result = false;

            try
            {
                Thread.Sleep(1000);
                IWebElement TermoDeAceite = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//h2[text()='Termos de Aceite']"));
                util.WaitForElementVisible(TermoDeAceite, 15);

                if (TermoDeAceite.Displayed)
                {
                    _result = true;
                }
                else
                {
                    ClassInfo.GetInstance().LogMessage = "Erro carregamento";
                }
            }
            catch
            {
                util.ScreenshotPrepare();
                ClassInfo.GetInstance().LogMessage = "Erro direcionamento";
            }
            return _result;
        }


}
}
