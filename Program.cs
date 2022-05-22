// See https://aka.ms/new-console-template for more information

using UC9_Senai_EncodingBackEnd_SA2.Classes;
using UC9_Senai_EncodingBackEnd_SA2.Extensions;

var customer = new Customizacao();
// *************************************************************************************************************** //
// Criar uma apresentação. Para isso, um loop
for (int i = 0; i < 70; i++)
{
    Console.Write("-");
} // Primeira linha
Console.WriteLine();
Console.WriteLine();
"BEM-VINDOS(AS) AO SISTEMA DE CADASTRO DE PESSOA FÍSICA E JURÍDICA".WriteLine(ConsoleColor.Green);
Console.WriteLine();
Console.WriteLine();
// Loop que finaliza a primeira apresentação
for (int i = 0; i < 70; i++)
{
    Console.Write("-");
} // Segunda linha
  // *************************************************************************************************************** //
Console.WriteLine();
Console.WriteLine();
customer.BarraCarregamento("Carregando", 300);
Console.Clear();
// Fim apresentação


// *************************************************************************************************************** //

// Criação de duas listas. Uma para Pessoa Jurídica e outra para Pessoa Física
List<PessoaFisica> listaPessoaFisica = new List<PessoaFisica>();
List<PessoaJuridica> listaPessoaJuridica = new List<PessoaJuridica>();

// Variável fora do loop receber a opção escolhida do usuário
string opcaoEscolhaCategoria;

