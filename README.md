# Sistema de Cadastros - Teste Técnico

Projeto desenvolvido como teste técnico para a vaga na Via Aroma. Trata-se de uma aplicação desktop de cadastro e gestão de pessoas (CRUD) feita em C# com Windows Forms e MySQL.

## O que o projeto faz
* Permite cadastrar, listar, editar e excluir pessoas.
* Valida a exclusão com confirmação para evitar cliques acidentais.
* Conta com uma janela principal limpa e atualização automática da grelha (DataGridView) quando alteramos ou criamos registos.
* Inclui um relatório gerado com o Report Viewer (.rdlc) para visualização e impressão dos dados.

## Tecnologias utilizadas
* C# (.NET Framework)
* Windows Forms
* MySQL (XAMPP / phpMyAdmin)
* Report Viewer

## Como rodar o projeto
1. Clone ou baixe este repositório para o seu computador.
2. Importe o script da base de dados (`teste_cadastros.sql`, que está na raiz do projeto) para o seu MySQL.
3. Abra o ficheiro de solução (`.sln`) no Visual Studio.
4. Execute o projeto (F5).
