using System;
using System.Reactive.Disposables;


namespace ImageGlass.Library.SwatcherExtensions
{
    public static class ObservableExtensions
    {
        public static void DisposeWith(this IDisposable disposable, CompositeDisposable bag)
        {
            bag.Add(disposable);
        }
    }
}
