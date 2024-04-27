using AutoClickerLib;

var cancellationSource = new CancellationTokenSource();

var clicker = new Clicker();
_ = clicker.AutoClick(100, cancellationSource.Token);

Console.ReadKey();
cancellationSource.Cancel();