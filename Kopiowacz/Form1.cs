using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kopiowacz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bCopy_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(tbPathTo.Text))
                {
                    if (!string.IsNullOrEmpty(tbFilesList.Text))
                    {
                        foreach (var line in tbFilesList.Lines)
                        {
                            var direct = Path.GetDirectoryName(line).Split('\\').Last();
                            string fileName = Path.GetFileName(line);
                            if (!Directory.Exists(string.Join("\\", tbPathTo.Text, direct)))
                            {
                                Directory.CreateDirectory(string.Join("\\", tbPathTo.Text, direct));
                            }
                            File.Copy(line, string.Join("\\", tbPathTo.Text, direct, fileName), true);
                        }
                    }
                }
                MessageBox.Show("Skopiowano");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
