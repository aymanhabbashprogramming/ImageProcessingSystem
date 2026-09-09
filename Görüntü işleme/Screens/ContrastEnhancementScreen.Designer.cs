namespace Görüntü_işleme.Screens
{
    partial class ContrastEnhancementScreen
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
            this.GoPreviousStep = new Krypton.Toolkit.KryptonButton();
            this.btnApply = new Krypton.Toolkit.KryptonButton();
            this.OpenImage = new Krypton.Toolkit.KryptonButton();
            this.EditedImage = new System.Windows.Forms.PictureBox();
            this.OriginalImage = new System.Windows.Forms.PictureBox();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.kryptonTrackBar1 = new Krypton.Toolkit.KryptonTrackBar();
            this.kryptonGroup3 = new Krypton.Toolkit.KryptonGroup();
            this.kryptonGroup1 = new Krypton.Toolkit.KryptonGroup();
            ((System.ComponentModel.ISupportInitialize)(this.EditedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3.Panel)).BeginInit();
            this.kryptonGroup3.Panel.SuspendLayout();
            this.kryptonGroup3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GoPreviousStep
            // 
            this.GoPreviousStep.Location = new System.Drawing.Point(508, 342);
            this.GoPreviousStep.Name = "GoPreviousStep";
            this.GoPreviousStep.Size = new System.Drawing.Size(144, 43);
            this.GoPreviousStep.StateCommon.Border.Rounding = 15F;
            this.GoPreviousStep.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoPreviousStep.TabIndex = 14;
            this.GoPreviousStep.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.GoPreviousStep.Values.Text = "Geri al";
            this.GoPreviousStep.Click += new System.EventHandler(this.GoPreviousStep_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(166, 342);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(156, 43);
            this.btnApply.StateCommon.Border.Rounding = 15F;
            this.btnApply.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.TabIndex = 13;
            this.btnApply.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnApply.Values.Text = "Uygula";
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // OpenImage
            // 
            this.OpenImage.Location = new System.Drawing.Point(22, 342);
            this.OpenImage.Name = "OpenImage";
            this.OpenImage.Size = new System.Drawing.Size(138, 43);
            this.OpenImage.StateCommon.Border.Rounding = 15F;
            this.OpenImage.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenImage.TabIndex = 12;
            this.OpenImage.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.OpenImage.Values.Text = "Görüntü Aç";
            this.OpenImage.Click += new System.EventHandler(this.OpenImage_Click);
            // 
            // EditedImage
            // 
            this.EditedImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EditedImage.Location = new System.Drawing.Point(3, 3);
            this.EditedImage.Name = "EditedImage";
            this.EditedImage.Size = new System.Drawing.Size(300, 300);
            this.EditedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EditedImage.TabIndex = 11;
            this.EditedImage.TabStop = false;
            // 
            // OriginalImage
            // 
            this.OriginalImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OriginalImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OriginalImage.Location = new System.Drawing.Point(3, 3);
            this.OriginalImage.Name = "OriginalImage";
            this.OriginalImage.Size = new System.Drawing.Size(300, 300);
            this.OriginalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OriginalImage.TabIndex = 10;
            this.OriginalImage.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(352, 342);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 43);
            this.btnSave.StateCommon.Border.Rounding = 15F;
            this.btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.TabIndex = 29;
            this.btnSave.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSave.Values.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // kryptonTrackBar1
            // 
            this.kryptonTrackBar1.Location = new System.Drawing.Point(22, 405);
            this.kryptonTrackBar1.Name = "kryptonTrackBar1";
            this.kryptonTrackBar1.Size = new System.Drawing.Size(630, 27);
            this.kryptonTrackBar1.TabIndex = 30;
            this.kryptonTrackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // kryptonGroup3
            // 
            this.kryptonGroup3.Location = new System.Drawing.Point(12, 12);
            // 
            // kryptonGroup3.Panel
            // 
            this.kryptonGroup3.Panel.Controls.Add(this.OriginalImage);
            this.kryptonGroup3.Size = new System.Drawing.Size(324, 324);
            this.kryptonGroup3.StateCommon.Back.Color1 = System.Drawing.Color.DarkOliveGreen;
            this.kryptonGroup3.StateCommon.Border.Rounding = 20F;
            this.kryptonGroup3.TabIndex = 60;
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Location = new System.Drawing.Point(342, 12);
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.EditedImage);
            this.kryptonGroup1.Size = new System.Drawing.Size(324, 324);
            this.kryptonGroup1.StateCommon.Back.Color1 = System.Drawing.Color.DarkOliveGreen;
            this.kryptonGroup1.StateCommon.Border.Rounding = 20F;
            this.kryptonGroup1.TabIndex = 61;
            // 
            // ContrastEnhancementScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 454);
            this.Controls.Add(this.kryptonGroup1);
            this.Controls.Add(this.kryptonGroup3);
            this.Controls.Add(this.kryptonTrackBar1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.GoPreviousStep);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.OpenImage);
            this.Name = "ContrastEnhancementScreen";
            this.Text = "Kontrast Artırma";
            this.Load += new System.EventHandler(this.ContrastEnhancementScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EditedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3.Panel)).EndInit();
            this.kryptonGroup3.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3)).EndInit();
            this.kryptonGroup3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonButton GoPreviousStep;
        private Krypton.Toolkit.KryptonButton btnApply;
        private Krypton.Toolkit.KryptonButton OpenImage;
        private System.Windows.Forms.PictureBox EditedImage;
        private System.Windows.Forms.PictureBox OriginalImage;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonTrackBar kryptonTrackBar1;
        private Krypton.Toolkit.KryptonGroup kryptonGroup3;
        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
    }
}