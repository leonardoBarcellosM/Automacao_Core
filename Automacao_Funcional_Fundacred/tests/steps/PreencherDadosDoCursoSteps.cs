using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Automacao_Funcional.tests.steps
{
    [Binding]
    public class PreencherDadosDoCursoSteps
    {
        private PreencherDadosDoCursoActions pageAction = new PreencherDadosDoCursoActions();

        [Given(@"Preencho matricula e percentual")]
        public void GivenPreenchoMatriculaEPercentual()
        {
            bool result = pageAction.PreencherMatricula();

                Assert.That(result, Is.True, "Erro ao preencher os dados Matrícula e Percentual!");
        }

        [When(@"Preencho ano e semestre")]
        public void WhenPreenchoAnoESemestre()
        {
            bool result = pageAction.PreencherAnoSemestre();

                Assert.That(result, Is.True, "Erro ao preencher os dados Ano e Semestre!");
        }

        [When(@"Clico em documentos")]
        public void WhenClicoEmDocumentos()
        {
            bool result = pageAction.AcessarDocumentos();

                Assert.That(result, Is.True, "Erro ao clicar em documentos!");
        }


        [Then(@"Validar direcionamento documentos")]
        public void ThenValidarDirecionamentoDocumentos()
        {
            var result = pageAction.ValidarDirecionamentoDocumentos();

                Assert.That(result, Is.True, "Erro durante o direcionamento para a tela de documentos!");
        }
    }

}
