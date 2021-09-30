
namespace VET
{
    partial class Form6
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
            this.label17 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.LightSalmon;
            this.label17.Location = new System.Drawing.Point(12, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(204, 23);
            this.label17.TabIndex = 97;
            this.label17.Text = "SAHİP BİLGİLERİ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.BackgroundImage = global::VET.Properties.Resources.human;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Century", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightCyan;
            this.button1.Location = new System.Drawing.Point(75, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 77);
            this.button1.TabIndex = 96;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LightSalmon;
            this.label1.Location = new System.Drawing.Point(272, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 23);
            this.label1.TabIndex = 99;
            this.label1.Text = "HASTA BİLGİLERİ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.BackgroundImage = global::VET.Properties.Resources.cat;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Font = new System.Drawing.Font("Century", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.LightCyan;
            this.button2.Location = new System.Drawing.Point(328, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 77);
            this.button2.TabIndex = 98;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.LightGreen;
            this.linkLabel2.Location = new System.Drawing.Point(360, 143);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(121, 16);
            this.linkLabel2.TabIndex = 100;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Ana sayfaya dön";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(493, 168);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.Leave += new System.EventHandler(this.Form6_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}