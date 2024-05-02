# Controle de Acesso - CRUD

Este projeto é um sistema CRUD (Create, Read, Update, Delete) com controle de acesso, desenvolvido utilizando Visual Studio 2015, .NET Framework 4.5.2, MVC (Model-View-Controller), Entity Framework e SQL Server 2019.

## Instalação

Para executar este projeto localmente, é necessário ter o seguinte ambiente configurado:

- Visual Studio 2015
- .NET Framework 4.5.2
- SQL Server 2019

Clone ou baixe o repositório para o seu computador e abra o projeto no Visual Studio 2015.

## Configuração

Antes de executar o projeto, é necessário configurar a string de conexão com o banco de dados SQL Server. Abra o arquivo `Web.config` localizado na pasta do projeto e localize a seção `<connectionStrings>`. Substitua a string de conexão existente pela sua própria string de conexão.

Exemplo de string de conexão:

```xml
<add name="ControleContext" connectionString="Data Source=NomeDoServidor;Initial Catalog=NomeDoBanco;Integrated Security=True" providerName="System.Data.SqlClient" />

#Uso
Este projeto permite a criação, leitura, atualização e exclusão de registros no banco de dados, com controle de acesso baseado em tipo de usuário.

#Contribuição
Se você deseja contribuir para este projeto, sinta-se à vontade para enviar sugestões, correções de bugs ou novos recursos. Por favor, envie suas contribuições através de pull requests.

#Licença
Este projeto está sob a licença MIT License.

#Contato
Para mais informações ou dúvidas sobre este projeto, entre em contato:

Email: kaikejrsilva55@gmail.com
LinkedIn: Caique Junior da Silva
Créditos
Desenvolvido por: CAIQUE JUNIOR DA SILVA
