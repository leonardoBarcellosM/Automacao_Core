using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Automacao_Funcional.tests.steps
{
    [Binding]
    public class EtapasSteps
    {
        private EtapasActions pageAction = new EtapasActions();
        private SelecaoDeInstituicaoActions InstituicaoActions = new SelecaoDeInstituicaoActions();
        private DadosDoEstudanteActions EstudanteActions = new DadosDoEstudanteActions();
        private DadosDoFiadorActions FiadorActions = new DadosDoFiadorActions();
        private SelecionarDocumentosActions ConcluirSolicitacao = new SelecionarDocumentosActions();
        private AprovacaoIesActions ReprovarAprovar = new AprovacaoIesActions();
        private ValidarRendaMinimaActions RendaMinima = new ValidarRendaMinimaActions();

        [Given(@"Acessar a opcao solicitacao")]
        public void GivenAcessarAOpcaoSolicitacao()
        {
           bool result = pageAction.ClicarSolicitacao();

                Assert.That(result, Is.True, "Erro ao acessar a opção de solicitação!");
        }

        [When(@"Clicar em quero solicitar o credito")]
        public void WhenClicarEmQueroSolicitarOCredito()
        {
           bool result = pageAction.ClicarSolicitarCredito();

                Assert.That(result, Is.True, "Erro ao clicar em solicitar crédito!");
        }

        [Then(@"Validar o direcionamento com sucesso")]
        public void ThenValidarODirecionamentoComSucesso()
        {
            var result = pageAction.ValidarDirecionamentoTermosDeUso();

                Assert.That(result, Is.True, "Erro no direcionamento solicitado!");
        }

        [Then(@"Validar status de solicitacao no db ""(.*)""")]
        public void ThenValidarSolicitacaoNoDb(string var)
        {
            bool result = false;

            switch (var)
            {
                case "Solicitacao":
                    result = InstituicaoActions.ValidarSolicitacaoNoDb();
                    break;
                case "Estudante":
                    result = EstudanteActions.ValidarEstudanteNoDb();
                    break;
                case "Fiador":
                    result = EstudanteActions.ValidarFiadorNoDb();
                    break;
                //case "PosFiador":
                //    result = FiadorActions.ValidarPosFiadorNoDb();
                //    break;
                //case "Solicitação concluída":
                //    result = ConcluirSolicitacao.ValidarSolicConcluidaNoDb();
                //    break;
                case "Solicitação aprovada":
                    result = ReprovarAprovar.ValidarSolicAprovNoDb();
                    break;
                case "Solicitação reprovada":
                    result = ReprovarAprovar.ValidarSolicReproNoDb();
                    break;
                    //case "PDC":
                    //    result = ConcluirSolicitacao.ValidarSolicitacao("PDC", "C", "PADC");
                    //    break;
                    //case "PAF":
                    //    result = ConcluirSolicitacao.ValidarSolicitacao("PAF", "C", "PAF");
                    //    break;
            }

            Assert.That(result, Is.True, "Divergência entre a etapa/ação e os status do banco -> " + var +"");
        }

        [Then(@"Consultar renda ""(.*)"" no db")]
        public void ThenConsultarRendaMinima(string var)
        {
            bool result = false;

            switch (var)
            {
                case "minima":
                    result = RendaMinima.ConsultarRendaMinima();
                    break;
            }

            Assert.That(result, Is.True, "Erro ao consultar a renda mínima exigida de acordo com os dados no banco de dados");
        }
    }
}
