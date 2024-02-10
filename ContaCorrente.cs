namespace ExBanco;

public class ContaCorrente : ContaBancaria
{
    public double TaxaOperacao {get;}

    public ContaCorrente(int numeroConta, string titular, double taxaOperacao) : base(numeroConta, titular)
    {
        TaxaOperacao = taxaOperacao;
    }

    public void DeductTax()
    {
        Saldo -= TaxaOperacao;
        Console.WriteLine($"Taxa de operação deduzida. Novo saldo: {Saldo}");
    }

    public override void Sacar(double valor)
    {
        double totalParaSacar = valor += TaxaOperacao;
        ProcessarSaque(totalParaSacar);
    }
    private void ProcessarSaque(double valor)
    {
        if (valor > 0)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque realizado. Novo saldo: {Saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }
        else
        {
            Console.WriteLine("O valor do saque deve ser maior que zero.");
        }
    }
}