using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatosPostulante;

namespace DatosPostulante
{
    
    public partial class Datos : Form
    {
        public Datos()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            string name;
            string surname;
            string IDType;
            string IDNumber;

            name = txtNombre.Text;
            surname = txtApellido.Text;
            IDType = cboIDType.Text;
            IDNumber = txtNroDoc.Text;

            // Instancia objeto clase postulante
           
            Postulante alumno = new Postulante(name, surname, IDType, IDNumber);
            
            MessageBox.Show("Nombre: " + alumno.Apellido + ", " + alumno.Nombre + "\n" + alumno.TipoID + " " +alumno.NroID, "Ingreso registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBox.Show("Datos correctos", "Ingreso registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();   
            txtNroDoc.Clear();
            cboIDType.ResetText();
        }

       private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
