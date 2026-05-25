namespace Launcher
{
    public sealed class LauncherSettings
    {
        public string LastUserId { get; set; } = "";
        public bool UseIamQa { get; set; } = true;
        public bool UseIamShuruk { get; set; } = true;
        public bool UseDevInfo { get; set; } = true;
        public bool WriteConfigXml { get; set; } = true;
    }
}
