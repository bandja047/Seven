using System.Threading.Tasks;
using System.Windows.Forms;
using LiveChartsCore.SkiaSharpView.WinForms;
using ViewModelsSamples.Bars.Race;

namespace SevenBusinessClient
{
    public partial class ViewData : UserControl
    {
        private readonly CartesianChart cartesianChart;
        private readonly ViewModel viewModel;

        public ViewData()
        {
            InitializeComponent();
            Size = new System.Drawing.Size(50, 50);

            viewModel = new ViewModel();

            cartesianChart = new CartesianChart
            {
                Series = viewModel.Series,
                XAxes = viewModel.XAxes,
                YAxes = viewModel.YAxes,
                TooltipPosition = LiveChartsCore.Measure.TooltipPosition.Hidden,

                // out of livecharts properties...
                Location = new System.Drawing.Point(0, 0),
                Size = new System.Drawing.Size(50, 50),
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom
            };

            Controls.Add(cartesianChart);
        }
    }
}
