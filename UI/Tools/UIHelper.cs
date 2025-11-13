using Services.BLL.Extensions;
using Services.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Tools
{
    public static class UIHelper
    {
        public static void LimpiarCampos(Control.ControlCollection controles)
        {
            try
            {
                foreach (Control ctrl in controles)
                {
                    if (ctrl.Name != null)
                    {
                        if (ctrl.Visible == true)
                        {
                            if (ctrl is TextBox)
                            {
                                ctrl.Text = string.Empty;
                            }
                            else if(ctrl is ComboBox cmb)
                            {
                                cmb.SelectedIndex = -1;
                            }
                        }
                    }
                    if (ctrl.HasChildren)
                    {
                        LimpiarCampos(ctrl.Controls);
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void TraducirControles(Control.ControlCollection controles)
        {
            try
            {
                foreach (Control ctrl in controles)
                {
                    if (ctrl.Name != null)
                    {
                        if (ctrl.Visible == true)
                        {
                            if (ctrl is Button || ctrl is Label)
                            {
                                string nuevoTexto = ctrl.Name.Traducir();
                                ctrl.Text = nuevoTexto == null ? ctrl.Text : nuevoTexto;
                            }
                        }
                    }
                    if (ctrl.HasChildren)
                    {
                        TraducirControles(ctrl.Controls);
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
