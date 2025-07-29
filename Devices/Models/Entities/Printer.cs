namespace Devices.Models.Entities
{
    internal class Printer : Device, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("Printer print: " + document);
        }

        public override void ProcessDocument(string document)
        {
            Console.WriteLine("Printer processing: " + document);
        }
    }
}
