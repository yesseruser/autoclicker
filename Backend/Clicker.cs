namespace Backend;

public class Clicker
{
    public async Task AutoClick(CancellationToken cancellationToken)
    {
        while (true)
        {
            Win32Apis.GetCursorPos(out var pos);
            Win32Apis.LeftMouseClick(pos.X, pos.Y);
            
            await Task.Delay(100, cancellationToken);
            if (cancellationToken.IsCancellationRequested)
                break;
        }
    }
}