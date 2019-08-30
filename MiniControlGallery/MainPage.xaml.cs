using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;

namespace MiniControlGallery
{
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();
            Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            TestTreeView.SelectedNodes.Add(TestTreeView.RootNodes[0].Children[1]);
        }

        private void CommandBarFlyoutButton_Click(object sender, RoutedEventArgs e)
        {
            Flyout1.ShowAt(sender as DependencyObject, new FlyoutShowOptions { Placement = FlyoutPlacementMode.TopEdgeAlignedLeft, ShowMode = FlyoutShowMode.Transient });
        }
    }
}
