using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Debug;

namespace video06
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Entry_TextChanged(object sender, EventArgs e)
        {
           string pasado= e.OldTextValue;
            string nuevo= e.NewTextValue;
        }
        private void Entry_Completed(object sender, EventArgs e)
        {
            string text = ((Entry)sender).Text;
        }
    }

}
