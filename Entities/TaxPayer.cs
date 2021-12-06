namespace AppExcerPOOHeranPoli_03.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }

        public double AnualIncome { get; set; }

        public TaxPayer() { }

        public TaxPayer(string name, double anualincome)
        {
            this.Name = name;
            this.AnualIncome = anualincome;
        }

        public abstract double Tax();
    }
}
