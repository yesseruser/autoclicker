using System.Runtime.InteropServices;

namespace AutoClickerLib;

public class Win32Apis
{
    [DllImport("user32.dll")]
    public static extern bool SetCursorPos(int x, int y);
    
    [DllImport("user32.dll")]
    public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
    
    [DllImport("user32.dll")]
    public static extern bool GetCursorPos(out System.Drawing.Point lpPoint);
    
    public const int MouseEventLeftDown = 0x02;
    public const int MouseEventLeftUp = 0x04;
}