# DesafioFullstackDotnetVue

# Desafio Dev .Net Fullstack Vue.js
Este documento descreve o desafio que será utilizado para avaliar os candidatos à vaga de Fullstack na D&D. Caso você tenha chegado aqui por acaso, sinta-se à vontade em realizar o teste, e logo após, contar um pouco mais sobre você através do email (thales.xavier@dedtechsolutions.com.br)

# O  Desafio
A equipe D&D levantou a necessidade de construção de um ferramenta que permita administração de Bebidas, onde espera-se ser possível fazer os cadastros desses Produtos com as seguintes característica:
- Título
- Descrição
- Valor
- Imagem
- Data de Criação 
- Data de Atualização 

Você será o responsável por criar essa Web API (dotnet 6) e fazer um CRUD (Vue.js). 

- Crie um projeto WebAPI; 

- Crie uma base de dados com a tabela Produtos utilizando Entity Framework;

- Faça um CRUD de Produtos. Será necessário gerar 5 endpoints para atender à esta finalidade:
  - Listar todos os Produtos com paginação
  - Buscar um Produtos em especifico por Título e Descrição;
  - Criar um novo Produtos;
  - Excluir um Produtos;
  - Editar um Produtos;

**O que não fazer:**
Vamos manter o desafio simples, ou seja, não se apegue a questão de usuário/perfil etc. A ideia é saber se você consegue criar uma API seguindo **boas práticas** e que faça persistência no banco de dados.

## Requisitos técnicos:
- Utilizar a base de dados Sql Server;
- Construir a API com dotnet 6.
- Utilizar o Entity Framework para a camada de persistência;
- Adotar as melhores práticas do mercado para construção de APIs;
- Adotar as melhores práticas do mercado para construção do CRUD (pode utilizar algum template)

## Diferenciais:
- Instalar e configurar o swagger;
- Aplicar o padrão RESTful para o desenvolvimento da API;

## O que será avaliado:
- **Organização do código**: Como você organiza os arquivos que compõem a solução;
- **Estruturação do código**: Como você estrutura o código e a solução do projeto (arquitetura adotada, etc);
- **Criatividade/Inovação:** Capacidade de sugerir melhorias no contexto descrito no desafio;
- **Nomenclatura/padrões:** A nomenclatura e padrões adotados para as propriedades, atributos, endpoints e nome do projeto;
- **Utilização do Git:** O readme do repositório e a descrição dos commit deverão ser claros e de fácil entendimento;

## Entrega:
O candidato deverá criar um fork deste projeto, e a partir deste fork, realizar o desenvolvimento. Favor utilizar o "Readme" do seu fork para descrever as dificuldades técnicas encontradas, como você as superou e, principalmente, como subir o projeto. Ao finalizar, você deverá responder para o e-mail que te enviou esse desafio, com o link do seu fork.
