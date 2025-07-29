namespace Devices.Models.Entities
{
    internal class Scanner : Device, IScanner
    {
        public string Scan()
        {
            return "Scanner scan result";
        }

        public override void ProcessDocument(string document)
        {
            Console.WriteLine("Scanner processing: " + document);
        }
    }
}
