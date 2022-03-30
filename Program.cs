using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gamePDD
{
    static class Program
    {
        static public PrivateFontCollection modernFont = new PrivateFontCollection();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int fontLength = Properties.Resources.gooddog_regular.Length;
            byte[] fontdata = Properties.Resources.gooddog_regular;
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);
            modernFont.AddMemoryFont(data, fontLength);

            int fontLength2 = Properties.Resources.sensei_medium.Length;
            byte[] fontdata2 = Properties.Resources.sensei_medium;
            System.IntPtr data1 = Marshal.AllocCoTaskMem(fontLength2);
            Marshal.Copy(fontdata2, 0, data1, fontLength2);
            modernFont.AddMemoryFont(data1, fontLength2);

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Start());
           
            
        }
        
    }
}
