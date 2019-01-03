using JCI.ITC.COMP2.Common.Settings;

namespace JCI.ITC.MsiBuilder
{
    public interface IMsiBuilderSettings:IIdentitySettings
    {
        string UiExe { get; set; }
        string ProductName { get; set; }
        string[] PathChoices { get; set; }
        string GuidBasis { get; set; }
        string CompanyName { get; set; }
        string MsiPrefix { get; set; }
    }
}