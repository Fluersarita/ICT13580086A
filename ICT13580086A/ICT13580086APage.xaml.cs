using Xamarin.Forms;

namespace ICT13580086A
{
    public partial class ICT13580086APage : ContentPage
    {
        public ICT13580086APage()
        {
            InitializeComponent();

            okButton.Clicked += OkButton_Clicked;

            genderPicker.Items.Add("I am a Boy");
            genderPicker.Items.Add("I am a Girl");

            mySlider.ValueChanged += MySlider_ValueChanged;

            myStepper.ValueChanged += MyStepper_ValueChanged;
        }


        void OkButton_Clicked(object sender, System.EventArgs e)
        {
            firstNameLabel.Text = firstNameEntry.Text;
        }

        void MySlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            valueLabel.Text = value.ToString();
        }

        void MyStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            valueLabel.Text = value.ToString();
        }
    }
}
