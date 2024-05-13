using System.Text;

string apiUrl = "https://petstore.swagger.io/v2/pet";

try
{
    using (HttpClient client = new HttpClient())
    {
        // Crear el objeto JSON con los datos de la mascota
        string jsonData = @"{
            ""id"": 0,
            ""name"": ""dog""
        }";

        client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        HttpResponseMessage response = await client.PostAsync(apiUrl, new StringContent(jsonData, Encoding.UTF8, "application/json"));

        Console.WriteLine($"Código de respuesta: {(int)response.StatusCode} {response.ReasonPhrase}");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Ocurrió un error: {ex.Message}");
}