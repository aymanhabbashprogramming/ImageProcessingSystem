namespace Görüntü_işleme.Screens
{
    partial class EsiklemeScreen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kryptonGroup3 = new Krypton.Toolkit.KryptonGroup();
            this.EditedImage = new System.Windows.Forms.PictureBox();
            this.kryptonGroup1 = new Krypton.Toolkit.KryptonGroup();
            this.OriginalImage = new System.Windows.Forms.PictureBox();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.btnDefault = new Krypton.Toolkit.KryptonButton();
            this.btnPrevious = new Krypton.Toolkit.KryptonButton();
            this.OpenImage = new Krypton.Toolkit.KryptonButton();
            this.TrackBar1 = new Krypton.Toolkit.KryptonTrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3.Panel)).BeginInit();
            this.kryptonGroup3.Panel.SuspendLayout();
            this.kryptonGroup3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImage)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonGroup3
            // 
            this.kryptonGroup3.Location = new System.Drawing.Point(358, 21);
            // 
            // kryptonGroup3.Panel
            // 
            this.kryptonGroup3.Panel.Controls.Add(this.EditedImage);
            this.kryptonGroup3.Size = new System.Drawing.Size(324, 324);
            this.kryptonGroup3.StateCommon.Back.Color1 = System.Drawing.Color.Tan;
            this.kryptonGroup3.StateCommon.Border.Rounding = 20F;
            this.kryptonGroup3.TabIndex = 58;
            // 
            // EditedImage
            // 
            this.EditedImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EditedImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditedImage.Location = new System.Drawing.Point(3, 3);
            this.EditedImage.Name = "EditedImage";
            this.EditedImage.Size = new System.Drawing.Size(300, 300);
            this.EditedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EditedImage.TabIndex = 11;
            this.EditedImage.TabStop = false;
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Location = new System.Drawing.Point(28, 21);
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.OriginalImage);
            this.kryptonGroup1.Size = new System.Drawing.Size(324, 324);
            this.kryptonGroup1.StateCommon.Back.Color1 = System.Drawing.Color.Tan;
            this.kryptonGroup1.StateCommon.Border.Rounding = 20F;
            this.kryptonGroup1.TabIndex = 57;
            // 
            // OriginalImage
            // 
            this.OriginalImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OriginalImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OriginalImage.Location = new System.Drawing.Point(3, 3);
            this.OriginalImage.Name = "OriginalImage";
            this.OriginalImage.Size = new System.Drawing.Size(300, 300);
            this.OriginalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OriginalImage.TabIndex = 11;
            this.OriginalImage.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(564, 351);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 43);
            this.btnSave.StateCommon.Border.Rounding = 15F;
            this.btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.TabIndex = 55;
            this.btnSave.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSave.Values.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(383, 351);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(153, 43);
            this.btnDefault.StateCommon.Border.Rounding = 15F;
            this.btnDefault.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefault.TabIndex = 54;
            this.btnDefault.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnDefault.Values.Text = "Varsayılan";
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(204, 351);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(148, 43);
            this.btnPrevious.StateCommon.Border.Rounding = 15F;
            this.btnPrevious.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.TabIndex = 53;
            this.btnPrevious.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnPrevious.Values.Text = "Geri Al";
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // OpenImage
            // 
            this.OpenImage.Location = new System.Drawing.Point(28, 351);
            this.OpenImage.Name = "OpenImage";
            this.OpenImage.Size = new System.Drawing.Size(148, 43);
            this.OpenImage.StateCommon.Border.Rounding = 15F;
            this.OpenImage.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenImage.TabIndex = 52;
            this.OpenImage.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.OpenImage.Values.Text = "Görüntü Aç";
            this.OpenImage.Click += new System.EventHandler(this.OpenImage_Click);
            // 
            // TrackBar1
            // 
            this.TrackBar1.Location = new System.Drawing.Point(38, 409);
            this.TrackBar1.Maximum = 255;
            this.TrackBar1.Name = "TrackBar1";
            this.TrackBar1.Size = new System.Drawing.Size(630, 27);
            this.TrackBar1.StateCommon.Track.Color1 = System.Drawing.Color.Red;
            this.TrackBar1.StateCommon.Track.Color2 = System.Drawing.Color.Empty;
            this.TrackBar1.StateCommon.Track.Color3 = System.Drawing.Color.Empty;
            this.TrackBar1.StateCommon.Track.Color4 = System.Drawing.Color.Red;
            this.TrackBar1.StateCommon.Track.Color5 = System.Drawing.Color.Empty;
            this.TrackBar1.TabIndex = 59;
            this.TrackBar1.Value = 128;
            this.TrackBar1.ValueChanged += new System.EventHandler(this.TrackBar1_ValueChanged);
            // 
            // EsiklemeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(711, 469);
            this.Controls.Add(this.TrackBar1);
            this.Controls.Add(this.kryptonGroup3);
            this.Controls.Add(this.kryptonGroup1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.OpenImage);
            this.Name = "EsiklemeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eşikleme";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3.Panel)).EndInit();
            this.kryptonGroup3.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3)).EndInit();
            this.kryptonGroup3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EditedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonGroup kryptonGroup3;
        private System.Windows.Forms.PictureBox EditedImage;
        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private System.Windows.Forms.PictureBox OriginalImage;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonButton btnDefault;
        private Krypton.Toolkit.KryptonButton btnPrevious;
        private Krypton.Toolkit.KryptonButton OpenImage;
        private Krypton.Toolkit.KryptonTrackBar TrackBar1;
    }
}