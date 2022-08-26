namespace PYP_Reflection_Task.Models
{
    public class Piano : Instrument
    {
        public byte Keys { get; set; }
        public int Sounds { get; set; }
        public double Weight { get; set; }
        public override string Voice()
        {
            return "Do re";
        }
    }
}
