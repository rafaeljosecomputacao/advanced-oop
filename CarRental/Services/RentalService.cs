using CarRental.Models.Entities;

namespace CarRental.Services
{
    internal class RentalService
    {
        private ITaxService _taxService;
        public double PricePerHour { get; set; }
        public double PricePerDay { get; set; }

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(Rental rental)
        {
            TimeSpan duration = rental.Finish.Subtract(rental.Start);

            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment);
            rental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
