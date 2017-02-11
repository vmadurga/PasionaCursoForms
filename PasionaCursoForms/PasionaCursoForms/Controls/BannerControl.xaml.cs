using Xamarin.Forms;

namespace PasionaCursoForms.Controls
{
    public partial class BannerControl
    {
        public BannerControl()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty PageTitleProperty = BindableProperty.Create("PageTitle", typeof(string), typeof(BannerControl), default(string), BindingMode.TwoWay, null, PageTitlePropertyChanged);
        private static void PageTitlePropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            var control = bindable as BannerControl;
            if (control != null)
            {
                var stringValue = newvalue as string;
                if (!string.IsNullOrEmpty(stringValue))
                {
                    control.TitleLabel.Text = stringValue;
                }
            }
        }

        public string PageTitle
        {
            get
            {
                return (string)GetValue(PageTitleProperty);
            }
            set
            {
                SetValue(PageTitleProperty, value);
            }
        }
    }
}
