using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace Automacao_Funcional.tests.steps
{
    class ValidarRendaMinimaActions : ValidarRendaMinimaMap
    {
        private ClassUtilities util = new ClassUtilities();
        private ConsultaDB db = new ConsultaDB();

        public ValidarRendaMinimaActions()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public bool ValidarMensagem(string arg)
        {
            bool _result = false;

            try
            {
                Thread.Sleep(1800);
                var msg = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//form[@name='formCadastroFiador']//div[@class='row'][3]//div[2]//div[1]//div[1] //div[1]//div[1]//div[2 and text()=' Seu fiador precisa comprovar renda bruta mínima de R$3.808,14. ']")).Text;
                var text = msg.Split(' ');
                var valor = text[8].Replace("R$", "");

                if (valor == arg)
                {
                    _result = true;
                    Thread.Sleep(500);
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool InformarRendaInferior()
        {
            bool _result = false;

            var msg = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//form[@name='formCadastroFiador']//div[@class='row'][3]//div[2]//div[1]//div[1] //div[1]//div[1]//div[2]")).Text;
            var text = msg.Split(' ');
            var valor = text[8].Replace("R$", "");
            valor = valor.Replace(".", "");
            valor = valor.Replace(",", "");

            var vlr = float.Parse(valor) - 1;
            valor = vlr.ToString();

            try
            {
                util.WaitForElementVisible(InputRenda, 30);
                if (InputRenda.Displayed)
                {
                    InputRenda.Click();
                    InputRenda.Clear();
                    InputRenda.SendKeys(valor);
                    _result = true;
                    Thread.Sleep(500);
                }
            }
            catch
            {

            }
            return _result;
        }
        
        public bool InformarRendaInferiorPrimeiroFiador()
        {
            bool _result = false;

            try
            {
                util.WaitForElementVisible(InputRenda, 30);
                if (InputRenda.Displayed)
                {

                    InputRenda.Clear();

                    var msg = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//form[@name='formCadastroFiador']//div[@class='row'][3]//div[2]//div[1]//div[1] //div[1]//div[1]//div[2]")).Text;
                    var text = msg.Split(' ');
                    var valor = text[8].Replace("R$", "");
                    valor = valor.Replace(".", "");
                    valor = valor.Replace(",", "");

                    //Valor mínimo dívidido por dois
                    var vlr = float.Parse(valor) / 2;

                    valor = vlr.ToString();

                    InputRenda.SendKeys(valor);
                    _result = true;
                    Thread.Sleep(500);
                }
            }
            catch
            {

            }
            return _result;
        }

        
        public bool InformarMetadeRendaPrimeiroFiador()
        {
            bool _result = false;

            try
            {
                util.WaitForElementVisible(InputRenda, 30);
                if (InputRenda.Displayed)
                {

                    InputRenda.Clear();
                    InputRenda2.Clear();

                    var msg = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//form[@name='formCadastroFiador']//div[@class='row'][3]//div[2]//div[1]//div[1] //div[1]//div[1]//div[2]")).Text;
                    var text = msg.Split(' ');
                    var valor = text[8].Replace("R$", "");
                    valor = valor.Replace(".", "");
                    valor = valor.Replace(",", "");

                    //Valor mínimo dívidido por dois
                    var vlr = float.Parse(valor) / 2;

                    valor = vlr.ToString();

                    InputRenda.SendKeys(valor);
                    _result = true;
                    Thread.Sleep(500);
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool InformarRendaInferiorSegundoFiador()
        {
            bool _result = false;

            var msg = ClassDriver.GetInstance().Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/ng-view/section/form/div[6]/div[3]/div[2]/div/renda-minima-fiador/div/div/div[1]/div[2]")).Text;
            var text = msg.Split(' ');
            var valor = text[12].Replace("R$", "");
            valor = valor.Replace(".", "");
            valor = valor.Replace(",", "");

            //Valor mínimo dívidido por dois
            var vlr = (float.Parse(valor) / 2) - 1;
            //vlr = vlr - 1;

            try
            {
                util.WaitForElementVisible(InputRenda, 30);
                if (InputRenda2.Displayed)
                {
                    InputRenda2.Click();
                    InputRenda2.Clear();
                    InputRenda2.SendKeys(vlr.ToString());
                    _result = true;
                    Thread.Sleep(500);
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool InformarMetadeRendaSegundoFiador()
        {
            bool _result = false;

            var msg = ClassDriver.GetInstance().Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/ng-view/section/form/div[6]/div[3]/div[2]/div/renda-minima-fiador/div/div/div[1]/div[2]")).Text;
            var text = msg.Split(' ');
            var valor = text[12].Replace("R$", "");
            valor = valor.Replace(".", "");
            valor = valor.Replace(",", "");

            //Valor mínimo dívidido por dois
            var vlr = float.Parse(valor) / 2;
            //vlr = vlr - 1;

            try
            {
                util.WaitForElementVisible(InputRenda, 30);
                if (InputRenda2.Displayed)
                {
                    InputRenda2.Click();
                    InputRenda2.Clear();
                    InputRenda2.SendKeys(vlr.ToString());
                    _result = true;
                    Thread.Sleep(500);
                }
            }
            catch
            {

            }
            return _result;
        }
        

        public bool SelecionarInformarDoisFiadores()
        {
            bool _result = false;

            util.WaitForElementVisible(Check2Fiadores, 30);
            try
            {
                if (Check2Fiadores.Displayed)
                {
                    Check2Fiadores.Click();
                    _result = true;
                    Thread.Sleep(500);
                }
            }
            catch
            {

            }
            return _result;
        }
        

        public bool InformarRendaSuperior()
        {
            bool _result = false;

            try
            {
                util.WaitForElementVisible(InputRenda, 30);
                if (InputRenda.Displayed)
                {
                    InputRenda.Click();
                    InputRenda.Clear();
                    Thread.Sleep(300);

                    var msg = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//form[@name='formCadastroFiador']//div[@class='row'][3]//div[2]//div[1]//div[1] //div[1]//div[1]//div[2]")).Text;
                    var text = msg.Split(' ');
                    var valor = text[8].Replace("R$", "");
                    valor = valor.Replace(".", "");
                    valor = valor.Replace(",", "");
                    Thread.Sleep(300);

                    InputRenda.Click();
                    InputRenda.SendKeys(valor);

                    _result = true;
                    Thread.Sleep(500);
                }
            }
            catch
            {

            }
            return _result;
        }


        public bool ValidarMsgRendaInvalida()
        {
            bool _result = false;
            util.WaitForElementVisible(MsgRendaInvalida, 15);

            try
            {
                if (MsgRendaInvalida.Text.Contains("A renda informada não é suficiente."))
                {
                    _result = true;
                    Thread.Sleep(500);
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool ValidarMsgRendaInvalidaDoisFiadores()
        {
            bool _result = false;
            util.WaitForElementVisible(MsgRendaInvalida, 15);

            IWebElement msg = ClassDriver.GetInstance().Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/ng-view/section/form/div[6]/div[3]/div[2]/div/renda-minima-fiador/div/div/div[1]/div[2]"));

            try
            {
                if (MsgRendaInvalida.Text.Contains("A renda informada não é suficiente.") && msg.Text.Contains("A renda informada não é suficiente."))
                {
                    _result = true;
                    Thread.Sleep(500);
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool ValidarBtnEnviarDisabled()
        {
            bool _result = false;
            
            try
            {
                if (BtnEnviar.Enabled)
                {
                    //false
                }
                else
                {
                   _result = true;
                   Thread.Sleep(500);
                }
            }
            catch
            {
                if (btnEnviarDoisFiadores.Enabled)
                {
                    _result = false;
                    Thread.Sleep(500);
                }
                else
                {
                    _result = true;
                }
            }
            return _result;
        }

        public bool ValidarBtnContinuar()
        {
            bool _result = false;

            try
            {
                util.WaitForElementVisible(BtnContinuar, 15);
                if (BtnContinuar.Displayed)
                {
                    _result = true;
                    Thread.Sleep(500);
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool ValidarBtnContinuarDoisFiadores()
        {
            bool _result = false;

            try
            {
                util.WaitForElementVisible(BtnContinuar, 15);
                if (BtnContinuar.Displayed && BtnContinuar2.Displayed)
                {
                    _result = true;
                    Thread.Sleep(500);
                }
            }
            catch
            {

            }
            return _result;
        }
        
        public bool SelecionarCheckboxContinuar()
        {
            bool _result = false;

            try
            {
                util.WaitForElementVisible(BtnContinuar, 15);
                if (BtnContinuar.Displayed)
                {
                    BtnContinuar.Click();
                    _result = true;
                    Thread.Sleep(500);
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool ValidarBtnEnviarEnabled()
        {
            bool _result = false;
           
            try
            {
                util.WaitForElementVisible(BtnEnviar, 2);
                if (BtnEnviar.Enabled)
                {
                    _result = true;
                    Thread.Sleep(500);
                }
                else
                {
                   //false
                }
            }
            catch
            {
                if (btnEnviarDoisFiadores.Enabled)
                {
                    _result = true;
                    Thread.Sleep(500);
                }
                else
                {
                    _result = false;
                }
            }
            return _result;
        }

        public bool ValidarMsgRendaValida()
        {
            bool _result = false;

            try
            {
                util.WaitForElementVisible(MsgConfirma, 15);
                if (MsgConfirma.Text.Contains("Seu fiador possui a renda necessária!"))
                {
                    _result = true;
                    Thread.Sleep(500);
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool ValidarMsgRendaValidaDoisFiadores()
        {
            bool _result = false;
            
            try
            {
                util.WaitForElementVisible(MsgConfirma, 15);
                if (MsgConfirma.Text.Contains("Seu fiador possui a renda necessária!") && MsgConfirma2.Text.Contains("Seu fiador possui a renda necessária!"))
                {
                    _result = true;
                    Thread.Sleep(500);
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool AddCpf(string cpf)
        {
            bool _result = false;

            try
            {
                ClassDriver.GetInstance().Driver.Navigate().Refresh();

                util.WaitForElementVisible(InputCpf, 30);
                if (InputCpf.Displayed)
                {
                    InputRenda.Clear();
                    InputCpf.Click();
                    InputCpf.SendKeys(cpf);
                    _result = true;
                    Thread.Sleep(500);
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool ValidarMensagemFiadorCadastrado(string arg)
        {
            bool _result = false;

            try
            {
                Thread.Sleep(2000);
                var msg = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//form[@name='formCadastroFiador']//div[@class='row'][3]//div[2]//div[1]//div[1] //div[1]//div[1]//div[2]")).Text;
                var text = msg.Split(' ');
                var valor = text[8].Replace("R$", "");

                if (valor == arg)
                {
                    _result = true;
                    Thread.Sleep(500);
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool ConsultarRendaMinima()
        {
            bool _result = false;

            try
            {
                string minimo = db.ConsultaRendaMinima();

                if (minimo != null)
                {
                    var msg = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//form[@name='formCadastroFiador']//div[@class='row'][3]//div[2]//div[1]//div[1] //div[1]//div[1]//div[2]")).Text;
                    var text = msg.Split(' ');
                    var valor = text[8].Replace("R$", "");

                    if (valor == minimo + ".")
                    {
                        _result = true;
                        Thread.Sleep(500);
                    }
                    else
                    {
                        _result = false;
                    }
                }
                else
                {
                    IWebElement msg = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//form[@name='formCadastroFiador']//div[@class='row'][3]//div[2]//div[1]//div[1] //div[1]//div[1]//div[2]"));
                    if (msg.Displayed)
                    {
                        _result = false;
                    }
                    else
                    {
                        _result = true;
                    }
                }
            }
            catch
            {
            }
            return _result;
        }

        public bool RemoverFiador( )
        {
            bool _result = false;

            try
            {
                if (BtnRemoverFiador.Displayed)
                {
                    BtnRemoverFiador.Click();
                    Thread.Sleep(500);

                    BtnRmvSim.Click();
                    _result = true;

                    Thread.Sleep(500);
                }
            }
            catch
            {

            }
            return _result;
        }
    }
}
