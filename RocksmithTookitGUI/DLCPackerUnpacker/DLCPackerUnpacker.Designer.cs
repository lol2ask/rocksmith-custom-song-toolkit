﻿namespace RocksmithToolkitGUI.DLCPackerUnpacker
{
    partial class DLCPackerUnpacker
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DLCPackerUnpacker));
            this.btnUnpack = new System.Windows.Forms.Button();
            this.btnPack = new System.Windows.Forms.Button();
            this.btnRepackAppId = new System.Windows.Forms.Button();
            this.gbAppIdUpdater = new System.Windows.Forms.GroupBox();
            this.lblAppId = new System.Windows.Forms.Label();
            this.cmbGameVersion = new System.Windows.Forms.ComboBox();
            this.txtAppId = new RocksmithToolkitGUI.CueTextBox();
            this.cmbAppId = new System.Windows.Forms.ComboBox();
            this.chkDecodeAudio = new System.Windows.Forms.CheckBox();
            this.chkUpdateSng = new System.Windows.Forms.CheckBox();
            this.gbUnpacker = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkExtractSongXml = new System.Windows.Forms.CheckBox();
            this.gbPacker = new System.Windows.Forms.GroupBox();
            this.lblCurrentOperation = new System.Windows.Forms.Label();
            this.pbUpdateProgress = new System.Windows.Forms.ProgressBar();
            this.gbCustomFixes = new System.Windows.Forms.GroupBox();
            this.chkDeleteSourceFile = new System.Windows.Forms.CheckBox();
            this.chkQuickBassFix = new System.Windows.Forms.CheckBox();
            this.btnLowTuningBassFix = new System.Windows.Forms.Button();
            this.gpSongPacks = new System.Windows.Forms.GroupBox();
            this.btnSelectSongs = new System.Windows.Forms.Button();
            this.btnPackSongPack = new System.Windows.Forms.Button();
            this.lblHelp = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbAppIdUpdater.SuspendLayout();
            this.gbUnpacker.SuspendLayout();
            this.gbPacker.SuspendLayout();
            this.gbCustomFixes.SuspendLayout();
            this.gpSongPacks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUnpack
            // 
            this.btnUnpack.ForeColor = System.Drawing.Color.Black;
            this.btnUnpack.Location = new System.Drawing.Point(120, 54);
            this.btnUnpack.Name = "btnUnpack";
            this.btnUnpack.Size = new System.Drawing.Size(75, 23);
            this.btnUnpack.TabIndex = 2;
            this.btnUnpack.Text = "Unpack";
            this.btnUnpack.UseVisualStyleBackColor = true;
            this.btnUnpack.Click += new System.EventHandler(this.btnUnpack_Click);
            // 
            // btnPack
            // 
            this.btnPack.ForeColor = System.Drawing.Color.Black;
            this.btnPack.Location = new System.Drawing.Point(39, 54);
            this.btnPack.Name = "btnPack";
            this.btnPack.Size = new System.Drawing.Size(75, 23);
            this.btnPack.TabIndex = 4;
            this.btnPack.Text = "Pack";
            this.btnPack.UseVisualStyleBackColor = true;
            this.btnPack.Click += new System.EventHandler(this.btnPack_Click);
            // 
            // btnRepackAppId
            // 
            this.btnRepackAppId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRepackAppId.ForeColor = System.Drawing.Color.Black;
            this.btnRepackAppId.Location = new System.Drawing.Point(297, 41);
            this.btnRepackAppId.Name = "btnRepackAppId";
            this.btnRepackAppId.Size = new System.Drawing.Size(128, 23);
            this.btnRepackAppId.TabIndex = 7;
            this.btnRepackAppId.Text = "Repack AppId";
            this.btnRepackAppId.UseVisualStyleBackColor = true;
            this.btnRepackAppId.Click += new System.EventHandler(this.btnRepackAppId_Click);
            // 
            // gbAppIdUpdater
            // 
            this.gbAppIdUpdater.Controls.Add(this.lblAppId);
            this.gbAppIdUpdater.Controls.Add(this.cmbGameVersion);
            this.gbAppIdUpdater.Controls.Add(this.txtAppId);
            this.gbAppIdUpdater.Controls.Add(this.cmbAppId);
            this.gbAppIdUpdater.Controls.Add(this.btnRepackAppId);
            this.gbAppIdUpdater.ForeColor = System.Drawing.Color.Firebrick;
            this.gbAppIdUpdater.Location = new System.Drawing.Point(8, 92);
            this.gbAppIdUpdater.Margin = new System.Windows.Forms.Padding(2);
            this.gbAppIdUpdater.Name = "gbAppIdUpdater";
            this.gbAppIdUpdater.Padding = new System.Windows.Forms.Padding(2);
            this.gbAppIdUpdater.Size = new System.Drawing.Size(434, 71);
            this.gbAppIdUpdater.TabIndex = 13;
            this.gbAppIdUpdater.TabStop = false;
            this.gbAppIdUpdater.Text = "App ID Updater";
            // 
            // lblAppId
            // 
            this.lblAppId.AutoSize = true;
            this.lblAppId.ForeColor = System.Drawing.Color.Black;
            this.lblAppId.Location = new System.Drawing.Point(7, 46);
            this.lblAppId.Name = "lblAppId";
            this.lblAppId.Size = new System.Drawing.Size(142, 13);
            this.lblAppId.TabIndex = 25;
            this.lblAppId.Text = "Enter a Custom App ID here:";
            // 
            // cmbGameVersion
            // 
            this.cmbGameVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGameVersion.FormattingEnabled = true;
            this.cmbGameVersion.Location = new System.Drawing.Point(10, 16);
            this.cmbGameVersion.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGameVersion.Name = "cmbGameVersion";
            this.cmbGameVersion.Size = new System.Drawing.Size(81, 21);
            this.cmbGameVersion.TabIndex = 5;
            this.cmbGameVersion.SelectedIndexChanged += new System.EventHandler(this.cmbGameVersion_SelectedIndexChanged);
            // 
            // txtAppId
            // 
            this.txtAppId.Cue = "APP ID";
            this.txtAppId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtAppId.ForeColor = System.Drawing.Color.Gray;
            this.txtAppId.Location = new System.Drawing.Point(155, 43);
            this.txtAppId.Name = "txtAppId";
            this.txtAppId.Size = new System.Drawing.Size(82, 20);
            this.txtAppId.TabIndex = 41;
            // 
            // cmbAppId
            // 
            this.cmbAppId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAppId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAppId.FormattingEnabled = true;
            this.cmbAppId.Location = new System.Drawing.Point(99, 16);
            this.cmbAppId.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAppId.Name = "cmbAppId";
            this.cmbAppId.Size = new System.Drawing.Size(326, 21);
            this.cmbAppId.TabIndex = 6;
            this.cmbAppId.SelectedValueChanged += new System.EventHandler(this.cmbAppIds_SelectedValueChanged);
            // 
            // chkDecodeAudio
            // 
            this.chkDecodeAudio.AutoSize = true;
            this.chkDecodeAudio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkDecodeAudio.Location = new System.Drawing.Point(7, 58);
            this.chkDecodeAudio.Name = "chkDecodeAudio";
            this.chkDecodeAudio.Size = new System.Drawing.Size(94, 17);
            this.chkDecodeAudio.TabIndex = 0;
            this.chkDecodeAudio.Text = "Decode Audio";
            this.chkDecodeAudio.UseVisualStyleBackColor = true;
            // 
            // chkUpdateSng
            // 
            this.chkUpdateSng.AutoSize = true;
            this.chkUpdateSng.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkUpdateSng.Location = new System.Drawing.Point(6, 19);
            this.chkUpdateSng.Name = "chkUpdateSng";
            this.chkUpdateSng.Size = new System.Drawing.Size(87, 17);
            this.chkUpdateSng.TabIndex = 3;
            this.chkUpdateSng.Text = "Update SNG";
            this.chkUpdateSng.UseVisualStyleBackColor = true;
            // 
            // gbUnpacker
            // 
            this.gbUnpacker.Controls.Add(this.label2);
            this.gbUnpacker.Controls.Add(this.chkExtractSongXml);
            this.gbUnpacker.Controls.Add(this.chkDecodeAudio);
            this.gbUnpacker.Controls.Add(this.btnUnpack);
            this.gbUnpacker.ForeColor = System.Drawing.Color.Firebrick;
            this.gbUnpacker.Location = new System.Drawing.Point(100, 4);
            this.gbUnpacker.Name = "gbUnpacker";
            this.gbUnpacker.Size = new System.Drawing.Size(204, 83);
            this.gbUnpacker.TabIndex = 16;
            this.gbUnpacker.TabStop = false;
            this.gbUnpacker.Text = "Unpacker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(9, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "Removes XML Comments";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkExtractSongXml
            // 
            this.chkExtractSongXml.AutoSize = true;
            this.chkExtractSongXml.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkExtractSongXml.Location = new System.Drawing.Point(7, 19);
            this.chkExtractSongXml.Name = "chkExtractSongXml";
            this.chkExtractSongXml.Size = new System.Drawing.Size(86, 17);
            this.chkExtractSongXml.TabIndex = 1;
            this.chkExtractSongXml.Text = "SNG to XML";
            this.chkExtractSongXml.UseVisualStyleBackColor = true;
            // 
            // gbPacker
            // 
            this.gbPacker.Controls.Add(this.chkUpdateSng);
            this.gbPacker.Controls.Add(this.btnPack);
            this.gbPacker.ForeColor = System.Drawing.Color.Firebrick;
            this.gbPacker.Location = new System.Drawing.Point(319, 4);
            this.gbPacker.Name = "gbPacker";
            this.gbPacker.Size = new System.Drawing.Size(123, 83);
            this.gbPacker.TabIndex = 17;
            this.gbPacker.TabStop = false;
            this.gbPacker.Text = "Packer";
            // 
            // lblCurrentOperation
            // 
            this.lblCurrentOperation.AutoSize = true;
            this.lblCurrentOperation.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCurrentOperation.Location = new System.Drawing.Point(15, 353);
            this.lblCurrentOperation.Name = "lblCurrentOperation";
            this.lblCurrentOperation.Size = new System.Drawing.Size(16, 13);
            this.lblCurrentOperation.TabIndex = 19;
            this.lblCurrentOperation.Text = "...";
            this.lblCurrentOperation.Visible = false;
            // 
            // pbUpdateProgress
            // 
            this.pbUpdateProgress.Location = new System.Drawing.Point(17, 373);
            this.pbUpdateProgress.Name = "pbUpdateProgress";
            this.pbUpdateProgress.Size = new System.Drawing.Size(416, 20);
            this.pbUpdateProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbUpdateProgress.TabIndex = 0;
            this.pbUpdateProgress.Visible = false;
            // 
            // gbCustomFixes
            // 
            this.gbCustomFixes.Controls.Add(this.chkDeleteSourceFile);
            this.gbCustomFixes.Controls.Add(this.chkQuickBassFix);
            this.gbCustomFixes.Controls.Add(this.btnLowTuningBassFix);
            this.gbCustomFixes.ForeColor = System.Drawing.Color.Firebrick;
            this.gbCustomFixes.Location = new System.Drawing.Point(8, 168);
            this.gbCustomFixes.Name = "gbCustomFixes";
            this.gbCustomFixes.Size = new System.Drawing.Size(434, 43);
            this.gbCustomFixes.TabIndex = 20;
            this.gbCustomFixes.TabStop = false;
            this.gbCustomFixes.Text = "Custom Fixes (RS 2014)";
            // 
            // chkDeleteSourceFile
            // 
            this.chkDeleteSourceFile.AutoSize = true;
            this.chkDeleteSourceFile.ForeColor = System.Drawing.Color.Black;
            this.chkDeleteSourceFile.Location = new System.Drawing.Point(99, 19);
            this.chkDeleteSourceFile.Name = "chkDeleteSourceFile";
            this.chkDeleteSourceFile.Size = new System.Drawing.Size(113, 17);
            this.chkDeleteSourceFile.TabIndex = 9;
            this.chkDeleteSourceFile.Text = "Delete Source File";
            this.chkDeleteSourceFile.UseVisualStyleBackColor = true;
            // 
            // chkQuickBassFix
            // 
            this.chkQuickBassFix.AutoSize = true;
            this.chkQuickBassFix.ForeColor = System.Drawing.Color.Black;
            this.chkQuickBassFix.Location = new System.Drawing.Point(10, 19);
            this.chkQuickBassFix.Name = "chkQuickBassFix";
            this.chkQuickBassFix.Size = new System.Drawing.Size(70, 17);
            this.chkQuickBassFix.TabIndex = 8;
            this.chkQuickBassFix.Text = "Quick Fix";
            this.chkQuickBassFix.UseVisualStyleBackColor = true;
            // 
            // btnLowTuningBassFix
            // 
            this.btnLowTuningBassFix.ForeColor = System.Drawing.Color.Black;
            this.btnLowTuningBassFix.Location = new System.Drawing.Point(297, 15);
            this.btnLowTuningBassFix.Name = "btnLowTuningBassFix";
            this.btnLowTuningBassFix.Size = new System.Drawing.Size(128, 23);
            this.btnLowTuningBassFix.TabIndex = 10;
            this.btnLowTuningBassFix.Text = "Fix Low Bass Tuning";
            this.btnLowTuningBassFix.UseVisualStyleBackColor = true;
            this.btnLowTuningBassFix.Click += new System.EventHandler(this.btnLowTuningBassFix_Click);
            // 
            // gpSongPacks
            // 
            this.gpSongPacks.Controls.Add(this.btnSelectSongs);
            this.gpSongPacks.Controls.Add(this.btnPackSongPack);
            this.gpSongPacks.Controls.Add(this.lblHelp);
            this.gpSongPacks.ForeColor = System.Drawing.Color.Firebrick;
            this.gpSongPacks.Location = new System.Drawing.Point(8, 217);
            this.gpSongPacks.Name = "gpSongPacks";
            this.gpSongPacks.Size = new System.Drawing.Size(434, 128);
            this.gpSongPacks.TabIndex = 21;
            this.gpSongPacks.TabStop = false;
            this.gpSongPacks.Text = "NEW Song Packs (RS 2014 PC Only)";
            // 
            // btnSelectSongs
            // 
            this.btnSelectSongs.ForeColor = System.Drawing.Color.Black;
            this.btnSelectSongs.Location = new System.Drawing.Point(297, 22);
            this.btnSelectSongs.Name = "btnSelectSongs";
            this.btnSelectSongs.Size = new System.Drawing.Size(128, 23);
            this.btnSelectSongs.TabIndex = 23;
            this.btnSelectSongs.Text = "Select Songs";
            this.btnSelectSongs.UseVisualStyleBackColor = true;
            this.btnSelectSongs.Click += new System.EventHandler(this.btnSelectSongs_Click);
            // 
            // btnPackSongPack
            // 
            this.btnPackSongPack.ForeColor = System.Drawing.Color.Black;
            this.btnPackSongPack.Location = new System.Drawing.Point(297, 90);
            this.btnPackSongPack.Name = "btnPackSongPack";
            this.btnPackSongPack.Size = new System.Drawing.Size(128, 23);
            this.btnPackSongPack.TabIndex = 5;
            this.btnPackSongPack.Text = "Repack as Song Pack";
            this.btnPackSongPack.UseVisualStyleBackColor = true;
            this.btnPackSongPack.Click += new System.EventHandler(this.btnPackSongPack_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHelp.Location = new System.Drawing.Point(7, 22);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(273, 91);
            this.lblHelp.TabIndex = 24;
            this.lblHelp.Text = resources.GetString("lblHelp.Text");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RocksmithToolkitGUI.Properties.Resources.brasil_logo;
            this.pictureBox2.Location = new System.Drawing.Point(8, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // DLCPackerUnpacker
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.gpSongPacks);
            this.Controls.Add(this.gbCustomFixes);
            this.Controls.Add(this.lblCurrentOperation);
            this.Controls.Add(this.pbUpdateProgress);
            this.Controls.Add(this.gbPacker);
            this.Controls.Add(this.gbUnpacker);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.gbAppIdUpdater);
            this.MinimumSize = new System.Drawing.Size(400, 308);
            this.Name = "DLCPackerUnpacker";
            this.Size = new System.Drawing.Size(450, 403);
            this.gbAppIdUpdater.ResumeLayout(false);
            this.gbAppIdUpdater.PerformLayout();
            this.gbUnpacker.ResumeLayout(false);
            this.gbUnpacker.PerformLayout();
            this.gbPacker.ResumeLayout(false);
            this.gbPacker.PerformLayout();
            this.gbCustomFixes.ResumeLayout(false);
            this.gbCustomFixes.PerformLayout();
            this.gpSongPacks.ResumeLayout(false);
            this.gpSongPacks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnpack;
        private System.Windows.Forms.Button btnPack;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnRepackAppId;
        private System.Windows.Forms.GroupBox gbAppIdUpdater;
        private System.Windows.Forms.ComboBox cmbAppId;
        private CueTextBox txtAppId;
        private System.Windows.Forms.CheckBox chkDecodeAudio;
        private System.Windows.Forms.CheckBox chkUpdateSng;
        private System.Windows.Forms.ComboBox cmbGameVersion;
        private System.Windows.Forms.GroupBox gbUnpacker;
        private System.Windows.Forms.CheckBox chkExtractSongXml;
        private System.Windows.Forms.GroupBox gbPacker;
        private System.Windows.Forms.Label lblCurrentOperation;
        private System.Windows.Forms.GroupBox gbCustomFixes;
        protected System.Windows.Forms.Button btnLowTuningBassFix;
        private DLCPackageCreator.DLCPackageCreator dlcPackageCreatorControl;
        private System.Windows.Forms.CheckBox chkQuickBassFix;
        private System.Windows.Forms.CheckBox chkDeleteSourceFile;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ProgressBar pbUpdateProgress;
        private System.Windows.Forms.GroupBox gpSongPacks;
        private System.Windows.Forms.Button btnPackSongPack;
        private System.Windows.Forms.Button btnSelectSongs;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label lblAppId;
    }
}
