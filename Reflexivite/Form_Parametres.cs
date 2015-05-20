using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reflexivite
{
    public partial class Form_Parametres : Form
    {
        public object[] objets { get; private set; }
        private ParameterInfo[] parameters;

        public Form_Parametres()
        {
            InitializeComponent();
        }

        public Form_Parametres(ParameterInfo[] p)
		{
			InitializeComponent();

			objets = new object[p.Length];
			parameters = p;

			foreach (var pi in parameters)
				flp_Parametres.Controls.Add(GetFlowLayoutPanel(pi));
		}

        private void btn_Confirmer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < parameters.Length; ++i)
            {
                Control[] ctrl = Controls.Find(parameters[i].Name, true);
               

                if (ctrl[0] is CheckBox)
                    objets[i] = ((CheckBox)ctrl[0]).Checked;
                else if (ctrl[0] is DateTimePicker)
                    objets[i] = ((DateTimePicker)ctrl[0]).Value.Date;
                else if (ctrl[0] is TextBox)
                    objets[i] = ConvertTo((TextBox)ctrl[0], parameters[i]);
            }

            DialogResult = DialogResult.OK;
        }

        private object ConvertTo(TextBox ctrl, ParameterInfo pi)
        {
            string valeur = ctrl.Text;

            switch (pi.ParameterType.Name)
            {
                case "Int32":
                    int nbInt;
                    if (int.TryParse(valeur, out nbInt))
                        return nbInt;
                    break;
                case "Float":
                    float nbFloat;
                    if (float.TryParse(valeur, out nbFloat))
                        return nbFloat;
                    break;
                case "Double":
                    double nbDouble;
                    if (double.TryParse(valeur, out nbDouble))
                        return nbDouble;
                    break;
            }
            return valeur;
        }


        private FlowLayoutPanel GetFlowLayoutPanel(ParameterInfo pi)
        {
            FlowLayoutPanel flp = new FlowLayoutPanel();
            flp.AutoSize = true;
            flp.Controls.Add(GetLabel(pi));

            switch (pi.ParameterType.Name)
            {
                case "Boolean":
                    flp.Controls.Add(GetCheckBox(pi));
                    break;
                case "DateTime":
                    flp.Controls.Add(GetDateTimePicker(pi));
                    break;
                default:
                    flp.Controls.Add(GetTextBox(pi));
                    break;
            }

            return flp;
        }


        private Label GetLabel(ParameterInfo pi)
        {
            Label lbl = new Label();
            lbl.Text = pi.Name + ":";
            lbl.AutoSize = true;
            lbl.Padding = new Padding(0, 5, 0, 0);
            return lbl;
        }


        private TextBox GetTextBox(ParameterInfo pi)
        {
            TextBox txt = new TextBox();
            txt.Font = new System.Drawing.Font(txt.Font, System.Drawing.FontStyle.Bold);
            txt.Name = pi.Name;
            return txt;
        }


        private DateTimePicker GetDateTimePicker(ParameterInfo pi)
        {
            DateTimePicker dtp = new DateTimePicker();
            dtp.Format = DateTimePickerFormat.Short;
            dtp.Width = 93;
            dtp.Name = pi.Name;
            return dtp;
        }


        private CheckBox GetCheckBox(ParameterInfo pi)
        {
            CheckBox chk = new CheckBox();
            chk.FlatStyle = FlatStyle.Flat;
            chk.Padding = new Padding(0, 0, 0, 3);
            chk.Name = pi.Name;
            return chk;
        }

    }
}
