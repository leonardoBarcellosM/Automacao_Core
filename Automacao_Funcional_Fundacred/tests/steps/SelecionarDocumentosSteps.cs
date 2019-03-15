using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Automacao_Funcional.tests.steps
{
    [Binding]
    public class SelecionarDocumentosSteps
    {
        private SelecionarDocumentosActions pageAction = new SelecionarDocumentosActions();


        [Given(@"Seleciono documentos do estudante")]
        public void GivenSelecionoDocumentosDoEstudante()
        {
            pageAction.DocsEstudante();
        }

        [When(@"Seleciono documentos do grupo familiar")]
        public void WhenSelecionoDocumentosDoGrupoFamiliar()
        {
            pageAction.DosGrupoFamiliar();
        }

        [When(@"Seleciono documentos de renda familiar")]
        public void WhenSelecionoDocumentosDeRendaFamiliar()
        {
            pageAction.DocsRendaFamiliar();
        }

        [When(@"Seleciono documentos do fiador")]
        public void WhenSelecionoDocumentosDoFiador()
        {
            pageAction.DocsFiador();
        }

        [When(@"Seleciono documentos de renda do fiador")]
        public void WhenSelecionoDocumentosDeRendaDoFiador()
        {
            pageAction.DocsImpostoRenda();
        }

        [When(@"Clico em concluir")]
        public void WhenClicoEmConcluir()
        {
            pageAction.Concluir();
        }

        [Then(@"Validar a conclusao da etapa 4")]
        public void ThenValidarConclusaoDaEtapa4()
        {
            var result = pageAction.ValidarConclusao();

                Assert.That(result, Is.True, "Erro ao concluir a solicitação");
        }

        [Then(@"Validar botao desabilitado")]
        public void ThenValidarBotaoDesabilitado()
        {
            var result = pageAction.ValidarBotaoConcluir();

                Assert.That(result, Is.True, "Erro");
        }
    }
}
