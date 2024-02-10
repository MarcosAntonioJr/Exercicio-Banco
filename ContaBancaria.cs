namespace ExBanco;

public class ContaBancaria
{
    public int NumConta { get; set; }
    public string Titular { get; set; }
    public double Saldo { get; set; }

    public ContaBancaria(int numeroConta, string titular)
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
    public virtual void Sacar(double valor)
    {
        if(valor > 0)
        {
            if(Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor} realizado. Novo saldo: {Saldo}");
            }
            else
            {
                System.Console.WriteLine("Saldo insuficiente.");
            }
        }
        else
        {
            System.Console.WriteLine("O valor do saque deve ser maior que zero.");
        }
    }
} 