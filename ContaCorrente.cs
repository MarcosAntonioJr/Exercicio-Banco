namespace ExBanco;

public class ContaCorrente : ContaBancaria
{
    public double TaxaOperacao {get; set;}

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
        base.Sacar(valor + TaxaOperacao);
    }
}