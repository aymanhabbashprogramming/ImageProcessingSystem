namespace Görüntü_işleme.Screens
{
    partial class CropScreen
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
            this.OpenImage = new Krypton.Toolkit.KryptonButton();
            this.EditedImage = new System.Windows.Forms.PictureBox();
            this.OriginalImage = new System.Windows.Forms.PictureBox();
            this.btnPerform = new Krypton.Toolkit.KryptonButton();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.EditedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImage)).BeginInit();
            this.SuspendLayout();
            // 
            // GoPreviousStep
            // 
            this.GoPreviousStep.Location = new System.Drawing.Point(529, 386);
            this.GoPreviousStep.Name = "GoPreviousStep";
            this.GoPreviousStep.Size = new System.Drawing.Size(117, 43);
            this.GoPreviousStep.StateCommon.Border.Rounding = 15F;
            this.GoPreviousStep.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoPreviousStep.TabIndex = 14;
            this.GoPreviousStep.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.GoPreviousStep.Values.Text = "Geri al";
            this.GoPreviousStep.Click += new System.EventHandler(this.GoPreviousStep_Click_1);
            // 
            // OpenImage
            // 
            this.OpenImage.Location = new System.Drawing.Point(32, 386);
            this.OpenImage.Name = "OpenImage";
            this.OpenImage.Size = new System.Drawing.Size(148, 43);
            this.OpenImage.StateCommon.Border.Rounding = 15F;
            this.OpenImage.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenImage.TabIndex = 12;
            this.OpenImage.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.OpenImage.Values.Text = "Görüntü Aç";
            this.OpenImage.Click += new System.EventHandler(this.OpenImage_Click_1);
            // 
            // EditedImage
            // 
            this.EditedImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EditedImage.Location = new System.Drawing.Point(413, 21);
            this.EditedImage.Name = "EditedImage";
            this.EditedImage.Size = new System.Drawing.Size(356, 346);
            this.EditedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EditedImage.TabIndex = 11;
            this.EditedImage.TabStop = false;
            // 
            // OriginalImage
            // 
            this.OriginalImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OriginalImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OriginalImage.Location = new System.Drawing.Point(32, 21);
            this.OriginalImage.Name = "OriginalImage";
            this.OriginalImage.Size = new System.Drawing.Size(371, 346);
            this.OriginalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OriginalImage.TabIndex = 10;
            this.OriginalImage.TabStop = false;
            this.OriginalImage.Paint += new System.Windows.Forms.PaintEventHandler(this.OriginalImage_Paint);
            this.OriginalImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OriginalImage_MouseDown);
            this.OriginalImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OriginalImage_MouseMove);
            this.OriginalImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OriginalImage_MouseUp);
            // 
            // btnPerform
            // 
            this.btnPerform.Location = new System.Drawing.Point(406, 386);
            this.btnPerform.Name = "btnPerform";
            this.btnPerform.Size = new System.Drawing.Size(117, 43);
            this.btnPerform.StateCommon.Border.Rounding = 15F;
            this.btnPerform.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerform.TabIndex = 15;
            this.btnPerform.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnPerform.Values.Text = "uygula";
            this.btnPerform.Click += new System.EventHandler(this.btnPerform_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(652, 386);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 43);
            this.btnSave.StateCommon.Border.Rounding = 15F;
            this.btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.TabIndex = 30;
            this.btnSave.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSave.Values.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(197, 386);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(117, 43);
            this.kryptonButton1.StateCommon.Border.Rounding = 15F;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.TabIndex = 31;
            this.kryptonButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton1.Values.Text = "Temizle";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // CropScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPerform);
            this.Controls.Add(this.GoPreviousStep);
            this.Controls.Add(this.OpenImage);
            this.Controls.Add(this.EditedImage);
            this.Controls.Add(this.OriginalImage);
            this.Name = "CropScreen";
            this.Text = "Görüntü Kırpma";
            ((System.ComponentModel.ISupportInitialize)(this.EditedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonButton GoPreviousStep;
        private Krypton.Toolkit.KryptonButton OpenImage;
        private System.Windows.Forms.PictureBox EditedImage;
        private System.Windows.Forms.PictureBox OriginalImage;
        private Krypton.Toolkit.KryptonButton btnPerform;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}