using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.OO;
using CursoCSharp.Colecoes;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.Api;
using CursoCSharp.TopicosAvancados;


namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
               // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Váriaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternários - Fundamentos", OperadorTernario.Executar},
               // Estruturas de Controle
                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura If/Else - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura If/Else/If - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura For Each - Estruturas de Controle", EstruturaForEach.Executar},
                {"Estrutura Usando Break - Estruturas de Controle", UsandoBreak.Executar},
                {"Estrutura Usando Continue - Estruturas de Controle", UsandoContinue.Executar},
               // Classes e Metodos
                {"Membros- Classes e Metodos", Membros.Executar},
                {"Construtores- Classes e Metodos", Construtores.Executar},
                {"Metodos com Retorno - Classes e Metodos(CALCULADORA)", MetodosComRetorno.Executar},
                {"Metodo Estatico - Classes e Metodos", MetodoEstatico.Executar},
                {"Atributos Estáticos - Classes e Metodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Metodos", DesafioAtributo.Executar},
                {"Params- Classes e Metodos", Params.Executar},
                {"Parâmetros Nomeados- Classes e Metodos", ParametrosNomeados.Executar},
                {"Getters e Setters- Classes e Metodos", GetSet.Executar},
                {"Propriedades - Classes e Metodos", Props.Executar},
                {"Readonly - Classes e Metodos", Readonly.Executar},
                {"Enum - Classes e Metodos", ExemploEnum.Executar},
                {"Struct - Classes e Metodos", ExemploStruct.Executar},
                {"Struct VS Classe - Classes e Metodos", StructVsClasse.Executar},
                {"Atribuição por Valor vs Referência - Classes e Metodos", ValorVsReferencia.Executar},
                {"Parâmetros por Referência - Classes e Metodos", ParametrosPorReferencia.Executar},
                {"Parâmetros com valor Padrão - Classes e Metodos", ParametroPadrao.Executar},
                // Coleções
  
                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"Array List - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecoesStack.Executar},
                {"Dictionary - Coleções", ColecoesDictionary.Executar},
                
                // OO
                
                {"Herança - OO ", Heranca.Executar},
                {"Construtor This - OO ", ConstrutorThis.Executar},
                {"Encapsulamento - OO ", OO.Encapsulamento.Executar},
                {"Polimorfismo - OO ", Polimorfismo.Executar},
                {"Abstract - OO ", Abstract.Executar},
                {"Interface - OO ", Interface.Executar},
                {"Sealed - OO ", Sealed.Executar},

                // Metodos e Funções

                {"Exemplo Lambda - Metodos e Funções ", ExemploLambda.Executar},
                {"Lambdas com Delegates - Metodos e Funções ", LambdasDelegate.Executar},
                {"Usando Delegates - Metodos e Funções ", UsandoDelegate.Executar},
                {"Delegate Fun Anonima - Metodos e Funções ", DelegateFunAnonima.Executar},
                {"Delegate Como Parametros - Metodos e Funções ", DelegatesComParametros.Executar},
                {"Metodos de Extensão - Metodos e Funções ", MetodosDeExtensao.Executar},

                // Exceções

                {"Primeira Exceção - Excessões ", PrimeiraExcecao.Executar},
                {"Excessões Personalizadas - Excessões ", ExcecoesPersonalizadas.Executar},

                // Api

                {"Primeiro Arquivo - Api ", PrimeiroArquivo.Executar},
                {"Lendo Arquivo - Api ", LendoArquivos.Executar},
                {"Exemplo File Info - Api ", ExemploFileInfo.Executar},
                {"Diretórios - Api ", Diretorios.Executar},
                {"Exemplo DirectoryInfo - Api ", ExemploDirectoryInfo.Executar},
                {"Exemplo Path - Api ", ExemploPath.Executar},
                {"Exemplo DateTime - Api ", ExemploDateTime.Executar},
                {"Exemplo TimeSpam - Api ", ExemploTimeSpan.Executar},
                
                //Topicos Avançados

                {"LINQ #1 - Tópicos Avançados ", LINQ1.Executar},
                {"LINQ #2 - Tópicos Avançados ", LINQ2.Executar},
                {"Nullables - Tópicos Avançados ", Nullables.Executar},
                {"Dynamics - Tópicos Avançados ", Dynamics.Executar},
                {"Genéricos - Tópicos Avançados ", Genericos.Executar},
                


            });

            central.SelecionarEExecutar();
        }
    }
}