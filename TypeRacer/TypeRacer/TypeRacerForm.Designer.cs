namespace TypeRacer
{
    partial class GameForm
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
            this.txtWholeTextToBeWritten = new System.Windows.Forms.TextBox();
            this.txtUserWordInput = new System.Windows.Forms.TextBox();
            this.txtActualWordToWrite = new System.Windows.Forms.TextBox();
            this.txtWordsPerMinute = new System.Windows.Forms.TextBox();
            this.txtPassedTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtWholeTextToBeWritten
            // 
            this.txtWholeTextToBeWritten.Enabled = false;
            this.txtWholeTextToBeWritten.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWholeTextToBeWritten.Location = new System.Drawing.Point(12, 12);
            this.txtWholeTextToBeWritten.Multiline = true;
            this.txtWholeTextToBeWritten.Name = "txtWholeTextToBeWritten";
            this.txtWholeTextToBeWritten.ReadOnly = true;
            this.txtWholeTextToBeWritten.Size = new System.Drawing.Size(453, 294);
            this.txtWholeTextToBeWritten.TabIndex = 0;
            this.txtWholeTextToBeWritten.Text = "test TEST";
            // 
            // txtUserWordInput
            // 
            this.txtUserWordInput.CausesValidation = false;
            this.txtUserWordInput.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserWordInput.Location = new System.Drawing.Point(12, 345);
            this.txtUserWordInput.Name = "txtUserWordInput";
            this.txtUserWordInput.Size = new System.Drawing.Size(224, 27);
            this.txtUserWordInput.TabIndex = 1;
            this.txtUserWordInput.TextChanged += new System.EventHandler(this.txtUserWordInput_TextChanged);
            // 
            // txtActualWordToWrite
            // 
            this.txtActualWordToWrite.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActualWordToWrite.Location = new System.Drawing.Point(12, 312);
            this.txtActualWordToWrite.Name = "txtActualWordToWrite";
            this.txtActualWordToWrite.ReadOnly = true;
            this.txtActualWordToWrite.Size = new System.Drawing.Size(224, 27);
            this.txtActualWordToWrite.TabIndex = 2;
            // 
            // txtWordsPerMinute
            // 
            this.txtWordsPerMinute.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWordsPerMinute.Location = new System.Drawing.Point(242, 312);
            this.txtWordsPerMinute.Name = "txtWordsPerMinute";
            this.txtWordsPerMinute.ReadOnly = true;
            this.txtWordsPerMinute.Size = new System.Drawing.Size(223, 27);
            this.txtWordsPerMinute.TabIndex = 3;
            // 
            // txtPassedTime
            // 
            this.txtPassedTime.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassedTime.Location = new System.Drawing.Point(242, 345);
            this.txtPassedTime.Name = "txtPassedTime";
            this.txtPassedTime.ReadOnly = true;
            this.txtPassedTime.Size = new System.Drawing.Size(223, 27);
            this.txtPassedTime.TabIndex = 4;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 380);
            this.Controls.Add(this.txtPassedTime);
            this.Controls.Add(this.txtWordsPerMinute);
            this.Controls.Add(this.txtActualWordToWrite);
            this.Controls.Add(this.txtUserWordInput);
            this.Controls.Add(this.txtWholeTextToBeWritten);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(493, 419);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(493, 419);
            this.Name = "GameForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWholeTextToBeWritten;
        private System.Windows.Forms.TextBox txtUserWordInput;
        private System.Windows.Forms.TextBox txtActualWordToWrite;
        private System.Windows.Forms.TextBox txtWordsPerMinute;
        private System.Windows.Forms.TextBox txtPassedTime;
    }
}

