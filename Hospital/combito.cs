using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    


    
    
    
    public partial class combito : Form
    {
        public combito()
        {
            InitializeComponent();

            dataGridView1.ColumnCount = 1;

            DataGridViewCheckBoxColumn check = new DataGridViewCheckBoxColumn();
            check.Name = "Seleccion";
            check.HeaderText = "Seleccion";
            dataGridView1.Columns.Add(check);

            dataGridView1.Rows.Add(3);
          
          

        }

        private void combito_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //
            // Solo se trabaja ante los cambios en la columan de los checkbox 
            //
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Seleccion")
            {
                //
                // Se toma la fila seleccionada
                //
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                //
                // Se selecciona la celda del checkbox
                //
                DataGridViewCheckBoxCell cellSelecion = row.Cells["Seleccion"] as DataGridViewCheckBoxCell;

                //
                // Se valida si esta checkeada
                //
                if (Convert.ToBoolean(cellSelecion.Value))
                {

                    string mensaje = "se marcó";

                    MessageBox.Show(mensaje + e.RowIndex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else {

                    string mensaje = "se desmarcó";

                    MessageBox.Show(mensaje + e.RowIndex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
