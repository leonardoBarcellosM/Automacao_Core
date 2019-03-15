using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace Automacao_Funcional.tests.steps
{
    class PreencherDadosDoCursoActions : PreencherDadosDoCursoMap
    {
        private ClassUtilities util = new ClassUtilities();
        private MassaDeDados massa = new MassaDeDados();

        public PreencherDadosDoCursoActions()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public bool PreencherMatricula()
        {
            bool _result = false;

            try
            {
                util.WaitForElementVisible(InputMatricula, 15);
                if(InputMatricula.Displayed)
                {
                    InputMatricula.Click();
                    Thread.Sleep(300);
                    InputMatricula.SendKeys(massa.percentual);
                    Thread.Sleep(300);
                    //InputPerc.Click();
                    //Thread.Sleep(300);
                    //InputPerc.SendKeys(massa.percentual);
                    //Thread.Sleep(300);
                    _result = true;
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool PreencherAnoSemestre()
        {
            bool _result = false;

            try
            {
                util.WaitForElementVisible(SelectAno, 15);
                if (SelectAno.Displayed)
                {
                    SelectAno.Click();
                    Thread.Sleep(300);
                    var ano = new SelectElement(SelectAno);
                    ano.SelectByIndex(2);
                    Thread.Sleep(300);

                    SelectSemestre.Click();
                    Thread.Sleep(300);
                    var semestre = new SelectElement(SelectSemestre);
                    semestre.SelectByIndex(1);
                    Thread.Sleep(300);

                    _result = true;
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool AcessarDocumentos()
        {
            bool _result = false;

            try
            {
                util.WaitForElementVisible(Btndocumentos, 15);
                if (Btndocumentos.Displayed)
                {
                    Btndocumentos.Click();
                    Thread.Sleep(1000);
                    _result = true;
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool ValidarDirecionamentoDocumentos()
        {
            bool _result = false;

            try
            {
                IWebElement Validar = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//h2[text()='Documentos']"));
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
