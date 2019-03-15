namespace Automacao_Funcional.tests.steps
{
    class MassaDeDados
    {
        public string nome = "Leonardo";
        public string sobrenome = "Teste";
        public string telefone = "(55) 99538-3542";
        public string email = "@mailinator.com";
        public string senha = "teste123";
        public string dtaNasc = "25/09/1988";

        public string cep = "90030130";
        public string numero = "44";
        public string complemento = "6° Andar";
        public string nomePai = "Francisco Moura Teste";
        public string nomeMae = "Helena Moura Teste";
        public string nomeFiador = "Leonardo Barcellos Teste";

        public string ddd = "51";
        public string numTel = "987654321";
        public string ramal = "000";

        public string nomePai_2 = "Francisco Moura Teste 2";
        public string nomeMae_2 = "Helena Moura Teste 2";

        public string matricula = "123456789";
        public string percentual = "30";

        public static string BKey = null;
        public static string Cpf = null;
        public static string Id = null;
        public static string justificativa = null;

        public static string Cnome = "Leonardo";
        public static string Csobrenome = "Teste";
        public static string Ctelefone = "55995383542";
        public static string Cemail = "@mailinator.com";
        public static string Csenha = "teste123";
        public static string CdtaNasc = "25/09/1988";


        public class Dependentes
        {
            public static string NomeDep { get; set; }
            public static string CpfDep { get; set; }
            public static string RgDep { get; set; }
            public static string DtDep { get; set; }
            public static string MatDep { get; set; }
        }

    }
}
