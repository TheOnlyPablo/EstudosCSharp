using System.Globalization;

namespace ExerHeraPoli.Entities
{
    class UsedProcut : Product
    {
        public DateTime ManufactureDate { get; set; }
        public UsedProcut() { }

        public UsedProcut(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name
                + " (used) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date: "
                + ManufactureDate.ToString("dd/MM/yyyy")
                + ")";
        }

    }
}
