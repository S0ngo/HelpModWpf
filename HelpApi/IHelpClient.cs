using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Adani.common.HelpModWPF.HelpApi
{
    public interface IHelpClient
    {
        string HelpClient();
    }

    class GetActiveWindowTitle : IHelpClient
    {

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        public string HelpClient()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;    
        }

    }

}
