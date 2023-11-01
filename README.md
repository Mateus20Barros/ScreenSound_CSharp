
<div align="center">
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" width="120"/>
</div> <br>

### 📃 Sobre o Projeto
**ScreenSound e uma versão melhorada do app ``MusicPlay``, desenvolvido na linguagem ``CSharp``.** <br>
**Assim como o app ``MusicPlay``, a parte visual do sistema e via ``Terminal``.** <br><br>

### 🔥 Conceitos POO Aplicados ao Projeto

**``🏷️ Namespaces ``** <br>
**Namespaces em ``CSharp`` e uma forma de organizar classes do projeto em pasta, onde pode ser incluidos em outras classes do projeto.**
**Para usar um namespace em outra classe do projeto, use a palavra reseverda ``using``, no começo do arquivo.** 
```CSharp
// Criando namespace
namespace ScreenSound;

class Menu {}

```
```CSharp
using ScreenSound;

class MenuAvaliacao {}
```
<br>

**``🏷️ Herança ``** <br>
**Aplicado a herança entre classes usando `` : `` na linguagem ``CSharp`` para que a classe ``MenuAvaliacao`` herde os membros da classe ``Menu``.**
```CSharp
class Menu {}

class MenuAvaliacao : Menu {}
```
<br>


**``🏷️ Interface ``** <br>
**Define um contrato que qualquer ``classe`` ou ``struct`` que implemente esse contrato, deve fornecer uma implementação dos membros definidos na interface. Por convenção toda interface deve ter a letra ``I`` no nome da interface, deixando explicito que essa estrutura de codigo e uma interface.** <br>
**No projeto foi criado uma interface chamada ``IAvaliavel``, com dois membros definidos ``AdicionarNota`` e ``Media``**

```CSharp
internal interace IAvaliavel 
{
    void AdicionarNota(Avaliacao nota);
    double Media { get; }
}
```

***Assim, todas as classes que implemente essa interface terá um metodo chamando ``AdicionarNota``, porem cada um com sua tratativa de adicionar nota.*** <br><br>


**``🏷️ Metodos Estaticos ``** <br>
**São definidos com a palavra `static`, e pdeom ser chamados na sem a necessidade de criar uma instancia da classe.** </br>
```CSharp
public static Avaliacao Parse(string texto)
{
    int nota = int.Parse(texto);
    return new Avaliacao(nota);
}
```
<br>

**``🏷️ Abstração ``** <br>
**Conceito utilizado para esconder os detalhes e complexidades do codigo e apenas focar nos aspectos essenciais.** <br><br>

**``🏷️ Encapsulamento ``** <br>
**Tecnica de implementar abstração, criar classes e membros com modificadores de acessos apropriados para mostrar ou esconder detalhes do codigo.** </br>
```CSharp
internal class Musica 
{
    public string Nome { get; }
    public int Duracao { get; set; }
}
```

***A classe `Musica` acima contém 02 propriedades publica `Nome` e `Duracao`, a propriedade `Nome` permite apenas verificar os dados, enquanto que a propriedade `Duracao` permite que outras classes posso definir e verificar os dados.*** <br><br>



**``🏷️ Polimorfismo ``** <br>
**Permite que objetos de diferentes classes sejam tratados de maneira uniforme.** </br>
**Permite que seja chamando o mesmo metodo em objetos de classes diferentes, obtendo o comportamentos especificos de cada classe.** </br>
```CSharp
// Classe "Menu"

using ScreenSound.Modelos;
namespace ScreenSound.Menus;

internal class Menu
{
    public virtual void Executar(Dictionary<string, Banda> bandasRegistradas) {}
}
```
```CSharp
// Classe "MenuAvaliarBanda"

using ScreenSound.Modelos;
namespace ScreenSound.Menus;

internal class MenuAvaliarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);

        // codigo ...
    }
}
```
```CSharp
// Classe "MenuAvaliarAlbum"

using ScreenSound.Modelos;
namespace ScreenSound.Menus;

internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);

        // codigo ...
    }
}
```

***Na classe `Menu` foi criado o metodo `Executar()` sem qualquer tipo de comportamento, apenas criado como um metodo `virtual` palavra usada para definir um metodo como abstrato. Porem nas classes `MenuAvaliarBanda` e `MenuAvaliarAlbum` que herdam da classe `Menu`, foi herdado o metodo `Executar()` que será implementado conforme comportamento de cada classe. Usado a palavra reservada `base` para acessar o metodo `Executar()` da classe base `Menu`.*** <br><br>

**``🏷️ Dictionary ``** <br>
**Estrutura de dados que permite associar chaves a valores.**
**Dictionary e definido do namespace `System.Collections.Generic`**
```CSharp
// Program.cs

// Armazenar Bandas
Dictionary<string, Banda> bandasRegistradas = new();

// Armazenar Menu de Opções
Dictionary<int, Menu> opcoes = new();
```

***No arquivo `Program.cs` foi criado um dicionario que permite armazenar as bandas cadastradas na aplicação, e outro dicionario que armazena as opções do menu da aplicação.*** <br><br>

<div align="center">
    :octocat: Feito por Mateus Barros :octocat:
</div>

---
