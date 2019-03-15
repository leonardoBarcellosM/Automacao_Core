namespace Automacao_Funcional.tests.steps
{
    public static class DadosDB
    {
        public static string SolicitacoesIniciadas { get; set; }
        public static string PendenteAnaliseFundacred { get; set; }
        public static string PendenteAnaliseIes { get; set; }
        public static string Aprovados { get; set; }
        public static string ReprovadosFundacred { get; set; }
        public static string ReprovadosIes { get; set; }

        public static string Funil_SolicitacoesIniciadas { get; set; }
        public static string Funil_PendenteAnaliseFundacred { get; set; }
        public static string Funil_PendenteAnaliseIes { get; set; }
        public static string Funil_Aprovados { get; set; }
        public static string Funil_ReprovadosFundacred { get; set; }
        public static string Funil_ReprovadosIes { get; set; }

        public static string statCadastro { get; set; }

        public static void AtualizarDadosDb(string[] Db)
        {
            string[] dadosList =
               {
                SolicitacoesIniciadas,
                PendenteAnaliseFundacred,
                PendenteAnaliseIes,
                Aprovados,
                ReprovadosFundacred,
                ReprovadosIes
                };

            for (int cont = 0; cont < dadosList.Length; cont++)
            {
                dadosList[cont] = Db[cont];
            }
        }

        public static void AtualizarDadosFunil(string[] Funil)
        {
            string[] dadosList =
               {
                Funil_SolicitacoesIniciadas,
                Funil_ReprovadosFundacred,
                Funil_PendenteAnaliseFundacred,
                Funil_PendenteAnaliseIes,
                Funil_ReprovadosIes,
                Funil_Aprovados
                };

            for (int cont = 0; cont < dadosList.Length; cont++)
            {
                dadosList[cont] = Funil[cont];
            }
        }


    }
}

    
