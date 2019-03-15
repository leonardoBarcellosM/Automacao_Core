using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace Automacao_Funcional.tests.steps
{
    class NavegarPortalIesActions : NavegarPortalIesMap
    {
        private ClassUtilities util = new ClassUtilities();

        public NavegarPortalIesActions()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public bool ClicarFunil(int arg)
        {
            bool _result = false;
            Thread.Sleep(2500);

            IWebElement[] Element =
                   {
                    OptSolicitacoesIniciadas,
                    OptReprovadosFundacred,
                    OptPendenteAnalisefundacred,
                    OptPendenteAnaliseIes,
                    OptReprovadosIEs,
                    OptAprovados
                    };

            switch (arg)
             {
                case 0:
                    DadosDB.Funil_SolicitacoesIniciadas = Element[arg].Text;
                    break;
                case 1:
                    DadosDB.Funil_ReprovadosFundacred = Element[arg].Text;
                    break;
                case 2:
                    DadosDB.Funil_PendenteAnaliseFundacred = Element[arg].Text;
                    break;
                case 3:
                    DadosDB.Funil_PendenteAnaliseIes = Element[arg].Text;
                    break;
                case 4:
                    DadosDB.Funil_ReprovadosIes = Element[arg].Text;
                    break;
                case 5:
                    DadosDB.Funil_Aprovados = Element[arg].Text;
                    break;
            };

            util.WaitForElementVisible(Element[arg], 30);

            try
            {
                if (Element[arg].Displayed)
                {
                    Element[arg].Click();
                    Thread.Sleep(500);
                    _result = true;
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool ClicarReprovadosFundacred()
        {
            bool _result = false;

            try
            {
                util.WaitForElementVisible(OptReprovadosFundacred, 30);
                DadosDB.Funil_ReprovadosFundacred = OptReprovadosFundacred.Text;

                if (OptReprovadosFundacred.Displayed)
                {
                    OptReprovadosFundacred.Click();
                    Thread.Sleep(500);
                    _result = true;
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool ClicarDashboard()
        {
            bool _result = false;
            Thread.Sleep(1000);
            try
            {
                util.WaitForElementVisible(OptDashboard, 30);

                if (OptDashboard.Displayed)
                {
                    OptDashboard.Click();
                    Thread.Sleep(500);
                    _result = true;
                }
            }
            catch
            {

            }
            return _result;
        }
    }
}
