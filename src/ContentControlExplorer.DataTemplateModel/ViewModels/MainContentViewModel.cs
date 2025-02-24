using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ContentControlExplorer.DataTemplateModel.ViewModels;

public class LogModel
{
    public string Ttitle { get; set; }
}

public class NormalModel : LogModel
{

}
public class ErrorModel : LogModel
{

}
public class WarningModel : LogModel
{

}

public partial class MainContentViewModel : ObservableObject
{
    [ObservableProperty] LogModel log;
    public MainContentViewModel()
    {
        this.Log = new NormalModel ();
    }

    [RelayCommand]
    public void ChangeNormal()
    {
        this.Log = new NormalModel ();
    }

    [RelayCommand]
    public void ChangeError()
    {
        this.Log = new ErrorModel ();
    }
    [RelayCommand]
    public void ChangeWarning()
    {
        this.Log = new WarningModel ();
    }
}
