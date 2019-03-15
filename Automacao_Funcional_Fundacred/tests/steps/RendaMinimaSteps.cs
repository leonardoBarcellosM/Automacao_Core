using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Automacao_Funcional.tests.steps
{
    [Binding]
    public class RendaMinimaSteps
    {
        ValidarRendaMinimaActions PageActions = new ValidarRendaMinimaActions();

        [Given(@"Informo valor inferior ao minimo")]
        public void GivenInformoValorInferiorAoMinimo()
        {
            bool result = PageActions.InformarRendaInferior();

            Assert.That(result, Is.True, "Erro ao inserir valor no campo Renda mensal bruta");
        }

        [Then(@"Apresenta mensagem informando que o valor é insuficiente")]
        public void ThenApresentaMensagemInformandoQueOValorEInsuficiente()
        {
            bool result = PageActions.ValidarMsgRendaInvalida();

            Assert.That(result, Is.True, "Erro ao apresentar a mensagem informando que o valor é insuficiente");
        }

        [Then(@"O botao Enviar ficara desabilitado")]
        public void ThenOBotaoEnviarFicaraDesabilitado()
        {
            bool result = PageActions.ValidarBtnEnviarDisabled();

            Assert.That(result, Is.True, "Erro ao apresentar o botao enviar desabilitado");
        }

        [Then(@"A opcao quero continuar mesmo assim e apresentada")]
        public void ThenAOpcaoQueroContinuarMesmoAssimEApresentada()
        {
            bool result = PageActions.ValidarBtnContinuar();

            Assert.That(result, Is.True, "Erro ao apresentar o botão quero continuar mesmo assim");
        }

        [Given(@"Informo valor superior ao minimo")]
        public void GivenInformoValorSuperiorAoMinimo()
        {
            bool result = PageActions.InformarRendaSuperior();

            Assert.That(result, Is.True, "Erro ao inserir o valor no campo Renda Mensal Bruta");
        }

        [Then(@"Apresenta mensagem informando que o valor é suficiente")]
        public void ThenApresentaMensagemInformandoQueOValorESuficiente()
        {
            bool result = PageActions.ValidarMsgRendaValida();

            Assert.That(result, Is.True, "Erro ao apresentar a mensagem informando que o valor é suficiente");
        }

        [Then(@"Apresenta mensagem informando que o valor é suficiente para dois fiadores")]
        public void ThenApresentaMensagemInformandoQueOValorESuficienteParaDoisFiadores()
        {
            bool result = PageActions.ValidarMsgRendaValidaDoisFiadores();

            Assert.That(result, Is.True, "Erro ao apresentar a mensagem informando que o valor é suficiente para dois fiadores");
        }

        [Then(@"O botao Enviar ficara habilitado")]
        public void ThenOBotaoEnviarFicaraHabilitado()
        {
            bool result = PageActions.ValidarBtnEnviarEnabled();

            Assert.That(result, Is.True, "Erro ao apresentar o botao Enviar habilitado");
        }

        [Given(@"Informo a metade do valor com o primeiro fiador")]
        public void GivenInformoAMetadeDoValorComOPrimeiroFiador()
        {
            bool result = PageActions.InformarRendaInferiorPrimeiroFiador();

            Assert.That(result, Is.True, "Erro ao informar a renda mensal bruta do primeiro fiador");
        }

        [When(@"Seleciono a opcao para informar um segundo fiador")]
        public void WhenSelecionoAOpcaoParaInformarUmSegundoFiador()
        {
            bool result = PageActions.SelecionarInformarDoisFiadores();

            Assert.That(result, Is.True, "Erro ao selecionar a opção para informar um segundo fiador");
        }

        [When(@"Informo valor inferior ao minimo com o segundo fiador")]
        public void WhenInformoValorInferiorAoMinimoComOSegundoFiador()
        {
            bool result = PageActions.InformarRendaInferiorSegundoFiador();
            
            Assert.That(result, Is.True, "Erro ao informar a renda mensal bruta do segundo fiador");
        }

        [Given(@"Informo a primeira metade do valor com o primeiro fiador")]
        public void GivenInformoAPrimeiraMetadeDoValorComOPrimeiroFiador()
        {
            bool result = PageActions.InformarMetadeRendaPrimeiroFiador();

            Assert.That(result, Is.True, "Erro ao informar a renda mensal bruta do segundo fiador");
        }

        [When(@"Informo a segunda metade do valor com o segundo fiador")]
        public void WhenInformoASegundaMetadeDoValorComOSegundoFiador()
        {
            bool result = PageActions.InformarMetadeRendaSegundoFiador();

            Assert.That(result, Is.True, "Erro ao informar a renda mensal bruta do segundo fiador");
        }

        [Then(@"Apresenta mensagem informando que o valor é insuficiente para os dois fiadores")]
        public void ThenApresentaMensagemInformandoQueOValorEInsuficienteParaOsDoisFiadores()
        {
            bool result = PageActions.ValidarMsgRendaInvalidaDoisFiadores();

            Assert.That(result, Is.True, "Erro ao apresentar a mensagem informando que o valor e insuficiente para dois fiadores");
        }

        [Then(@"A opcao quero continuar mesmo assim e apresentada para os dois fiadores")]
        public void ThenAOpcaoQueroContinuarMesmoAssimEApresentadaParaOsDoisFiadores()
        {
            bool result = PageActions.ValidarBtnContinuarDoisFiadores();

            Assert.That(result, Is.True, "Erro ao apresentar o botao quero continuar mesmo assim para dois fiadores");
        }

        [Given(@"Removo o segundo fiador")]
        public void GivenRemovoOSegundoFiador()
        {
            bool result = PageActions.RemoverFiador();

            Assert.That(result, Is.True, "Erro ao remover o segundo fiador");
        }

        [When(@"Informo valor insuficiente para a renda mensal")]
        public void WhenInformoValorInsuficienteParaARendaMensal()
        {
            bool result = PageActions.InformarRendaInferiorPrimeiroFiador();

            Assert.That(result, Is.True, "Erro ao informar a renda mensal bruta do segundo fiador");
        }

        [When(@"Clico no checkbox para continuar mesmo assim")]
        public void WhenClicoNoCheckboxParaContinuarMesmoAssim()
        {
            bool result = PageActions.SelecionarCheckboxContinuar();

            Assert.That(result, Is.True, "Erro ao selecionar a opcao quero continuar mesmo assim");
        }
      
    }
}
