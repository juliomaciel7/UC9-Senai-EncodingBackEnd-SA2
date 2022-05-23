// See https://aka.ms/new-console-template for more information

using UC9_Senai_EncodingBackEnd_SA2.Classes;
using UC9_Senai_EncodingBackEnd_SA2.Extensions;
// Criação de duas listas. Uma para Pessoa Jurídica e outra para Pessoa Física
List<PessoaFisica> listaPessoaFisica = new List<PessoaFisica>();
List<PessoaJuridica> listaPessoaJuridica = new List<PessoaJuridica>();

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
                "\n2 - CONSULTAR CADASTRO PESSOA FÍSICA".WriteLine(ConsoleColor.Blue);
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
                            Console.WriteLine("\nDigite \"S\" para sim e \"N\" para não!!");
                        }
                        // Condicional para testar tipo de endereço

                        // Atribuindo o objeto enderecoPessoaFisica ao objeto novoCadastroPessoaFisica
                        novoCadastroPessoaFisica.Endereco = enderecoPessoaFisica;

                        Console.Write("\nRemuneração mensal: ");
                        novoCadastroPessoaFisica.Remuneracao = decimal.Parse(Console.ReadLine());

                        // Adicionando o objeto novoCadastroPessoaFisica à lista
                        listaPessoaFisica.Add(novoCadastroPessoaFisica);

                        // Finalização do cadastro
                        "Cadastro realizado com sucesso!".WriteLine(ConsoleColor.Green);
                        Thread.Sleep(3000);


                        // ******** Espaço para gravar em arquivo ************* //
                        //using (StreamWriter escrever = new StreamWriter($"{novoCadastroPessoaFisica.Nome}.txt"))
                        //{
                        //    escrever.WriteLine(novoCadastroPessoaFisica.Nome);
                        //}

                        break;
                    case "2":
                        Console.Clear();
                        if (listaPessoaFisica.Count > 0)
                        {
                            foreach (PessoaFisica apresentacaoPessoaFisica in listaPessoaFisica)
                            {
                                
                                Console.WriteLine(@$"
                                    CPF: {apresentacaoPessoaFisica.CPF}
                                    Nome: {apresentacaoPessoaFisica.Nome}
                                    Sobrenome:{apresentacaoPessoaFisica.Sobrenome}
                                    Data de nascimento: {apresentacaoPessoaFisica.DataNascimento}
                                    Endereço
                                    Rua: {apresentacaoPessoaFisica.Endereco.NomeRua}
                                    Nº: {apresentacaoPessoaFisica.Endereco.NumeroCasa}
                                    Complemento: {apresentacaoPessoaFisica.Endereco.Complemento}
                                    Tipo de endereço: {apresentacaoPessoaFisica.Endereco.Comercial}
                                    Remuneração mensal: {apresentacaoPessoaFisica.Remuneracao}
                                    Imposto a se pagar: {apresentacaoPessoaFisica.PagarImposto(apresentacaoPessoaFisica.Remuneracao).ToString("C")}
                                    ");
                                Console.WriteLine("Aperte Enter para continuar");
                                Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Lista Vazia!");
                            Thread.Sleep(3000);

                        }

                        break;
                    case "0":
                        Console.Clear();
                        customer.BarraCarregamento("Aguarde", 300);
                        Console.Clear();
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
                        // Primeira Instância de Pessoa Jurídica 
                        var metodoPessoaJuridica = new PessoaJuridica();
                        // Segundo instância de Pessoa Jurídica
                        var novoCadastroPessoaJuridica = new PessoaJuridica();
                        // Instância Endereço
                        var enderecoPessoaJuridica = new Endereco();



                        // Limpar para ficar organizado
                        Console.Clear();
                        "\nCADASTRO DE PESSOA FÍSICA ESCOLHIDO".WriteLine(ConsoleColor.Yellow);
                        "\nPREENCHA SEUS DADOS PARA CONCLUIR O CADASTRO!".WriteLine(ConsoleColor.Blue);
                        "\nAperte Enter para continuar!".WriteLine(ConsoleColor.White);
                        Console.ReadKey(true);
                        customer.BarraCarregamento("Carregando", 300);
                        // Limpar para ficar organizado
                        Console.Clear();

                        // ***** Loop para estrutura de validação de cnpj ****** //
                        do
                        {
                            Console.Write("\nCNPJ: ");
                            string cnpj = Console.ReadLine();
                            cnpjValidado = novoCadastroPessoaJuridica.ValidarCnpj(cnpj);
                            // Condicional para atribuir á propriedade do objeto já com o cnpj validado
                            if (cnpjValidado)
                            {
                                novoCadastroPessoaJuridica.CNPJ = cnpj;
                            }
                        }
                        while (cnpjValidado == false);
                        // ***** Loop para estrutura de validação de cnpj ****** //


                        // Limpar para ficar organizado
                        Console.Clear();
                        Console.Write($"\nCNPJ: {novoCadastroPessoaJuridica.CNPJ} validado com sucesso!\n");


                        // Continuação do preenchimento
                        Console.Write("\nNome: ");
                        novoCadastroPessoaJuridica.Nome = Console.ReadLine();
                        Console.Write("\nSobrenome: ");
                        novoCadastroPessoaJuridica.Sobrenome = Console.ReadLine();
                        Console.Write("\nRazão Social: ");
                        novoCadastroPessoaJuridica.RazaoSocial = Console.ReadLine();
                        Console.Write("\nNome Fantasia: ");
                        novoCadastroPessoaJuridica.NomeFantasia = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Espaço endereço");
                        Console.Write("\nRua: ");
                        enderecoPessoaJuridica.NomeRua = Console.ReadLine();
                        Console.Write("\nNúmero: ");
                        enderecoPessoaJuridica.NumeroCasa = int.Parse(Console.ReadLine());
                        Console.Write("\nComplemento: ");
                        enderecoPessoaJuridica.Complemento = Console.ReadLine();
                        Console.Write("\nEndereço Comercial? Digite  Digite \"S\" para sim e \"N\" para não!!");
                        string tipoEnderecoPessoaJuridica = Console.ReadLine().ToUpper(); 

                        // Condicional para averiguar a entrada do tipo de endereço
                        if (tipoEnderecoPessoaJuridica != "S" || tipoEnderecoPessoaJuridica != "N")
                        {
                            if (tipoEnderecoPessoaJuridica == "S")
                            {
                                enderecoPessoaJuridica.Comercial = true;
                                Console.WriteLine("\nEndereço Comercial!");
                            }
                            else
                            {
                                enderecoPessoaJuridica.Comercial = false;
                                Console.WriteLine("\nEndereço Residencial!");
                            }
                        }
                        else
                        {
                            "\nDigite \"S\" para sim e \"N\" para não!!".WriteLine(ConsoleColor.DarkRed);
                        }
                        // Condicional para averiguar a entrada do tipo de endereço


                        // Atribuição do objeto endereço Pessoa Jurídica ao novoCadastroPessoaJuridica
                        novoCadastroPessoaJuridica.Endereco = enderecoPessoaJuridica;


                        Console.WriteLine("\nRemuneração ou lucro mensal:!");
                        novoCadastroPessoaJuridica.Remuneracao = decimal.Parse(Console.ReadLine());


                        // Adiconando à lista de Pessoa Jurídica
                        listaPessoaJuridica.Add(novoCadastroPessoaJuridica);



                        "Cadastro realizado com sucesso!".WriteLine(ConsoleColor.Green);
                        customer.BarraCarregamento("Aguarde um pouco", 300);

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
// ********************************************************************************************************************************* //
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
