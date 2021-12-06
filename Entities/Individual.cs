namespace AppExcerPOOHeranPoli_03.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures  { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double anualincome, double healthExpenditures)
            : base(name,anualincome)
        {
            this.HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000.0)
            {
                return AnualIncome * 0.15 - HealthExpenditures * 0.5;
            }
            else
            {
                return AnualIncome * 0.25 - HealthExpenditures * 0.5;
            }
        }
    }
}
