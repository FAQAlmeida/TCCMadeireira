using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCCMadeireira.Views
{
    /// <summary>
    /// Splash Screen do Projeto
    /// </summary>
    public partial class SplashScreen : Form
    {
        /// <summary>
        /// Inicializa a Splash Screen
        /// </summary>
        public SplashScreen()
        {
            InitializeComponent();
            ProgressWorker();
        }
        async private void ProgressWorker(int progress= 1, int step = 1,  int maximum = 100, int delay = 15)
        {
            ProgressUpdate(progress);
            if(progress != maximum)
            {
                await Task.Delay(delay);
                ProgressWorker(progress: progress + step);
            }
        }
        private void ProgressUpdate(int valor)
        {
            try
            {
                progressBar.Value = valor;
                if (progressBar.Value == 100)
                {
                    Login frmLogin = new Login();
                    frmLogin.Show();
                    Hide();
                }
            }
            catch
            {
                
            }
        }
    }
}
