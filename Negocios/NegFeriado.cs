using Newtonsoft;
using Newtonsoft.Json;
using ObjetoTransferencia;
namespace Negocios
{
    public class NegFeriado
    {
        readonly HttpClient httpClient = new();
        private string baseUrl = "https://brasilapi.com.br/api/feriados/v1/";

        public async Task BuscarFeriados(string ano, List<Feriado> feriados)
        {
            if (!string.IsNullOrEmpty(ano))
            {
                //Recebe o valor da API
                var response = await httpClient.GetStringAsync(baseUrl + ano);

                if (response == null)
                    return;

                var lista = JsonConvert.DeserializeObject<List<Feriado>>(response);

                if(lista == null) 
                    return;

                foreach(var  f in lista)
                {

                    feriados.Add(new Feriado(
                        f.Date, 
                        f.Name
                    ));

                }
            }

                /*/Forma mais completa
                 * Permite manipulção da resposta e do cabeçário
                var response2= await httpClient.GetAsync(baseUrl + ano);
                if(response2.IsSuccessStatusCode)
                {
                    string conteudo = await response2.Content.ReadAsStringAsync();
                }*/
            }




        }
    }

