Feature: H-Portal_Estudante_Validar_Renda_Minima
	Use before title fiture separed with "-":
	 'C' for Chrome;
	 'I' for Internet Explorer;
	 'F' for FireFox Mozilla;
	 'E' for Edge;
	 'H' for Headless Chrome;
	 Default: Chrome

@01_AcessarPagina
Scenario: 01 Acessar o endereco
Given Acessar o endereco "http://homologacao.fundacred.org.br/estudante-web/#/"	
Then Validar o carregamento

@02_CadastrarEstudante
Scenario: 02 Iniciar Fluxo Comece Agora
Given Preencher os dados
When Clicar em Comece agora sem compromisso
Then Validar se o fluxo e iniciado

@03_IniciarSolicitaçaoDeCrédito
Scenario: 03 Iniciar Solicitacao
Given Acessar a opcao solicitacao
When Clicar em quero solicitar o credito
Then Validar o direcionamento com sucesso

@03_IniciarSolicitaçaoDeCrédito
Scenario: 04 Selecionar Instituicao
Given Selecionar instituicao "CENTRO UNIVERSITARIO IESB (GRADUACAO)"
When Selecionar curso "ENGENHARIA MECANICA-MATUTINO-EDSON MACHADO (SUL)"
And Clicar no botao aceito os termos
Then Validar solicitacao enviada

@03_IniciarSolicitaçaoDeCrédito
Scenario: 05 Preencher Dados Do Estudante
Given Clicar no botao enviar
Then Validar direcionamento para etapa 3

@04_RendaMinima
Scenario: 06 Consultar os dados para calcular a renda mínima que será apresentada no portal do estudante
Then Consultar renda "minima" no db

@04_RendaMinima
Scenario: 07 Validar o comportamento com a renda inferior ao minimo exigido
Given Informo valor inferior ao minimo
Then Apresenta mensagem informando que o valor é insuficiente
And O botao Enviar ficara desabilitado
And A opcao quero continuar mesmo assim e apresentada

@04_RendaMinima
Scenario: 08 Validar o comportamento com a renda superior ao minimo exigido
Given Informo valor superior ao minimo
Then Apresenta mensagem informando que o valor é suficiente
And O botao Enviar ficara habilitado

@04_RendaMinima
Scenario: 09 Validar o comportamento da renda minima utilizando dois fiadores com renda insuficiente
Given Informo a metade do valor com o primeiro fiador
When Seleciono a opcao para informar um segundo fiador
And Informo valor inferior ao minimo com o segundo fiador
Then Apresenta mensagem informando que o valor é insuficiente para os dois fiadores
And O botao Enviar ficara desabilitado
And A opcao quero continuar mesmo assim e apresentada para os dois fiadores

@04_RendaMinima
Scenario: 10 Validar o comportamento da renda minima utilizando dois fiadores com renda suficiente
Given Informo a primeira metade do valor com o primeiro fiador
When Informo a segunda metade do valor com o segundo fiador
Then Apresenta mensagem informando que o valor é suficiente para dois fiadores
And O botao Enviar ficara habilitado

@04_RendaMinima
Scenario: 11 Validar a opção quero continuar mesmo assim com a renda inferior ao mínimo com um fiador
Given Removo o segundo fiador
When Informo valor insuficiente para a renda mensal
And Clico no checkbox para continuar mesmo assim
#Then O botao Enviar ficara habilitado

@04_RendaMinima
Scenario: 12 Validar a opção quero continuar mesmo assim com a renda inferior ao mínimo com dois fiadores
Given Informo a metade do valor com o primeiro fiador
When Seleciono a opcao para informar um segundo fiador
And Informo valor inferior ao minimo com o segundo fiador
And Clico no checkbox para continuar mesmo assim
#Then O botao Enviar ficara habilitado