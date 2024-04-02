namespace AppArchivosNoEstruc
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenTxt = new System.Windows.Forms.Button();
            this.rtbDataTxt = new System.Windows.Forms.RichTextBox();
            this.btnOpenPDF = new System.Windows.Forms.Button();
            this.btnOpenDOCX = new System.Windows.Forms.Button();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.btnOpenWEBSITE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenTxt
            // 
            this.btnOpenTxt.Location = new System.Drawing.Point(25, 32);
            this.btnOpenTxt.Name = "btnOpenTxt";
            this.btnOpenTxt.Size = new System.Drawing.Size(119, 34);
            this.btnOpenTxt.TabIndex = 0;
            this.btnOpenTxt.Text = "OPEN TXT";
            this.btnOpenTxt.UseVisualStyleBackColor = true;
            this.btnOpenTxt.Click += new System.EventHandler(this.btnOpenTxt_Click);
            // 
            // rtbDataTxt
            // 
            this.rtbDataTxt.Location = new System.Drawing.Point(25, 115);
            this.rtbDataTxt.Name = "rtbDataTxt";
            this.rtbDataTxt.Size = new System.Drawing.Size(440, 446);
            this.rtbDataTxt.TabIndex = 1;
            this.rtbDataTxt.Text = "";
            // 
            // btnOpenPDF
            // 
            this.btnOpenPDF.Location = new System.Drawing.Point(172, 35);
            this.btnOpenPDF.Name = "btnOpenPDF";
            this.btnOpenPDF.Size = new System.Drawing.Size(119, 31);
            this.btnOpenPDF.TabIndex = 2;
            this.btnOpenPDF.Text = "OPEN PDF";
            this.btnOpenPDF.UseVisualStyleBackColor = true;
            this.btnOpenPDF.Click += new System.EventHandler(this.btnOpenPDF_Click);
            // 
            // btnOpenDOCX
            // 
            this.btnOpenDOCX.Location = new System.Drawing.Point(320, 36);
            this.btnOpenDOCX.Name = "btnOpenDOCX";
            this.btnOpenDOCX.Size = new System.Drawing.Size(119, 28);
            this.btnOpenDOCX.TabIndex = 3;
            this.btnOpenDOCX.Text = "OPEN DOCX";
            this.btnOpenDOCX.UseVisualStyleBackColor = true;
            this.btnOpenDOCX.Click += new System.EventHandler(this.btnOpenDOCX_Click);
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Location = new System.Drawing.Point(522, 38);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(119, 28);
            this.btnOpenImage.TabIndex = 4;
            this.btnOpenImage.Text = "OPEN IMAGE";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(522, 115);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(443, 446);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxImage.TabIndex = 5;
            this.pictureBoxImage.TabStop = false;
            // 
            // btnOpenWEBSITE
            // 
            this.btnOpenWEBSITE.Location = new System.Drawing.Point(690, 40);
            this.btnOpenWEBSITE.Name = "btnOpenWEBSITE";
            this.btnOpenWEBSITE.Size = new System.Drawing.Size(136, 26);
            this.btnOpenWEBSITE.TabIndex = 6;
            this.btnOpenWEBSITE.Text = "OPEN WEBSITE";
            this.btnOpenWEBSITE.UseVisualStyleBackColor = true;
            this.btnOpenWEBSITE.Click += new System.EventHandler(this.btnOpenWEBSITE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 644);
            this.Controls.Add(this.btnOpenWEBSITE);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.btnOpenImage);
            this.Controls.Add(this.btnOpenDOCX);
            this.Controls.Add(this.btnOpenPDF);
            this.Controls.Add(this.rtbDataTxt);
            this.Controls.Add(this.btnOpenTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenTxt;
        private System.Windows.Forms.RichTextBox rtbDataTxt;
        private System.Windows.Forms.Button btnOpenPDF;
        private System.Windows.Forms.Button btnOpenDOCX;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Button btnOpenWEBSITE;
    }
}

