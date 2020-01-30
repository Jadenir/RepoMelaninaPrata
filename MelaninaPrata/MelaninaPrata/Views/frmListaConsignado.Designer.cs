namespace MelaninaPrata.Views
{
    partial class frmListaConsignado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaConsignado));
            this.tollStipTopMenu = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.txtVendedora = new System.Windows.Forms.TextBox();
            this.lvlVendedora = new System.Windows.Forms.Label();
            this.dgvVendedores = new System.Windows.Forms.DataGridView();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tollStipTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).BeginInit();
            this.SuspendLayout();
            // 
            // tollStipTopMenu
            // 
            this.tollStipTopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(122)))), ((int)(((byte)(107)))));
            this.tollStipTopMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tollStipTopMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tollStipTopMenu.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.tollStipTopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnClear,
            this.toolStripSeparator1,
            this.btnExit});
            this.tollStipTopMenu.Location = new System.Drawing.Point(0, 0);
            this.tollStipTopMenu.Name = "tollStipTopMenu";
            this.tollStipTopMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tollStipTopMenu.Size = new System.Drawing.Size(800, 47);
            this.tollStipTopMenu.TabIndex = 6;
            this.tollStipTopMenu.TabStop = true;
            this.tollStipTopMenu.Text = "toolStrip1";
            // 
            // btnNew
            // 
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(40, 44);
            this.btnNew.Text = "Novo";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNew.ToolTipText = "Novo Consignado";
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(48, 44);
            this.btnClear.Text = "Limpar";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 44);
            this.btnExit.Text = "Sair";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // txtVendedora
            // 
            this.txtVendedora.Location = new System.Drawing.Point(77, 56);
            this.txtVendedora.MaxLength = 100;
            this.txtVendedora.Name = "txtVendedora";
            this.txtVendedora.Size = new System.Drawing.Size(280, 20);
            this.txtVendedora.TabIndex = 9;
            // 
            // lvlVendedora
            // 
            this.lvlVendedora.AutoSize = true;
            this.lvlVendedora.Location = new System.Drawing.Point(12, 59);
            this.lvlVendedora.Name = "lvlVendedora";
            this.lvlVendedora.Size = new System.Drawing.Size(59, 13);
            this.lvlVendedora.TabIndex = 8;
            this.lvlVendedora.Text = "Vendedora";
            // 
            // dgvVendedores
            // 
            this.dgvVendedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvVendedores.BackgroundColor = System.Drawing.Color.White;
            this.dgvVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendedores.Location = new System.Drawing.Point(15, 109);
            this.dgvVendedores.Name = "dgvVendedores";
            this.dgvVendedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendedores.Size = new System.Drawing.Size(773, 329);
            this.dgvVendedores.TabIndex = 27;
            this.dgvVendedores.TabStop = false;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DisplayMember = "uf";
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(77, 82);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(136, 21);
            this.cmbStatus.TabIndex = 29;
            this.cmbStatus.ValueMember = "codigoUf";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 85);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 28;
            this.lblStatus.Text = "Status";
            // 
            // frmListaConsignado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dgvVendedores);
            this.Controls.Add(this.txtVendedora);
            this.Controls.Add(this.lvlVendedora);
            this.Controls.Add(this.tollStipTopMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaConsignado";
            this.Text = "frmListaConsignado";
            this.tollStipTopMenu.ResumeLayout(false);
            this.tollStipTopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tollStipTopMenu;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.TextBox txtVendedora;
        private System.Windows.Forms.Label lvlVendedora;
        private System.Windows.Forms.DataGridView dgvVendedores;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
    }
}