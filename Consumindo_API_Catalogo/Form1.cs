using Microsoft.Win32.SafeHandles;
using System.Configuration;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;


namespace Consumindo_API_Catalogo;

public partial class Form1 : Form
{
    string URI = "";
    int codigoProduto = 1;
    private static string _urlBase;
    private static AccessToken accessToken;
    public Form1()
    {
        InitializeComponent();
    }

    private void btnObterProdutos_Click(object sender, EventArgs e)
    {
        try
        {
            URI = txtURI.Text;
            var accessaAPI = new AcessaAPIService();
            List<Produto> produtos = await accessaAPI.GetAllProdutos(URI, accessToken);
            dgvDados.DataSource = produtos;
        }catch(Exception ex)
        {
            MessageBox.Show("Erro ao obter produtos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnAutenticar_Click(object sender, EventArgs e)
    {
        _urlBase = ConfigurationManager.AppSettings["UrlBase"];
        var email = ConfigurationManager.AppSettings["UserID"];
        var password = ConfigurationManager.AppSettings["AccessKey"];
        var confirmPassword = password;

        var urlBase = _urlBase + "Auth/login/";

        using (var client = new HttpClient())
        {
            string conteudo = "";

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage respToken =
                client.PostAsync(urlBase,
                    new StringContent(
                        JsonSerializer.Serialize(new // Replace JsonConverter with JsonSerializer
                        {
                            email,
                            password,
                            confirmPassword
                        }), Encoding.UTF8, "application/json")).Result;

            try
            {
                conteudo = respToken.Content.ReadAsStringAsync().Result;
                btnProdutosPorId.Enabled = true;
                btnObterProdutos.Enabled = true;
                btnIncluirProduto.Enabled = true;
                btnDeletarProdutos.Enabled = true;
                btnAtualizarProduto.Enabled = true;
            }
            catch (Exception ex) { 
                MessageBox.Show("Erro ao autenticar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }

            if(respToken.StatusCode == HttpStatusCode.OK)
            {
                accessToken = JsonSerializer.Deserialize<AccessToken>(conteudo); 

                if(accessToken.Authenticated)
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken.Token);
                    MessageBox.Show("Autenticado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao autenticar: " + accessToken.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
