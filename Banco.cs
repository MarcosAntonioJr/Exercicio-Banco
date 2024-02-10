namespace ExBanco;

public class Banco
{
    private List<ContaBancaria> contas = new List<ContaBancaria>();

    public void AdicionarConta(ContaBancaria conta)
    {
        contas.Add(conta);
        Console.WriteLine($"Conta adicionada com sucesso: {conta.Titular}, Número {conta.NumConta}");
    }
    public void ListarContas()
    {
        Console.WriteLine("Lista de contas no banco: ");
        foreach(var conta in contas)
        {
            Console.WriteLine($"Número: {conta.NumConta}, Titular: {conta.Titular}, Saldo: {conta.Saldo}");
        }
    }
    public void ProcessarContas()
    {
        foreach(var conta in contas)
        {
            if(conta is ContaCorrente contaCorrente)
            {
                contaCorrente.DeductTax();
            }
            else if(conta is ContaPoupanca contaPoupanca)
            {
                contaPoupanca.AplicarJuros();
            }
        }
    }
}