namespace Ajf.NsPlanner3.Shared
{
    public class StepViewModel1 : IStepViewModel
    {
        public StepViewModel1()
        {
            Order = "B";
            Completion = 2;
        }
        public string Order { get; set; }
        public double Completion { get; set; }
    }
}