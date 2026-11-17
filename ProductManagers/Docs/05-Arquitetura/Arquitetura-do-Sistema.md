# ProductManager
## Documento de Arquitetura do Sistema

**Projeto:** ProductManager – Sistema Web de Gerenciamento de Produtos  
**Versão:** 1.0  
**Arquitetura:** Model-View-Controller (MVC)

---

### 1. Introdução

Este documento apresenta a arquitetura de software utilizada no desenvolvimento do ProductManager, descrevendo sua organização interna, responsabilidades dos componentes, tecnologias utilizadas e fluxo de comunicação entre as camadas da aplicação.

O sistema foi desenvolvido com ASP.NET Core MVC, utilizando C# e Entity Framework Core para comunicação com o banco de dados PostgreSQL.

### 2. Arquitetura Utilizada

O ProductManager utiliza o padrão arquitetural Model-View-Controller (MVC), que organiza a aplicação em três componentes principais:

**Model (Modelo)**

Responsável por representar os dados e as estruturas utilizadas pela aplicação.

No projeto, essa responsabilidade é representada principalmente pela entidade Product, que contém os atributos e informações dos produtos cadastrados.

**View (Visualização)**

Responsável pela apresentação das informações e interação com o usuário.

As interfaces foram desenvolvidas utilizando Razor Views, HTML, CSS e Bootstrap.

**Controller (Controlador)**

Responsável por receber as requisições do usuário, coordenar as operações necessárias e retornar as respostas adequadas.

No ProductManager, essa responsabilidade é realizada pelo ProductsController.

### 3. Organização das Camadas

Além da estrutura MVC, o projeto utiliza uma camada de serviços para separar as regras de aplicação e operações de negócio.

A organização é composta por:

| Componente | Responsabilidade |
|---|---|
| Controllers | Receber requisições e controlar o fluxo da aplicação. |
| Views | Apresentar informações e formulários ao usuário. |
| Models | Representar as entidades do sistema. |
| ViewModels | Transportar dados entre formulários, Controllers e Views. |
| Services | Executar operações e regras relacionadas ao gerenciamento de produtos. |
| Interfaces | Definir contratos para os serviços. |
| Data | Configurar o acesso ao banco de dados por meio do Entity Framework Core. |
| Configurations | Definir o mapeamento das entidades utilizando Fluent API. |

### 4. Tecnologias Utilizadas

| Tecnologia | Finalidade |
|---|---|
| C# | Linguagem de programação principal. |
| .NET 10 | Plataforma de desenvolvimento. |
| ASP.NET Core MVC | Framework para desenvolvimento da aplicação web. |
| Razor Views | Construção das interfaces dinâmicas. |
| HTML5 | Estruturação das páginas. |
| CSS3 | Estilização da aplicação. |
| Bootstrap | Componentes visuais e responsividade. |
| PostgreSQL | Sistema gerenciador de banco de dados. |
| Entity Framework Core | Mapeamento objeto-relacional e persistência dos dados. |
| Npgsql | Provedor de conexão entre Entity Framework Core e PostgreSQL. |
| PlantUML | Desenvolvimento dos diagramas UML. |
| Git e GitHub | Controle de versão e armazenamento do código-fonte. |

### 5. Fluxo de Comunicação

O fluxo de comunicação do ProductManager ocorre da seguinte maneira:

1. O usuário acessa uma funcionalidade pela interface web.
2. A View apresenta os formulários e informações disponíveis.
3. O Controller recebe a requisição.
4. O Controller valida os dados recebidos e utiliza a interface IProductService.
5. O ProductService executa as operações solicitadas.
6. O AppDbContext realiza as consultas e alterações no banco de dados utilizando Entity Framework Core.
7. O PostgreSQL armazena ou retorna as informações solicitadas.
8. O resultado retorna ao Controller, que apresenta a resposta ao usuário por meio de uma View.

### 6. Estrutura do Projeto

A organização dos diretórios do ProductManager foi definida da seguinte forma:

```text
ProductManager/
│
├── Controllers/
│   ├── HomeController.cs
│   └── ProductsController.cs
│
├── Data/
│   ├── AppDbContext.cs
│   └── Configurations/
│       └── ProductConfiguration.cs
│
├── Models/
│   └── Product.cs
│
├── Services/
│   ├── Interfaces/
│   │   └── IProductService.cs
│   └── ProductService.cs
│
├── ViewModels/
│   ├── ProductCreateViewModel.cs
│   ├── ProductEditViewModel.cs
│   └── ProductListViewModel.cs
│
├── Views/
│   ├── Home/
│   ├── Products/
│   └── Shared/
│
├── wwwroot/
│   ├── css/
│   ├── js/
│   └── lib/
│
├── docs/
│   ├── 01-Requisitos/
│   ├── 02-UML/
│   ├── 03-Banco-de-Dados/
│   ├── 04-IHC/
│   └── 05-Arquitetura/
│
├── appsettings.json
└── Program.cs
```

### 7. Padrões e Práticas de Desenvolvimento

Durante a implementação, foram utilizadas práticas que contribuem para a organização e manutenção do código:

**Injeção de Dependência:** os serviços são registrados e disponibilizados por meio do contêiner de dependências do ASP.NET Core.

**Separação de Responsabilidades:** Controllers, Services, Models e Views possuem responsabilidades distintas.

**Programação Assíncrona:** operações de acesso ao banco de dados utilizam async/await para evitar bloqueios desnecessários durante as requisições.

**Fluent API:** o mapeamento das entidades e suas restrições são definidos por meio das configurações do Entity Framework Core.

**Validação de Dados:** os ViewModels utilizam Data Annotations para validar informações recebidas nos formulários.

**Entity Framework Core:** utilizado para realizar operações de persistência e consulta ao banco de dados.

### 8. Considerações Finais

A arquitetura adotada no ProductManager busca proporcionar uma aplicação organizada, de fácil manutenção e com responsabilidades bem definidas.

A utilização do padrão MVC, associada à camada de serviços e ao Entity Framework Core, permite separar a apresentação, o processamento das operações e o acesso aos dados.

Essa estrutura facilita futuras evoluções do sistema, permitindo adicionar novas funcionalidades sem comprometer a organização existente.