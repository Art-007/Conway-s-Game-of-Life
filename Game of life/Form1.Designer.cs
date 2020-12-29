namespace Life
{
    partial class Form2
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ResetBttn = new System.Windows.Forms.Button();
            this.NextGenBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // ResetBttn
            // 
            this.ResetBttn.Location = new System.Drawing.Point(1038, 272);
            this.ResetBttn.Name = "ResetBttn";
            this.ResetBttn.Size = new System.Drawing.Size(150, 86);
            this.ResetBttn.TabIndex = 2;
            this.ResetBttn.Text = "Reset";
            this.ResetBttn.UseVisualStyleBackColor = true;
            this.ResetBttn.Click += new System.EventHandler(this.ResetBttn_Click_1);
            // 
            // NextGenBttn
            // 
            this.NextGenBttn.Location = new System.Drawing.Point(963, 83);
            this.NextGenBttn.Name = "NextGenBttn";
            this.NextGenBttn.Size = new System.Drawing.Size(292, 142);
            this.NextGenBttn.TabIndex = 3;
            this.NextGenBttn.Text = "Next Generation";
            this.NextGenBttn.UseVisualStyleBackColor = true;
            this.NextGenBttn.Click += new System.EventHandler(this.NextGenBttn_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1790, 782);
            this.Controls.Add(this.NextGenBttn);
            this.Controls.Add(this.ResetBttn);
            this.Name = "Form2";
            this.Text = "Game of Life";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button ResetBttn;
        private System.Windows.Forms.Button NextGenBttn;
    }
}

