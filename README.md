<h1 align="center">
LIST VIEW IMGS
</h1>
<p align="center">
<hr>
## Techs

- [x] ASP .NET core<br>
- [x] SLQ SERVER<br>

## Starting Dev Environment

1.	Baixe o arquivo zipado no git<br>

2.	Descompactar o arquivo .zip<br>

3.  Antes de abrir a pasta do projeto, você deve entrar em seu SQL server Management Studio para criar o banco de dados na sua maquina local, não esqueça de colocar o nome do banco como `ImageDb`(Sé não colocar esse nome a aplicação não ira funcionar)<br>

4.	Ao criar o Banco de dados em sua maquina local, você podera abrir a pasta do projeto e clicar no `Projeto2.sln`<br>

5.  Depois que abrir no VS, você terá que entrar no arquivo `appsetttings.json`<br>

6.	Já no arquivo `appsetttings.json`, você deve alterar o `NOME DO SERVIDOR` para o seu local, linha de código:<br>

`"DevConnection": "Server =Nome-do-servidor; Database=ImageDb; Trusted_Connection=True; MultipleActiveResultSets=True;"`<br>

7.  Depois de trocar o nome do servidor, voocê deve ir em ferramentas --> Gerenciador de pacotes do NuGet --> e clicar na opção `Console do gerenciador de pacotes` <br>

8.  Ao clicar na opção, abrira uma tela de console, dentro da tela do console você deve digitar `Update-Database` (Esse comando serve para ajudar as Migrations a versionar o schema de sua aplicação)<br>

9.	Após a troca do nome do servidor e o uso do `Update-Database`, você poderá iniciar o projeto apertando play.<br>
