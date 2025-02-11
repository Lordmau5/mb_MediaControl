using System.ComponentModel;

namespace MusicBeePlugin.Forms
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblAlbumFormat = new System.Windows.Forms.Label();
            this.lblArtistFormat = new System.Windows.Forms.Label();
            this.lblTrackFormat = new System.Windows.Forms.Label();
            this.txtAlbumFormat = new System.Windows.Forms.TextBox();
            this.txtArtistFormat = new System.Windows.Forms.TextBox();
            this.txtTrackFormat = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.lblAlbumPreview = new System.Windows.Forms.Label();
            this.lblArtistPreview = new System.Windows.Forms.Label();
            this.lblTrackPreview = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAlbumFormat
            // 
            this.lblAlbumFormat.AutoSize = true;
            this.lblAlbumFormat.Location = new System.Drawing.Point(12, 20);
            this.lblAlbumFormat.Name = "lblAlbumFormat";
            this.lblAlbumFormat.Size = new System.Drawing.Size(74, 13);
            this.lblAlbumFormat.TabIndex = 0;
            this.lblAlbumFormat.Text = "Album Format:";
            // 
            // lblArtistFormat
            // 
            this.lblArtistFormat.AutoSize = true;
            this.lblArtistFormat.Location = new System.Drawing.Point(12, 48);
            this.lblArtistFormat.Name = "lblArtistFormat";
            this.lblArtistFormat.Size = new System.Drawing.Size(68, 13);
            this.lblArtistFormat.TabIndex = 2;
            this.lblArtistFormat.Text = "Artist Format:";
            // 
            // lblTrackFormat
            // 
            this.lblTrackFormat.AutoSize = true;
            this.lblTrackFormat.Location = new System.Drawing.Point(12, 76);
            this.lblTrackFormat.Name = "lblTrackFormat";
            this.lblTrackFormat.Size = new System.Drawing.Size(73, 13);
            this.lblTrackFormat.TabIndex = 4;
            this.lblTrackFormat.Text = "Track Format:";
            // 
            // txtAlbumFormat
            // 
            this.txtAlbumFormat.Location = new System.Drawing.Point(92, 17);
            this.txtAlbumFormat.Name = "txtAlbumFormat";
            this.txtAlbumFormat.Size = new System.Drawing.Size(160, 20);
            this.txtAlbumFormat.TabIndex = 1;
            this.txtAlbumFormat.TextChanged += new System.EventHandler(this.OnFormatTextChanged);
            // 
            // txtArtistFormat
            // 
            this.txtArtistFormat.Location = new System.Drawing.Point(92, 45);
            this.txtArtistFormat.Name = "txtArtistFormat";
            this.txtArtistFormat.Size = new System.Drawing.Size(160, 20);
            this.txtArtistFormat.TabIndex = 3;
            this.txtArtistFormat.TextChanged += new System.EventHandler(this.OnFormatTextChanged);
            // 
            // txtTrackFormat
            // 
            this.txtTrackFormat.Location = new System.Drawing.Point(92, 73);
            this.txtTrackFormat.Name = "txtTrackFormat";
            this.txtTrackFormat.Size = new System.Drawing.Size(160, 20);
            this.txtTrackFormat.TabIndex = 5;
            this.txtTrackFormat.TextChanged += new System.EventHandler(this.OnFormatTextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(297, 106);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(216, 106);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // lblAlbumPreview
            // 
            this.lblAlbumPreview.AutoSize = true;
            this.lblAlbumPreview.Location = new System.Drawing.Point(258, 20);
            this.lblAlbumPreview.Name = "lblAlbumPreview";
            this.lblAlbumPreview.Size = new System.Drawing.Size(93, 13);
            this.lblAlbumPreview.TabIndex = 8;
            this.lblAlbumPreview.Text = "No track playing...";
            // 
            // lblArtistPreview
            // 
            this.lblArtistPreview.AutoSize = true;
            this.lblArtistPreview.Location = new System.Drawing.Point(258, 48);
            this.lblArtistPreview.Name = "lblArtistPreview";
            this.lblArtistPreview.Size = new System.Drawing.Size(93, 13);
            this.lblArtistPreview.TabIndex = 9;
            this.lblArtistPreview.Text = "No track playing...";
            // 
            // lblTrackPreview
            // 
            this.lblTrackPreview.AutoSize = true;
            this.lblTrackPreview.Location = new System.Drawing.Point(258, 76);
            this.lblTrackPreview.Name = "lblTrackPreview";
            this.lblTrackPreview.Size = new System.Drawing.Size(93, 13);
            this.lblTrackPreview.TabIndex = 10;
            this.lblTrackPreview.Text = "No track playing...";
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(12, 106);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInfo.TabIndex = 11;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 141);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lblTrackPreview);
            this.Controls.Add(this.lblArtistPreview);
            this.Controls.Add(this.lblAlbumPreview);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtTrackFormat);
            this.Controls.Add(this.txtArtistFormat);
            this.Controls.Add(this.txtAlbumFormat);
            this.Controls.Add(this.lblTrackFormat);
            this.Controls.Add(this.lblArtistFormat);
            this.Controls.Add(this.lblAlbumFormat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MediaControl: Settings";
            this.Shown += new System.EventHandler(this.SettingsForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnInfo;

        private System.Windows.Forms.Label lblAlbumPreview;
        private System.Windows.Forms.Label lblArtistPreview;
        private System.Windows.Forms.Label lblTrackPreview;

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;

        private System.Windows.Forms.Label lblAlbumFormat;
        private System.Windows.Forms.Label lblArtistFormat;
        private System.Windows.Forms.Label lblTrackFormat;
        private System.Windows.Forms.TextBox txtAlbumFormat;
        private System.Windows.Forms.TextBox txtArtistFormat;
        private System.Windows.Forms.TextBox txtTrackFormat;
        private System.Windows.Forms.ToolTip toolTip;

        #endregion
    }
}