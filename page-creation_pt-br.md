# MAUI e MAUI Blazor

Diferente de um aplicativo MAUI .Net que é baseado em Xamarin e sua estrutura segue o modelo MVVM (Model View ViewModel) e as Views são construídas através de arquivos XAML e XAML.cs, existe uma camada de visualização construída com o componente BlazorWebView que permite exibir componentes Razor com o mesmo poder do código C# nativo.

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

## Comparação e Melhorias

A sugestão de diretórios padrão não é tão detalhada em relação à organização dos arquivos específicos. A atual sugestão fornece uma divisão mais clara e estruturada dos arquivos, o que facilita a localização e a manutenção dos mesmos.

As melhorias na nova sugestão incluem:
Melhor organização: O modelo atual propõe um agrupamento mais claro dos arquivos relacionados a dados, páginas e componentes, tornando o projeto mais organizado e de fácil manutenção.

Separação de camadas: Ao dividir os arquivos de dados em "Models", "Repositories" e "Services", conseguimos separar melhor a camada de dados da lógica de negócio, promovendo um código mais modular e fácil de entender.

Nomenclatura descritiva: Os subdiretórios como "Forms", "Cards", "Lists" e "Tiles" fornecem uma nomenclatura mais descritiva, o que torna o propósito das páginas mais claro e ajuda a identificar rapidamente o que cada parte da aplicação representa.

Escalabilidade: Com a estrutura de diretórios mais detalhada e organizada, o projeto está melhor preparado para lidar com o crescimento e a adição de novas funcionalidades, tornando-o mais escalável.

Em resumo, a sugestão atual de diretórios para o projeto Blazor MAUI oferece uma organização mais eficiente, maior clareza na nomenclatura e uma melhor separação de responsabilidades entre os arquivos. Isso torna o desenvolvimento mais ágil e facilita a colaboração entre membros da equipe, resultando em um projeto mais robusto e fácil de manter no longo prazo.

## Anatomia de uma Página

Uma página de um aplicativo híbrido mobile utilizando MAUI com Blazor deve ter código HTML e C#, e algumas tags Asp.NET. As páginas são divididas em duas seções, a parte Asp.Net e a parte C#, podendo conter também a parte CSS em um arquivo separado (de forma um pouco parecida com o framework Vue.JS, caso você já tenha trabalhado com Javascript). 

Vejamos como fica a nossa página principal descrita no componente Index.razor.

### Código "Asp.NEt"
(em breve)

### Código C#
(em breve)

## Separando os códigos Asp.Net e C#
(em breve)




(texto para editar)

Uma página Razor em um projeto Blazor MAUI é um componente que contém a estrutura, a lógica e a aparência da página que será renderizada para o usuário. A página Razor é escrita em formato .razor e é uma mistura de código C# com marcação HTML-like, o que torna a criação de interfaces de usuário de forma declarativa muito intuitiva.

Aqui está uma explicação detalhada sobre a anatomia de uma página Razor:

Diretivas:
No início do arquivo .razor, você pode encontrar diretivas usando o símbolo @. Essas diretivas são usadas para importar namespaces, referenciar componentes ou até mesmo criar instruções C# diretamente. Algumas diretivas comuns são @page, @using e @inject.

Referências a Componentes:
Uma página Razor pode fazer referência a outros componentes Razor que você criou ou que fazem parte do projeto. Para fazer isso, você pode usar a tag <Componente> dentro da marcação HTML-like da página.

Marcação HTML-like:
A maior parte do conteúdo de uma página Razor é uma marcação que se parece com HTML. Aqui, você pode definir a estrutura e o layout da página, como elementos, estilos, imagens, etc. Essa marcação será renderizada no navegador quando a página for acessada.

Código C#:
O código C# é escrito dentro de blocos delimitados por @ {}. Isso permite que você adicione lógica e comportamento à página, como manipulação de eventos, chamadas a serviços, definição de variáveis, e muito mais.

*Arquivos .razor.cs:
Para componentes Razor mais complexos, é possível separar o código C# da marcação HTML-like em um arquivo separado com a extensão *.razor.cs. Essa separação ajuda a manter o código mais organizado e legível, especialmente para componentes maiores e mais reutilizáveis.

