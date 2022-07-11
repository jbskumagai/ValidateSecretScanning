// See https://aka.ms/new-console-template for more information
using ValidateSecretScanning;

Console.WriteLine("Hello, World!");
var client = new HttpClientSample();
Console.WriteLine($"StatusCode : {await client.Get()}");