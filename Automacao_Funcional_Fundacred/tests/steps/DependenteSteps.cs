using Automacao_Funcional.tests.actions;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Automacao_Funcional.tests.steps
{
    [Binding]
    public class DependenteSteps
    {
        DependenteCadastroActions pageAction = new DependenteCadastroActions();
        DadosDoEstudanteActions pageAction2 = new DadosDoEstudanteActions();
        ConsultaDB Db = new ConsultaDB();

        [Given(@"Preencho os dados do dependente")]
        public void GivenPreenchoOsDadosDoDependente()
        {
            bool result = pageAction.PreencherDadosDependente();

            Assert.That(result, Is.True, "Erro ao inserir os dados pessoais do dependente!");
        }

        [When(@"Clico em enviar")]
        public void WhenClicoEmEnviar()
        {
            bool result = pageAction2.ClicarEnviar();

            Assert.That(result, Is.True, "Erro ao enviar!");
        }

        [Then(@"Os dados do dependente devem ser salvos com sucesso na tabela dependentes")]
        public void ThenOsDadosDevemSerSalvosComSucessoNaTabelaDependentes()
        {
            bool result = pageAction.ValidarCadastroDeDependenteNoBanco();

            Assert.That(result, Is.True, "Erro ao cadastrar os dados do dependente!");
        }

        [Then(@"Solicitacao iniciada com sucesso para o dependente")]
        public void ThenSolicitacaoIniciadaComSucessoParaODependente()
        {
            bool result = pageAction.ValidarCadastroDeDependenteNoBanco();

            Assert.That(result, Is.True, "Erro ao cadastrar os dados do dependente!");
        }

        [Then(@"Solicitacao iniciada com sucesso na tabela solicitacoes_web para o dependente")]
        public void ThenSocliticacaoIniciadaComSucessoNaTabelaSolicitacoes_WebParaODependente()
        {
            bool result = Db.ConsultarSolicitacaoDependente();

            Assert.That(result, Is.True, "Erro ao iniciar a solicitação na tabela de solicitacoes_web para o dependente!");
        }

        [Then(@"O requerente deve ser salvo na tabela pessoas_web")]
        public void ThenORequerenteDeveSerSalvoNaTabelaPessoas_Web()
        {
            bool result = Db.ConsultarCadastroRequerente();

            Assert.That(result, Is.True, "Erro ao salvar o requerente na tabela PESSOAS_WEB");
        }

    }
}
