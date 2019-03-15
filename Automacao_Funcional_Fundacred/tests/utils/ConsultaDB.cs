using Oracle.ManagedDataAccess.Client;
using System;
using System.Globalization;

namespace Automacao_Funcional.tests.steps
{
    class ConsultaDB
    {
        public static string CpfFixo = "";

        public static void Cpf(string cpf)
        {
            CpfFixo = cpf;
        }

        public string ConectarDB()
        {
            OracleConnection con = new OracleConnection();

            OracleConnectionStringBuilder ocsb = new OracleConnectionStringBuilder();
            ocsb.Password = "paris";
            ocsb.UserID = "sgcred";
            ocsb.DataSource = "faserv22:1521/homolog";

            return ocsb.ConnectionString;
        }

        public bool Consulta(string bol_id)
        {
            //1539, 1541
            //select bolsas_id from USUARIOS_IES_BOLSAS where USUARIO_IES_ID = 8
            bool result = false;
            string total = "";

            string dia = DateTime.Now.Day.ToString();
            string mes = DateTime.Now.Month.ToString();
            string ano = DateTime.Now.Year.ToString();
            int year = int.Parse(ano) - 7;
            ano = year.ToString();
            string data = dia + "-" + mes + "-" + ano;

            OracleConnection con = new OracleConnection
            {
                ConnectionString = ConectarDB()
            };

            //string queryString0 =
            //    "select count(1) from SOLICITACOES_WEB where STATUS not in ('C', 'RIES') and STATUS_CADASTRO not in ('C') and BOLSA_ID in (select bolsas_id from USUARIOS_IES_BOLSAS where USUARIO_IES_ID = 8) and nvl(OCULTAR_IES, 'N') <> 'S' and dt_inclusao >= :dt";
            //string queryString1 =
            //    "select count(1) from SOLICITACOES_WEB where STATUS_CADASTRO in ('C') and STATUS  in ('PAF', 'PDC') and BOLSA_ID in (select bolsas_id from USUARIOS_IES_BOLSAS where USUARIO_IES_ID = 8) and nvl(OCULTAR_IES, 'N') <> 'S' and dt_inclusao >= :dt";
            //string queryString2 =
            //    "select count(1) from SOLICITACOES_WEB where STATUS_CADASTRO = 'C' and STATUS in ('PIES') and BOLSA_ID in (select bolsas_id from USUARIOS_IES_BOLSAS where USUARIO_IES_ID = 8) and nvl(OCULTAR_IES, 'N') <> 'S' and dt_inclusao >= :dt";
            //string queryString3 =
            //    "select count(1) from SOLICITACOES_WEB where STATUS_CADASTRO = 'C' and STATUS in ('A') and BOLSA_ID in (select bolsas_id from USUARIOS_IES_BOLSAS where USUARIO_IES_ID = 8) and nvl(OCULTAR_IES, 'N') <> 'S' and dt_inclusao >= :dt";
            //string queryString4 =
            //    "select count(1) from SOLICITACOES_WEB where STATUS in ('RAF', 'RDC') and STATUS_CADASTRO not in ('C') and BOLSA_ID in (select bolsas_id from USUARIOS_IES_BOLSAS where USUARIO_IES_ID = 8) and nvl(OCULTAR_IES, 'N') <> 'S' and dt_inclusao >= :dt";
            //string queryString5 =
            //    "select count(1) from SOLICITACOES_WEB where STATUS in ('RIES') and BOLSA_ID in (select bolsas_id from USUARIOS_IES_BOLSAS where USUARIO_IES_ID = 8) and nvl(OCULTAR_IES, 'N') <> 'S' and dt_inclusao >= :dt";


            string queryString0 =
                "select count(1) from SOLICITACOES_WEB where STATUS not in ('C', 'RIES') and STATUS_CADASTRO not in ('C') and BOLSA_ID in (1539, 1541) and nvl(OCULTAR_IES, 'N') <> 'S'";
            string queryString1 =
                "select count(1) from SOLICITACOES_WEB where STATUS_CADASTRO in ('C') and STATUS  in ('PAF', 'PDC') and BOLSA_ID in (1539, 1541) and nvl(OCULTAR_IES, 'N') <> 'S'";
            string queryString2 =
                "select count(1) from SOLICITACOES_WEB where STATUS_CADASTRO = 'C' and STATUS in ('PIES') and BOLSA_ID in (1539, 1541) and nvl(OCULTAR_IES, 'N') <> 'S'";
            string queryString3 =
                "select count(1) from SOLICITACOES_WEB where STATUS_CADASTRO = 'C' and STATUS in ('A') and BOLSA_ID in (1539, 1541) and nvl(OCULTAR_IES, 'N') <> 'S'";
            string queryString4 =
                "select count(1) from SOLICITACOES_WEB where STATUS in ('RAF', 'RDC') and STATUS_CADASTRO not in ('C') and BOLSA_ID in (1539, 1541) and nvl(OCULTAR_IES, 'N') <> 'S'";
            string queryString5 =
                "select count(1) from SOLICITACOES_WEB where STATUS in ('RIES') and BOLSA_ID in (1539, 1541) and nvl(OCULTAR_IES, 'N') <> 'S'";

            string[] queryList =
                {
                queryString0,
                queryString1,
                queryString2,
                queryString3,
                queryString4,
                queryString5
                };

            string[] dadosList =
                {
                DadosDB.SolicitacoesIniciadas,
                DadosDB.PendenteAnaliseFundacred,
                DadosDB.PendenteAnaliseIes,
                DadosDB.Aprovados,
                DadosDB.ReprovadosFundacred,
                DadosDB.ReprovadosIes
                };

            con.Open();

            for (int cont = 0; cont < 6; cont++)
            {

                try
                {
                    OracleCommand command = con.CreateCommand();
                    command.CommandText = queryList[cont];
                    command.Parameters.Add(new OracleParameter("dt", data));
                    OracleDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        total = reader[0].ToString();
                        dadosList[cont] = total;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                if (cont == 5)
                {
                    result = true;
                }
            }

            DadosDB.SolicitacoesIniciadas = dadosList[0];
            DadosDB.PendenteAnaliseFundacred = dadosList[1];
            DadosDB.PendenteAnaliseIes = dadosList[2];
            DadosDB.Aprovados = dadosList[3];
            DadosDB.ReprovadosFundacred = dadosList[4];
            DadosDB.ReprovadosIes = dadosList[5];

            con.Dispose();
            return result;
        }

        //public string NovoCadastro()
        //{
        //    string stat = null;
        //    OracleConnection con = new OracleConnection();

        //    con.ConnectionString = ConectarDB();

        //    string queryString0 =
        //        "select status from usuarios_web where cpf = :cpf";

        //    con.Open();

        //        try
        //        {
        //            OracleCommand command = con.CreateCommand();
        //            command.CommandText = queryString0;
        //            command.Parameters.Add(new OracleParameter("cpf", CpfFixo));

        //            OracleDataReader reader = command.ExecuteReader();

        //            if (reader.Read())
        //            {
        //                stat = reader[0].ToString();
        //                DadosDB.statCadastro = stat;

        //            }
        //            reader.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //        }

        //    con.Dispose();

        //    return stat;
        //}

        public string[] ConsultaSolicitacao()
        {
            string[] stat = new string[3];
            string Id = null;

            OracleConnection con = new OracleConnection
            {
                ConnectionString = ConectarDB()
            };

            string queryString0 =
                "select id from usuarios_web where cpf = :cpf";
            string queryString1 =
                "select status, status_cadastro, etapa_solicitacao from solicitacoes_web where usr_id = :id";

            con.Open();

            try
            {
                OracleCommand command = con.CreateCommand();
                command.CommandText = queryString0;
                command.Parameters.Add(new OracleParameter("cpf", CpfFixo));

                OracleDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Id = reader[0].ToString();

                }
                reader.Close();

                OracleCommand command2 = con.CreateCommand();
                command2.CommandText = queryString1;
                command2.Parameters.Add(new OracleParameter("id", Id));

                OracleDataReader reader2 = command2.ExecuteReader();

                if (reader2.Read())
                {
                    stat[0] = reader2[0].ToString();
                    stat[1] = reader2[1].ToString();
                    stat[2] = reader2[2].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            con.Dispose();

            return stat;
        }

        public string[] ConsultaBolsaCurso()
        {
            string[] stat = new string[2];

            OracleConnection con = new OracleConnection();

            con.ConnectionString = ConectarDB();

            string queryString1 =
                "select sw.bolsa_id, sw.curso_id " +
                "from usuarios_web uw " +
                "inner join solicitacoes_web sw on sw.usr_id = uw.id " +
                "where cpf = :cpf ";

            con.Open();

            try
            {
                OracleCommand command2 = con.CreateCommand();
                command2.CommandText = queryString1;
                command2.Parameters.Add(new OracleParameter("cpf", CpfFixo));

                OracleDataReader reader2 = command2.ExecuteReader();

                if (reader2.Read())
                {
                    stat[0] = reader2[0].ToString();
                    stat[1] = reader2[1].ToString();
                }
                reader2.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            con.Dispose();

            return stat;
        }

        public string ConsultaRendaMinima()
        {
            string vlrMensalidade = null;
            string MinSalMinimo = null;
            string VlrRendaFiador = null;
            string SalarioMinimo = null;
            string Minimo = null;
            double Mensalidade;
            float salMinimo;

            string[] status = ConsultaBolsaCurso();

            OracleConnection con = new OracleConnection();
            con.ConnectionString = ConectarDB();

            string queryString0 =
                "select pbc.min_salarios_minimo, pbc.valor_renda_fiador, vmp.vl_mensalidade, (select valor from salario_minimo where rownum = 1) as salario_minimo " +
                "from bolsas_curso bc " +
                "left join param_bolsas_curso pbc on pbc.bcs_id = bc.id " +
                "left join valores_medio_parcela vmp on vmp.bcs_id = bc.id " +
                "where bol_id = :bolsa and bc.id = :curso";

            con.Open();

            try
            {
                OracleCommand command = con.CreateCommand();
                command.CommandText = queryString0;
                command.Parameters.Add(new OracleParameter("bolsa", status[0]));
                command.Parameters.Add(new OracleParameter("curso", status[1]));

                OracleDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    MinSalMinimo = reader[0].ToString();
                    VlrRendaFiador = reader[1].ToString();
                    vlrMensalidade = reader[2].ToString();
                    SalarioMinimo = reader[3].ToString();
                }

                reader.Close();

                if (vlrMensalidade != "" && vlrMensalidade != null)
                {
                    if(VlrRendaFiador == "" || VlrRendaFiador == null)
                    {
                        Mensalidade = float.Parse(vlrMensalidade) * 1.5;
                    }
                    else
                    {
                        Mensalidade = float.Parse(vlrMensalidade) * float.Parse(VlrRendaFiador);
                    }

                    if(MinSalMinimo == "" || MinSalMinimo == null )
                    {
                        salMinimo = float.Parse(SalarioMinimo) * 2;
                    }
                    else
                    {
                        salMinimo = float.Parse(SalarioMinimo) * float.Parse(MinSalMinimo);
                    }

                    if (Mensalidade > salMinimo)
                    {
                        Minimo = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Mensalidade);
                        Minimo = Minimo.Replace("R$ ", "");
                    }
                    else
                    {
                        Minimo = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", salMinimo);
                        Minimo = Minimo.Replace("R$ ", "");
                    }
                }
                else
                {
                    Minimo = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            con.Dispose();

            return Minimo;
        }

        public void AlterarStatus()
        {
            OracleConnection con = new OracleConnection
            {
                ConnectionString = ConectarDB()
            };

            con.Open();

            string queryString =
                "update SOLICITACOES_WEB set STATUS = 'PIES' where id = '99329'";

            OracleCommand command = con.CreateCommand();
            command.CommandText = queryString;
            
            try
            {
                Console.WriteLine("Connection established (" + con.ServerVersion + ")");

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            con.Dispose();
        }

        public string[] ConsultarTabelaDependentes()
        {
            string[] values = new string[5];

            OracleConnection con = new OracleConnection
            {
                ConnectionString = ConectarDB()
            };

            con.Open();

            string queryString =
                "select * from dependentes where cpf =:Cpf";

            try
            {
                OracleCommand command = con.CreateCommand();
                command.CommandText = queryString;
                command.Parameters.Add(new OracleParameter("Cpf", MassaDeDados.Dependentes.CpfDep));

                OracleDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    values[0] = reader[1].ToString();
                    values[1] = reader[2].ToString();
                    values[2] = reader[3].ToString();
                    values[3] = reader[4].ToString();
                    values[4] = reader[5].ToString();
                }

                reader.Close();
            }
            catch
            {

            }
            return values;
        }

        public bool ConsultarSolicitacaoDependente()
        {
            string Id = null;
            bool _result = false; 


            OracleConnection con = new OracleConnection
            {
                ConnectionString = ConectarDB()
            };

            con.Open();

            string queryString =
                "select sw.id from solicitacoes_web sw inner join dependentes d on d.id = sw.dep_id where cpf =:Cpf";

            try
            {
                OracleCommand command = con.CreateCommand();
                command.CommandText = queryString;
                command.Parameters.Add(new OracleParameter("Cpf", MassaDeDados.Dependentes.CpfDep));

                OracleDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Id = reader[0].ToString();

                    if (Id != null)
                    {
                        _result = true;
                    }
                }

                reader.Close();
            }
            catch(Exception)
            {
                
            }
            return _result;
        }

        public bool ConsultarCadastroRequerente()
        {
            string Id = null;
            bool _result = false;


            OracleConnection con = new OracleConnection
            {
                ConnectionString = ConectarDB()
            };

            con.Open();

            string queryString =
                "select id from PESSOAS_WEB where cpf =:Cpf";

            try
            {
                OracleCommand command = con.CreateCommand();
                command.CommandText = queryString;
                command.Parameters.Add(new OracleParameter("Cpf", CpfFixo));

                OracleDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Id = reader[0].ToString();

                    if (Id != null)
                    {
                        _result = true;
                    }
                }

                reader.Close();
            }
            catch (Exception)
            {

            }
            return _result;
        }
    }
}
