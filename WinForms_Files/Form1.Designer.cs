
namespace WinForms_Files
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenStandart = new System.Windows.Forms.Button();
            this.textBoxFileData = new System.Windows.Forms.TextBox();
            this.buttonSelectOpenFile = new System.Windows.Forms.Button();
            this.buttonSelectAndSaveFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpenStandart
            // 
            this.buttonOpenStandart.Location = new System.Drawing.Point(41, 35);
            this.buttonOpenStandart.Name = "buttonOpenStandart";
            this.buttonOpenStandart.Size = new System.Drawing.Size(252, 53);
            this.buttonOpenStandart.TabIndex = 0;
            this.buttonOpenStandart.Text = "Открыть стандартный файл";
            this.buttonOpenStandart.UseVisualStyleBackColor = true;
            this.buttonOpenStandart.Click += new System.EventHandler(this.buttonOpenStandart_Click);
            // 
            // textBoxFileData
            // 
            this.textBoxFileData.Location = new System.Drawing.Point(345, 12);
            this.textBoxFileData.Multiline = true;
            this.textBoxFileData.Name = "textBoxFileData";
            this.textBoxFileData.Size = new System.Drawing.Size(503, 342);
            this.textBoxFileData.TabIndex = 1;
            // 
            // buttonSelectOpenFile
            // 
            this.buttonSelectOpenFile.Location = new System.Drawing.Point(41, 155);
            this.buttonSelectOpenFile.Name = "buttonSelectOpenFile";
            this.buttonSelectOpenFile.Size = new System.Drawing.Size(252, 65);
            this.buttonSelectOpenFile.TabIndex = 2;
            this.buttonSelectOpenFile.Text = "Выбрать и открыть файл";
            this.buttonSelectOpenFile.UseVisualStyleBackColor = true;
            this.buttonSelectOpenFile.Click += new System.EventHandler(this.buttonSelectOpenFile_Click);
            // 
            // buttonSelectAndSaveFile
            // 
            this.buttonSelectAndSaveFile.Location = new System.Drawing.Point(41, 290);
            this.buttonSelectAndSaveFile.Name = "buttonSelectAndSaveFile";
            this.buttonSelectAndSaveFile.Size = new System.Drawing.Size(252, 64);
            this.buttonSelectAndSaveFile.TabIndex = 3;
            this.buttonSelectAndSaveFile.Text = "Выбрать и сохранить в файл";
            this.buttonSelectAndSaveFile.UseVisualStyleBackColor = true;
            this.buttonSelectAndSaveFile.Click += new System.EventHandler(this.buttonSelectAndSaveFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 366);
            this.Controls.Add(this.buttonSelectAndSaveFile);
            this.Controls.Add(this.buttonSelectOpenFile);
            this.Controls.Add(this.textBoxFileData);
            this.Controls.Add(this.buttonOpenStandart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenStandart;
        private System.Windows.Forms.TextBox textBoxFileData;
        private System.Windows.Forms.Button buttonSelectOpenFile;
        private System.Windows.Forms.Button buttonSelectAndSaveFile;
    }
}

