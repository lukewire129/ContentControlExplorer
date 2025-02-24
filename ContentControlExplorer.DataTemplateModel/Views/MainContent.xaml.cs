using ContentControlExplorer.DataTemplateModel.ViewModels;
using System.Windows.Controls;

namespace ContentControlExplorer.DataTemplateModel.Views
{
    /// <summary>
    /// MainContent.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainContent : UserControl
    {
        public MainContent()
        {
            InitializeComponent();
            this.DataContext = new MainContentViewModel ();
        }
    }
}
