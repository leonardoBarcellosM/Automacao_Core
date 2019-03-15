using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace Automacao_Funcional.tests.steps
{
    class LoginIesActions : LoginIesMap
    {
        private ClassUtilities util = new ClassUtilities();

        public LoginIesActions()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public bool InformarEmail(string email)
        {
            bool _result = false;

            try
            {
                util.WaitForElementVisible(InputEmail, 30);
                if (InputEmail.Displayed)
                {
                    InputEmail.Click();
                    Thread.Sleep(400);
                    InputEmail.SendKeys(email);

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

        public bool InformarSenha(string senha)
        {
            bool _result = false;

            try
            {
                util.WaitForElementVisible(InputSenha, 15);
                if (InputSenha.Displayed)
                {
                    InputSenha.Click();
                    Thread.Sleep(400);
                    InputSenha.SendKeys(senha);

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

        public bool ClicarEmEntrar()
        {
            bool _result = false;

            try
            {
                util.WaitForElementVisible(BtnEntrar, 15);
                if (BtnEntrar.Displayed)
                {
                    BtnEntrar.Click();
                    

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

        public bool ValidarLogin()
        {
            bool _result = false;
            try
            {
                Thread.Sleep(4500);
                IWebElement Validar = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//div[@class='container-fluid']//div//img"));
                util.WaitForElementVisible(Validar, 45);
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
    }
}
