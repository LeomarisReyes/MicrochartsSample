using Xamarin.Forms;

namespace MicrochartsSample
{
    public partial class MicrochartsSamplePage : ContentPage
    {
        public MicrochartsSamplePage()
        {
            this.BindingContext = new ViewModel.DisplayChartViewModel();
            InitializeComponent();
        }
    }
}
