# ProductManager
## Documento de Requisitos Não Funcionais

**Projeto:** ProductManager – Sistema Web de Gerenciamento de Produtos  
**Versão:** 1.0  
**Tipo de documento:** Requisitos Não Funcionais

---

### 1. Introdução

Este documento apresenta os requisitos não funcionais do sistema ProductManager, estabelecendo critérios relacionados à qualidade, desempenho, segurança, usabilidade e manutenção da aplicação.

Esses requisitos definem como o sistema deve funcionar, complementando as funcionalidades descritas no documento de requisitos funcionais.

### 2. Requisitos Não Funcionais

| Código | Requisito | Descrição |
|---|---|---|
| RNF01 | Usabilidade | O sistema deve possuir uma interface simples e intuitiva, permitindo que usuários com conhecimentos básicos de informática utilizem suas funcionalidades. |
| RNF02 | Responsividade | A interface deve se adaptar a diferentes tamanhos de tela, incluindo computadores, tablets e smartphones. |
| RNF03 | Desempenho | O sistema deve apresentar respostas adequadas às operações de cadastro, consulta, edição, exclusão e pesquisa, considerando o volume de dados previsto para sua utilização. |
| RNF04 | Integridade dos dados | O sistema deve preservar a consistência das informações armazenadas, impedindo registros inválidos e violações das regras de negócio. |
| RNF05 | Manutenibilidade | O código-fonte deve ser organizado em componentes e responsabilidades bem definidas, facilitando futuras correções e evoluções. |
| RNF06 | Compatibilidade | A aplicação deve funcionar nos principais navegadores modernos, como Google Chrome, Microsoft Edge e Mozilla Firefox. |
| RNF07 | Persistência | As informações cadastradas devem ser armazenadas em banco de dados PostgreSQL, permanecendo disponíveis após o encerramento da aplicação. |
| RNF08 | Tratamento de erros | O sistema deve tratar falhas durante as operações, apresentando mensagens compreensíveis ao usuário e evitando a exposição de detalhes técnicos desnecessários. |

### 3. Tecnologias Relacionadas

Para atender aos requisitos estabelecidos, o ProductManager utiliza as seguintes tecnologias:

- **Linguagem:** C#.
- **Framework:** ASP.NET Core MVC (.NET 10).
- **Interface:** Razor Views, HTML, CSS e Bootstrap.
- **Banco de dados:** PostgreSQL.
- **Mapeamento objeto-relacional:** Entity Framework Core.
- **Arquitetura:** Model-View-Controller (MVC).

### 4. Considerações

Os requisitos não funcionais estabelecem os critérios de qualidade esperados para a primeira versão do ProductManager.

Eles deverão ser considerados durante o desenvolvimento, os testes e as futuras manutenções da aplicação.