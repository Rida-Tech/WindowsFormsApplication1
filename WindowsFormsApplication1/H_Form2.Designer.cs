namespace WindowsFormsApplication1
{
    partial class H_Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tuser = new System.Windows.Forms.TextBox();
            this.tpass = new System.Windows.Forms.TextBox();
            this.bconnecter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Authentification";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "user : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "pass : ";
            // 
            // tuser
            // 
            this.tuser.Location = new System.Drawing.Point(153, 63);
            this.tuser.Name = "tuser";
            this.tuser.Size = new System.Drawing.Size(100, 20);
            this.tuser.TabIndex = 3;
            // 
            // tpass
            // 
            this.tpass.Location = new System.Drawing.Point(153, 112);
            this.tpass.Name = "tpass";
            this.tpass.Size = new System.Drawing.Size(100, 20);
            this.tpass.TabIndex = 4;
            // 
            // bconnecter
            // 
            this.bconnecter.Location = new System.Drawing.Point(153, 165);
            this.bconnecter.Name = "bconnecter";
            this.bconnecter.Size = new System.Drawing.Size(75, 23);
            this.bconnecter.TabIndex = 5;
            this.bconnecter.Text = "Connecter";
            this.bconnecter.UseVisualStyleBackColor = true;
            // 
            // H_Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 215);
            this.Controls.Add(this.bconnecter);
            this.Controls.Add(this.tpass);
            this.Controls.Add(this.tuser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "H_Form2";
            this.Text = "H_Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tuser;
        private System.Windows.Forms.TextBox tpass;
        private System.Windows.Forms.Button bconnecter;
    }
}