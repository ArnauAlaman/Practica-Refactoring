namespace PracticaRefactoring
{
    public class DadesComanda
    {
        private string id; 
        private double importBrut;
        private string client;
        private double descompte;
        private double despesa;
        private double iva;
        private string estat;

        public double ImportBrut { get => importBrut; set => importBrut = value; }
        public double Descompte { get => descompte; set => descompte = value; }
        public double Despesa { get => despesa; set => despesa = value; }
        public double Iva { get => iva; set => iva = value; }
        public string Client { get => client; set => client = value; }
        public string Estat { get => estat; set => estat = value; }
        public string Id { get => id; set => id = value; }

        public DadesComanda(double importBrut, string client, double descompte, double despesa, double iva, string estat, string id)
        {
            this.importBrut = importBrut;
            this.descompte = descompte;
            this.despesa = despesa;
            this.iva = iva;
            this.client = client;
            this.estat = estat;
            this.id = id;
        }

    }
}