*Arquivos .razor.css:
Assim como os arquivos *.razor.cs, é possível separar o código CSS associado a uma página Razor em um arquivo *.razor.css. Essa separação permite uma melhor organização e manutenção dos estilos aplicados à página.

Utilização de Componentes Razor em Páginas Razor

Os componentes Razor são reutilizáveis e modulares, o que significa que você pode incorporá-los em outras páginas Razor para criar interfaces mais complexas e consistentes.

Para utilizar um componente Razor em uma página Razor, você pode simplesmente usar a tag <Componente> com o nome do componente que deseja incorporar. Por exemplo, se você tiver um componente chamado MeuComponente.razor, basta incluí-lo em sua página usando <MeuComponente>.

Dentro do componente MeuComponente, você pode definir parâmetros que podem ser passados a partir da página que o está utilizando. Isso permite a personalização e configuração dinâmica do componente em diferentes páginas.

Por meio da utilização de componentes Razor, você pode criar interfaces de usuário altamente reutilizáveis, simplificar a manutenção do código e promover uma arquitetura mais organizada em seus projetos Blazor MAUI.

~~~
<!-- PaginaInicial.razor -->
@page "/"

<h3>Bem-vindo ao Aplicativo de Condomínio</h3>

<div class="container">
    <div class="row">
        <!-- Botão para Avisos -->
        <div class="col-md-3">
            <button class="btn btn-primary btn-block" @onclick="IrParaAvisos">
                <img src="images/avisos_icon.png" alt="Ícone Avisos" class="btn-icon" />
                Avisos
            </button>
        </div>

        <!-- Botão para 2ª Via de Boletos -->
        <div class="col-md-3">
            <button class="btn btn-primary btn-block" @onclick="IrParaSegundaViaBoletos">
                <img src="images/boletos_icon.png" alt="Ícone 2ª Via de Boletos" class="btn-icon" />
                2ª Via de Boletos
            </button>
        </div>

        <!-- Botão para Reuniões -->
        <div class="col-md-3">
            <button class="btn btn-primary btn-block" @onclick="IrParaReunioes">
                <img src="images/reunioes_icon.png" alt="Ícone Reuniões" class="btn-icon" />
                Reuniões
            </button>
        </div>

        <!-- Botão para Reservas de Áreas Comuns -->
        <div class="col-md-3">
            <button class="btn btn-primary btn-block" @onclick="IrParaReservasAreasComuns">
                <img src="images/reservas_icon.png" alt="Ícone Reservas de Áreas Comuns" class="btn-icon" />
                Reservas de Áreas Comuns
            </button>
        </div>
    </div>

    <div class="row mt-3">
        <!-- Botão para Contato com a Administração -->
        <div class="col-md-3">
            <button class="btn btn-primary btn-block" @onclick="IrParaContatoAdministracao">
                <img src="images/contato_icon.png" alt="Ícone Contato com a Administração" class="btn-icon" />
                Contato com a Administração
            </button>
        </div>

        <!-- Botão para Notificações -->
        <div class="col-md-3">
            <button class="btn btn-primary btn-block" @onclick="IrParaNotificacoes">
                <img src="images/notificacoes_icon.png" alt="Ícone Notificações" class="btn-icon" />
                Notificações
            </button>
        </div>

        <!-- Botão para Reservas de Espaços -->
        <div class="col-md-3">
            <button class="btn btn-primary btn-block" @onclick="IrParaReservasEspacos">
                <img src="images/espacos_icon.png" alt="Ícone Reservas de Espaços" class="btn-icon" />
                Reservas de Espaços
            </button>
        </div>

        <!-- Botão para Manutenções -->
        <div class="col-md-3">
            <button class="btn btn-primary btn-block" @onclick="IrParaManutencoes">
                <img src="images/manutencoes_icon.png" alt="Ícone Manutenções" class="btn-icon" />
                Manutenções
            </button>
        </div>
    </div>
</div>

@code {
    // Lógica para redirecionar para os diferentes recursos
    private void IrParaAvisos()
    {
        // Lógica para redirecionar para a página de Avisos
        NavigationManager.NavigateTo("MinhaRotaAvisos");
    }

    private void IrParaSegundaViaBoletos()
    {
        // Lógica para redirecionar para a página de 2ª Via de Boletos
        NavigationManager.NavigateTo("MinhaRotaSegundaViaBoletos");
    }

    // Continuar com a lógica para os outros recursos...
}
~~~


