using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Automacao_Funcional.tests.steps
{
    class LoginActions :  LoginMap
    {
        private ClassUtilities util = new ClassUtilities();

        public LoginActions()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public bool AcessarTelaLogin()
        {
            bool _result = false;
            util.WaitForElementVisible(BtnEntrar, 30);
            try
            {
                if (BtnEntrar.Displayed)
                {
                    BtnEntrar.Click();
                    _result = true;
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool PreencherCampos(Table table)
        {
            bool _result = false;
            var credentials = table.CreateInstance<ClassUtilities.Credentials>();

            string Class = Pass.GetAttribute("class");

            try
            {
                util.WaitForElementVisible(InputCpf, 45);
                if (InputCpf.Displayed)
                {
                    InputCpf.Clear();
                    Thread.Sleep(300);
                    InputCpf.SendKeys(credentials.Cpf);
                    Thread.Sleep(300);

                    if (Class == "input-padrao valid")
                    {
                        Pass.Clear();

                        Pass.SendKeys(credentials.Senha);
                        Thread.Sleep(300);

                        _result = true;
                    }
                    else
                    {
                        Pass.SendKeys(credentials.Senha);
                        Thread.Sleep(300);

                        _result = true;
                    }
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool Submit()
        {
            bool _result = false;

            try
            {
                util.WaitForElementVisible(BtnSubmit, 45);
                if (BtnSubmit.Displayed)
                {
                    BtnSubmit.Click();
                    //Thread.Sleep(3000);

                    _result = true;
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool ValidarLogin()
        {
            bool _result = false;
            Thread.Sleep(3000);
            try
            {
                IWebElement BemVindo = ClassDriver.GetInstance().Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/ng-include/div/div/h3"));
                util.WaitForElementVisible(BemVindo, 45);
                if (BemVindo.Displayed)
                {
                    _result = true;
                    Thread.Sleep(3000);
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool PreencherUsuario(string user)
        {
            bool _result = false;

            try
            {
                util.WaitForElementVisible(InputCpf, 45);
                if (InputCpf.Displayed)
                {
                    InputCpf.Click();
                    Thread.Sleep(300);
                    InputCpf.SendKeys(user);
                    _result = true;
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool VerificarMsgLoginInvalido()
        {
            bool _result = false;

            Thread.Sleep(1000);
            IWebElement MsgErro = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//*[@id='frmLogin']/fieldset/div/span"));
            util.WaitForElementVisible(MsgErro, 45);

            try
            {
                if (MsgErro.Displayed)
                {
                    _result = true;
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool VerificarMsgCpfInvalido()
        {
            bool _result = false;

            Thread.Sleep(1000);

            IWebElement MsgErro = ClassDriver.GetInstance().Driver.FindElement(By.Id("txtCpfLogin-error"));
            util.WaitForElementVisible(MsgErro, 45);

            try
            {
                if (MsgErro.Displayed)
                {
                    _result = true;
                }
            }
            catch
            {

            }
            return _result;
        }
        


            public bool PreencherUserPassword()
            {
                bool _result = false;
                util.WaitForElementVisible(CampoUsername, 45);

                try
                {
                    if (CampoUsername.Displayed)
                    {
                        CampoUsername.Clear();
                        CampoUsername.SendKeys("demo");
                        CampoPassword.Clear();
                        CampoPassword.SendKeys("demo");

                        _result = true;
                    }
                }
                catch
                {
                }
                return _result;
            }

            public bool ClicarSignIn()
            {
                bool _result = false;

                try
                {
                    if (BtnSignIn.Displayed)
                    {
                        BtnSignIn.Click();

                        _result = true;
                    }
                }
                catch
                {
                }
                return _result;
            }

            public bool ValidarLoginCamunda()
            {
                bool _result = false;
                Thread.Sleep(2000);

                IWebElement Validar = ClassDriver.GetInstance().Driver.FindElement(By.XPath("/html/body/div[1]/nav/ul/li[2]/a"));

                try
                {
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

            public bool ValidarAcessoIes()
            {
                bool _result = false;
                try
                {
                    Thread.Sleep(10000);
                    IWebElement formLogin = ClassDriver.GetInstance().Driver.FindElement(By.Id("formLogin"));
                    util.WaitForElementVisible(formLogin, 45);
                    if (formLogin.Displayed)
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


        public bool TelaLogin()
        {
            bool _result = false;
            try
            {
               
                util.WaitForElementVisible(BtnSair, 45);
                if (BtnSair.Displayed)
                {
                    BtnSair.Click();

                    Thread.Sleep(1500);
                    AcessarTelaLogin();

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
