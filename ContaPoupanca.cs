namespace ExBanco;

public class ContaPoupanca : ContaBancaria
{
    public double TaxaJuros { get; set; }

    public ContaPoupanca(int numeroConta, string titular, double taxaJuros) : base(numeroConta, titular)
    {
        TaxaJuros = taxaJuros;
    }
    public void AplicarJuros()
    {
        Saldo += Saldo * TaxaJuros / 100;
        System.Console.WriteLine($"Juros aplicados. Novo saldo: {Saldo}");
    }
    
}