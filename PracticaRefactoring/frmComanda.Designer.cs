namespace PracticaRefactoring
{
    partial class frmComanda
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbClients = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantitat = new System.Windows.Forms.TextBox();
            this.txtPreu = new System.Windows.Forms.TextBox();
            this.btnDetall = new System.Windows.Forms.Button();
            this.cmbProductes = new System.Windows.Forms.ComboBox();
            this.dtgProductes = new System.Windows.Forms.DataGridView();
            this.btnBrut = new System.Windows.Forms.Button();
            this.btnIVA = new System.Windows.Forms.Button();
            this.btnDespesa = new System.Windows.Forms.Button();
            this.btnDescompte = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.lblBrut = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblDespesa = new System.Windows.Forms.Label();
            this.lbldescompte = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblComanda = new System.Windows.Forms.Label();
            this.btnComanda = new System.Windows.Forms.Button();
            this.grpResum = new System.Windows.Forms.GroupBox();
            this.btnResum = new System.Windows.Forms.Button();
            this.cmbEstat = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRepresentant = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductes)).BeginInit();
            this.grpResum.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbClients
            // 
            this.cmbClients.FormattingEnabled = true;
            this.cmbClients.Items.AddRange(new object[] {
            "Client A",
            "Client B",
            "Client C",
            "Client AA",
            "Client BB",
            "Client CC"});
            this.cmbClients.Location = new System.Drawing.Point(131, 82);
            this.cmbClients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbClients.Name = "cmbClients";
            this.cmbClients.Size = new System.Drawing.Size(160, 24);
            this.cmbClients.TabIndex = 0;
            this.cmbClients.SelectedIndexChanged += new System.EventHandler(this.cmbClients_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Producte:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantitat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 256);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Preu:";
            // 
            // txtQuantitat
            // 
            this.txtQuantitat.Location = new System.Drawing.Point(131, 218);
            this.txtQuantitat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantitat.Name = "txtQuantitat";
            this.txtQuantitat.Size = new System.Drawing.Size(51, 22);
            this.txtQuantitat.TabIndex = 7;
            // 
            // txtPreu
            // 
            this.txtPreu.Location = new System.Drawing.Point(131, 256);
            this.txtPreu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPreu.Name = "txtPreu";
            this.txtPreu.Size = new System.Drawing.Size(51, 22);
            this.txtPreu.TabIndex = 8;
            // 
            // btnDetall
            // 
            this.btnDetall.Location = new System.Drawing.Point(208, 235);
            this.btnDetall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDetall.Name = "btnDetall";
            this.btnDetall.Size = new System.Drawing.Size(116, 46);
            this.btnDetall.TabIndex = 10;
            this.btnDetall.Text = "Afegeix producte";
            this.btnDetall.UseVisualStyleBackColor = true;
            this.btnDetall.Click += new System.EventHandler(this.btnDetall_Click);
            // 
            // cmbProductes
            // 
            this.cmbProductes.FormattingEnabled = true;
            this.cmbProductes.Items.AddRange(new object[] {
            "Producte A",
            "Producte B",
            "Producte C",
            "Producte AA",
            "Producte BB",
            "Producte CC"});
            this.cmbProductes.Location = new System.Drawing.Point(131, 181);
            this.cmbProductes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbProductes.Name = "cmbProductes";
            this.cmbProductes.Size = new System.Drawing.Size(192, 24);
            this.cmbProductes.TabIndex = 12;
            // 
            // dtgProductes
            // 
            this.dtgProductes.AllowUserToAddRows = false;
            this.dtgProductes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProductes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductes.Location = new System.Drawing.Point(41, 299);
            this.dtgProductes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgProductes.MultiSelect = false;
            this.dtgProductes.Name = "dtgProductes";
            this.dtgProductes.ReadOnly = true;
            this.dtgProductes.RowHeadersWidth = 51;
            this.dtgProductes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProductes.Size = new System.Drawing.Size(507, 282);
            this.dtgProductes.TabIndex = 16;
            // 
            // btnBrut
            // 
            this.btnBrut.Location = new System.Drawing.Point(616, 299);
            this.btnBrut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrut.Name = "btnBrut";
            this.btnBrut.Size = new System.Drawing.Size(116, 46);
            this.btnBrut.TabIndex = 17;
            this.btnBrut.Text = "Total brut";
            this.btnBrut.UseVisualStyleBackColor = true;
            this.btnBrut.Click += new System.EventHandler(this.btnBrut_Click);
            // 
            // btnIVA
            // 
            this.btnIVA.Location = new System.Drawing.Point(616, 352);
            this.btnIVA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIVA.Name = "btnIVA";
            this.btnIVA.Size = new System.Drawing.Size(116, 46);
            this.btnIVA.TabIndex = 18;
            this.btnIVA.Text = "Total IVA";
            this.btnIVA.UseVisualStyleBackColor = true;
            this.btnIVA.Click += new System.EventHandler(this.btnIVA_Click);
            // 
            // btnDespesa
            // 
            this.btnDespesa.Location = new System.Drawing.Point(616, 405);
            this.btnDespesa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDespesa.Name = "btnDespesa";
            this.btnDespesa.Size = new System.Drawing.Size(116, 46);
            this.btnDespesa.TabIndex = 19;
            this.btnDespesa.Text = "Total despeses";
            this.btnDespesa.UseVisualStyleBackColor = true;
            this.btnDespesa.Click += new System.EventHandler(this.btnDespesa_Click);
            // 
            // btnDescompte
            // 
            this.btnDescompte.Location = new System.Drawing.Point(616, 458);
            this.btnDescompte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDescompte.Name = "btnDescompte";
            this.btnDescompte.Size = new System.Drawing.Size(116, 46);
            this.btnDescompte.TabIndex = 20;
            this.btnDescompte.Text = "Total descomptes";
            this.btnDescompte.UseVisualStyleBackColor = true;
            this.btnDescompte.Click += new System.EventHandler(this.btnDescompte_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(616, 511);
            this.btnTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(116, 46);
            this.btnTotal.TabIndex = 21;
            this.btnTotal.Text = "Total comanda";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // lblBrut
            // 
            this.lblBrut.AutoSize = true;
            this.lblBrut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrut.Location = new System.Drawing.Point(787, 314);
            this.lblBrut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrut.Name = "lblBrut";
            this.lblBrut.Size = new System.Drawing.Size(29, 17);
            this.lblBrut.TabIndex = 22;
            this.lblBrut.Text = "-0-";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIva.Location = new System.Drawing.Point(787, 367);
            this.lblIva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(29, 17);
            this.lblIva.TabIndex = 23;
            this.lblIva.Text = "-0-";
            // 
            // lblDespesa
            // 
            this.lblDespesa.AutoSize = true;
            this.lblDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDespesa.Location = new System.Drawing.Point(787, 420);
            this.lblDespesa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDespesa.Name = "lblDespesa";
            this.lblDespesa.Size = new System.Drawing.Size(29, 17);
            this.lblDespesa.TabIndex = 24;
            this.lblDespesa.Text = "-0-";
            // 
            // lbldescompte
            // 
            this.lbldescompte.AutoSize = true;
            this.lbldescompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescompte.Location = new System.Drawing.Point(787, 473);
            this.lbldescompte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldescompte.Name = "lbldescompte";
            this.lbldescompte.Size = new System.Drawing.Size(29, 17);
            this.lbldescompte.TabIndex = 25;
            this.lbldescompte.Text = "-0-";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(787, 526);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(29, 17);
            this.lblTotal.TabIndex = 26;
            this.lblTotal.Text = "-0-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Comanda:";
            // 
            // lblComanda
            // 
            this.lblComanda.AutoSize = true;
            this.lblComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComanda.Location = new System.Drawing.Point(139, 48);
            this.lblComanda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComanda.Name = "lblComanda";
            this.lblComanda.Size = new System.Drawing.Size(29, 17);
            this.lblComanda.TabIndex = 28;
            this.lblComanda.Text = "-0-";
            // 
            // btnComanda
            // 
            this.btnComanda.Location = new System.Drawing.Point(323, 63);
            this.btnComanda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnComanda.Name = "btnComanda";
            this.btnComanda.Size = new System.Drawing.Size(116, 46);
            this.btnComanda.TabIndex = 29;
            this.btnComanda.Text = "Afegeix comanda";
            this.btnComanda.UseVisualStyleBackColor = true;
            this.btnComanda.Click += new System.EventHandler(this.btnComanda_Click);
            // 
            // grpResum
            // 
            this.grpResum.Controls.Add(this.btnResum);
            this.grpResum.Controls.Add(this.cmbEstat);
            this.grpResum.Controls.Add(this.label6);
            this.grpResum.Location = new System.Drawing.Point(39, 614);
            this.grpResum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpResum.Name = "grpResum";
            this.grpResum.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpResum.Size = new System.Drawing.Size(509, 123);
            this.grpResum.TabIndex = 30;
            this.grpResum.TabStop = false;
            this.grpResum.Text = "Resum";
            this.grpResum.Visible = false;
            // 
            // btnResum
            // 
            this.btnResum.Location = new System.Drawing.Point(319, 34);
            this.btnResum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResum.Name = "btnResum";
            this.btnResum.Size = new System.Drawing.Size(116, 46);
            this.btnResum.TabIndex = 15;
            this.btnResum.Text = "Veure resum";
            this.btnResum.UseVisualStyleBackColor = true;
            this.btnResum.Click += new System.EventHandler(this.btnResum_Click);
            // 
            // cmbEstat
            // 
            this.cmbEstat.FormattingEnabled = true;
            this.cmbEstat.Items.AddRange(new object[] {
            "En espera",
            "Retinguda",
            "Condicionada",
            "Confirmada"});
            this.cmbEstat.Location = new System.Drawing.Point(81, 46);
            this.cmbEstat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEstat.Name = "cmbEstat";
            this.cmbEstat.Size = new System.Drawing.Size(192, 24);
            this.cmbEstat.TabIndex = 14;
            this.cmbEstat.SelectedIndexChanged += new System.EventHandler(this.cmbEstat_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Estat:";
            // 
            // lblRepresentant
            // 
            this.lblRepresentant.AutoSize = true;
            this.lblRepresentant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepresentant.Location = new System.Drawing.Point(768, 11);
            this.lblRepresentant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRepresentant.Name = "lblRepresentant";
            this.lblRepresentant.Size = new System.Drawing.Size(29, 17);
            this.lblRepresentant.TabIndex = 31;
            this.lblRepresentant.Text = "-0-";
            // 
            // frmComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 751);
            this.Controls.Add(this.lblRepresentant);
            this.Controls.Add(this.grpResum);
            this.Controls.Add(this.btnComanda);
            this.Controls.Add(this.lblComanda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lbldescompte);
            this.Controls.Add(this.lblDespesa);
            this.Controls.Add(this.lblIva);
            this.Controls.Add(this.lblBrut);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnDescompte);
            this.Controls.Add(this.btnDespesa);
            this.Controls.Add(this.btnIVA);
            this.Controls.Add(this.btnBrut);
            this.Controls.Add(this.dtgProductes);
            this.Controls.Add(this.cmbProductes);
            this.Controls.Add(this.btnDetall);
            this.Controls.Add(this.txtPreu);
            this.Controls.Add(this.txtQuantitat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbClients);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmComanda";
            this.Text = "Proposta de comanda";
            this.Load += new System.EventHandler(this.frmComanda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductes)).EndInit();
            this.grpResum.ResumeLayout(false);
            this.grpResum.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantitat;
        private System.Windows.Forms.TextBox txtPreu;
        private System.Windows.Forms.Button btnDetall;
        private System.Windows.Forms.ComboBox cmbProductes;
        private System.Windows.Forms.DataGridView dtgProductes;
        private System.Windows.Forms.Button btnBrut;
        private System.Windows.Forms.Button btnIVA;
        private System.Windows.Forms.Button btnDespesa;
        private System.Windows.Forms.Button btnDescompte;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Label lblBrut;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblDespesa;
        private System.Windows.Forms.Label lbldescompte;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblComanda;
        private System.Windows.Forms.Button btnComanda;
        private System.Windows.Forms.GroupBox grpResum;
        private System.Windows.Forms.ComboBox cmbEstat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnResum;
        private System.Windows.Forms.Label lblRepresentant;
    }
}

