namespace baytbank
{
    public class ContaCorrente
    {
       public string conta;
       public int number_agencia;
       public string name_agencia ;
       public double saldo;
        public bool sacar (double valor)
        {
            if (saldo < valor)
            {
                return false;

            }
            if(valor > 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                return true;
            }
        }
        public void Depositar(double valor)
        {
            if(valor < 0)
            {
                return;
            }
            saldo = saldo+ valor;
            
        }

        public bool Trasnferir(double valor, ContaCorrente destino)
        { if(saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                destino.saldo = destino.saldo + valor;
                return true;
            }

        }


    }

   

}