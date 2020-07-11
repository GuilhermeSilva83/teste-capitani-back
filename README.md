## Projeto de teste.

Requisitos:
[**.Net Core 3.1**](https://dotnet.microsoft.com/download/dotnet-core/3.1)

###Para preparar o projeto "Teste.Capitani.WebApi":
* Marcar como **"Startup Project"**
* Alterar o arquivo: **appsettings.json**, trocando a variável **"DefaultConnection"**, para uma base de dados local.
* No console do NuGet, escolha o projeto **Teste.Capitani.Infra.Repositories.MainContext**
* Por fim, execute a linha de código abaixo:

>
    Update-Database


No Angular:
Altere o arquivo **environment.ts** mudando o valor da propriedade **apiUrl** p/ a nova url.
