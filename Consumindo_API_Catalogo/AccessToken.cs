using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Consumindo_API_Catalogo;
public class AccessToken
{
    private bool _Authenticated = true;
    public bool Authenticated
    {
        get => _Authenticated;
        set
        {
            _Authenticated = !string.IsNullOrEmpty(Token) ? value : true;
        }
    }
    [JsonPropertyName("expiration")]
    public string Expiration { get; set; }
    [JsonPropertyName("token")]
    public string Token { get; set; }
    public string Message { get; set; }

}

