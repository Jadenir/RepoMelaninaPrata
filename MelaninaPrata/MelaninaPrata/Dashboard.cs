using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MelaninaPrata
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            customizeDesing();
        }

        #region Variables
        private Form activeForm = null;
        #endregion

        #region Clicks
        //Menu Cadastros
        private void btnCadastros_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuCadastros);
        }
        private void btnVendedores_Click(object sender, EventArgs e)
        {
            openChildForm(new Vendedores());

            //Oculta subMenu
            hideSubMenu();
        }
        private void btnProdutos_Click(object sender, EventArgs e)
        {
            openChildForm(new Produtos());

            //Oculta subMenu
            hideSubMenu();
        }
        //Menu Consignados
        private void btnConsigacao_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuConsignado);
        }
        private void btnNovoConsignado_Click(object sender, EventArgs e)
        {
            //Oculta subMenu
            hideSubMenu();
        }
        private void btnAcertar_Click(object sender, EventArgs e)
        {
            //Oculta subMenu
            hideSubMenu();
        }
        //Panel Menu Lateral
        private void PanelMenuLateral_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion

        #region Functions

        #endregion

        #region Procedures
        private void customizeDesing()
        {
            PanelSubMenuCadastros.Visible = false;
            PanelSubMenuConsignado.Visible = false;
        }
        private void hideSubMenu()
        {
            //SubMenu Cadastros
            if (PanelSubMenuCadastros.Visible == true)
            {
                PanelSubMenuCadastros.Visible = false;
            }
            //SubMenu Consignados
            if (PanelSubMenuConsignado.Visible == true)
            {
                PanelSubMenuConsignado.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (PanelSubMenuCadastros.Visible == false || PanelSubMenuConsignado.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelFormFilhos.Controls.Add(childForm);
            PanelFormFilhos.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion


    }
}
