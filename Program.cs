namespace ExBanco
{
        public class Program
    {
        static void Main()
        {
            Banco banco = new Banco();

            ContaCorrente contaCorrente = new ContaCorrente(1, "Marcos", 5.0);
            ContaPoupanca contaPoupanca = new ContaPoupanca(2, "Junior", 2.5);

            banco.AdicionarConta(contaCorrente);
            banco.AdicionarConta(contaPoupanca);

            contaCorrente.Depositar(1000);
            contaCorrente.Sacar(50);

            contaPoupanca.Depositar(500);
            contaPoupanca.Sacar(50);

            banco.ProcessarContas();
            banco.ListaContas();
        }
    }
}
