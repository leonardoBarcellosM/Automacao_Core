Feature: H-Portal_IES_Validar_Direcionamentos_Funil
	Use before title fiture separed with "-":
	 'C' for Chrome;
	 'I' for Internet Explorer;
	 'F' for FireFox Mozilla;
	 'E' for Edge;
	 'H' for Headless Chrome;
	 Default: Chrome

@01_AcessarPagina
Scenario: 01 Acessar o endereco
#Given Acessar o endereco "http://testes.fundacred.org.br/ies/#/login"	
Given Acessar o endereco "http://homologacao.fundacred.org.br/ies/#/login"	
Then Validar Acesso ao portal

@02_RealizarLogin
Scenario: 02 Realizar Login Portal IES
Given Informo o email "angela@teste.org.br"
When Informo a senha "welcome1"
And Clico no botao Entrar
Then Validar login Ies com sucesso

@03_ValidarFunil
Scenario: 03 Validar a Opção Solicitações Iniciadas
Given Acesso o dashboard
When Clico em "Solicitações Iniciadas"
When Valido o direcionamento para a tela de pesquisa "Pesquisa de solicitações"
Then Verifico o total de "Solicitações Iniciadas"

@03_ValidarFunil
Scenario: 04 Validar Resumo Da Pesquisa E Filtro De Etapas
Given Consulto a lista de etapas
Then Verifico as informacoes basicas de listagem de solicitacao

@03_ValidarFunil
Scenario: 05 Validar a Opção Reprovados fundacred
Given Acesso o dashboard
When Clico em "Reprovados Fundacred"
When Valido o direcionamento para a tela de pesquisa "Pesquisa de solicitações"
Then Verifico o total de "Reprovados Fundacred"

@03_ValidarFunil
Scenario: 06 Validar a Opção Pendente Análise Fundacred
Given Acesso o dashboard
When Clico em "Pendente Análise Fundacred"
When Valido o direcionamento para a tela de pesquisa "Pesquisa de solicitações"
Then Verifico o total de "Pendente Análise Fundacred"

@03_ValidarFunil
Scenario: 07 Validar a Opção Pendente Análise Ies
Given Acesso o dashboard
When Clico em "Pendente Análise Ies"
When Valido o direcionamento para a tela de pesquisa " Aprovação de solicitações "
Then Verifico o total de "Pendente Análise Ies"

@03_ValidarFunil
Scenario: 08 Validar a Opção Reprovadas IES
Given Acesso o dashboard
When Clico em "Reprovadas IES"
When Valido o direcionamento para a tela de pesquisa "Pesquisa de solicitações"
Then Verifico o total de "Reprovadas IES"

@03_ValidarFunil
Scenario: 09 Validar a Opção Aprovadas
Given Acesso o dashboard
When Clico em "Aprovadas"
When Valido o direcionamento para a tela de pesquisa "Pesquisa de solicitações"
Then Verifico o total de "Aprovadas"