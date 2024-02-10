#Exercicio-Banco
#Explicando o código

1. Classes Principais:
ContaBancaria: Classe abstrata que serve como uma base genérica para diferentes tipos de contas bancárias. Possui atributos como NumConta (número da conta), Titular (nome do titular) e Saldo (saldo disponível). Contém métodos como Depositar para adicionar dinheiro à conta e Sacar (abstrato) para retirar dinheiro, sendo esse método abstrato, exigindo implementação nas classes derivadas.

ContaCorrente: Classe que herda de ContaBancaria. Além dos atributos da classe base, possui um atributo adicional TaxaOperacao representando a taxa cobrada em operações. Implementa o método Sacar sobrescrevendo o método abstrato da classe base para considerar a taxa de operação.

ContaPoupanca: Classe que herda de ContaBancaria. Similar à ContaCorrente, possui um atributo adicional TaxaJuros representando a taxa de juros a ser aplicada. Sobrescreve o método Sacar para indicar que saques diretos não são permitidos em contas poupança.

Banco: Classe que gerencia uma lista de contas bancárias. Possui métodos para adicionar contas (AdicionarConta), listar contas (ListarContas) e processar operações específicas para cada tipo de conta (ProcessarContas).

2. Métodos e Operações:
Depositar: Método que permite depositar um valor na conta, desde que o valor seja maior que zero.

Sacar: Método abstrato na classe base, implementado nas classes derivadas. Representa a operação de saque. Na ContaCorrente, considera a taxa de operação. Na ContaPoupanca, indica que saques diretos não são permitidos.

DeductTax: Método na classe ContaCorrente que deduz a taxa de operação do saldo.

AplicarJuros: Método na classe ContaPoupanca que aplica juros ao saldo.

AdicionarConta: Método na classe Banco que adiciona uma conta à lista.

ListarContas: Método na classe Banco que exibe informações sobre todas as contas na lista.

ProcessarContas: Método na classe Banco que processa operações específicas para cada tipo de conta, como dedução de taxas ou aplicação de juros.

3. Uso na Classe Program:
Cria uma instância do Banco.

Instancia contas corrente e poupança.

Realiza operações como depósitos, saques e aplicações de taxas/juros.

Exibe informações sobre as contas no banco.
