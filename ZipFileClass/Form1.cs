using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace ZipFileClass
{
    public partial class Form1 : Form
    {
        string directoryPath;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
            string startPath = @"C:\Users\jeff_\Downloads";
            string zipPath = @"C:\Users\jeff_\Downloads";
            string extractPath = @"C:\Users\jeff_\Downloads";

            string[] compressfiles = Directory.GetFiles(@"C:\Users\jeff_\Downloads", @"*.zip");

            for (int i = 0; i < compressfiles.Length; i++)
            {
                //compressfiles[i] = Path.GetFileName(compressfiles[i]);
                MessageBox.Show(compressfiles[i]);
                ZipFile.ExtractToDirectory(compressfiles[i], extractPath); // you need to use the whole path including the name of the file and
                /// the extension.
            }
            ///ZipFile.CreateFromDirectory(startPath, zipPath);
            /// using (ZipArchive archive = ZipFile.OpenRead(zipPath))
            ///{
            ///ZipFile.ExtractToDirectory(zipPath, extractPath); /// if doesn't work please add the reference System.IO.Compression.FileSystem
            ///}
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

    }
}
