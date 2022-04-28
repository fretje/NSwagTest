// See https://aka.ms/new-console-template for more information
using NSwagClient;

var apiClient = new ApiClient(new HttpClient());

var response = await apiClient.PostPostWithoutBodyAsync();

Console.WriteLine(response.Response);
