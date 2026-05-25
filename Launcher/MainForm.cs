using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace Launcher
{
    public partial class MainForm : Form
    {
        private const string IamQaPassword = "15885111";
        private const string IamShurukPassword = "1122qq";
        private const string AuthHash = "0123456789abcdef0123456789abcdef";
        private const string DummyArgument = "dummy";

        private readonly string _baseDir = AppDomain.CurrentDomain.BaseDirectory;
        private readonly string _settingsPath;
        private LauncherSettings _settings = new();

        public MainForm()
        {
            _settingsPath = Path.Combine(_baseDir, "Profile\\Launcher");

            InitializeComponent();
            LoadSettings();
            ApplySettingsToUi();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string userId = txtUserId.Text.Trim();
            string exePath = Path.Combine(_baseDir, "Raycity.exe");

            if (!File.Exists(exePath))
            {
                MessageBox.Show(
                    $"Raycity.exe를 찾을 수 없습니다.",
                    "오류",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (chkWriteConfig.Checked)
                {
                    WriteConfigXml(_baseDir);
                }

                var psi = new ProcessStartInfo
                {
                    FileName = exePath,
                    WorkingDirectory = _baseDir,
                    UseShellExecute = false
                };

                if (chkIamShuruk.Checked)
                {
                    psi.ArgumentList.Add(BuildIamShurukToken(userId));
                    psi.ArgumentList.Add(DummyArgument);
                }

                Process.Start(psi);
                SaveSettingsFromUi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"실행 중 오류가 발생했습니다.\r\n\r\n{ex.Message}",
                    "오류",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSettingsFromUi();
            MessageBox.Show(
                "설정을 저장했습니다.",
                "Launcher",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private static string BuildIamShurukToken(string userId)
        {
            return $"1|{userId}|3|4|{AuthHash}";
        }

        private void WriteConfigXml(string targetDir)
        {
            var sb = new StringBuilder();
            sb.AppendLine("<config>");

            if (chkIamQa.Checked)
            {
                sb.AppendLine($"  <iamqa pw=\"{IamQaPassword}\"/>");
            }

            if (chkIamShuruk.Checked)
            {
                sb.AppendLine($"  <iamshuruk pw=\"{IamShurukPassword}\"/>");
            }

            if (chkDevInfo.Checked)
            {
                sb.AppendLine("  <enableDevInfo/>");
            }

            sb.AppendLine("</config>");

            string configPath = Path.Combine(targetDir, "config.xml");
            File.WriteAllText(configPath, sb.ToString(), new UTF8Encoding(false));
        }

        private void LoadSettings()
        {
            try
            {
                if (!File.Exists(_settingsPath))
                {
                    return;
                }

                string json = File.ReadAllText(_settingsPath, Encoding.UTF8);
                _settings = JsonSerializer.Deserialize<LauncherSettings>(json) ?? new LauncherSettings();
            }
            catch
            {
                _settings = new LauncherSettings();
            }
        }

        private void ApplySettingsToUi()
        {
            txtUserId.Text = _settings.LastUserId;
            chkIamQa.Checked = _settings.UseIamQa;
            chkIamShuruk.Checked = _settings.UseIamShuruk;
            chkDevInfo.Checked = _settings.UseDevInfo;
            chkWriteConfig.Checked = _settings.WriteConfigXml;
        }

        private void SaveSettingsFromUi()
        {
            _settings.LastUserId = txtUserId.Text.Trim();
            _settings.UseIamQa = chkIamQa.Checked;
            _settings.UseIamShuruk = chkIamShuruk.Checked;
            _settings.UseDevInfo = chkDevInfo.Checked;
            _settings.WriteConfigXml = chkWriteConfig.Checked;

            string json = JsonSerializer.Serialize(_settings, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_settingsPath, json, new UTF8Encoding(false));
        }
    }
}
