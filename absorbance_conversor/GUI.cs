using System.Globalization;

namespace absorbance_factor_conversor
{
    public partial class Gui : Form
    {
        public Calculator Calculator = new();

        public Gui()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            var firstValue = float.Parse(this.firstValueInput.Text);
            var secondValue = float.Parse(this.secondValueInput.Text);
            var thirdValue = float.Parse(this.thirdValueInput.Text);

            var result = Calculator.getResult(firstValue, secondValue, thirdValue);

            this.resultField.Text = result.ToString(CultureInfo.InvariantCulture);
        }

        private void ModeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedOption = modeSelector.SelectedItem.ToString();

            switch (selectedOption)
            {
                case "Fator":
                    Calculator.Mode_Changer(0);
                    UpdateLabels();
                    break;

                case "Absorbância":
                    Calculator.Mode_Changer(1);
                    UpdateLabels();
                    break;
            }
        }

        private void ModeSelectorLoad(object sender, EventArgs e)
        {
            modeSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            modeSelector.Items.AddRange(new object[] { "Fator", "Absorbância" });
            modeSelector.SelectedIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void UpdateLabels()
        {
            var labels = Calculator.GetLabels();
            firstValueLabel.Text = labels["firstValue"];
            secondValueLabel.Text = labels["secondValue"];
            thirdValueLabel.Text = labels["thirdValue"];
        }
    }
}