using System.Windows;
using System.Windows.Controls;

namespace ContentControlExplorer.DataTemplateSelectorSample;

public class TestDataTemplateSelector : DataTemplateSelector
{
    public DataTemplate? ATemplate { get; set; }
    public DataTemplate? BTemplate { get; set; }
    public DataTemplate? EmptyTemplate { get; set; }

    public override DataTemplate? SelectTemplate(object item, DependencyObject container)
    {
        if (item is string userType)
        {
            if(userType =="BMW")
            {
                return ATemplate;
            }
            else if (userType == "LUKE")
            {
                return BTemplate;
            }
            return EmptyTemplate;
        }
        return base.SelectTemplate (item, container);
    }
}
