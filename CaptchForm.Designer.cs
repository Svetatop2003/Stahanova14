namespace Stahanova14.ModelEF
{
    partial class CaptchForm
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
            this.components = new System.ComponentModel.Container();
            this.buttonUpDate = new System.Windows.Forms.Button();
            this.labelCaptch = new System.Windows.Forms.Label();
            this.textBoxCaptch = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonUpDate
            // 
            this.buttonUpDate.Location = new System.Drawing.Point(186, 154);
            this.buttonUpDate.Name = "buttonUpDate";
            this.buttonUpDate.Size = new System.Drawing.Size(100, 34);
            this.buttonUpDate.TabIndex = 0;
            this.buttonUpDate.Text = "Обновить капчу";
            this.buttonUpDate.UseVisualStyleBackColor = true;
            this.buttonUpDate.Click += new System.EventHandler(this.buttonUpDate_Click);
            // 
            // labelCaptch
            // 
            this.labelCaptch.AutoSize = true;
            this.labelCaptch.Font = new System.Drawing.Font("Mistral", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaptch.Location = new System.Drawing.Point(176, 78);
            this.labelCaptch.Name = "labelCaptch";
            this.labelCaptch.Size = new System.Drawing.Size(114, 57);
            this.labelCaptch.TabIndex = 1;
            this.labelCaptch.Text = "label1";
            // 
            // textBoxCaptch
            // 
            this.textBoxCaptch.Location = new System.Drawing.Point(133, 265);
            this.textBoxCaptch.Name = "textBoxCaptch";
            this.textBoxCaptch.Size = new System.Drawing.Size(207, 20);
            this.textBoxCaptch.TabIndex = 2;
            this.textBoxCaptch.TextChanged += new System.EventHandler(this.textBoxCaptch_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CaptchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.textBoxCaptch);
            this.Controls.Add(this.labelCaptch);
            this.Controls.Add(this.buttonUpDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CaptchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CaptchForm";
            this.Load += new System.EventHandler(this.CaptchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpDate;
        private System.Windows.Forms.Label labelCaptch;
        private System.Windows.Forms.TextBox textBoxCaptch;
        private System.Windows.Forms.Timer timer1;
    }
}