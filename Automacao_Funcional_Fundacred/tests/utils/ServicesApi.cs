

using System;

namespace Automacao_Funcional.tests.steps
{
    class ServicesApi
    {
        public bool CarregarSolicitacao()
        {
            String Token = ClassUtilities.getItemFromLocalStorage("value");
            bool _result = ConsultarServicoCarregarSolicitacao(Token);

            return _result;
        }

        public bool ConsultarServicoCarregarSolicitacao(string Token)
        {
            bool _result = false;
            const string WEBSERVICE_URL = "http://homologacao.fundacred.org.br:8080/portal-estudante-rest/resources/solicitacaoCredito/carregar";
            try
            {
                var webRequest = System.Net.WebRequest.Create(WEBSERVICE_URL);
                if (webRequest != null)
                {
                    webRequest.Method = "GET";
                    webRequest.Timeout = 12000;
                    webRequest.ContentType = "application/json";
                    webRequest.Headers.Add("Authorization", Token);

                    using (System.IO.Stream s = webRequest.GetResponse().GetResponseStream())
                    {
                        using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
                        {
                            var jsonResponse = sr.ReadToEnd();
                            string value = String.Format("Response: {0}", jsonResponse);
                            string[] values = value.Split('"');
                            if (values[2] == ":99299,")
                            {
                                _result = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return _result;
        }
    }
}
