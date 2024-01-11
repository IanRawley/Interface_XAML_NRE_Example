using Avalonia.Platform;
using ReactiveUI;

namespace Interface_XAML_NRE_Example.ViewModels;

public interface IReadableExample
{
    public string Name { get; }
}

public interface IWriteableExample : IReadableExample
{
    public new string Name { set; }
}

public class ExampleImpl : ReactiveObject, IWriteableExample
{
    private string _name = "Binding with Interfaces!";
    public string Name { get => _name; set => this.RaiseAndSetIfChanged(ref _name, value); }
}

public class MainViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";

    private ExampleImpl _example = new();

    public IReadableExample ReadableExample { get => _example; }

    public IWriteableExample WriteableExample { get => _example; }
}
