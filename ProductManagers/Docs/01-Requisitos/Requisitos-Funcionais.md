# ProductManager
## Documento de Requisitos Funcionais

**Projeto:** ProductManager – Sistema Web de Gerenciamento de Produtos  
**Versão:** 1.0  
**Tipo de documento:** Requisitos Funcionais

---

### 1. Introdução

Este documento apresenta os requisitos funcionais do sistema ProductManager, uma aplicação web desenvolvida para auxiliar pequenos comerciantes no gerenciamento de seus produtos.

O sistema tem como objetivo centralizar as informações dos produtos, permitindo realizar operações de cadastro, consulta, atualização, exclusão e pesquisa de maneira simples e organizada.

### 2. Objetivo

Definir as funcionalidades que deverão estar disponíveis no sistema, estabelecendo o comportamento esperado para cada operação realizada pelo usuário.

### 3. Ator do Sistema

**Comerciante:** usuário responsável por utilizar o sistema para cadastrar, consultar, atualizar, pesquisar e excluir produtos.

### 4. Requisitos Funcionais

| Código | Requisito | Descrição |
|---|---|---|
| RF01 | Cadastrar produto | O sistema deve permitir cadastrar novos produtos, informando nome, descrição, SKU, preço de custo, preço de venda e quantidade. |
| RF02 | Listar produtos | O sistema deve apresentar uma listagem dos produtos cadastrados. |
| RF03 | Consultar produto | O sistema deve permitir visualizar os detalhes de um produto específico. |
| RF04 | Editar produto | O sistema deve permitir atualizar as informações de um produto já cadastrado. |
| RF05 | Excluir produto | O sistema deve permitir excluir produtos cadastrados mediante confirmação do usuário. |
| RF06 | Pesquisar produtos | O sistema deve permitir pesquisar produtos pelo nome ou pelo SKU. |
| RF07 | Validar dados | O sistema deve validar os campos informados antes de realizar operações de cadastro e atualização. |
| RF08 | Confirmar exclusão | O sistema deve solicitar confirmação antes de excluir um produto. |
| RF09 | Apresentar mensagens | O sistema deve apresentar mensagens informando o resultado das operações realizadas, incluindo sucessos e erros. |

### 5. Considerações

Os requisitos apresentados representam as funcionalidades previstas para a primeira versão do ProductManager.

O sistema não contempla, nesta versão, funcionalidades de vendas, cadastro de clientes, fornecedores, movimentações de estoque ou emissão de documentos fiscais.