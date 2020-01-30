using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

        #region "Eventos"
        //Load
        private void Dashboard_Load(object sender, EventArgs e)
        {
            DataSet dsConfig = new DataSet();

            dsConfig.ReadXml(Application.StartupPath + "/config/config.xml");

            String host = dsConfig.Tables["conexao"].Rows[0].Field<String>("host");
            String banco = dsConfig.Tables["conexao"].Rows[0].Field<String>("banco");
            String usuario = dsConfig.Tables["conexao"].Rows[0].Field<String>("usuario");
            String senha = "&destroyer#";

            String CONNECTION_STRING_NAME = "DBMelaninaEntities";
            String ConnectionString = @"metadata = res://*/Models.MelaninaModel.csdl|res://*/Models.MelaninaModel.ssdl|res://*/Models.MelaninaModel.msl;provider=System.Data.SqlClient;provider connection string=';data source=" 
                                      + host + ";initial catalog=" + banco + ";persist security info=True;user id=" 
                                      + usuario + ";password="+ senha +";MultipleActiveResultSets=True;App=EntityFramework';";
            EntityConnectionStringBuilder connectionBuilder = new EntityConnectionStringBuilder();
            connectionBuilder.ConnectionString = ConnectionString;

            //Update connection string within config file
            Configuration config = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
            ConnectionStringsSection section = (ConnectionStringsSection)config.GetSection("connectionStrings");
            section.ConnectionStrings[CONNECTION_STRING_NAME].ConnectionString = connectionBuilder.ToString();

            //Save changes
            ConfigurationManager.RefreshSection("connectionStrings");
            config.Save();
        }
        #endregion

        #region Clicks
        //Menu Cadastros
        private void btnCadastros_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuCadastros);
        }
        private void btnVendedores_Click(object sender, EventArgs e)
        {
            openChildForm(new Views.frmPessoas());

            //Oculta subMenu
            //hideSubMenu();
        }
        private void btnProdutos_Click(object sender, EventArgs e)
        {
            openChildForm(new Views.frmProdutos());

            //Oculta subMenu
            //hideSubMenu();
        }
        private void btnGrupos_Click(object sender, EventArgs e)
        {
            openChildForm(new Views.frmGrupos());
            //Oculta subMenu
            //hideSubMenu();
        }
        //Menu Consignados
        private void btnConsigacao_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuConsignado);
        }
        private void btnNovoConsignado_Click(object sender, EventArgs e)
        {
            //Oculta subMenu
            //hideSubMenu();
        }
        private void btnAcertar_Click(object sender, EventArgs e)
        {
            //Oculta subMenu
            //hideSubMenu();
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
