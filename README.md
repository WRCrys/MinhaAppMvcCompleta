﻿![](https://gixnetwork.org/wp-content/uploads/2019/04/Microsoft-logo_rgb_gray-1024x459.png)
# MinhaAppMvcCompleta

## Comandos para o Gerenciador de Pacotes

#### Configurando o seu próprio contexto
##### Instalando o Entity Framework Core

PM> `Install-Package Microsoft.EntityFrameworkCore`


------------


##### Instalando o Relational do Entity Framework Core para conseguirmos mapear o tipo e tamanho das colunas

PM> `Install-Package Microsoft.EntityFrameworkCore.Relational`


------------



##### Adicionando a nossa migration para criarmos o banco passando o contexto pois nessa aplicação temos dois contextos e não é entendido quando tem mais de um.

PM> `Add-Migration Initial  -Context MeuDbContext


------------



##### Caso queria criar um script sql precisará do pacote abaixo

PM> `Install-Package Microsoft.EntityFrameworkCore.Sqlserver`


------------


##### Criando um script sql a partir da migration do contexto escolhido.

PM> `Script-Migration -Context MeuDbContext -v`


------------


##### Caso queria criar o banco direto use o comando abaixo.

Caso tenha mais de um contexto, escolha e passe...
PM> `Update-Database -Context MeuDbContext`

Caso não...
PM> `Update-Database`


------------



#### Configurando o Automapper para o uso de ViewModel

PM> `Install-Package automapper.extensions.microsoft.dependencyinjection`


------------


#### Framework para validação de negócio

##### [Fluent Validation](http://https://docs.fluentvalidation.net/en/latest/installation.html "Fluent Validation")

PM> `Install-Package FluentValidation`







