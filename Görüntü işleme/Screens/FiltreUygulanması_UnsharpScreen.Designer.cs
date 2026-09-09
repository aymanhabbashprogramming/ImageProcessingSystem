namespace Görüntü_işleme.Screens
{
    partial class FiltreUygulanması_UnsharpScreen
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
            this.kryptonGroup1 = new Krypton.Toolkit.KryptonGroup();
            this.OriginalImage = new System.Windows.Forms.PictureBox();
            this.OpenImage = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.TrackBar1 = new Krypton.Toolkit.KryptonTrackBar();
            this.kryptonGroup2 = new Krypton.Toolkit.KryptonGroup();
            this.EditedImage = new System.Windows.Forms.PictureBox();
            this.btnPerform = new Krypton.Toolkit.KryptonButton();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.btnPrevious = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2.Panel)).BeginInit();
            this.kryptonGroup2.Panel.SuspendLayout();
            this.kryptonGroup2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Location = new System.Drawing.Point(23, 27);
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.OriginalImage);
            this.kryptonGroup1.Size = new System.Drawing.Size(324, 324);
            this.kryptonGroup1.StateCommon.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.kryptonGroup1.StateCommon.Border.Rounding = 20F;
            this.kryptonGroup1.TabIndex = 68;
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
            // OpenImage
            // 
            this.OpenImage.Location = new System.Drawing.Point(81, 357);
            this.OpenImage.Name = "OpenImage";
            this.OpenImage.Size = new System.Drawing.Size(200, 43);
            this.OpenImage.StateCommon.Border.Rounding = 15F;
            this.OpenImage.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenImage.TabIndex = 67;
            this.OpenImage.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.OpenImage.Values.Text = "Görüntü Aç";
            this.OpenImage.Click += new System.EventHandler(this.OpenImage_Click);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.AutoSize = false;
            this.kryptonLabel2.Location = new System.Drawing.Point(33, 422);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(183, 32);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 74;
            this.kryptonLabel2.Values.Text = "Keskinlik Miktari : ";
            // 
            // TrackBar1
            // 
            this.TrackBar1.AutoSize = false;
            this.TrackBar1.Location = new System.Drawing.Point(213, 422);
            this.TrackBar1.Maximum = 30;
            this.TrackBar1.Minimum = 1;
            this.TrackBar1.Name = "TrackBar1";
            this.TrackBar1.Size = new System.Drawing.Size(464, 32);
            this.TrackBar1.TabIndex = 73;
            this.TrackBar1.Value = 1;
            // 
            // kryptonGroup2
            // 
            this.kryptonGroup2.Location = new System.Drawing.Point(353, 27);
            // 
            // kryptonGroup2.Panel
            // 
            this.kryptonGroup2.Panel.Controls.Add(this.EditedImage);
            this.kryptonGroup2.Size = new System.Drawing.Size(324, 324);
            this.kryptonGroup2.StateCommon.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.kryptonGroup2.StateCommon.Border.Rounding = 20F;
            this.kryptonGroup2.TabIndex = 76;
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
            // btnPerform
            // 
            this.btnPerform.Location = new System.Drawing.Point(413, 357);
            this.btnPerform.Name = "btnPerform";
            this.btnPerform.Size = new System.Drawing.Size(205, 43);
            this.btnPerform.StateCommon.Border.Rounding = 15F;
            this.btnPerform.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerform.TabIndex = 77;
            this.btnPerform.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnPerform.Values.Text = "uygula";
            this.btnPerform.Click += new System.EventHandler(this.btnPerform_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(503, 491);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(174, 43);
            this.btnSave.StateCommon.Border.Rounding = 15F;
            this.btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.TabIndex = 78;
            this.btnSave.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSave.Values.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(399, 491);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(98, 43);
            this.btnPrevious.StateCommon.Border.Rounding = 15F;
            this.btnPrevious.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.TabIndex = 79;
            this.btnPrevious.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnPrevious.Values.Text = "Geri Al";
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // FiltreUygulanması_UnsharpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(710, 557);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPerform);
            this.Controls.Add(this.kryptonGroup2);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.TrackBar1);
            this.Controls.Add(this.kryptonGroup1);
            this.Controls.Add(this.OpenImage);
            this.Name = "FiltreUygulanması_UnsharpScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Görüntü Üzerinde Filtre Uygulanması";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2.Panel)).EndInit();
            this.kryptonGroup2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2)).EndInit();
            this.kryptonGroup2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EditedImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private System.Windows.Forms.PictureBox OriginalImage;
        private Krypton.Toolkit.KryptonButton OpenImage;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTrackBar TrackBar1;
        private Krypton.Toolkit.KryptonGroup kryptonGroup2;
        private System.Windows.Forms.PictureBox EditedImage;
        private Krypton.Toolkit.KryptonButton btnPerform;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonButton btnPrevious;
    }
}