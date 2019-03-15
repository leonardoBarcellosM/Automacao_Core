using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using Automacao_Funcional.tests.steps;

namespace Automacao_Funcional.tests.actions
{
    class DependenteCadastroActions : DependenteCadastroMap
    {
        private ClassUtilities util = new ClassUtilities();
        private MassaDeDados massa = new MassaDeDados();
        private ConsultaDB db = new ConsultaDB();

        public DependenteCadastroActions()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }


        public bool PreencherDadosDependente()
        {
            bool _result = false;

            MassaDeDados.Dependentes.NomeDep = "Leonardo Dependente";
            MassaDeDados.Dependentes.CpfDep = util.GerarCpf();
            MassaDeDados.Dependentes.RgDep = util.GerarRg();
            MassaDeDados.Dependentes.DtDep = "27/10/2006";
            MassaDeDados.Dependentes.MatDep = util.GerarNumRandom();

            //ConsultaDB.Cpf(MassaDeDados.Dependentes.CpfDep);

            util.WaitForElementVisible(InputNomeDep, 30);
            try
            {
                InputNomeDep.SendKeys(MassaDeDados.Dependentes.NomeDep);
                Thread.Sleep(300);

                InputCpfDep.SendKeys(MassaDeDados.Dependentes.CpfDep);
                Thread.Sleep(300);

                InputRgDep.SendKeys(MassaDeDados.Dependentes.RgDep);
                Thread.Sleep(300);

                InputDtDep.SendKeys(MassaDeDados.Dependentes.DtDep);
                Thread.Sleep(300);

                NumMatricula02.SendKeys(MassaDeDados.Dependentes.MatDep);
                Thread.Sleep(300);

                _result = true;
            }
            catch
            {

            }

            return _result;
        }

        public bool ValidarCadastroDeDependenteNoBanco()
        {
            bool _result = false;

            string[] list = db.ConsultarTabelaDependentes();

            try
            {
                if (
                    list[0].Equals(MassaDeDados.Dependentes.CpfDep)
                    &&
                    list[1].Equals(MassaDeDados.Dependentes.RgDep)
                    &&
                    list[2].Equals(MassaDeDados.Dependentes.NomeDep)
                    &&
                    list[3].Contains("10/27/2006")
                    &&
                    list[4].Equals(MassaDeDados.Dependentes.MatDep)
                    )
                {
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
