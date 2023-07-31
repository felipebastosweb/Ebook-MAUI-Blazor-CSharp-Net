# Estruturação do Projeto e Criação de Páginas

Ao criar um projeto Blazor .NET MAUI no Visual Studio Community, você encontrará uma estrutura de diretórios e arquivos bem organizada para facilitar o desenvolvimento da aplicação. Vamos explorar os arquivos obrigatórios e opcionais presentes na estrutura padrão do projeto Blazor MAUI. A princípio, sugiro que não altere a formatação dos arquivos existentes a não ser que você saiba o que está fazendo.

## Arquivos Obrigatórios
 - Program.cs: Este arquivo contém o ponto de entrada do aplicativo MAUI e é responsável por iniciar a aplicação.
 - MainPage.razor: Essa é a página principal da aplicação Blazor MAUI. É onde o conteúdo principal da aplicação é renderizado.
 - App.razor: Este arquivo é o componente raiz do aplicativo. Ele define o layout geral da aplicação e é responsável por renderizar as outras páginas e componentes.
- Pages: Este diretório geralmente contém as páginas adicionais da aplicação. Ao criar uma nova página, um novo arquivo Razor será criado aqui.

## Arquivos Opcionais
 - Data: Este diretório é usado para armazenar as classes de modelo e serviços do aplicativo, com como qualquer outro arquivo C# que seja necessário para a aplicação.
 - wwwroot: Este diretório é usado para armazenar recursos estáticos, como arquivos CSS, JavaScript, imagens e outros arquivos que serão servidos diretamente pelo servidor.
 - Properties: Este diretório é comumente encontrado em projetos Blazor MAUI criados no Visual Studio. Ele contém o arquivo launchSettings.json, que é usado para configurar as opções de execução da aplicação, como a porta em que o servidor será iniciado.
- Shared: Este diretório é usado para armazenar componentes compartilhados que podem ser usados em várias páginas da aplicação.

## Sugestão de Estrutura Adicional
Aqui está a sugestão de estrutura de diretórios para o projeto Blazor MAUI, com algumas melhorias e justificativas em comparação ao modelo anterior:

Diretórios:
 - Data
 - Data/Models
 - Data/Repositories
 - Data/Services
 - Pages
 - Pages/Forms
 - Pages/Cards
 - Pages/Lists
 - Pages/Tiles

Data: Este diretório pode ser utilizado para armazenar todos os arquivos relacionados a dados, como modelos, repositórios e serviços.
Data/Models: Neste diretório, mantenha os modelos de dados da aplicação, representando as entidades utilizadas.
Data/Repositories: Aqui, armazene as classes responsáveis pela comunicação com fontes de dados externas, como APIs ou bancos de dados.
Data/Services: Este diretório pode conter serviços que lidam com a lógica de negócios da aplicação, tornando a camada de dados mais separada das regras de negócio.
Pages: Mantenha todas as páginas da aplicação neste diretório, organizadas em subdiretórios para melhor estruturação.
Pages/Forms: Aqui, coloque as páginas relacionadas a formulários e entradas de dados.
Pages/Cards: Neste diretório, coloque as páginas que exibem informações em cartões ou cards, proporcionando uma melhor separação de layout.
Pages/Lists: Para páginas que apresentam listas de itens, utilize este diretório para mantê-las organizadas.
Pages/Tiles: Caso a aplicação use tiles ou blocos como interface, este diretório é ideal para armazenar as páginas relacionadas.
