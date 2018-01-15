namespace Disconnected1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDatenAdapter = new System.Windows.Forms.Button();
            this.buttonDsRead = new System.Windows.Forms.Button();
            this.listBoxAusgabe = new System.Windows.Forms.ListBox();
            this.dataGridViewAusgabe = new System.Windows.Forms.DataGridView();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDataAdapterArtikel = new System.Windows.Forms.Button();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAusgabe)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDatenAdapter
            // 
            this.buttonDatenAdapter.Location = new System.Drawing.Point(11, 12);
            this.buttonDatenAdapter.Name = "buttonDatenAdapter";
            this.buttonDatenAdapter.Size = new System.Drawing.Size(173, 64);
            this.buttonDatenAdapter.TabIndex = 0;
            this.buttonDatenAdapter.Text = "DatenAdapter";
            this.buttonDatenAdapter.UseVisualStyleBackColor = true;
            this.buttonDatenAdapter.Click += new System.EventHandler(this.buttonDatenAdapter_Click);
            // 
            // buttonDsRead
            // 
            this.buttonDsRead.Location = new System.Drawing.Point(11, 94);
            this.buttonDsRead.Name = "buttonDsRead";
            this.buttonDsRead.Size = new System.Drawing.Size(172, 63);
            this.buttonDsRead.TabIndex = 1;
            this.buttonDsRead.Text = "DS auslesen";
            this.buttonDsRead.UseVisualStyleBackColor = true;
            this.buttonDsRead.Click += new System.EventHandler(this.buttonDsRead_Click);
            // 
            // listBoxAusgabe
            // 
            this.listBoxAusgabe.FormattingEnabled = true;
            this.listBoxAusgabe.Location = new System.Drawing.Point(221, 12);
            this.listBoxAusgabe.Name = "listBoxAusgabe";
            this.listBoxAusgabe.Size = new System.Drawing.Size(251, 199);
            this.listBoxAusgabe.TabIndex = 2;
            // 
            // dataGridViewAusgabe
            // 
            this.dataGridViewAusgabe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAusgabe.Location = new System.Drawing.Point(12, 269);
            this.dataGridViewAusgabe.Name = "dataGridViewAusgabe";
            this.dataGridViewAusgabe.Size = new System.Drawing.Size(655, 175);
            this.dataGridViewAusgabe.TabIndex = 3;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(690, 293);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(119, 50);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDataAdapterArtikel
            // 
            this.buttonDataAdapterArtikel.Location = new System.Drawing.Point(12, 180);
            this.buttonDataAdapterArtikel.Name = "buttonDataAdapterArtikel";
            this.buttonDataAdapterArtikel.Size = new System.Drawing.Size(162, 63);
            this.buttonDataAdapterArtikel.TabIndex = 5;
            this.buttonDataAdapterArtikel.Text = "DatenAdapter Artikel";
            this.buttonDataAdapterArtikel.UseVisualStyleBackColor = true;
            this.buttonDataAdapterArtikel.Click += new System.EventHandler(this.buttonDataAdapterArtikel_Click);
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(508, 12);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(159, 64);
            this.buttonWrite.TabIndex = 6;
            this.buttonWrite.Text = "Write";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(508, 94);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(159, 63);
            this.buttonRead.TabIndex = 7;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 466);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.buttonDataAdapterArtikel);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.dataGridViewAusgabe);
            this.Controls.Add(this.listBoxAusgabe);
            this.Controls.Add(this.buttonDsRead);
            this.Controls.Add(this.buttonDatenAdapter);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAusgabe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDatenAdapter;
        private System.Windows.Forms.Button buttonDsRead;
        private System.Windows.Forms.ListBox listBoxAusgabe;
        private System.Windows.Forms.DataGridView dataGridViewAusgabe;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDataAdapterArtikel;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.Button buttonRead;
    }
}

