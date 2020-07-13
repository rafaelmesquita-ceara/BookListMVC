# Sobre o BookListMVC

O BookListMVC é um simples gerenciador de livros feito em **ASP.NET CORE 2.1** utilizando o **Entity Framework** como ORM, o projeto foi feito para fins de aprendizado. Conceitos como requisições a API, Razor Pages, validações com base no modelo, padrão de CodeFirst, Ajax, Frameworks de webdesign e SQLite foram aplicados de forma prática nesta solução.

<img src="https://user-images.githubusercontent.com/62113721/87341672-686fbc80-c520-11ea-937a-b87459a3f524.gif" 
width="95%" height="614px"
/> 

# Entidades
O note_app consiste em uma entidade de livros, onde possui a seguinte estrutura:

 - Books
	 - iD : Chave primária da entidade (int)
	 - Name: Nome do livro (string)
	 - Author: Autor do livro (string)
	 - ISBN: Sistema internacional de identificação de livros (int)
  - Users
	 - iD : Chave primária da entidade (int)
	 - CH_Name : Nome do usuario (string)
	 - CH_Login : Login do usuario (string)
	 - CH_Password : Senha do usuario (string)
	 - VL_Age  : Idade do usuario (int)

# Funções
O BookListMVC consiste em algumas funções, atendendo ao CRUD:

 - Adicionar novo livro
 - Listar livros
 - Editar livro específico
 - Remover livro específico
 - Cadastrar usuario
 - Logar com usuario cadastrado iniciando uma sessão

# Conceitos aplicados
No desenvolvimento do BookListMVC alguns conceitos foram colocados em prática:
	
 - ASP.NET CORE MVC 2.1
 	- Sistema de roteamento
	- Requisições para a API (monolítica)
	- Razor Pages
	- Utilização de AJAX para páginas dinâmicas

 - Frameworks de Web Design
 	- Data Tables (para criar tabelas interativas)
	- Sweet Alert (Alertas mais trabalhados e bonitos)
	- Toastr (Notificações Toast que mostram mensagens de sucesso ou erro vindas da api para o usuário)
	- Bootstrap (Biblioteca Html/CSS e Javascript para criação de layouts responsivos)
 - Entity Framework code-first)
 - Migrations para gerar o banco de dados
 - Conexão ao banco de dados utilizando SQL SERVER
 - Conceito MVC
 	- Models de entidade (Pasta Models)
	- Views de entidade (Pasta Views)
 	- Controladores de entidade (Pasta Controls)
 - CRUD utilizando um ORM (Entity Framework)

<img src="https://user-images.githubusercontent.com/62113721/87341691-6f96ca80-c520-11ea-81d0-1b3d04b004f4.gif" 
width="95%" height="614px"
/> 

<img src="https://user-images.githubusercontent.com/62113721/87341932-c2708200-c520-11ea-9def-faa8dff09ad4.gif" 
width="95%" height="614px"
/> 

