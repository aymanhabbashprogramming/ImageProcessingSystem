namespace Görüntü_işleme.Screens
{
    partial class Konvolusyon_MeanScreen
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
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.GoPreviousStep = new Krypton.Toolkit.KryptonButton();
            this.btnPerform = new Krypton.Toolkit.KryptonButton();
            this.OpenImage = new Krypton.Toolkit.KryptonButton();
            this.OriginalImage = new System.Windows.Forms.PictureBox();
            this.RadioButton_3 = new Krypton.Toolkit.KryptonRadioButton();
            this.RadioButton_5 = new Krypton.Toolkit.KryptonRadioButton();
            this.RadioButton_7 = new Krypton.Toolkit.KryptonRadioButton();
            this.kryptonGroup2 = new Krypton.Toolkit.KryptonGroup();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonGroup1 = new Krypton.Toolkit.KryptonGroup();
            this.kryptonGroup3 = new Krypton.Toolkit.KryptonGroup();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.EditedImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2.Panel)).BeginInit();
            this.kryptonGroup2.Panel.SuspendLayout();
            this.kryptonGroup2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3.Panel)).BeginInit();
            this.kryptonGroup3.Panel.SuspendLayout();
            this.kryptonGroup3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(549, 420);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 43);
            this.btnSave.StateCommon.Border.Rounding = 15F;
            this.btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.TabIndex = 16;
            this.btnSave.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSave.Values.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // GoPreviousStep
            // 
            this.GoPreviousStep.Location = new System.Drawing.Point(384, 420);
            this.GoPreviousStep.Name = "GoPreviousStep";
            this.GoPreviousStep.Size = new System.Drawing.Size(117, 43);
            this.GoPreviousStep.StateCommon.Border.Rounding = 15F;
            this.GoPreviousStep.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoPreviousStep.TabIndex = 15;
            this.GoPreviousStep.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.GoPreviousStep.Values.Text = "Geri al";
            this.GoPreviousStep.Click += new System.EventHandler(this.GoPreviousStep_Click);
            // 
            // btnPerform
            // 
            this.btnPerform.Location = new System.Drawing.Point(188, 420);
            this.btnPerform.Name = "btnPerform";
            this.btnPerform.Size = new System.Drawing.Size(148, 43);
            this.btnPerform.StateCommon.Border.Rounding = 15F;
            this.btnPerform.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerform.TabIndex = 14;
            this.btnPerform.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnPerform.Values.Text = "Uygula";
            this.btnPerform.Click += new System.EventHandler(this.btnPerform_Click);
            // 
            // OpenImage
            // 
            this.OpenImage.Location = new System.Drawing.Point(12, 342);
            this.OpenImage.Name = "OpenImage";
            this.OpenImage.Size = new System.Drawing.Size(148, 56);
            this.OpenImage.StateCommon.Border.Rounding = 15F;
            this.OpenImage.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenImage.TabIndex = 13;
            this.OpenImage.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.OpenImage.Values.Text = "Görüntü Aç";
            this.OpenImage.Click += new System.EventHandler(this.OpenImage_Click);
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
            // RadioButton_3
            // 
            this.RadioButton_3.AutoSize = false;
            this.RadioButton_3.Location = new System.Drawing.Point(405, 6);
            this.RadioButton_3.Name = "RadioButton_3";
            this.RadioButton_3.Size = new System.Drawing.Size(53, 25);
            this.RadioButton_3.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton_3.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.RadioButton_3.TabIndex = 45;
            this.RadioButton_3.Values.Text = "3";
            // 
            // RadioButton_5
            // 
            this.RadioButton_5.AutoSize = false;
            this.RadioButton_5.Location = new System.Drawing.Point(317, 6);
            this.RadioButton_5.Name = "RadioButton_5";
            this.RadioButton_5.Size = new System.Drawing.Size(53, 25);
            this.RadioButton_5.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton_5.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.RadioButton_5.TabIndex = 47;
            this.RadioButton_5.Values.Text = "5";
            // 
            // RadioButton_7
            // 
            this.RadioButton_7.AutoSize = false;
            this.RadioButton_7.Location = new System.Drawing.Point(229, 6);
            this.RadioButton_7.Name = "RadioButton_7";
            this.RadioButton_7.Size = new System.Drawing.Size(53, 25);
            this.RadioButton_7.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton_7.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.RadioButton_7.TabIndex = 48;
            this.RadioButton_7.Values.Text = "7";
            // 
            // kryptonGroup2
            // 
            this.kryptonGroup2.Location = new System.Drawing.Point(181, 342);
            // 
            // kryptonGroup2.Panel
            // 
            this.kryptonGroup2.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonGroup2.Panel.Controls.Add(this.RadioButton_7);
            this.kryptonGroup2.Panel.Controls.Add(this.pictureBox1);
            this.kryptonGroup2.Panel.Controls.Add(this.RadioButton_5);
            this.kryptonGroup2.Panel.Controls.Add(this.RadioButton_3);
            this.kryptonGroup2.Size = new System.Drawing.Size(485, 56);
            this.kryptonGroup2.StateCommon.Back.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.kryptonGroup2.StateCommon.Border.Rounding = 20F;
            this.kryptonGroup2.TabIndex = 49;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.AutoSize = false;
            this.kryptonLabel3.Location = new System.Drawing.Point(5, 6);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(188, 32);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 44;
            this.kryptonLabel3.Values.Text = "Maske Boyutu Seç";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(310, -362);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(606, 323);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Location = new System.Drawing.Point(12, 12);
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.OriginalImage);
            this.kryptonGroup1.Size = new System.Drawing.Size(324, 324);
            this.kryptonGroup1.StateCommon.Back.Color1 = System.Drawing.Color.Gold;
            this.kryptonGroup1.StateCommon.Border.Rounding = 20F;
            this.kryptonGroup1.TabIndex = 50;
            // 
            // kryptonGroup3
            // 
            this.kryptonGroup3.Location = new System.Drawing.Point(342, 12);
            // 
            // kryptonGroup3.Panel
            // 
            this.kryptonGroup3.Panel.Controls.Add(this.pictureBox3);
            this.kryptonGroup3.Panel.Controls.Add(this.EditedImage);
            this.kryptonGroup3.Size = new System.Drawing.Size(324, 324);
            this.kryptonGroup3.StateCommon.Back.Color1 = System.Drawing.Color.Gold;
            this.kryptonGroup3.StateCommon.Border.Rounding = 20F;
            this.kryptonGroup3.TabIndex = 51;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox3.Location = new System.Drawing.Point(310, -362);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(606, 323);
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // EditedImage
            // 
            this.EditedImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EditedImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditedImage.Location = new System.Drawing.Point(7, 3);
            this.EditedImage.Name = "EditedImage";
            this.EditedImage.Size = new System.Drawing.Size(300, 300);
            this.EditedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EditedImage.TabIndex = 11;
            this.EditedImage.TabStop = false;
            // 
            // Konvolusyon_MeanScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 475);
            this.Controls.Add(this.kryptonGroup3);
            this.Controls.Add(this.kryptonGroup1);
            this.Controls.Add(this.kryptonGroup2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.GoPreviousStep);
            this.Controls.Add(this.btnPerform);
            this.Controls.Add(this.OpenImage);
            this.Name = "Konvolusyon_MeanScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Konvolusyon İşlemi";
            this.Load += new System.EventHandler(this.Konvolusyon_MeanScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2.Panel)).EndInit();
            this.kryptonGroup2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2)).EndInit();
            this.kryptonGroup2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3.Panel)).EndInit();
            this.kryptonGroup3.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3)).EndInit();
            this.kryptonGroup3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditedImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonButton GoPreviousStep;
        private Krypton.Toolkit.KryptonButton btnPerform;
        private Krypton.Toolkit.KryptonButton OpenImage;
        private System.Windows.Forms.PictureBox OriginalImage;
        private Krypton.Toolkit.KryptonRadioButton RadioButton_3;
        private Krypton.Toolkit.KryptonRadioButton RadioButton_5;
        private Krypton.Toolkit.KryptonRadioButton RadioButton_7;
        private Krypton.Toolkit.KryptonGroup kryptonGroup2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private Krypton.Toolkit.KryptonGroup kryptonGroup3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox EditedImage;
    }
}