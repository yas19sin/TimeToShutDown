namespace TimeToShutDown
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Startbtn = new System.Windows.Forms.Button();
            this.txtBoxTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.InfoTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Startbtn
            // 
            this.Startbtn.Location = new System.Drawing.Point(183, 313);
            this.Startbtn.Name = "Startbtn";
            this.Startbtn.Size = new System.Drawing.Size(93, 39);
            this.Startbtn.TabIndex = 0;
            this.Startbtn.Text = "Start CountDown";
            this.Startbtn.UseVisualStyleBackColor = true;
            this.Startbtn.Click += new System.EventHandler(this.Startbtn_Click);
            // 
            // txtBoxTime
            // 
            this.txtBoxTime.Location = new System.Drawing.Point(253, 250);
            this.txtBoxTime.Multiline = true;
            this.txtBoxTime.Name = "txtBoxTime";
            this.txtBoxTime.Size = new System.Drawing.Size(117, 36);
            this.txtBoxTime.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "TimeToShutDown";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.Location = new System.Drawing.Point(121, 176);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(0, 25);
            this.InfoLabel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Info:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "TimeLeft:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Type Time in Seconds:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(168, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Just Close The Program to Stop the CountDown";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Still in Development: V0.1";
            // 
            // InfoTxtBox
            // 
            this.InfoTxtBox.Enabled = false;
            this.InfoTxtBox.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoTxtBox.Location = new System.Drawing.Point(156, 98);
            this.InfoTxtBox.Name = "InfoTxtBox";
            this.InfoTxtBox.Size = new System.Drawing.Size(137, 36);
            this.InfoTxtBox.TabIndex = 12;
            this.InfoTxtBox.Text = "10";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(440, 406);
            this.Controls.Add(this.InfoTxtBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxTime);
            this.Controls.Add(this.Startbtn);
            this.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Time2ShutDown";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Startbtn;
        private System.Windows.Forms.TextBox txtBoxTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox InfoTxtBox;
    }
}

