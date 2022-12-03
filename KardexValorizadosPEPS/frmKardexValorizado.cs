using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KardexValorizadosPEPS
{
    public partial class frmKardexValorizado : Form
    {
        public frmKardexValorizado()
        {
            InitializeComponent();
        }

        private void frmKardexValorizado_Load(object sender, EventArgs e)
        {
            Nuevo();
        }

        #region FUNCIONES INTERNAS

        private void Nuevo()
        {
            cboMovimiento.SelectedItem = 0;
            dtpFecha.Value = DateTime.Now;
            txtCantidad.Text = "0";
            txtValor.Text = "0";
            txtTotal.Text = "0";
        }

        private void Agregar()
        {
            try
            {
                if (cboMovimiento.Text == "Compra")
                    dgvListado.Rows.Add(dtpFecha.Text, cboMovimiento.Text, txtCantidad.Text, txtValor.Text, txtTotal.Text, "", "", "", txtCantidad.Text, txtValor.Text, txtTotal.Text, 1);
                
                if (cboMovimiento.Text == "Venta")
                {
                    double Cant = Convert.ToDouble(txtCantidad.Text);

                    foreach (DataGridViewRow fila in dgvListado.Rows)
                    {
                        if (fila.Cells[8].Value.ToString() != "" && fila.Cells[9].Value.ToString() != "" && fila.Cells[10].Value.ToString() != "")
                        {
                            double Saldo = Convert.ToDouble(fila.Cells[8].Value);
                            string Disponible = fila.Cells[11].Value.ToString();

                            if (Cant > Saldo && Disponible == "1")
                            {
                                dgvListado.Rows.Add(dtpFecha.Text, cboMovimiento.Text, "", "", "", fila.Cells[8].Value, fila.Cells[9].Value, fila.Cells[10].Value, "", "", "", "1");
                                fila.Cells[11].Value = "0";
                                Cant -= Saldo;
                            }
                            else if (Cant == Saldo && Disponible == "1")
                            {
                                dgvListado.Rows.Add(dtpFecha.Text, cboMovimiento.Text, "", "", "", fila.Cells[8].Value, fila.Cells[9].Value, fila.Cells[10].Value, "", "", "", "1");
                                fila.Cells[11].Value = "0";
                                Cant -= Saldo;
                            }
                            else if (Cant != 0 && Cant < Saldo && Disponible == "1")
                            {
                                dgvListado.Rows.Add(dtpFecha.Text, cboMovimiento.Text, "", "", "", Cant, fila.Cells[9].Value, (Cant * (Convert.ToDouble(fila.Cells[9].Value))), Saldo - Cant, fila.Cells[9].Value, ((Saldo - Cant) * Convert.ToDouble(fila.Cells[9].Value)), "1");
                                fila.Cells[11].Value = "0";
                                Cant = 0;
                            }
                        }
                    }
                }

                TotalVentasStock();
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void CalcularTotal()
        {
            double Cant = 0.0;
            double Precio = 0.0;
            double Total = 0.0;

            if (txtCantidad.Text != "")
                Cant = Convert.ToDouble(txtCantidad.Text);
            else
                Cant = 0.0;

            if (txtValor.Text != "")
                Precio = Convert.ToDouble(txtValor.Text);
            else
                Precio = 0.0;

            Total = Cant * Precio;

            txtTotal.Text = Total.ToString();
        }

        private void TotalVentasStock()
        {
            try
            {
                //if (dgvListado.Rows.Count > 1)
                //    dgvListado.Rows.RemoveAt(dgvListado.Rows.Count - 1);

                double CantidadCompras = 0.0;
                double CantidadVentas = 0.0;

                double TotalVentas = 0.0;
                //double Stock = 0.0;

                foreach (DataGridViewRow filas in dgvListado.Rows)
                {
                    if (filas.Cells[2].Value.ToString() != "")
                        CantidadCompras += Convert.ToDouble(filas.Cells[2].Value);

                    if (filas.Cells[5].Value.ToString() != "")
                        CantidadVentas += Convert.ToDouble(filas.Cells[5].Value);

                    if (filas.Cells[7].Value.ToString() != "")
                        TotalVentas += Convert.ToDouble(filas.Cells[7].Value);
                }

                //dgvListado.Rows.Add("", "", "", "", "", "", "Total ventas: ", TotalVentas.ToString(), $"Stock: {CantidadCompras - CantidadVentas}", "", "", "");
                txtTotalVentas.Text = TotalVentas.ToString();
                txtStock.Text = Convert.ToString(CantidadCompras - CantidadVentas);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        #endregion

        #region BOTONES

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cboMovimiento.Text == "")
                MessageBox.Show("Debe de ingresar el movimiento a registrar.");

            if (txtCantidad.Text == "" && Convert.ToDouble(txtCantidad.Text) <= 0)
                MessageBox.Show("Debe de registrar una cantidad correcta.");

            if (txtValor.Text == "" && Convert.ToDouble(txtValor.Text) <= 0)
                MessageBox.Show("Debe de ingresar un valor correcto del producto.");

            Agregar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        #endregion


        #region CAJAS DE TEXTO

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidad.Text != "")
                CalcularTotal();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            if (txtValor.Text != "")
                CalcularTotal();
        }

        #endregion

    }
}
