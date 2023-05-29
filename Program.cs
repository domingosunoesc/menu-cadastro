using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string data_atendimento = "";
        string nome_animal = "";
        string nome_medico = "";

        int choice;
        bool sair = false;

        do
        {
            Console.WriteLine("Menu Principal:");
            Console.WriteLine("1 - Cadastros");
            Console.WriteLine("2 - Relatórios");
            Console.WriteLine("0 - SAIR");
            Console.WriteLine("Escolha uma opção: ");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("Menu de Cadastros:");
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("1 - Médicos");
                        Console.WriteLine("2 - Animais");
                        Console.WriteLine("3 - Atendimentos");
                        Console.WriteLine("4 - Voltar");
                        Console.WriteLine("Escolha uma opção: ");
                        Console.WriteLine("----------------------------");
                        if (int.TryParse(Console.ReadLine(), out choice))
                        {
                            switch (choice)
                            {
                                case 1:
                                    Console.WriteLine("Você escolheu a opção Médicos.");
                                    Console.WriteLine(" Digite o nome do médico");
                                    nome_medico = Console.ReadLine();
                                    Console.WriteLine($"Médico {nome_medico} cadastrado com sucesso");

                                    break;
                                case 2:
                                    Console.WriteLine("Você escolheu a opção Animais.");
                                    Console.WriteLine("Digite o nome do animal");
                                    nome_animal = Console.ReadLine();
                                    Console.WriteLine($"O animal {nome_animal} foi cadastrado com sucesso");

                                    break;
                                case 3:
                                    Console.WriteLine("Você escolheu a opção Atendimentos.");
                                    Console.WriteLine("Digite a data para o atendimento ");
                                    data_atendimento = Console.ReadLine();
                                    Console.WriteLine($"O atendimento do animal {nome_animal} foi marcado para {data_atendimento} com o médico {nome_medico} ");

                                    break;
                                case 4:
                                    Console.WriteLine("Voltando ao menu principal...");
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida.");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida. Digite um número válido.");
                        }
                        break;
                        
                    case 2:
                        Console.WriteLine("Menu de Relatórios:");
                        Console.WriteLine("1 - Animais");
                        Console.WriteLine("2- Atendimentos");
                        Console.WriteLine("3 - Voltar");
                        Console.Write("Escolha uma opção: ");
                        if (int.TryParse(Console.ReadLine(), out choice))
                        {
                            switch (choice)
                            {
                                case 1:
                                    Console.WriteLine("Você escolheu a opção Animais.");
                                    Console.WriteLine("Digite o nome do animal");
                                    nome_animal = Console.ReadLine();
                                    Console.WriteLine($"O animal {nome_animal} foi atendido em {data_atendimento} pelo médico {nome_medico}com sucesso");

                                    break;
                                case 2:
                                    Console.WriteLine("Você escolheu a opção Atendimentos.");
                                    Console.WriteLine("Digite o nome do animal");
                                    nome_animal = Console.ReadLine();
                                    Console.WriteLine($"O animal {nome_animal} foi atendido com sucesso e já está com alta");
                                    break;
                                case 3:
                                    Console.WriteLine("Voltando ao menu principal...");
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida.");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida. Digite um número válido.");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Saindo...");
                        sair = true;
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opção inválida. Digite um número válido.");
            }

            Console.WriteLine();
        } while (!sair);
    }
}