// ******************** Menu para apresentar as opções para a escolha da Categoria ******************** //
do
{

    "Escolha uma das opções abaixo: ".WriteLine(ConsoleColor.Gray);
    Console.WriteLine();

    "\n1 - PESSOA FÍSICA".WriteLine(ConsoleColor.Blue);
    "\n2 - PESSOA JURÍDICA".WriteLine(ConsoleColor.Blue);
    "\n0 - SAIR".WriteLine(ConsoleColor.Blue);

    opcaoEscolhaCategoria = Console.ReadLine();

    // ********* Switch case para execução de códigos conforme a escolha do usuário do primeiro MENU ************ //
    switch (opcaoEscolhaCategoria)
    {
        case "1":
            // Criar dois objetos de Pessoa Física
            var metodoPessoaFisica = new PessoaFisica();
            var novoCadastroPessoaFisica = new PessoaFisica();
            // Crir um objeto de Endereço
            var enderecoPessoaFisica = new Endereco();

            // Variável para receber a opção do SEGUNDO MENU da CATEGORIA ESCOLHIDA PESSOA FÍSICA
            string opcaoCategoriaPessoaFisica;
            string opcaoCategoriaPessoaJuridica;

            // ******************** SubMenu da CATEGORIA PESSOA FÍSICA ******************** //
            do
            {
                // Limpar para ficar organizado
                Console.Clear();
                // Criar uma apresentação do submenu. Para isso, um loop
                for (int i = 0; i < 70; i++)
                {
                    Console.Write("-");
                } // Primeira linha
                Console.WriteLine();
                Console.WriteLine();
                "ESPAÇO PESSOA FÍSICA".WriteLine(ConsoleColor.Green);
                "\nESCOLHA UMA DAS OPÇÕES ABAIXO".WriteLine(ConsoleColor.Green);
                Console.WriteLine();
                Console.WriteLine();
                // Loop que finaliza a primeira apresentação
                for (int i = 0; i < 70; i++)
                {
                    Console.Write("-");
                } // Segunda linha
                  // *************************************************************************************************************** //
                Console.WriteLine();
                Console.WriteLine();
                
                // Fim apresentação

                Console.WriteLine();
                Console.WriteLine();

                "\n1 - CADASTRAR PESSOA FÍSICA".WriteLine(ConsoleColor.Blue);
                "\n2 - CONSULTAR CADASTRO PESSOA JURÍDICA".WriteLine(ConsoleColor.Blue);
                "\n0 - VOLTAR AO MENU ANTERIOR".WriteLine(ConsoleColor.Blue);

                opcaoCategoriaPessoaFisica = Console.ReadLine();
          

                // Criação de variável para receber o resultado da validação cpf
                bool cpfValidado = false;
                // Criação de variável para receber o resultado da validação Data de nascimento
                bool dataNascimentoValidada = false;


                // ********* Switch case para execução de códigos conforme a escolha do usuário do segundo (submenu) MENU ************ //
                switch (opcaoCategoriaPessoaFisica)
                {
                    case "1":
                        // Limpar para ficar organizado
                        Console.Clear();
                        "\nCADASTRO DE PESSOA FÍSICA ESCOLHIDO".WriteLine(ConsoleColor.Yellow);
                        "\nPREENCHA SEUS DADOS PARA CONCLUIR O CADASTRO!".WriteLine(ConsoleColor.Blue);
                        "\nAperte Enter para continuar!".WriteLine(ConsoleColor.White);
                        Console.ReadKey(true);
                        customer.BarraCarregamento("Carregando", 300);
                        // Limpar para ficar organizado
                        Console.Clear();

                    // **** Loop 'do while' para a estrura de validação do CPF **** //
                    do
                        {
                            Console.Write("\nCPF: ");
                            string cpf = Console.ReadLine();
                            cpfValidado = novoCadastroPessoaFisica.ValidarCpf(cpf);
                            // Condicional para atribuir à propriedade do objeto já com o cpf validado corretamente
                            if (cpfValidado)
                            {
                                novoCadastroPessoaFisica.CPF = cpf;
                            }
                        }
                    while (cpfValidado == false);
                        // **** Loop 'do while' para a estrura de validação do CPF **** //

                        // Limpar para ficar organizado
                        Console.Clear();
                        Console.Write($"\nCPF: {novoCadastroPessoaFisica.CPF} validado com sucesso!\n");

                        // Continuação do preenchimento dos dados
                        Console.Write("\nNome: ");
                        novoCadastroPessoaFisica.Nome = Console.ReadLine();
                        Console.Write("\nSobrenome: ");
                        novoCadastroPessoaFisica.Sobrenome = Console.ReadLine();


                        // **** Loop 'do while' para a estrura de validação Data de nascimento **** //
                        do
                        {
                            Console.WriteLine("\nData de nascimento: ");
                            string nascimento = Console.ReadLine();
                            dataNascimentoValidada = metodoPessoaFisica.ValidarDataNascimento(nascimento);

                            // Condicional para atribuir à propriedade do objeto já com a data de nascimento validada corretamente
                            if (dataNascimentoValidada)
                            {
                                novoCadastroPessoaFisica.DataNascimento = nascimento;
                            }
                        }
                        while (dataNascimentoValidada == false);
                        // **** Loop 'do while' para a estrura de validação Data de nascimento **** //

                        // Continuação do preenchimento dos dados
                        Console.WriteLine("\n Espaço do Endereço.  ");
                        Console.Write("\nRua:  ");
                        enderecoPessoaFisica.NomeRua = Console.ReadLine();
                        Console.Write("\nNumero: ");
                        enderecoPessoaFisica.NumeroCasa = int.Parse(Console.ReadLine());
                        Console.Write("\nComplemento: ");
                        enderecoPessoaFisica.Complemento = Console.ReadLine();
                        // Estrura para endereço caso comercial
                        Console.Write("\nEndereço comercial? Digite \"S\" para sim e \"N\" para não! . ");
                        string tipoEndereco = Console.ReadLine().ToUpper();

                        // Condicional para testar tipo de endereço
                        if (tipoEndereco != "S" || tipoEndereco != "N")
                        {
                            if (tipoEndereco == "S")
                            {
                                enderecoPessoaFisica.Comercial = true;
                                Console.WriteLine("\nEndereço Comercial!");
                            }
                            else
                            {
                                enderecoPessoaFisica.Comercial = false;
                                Console.WriteLine("\nEndereço Residencial!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nDigite apenas \"S\" para sim e \"N\" para não!!");
                        }
                        // Condicional para testar tipo de endereço

                        // Atribuindo o objeto enderecoPessoaFisica ao objeto novoCadastroPessoaFisica
                        novoCadastroPessoaFisica.Endereco = enderecoPessoaFisica;

                        Console.Write("\nRemuneração mensal: ");
                        novoCadastroPessoaFisica.Remuneracao = decimal.Parse(Console.ReadLine());

                        // Adicionando o objeto novoCadastroPessoaFisica à lista
                        listaPessoaFisica.Add(metodoPessoaFisica);


                        // ******** Espaço para gravar em arquivo ************* //
                        using (StreamWriter escrever = new StreamWriter($"{novoCadastroPessoaFisica.Nome}.txt"))
                        {
                            escrever.WriteLine(novoCadastroPessoaFisica.Nome);
                        }

                        // Finalização do cadastro
                        "Cadastro realizado com sucesso!".WriteLine(ConsoleColor.Green);

                        break;
                    case "2":
                        // Acrescentar um foreach para listar Pessoa Física
                        break;
                    case "0":
                        break;
                    default:
                        Console.Clear();
                        "Opção Inválida!".WriteLine(ConsoleColor.DarkRed);
                        Thread.Sleep(2000);
                        break;
                }
            }
            while (opcaoCategoriaPessoaFisica != "0");
            // Fim do 'do while' do submenu de Pessoa Física //

            break;
        case "2":

            // ***************** Submenu CATEGORIA PESSOA JURÍDICA ************* //
            do
            {
                // Limpar para ficar organizado
                Console.Clear();
                // Criar uma apresentação do submenu. Para isso, um loop
                for (int i = 0; i < 70; i++)
                {
                    Console.Write("-");
                } // Primeira linha
                Console.WriteLine();
                Console.WriteLine();
                "ESPAÇO PESSOA JURÍDICA".WriteLine(ConsoleColor.Green);
                "\nESCOLHA UMA DAS OPÇÕES ABAIXO".WriteLine(ConsoleColor.Green);
                Console.WriteLine();
                Console.WriteLine();
                // Loop que finaliza a primeira apresentação
                for (int i = 0; i < 70; i++)
                {
                    Console.Write("-");
                } // Segunda linha
                  // *************************************************************************************************************** //
                Console.WriteLine();
                Console.WriteLine();

                // Fim apresentação

                Console.WriteLine();
                Console.WriteLine();

                "\n1 - CADASTRAR PESSOA JURÍDICA".WriteLine(ConsoleColor.Blue);
                "\n2 - CONSULTAR CADASTRO PESSOA JURÍDICA".WriteLine(ConsoleColor.Blue);
                "\n0 - VOLTAR AO MENU ANTERIOR".WriteLine(ConsoleColor.Blue);

                opcaoCategoriaPessoaJuridica = Console.ReadLine();
                bool cnpjValidado = false;

                // Switch case para execução do código conforme a opção escolhido pelo usuário
                switch (opcaoCategoriaPessoaJuridica)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "0":
                    default:
                        Console.Clear();
                        "Opção Inválida!".WriteLine(ConsoleColor.DarkRed);
                        Thread.Sleep(2000);
                        break;
                } // ***************** Switch case de pessoa jurídica ************* //


            }
            while (opcaoCategoriaPessoaJuridica != "0");
            // ***************** Submenu CATEGORIA PESSOA JURÍDICA ************* //

            break;
        case "0":
            break;
        default:
            Console.Clear();
            "Opção Inválida!".WriteLine(ConsoleColor.DarkRed);
            Thread.Sleep(2000);
            break;
    } // ********* Switch case para execução de códigos conforme a escolha do usuário do primeiro MENU ************ //


    



} 
while (opcaoEscolhaCategoria != "0");
