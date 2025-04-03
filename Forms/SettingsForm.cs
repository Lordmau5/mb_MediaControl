using System;
using System.Text;
using System.Windows.Forms;
using MusicBeePlugin.Extensions;

namespace MusicBeePlugin.Forms
{
    public partial class SettingsForm : Form
    {
        private readonly Plugin.MusicBeeApiInterface mbApiInterface;
        private readonly Settings settings;

        public SettingsForm(Plugin.MusicBeeApiInterface mbApiInterface, Settings settings)
        {
            InitializeComponent();

            this.mbApiInterface = mbApiInterface;
            this.settings = settings;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            settings.AlbumFormat = txtAlbumFormat.Text.Trim();
            settings.ArtistFormat = txtArtistFormat.Text.Trim();
            settings.TrackFormat = txtTrackFormat.Text.Trim();

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SettingsForm_Shown(object sender, EventArgs e)
        {
            txtAlbumFormat.Text = settings.AlbumFormat;
            txtArtistFormat.Text = settings.ArtistFormat;
            txtTrackFormat.Text = settings.TrackFormat;
            checkBoxHookGlobalHotkeys.Checked = settings.HookGlobalHotkeys;
        }

        private string GetFormattedPreview(string input)
        {
            var preview = mbApiInterface.GetFormattedString(input);
            if (string.IsNullOrWhiteSpace(preview))
            {
                preview = "No track playing...";
            }

            return preview;
        }

        private void UpdatePreview()
        {
            var albumPreview = GetFormattedPreview(txtAlbumFormat.Text);
            lblAlbumPreview.Text = albumPreview;
            toolTip.SetToolTip(lblAlbumPreview, albumPreview);

            var artistPreview = GetFormattedPreview(txtArtistFormat.Text);
            lblArtistPreview.Text = artistPreview;
            toolTip.SetToolTip(lblArtistPreview, artistPreview);

            var trackPreview = GetFormattedPreview(txtTrackFormat.Text);
            lblTrackPreview.Text = trackPreview;
            toolTip.SetToolTip(lblTrackPreview, trackPreview);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Album")
                .AppendLine("AlbumArtist")
                .AppendLine("Artist")
                .AppendLine("DiscCount")
                .AppendLine("DiscNo")
                .AppendLine("Genre")
                .AppendLine("Track")
                .AppendLine("TrackCount")
                .AppendLine("TrackNo")
                .AppendLine("Year");
            MessageBox.Show(sb.ToString(), "MediaControl - Supported Placeholders", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OnFormatTextChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void checkBoxHookGlobalHotkeys_CheckedChanged(object sender, EventArgs e)
        {
            settings.HookGlobalHotkeys = checkBoxHookGlobalHotkeys.Checked;
        }
    }
}