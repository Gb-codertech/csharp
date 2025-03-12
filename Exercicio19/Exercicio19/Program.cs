using System;
using System.Collections.Generic;

public class Exercicio19
{
    public static void Main(string[] args)
    {
        Dictionary<String, String> listatelefonica = new Dictionary<String, String>();
        // Váriaveis Globais
        String opcao;

        do
        {
            // Apresentar o menu
            Console.WriteLine("\n1. Adicionar contato:    ");
            Console.WriteLine("2. Pesquisar Contacto:    ");
            Console.WriteLine("3. Remover Contacto:    ");
            Console.WriteLine("4. Sair:    ");

            // Pedir ao utilizador que escolha uma opção
            Console.WriteLine("Escolha uma opção: ");
            // Variável da opção
            opcao = Console.ReadLine();

            // Criar a lógica das opções
            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Nome: ");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Contacto: ");
                    string contacto = Console.ReadLine();

                    listatelefonica.Add(nome, contacto);
                    break;

                case "2":
                    Console.WriteLine("Digite um nome para pesquisar");
                    nome = Console.ReadLine();

                    if (listatelefonica.ContainsKey(nome))  // ContainsKey para pesquisar o nome
                    {
                        Console.WriteLine($"O número de {nome} é {listatelefonica[nome]}");
                    }
                    else
                    {
                        Console.WriteLine("Não existe!");
                    }
                    Console.WriteLine("\n");
                    break;

                case "3":
                    {
                        Console.WriteLine("Digite um nome para remover");
                        nome = Console.ReadLine();

                        if (listatelefonica.ContainsKey(nome))  // Verificar se o nome existe no dicionário
                        {
                            listatelefonica.Remove(nome);  // Remover o nome
                            Console.WriteLine($"Contato {nome} removido com sucesso.");
                        }
                        else
                        {
                            Console.WriteLine("Nome não encontrado! Por favor, adicione um novo nome.");
                            Console.WriteLine("Deseja adicionar um novo contato? (s/n)");
                            string resposta = Console.ReadLine();

                            if (resposta.ToLower() == "s")
                            {
                                Console.WriteLine("Nome: ");
                                nome = Console.ReadLine();

                                Console.WriteLine("Contato: ");
                                string novoContato = Console.ReadLine();

                                listatelefonica.Add(nome, novoContato);
                                Console.WriteLine($"Contato {nome} adicionado com sucesso.");
                            }
                        }
                    }
                    Console.WriteLine("\n");
                    break;

                case "4":
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        } while (opcao != "4");   
    }
}