namespace AutoClickerLib;

public class Clicker
{
    public async Task AutoClick(CancellationToken cancellationToken)
    {
        while (true)
        {
            Win32Apis.GetCursorPos(out var position);
            LeftMouseClick(position.X, position.Y);
            
            await Task.Delay(100, cancellationToken);
            if (cancellationToken.IsCancellationRequested)
                break;
        }
    }

    public static void LeftMouseClick(int xPosition, int yPosition)
    {
        Win32Apis.SetCursorPos(xPosition, yPosition);
        Win32Apis.mouse_event(Win32Apis.MouseEventLeftDown, xPosition, yPosition, 0, 0);
        Win32Apis.mouse_event(Win32Apis.MouseEventLeftUp, xPosition, yPosition, 0, 0);
    }
}