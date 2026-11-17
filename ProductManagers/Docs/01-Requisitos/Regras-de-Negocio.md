# ProductManager
## Documento de Regras de Negócio

**Projeto:** ProductManager – Sistema Web de Gerenciamento de Produtos  
**Versão:** 1.0  
**Tipo de documento:** Regras de Negócio

---

### 1. Introdução

Este documento apresenta as regras de negócio estabelecidas para o sistema ProductManager.

As regras definem as condições e restrições que devem ser respeitadas durante as operações de cadastro, consulta, atualização, pesquisa e exclusão de produtos.

### 2. Regras de Negócio

#### 2.1. Identificação e Cadastro

| Código | Regra | Descrição |
|---|---|---|
| RN01 | Identificação automática | Cada produto deve receber um identificador único gerado automaticamente pelo sistema. |
| RN02 | Nome obrigatório | O nome do produto deve ser obrigatório e possuir entre 3 e 150 caracteres. |
| RN03 | Descrição opcional | A descrição do produto pode ser preenchida opcionalmente, respeitando o limite de 500 caracteres. |
| RN04 | SKU obrigatório | Todo produto deve possuir um código SKU informado no cadastro. |
| RN05 | SKU único | Não deve ser permitido cadastrar dois produtos com o mesmo SKU, independentemente de letras maiúsculas ou minúsculas. |
| RN06 | Preço de custo | O preço de custo deve ser maior ou igual a zero. |
| RN07 | Preço de venda | O preço de venda deve ser obrigatoriamente maior que zero. |
| RN08 | Quantidade válida | A quantidade em estoque deve ser um número inteiro maior ou igual a zero. |
| RN09 | Data de cadastro | A data de cadastro deve ser preenchida automaticamente pelo sistema. |
| RN10 | Validação de cadastro | Todos os campos devem ser validados conforme suas regras antes da persistência dos dados. |
| RN11 | Prevenção de duplicidade | O sistema deve impedir a inclusão de produtos com SKU já cadastrado. |
| RN12 | Confirmação de cadastro | Após um cadastro realizado com sucesso, o sistema deve apresentar uma mensagem de confirmação ao usuário. |

#### 2.2. Consulta e Pesquisa

| Código | Regra | Descrição |
|---|---|---|
| RN13 | Listagem de produtos | O sistema deve permitir consultar todos os produtos cadastrados. |
| RN14 | Pesquisa por nome | O sistema deve permitir pesquisar produtos utilizando o nome, inclusive por correspondência parcial. |
| RN15 | Pesquisa por SKU | O sistema deve permitir localizar produtos por meio do código SKU. |
| RN16 | Resultado da pesquisa | Quando nenhum produto corresponder aos critérios informados, o sistema deve apresentar uma mensagem indicando a ausência de resultados. |

#### 2.3. Atualização de Produtos

| Código | Regra | Descrição |
|---|---|---|
| RN17 | Produto existente | Somente produtos previamente cadastrados podem ser atualizados. |
| RN18 | Validação de alterações | Todas as informações modificadas devem passar pelas validações estabelecidas no cadastro. |
| RN19 | Unicidade do SKU na edição | O SKU pode permanecer igual ao do próprio produto, mas não pode pertencer a outro produto cadastrado. |
| RN20 | Preservação da identificação | A atualização não deve modificar o identificador nem a data original de cadastro do produto. |

#### 2.4. Exclusão de Produtos

| Código | Regra | Descrição |
|---|---|---|
| RN21 | Produto existente | Somente produtos cadastrados podem ser excluídos. |
| RN22 | Confirmação de exclusão | O sistema deve solicitar confirmação antes de executar a exclusão. |
| RN23 | Remoção do registro | Após a confirmação, o produto deve ser removido do banco de dados. |

#### 2.5. Persistência e Integridade

| Código | Regra | Descrição |
|---|---|---|
| RN24 | Persistência dos dados | As operações realizadas com sucesso devem ser persistidas no banco de dados. |
| RN25 | Integridade das informações | O sistema deve impedir a gravação de dados que violem as regras de negócio estabelecidas. |
| RN26 | Tratamento de falhas | Falhas durante as operações devem ser tratadas sem comprometer a consistência dos dados armazenados. |

### 3. Considerações

As regras de negócio apresentadas constituem a base para as validações e o comportamento esperado do ProductManager.

Elas devem ser consideradas durante a implementação das funcionalidades, na modelagem do banco de dados e na execução dos testes de verificação e validação.

O cumprimento dessas regras contribui para a confiabilidade, integridade e consistência das informações gerenciadas pelo sistema.