using System.Data;

namespace EJERCICIO_9_2_GRIPVIEW
{
    public partial class Form1 : Form
    {
        //Variables globales 
        double subtotal;
        double precio = 0.0;
        int cantidad =0;
        int posicion;
        int numerofila = 0;
        DataTable tabla; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                cbcantidad.Items.Add(i);
                
            }

        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
        {
            //Que aparezca automaticamente al subtotal
            if (txtprecio.Text != "" && cbcantidad.SelectedItem != null) //!= es distinto. && Y
            {
                precio = Convert.ToDouble(txtprecio.Text);
                cantidad = Convert.ToInt32(cbcantidad.SelectedItem);
                
                subtotal = precio * cantidad;
                txtsubtotal.Text = subtotal.ToString();

            }
            else
            {
                

            }

        }

        private void btadicional_Click(object sender, EventArgs e)
        {
            int fila = dwrecibe.Rows.Add();

            dwrecibe.Rows[fila].Cells[0].Value = txtproducto.Text;
            dwrecibe.Rows[fila].Cells[1].Value = cbcantidad.SelectedItem;
            dwrecibe.Rows[fila].Cells[2].Value = txtprecio.Text;
            dwrecibe.Rows[fila].Cells[3].Value = txtsubtotal.Text;

            txtproducto.Text = "";
            txtprecio.Text = "";
            txtsubtotal.Clear();
            cbcantidad.ResetText();

        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            if(posicion != -1)
            {
                dwrecibe.Rows.RemoveAt(posicion); 
                
                txtproducto.Text = "";
                txtprecio.Text = "";
                txtsubtotal.Clear();
                cbcantidad.ResetText();
            }

        }

        private void dwrecibe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dwrecibe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Evento que seleccionamos la fila
            posicion = dwrecibe.CurrentRow.Index; //mostrar el numero de la fila que seleccionamos 

            txtproducto.Text = dwrecibe.Rows[posicion].Cells[0].Value.ToString();
            cbcantidad.Text = dwrecibe.Rows[posicion].Cells[1].Value.ToString();
            txtprecio.Text = dwrecibe.Rows[posicion].Cells[2].Value.ToString();
            txtsubtotal.Text = dwrecibe.Rows[posicion].Cells[3].Value.ToString();


        }

        private void btactualizar_Click(object sender, EventArgs e)
        {
            dwrecibe[0, posicion].Value = txtproducto.Text;
            dwrecibe[1, posicion].Value = cbcantidad.SelectedItem;
            dwrecibe[2, posicion].Value = txtprecio.Text;
            dwrecibe[3, posicion].Value = txtsubtotal.Text;

            txtproducto.Text = "";
            txtprecio.Text = "";
            txtsubtotal.Clear();
            cbcantidad.ResetText();

            MessageBox.Show("El registro se ha actualizado!! ", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

        }

        private void btbuscar_Click(object sender, EventArgs e)
        {

            string buscar = txtbuscar.Text;
            foreach (DataGridViewRow fila in dwrecibe.Rows)
            {
                numerofila += 1; 
            }
            tabla = new DataTable();
            tabla.Columns.Add("Producto", typeof(string)); 
            tabla.Columns.Add("Cantidad", typeof(string)); 
            tabla.Columns.Add("Precio", typeof(string)); 
            tabla.Columns.Add("SubTotal", typeof(string));

            for (int i = 0; i < numerofila; i++)
            {
                tabla.Rows.Add(
                    dwrecibe.Rows[i].Cells[0].Value,
                    dwrecibe.Rows[i].Cells[1].Value,
                    dwrecibe.Rows[i].Cells[2].Value,
                    dwrecibe.Rows[i].Cells[3].Value);
            }

                dwrecibe.Columns.Clear();
                dwrecibe.DataSource = tabla; //Lo que se incluye en el data grip

                DataView dv = tabla.DefaultView; 
                dv.RowFilter = "Producto LIKE '" + buscar + "%'"; //Query. Filtarlo en el data grip
                dwrecibe.DataSource = dv; //Es como la matrix del datagrip

            

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}