using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace Automacao_Funcional.tests.steps
{
    class IniciarFluxoComeceAgoraActions : IniciarFluxoComeceAgoraMap
    {
        private MassaDeDados massa = new MassaDeDados();
        private ClassUtilities util = new ClassUtilities();
        private AprovacaoIesActions cpf = new AprovacaoIesActions();

        public IniciarFluxoComeceAgoraActions()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public void PreencherOsDados( ref string Error,  ref bool result)
        {
            Error = "Erro antes dos inputs";

            string mail = util.GerarNumRandom();
            mail = "teste_" + mail + massa.email;
            string cpf = util.GerarCpf();

            ConsultaDB.Cpf(cpf);

            cpf = util.MascaraCpf(cpf);
            var teste = cpf.ToCharArray();

            try
            {
                //MassaDeDados.BKey = "SOLICITACAO " + cpf;
                // UpdateStatusDB.Cpf(cpf);
                //string dt = utils.ClassUtilities.PegarDataHora();
                //string arquivo = @"C:\Users\leonardo.barcellos\Desktop\Fundacred\reg\" + dt + ".txt";
                //StreamWriter Doc = new StreamWriter(arquivo);
                //string line = String.Empty;
                //Doc.WriteLine(DateTime.Now);
                //Doc.WriteLine("CPF: " + cpf);
                //Doc.WriteLine("\r\n\r\n");
                //Doc.Close();

                util.WaitForElementVisible(BtnIniciar, 60);

                if (BtnIniciar.Displayed) {

                    BtnIniciar.Click();
                    Thread.Sleep(1000);

                    campoNome.Click();
                    Thread.Sleep(500);
                    campoNome.SendKeys(massa.nome + " " + massa.sobrenome);
                    Thread.Sleep(500);

                    InputCpf.Click();
                    Thread.Sleep(1000);
                    InputCpf.SendKeys(cpf);
                    Thread.Sleep(1000);

                    campoTelefone.Click();
                    Thread.Sleep(500);
                    campoTelefone.SendKeys(massa.telefone);
                    Thread.Sleep(500);

                    campoEmail.Click();
                    Thread.Sleep(500);
                    campoEmail.SendKeys(mail);
                    Thread.Sleep(500);
                    
                    campoEmailConf.Click();
                    Thread.Sleep(500);
                    campoEmailConf.SendKeys(mail);
                    Thread.Sleep(500);

                    campoSenha.Click();
                    Thread.Sleep(500);
                    campoSenha.SendKeys(massa.senha);
                    Thread.Sleep(500);

                    senhaConf.Click();
                    Thread.Sleep(500);
                    senhaConf.SendKeys(massa.senha);
                    Thread.Sleep(500);

                    string Classe = ClassDriver.GetInstance().Driver.FindElement(By.Id("txtCpf")).GetAttribute("class");

                    if (Classe == "input-padrao valid")
                    {
                        Error = Classe;
                    }
                    else
                    {
                        Error = "Nao pegou CPF - " + Classe;
                        result = false;
                    }

                    string Classe1 = ClassDriver.GetInstance().Driver.FindElement(By.Id("txtEmail")).GetAttribute("class");

                    if (Classe1 == "input-padrao valid")
                    {
                        Error = Classe1;
                    }
                    else
                    {
                        Error = "Nao pegou email - " + Classe1;
                        result = false;
                    }

                    string Classe2 = ClassDriver.GetInstance().Driver.FindElement(By.Id("txtEmailConfirmar")).GetAttribute("class");

                    if (Classe2 == "input-padrao valid")
                    {
                        Error = Classe2;

                    }
                    else
                    {
                        Error = "Nao pegou email confirmar - " + Classe2;
                        result = false;
                    }

                    string Classe3 = ClassDriver.GetInstance().Driver.FindElement(By.Id("txtSenha")).GetAttribute("class");

                    if (Classe3 == "input-padrao eyePass valid")
                    {
                        Error = Classe3;
                       
                    }
                    else
                    {
                        Error = "Não pegou senha - " + Classe3;
                        result = false;
                    }
                }
                else
                {
                    Error = "Primeiro IF";
                    result = false;
                }
            }
            catch
            {

            }

        }

        public bool ClicarComeceAgora()
        {
            bool _result = false;
            Thread.Sleep(2000);

            try
            {
                if (btnCadastro.Displayed)
                {
                    btnCadastro.Submit();
                    _result = true;
                    Thread.Sleep(3000);
                }
                else
                {
                    util.ScreenshotPrepare();
                }
            }
            catch
            {

            }
            return _result;
        }


        public bool FluxoIniciadoComSucesso()
        {
            bool _result = false;
            Thread.Sleep(5000);
            IWebElement BemVindo = ClassDriver.GetInstance().Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/ng-include/div/div/h3"));
            try
            {
                if (BemVindo.Text.Contains("LEONARDO"))
                {
                    _result = true;
                    Thread.Sleep(1500);
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

        //public bool ValidarCadastroDB()
        //{
        //    bool _result = false;
        //    try
        //    {
        //        string valor = db.NovoCadastro();

        //        if (valor == "1")
        //        {
        //            _result = true;
        //        }
              
        //    }
        //    catch
        //    {

        //    }
        //    return _result;
        //}
    }
}
