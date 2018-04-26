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
        private delegate void ProgressDelegate(int progress);
        private ProgressDelegate del;
        /// <summary>
        /// Inicializa a Splash Screen
        /// </summary>
        public SplashScreen()
        {
            InitializeComponent();
            progressBar.Maximum = 100;
            del = UpdateProgressInternal;
        }
        /// <summary>
        /// Get e Set do valor da progressBar
        /// </summary>
        public int Progress
        {
            get
            {
                return progressBar.Value;
            }
            set
            {
                progressBar.Value = value;
            }
        }

        private void UpdateProgressInternal(int progress)
        {
            if (Handle == null)
            {
                return;
            }
            progressBar.Value = progress;
        }

        public void UpdateProgress(double progress)
        {
            Invoke(del, progress);
        }
    }
}
