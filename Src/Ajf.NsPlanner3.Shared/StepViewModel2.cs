﻿namespace Ajf.NsPlanner3.Shared
{
    public class StepViewModel2 : IStepViewModel
    {
        public StepViewModel2()
        {
            Order = "C";
            Completion = 3;
        }
        public string Order { get; set; }
        public double Completion { get; set; }
    }
}