namespace Ajf.NsPlanner3.Shared
{
    public class StepViewModel0 : IStepViewModel
    {
        public StepViewModel0()
        {
            Order = "A";
            Completion = 1;
            Text = "Lav resultatfil";
        }

        public string Text { get; set; }
        public string Order { get; set; }
        public double Completion { get; set; }
    }
}