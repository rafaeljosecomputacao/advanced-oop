namespace Devices.Models.Entities
{
    internal abstract class Device
    {
        public int SerialNumber { get; set; }

        public abstract void ProcessDocument(string document);
    }
}
