using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHARP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btNova.Enabled = false;
            bt_processa.Enabled = false;
            
        }

        private void bt_processa_Click(object sender, EventArgs e)
        {
            String caminho = "C:\\Users\\Samuel\\Desktop\\Trabalho_C#\\PYTHON\\PYTHON.PY";
            Process.Start(caminho);
            btNova.Enabled = true;
        }

        private void bt_Nova(object sender, EventArgs e)
        {
            String caminho = "C:\\Users\\Samuel\\Desktop\\Trabalho_C#\\CSHARP\\bin\\Debug\\nova.png";
            pbNova.Load(caminho);
        }

        private void bt_Origi(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();
            foto.Filter = "PNG|*.png";
            foto.ShowDialog();
            pbOrigi.Load(foto.FileName);

            if (foto.FileName != null){
                pbOrigi.Image = Image.FromFile(foto.FileName);
                pbOrigi.Image.Save(@"C:\\Users\\Samuel\\Desktop\\Trabalho_C#\\CSHARP\\bin\\Debug\\cranio.png",pbOrigi.Image.RawFormat);

            }


            //pbOrigi.Load("C:\\Users\\Samuel\\Desktop\\Trabalho_C#\\CSHARP\\bin\\Debug\\cranio.png");
            bt_processa.Enabled = true;
        }

    }
}
