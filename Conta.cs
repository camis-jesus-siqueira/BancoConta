public class Conta
{
  public int Codigo { get; }
  public double Saldo { get; private set;}
 
  public Conta(int codigo)
  {
      Codigo = codigo;
      Saldo = 0.0;
  }
  public void Sacar(double valor)
  {
     ValidarValor(valor);
     VerificarSaldo(valor);
      Saldo = Saldo - valor;
  }  
  public void Depositar(double valor)
  {
     ValidarValor(valor);
      Saldo = Saldo + valor;
  }
  public void Transferir(double valor, Conta conta)
  {
    // ValidarValor(valor);
    // VerificarSaldo(valor);
     // Saldo = Saldo - valor;
    //  conta.Saldo = conta.Saldo + valor;

      Sacar(valor);
      conta.Depositar(valor);
  }
private void ValidarValor(double valor)
{
    if(valor <= 0.0)
     throw new ArgumentException("deve ser maior que zero");
}
private void VerificarSaldo(double valor)
{
    if(valor > Saldo)
     throw new ArgumentException("não há saldo sulficiente");
}
}