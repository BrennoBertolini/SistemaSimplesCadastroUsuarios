using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> usuarios = new List<string>();
        int opcao;

        do
        {
            Console.WriteLine("=== Sistema de Cadastro ===");
            Console.WriteLine("1 - Adicionar usuário");
            Console.WriteLine("2 - Listar usuários");
            Console.WriteLine("3 - Atualizar usuário");
            Console.WriteLine("4 - Excluir usuário");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o nome do usuário: ");
                    string nome = Console.ReadLine();
                    usuarios.Add(nome);
                    Console.WriteLine("Usuário cadastrado com sucesso!\n");
                    break;

                case 2:
                    Console.WriteLine("\n=== Usuários cadastrados ===");
                    if (usuarios.Count == 0)
                    {
                        Console.WriteLine("Nenhum usuário cadastrado.\n");
                    }
                    else
                    {
                        for (int i = 0; i < usuarios.Count; i++)
                        {
                            Console.WriteLine($"{i} - {usuarios[i]}");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 3:
                    Console.Write("Digite o ID do usuário para atualizar: ");
                    int idAtualizar = int.Parse(Console.ReadLine());

                    if (idAtualizar >= 0 && idAtualizar < usuarios.Count)
                    {
                        Console.Write("Digite o novo nome: ");
                        string novoNome = Console.ReadLine();
                        usuarios[idAtualizar] = novoNome;
                        Console.WriteLine("Usuário atualizado com sucesso!\n");
                    }
                    else
                    {
                        Console.WriteLine("ID inválido!\n");
                    }
                    break;

                case 4:
                    Console.Write("Digite o ID do usuário para excluir: ");
                    int idExcluir = int.Parse(Console.ReadLine());

                    if (idExcluir >= 0 && idExcluir < usuarios.Count)
                    {
                        usuarios.RemoveAt(idExcluir);
                        Console.WriteLine("Usuário excluído com sucesso!\n");
                    }
                    else
                    {
                        Console.WriteLine("ID inválido!\n");
                    }
                    break;
            }

        } while (opcao != 0);

        Console.WriteLine("Sistema encerrado.");
    }
}
