
namespace Text_to_Speech_Demo
{
    partial class TextToSpeechForm
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
            this.buttonTTS = new System.Windows.Forms.Button();
            this.textboxInputFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openInputFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonBrowseInputFile = new System.Windows.Forms.Button();
            this.buttonOutputFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOutputFile = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxVoice = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonTTS
            // 
            this.buttonTTS.Location = new System.Drawing.Point(201, 125);
            this.buttonTTS.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTTS.Name = "buttonTTS";
            this.buttonTTS.Size = new System.Drawing.Size(202, 34);
            this.buttonTTS.TabIndex = 5;
            this.buttonTTS.Text = "Convert Text to Speech";
            this.buttonTTS.UseVisualStyleBackColor = true;
            this.buttonTTS.Click += new System.EventHandler(this.buttonTTS_Click);
            // 
            // textboxInputFile
            // 
            this.textboxInputFile.Location = new System.Drawing.Point(144, 16);
            this.textboxInputFile.Margin = new System.Windows.Forms.Padding(2);
            this.textboxInputFile.Name = "textboxInputFile";
            this.textboxInputFile.Size = new System.Drawing.Size(397, 29);
            this.textboxInputFile.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input text file";
            // 
            // openInputFileDialog
            // 
            this.openInputFileDialog.Filter = "Text files (*.txt)|*.txt";
            // 
            // buttonBrowseInputFile
            // 
            this.buttonBrowseInputFile.Location = new System.Drawing.Point(546, 16);
            this.buttonBrowseInputFile.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBrowseInputFile.Name = "buttonBrowseInputFile";
            this.buttonBrowseInputFile.Size = new System.Drawing.Size(30, 27);
            this.buttonBrowseInputFile.TabIndex = 1;
            this.buttonBrowseInputFile.Text = "...";
            this.buttonBrowseInputFile.UseVisualStyleBackColor = true;
            this.buttonBrowseInputFile.Click += new System.EventHandler(this.buttonBrowseInputFile_Click);
            // 
            // buttonOutputFile
            // 
            this.buttonOutputFile.Location = new System.Drawing.Point(546, 48);
            this.buttonOutputFile.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOutputFile.Name = "buttonOutputFile";
            this.buttonOutputFile.Size = new System.Drawing.Size(30, 27);
            this.buttonOutputFile.TabIndex = 3;
            this.buttonOutputFile.Text = "...";
            this.buttonOutputFile.UseVisualStyleBackColor = true;
            this.buttonOutputFile.Click += new System.EventHandler(this.buttonOutputFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output wav path";
            // 
            // textBoxOutputFile
            // 
            this.textBoxOutputFile.Location = new System.Drawing.Point(144, 48);
            this.textBoxOutputFile.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOutputFile.Name = "textBoxOutputFile";
            this.textBoxOutputFile.Size = new System.Drawing.Size(397, 29);
            this.textBoxOutputFile.TabIndex = 2;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(14, 178);
            this.textBoxStatus.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(562, 80);
            this.textBoxStatus.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Voice";
            // 
            // comboBoxVoice
            // 
            this.comboBoxVoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVoice.FormattingEnabled = true;
            this.comboBoxVoice.Location = new System.Drawing.Point(144, 82);
            this.comboBoxVoice.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxVoice.Name = "comboBoxVoice";
            this.comboBoxVoice.Size = new System.Drawing.Size(173, 29);
            this.comboBoxVoice.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Status";
            // 
            // TextToSpeechForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(591, 270);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxVoice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.buttonOutputFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxOutputFile);
            this.Controls.Add(this.buttonBrowseInputFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxInputFile);
            this.Controls.Add(this.buttonTTS);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "TextToSpeechForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text-to-Speech Demo for Telugu (te-in)";
            this.Load += new System.EventHandler(this.TextToSpeechForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTTS;
        private System.Windows.Forms.TextBox textboxInputFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openInputFileDialog;
        private System.Windows.Forms.Button buttonBrowseInputFile;
        private System.Windows.Forms.Button buttonOutputFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOutputFile;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxVoice;
        private System.Windows.Forms.Label label4;
    }
}

