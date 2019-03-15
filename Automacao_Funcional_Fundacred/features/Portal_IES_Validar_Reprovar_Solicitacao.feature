Feature: H-Portal_IES_Validar_Reprovar_Solicitacao
	Use before title fiture separed with "-":
	 'C' for Chrome;
	 'I' for Internet Explorer;
	 'F' for FireFox Mozilla;
	 'E' for Edge;
	 'H' for Headless Chrome;
	 Default: Chrome

@06_AcessarPagina
Scenario: 01 Acessar o endereco
#Given Acessar o endereco "http://testes.fundacred.org.br/ies/#/login"	
Given Acessar o endereco "http://homologacao.fundacred.org.br/ies/#/login"	
Then Validar Acesso ao portal

@06_6Etapa
Scenario: 02 Realizar Login Portal IES
Given Informo o email "Cristiane@teste.org.br"
When Informo a senha "welcome1"
And Clico no botao Entrar
Then Validar login Ies com sucesso

@06_6Etapa
Scenario: 03 iniciar Reprovacao
Given Acesso a opcao aprovacao
When Pesquiso a solicitacao "44335581092"
And Clico em reprovar
Then Valido o acesso ao modal de reprovacao

@06_6Etapa
Scenario: 04 Finalizar Reprovacao
Given Seleciono a justificativa
When Clico em reprovar solicitacao
Then Valido solicitacao reprovada com sucesso

@06_6Etapa
Scenario: 05 Validar DB
Then Validar status de solicitacao no db "Solicitação reprovada"