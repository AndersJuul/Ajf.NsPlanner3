namespace Ajf.NsPlanner3.Shared
{
    public interface IStepViewModel
    {
        string Text { get; set; }
        string Order { get; set; }
        double Completion { get; set; }
    }
}