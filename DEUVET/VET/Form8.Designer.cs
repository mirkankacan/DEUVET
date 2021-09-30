
namespace VET
{
    partial class Form8
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
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.kisilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hayvanlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.türDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastalıkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parazitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.karma1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.karma2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuduzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lösemiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mantarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ücretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kisilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hayvanlarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.LightGreen;
            this.linkLabel2.Location = new System.Drawing.Point(854, 644);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(121, 16);
            this.linkLabel2.TabIndex = 101;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Ana sayfaya dön";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tCDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.ücretDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kisilerBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(963, 307);
            this.dataGridView1.TabIndex = 102;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.türDataGridViewTextBoxColumn,
            this.cinsDataGridViewTextBoxColumn,
            this.hastalıkDataGridViewTextBoxColumn,
            this.parazitDataGridViewTextBoxColumn,
            this.karma1DataGridViewTextBoxColumn,
            this.karma2DataGridViewTextBoxColumn,
            this.kuduzDataGridViewTextBoxColumn,
            this.lösemiDataGridViewTextBoxColumn,
            this.mantarDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.hayvanlarBindingSource;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.Location = new System.Drawing.Point(12, 335);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(963, 301);
            this.dataGridView2.TabIndex = 103;
            // 
            // kisilerBindingSource
            // 
            this.kisilerBindingSource.DataSource = typeof(VET.kisiler);
            // 
            // hayvanlarBindingSource
            // 
            this.hayvanlarBindingSource.DataSource = typeof(VET.hayvanlar);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // türDataGridViewTextBoxColumn
            // 
            this.türDataGridViewTextBoxColumn.DataPropertyName = "Tür";
            this.türDataGridViewTextBoxColumn.HeaderText = "Tür";
            this.türDataGridViewTextBoxColumn.Name = "türDataGridViewTextBoxColumn";
            this.türDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cinsDataGridViewTextBoxColumn
            // 
            this.cinsDataGridViewTextBoxColumn.DataPropertyName = "Cins";
            this.cinsDataGridViewTextBoxColumn.HeaderText = "Cins";
            this.cinsDataGridViewTextBoxColumn.Name = "cinsDataGridViewTextBoxColumn";
            this.cinsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hastalıkDataGridViewTextBoxColumn
            // 
            this.hastalıkDataGridViewTextBoxColumn.DataPropertyName = "Hastalık";
            this.hastalıkDataGridViewTextBoxColumn.HeaderText = "Hastalık";
            this.hastalıkDataGridViewTextBoxColumn.Name = "hastalıkDataGridViewTextBoxColumn";
            this.hastalıkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parazitDataGridViewTextBoxColumn
            // 
            this.parazitDataGridViewTextBoxColumn.DataPropertyName = "Parazit";
            this.parazitDataGridViewTextBoxColumn.HeaderText = "Parazit";
            this.parazitDataGridViewTextBoxColumn.Name = "parazitDataGridViewTextBoxColumn";
            this.parazitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // karma1DataGridViewTextBoxColumn
            // 
            this.karma1DataGridViewTextBoxColumn.DataPropertyName = "Karma1";
            this.karma1DataGridViewTextBoxColumn.HeaderText = "Karma1";
            this.karma1DataGridViewTextBoxColumn.Name = "karma1DataGridViewTextBoxColumn";
            this.karma1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // karma2DataGridViewTextBoxColumn
            // 
            this.karma2DataGridViewTextBoxColumn.DataPropertyName = "Karma2";
            this.karma2DataGridViewTextBoxColumn.HeaderText = "Karma2";
            this.karma2DataGridViewTextBoxColumn.Name = "karma2DataGridViewTextBoxColumn";
            this.karma2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kuduzDataGridViewTextBoxColumn
            // 
            this.kuduzDataGridViewTextBoxColumn.DataPropertyName = "Kuduz";
            this.kuduzDataGridViewTextBoxColumn.HeaderText = "Kuduz";
            this.kuduzDataGridViewTextBoxColumn.Name = "kuduzDataGridViewTextBoxColumn";
            this.kuduzDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lösemiDataGridViewTextBoxColumn
            // 
            this.lösemiDataGridViewTextBoxColumn.DataPropertyName = "Lösemi";
            this.lösemiDataGridViewTextBoxColumn.HeaderText = "Lösemi";
            this.lösemiDataGridViewTextBoxColumn.Name = "lösemiDataGridViewTextBoxColumn";
            this.lösemiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mantarDataGridViewTextBoxColumn
            // 
            this.mantarDataGridViewTextBoxColumn.DataPropertyName = "Mantar";
            this.mantarDataGridViewTextBoxColumn.HeaderText = "Mantar";
            this.mantarDataGridViewTextBoxColumn.Name = "mantarDataGridViewTextBoxColumn";
            this.mantarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tCDataGridViewTextBoxColumn
            // 
            this.tCDataGridViewTextBoxColumn.DataPropertyName = "TC";
            this.tCDataGridViewTextBoxColumn.HeaderText = "TC";
            this.tCDataGridViewTextBoxColumn.Name = "tCDataGridViewTextBoxColumn";
            this.tCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ücretDataGridViewTextBoxColumn
            // 
            this.ücretDataGridViewTextBoxColumn.DataPropertyName = "Ücret";
            this.ücretDataGridViewTextBoxColumn.HeaderText = "Ücret";
            this.ücretDataGridViewTextBoxColumn.Name = "ücretDataGridViewTextBoxColumn";
            this.ücretDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(987, 669);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.linkLabel2);
            this.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kisilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hayvanlarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource kisilerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ücretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn türDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastalıkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parazitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn karma1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn karma2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuduzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lösemiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mantarDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource hayvanlarBindingSource;
    }
}