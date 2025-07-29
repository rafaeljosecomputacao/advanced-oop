namespace CarRental.Services
{
    internal class EnglandTaxService : ITaxService
    {
        public double Tax(double amount)
        {
            return (amount <= 100.00) ? amount * 0.2 : amount * 0.15;
        }
    }
}
