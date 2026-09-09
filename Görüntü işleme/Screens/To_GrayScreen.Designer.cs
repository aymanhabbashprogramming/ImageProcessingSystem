namespace Görüntü_işleme.Screens
{
    partial class To_GrayScreen
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
            this.OriginalImage = new System.Windows.Forms.PictureBox();
            this.EditedImage = new System.Windows.Forms.PictureBox();
            this.GoPreviousStep = new Krypton.Toolkit.KryptonButton();
            this.btnTo_Gray = new Krypton.Toolkit.KryptonButton();
            this.OpenImage = new Krypton.Toolkit.KryptonButton();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.kryptonGroup1 = new Krypton.Toolkit.KryptonGroup();
            this.kryptonGroup2 = new Krypton.Toolkit.KryptonGroup();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2.Panel)).BeginInit();
            this.kryptonGroup2.Panel.SuspendLayout();
            this.kryptonGroup2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OriginalImage
            // 
            this.OriginalImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OriginalImage.Location = new System.Drawing.Point(3, 3);
            this.OriginalImage.Name = "OriginalImage";
            this.OriginalImage.Size = new System.Drawing.Size(300, 300);
            this.OriginalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OriginalImage.TabIndex = 0;
            this.OriginalImage.TabStop = false;
            // 
            // EditedImage
            // 
            this.EditedImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EditedImage.Location = new System.Drawing.Point(3, 3);
            this.EditedImage.Name = "EditedImage";
            this.EditedImage.Size = new System.Drawing.Size(300, 300);
            this.EditedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EditedImage.TabIndex = 1;
            this.EditedImage.TabStop = false;
            // 
            // GoPreviousStep
            // 
            this.GoPreviousStep.Location = new System.Drawing.Point(501, 342);
            this.GoPreviousStep.Name = "GoPreviousStep";
            this.GoPreviousStep.Size = new System.Drawing.Size(151, 43);
            this.GoPreviousStep.StateCommon.Border.Rounding = 15F;
            this.GoPreviousStep.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoPreviousStep.TabIndex = 12;
            this.GoPreviousStep.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.GoPreviousStep.Values.Text = "Geri al";
            this.GoPreviousStep.Click += new System.EventHandler(this.GoPreviousStep_Click_1);
            // 
            // btnTo_Gray
            // 
            this.btnTo_Gray.Location = new System.Drawing.Point(161, 342);
            this.btnTo_Gray.Name = "btnTo_Gray";
            this.btnTo_Gray.Size = new System.Drawing.Size(185, 43);
            this.btnTo_Gray.StateCommon.Border.Rounding = 15F;
            this.btnTo_Gray.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTo_Gray.TabIndex = 11;
            this.btnTo_Gray.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnTo_Gray.Values.Text = "Griye Dönüştür";
            this.btnTo_Gray.Click += new System.EventHandler(this.btnTo_Gray_Click_1);
            // 
            // OpenImage
            // 
            this.OpenImage.Location = new System.Drawing.Point(12, 342);
            this.OpenImage.Name = "OpenImage";
            this.OpenImage.Size = new System.Drawing.Size(143, 43);
            this.OpenImage.StateCommon.Border.Rounding = 15F;
            this.OpenImage.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenImage.TabIndex = 10;
            this.OpenImage.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.OpenImage.Values.Text = "Görüntü Aç";
            this.OpenImage.Click += new System.EventHandler(this.OpenImage_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(352, 342);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 43);
            this.btnSave.StateCommon.Border.Rounding = 15F;
            this.btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.TabIndex = 32;
            this.btnSave.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSave.Values.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Location = new System.Drawing.Point(12, 12);
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.OriginalImage);
            this.kryptonGroup1.Size = new System.Drawing.Size(324, 324);
            this.kryptonGroup1.StateCommon.Back.Color1 = System.Drawing.Color.Goldenrod;
            this.kryptonGroup1.StateCommon.Border.Rounding = 20F;
            this.kryptonGroup1.TabIndex = 61;
            // 
            // kryptonGroup2
            // 
            this.kryptonGroup2.Location = new System.Drawing.Point(342, 12);
            // 
            // kryptonGroup2.Panel
            // 
            this.kryptonGroup2.Panel.Controls.Add(this.EditedImage);
            this.kryptonGroup2.Size = new System.Drawing.Size(324, 324);
            this.kryptonGroup2.StateCommon.Back.Color1 = System.Drawing.Color.Goldenrod;
            this.kryptonGroup2.StateCommon.Border.Rounding = 20F;
            this.kryptonGroup2.TabIndex = 62;
            // 
            // To_GrayScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 405);
            this.Controls.Add(this.kryptonGroup2);
            this.Controls.Add(this.kryptonGroup1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.GoPreviousStep);
            this.Controls.Add(this.btnTo_Gray);
            this.Controls.Add(this.OpenImage);
            this.Name = "To_GrayScreen";
            this.Text = "Gri Dönüşüm";
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2.Panel)).EndInit();
            this.kryptonGroup2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2)).EndInit();
            this.kryptonGroup2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox OriginalImage;
        private System.Windows.Forms.PictureBox EditedImage;
        private Krypton.Toolkit.KryptonButton GoPreviousStep;
        private Krypton.Toolkit.KryptonButton btnTo_Gray;
        private Krypton.Toolkit.KryptonButton OpenImage;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private Krypton.Toolkit.KryptonGroup kryptonGroup2;
    }
}