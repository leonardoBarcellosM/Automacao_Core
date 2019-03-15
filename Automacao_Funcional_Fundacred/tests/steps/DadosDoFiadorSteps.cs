using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Automacao_Funcional.tests.steps
{
    [Binding]
    public class DadosDoFiadorSteps
    {
        private const string V = ",";
        private DadosDoFiadorActions pageAction = new DadosDoFiadorActions();

        [Given(@"Inserir nome e cpf ""(.*)""")]
        public void GivenInserirNomeECpf(string arg)
        {
            bool result = pageAction.InserirNomeECpf(arg);

                Assert.That(result, Is.True, "Erro ao inserir os dados - Nome e CPF!");
        }

        [When(@"Inserir data de nasc e renda ""(.*)""")]
        public void WhenInserirDataDeNascERenda(string arg)
        {
            var items = arg.Split('-');
            bool result = pageAction.InserirDtaERenda(items);

                Assert.That(result, Is.True, "Erro ao inserir os dados - Data de nascimento e renda!");
        }

        [When(@"Clicar no botao enviar etapa 3")]
        public void WhenClicarNoBotaoEnviar()
        {
            bool result = pageAction.ClicarEnviarEtapa3();

                Assert.That(result, Is.True, "Erro ao enviar!");
        }

        [Then(@"Validar direcionamento para etapa 4")]
        public void ThenValidarDirecionamentoParaEtapa4()
        {
            var result = pageAction.ValidarDirecionamentoEtapa4();

                Assert.That(result, Is.True, "Erro no direcionamento para a etapa 4");
        }
    }
}
