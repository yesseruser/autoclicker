namespace AutoClickerLib;

public class Clicker
{
    public async Task AutoClick(CancellationToken cancellationToken)
    {
        while (true)
        {
            Win32Apis.GetCursorPos(out var pos);
            LeftMouseClick(pos.X, pos.Y);
            
            await Task.Delay(100, cancellationToken);
            if (cancellationToken.IsCancellationRequested)
                break;
        }
    }

    public static void LeftMouseClick(int xpos, int ypos)
    {
        Win32Apis.SetCursorPos(xpos, ypos);
        Win32Apis.mouse_event(Win32Apis.MouseEventLeftDown, xpos, ypos, 0, 0);
        Win32Apis.mouse_event(Win32Apis.MouseEventLeftUp, xpos, ypos, 0, 0);
    }
}