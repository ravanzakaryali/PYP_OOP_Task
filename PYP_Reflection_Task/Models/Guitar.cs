namespace PYP_Reflection_Task.Models
{
    public class Guitar : Instrument
    {
        public string Size { get; set; }
        public int Fingerboard { get; set; }
        public override string Voice()
        {
            return "Do re mi fa sol lya";
        }
    }
}
