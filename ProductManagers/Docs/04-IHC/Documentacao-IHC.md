# ProductManager
## Documentação de Interface Humano-Computador (IHC)

**Projeto:** ProductManager – Sistema Web de Gerenciamento de Produtos  
**Versão:** 1.0  
**Tipo de documento:** Interface Humano-Computador

---

### 1. Introdução

Este documento apresenta os aspectos relacionados à Interface Humano-Computador (IHC) do sistema ProductManager, abordando a organização visual, navegação, usabilidade e interação entre o usuário e a aplicação.

O desenvolvimento da interface considera as necessidades de pequenos comerciantes que precisam realizar o gerenciamento de seus produtos de maneira simples, rápida e organizada.

### 2. Objetivo da Interface

A interface do ProductManager tem como objetivo proporcionar uma experiência de utilização intuitiva, permitindo que o usuário execute operações de cadastro, consulta, atualização, exclusão e pesquisa de produtos sem dificuldades.

A organização das telas busca reduzir a complexidade das operações e facilitar o acesso às funcionalidades disponíveis.

### 3. Público-Alvo

A aplicação é direcionada principalmente a:

- Pequenos comerciantes.
- Microempreendedores individuais (MEIs).
- Proprietários de pequenos estabelecimentos comerciais.
- Usuários que necessitam organizar informações de produtos.

Considera-se que os usuários podem possuir diferentes níveis de familiaridade com ferramentas tecnológicas. Por esse motivo, a interface prioriza simplicidade e clareza.

### 4. Organização da Interface

O sistema foi desenvolvido utilizando ASP.NET Core MVC, Razor Views, HTML, CSS e Bootstrap.

A navegação é organizada por meio de um menu principal, permitindo acessar as funcionalidades de forma direta.

As principais telas são:

| Tela | Finalidade |
|---|---|
| Página Inicial | Apresentar o sistema e disponibilizar atalhos para as principais funcionalidades. |
| Listagem de Produtos | Exibir os produtos cadastrados e disponibilizar opções de pesquisa e gerenciamento. |
| Cadastro de Produto | Permitir a inclusão de novos produtos. |
| Detalhes do Produto | Apresentar todas as informações de um produto selecionado. |
| Edição de Produto | Permitir a atualização das informações cadastradas. |
| Exclusão de Produto | Apresentar os dados do produto e solicitar confirmação antes da exclusão. |

### 5. Princípios de Usabilidade

Durante o desenvolvimento da interface, foram considerados os seguintes princípios:

**5.1. Simplicidade**

A interface apresenta informações e funcionalidades de maneira organizada, evitando elementos desnecessários que possam dificultar a utilização.

**5.2. Consistência**

As telas mantêm padrões visuais semelhantes, incluindo cores, botões, campos de formulário e elementos de navegação.

**5.3. Feedback ao Usuário**

O sistema apresenta mensagens de confirmação após operações realizadas com sucesso e mensagens de erro quando ocorrem problemas.

**5.4. Prevenção de Erros**

Os formulários possuem validações para impedir o envio de informações inválidas, como preços negativos, nomes fora do limite permitido e campos obrigatórios não preenchidos.

**5.5. Facilidade de Navegação**

O menu principal e os atalhos da página inicial facilitam o acesso às funcionalidades do sistema.

**5.6. Responsividade**

A interface utiliza recursos do Bootstrap para adaptar sua apresentação a diferentes tamanhos de tela.

### 6. Identidade Visual

A identidade visual do ProductManager utiliza uma apresentação moderna e objetiva, buscando transmitir organização e profissionalismo.

Os principais elementos visuais incluem:

- Tons de azul escuro para destacar elementos principais.
- Fundo em tons claros para facilitar a leitura.
- Tipografia de fácil compreensão.
- Botões com identificação clara de suas ações.
- Tabelas organizadas para apresentação dos produtos.
- Espaçamento adequado entre os elementos da interface.

### 7. Fluxo de Navegação

O fluxo principal de navegação foi organizado da seguinte maneira:

1. O usuário acessa a página inicial.
2. Seleciona a opção de gerenciamento de produtos.
3. Visualiza a listagem dos produtos cadastrados.
4. Escolhe a operação desejada: cadastrar, consultar, editar, excluir ou pesquisar.
5. O sistema executa a operação solicitada.
6. O usuário recebe o resultado da operação por meio da interface.

### 8. Tecnologias Utilizadas

| Tecnologia | Aplicação |
|---|---|
| HTML | Estruturação dos elementos das páginas. |
| CSS | Definição da apresentação visual. |
| Bootstrap | Componentes visuais e responsividade. |
| Razor Views | Renderização dinâmica das páginas. |
| ASP.NET Core MVC | Organização da aplicação e comunicação entre as camadas. |

### 9. Considerações Finais

A interface do ProductManager foi planejada para atender às necessidades de gerenciamento de produtos de pequenos comerciantes, priorizando facilidade de utilização, organização e clareza das informações.

As decisões de interface buscam proporcionar uma experiência consistente e acessível, permitindo que o usuário realize as operações disponíveis sem necessidade de conhecimentos técnicos avançados.