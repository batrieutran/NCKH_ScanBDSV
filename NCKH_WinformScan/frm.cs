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
using IronOcr;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NCKH_WinformScan
{
    public partial class frmDisplayScan : Form
    {
        public frmDisplayScan()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.pdf)|*.jpg; *.jpeg; *.gif; *.bmp; *.pdf";
            //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //    {
            //        pbImage.Load(openFileDialog1.FileName);
            //        pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Eror load image " + ex.Message);
            //    throw ex;
            //}
            try
            {
                openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.pdf)|*.jpg; *.jpeg; *.gif; *.bmp; *.pdf";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = openFileDialog1.FileName;
                    string fileExtension = Path.GetExtension(selectedFile).ToLower();

                    if (fileExtension == ".pdf")
                    {
                        // Đọc nội dung từ file PDF và chuyển đổi thành hình ảnh
                        var ocr = new IronTesseract();
                        ocr.Language = OcrLanguage.Vietnamese;
                        using (var input = new OcrInput(selectedFile))
                        {
                            var result = ocr.Read(input);
                            rtbResultImage.Text = result.Text;
                        }
                    }
                    else
                    {
                        // Xử lý file ảnh như trước
                        pbImage.Load(selectedFile);
                        pbImage.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading file: " + ex.Message);
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (pbImage.Image != null)
            //    {
            //        var ocr = new IronTesseract();
            //        ocr.Language = OcrLanguage.Vietnamese;
            //        using (var input = new OcrInput(pbImage.Image))
            //        {
            //            var result = ocr.Read(input);
            //            rtbResultImage.Text = result.Text;
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Eror load image conversion " + ex.Message);
            //    throw ex;
            //}
            try
            {
                if (pbImage.Image != null)
                {
                    var ocr = new IronTesseract();
                    ocr.Language = OcrLanguage.Vietnamese;
                    using (var input = new OcrInput(pbImage.Image))
                    {
                        var result = ocr.Read(input);
                        rtbResultImage.Text = result.Text;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error image conversion: " + ex.Message);
            }
        }
    }
}
