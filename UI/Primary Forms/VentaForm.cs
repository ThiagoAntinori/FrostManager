using Services.BLL.Contracts;
using Services.BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Primary_Forms
{
    public partial class VentaForm : Form, ITraducible
    {
        public VentaForm()
        {
            InitializeComponent();
            IdiomaService.Current.Suscribir(this);
        }

        public void CambiarIdioma()
        {
            try
            {
                MainForm.TraducirControles(this.Controls);
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
