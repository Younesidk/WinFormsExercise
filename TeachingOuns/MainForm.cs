namespace TeachingOuns
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            var cc1 = CC1TextBox.Text;
            var cc2 = CC2TextBox.Text;
            var exam = ExamTextBox.Text;

            var cc1Double = StringToDouble(cc1);
            var cc2Double = StringToDouble(cc2);
            var examDouble = StringToDouble(exam);

            if ((cc1Double is null) || (cc2Double is null) || (examDouble is null))
            {
                MessageBox.Show("Please type in a number");
            }

            if ((cc1Double > 20 || cc1Double < 0) ||
                (cc2Double > 20 || cc2Double < 0) ||
                (examDouble > 20 || examDouble < 0))
            {
                MessageBox.Show("the grade must be within range");
            }

            var result = ((cc1Double + cc2Double) / 2) * 0.4 + examDouble * 0.6;

            GradeResultLabel.Text = $"You Got : {result}";
        }

        private double? StringToDouble(string text)
        {
            double result;

            
            if (!double.TryParse(text, out result))
            {
                return null;
            }
            

            return result;
        }

    }
}
