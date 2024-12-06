# Fundamentos do blazor

O Blazor é uma estrutura de desenvolvimento para a criação de interfaces web interativas usando C# em vez de JavaScript.

## MinhaPrimeiraApp

Conjuntos de funcionalidades do Blazor para guia de estudo 

Nesta aplicação, implementamos diversas funcionalidades usando o Blazor:

. [Data Binding](https://learn.microsoft.com/en-us/aspnet/core/blazor/components/data-binding?view=aspnetcore-9.0)

. [Render modes](https://learn.microsoft.com/en-us/aspnet/core/blazor/components/render-modes?view=aspnetcore-9.0)

.[Prerender](https://learn.microsoft.com/en-us/aspnet/core/blazor/components/prerender?view=aspnetcore-9.0)

. [Cascading values and parameters](https://learn.microsoft.com/en-us/aspnet/core/blazor/components/cascading-values-and-parameters?view=aspnetcore-9.0)

. [Blazor templated components](https://learn.microsoft.com/en-us/aspnet/core/blazor/components/templated-components?view=aspnetcore-9.0)

. [Blazor event handling](https://learn.microsoft.com/en-us/aspnet/core/blazor/components/event-handling?view=aspnetcore-9.0)

. Exemplo
  . Counter
  . Weather
  . Todo-List
  . Eventos Html
  . Forms
  . Roteamento

## AppCompleta

Desenvolvemos uma aplicação intemerdiária com gestão de usuários e gestão de produtos:

Nesta aplicação, implementamos diversas funcionalidades usando o Blazor:

. Scaffolding
. Customizações visuais
. QuickGrid
. Autenticação e Autorização
. Tratamento de Erros
. Interir com o JavaScript

Atualizar o banco de dados

~~~PMC

Add-Migration InitialCreate -OutputDir Data/Migrations

Update-Database

~~~

# Links

. [QuickGrid](https://www.nuget.org/packages/Microsoft.AspNetCore.Components.QuickGrid)

. [Scaffold](https://learn.microsoft.com/en-us/aspnet/core/blazor/tutorials/movie-database-app/part-2?view=aspnetcore-9.0&pivots=vs)

. [Scaffold Identity](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/scaffold-identity?view=aspnetcore-9.0&tabs=visual-studio): 

. [MudBlazor](https://mudblazor.com)

. [QuickGrid](https://aspnet.github.io/quickgridsamples)

> [!NOTE]
> Repositorio do curso Fundamentos do Blazor

>[!TODO]
> Construir dockerFile para a [AppCompleta]
