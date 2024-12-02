# CRUD de Produtos - ASP.NET Core MVC

Este repositório apresenta um projeto completo de **CRUD (Create, Read, Update, Delete)** para gerenciamento de produtos, desenvolvido com **ASP.NET Core MVC**, **Entity Framework Core** e **.NET 8**. Ele demonstra como construir aplicações robustas e escaláveis com operações básicas de banco de dados, seguindo as melhores práticas da indústria.

## 🎯 **Objetivo do Projeto**
Este projeto foi criado com o objetivo de:
- Proporcionar uma base sólida para aplicações CRUD.
- Demonstrar o uso de **ASP.NET Core MVC** e **EF Core** com a última versão do .NET.
- Explorar integração entre frontend e backend em uma aplicação orientada a dados.

## 🚀 **Principais Funcionalidades**
1. **Cadastro de Produtos**: Adicione novos produtos com atributos detalhados.
2. **Leitura de Produtos**: Consulte a lista de produtos cadastrados.
3. **Atualização**: Modifique os dados de produtos existentes.
4. **Exclusão**: Remova produtos com segurança e eficiência.

## 🛠️ **Tecnologias Utilizadas**
- **.NET 8**: Framework de última geração para desenvolvimento backend.
- **ASP.NET Core MVC**: Arquitetura para criação de aplicações web.
- **Entity Framework Core**: ORM para manipulação de dados com simplicidade.
- **SQL Server**: Gerenciador de banco de dados robusto e confiável.
- **Bootstrap 5**: Framework para estilização responsiva do frontend.

## 📂 **Estrutura do Projeto**
A arquitetura do projeto foi cuidadosamente planejada para separar responsabilidades e facilitar a manutenção:
- **Controllers**: Gerenciam as requisições e controlam a lógica de negócio.
- **Models**: Representam as entidades do banco de dados.
- **Views**: Exibem as informações ao usuário utilizando Razor Pages.
- **Migrations**: Controlam o versionamento e a estrutura do banco de dados.

## 🌟 **Diferenciais**
- Código limpo e organizado com uso de boas práticas.
- Uso de **Dependency Injection** para melhorar a testabilidade.
- Totalmente documentado para facilitar contribuições de outros desenvolvedores.
- Estruturado para fácil escalabilidade e integração com APIs REST.

## 💻 **Como Executar o Projeto**
1. Clone este repositório:
   ```bash
   git clone https://github.com/theotrin/Crud_Products_dot-net.git
   ```
2. Configure o banco de dados no arquivo `appsettings.json`.
3. Execute as migrações:
   ```bash
   dotnet ef database update
   ```
4. Rode o projeto:
   ```bash
   dotnet run
   ```
5. Acesse no navegador: `http://localhost:5000`.

## 🤝 **Contribuições**
Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests para aprimorar o projeto.

---

Esta abordagem demonstra claramente suas habilidades técnicas e atenção a detalhes, ao mesmo tempo que facilita a navegação e compreensão do código para recrutadores e outros desenvolvedores interessados.
