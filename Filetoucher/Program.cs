using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filetoucher {
    class Program {
        [STAThread]
        static void Main(string[] args) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\apps\NiceOffice\Builds";
            ofd.Filter = "Access files (*.mdb, *.accdb)|*.accdb; *.mdb";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;
            DialogResult result = ofd.ShowDialog();
            string fileName = "";

            if (result == DialogResult.OK) {
                fileName = ofd.FileName;
                DateTime tTime = DateTime.Now;
                File.SetCreationTime(fileName, tTime);
                File.SetLastWriteTime(fileName, tTime);
                File.SetLastAccessTime(fileName, tTime);
            }
             Environment.Exit(0);
        }
    }
}
