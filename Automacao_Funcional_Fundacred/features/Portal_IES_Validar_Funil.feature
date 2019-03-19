Feature: H-Portal_IES_Validar_Funil
	Use before title fiture separed with "-":
	 'C' for Chrome;
	 'I' for Internet Explorer;
	 'F' for FireFox Mozilla;
	 'E' for Edge;
	 'H' for Headless Chrome;
	 Default: Chrome

@01_AcessarPagina
Scenario: 01 Acessar o endereco
Given Acessar o endereco "http://testes.fundacred.org.br/ies/#/login"	
Given Acessar o endereco "http://homologacao.fundacred.org.br/ies/#/login"	
Then Validar Acesso ao portal

@02_RealizarLogin
Scenario: 02 Realizar Login Portal IES
Given Informo o email "Cristiane@teste.org.br"
When Informo a senha "welcome1"
And Clico no botao Entrar
Then Validar login Ies com sucesso

@03_ValidarFunil
Scenario: 03 Capturar os dados do DB e Funil
Given Consulto os dados no banco "1539, 1541"
Then Consulto os dados do funil 

@03_ValidarFunil
Scenario: 04 Valido solicitacoes iniciadas
Then Valido solicitacoes iniciadas

@03_ValidarFunil
Scenario: 05 Valido pendente analise fundacred
When Valido pendente analise fundacred

@03_ValidarFunil
Scenario: 06 Valido Pendente analise ies
When Valido Pendente analise ies

@03_ValidarFunil
Scenario: 07 Valido aprovados
When Valido aprovados

@03_ValidarFunil
Scenario: 08 Valido reprovados fundacred
When Valido reprovados fundacred

@03_ValidarFunil
Scenario: 09 Valido Fila De Espera IES
When Valido Fila De Espera IES

@03_ValidarFunil
Scenario: 10 Valido reprovados ies
When Valido reprovados ies