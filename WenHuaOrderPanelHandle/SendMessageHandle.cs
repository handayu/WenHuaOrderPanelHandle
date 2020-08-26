using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WenHuaOrderPanelHandle
{
    public class SendMessageHandle
    {
        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, string lParam);
        private const int WM_SETTEXT = 0x000C;

        //[DllImport("user32.dll", EntryPoint = "SendMessageA")]
        //private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, StringBuilder lParam);
        //private const int WM_GETTEXT = 0x0D;

        /// <summary>
        /// 下单到按钮
        /// </summary>
        public void SendMessageToButton()
        {

        }

        /// <summary>
        /// 下单到TextBox
        /// </summary>
        public void SendMessageToTextBox(IntPtr intPtr,string info)
        {
            SendMessage(intPtr, WM_SETTEXT, IntPtr.Zero, "");
            SendMessage(intPtr, WM_SETTEXT, IntPtr.Zero, info);
        }

    }
}
