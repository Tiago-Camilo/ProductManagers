# ProductManager
## Dicionário de Dados

**Projeto:** ProductManager – Sistema Web de Gerenciamento de Produtos  
**Versão:** 1.0  
**Banco de Dados:** PostgreSQL  
**Tabela:** Products

---

### 1. Introdução

Este documento apresenta o dicionário de dados do sistema ProductManager, descrevendo a estrutura da tabela responsável pelo armazenamento das informações dos produtos cadastrados.

O objetivo é documentar os campos existentes, seus respectivos tipos de dados, restrições e finalidades, facilitando a compreensão, manutenção e evolução do banco de dados.

### 2. Estrutura da Tabela Products

A tabela Products é responsável por armazenar os dados dos produtos gerenciados pelo sistema.

| Campo | Tipo de dado | Tamanho | Obrigatório | Restrição |
|---|---|---|---|---|
| Id | INTEGER | - | Sim | Chave primária e geração automática |
| Name | VARCHAR | 150 | Sim | Mínimo de 3 e máximo de 150 caracteres |
| Description | VARCHAR | 500 | Não | Máximo de 500 caracteres |
| SKU | VARCHAR | 50 | Sim | Código único, sem distinção entre maiúsculas e minúsculas |
| CostPrice | DECIMAL | 12,2 | Sim | Valor maior ou igual a zero |
| SalePrice | DECIMAL | 12,2 | Sim | Valor maior que zero |
| Quantity | INTEGER | - | Sim | Valor inteiro maior ou igual a zero |
| CreatedAt | TIMESTAMP | - | Sim | Preenchimento automático |

### 3. Descrição dos Campos

#### 3.1. Id

- **Finalidade:** identificar exclusivamente cada produto cadastrado.
- **Tipo:** INTEGER.
- **Obrigatoriedade:** obrigatório.
- **Restrição:** chave primária (Primary Key).
- **Preenchimento:** gerado automaticamente pelo banco de dados.

#### 3.2. Name

- **Finalidade:** armazenar o nome ou título do produto.
- **Tipo:** VARCHAR(150).
- **Obrigatoriedade:** obrigatório.
- **Restrição:** deve possuir entre 3 e 150 caracteres.

#### 3.3. Description

- **Finalidade:** armazenar informações complementares sobre o produto.
- **Tipo:** VARCHAR(500).
- **Obrigatoriedade:** opcional.
- **Restrição:** máximo de 500 caracteres.

#### 3.4. SKU

- **Finalidade:** armazenar o código de identificação comercial do produto.
- **Tipo:** VARCHAR(50).
- **Obrigatoriedade:** obrigatório.
- **Restrição:** não permite códigos duplicados, independentemente de letras maiúsculas ou minúsculas.

#### 3.5. CostPrice

- **Finalidade:** armazenar o preço de custo do produto.
- **Tipo:** DECIMAL(12,2).
- **Obrigatoriedade:** obrigatório.
- **Restrição:** deve ser maior ou igual a zero.

#### 3.6. SalePrice

- **Finalidade:** armazenar o preço de venda do produto.
- **Tipo:** DECIMAL(12,2).
- **Obrigatoriedade:** obrigatório.
- **Restrição:** deve ser maior que zero.

#### 3.7. Quantity

- **Finalidade:** registrar a quantidade disponível do produto.
- **Tipo:** INTEGER.
- **Obrigatoriedade:** obrigatório.
- **Restrição:** deve ser um número inteiro maior ou igual a zero.

#### 3.8. CreatedAt

- **Finalidade:** registrar a data e o horário em que o produto foi cadastrado.
- **Tipo:** TIMESTAMP WITHOUT TIME ZONE.
- **Obrigatoriedade:** obrigatório.
- **Restrição:** preenchimento automático por meio do valor padrão CURRENT_TIMESTAMP.

### 4. Chaves e Índices

A tabela Products possui os seguintes elementos de integridade e desempenho:

| Elemento | Campo | Finalidade |
|---|---|---|
| Primary Key | Id | Identificação exclusiva dos registros. |
| Unique Index | SKU | Impedir códigos SKU duplicados. |
| Check Constraint | CostPrice | Impedir valores negativos. |
| Check Constraint | SalePrice | Impedir valores iguais ou inferiores a zero. |
| Check Constraint | Quantity | Impedir quantidades negativas. |
| Index | Name | Auxiliar pesquisas pelo nome do produto. |

### 5. Considerações Finais

A estrutura apresentada contempla os dados necessários para o funcionamento da primeira versão do ProductManager.

A definição dos tipos de dados e restrições busca garantir a integridade, consistência e organização das informações armazenadas no PostgreSQL.

O dicionário poderá ser atualizado conforme novas funcionalidades e necessidades sejam incorporadas ao sistema.