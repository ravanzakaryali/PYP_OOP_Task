namespace PYP_Reflection_Task.Models
{
    public class Flute : Instrument
    {
        public string Direction { get; set; }
        public double ECC { get; set; }
        public double ControlerPaper { get; set; }
        public override string Voice() => "fuuuuu";
    }
}
