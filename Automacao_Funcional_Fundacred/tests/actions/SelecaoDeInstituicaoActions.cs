using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace Automacao_Funcional.tests.steps
{
    class SelecaoDeInstituicaoActions : SelecaoDeInstituicaoMap
    {

        private ClassUtilities util = new ClassUtilities();
        private ConsultaDB db = new ConsultaDB();

        public SelecaoDeInstituicaoActions()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public bool SelecionarInstituicao(string arg)
        {
            bool _result = false;
            try
            {
                IWebElement Lista = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//div[@id='listaIES_chosen']//a"));
                util.WaitForElementVisible(Lista, 5);

                if (Lista.Displayed)
                {
                    Lista.Click();
                    Thread.Sleep(1000);
                    _result = SelectInstituicao(arg);

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


        public bool SelectInstituicao(string arg)
        {
            bool _result = false;
            try
            {
                IWebElement opt = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//div[@class='chosen-drop']//ul[@class='chosen-results'][1]//li[text()='" + arg + "']"));
                util.WaitForElementVisible(opt, 5);
                if (opt.Displayed)
                {
                    opt.Click();
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

        public bool SelecionarCurso(string arg)
        {
            bool _result = false;
            try
            {
                IWebElement Lista = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//div[@id='listaCursosIES_chosen']//a"));


                util.WaitForElementVisible(Lista, 10);
                if (Lista.Displayed)
                {
                    Lista.Click();
                    Thread.Sleep(500);
                    _result = SelectCurso(arg);
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

        public bool SelectCurso(string arg)
        {
            bool _result = false;    
            
            try
            {
                IWebElement opt2 = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//a[@class='chosen-single chosen-default']/../div//div/../ul//li[text()='"+arg+"']"));
               
                util.WaitForElementVisible(opt2, 10);
                if (opt2.Displayed)
                {
                    opt2.Click();
                    _result = true;
                }
                else
                {
                    ClassInfo.GetInstance().LogMessage = "Erro if";
                }
            }
            catch
            {
                ClassInfo.GetInstance().LogMessage = "Erro try";
            }
            return _result;
        }



        public bool AceitarTermoDeUso()
        {
            bool _result = false;

            try
            {
                util.WaitForElementVisible(CheckAceite, 10);
                if (CheckAceite.Displayed)
                {
                    util.ScrollPage(2);
                    if (CheckAceite.Selected == false)
                    {
                        CheckAceite.Click();
                        Thread.Sleep(750);
                        
                    }
                    if (CheckAceite.Selected == true)
                    {
                        BtnSubmit.Click();
                        _result = true;
                    }

                    
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool ValidarSolicitacao()
        {
            bool _result = false;

            Thread.Sleep(3000);
            try
            {
                IWebElement Validar = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//section[@class='ng-scope']//h2[text()='Dados do Estudante']"));
                util.WaitForElementVisible(Validar, 15);
                if (Validar.Displayed)
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

        public bool ValidarSolicitacaoNoDb()
        {
            bool _result = false;

            try
            {
                string[] list = db.ConsultaSolicitacao();

                if (list[0] == "CI" && list[1] == "PDBE" && list[2] == "PDBE")
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

        public bool SelecionarOpResponsavel()
        {
            bool _result = false;
            util.WaitForElementVisible(OpResponsavel, 30);
            util.ScrollElementoPage(OpResponsavel);
            try
            {
                if (OpResponsavel.Displayed)
                {
                    OpResponsavel.Click();
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
