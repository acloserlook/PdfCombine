using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSupergoo.ABCpdf8;

namespace PdfCombine
{
    public partial class EditForm : Form
    {
        private class PageListItem
        {
            public string Title { get; set; }
            public int PageNumber { get; set; }
            public Bitmap Thumbnail { get; set; }
        }

        private string fileToEdit;
        private CancellationTokenSource cts;

        public EditForm(string fileToEdit)
        {
            this.fileToEdit = fileToEdit;
            InitializeComponent();
        }


        private async void EditForm_Load(object sender, EventArgs e)
        {
            ProgressBar.Visible = true;
            var progressIndicator = new Progress<int>(ReportProgress);
            cts = new CancellationTokenSource();

            try
            {
                var pages = await Task.Run(() => LoadFile(progressIndicator, cts.Token), cts.Token);
                Pages.Items.AddRange(pages);

                ProgressBar.Visible = false;
                cts = null;
            }
            catch (OperationCanceledException)
            {
            }
        }


        private PageListItem[] LoadFile(IProgress<int> progress, CancellationToken ct)
        {
            ct.ThrowIfCancellationRequested();

            var items = new List<PageListItem>();

            using (var doc = new Doc())
            {
                doc.Read(fileToEdit);

                for (int i = 1; i <= doc.PageCount; i++)
                {
                    doc.PageNumber = i;

                    var item = new PageListItem
                    {
                        Title = "Page " + i,
                        PageNumber = i,
                        Thumbnail = doc.Rendering.GetBitmap()
                    };

                    items.Add(item);

                    CheckForCancellation(ct, items);
                    progress.Report(i * 100 / doc.PageCount);
                }
            }

            CheckForCancellation(ct, items);

            return items.ToArray();
        }


        private void ReportProgress(int value)
        {
            ProgressBar.Value = value;
        }


        private void CheckForCancellation(CancellationToken ct, List<PageListItem> items)
        {
            if (ct.IsCancellationRequested)
            {
                foreach (var item in items)
                {
                    item.Thumbnail.Dispose();
                }

                throw new OperationCanceledException(ct);
            }
        }


        private void Pages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Pages.SelectedIndex != -1)
            {
                var item = Pages.SelectedItem as PageListItem;
                PageThumbnail.Image = item.Thumbnail;
            }
            else
                PageThumbnail.Image = null;
        }


        private void MoveUp_Click(object sender, EventArgs e)
        {
            if (Pages.SelectedIndex == -1 || Pages.SelectedIndex == 0)
                return;

            MovePage(Pages.SelectedIndex - 1);
        }


        private void MoveDown_Click(object sender, EventArgs e)
        {
            if (Pages.SelectedIndex == -1 || Pages.SelectedIndex == Pages.Items.Count - 1)
                return;

            MovePage(Pages.SelectedIndex + 1);
        }


        private void MovePage(int newIndex)
        {
            var page = Pages.SelectedItem;
            var index = Pages.SelectedIndex;

            Pages.Items.RemoveAt(index);
            Pages.Items.Insert(newIndex, page);

            Pages.SelectedIndex = newIndex;
        }


        private void RemovePage_Click(object sender, EventArgs e)
        {
            if (Pages.SelectedIndex == -1)
                return;

            var page = Pages.SelectedItem as PageListItem;
            page.Thumbnail.Dispose();

            Pages.Items.RemoveAt(Pages.SelectedIndex);
        }


        private void Save_Click(object sender, EventArgs e)
        {
            if (Pages.Items.Count == 0)
                return;

            using (var dialog = new SaveFileDialog())
            {
                dialog.Title = "Save As";
                dialog.Filter = "PDF Files (*.pdf)|*.pdf";

                var result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                    SaveFile(dialog.FileName);
            }
        }


        private void SaveFile(string fileName)
        {
            bool overwrite = fileName.Equals(fileToEdit, StringComparison.CurrentCultureIgnoreCase);
            string tempFileName = null;

            var pages = Pages.Items.OfType<PageListItem>().Select(p => p.PageNumber).ToArray();

            using (var doc = new Doc())
            {
                doc.Read(fileToEdit);
                doc.RemapPages(pages);

                if (overwrite)
                {
                    tempFileName = Path.GetTempFileName();
                    doc.Save(tempFileName);
                }
                else
                    doc.Save(fileName);
            }

            if (overwrite)
            {
                File.Delete(fileName);
                File.Move(tempFileName, fileName);
            }
        }


        private void EditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (cts != null)
                cts.Cancel();

            foreach (PageListItem item in Pages.Items)
            {
                item.Thumbnail.Dispose();
            }
        }
    }
}
