using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VKProfiler
{
    public partial class Form1 : Form
    {
        Profiler profiler = new Profiler();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (profiler.Autorized)
            {
                var dialogResult = MessageBox.Show("Вы уже авторизованы\nХотите снова пройти авторизацию?", "Внимание!", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Information ,MessageBoxDefaultButton.Button2);
                if (dialogResult == DialogResult.Yes)
                    StartAutorisation();
            }
            else StartAutorisation();
            
        }

        async void StartAutorisation() 
        {
            var f = new Form2(profiler.GetAutorizeURL());
            f.Show();
            await Task.Run(() => profiler.Autorize(f));
            button1.Text = "Вы вошли как " + profiler.UserName;
        }
    }
}
