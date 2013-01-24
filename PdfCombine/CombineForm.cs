using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSupergoo.ABCpdf8;

namespace PdfCombine
{
    public partial class CombineForm : Form
    {
        private IEnumerable<string> filesToEdit;

        public CombineForm(IEnumerable<string> filesToEdit)
        {
            this.filesToEdit = filesToEdit;
            InitializeComponent();
        }


        private void CombineForm_Load(object sender, EventArgs e)
        {
            foreach (var item in filesToEdit)
            {
                Files.Items.Add(item);
            }
        }


        private void MoveUp_Click(object sender, EventArgs e)
        {
            if (Files.SelectedIndex == -1 || Files.SelectedIndex == 0)
                return;

            MoveFile(Files.SelectedIndex - 1);
        }


        private void MoveDown_Click(object sender, EventArgs e)
        {
            if (Files.SelectedIndex == -1 || Files.SelectedIndex == Files.Items.Count - 1)
                return;
          
            MoveFile(Files.SelectedIndex + 1);
        }


        private void MoveFile(int newIndex)
        {
            var file = Files.SelectedItem;
            var index = Files.SelectedIndex;

            Files.Items.RemoveAt(index);
            Files.Items.Insert(newIndex, file);

            Files.SelectedIndex = newIndex;
        }


        private void RemoveFile_Click(object sender, EventArgs e)
        {
            if (Files.SelectedIndex == -1)
                return;

            Files.Items.RemoveAt(Files.SelectedIndex);
        }


        private void Combine_Click(object sender, EventArgs e)
        {
            if (Files.Items.Count == 0)
                return;

            using (var dialog = new SaveFileDialog())
            {
                dialog.Title = "Save As";
                dialog.Filter = "PDF Files (*.pdf)|*.pdf";

                var result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                    CombineFiles(dialog.FileName);
            }
        }


        private void CombineFiles(string fileName)
        {
            using (var combined = new Doc())
            {
                foreach (string file in Files.Items)
                {
                    using (var doc = new Doc())
                    {
                        doc.Read(file);
                        combined.Append(doc);
                    }
                }

                combined.Save(fileName);
            }
        }


        private void Files_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }


        private void Files_DragDrop(object sender, DragEventArgs e)
        {
            var files = e.Data.GetData(DataFormats.FileDrop) as string[];
            var pdfs = files.Where(f => f.EndsWith(".pdf", StringComparison.CurrentCultureIgnoreCase));

            foreach (var pdf in pdfs)
            {
                Files.Items.Add(pdf);
            }
        }
    }
}
