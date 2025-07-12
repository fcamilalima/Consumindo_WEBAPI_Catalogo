using Microsoft.Win32.SafeHandles;
using System.Configuration;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


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

    private async void btnObterProdutos_Click(object sender, EventArgs e)
    {
        try
        {
            URI = txtURI.Text;
            var accessaAPI = new AcessaAPIService();
            List<Produto> produtos = await accessaAPI.GetAllProdutos(URI, accessToken);
            dgvDados.DataSource = produtos;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao obter produtos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnAutenticar_Click(object sender, EventArgs e)
    {
        _urlBase = ConfigurationManager.AppSettings["UrlBase"];
        var userName = ConfigurationManager.AppSettings["UserID"];
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
                            userName,
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
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao autenticar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }

            if (respToken.StatusCode == HttpStatusCode.OK)
            {
                accessToken = JsonSerializer.Deserialize<AccessToken>(conteudo);

                if (accessToken.Authenticated)
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

    private async void btnProdutosPorId_Click(object sender, EventArgs e)
    {
        BindingSource bindingSource = new BindingSource();
        InputBox();
        if (codigoProduto != -1)
        {
            try
            {
                URI = txtURI.Text + "/" + codigoProduto;
                var accessaAPI = new AcessaAPIService();
                Produto produto = await accessaAPI.GetProdutoById(URI, accessToken);
                bindingSource.DataSource = produto;
                dgvDados.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private async void btnIncluirProduto_Click(object sender, EventArgs e)
    {
        Random random = new Random();
        URI = txtURI.Text;
        Produto produto = new Produto
        {
            Nome = "Novo Produto " + DateTime.Now.Second.ToString(),
            Descricao = "Descrição do Novo Produto " + DateTime.Now.Second.ToString(),
            CategoriaID = 1,
            Preco = random.Next(100),
            ImagemURL = "novaImagem" + DateTime.Now.Second.ToString() + "jpg",
        };
        try
        {
            var acessaAPI = new AcessaAPIService();
            var resultado = await acessaAPI.AddProduto(URI, accessToken, produto);
            MessageBox.Show("Produto incluído com sucesso! ID: " + resultado, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao incluir produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnAtualizarProduto_Click(object sender, EventArgs e)
    {
        Random random = new Random();
        Produto produto = new Produto
        {
            Nome = "Novo Produto Alterado " + DateTime.Now.Second.ToString(),
            Descricao = "Descrição do Produto Atualizado " + DateTime.Now.Second.ToString(),
            CategoriaID = 1,
            ImagemURL = "imagemAtualizada" + DateTime.Now.Second.ToString() + ".jpg",
            Preco = random.Next(100),
        };
        InputBox();
        if (codigoProduto != -1)
        {
            produto.ProdutoID = codigoProduto;
            URI = txtURI.Text + "/" + produto.ProdutoID;
            try
            {
                var acessaAPI = new AcessaAPIService();
                var resultado = await acessaAPI.UpdateProduto(URI, accessToken, produto);
                MessageBox.Show("Produto atualizado com sucesso! ID: " + resultado, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    private void InputBox()
    {
        string Prompt = "Informe o código do produto:";
        string Titulo = "www.macoratti.com.br";
        string Resultado = Microsoft.VisualBasic.Interaction.InputBox(
            Prompt, Titulo, "9", 600, 350);

        if (Resultado != "")
        {
            codigoProduto = Convert.ToInt32(Resultado);
        }
        else
        {
            codigoProduto = -1;
        }
    }

    private async void btnDeletarProdutos_Click(object sender, EventArgs e)
    {
        URI = txtURI.Text;
        InputBox();
        if (codigoProduto != -1)
        {
            try
            {
                var acessaAPI = new AcessaAPIService();
                var resultado = await acessaAPI.DeleteProduto(URI, accessToken, codigoProduto);
                MessageBox.Show("Produto deletado com sucesso! ID: " + resultado, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
