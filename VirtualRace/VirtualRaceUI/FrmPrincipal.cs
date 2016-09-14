using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualRaceConsola;

namespace VirtualRaceUI
{
    public partial class FrmPrincipal : Form
    {
        private Carrera miCarrera;
        public FrmPrincipal()
        {
            InitializeComponent();
            // cargo y configuro el comboBox
            foreach (eFabricante item in Enum.GetValues(typeof (eFabricante)))
            {
                this.cmbFabricantes.Items.Add(item);
                
            }
            cmbFabricantes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFabricantes.SelectedIndex=1;
            this.gpbAuto.Enabled = false;

            this.cmbTipoCarrera.Items.Add("Por Tiempo");
            this.cmbTipoCarrera.Items.Add("Por Kilometros");
            this.cmbTipoCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbTipoCarrera.SelectedIndex = 1;

            this.cmbCriterio.Items.Add("Fabricante");
            this.cmbCriterio.Items.Add("Piloto");
            this.cmbCriterio.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbCriterio.SelectedIndex = 1;

            //datos para testing
            this.txtfecha.Text = "29/7/2016";
            this.txtLugar.Text = "avellaneda";
            this.txtNombre.Text = "avellaneda";
        }

        private void btnCrearCarrera_Click(object sender, EventArgs e)
        {
            this.miCarrera = new Carrera(this.txtLugar.Text,this.txtfecha.Text,this.txtNombre.Text);
            this.gpbCarrera.Enabled = false;
            this.gpbAuto.Enabled = true;
        }

        private void btnAgregarAuto_Click(object sender, EventArgs e)
        {
            Auto autito = new Auto(this.txtNombrePiloto.Text,(eFabricante)cmbFabricantes.SelectedItem);
            this.miCarrera = this.miCarrera + autito;

            cargarListado();
        }
        private void cargarListado()
        {
           this.lsbAutos.Items.Clear();
             foreach (Auto item in this.miCarrera.ListaDeAutos)
	            {
                    this.lsbAutos.Items.Add(item.retornarStringParaListado());
	            }
        }

      

        private void btnCorrerCarrera_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
