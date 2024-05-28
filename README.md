# Desafio Técnico Fiap

# Documentação da Aplicação
## Visão Geral
Este documento fornece um guia abrangente para a aplicação de gerenciamento de contatos desenvolvida usando .NET 8. A aplicação é projetada para gerenciar e organizar contatos pessoais com funcionalidades para registrar, visualizar, atualizar e excluir contatos.

![diagram-export-27-05-2024-15_51_50](https://github.com/victorverdoodt/FiapTechChallenge.ContactBook/assets/3966396/c50c3304-a81d-470c-9edb-774bd8a875e5)
![diagram-export-17-05-2024-10_24_14](https://github.com/victorverdoodt/FiapTechChallenge.ContactBook/assets/3966396/63586e72-c93f-4637-86d3-9e0ebe73b0e2)

## Funcionalidades
### Registro de Contatos
- **Descrição**: Permite que os usuários registrem novos contatos.
- **Campos**:
    - Nome
    - Telefone
    - Email
    - Código de Área Regional (DDD)
### Visualização e Consulta de Contatos
- **Descrição**: Permite que os usuários visualizem e pesquisem contatos armazenados no banco de dados.
- **Filtro**: Os contatos podem ser filtrados pelo DDD.
### Atualização de Contatos
- **Descrição**: Fornece a funcionalidade para atualizar detalhes de contatos existentes.
### Exclusão de Contatos
- **Descrição**: Permite que os usuários excluam contatos do banco de dados.

## Persistência de Dados
### Ferramentas e Frameworks
- **Entity Framework Core**: Usado para capacidades ORM.
- **PostgreSQL**: Serve como o banco de dados principal para armazenar informações de contato.
- **Redis**: Utilizado para cache de dados acessados com frequência.

## Validações
### Validações Implementadas
- **Formato de Email**: Garante que o endereço de email fornecido siga um formato válido.
- **Número de Telefone**: Valida o formato do número de telefone.
- **Campos Obrigatórios**: Verifica se todos os campos obrigatórios estão preenchidos.

## Testes Unitários
### Framework
- **NUnit**: Usado para conduzir testes unitários para garantir a confiabilidade e correção do código.

## Containerização e Orquestração
### .NET Aspire
- **Uso**: A aplicação é containerizada usando Docker, o que simplifica a implantação e a escalabilidade com .NET Aspire.
