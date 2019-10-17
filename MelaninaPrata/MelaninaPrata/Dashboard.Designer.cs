using System;

namespace MelaninaPrata
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.PanelMenuLateral = new System.Windows.Forms.Panel();
            this.PanelSubMenuConsignado = new System.Windows.Forms.Panel();
            this.btnAcertar = new System.Windows.Forms.Button();
            this.btnNovoConsignado = new System.Windows.Forms.Button();
            this.btnConsigacao = new System.Windows.Forms.Button();
            this.PanelSubMenuCadastros = new System.Windows.Forms.Panel();
            this.btnVendedores = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnCadastros = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.PanelFormFilhos = new System.Windows.Forms.Panel();
            this.PanelMenuLateral.SuspendLayout();
            this.PanelSubMenuConsignado.SuspendLayout();
            this.PanelSubMenuCadastros.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenuLateral
            // 
            this.PanelMenuLateral.AutoScroll = true;
            this.PanelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(122)))), ((int)(((byte)(107)))));
            this.PanelMenuLateral.Controls.Add(this.PanelSubMenuConsignado);
            this.PanelMenuLateral.Controls.Add(this.btnConsigacao);
            this.PanelMenuLateral.Controls.Add(this.PanelSubMenuCadastros);
            this.PanelMenuLateral.Controls.Add(this.btnCadastros);
            this.PanelMenuLateral.Controls.Add(this.PanelLogo);
            this.PanelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenuLateral.ForeColor = System.Drawing.SystemColors.Control;
            this.PanelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.PanelMenuLateral.Name = "PanelMenuLateral";
            this.PanelMenuLateral.Size = new System.Drawing.Size(200, 561);
            this.PanelMenuLateral.TabIndex = 0;
            this.PanelMenuLateral.Click += new System.EventHandler(this.PanelMenuLateral_Click);
            // 
            // PanelSubMenuConsignado
            // 
            this.PanelSubMenuConsignado.Controls.Add(this.btnAcertar);
            this.PanelSubMenuConsignado.Controls.Add(this.btnNovoConsignado);
            this.PanelSubMenuConsignado.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenuConsignado.Location = new System.Drawing.Point(0, 261);
            this.PanelSubMenuConsignado.Name = "PanelSubMenuConsignado";
            this.PanelSubMenuConsignado.Size = new System.Drawing.Size(200, 85);
            this.PanelSubMenuConsignado.TabIndex = 4;
            // 
            // btnAcertar
            // 
            this.btnAcertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
            this.btnAcertar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAcertar.FlatAppearance.BorderSize = 0;
            this.btnAcertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcertar.ForeColor = System.Drawing.Color.White;
            this.btnAcertar.Image = ((System.Drawing.Image)(resources.GetObject("btnAcertar.Image")));
            this.btnAcertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcertar.Location = new System.Drawing.Point(0, 40);
            this.btnAcertar.Name = "btnAcertar";
            this.btnAcertar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAcertar.Size = new System.Drawing.Size(200, 40);
            this.btnAcertar.TabIndex = 2;
            this.btnAcertar.Text = "          Fechar";
            this.btnAcertar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcertar.UseVisualStyleBackColor = false;
            this.btnAcertar.Click += new System.EventHandler(this.btnAcertar_Click);
            // 
            // btnNovoConsignado
            // 
            this.btnNovoConsignado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
            this.btnNovoConsignado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNovoConsignado.FlatAppearance.BorderSize = 0;
            this.btnNovoConsignado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoConsignado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoConsignado.ForeColor = System.Drawing.Color.White;
            this.btnNovoConsignado.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoConsignado.Image")));
            this.btnNovoConsignado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoConsignado.Location = new System.Drawing.Point(0, 0);
            this.btnNovoConsignado.Name = "btnNovoConsignado";
            this.btnNovoConsignado.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnNovoConsignado.Size = new System.Drawing.Size(200, 40);
            this.btnNovoConsignado.TabIndex = 1;
            this.btnNovoConsignado.Text = "          Novo";
            this.btnNovoConsignado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoConsignado.UseVisualStyleBackColor = false;
            this.btnNovoConsignado.Click += new System.EventHandler(this.btnNovoConsignado_Click);
            // 
            // btnConsigacao
            // 
            this.btnConsigacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(122)))), ((int)(((byte)(107)))));
            this.btnConsigacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsigacao.FlatAppearance.BorderSize = 0;
            this.btnConsigacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsigacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsigacao.ForeColor = System.Drawing.Color.White;
            this.btnConsigacao.Location = new System.Drawing.Point(0, 216);
            this.btnConsigacao.Name = "btnConsigacao";
            this.btnConsigacao.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnConsigacao.Size = new System.Drawing.Size(200, 45);
            this.btnConsigacao.TabIndex = 3;
            this.btnConsigacao.Text = "Consignado";
            this.btnConsigacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsigacao.UseVisualStyleBackColor = false;
            this.btnConsigacao.Click += new System.EventHandler(this.btnConsigacao_Click);
            // 
            // PanelSubMenuCadastros
            // 
            this.PanelSubMenuCadastros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
            this.PanelSubMenuCadastros.Controls.Add(this.btnVendedores);
            this.PanelSubMenuCadastros.Controls.Add(this.btnProdutos);
            this.PanelSubMenuCadastros.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenuCadastros.Location = new System.Drawing.Point(0, 131);
            this.PanelSubMenuCadastros.Name = "PanelSubMenuCadastros";
            this.PanelSubMenuCadastros.Size = new System.Drawing.Size(200, 85);
            this.PanelSubMenuCadastros.TabIndex = 2;
            // 
            // btnVendedores
            // 
            this.btnVendedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
            this.btnVendedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVendedores.FlatAppearance.BorderSize = 0;
            this.btnVendedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendedores.ForeColor = System.Drawing.Color.White;
            this.btnVendedores.Image = ((System.Drawing.Image)(resources.GetObject("btnVendedores.Image")));
            this.btnVendedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendedores.Location = new System.Drawing.Point(0, 40);
            this.btnVendedores.Name = "btnVendedores";
            this.btnVendedores.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnVendedores.Size = new System.Drawing.Size(200, 40);
            this.btnVendedores.TabIndex = 1;
            this.btnVendedores.Text = "          Vendedores";
            this.btnVendedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendedores.UseVisualStyleBackColor = false;
            this.btnVendedores.Click += new System.EventHandler(this.btnVendedores_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
            this.btnProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProdutos.FlatAppearance.BorderSize = 0;
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.ForeColor = System.Drawing.Color.White;
            this.btnProdutos.Image = ((System.Drawing.Image)(resources.GetObject("btnProdutos.Image")));
            this.btnProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdutos.Location = new System.Drawing.Point(0, 0);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnProdutos.Size = new System.Drawing.Size(200, 40);
            this.btnProdutos.TabIndex = 0;
            this.btnProdutos.Text = "          Produtos";
            this.btnProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdutos.UseVisualStyleBackColor = false;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnCadastros
            // 
            this.btnCadastros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(122)))), ((int)(((byte)(107)))));
            this.btnCadastros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastros.FlatAppearance.BorderSize = 0;
            this.btnCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastros.ForeColor = System.Drawing.Color.White;
            this.btnCadastros.Location = new System.Drawing.Point(0, 86);
            this.btnCadastros.Name = "btnCadastros";
            this.btnCadastros.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCadastros.Size = new System.Drawing.Size(200, 45);
            this.btnCadastros.TabIndex = 1;
            this.btnCadastros.Text = "Cadastros";
            this.btnCadastros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastros.UseVisualStyleBackColor = false;
            this.btnCadastros.Click += new System.EventHandler(this.btnCadastros_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(122)))), ((int)(((byte)(107)))));
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(200, 86);
            this.PanelLogo.TabIndex = 0;
            // 
            // PanelFormFilhos
            // 
            this.PanelFormFilhos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormFilhos.Location = new System.Drawing.Point(200, 0);
            this.PanelFormFilhos.Name = "PanelFormFilhos";
            this.PanelFormFilhos.Size = new System.Drawing.Size(734, 561);
            this.PanelFormFilhos.TabIndex = 1;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.PanelFormFilhos);
            this.Controls.Add(this.PanelMenuLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Melanina Prata - Sistema de Consignado";
            this.PanelMenuLateral.ResumeLayout(false);
            this.PanelSubMenuConsignado.ResumeLayout(false);
            this.PanelSubMenuCadastros.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenuLateral;
        private System.Windows.Forms.Panel PanelSubMenuCadastros;
        private System.Windows.Forms.Button btnVendedores;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnCadastros;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Panel PanelFormFilhos;
        private System.Windows.Forms.Button btnConsigacao;
        private System.Windows.Forms.Panel PanelSubMenuConsignado;
        private System.Windows.Forms.Button btnAcertar;
        private System.Windows.Forms.Button btnNovoConsignado;
    }
}

