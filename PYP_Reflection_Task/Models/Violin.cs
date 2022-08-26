namespace PYP_Reflection_Task.Models
{
    public class Violin : Instrument
    {
        public bool IsKanifol { get; set; }
        public bool IsFuts { get; set; }
        public override string Voice() => "dirr dir";
    }
}
