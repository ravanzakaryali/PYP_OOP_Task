namespace PYP_Reflection_Task.Models
{
    public abstract class Instrument
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public string Model { get; set; }
        abstract public string Voice();
    }
}
