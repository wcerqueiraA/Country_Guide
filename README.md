# Country Guide
Aplicação web desenvolvida em ASP.NET Core MVC que consome a API pública REST Countries API para buscar informações sobre países.
O usuário pode pesquisar pelo nome de um país e visualizar dados como bandeira, idioma, população e área territorial.

## Descrição

Este projeto foi desenvolvido para praticar consumo de APIs externas em aplicações ASP.NET Core.
A aplicação envia uma requisição para a API de países e exibe as informações retornadas na interface.

## Stack Tecnológica

-ASP.NET Core
-ASP.NET Core MVC
-C#
-HTML5
-CSS3
-REST Countries API
-HttpClient
-Memory Cache

## Funcionalidades

-Buscar país pelo nome
-Exibir bandeira do país
-Mostrar idioma principal
-Exibir população
-Mostrar área territorial
-Cache para otimizar requisições à API

## Como Executar

```bash
git clone https://github.com/wcerqueiraA/Country_Guide.git
cd Country_Guide
dotnet restore
dotnet run
```

## Arquitetura
O projeto foi estruturado utilizando o padrão MVC (Model-View-Controller).
- Model -> Representa os dados do país retornados pela API.
- Controller -> Responsável por receber a requisição do usuário e chamar o serviço que consome a API.
- Service -> Classe responsável por fazer a requisição HTTP para a API externa.
- View -> Interface que exibe os dados do país para o usuário.

## Demonstração


## Objetivo do projeto
Este projeto foi criado com o objetivo de praticar:
- Consumo de APIs externas
- Requisições HTTP com HttpClient
- Desserialização de JSON
- Estruturação de aplicações usando MVC
- Implementação de cache em aplicações web

