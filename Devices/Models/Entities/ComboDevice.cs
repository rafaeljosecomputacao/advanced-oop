namespace Devices.Models.Entities
{
    internal class ComboDevice: Device, IPrinter, IScanner
    {
        public void Print(string document)
        {
            Console.WriteLine("Combo device print: " + document);
        }

        public string Scan()
        {
            return "Combo device scan result";
        }

        public override void ProcessDocument(string document)
        {
            Console.WriteLine("Combo device processing: " + document);
        }
    }
}
