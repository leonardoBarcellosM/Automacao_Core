using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Automacao_Funcional.tests.steps
{
    [Binding]
    public class SelecionarInstituicaoSteps
    {
        private SelecaoDeInstituicaoActions pageAction = new SelecaoDeInstituicaoActions();

        [Given(@"Selecionar instituicao ""(.*)""")]
        public void GivenSelecionarInstituicao(string arg)
        {
            bool result = pageAction.SelecionarInstituicao(arg);

                Assert.That(result, Is.True, "Erro ao selecionar a instituição -> "+ arg);
        }

        [When(@"Selecionar curso ""(.*)""")]
        public void WhenSelecionarCurso(string arg)
        {
            bool result = pageAction.SelecionarCurso(arg);

                Assert.That(result, Is.True, "Erro ao selecionar o curso -> "+arg);
        }

        [When(@"Clicar no botao aceito os termos")]
        public void WhenClicarNoBotaoAceitoOsTermos()
        {
            bool result = pageAction.AceitarTermoDeUso();

                Assert.That(result, Is.True, "Erro ao aceitar o termo!");
        }

        [Then(@"Validar solicitacao enviada")]
        public void ThenValidarSolicitacaoEnviada()
        {
            var result = pageAction.ValidarSolicitacao();

                Assert.That(result, Is.True, "Erro ao enviar solicitação!");
        }

        [When(@"Seleciono a opcao Sou o responsavel pela assinatura")]
        public void WhenSelecionoAOpcaoSouOResponsavelPelaAssinatura()
        {
            var result = pageAction.SelecionarOpResponsavel();

            Assert.That(result, Is.True, "Erro ao selecionar Sou o responsável pela assinatura do contrato de prestação de serviços educacionais com a COLÉGIO ULBRA !");
        }

    }
}
