namespace Prodotti
{
    internal class Prodotto
    {
        //-------Dichiaro le variabili del mio programma------
        private int codiceProdotto;
        private string nomeProdotto;
        private string descrizioneProdotto;
        private double prezzoProdotto;
        private double ivaProdotto;

        //-----creo i miei costruttori-------
        public Prodotto(string nomeProdotto, string descrizioneProdotto, double prezzoProdotto)

        {
            //this.codiceProdotto = codiceProdotto;
            this.nomeProdotto = nomeProdotto;
            this.descrizioneProdotto = descrizioneProdotto;
            this.prezzoProdotto = prezzoProdotto;
        }
        //-------CREO I MIEI METODI------
        public void generazioneCodiceRandom()
        {
            Random random = new Random();
            int num = random.Next();
        }

        public void calcoloPrezzoConIva()
        {
            prezzoProdotto * 0.22;
            return;
        }
    }
        
    


        
}
    

