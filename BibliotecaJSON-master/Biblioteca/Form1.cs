using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Biblioteca
{
    public partial class Form1 : Form
    {
        Datos<RegistroLibro> registro = new Datos<RegistroLibro>("Registro.json");


        public void Limpiar()
        {

            txtISBN.Text = string.Empty;
            txtTitulo.Text = string.Empty;
            txtAutor.Text = string.Empty;
            txtEditorial.Text = string.Empty;
            txtPaginas.Text = string.Empty;
            txtISBN.Focus();
        }
        public void Limpiar2()
        {

            txtISBN.Text = string.Empty;
            txtISBN.Focus();
        }

        void mostrar(List<RegistroLibro> lista)
        {
            dataGridView1.Rows.Clear();

            foreach (RegistroLibro p in lista)
            {
                DataGridViewRow datos = new DataGridViewRow();
                datos.Cells.Add(new DataGridViewTextBoxCell() { Value = p.ISBN });
                datos.Cells.Add(new DataGridViewTextBoxCell() { Value = p.Titulo });
                datos.Cells.Add(new DataGridViewTextBoxCell() { Value = p.Autor });
                datos.Cells.Add(new DataGridViewTextBoxCell() { Value = p.Editorial });
                datos.Cells.Add(new DataGridViewTextBoxCell() { Value = p.Paginas });
                dataGridView1.Rows.Add(datos);

            }
        }

        public Form1()
        {

            InitializeComponent();
            registro.Cargar();
            mostrar(registro.valores);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            RegistroLibro p = registro.Buscar(x => x.ISBN.ToString() == dataGridView1.CurrentRow.Cells[0].Value.ToString())[0];
            txtISBN.Text = p.ISBN.ToString();
            txtTitulo.Text = p.Titulo.ToString();
            txtAutor.Text = p.Autor.ToString();
            txtEditorial.Text = p.Editorial.ToString();
            txtPaginas.Text = p.Paginas.ToString();
        }

     
        

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     
        private void button3_Click(object sender, EventArgs e)
        {
            if (txtISBN.Text == "" || txtTitulo.Text == "" || txtAutor.Text == "" || txtEditorial.Text == "" || txtPaginas.Text == "")
            {
                MessageBox.Show("No puede dejar casillas en blanco!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                  if (txtISBN.Text != dataGridView1.Rows[i].Cells[0].Value.ToString())
                {
                  continue;
                }
                else
                {

                  MessageBox.Show("Codigo repetido");
                Limpiar2();
                return;
                }

                 }
                MessageBox.Show("Iniciamos la Serializacón y Deserializacion de los datos ", "Registrando",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                panel1.Visible = true;
                RegistroLibro p = new RegistroLibro(int.Parse(txtISBN.Text), txtTitulo.Text, txtAutor.Text, txtEditorial.Text, int.Parse(txtPaginas.Text));
                registro.Insertar(p);
                mostrar(registro.valores);
                Limpiar();
            }
        }

       

      

        private void button5_Click(object sender, EventArgs e)
        {
            Eleccion pantalla = new Eleccion();
            pantalla.Show();
            this.Close();
        }

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtISBN.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Por favor solo ingrese numeros.");
                txtISBN.Text = txtISBN.Text.Remove(txtISBN.Text.Length - 1);
            }
        }

  
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var lista = registro.Buscar(x => x.Titulo.Contains(textBox1.Text));
            mostrar(lista);
        }

        private void txtPaginas_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtPaginas.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Por favor solo ingrese numeros.");
                txtPaginas.Text = txtPaginas.Text.Remove(txtPaginas.Text.Length - 1);
            }
        }

        private void txtTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            
                e.Handled = true;
            
        }

        private void txtAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else

                e.Handled = true;
        }

        private void txtEditorial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else

                e.Handled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            panel1.Visible = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}

