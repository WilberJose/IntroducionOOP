using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroduccionOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Compra compra = new Compra();

            compra.setCompraId(1);
            compra.setCantidad("Una pieza");
            compra.setPrecio("$100.00");
            compra.FechaCompra = "Domingo 26 de septiembre de 2021";

            /*MessageBox.Show(
                "Datos de compra: " +
                "\nID: " + compra.getCompraId() +
                "\nprecio: " + compra.getPrecio() +
                "\ncantidad: " + compra.getCantidad() +
                "\n: " + compra.FechaCompra
                );*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Compra compra = new Compra();
            compra.setCompraId(Convert.ToInt32(txtId.Text));
            compra.setPrecio(txtPrecio.Text);
            compra.setCantidad(txtCantidad.Text);
            compra.FechaCompra = txtFechaCompra.Text;

            Compra compra1 = new Compra(Convert.ToInt32(txtId.Text), txtPrecio.Text, txtCantidad.Text, txtFechaCompra.Text);

            lstCompraInfo.Items.Add("Mediante el constructor vacio: " + compra.getCompraInfo());
            lstCompraInfo.Items.Add("Mediante el constructor inicializando las propiedades: " + compra1.getCompraInfo());
        }
    }
}
        