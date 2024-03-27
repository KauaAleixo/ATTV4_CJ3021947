Console.WriteLine("escolha um programa: \n pagamento");
int atv = int.Parse(Console.ReadLine());
switch
    (atv)
{
    case 1:

        //att1

        Console.WriteLine("escolha um tipo de operação: \n 1 - débito \n 2 - crédito \n 3 - pix \n 4 - boleto \n 5 - transferência bancária ");

        int opç = int.Parse(Console.ReadLine());

        switch (opç)

        {
            case 1:
                Console.WriteLine("o pagamento será efetuado em débito");
                break;
            case 2:
                Console.WriteLine("o pagamento será efetuado em crédito");
                Console.WriteLine("haverá um acrécimo de 5%");
                break;
            case 3:
                Console.WriteLine("o pagamento será efetuado em pix");
                Console.WriteLine("haverá um de descconto de 5%");
                break;
            case 4:
                Console.WriteLine("o pagamento será efetuado em boleto");
                Console.WriteLine("haverá um acrécimo de 5%");
                break;
            case 5:
                Console.WriteLine("o pagamento será feito em transferência bancária");
                break;


        }
        break;

    case 2:

        //att3
        Console.WriteLine("digite um numero de 1 a 7 ");

        int n = int.Parse(Console.ReadLine());

        switch (n)
        {

            case 1:
                Console.WriteLine("domingo");

                break;
            case 2:
                Console.WriteLine("segunda");

                break;

            case 3:
                Console.WriteLine("terça");

                break;

            case 4:
                Console.WriteLine("quarta");

                break;

            case 5:
                Console.WriteLine("quinta");

                break;

            case 6:
                Console.WriteLine("sexta");

                break;

            case 7:
                Console.WriteLine("sabádo");
                break;

        }
        break;

        //att3
        Console.WriteLine("Digite o valor total da compra: ");
        int tot = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite uma opção válida: \n 1 - Dinheiro \n 2 - Pix \n 3 - Débito \n 4 - Crédito");
        int opc1 = int.Parse(Console.ReadLine());

        switch (opc1)
        {
            case 1:
                Console.WriteLine("Você terá direito a um desconto de 15%");
                Console.WriteLine("O sub-total será de: {0}", (tot - tot * 0.15));
                break;
            case 2:
                Console.WriteLine("Você terá direito a um desconto de 5%");
                Console.WriteLine("O sub-total será de: {0}", (tot - tot * 0.10));
                break;
            case 3:
                Console.WriteLine("Você terá um acréscimo de 5%");
                Console.WriteLine("O sub-total será de: {0}", (tot + tot * 0.5));
                break;
            case 4:
                Console.WriteLine("Você terá um acréscimo de 10%");
                Console.WriteLine("O sub-total será de: {0}", (tot + tot * 0.10));
                break;
        }
        break;

        //att4
        int opc3, ano;

        Console.WriteLine("digite o ano: ");
        ano = int.Parse(Console.ReadLine());
        Console.WriteLine("digite um número de 1 a 12 referente a um mês do ano: ");
        opc3 = int.Parse(Console.ReadLine());

        switch (opc3)
        {
            case 1:
                Console.WriteLine("o mês de janeiro tem 31 dias");
                break;
            case 2:
                Console.WriteLine("Qual é o ano: ");
                ano = int.Parse(Console.ReadLine());
                if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0)
                {
                    Console.WriteLine("O mês é fevereiro e tem 29 dias,pois, o ano é bissexto");
                    break;
                }
                else
                {
                    Console.WriteLine("O mês é fevereiro e tem 28 dias");
                    break;
                }
            case 3:
                Console.WriteLine("O mês de março tem 31 dias.");
                break;
            case 4:
                Console.WriteLine("O mês de abril tem 30 dias.");
                break;
            case 5:
                Console.WriteLine("O mês de maio tem 31 dias.");
                break;
            case 6:
                Console.WriteLine("O mês de junho tem 30 dias.");
                break;
            case 7:
                Console.WriteLine("O mês de julho tem 31 dias.");
                break;
            case 8:
                Console.WriteLine("O mês de agosto tem 31 dias.");
                break;
            case 9:
                Console.WriteLine("O mês de setembro tem 30 dias.");
                break;
            case 10:
                Console.WriteLine("O mês de outubro tem 31 dias.");
                break;
            case 11:
                Console.WriteLine("O mês de novembro tem 30 dias.");
                break;
            case 12:
                Console.WriteLine("O mês de dezembro tem 31 dias.");
                break;
            default:
                Console.WriteLine("opção inválida");
                break;
        }

        //att5
        float x, y, res;
        int opc4;

        Console.WriteLine("vamos fazer uma calculadora! \n");
        Console.WriteLine("digite um valor: ");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("digite outro valor: ");
        y = int.Parse(Console.ReadLine());
        Console.WriteLine("escolha a operação: \n 1-adição \n 2-subtração \n 3-multiplicação \n 4-divisão \n 5-potência");
        opç = int.Parse(Console.ReadLine());

        switch (opç)
        {
            case 1:
                Console.WriteLine("você escolheu adição.");
                res = x + y;
                Console.WriteLine("o resultado é: {0}", res);
                break;

            case 2:
                Console.WriteLine("você escolheu subtração.");
                res = x - y;
                Console.WriteLine("o resultado é : {0} ", res);
                break;

            case 3:
                Console.WriteLine("você escolheu multiplicação.");
                res = x * y;
                Console.WriteLine("o resultado é: {0} ", res);
                break;

            case 4:
                Console.WriteLine("você escolheu divisão.");
                res = x / y;
                Console.WriteLine("o resultado é: {0} ", res);
                break;

            case 5:
                Console.WriteLine("você escolheu potência.");
                res = x / y;
                Console.WriteLine("o resultado é: {0} ", res);
                break;

            default:
                Console.WriteLine("opção inválida");
                break;
        }

        // att6

        int codigo;
        float salario, novo_salario;

        Console.WriteLine("Digite o valor do seu sálario: ");
        salario = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o codigo do seu cargo:\nProfessor - 101\nSecretário - 102\nPublicitário - 103\nJornalista - 204\nMecânico - 206\nEstagiário - 301\nTécnico de TI - 302");
        codigo = int.Parse(Console.ReadLine());

        switch (codigo)
        {
            case 101:
                novo_salario = salario + (salario * 0.75f);
                Console.WriteLine("Novo Salário = {0}", novo_salario);
                break;
            case 102:
                novo_salario = salario + (salario * 0.97f);
                Console.WriteLine("Novo Salário = {0}", novo_salario);
                break;
            case 103:
                novo_salario = salario + (salario * 1.17f);
                Console.WriteLine("Novo Salário = {0}", novo_salario);
                break;
            case 204:
                novo_salario = salario + (salario * 0.89f);
                Console.WriteLine("Novo Salário = {0}", novo_salario);
                break;
            case 206:
                novo_salario = salario + (salario * 1.324f);
                Console.WriteLine("Novo Salário = {0}", novo_salario);
                break;
            case 301:
                novo_salario = salario + (salario * 1.04f);
                Console.WriteLine("Novo Salário = {0}", novo_salario);
                break;
            case 302:
                novo_salario = salario + (salario * 1.46f);
                Console.WriteLine("Novo Salário = {0}", novo_salario);
                break;
            default:
                novo_salario = salario + (salario * 4.35f);
                Console.WriteLine("Novo Salário = {0}", novo_salario);
                break;
        }

        //att7


        float sal;
        int opc6;

        Console.WriteLine("**digite o número referente ao seu salário** \n 1-Até R$ 1.903,98 \n 2-Entre R$ 1.903,99 e R$ 2.826,65 \n 3-Entre R$ 2.826,66 e R$ 3.751,05 \n 4-Entre R$ 3.751,06 e R$ 4.664,6 \n 5- Acima de R$ 4.664,68");
        opc6 = int.Parse(Console.ReadLine());

        switch (opc6)
        {
            case 1:
                Console.WriteLine("você está isento de imposto");
                break;
            case 2:
                sal = opc6 - (opc6 * 0.075f);
                Console.WriteLine("seu salário será: {0}", sal);
                break;
            case 3:
                sal = opc6 - (opc6 * 0.15f);
                Console.WriteLine("seu salário será: {0}", sal);
                break;
            case 4:
                sal = opc6 - (opc6 * 0.225f);
                Console.WriteLine("seu salário será: {0}", sal);
                break;
            case 5:
                sal = opc6 - (opc6 * 0.275f);
                Console.WriteLine("seu salário será: {0}", sal);
                break;
        }

}   