using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace Automacao_Funcional.tests.steps
{
    class ValidarTelaPesquisaAction : ValidarTelaPesquisaMap
    {
        private ClassUtilities util = new ClassUtilities();
        //private ConsultaDB db = new ConsultaDB();

        public ValidarTelaPesquisaAction()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public bool ValidarTelaDePesquisa(string arg)
        {
            bool _result = false;
            Thread.Sleep(1500);
            IWebElement Validar = ClassDriver.GetInstance().Driver.FindElement(By.XPath("/html/body/div[2]/h1[contains(text(), '"+arg+"')]"));

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


        //public bool ValidarFiltroSelecionado(string arg)
        //{
        //    bool _result = false;
        //    Thread.Sleep(500);
        //    string filtro = CampoFiltro.Text;
        //    try
        //    {
        //        if (filtro == arg)
        //        {
        //            _result = true;
        //        }
        //    }
        //    catch
        //    {

        //    }

        //    return _result;
        //}


        public void ValidarTotalDeSolicitacoes(ref bool result, ref string conteudo, int arg)
        {
            bool _result = false;
            Thread.Sleep(2000);
            string valor = TotalTelaPesquisa.Text;

            string[] dadosList =
            {
                DadosDB.Funil_SolicitacoesIniciadas,
                DadosDB.Funil_ReprovadosFundacred,
                DadosDB.Funil_PendenteAnaliseFundacred,
                DadosDB.Funil_PendenteAnaliseIes,
                DadosDB.Funil_ReprovadosIes,
                DadosDB.Funil_Aprovados
                };

            try
            {
                if (valor == dadosList[arg])
                {
                    _result = true;
                }
            }
            catch
            {

            }
            result = _result;
            conteudo = "Tela de Pesquisa de solicitações: " + valor + " | Funil: " + dadosList[arg];
            
            //return (_result, "Portal IES: " + valor + " | DB: " + dadosList[arg]);
        }

        public void ValidarTotalDeSolicitacoesPendentesIes(ref bool result, ref string conteudo, int arg)
        {
            bool _result = false;
            Thread.Sleep(1000);
            string valor = ClassDriver.GetInstance().Driver.FindElement(By.XPath("/html/body/div[2]/p/strong[2]")).Text;

            try
            {
                if (valor == DadosDB.Funil_PendenteAnaliseIes)
                {
                    _result = true;
                }
            }
            catch
            {

            }

            result = _result;
            conteudo = "Portal IES: " + valor + " | DB: " + DadosDB.Funil_PendenteAnaliseIes;

            //return new KeyValuePair<bool, string>(_result, "Portal IES: " + valor + " | DB: " + DadosDB.Funil_PendenteAnaliseIes);
        }

        public bool ValidarEtapasFiltro()
        {
            bool _result = true;
            Thread.Sleep(1000);

            string[] values =
                {
                "Iniciada",
                "Pendente Análise Fundacred",
                "Pendente Análise IES",
                "Aprovada",
                "Reprovada Fundacred",
                "Reprovada IES",
                "Cancelada",
                "Todos"
                };

            for (int i = 0; i < values.Length; i++) {
                IWebElement Validar = ClassDriver.GetInstance().Driver.FindElement(By.XPath("/html/body/div[2]/form/div/div[2]/div/div[4]/div/select/option[contains(text(), '" + values[i] + "')]"));

                try
                {
                    if (Validar.Displayed)
                    {
                       
                    }
                    else
                    {
                        _result = false;
                    }
                }
                catch
                {

                }
            }
            return _result;
        }

        public bool ValidarInformacoesApresentadas()
        {
            bool _result = false;
            Thread.Sleep(1000);

            try
            {

                if (NomeEstudante.Displayed || DtSolicitacao.Displayed
                    || Curso.Displayed || Convenio.Displayed || Campus.Displayed
                    || Etapa.Displayed || PercSolicitado.Displayed)
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
