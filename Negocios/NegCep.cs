using Newtonsoft.Json;
using ObjetoTransferencia;

namespace Negocios
{
    public class NegCep
    {


        readonly HttpClient httpClient = new();
        private string baseUrlCep = "https://brasilapi.com.br/api/cep/v1/";

        public async Task<Cep> GetCep(string cep)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cep))
                    return null;

                // Construir URL localmente para evitar side effects
                string url = baseUrlCep + cep;

                var response = await httpClient.GetStringAsync(url);

                if (string.IsNullOrWhiteSpace(response))
                    return null;

                // Deserialize direto do JSON retornado
                var objCep = JsonConvert.DeserializeObject<Cep>(response);

                return objCep;
            }
            catch (HttpRequestException)
            {
                // Pode tratar erros específicos de HTTP aqui
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar CEP: {ex.Message}", ex);
            }
        }
    }
}