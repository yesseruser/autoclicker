using Backend;

var cancellationSource = new CancellationTokenSource();

var clicker = new Clicker();
_ = clicker.AutoClick(cancellationSource.Token);

Console.ReadKey();
cancellationSource.Cancel();