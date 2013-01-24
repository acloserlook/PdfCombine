using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdfCombine
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }


        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            var files = e.Data.GetData(DataFormats.FileDrop) as string[];
            var pdfs = files.Where(f => f.EndsWith(".pdf", StringComparison.CurrentCultureIgnoreCase));

            if (pdfs.Count() > 1)
            {
                var form = new CombineForm(pdfs);
                form.Show();
            }
            else if (pdfs.Count() == 1)
            {
                var form = new EditForm(pdfs.Single());
                form.Show();
            }
        }
    }
}
