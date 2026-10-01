# 🎮 GamerProfile - Gerenciamento de Perfil de Jogadores

![.NET Standard](https://img.shields.io/badge/.NET-10.0-512BD4?style=for-the-badge&logo=dotnet)
![xUnit](https://img.shields.io/badge/Testes-xUnit-blue?style=for-the-badge)
![Status](https://img.shields.io/badge/Status-Conclu%C3%ADdo-brightgreen?style=for-the-badge)

Projeto desenvolvido como atividade prática para a disciplina de **Gestão e Qualidade de Software** (Prof. Daniel Henrique Matos de Paiva). O objetivo é demonstrar a criação e organização de uma solução em **.NET 10** via **.NET CLI**, combinando código de produção com testes unitários no **xUnit**.

---

## 📌 Funcionalidades

A classe `PerfilJogadorService` disponibiliza três regras de negócio principais:

1. **`GerarTagUsuario(string apelido, string codigo)`** (`string`): Concatena o apelido do jogador e o código identificador no formato `Nickname#Codigo`.
2. **`CalcularXPTotal(int xpFase1, int xpFase2)`** (`int`): Soma os pontos de experiência das fases 1 e 2, aplicando um bônus fixo de **100 pontos**.
3. **`EEligivelParaRanked(int nivelJogador)`** (`bool`): Verifica se o jogador possui nível suficiente ($\ge 15$) para acessar partidas ranqueadas.

---

## 🛠️ Tecnologias Utilizadas

- **C# / .NET 10**
- **xUnit** (Framework de Testes Unitários)
- **.NET CLI** (Criação de projetos e execução de testes via terminal)

---

## 🚀 Como executar o projeto

### Pré-requisitos
- [SDK do .NET 10](https://dotnet.microsoft.com/download) instalado.

### 1. Clonar o Repositório
```bash
git clone https://github.com/SEU-USUARIO/GamerProfile.git
cd GamerProfile
```

### 2. Estrutura da Solução (Criada via CLI)
Caso deseje recriar a estrutura do zero pelo terminal:

```bash
# 1. Cria a Solução
dotnet novo sln -n Perfil de Jogador

# 2. Crie o projeto da aplicação
dotnet new console -n GamerProfile.App -f net10.0

# 3. Crie o projeto de Testes Unitários com xUnit
dotnet new xunit -n GamerProfile.Tests -f net10.0

# 4. Adiciona ambos os projetos à Solução
dotnet sln add GamerProfile.App/GamerProfile.App.csproj
dotnet sln add GamerProfile.Tests/GamerProfile.Tests.csproj

# 5. Adicionada a referência do projeto de Produção no projeto de Testes
dotnet add GamerProfile.Tests/GamerProfile.Tests.csproj reference GamerProfile.App/GamerProfile.App.csproj
```

---

## 🧪 Executando os Testes Unitários

Para rodar um conjunto de testes e validar a qualidade do código com `Assert.Equal`, `Assert.True` e `Assert.False`:

```bash
dotnet test 
```

### Casos de Teste Cobertos:
- ✅ **Geração de Tag:** Confirme a formatação no padrão `"Aragorn#1042"`.
- ✅ **Cálculo de XP:** Valida se a soma das fases mais o bônus de 100 gera o resultado esperado (ex: $200 + 300 + 100 = 600$).
- ✅ **Elegibilidade Classificada:**
  - `Assert.True` para jogadores com nível $\ge 15$.
  - `Assert.False` para jogadores com nível $< 15$.

---

## 📂 Estrutura de Arquivos

```text
Perfil do jogador/
├── GamerProfile.sln
├── GamerProfile.App/
│ ├── GamerProfile.App.csproj
│ ├── Program.cs
│ └── PerfilJogadorService.cs
└── GamerProfile.Tests/
    ├── GamerProfile.Tests.csproj
    └── PerfilJogadorServiceTests.cs
```