using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iTEC_Cireseii
{
    /// <summary>
    /// Operatii ale Butonului de vot al user-ului
    /// </summary>
    static class ButtonsOperations
    {
        /// <summary>
        /// Aflarea costului unei delicatese
        /// </summary>
        /// <param name="_button"></param>
        /// <returns></returns>
        static public int ExtractPrice(Button _button)
        {
            foreach (Control control in _button.Controls)
            {
                if (control.GetType() == typeof(Label))
                {
                    if (control.Text.Contains("Price in points:"))
                    {
                        return int.Parse(control.Text.Replace("Price in points:", "").Trim());
                    }
                }
            }
            return -1;
        }
        /// <summary>
        /// Aflarea numelui produs
        /// </summary>
        /// <param name="_button"></param>
        /// <returns></returns>
        static public string ExtractName(Button _button)
        {
            foreach (Control control in _button.Controls)
            {
                if (control.GetType() == typeof(Label))
                {
                    if (control.Text.Contains("Product:"))
                    {
                        return control.Text.Replace("Product:", "").Trim();
                    }
                }
            }
            return null;
        }
        /// <summary>
        /// Aflarea valorii punctelor de vot introduse de utilizator
        /// </summary>
        /// <param name="_button"></param>
        /// <returns></returns>
        static public int GetValue(Button _button)
        {
            foreach (Control control in _button.Controls)
            {
                if (control.GetType() == typeof(TrackBar))
                {
                    TrackBar trackBar = (TrackBar)control;
                    return trackBar.Value;
                }
            }
            return -1;
        }
    }
}
