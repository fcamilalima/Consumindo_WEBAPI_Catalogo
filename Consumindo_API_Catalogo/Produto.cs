using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Consumindo_API_Catalogo;

public class Produto
{
    [JsonPropertyName("produtoId")]
    public int ProdutoID { get; set; }

    [JsonPropertyName("nome")]
    public string Nome { get; set; }

    [JsonPropertyName("descricao")]
    public string Descricao { get; set; }

    [JsonPropertyName("preco")]
    public decimal Preco { get; set; }

    [JsonPropertyName("imagemURL")]
    public string ImagemURL { get; set; }

    [JsonPropertyName("categoriaId")]
    public int CategoriaID { get; set; }
}
