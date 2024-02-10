namespace ExBanco;

public abstract class ContaBancaria
{
    public int NumConta { get; set; }
    public string Titular { get; set; }
    public double Saldo { get; set; }

    protected ContaBancaria(int numeroConta, string titular)
    {
        NumConta = numeroConta;
        Titular = titular;
        Saldo = 0.0;
    }
    public void Depositar(double valor)
    {
        if(valor > 0)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de {valor} realizado. Novo saldo: {Saldo}");
        }
        else
        {
            Console.WriteLine("O valor do depósito deve ser maior que zero.");
        }
    }
    public abstract void Sacar(double valor);
} 