# Escola Era — Sistema de Gestão de Alunos
Aplicação desktop desenvolvida em C# com Windows Forms para gestão de alunos, utilizando SQLite como base de dados.

## Funcionalidades

- Login administrativo
- Cadastro de alunos
- Atualização de dados dos alunos
- Desativação de alunos
- Pesquisa de alunos
- Listagem através de DataGridView
- Impressão de dados
- Exportação para PDF
- Exportação para CSV
- Navegação entre diferentes formulários
- Armazenamento de dados em SQLite

## Tecnologias
- C#
- .NET
- Windows Forms
- SQLite
- SQL

## Principais conceitos aplicados
- Programação orientada a eventos
- Windows Forms
- CRUD
- Operações com base de dados
- SQLiteConnection
- SQLiteCommand
- Consultas SQL
- INSERT
- UPDATE
- Parâmetros SQL
- DataGridView
- Pesquisa e filtragem de dados
- Exportação de dados
- Impressão de documentos
- Navegação entre formulários

## Modelo de Dados
O projeto utiliza uma estrutura relacional para representar alunos, cursos, nacionalidades, localidades e matrículas.

As principais entidades do modelo são:
- Aluno
- Curso
- Nacionalidade
- Localidade
- Matrícula

O modelo estabelece relações entre estas entidades através de chaves primárias e estrangeiras.

## Estrutura do projeto

```text
escola-era-csharp-windows-forms/
│
├── Escola_era/
│   ├── Properties/
│   ├── App.config
│   ├── Escola_era.csproj
│   ├── Form1.cs
│   ├── Form1.Designer.cs
│   ├── Form1.resx
│   ├── FormAdicionar.cs
│   ├── FormAdicionar.Designer.cs
│   ├── FormAdicionar.resx
│   ├── FormAtualizar.cs
│   ├── FormAtualizar.Designer.cs
│   ├── FormAtualizar.resx
│   ├── FormLogin.cs
│   ├── FormLogin.Designer.cs
│   ├── FormLogin.resx
│   ├── Program.cs
│   └── packages.config
│
├── Escola Era.png
├── fundo.png
├── fundo.jpg
├── cabeçalho1.png
└── README.md
