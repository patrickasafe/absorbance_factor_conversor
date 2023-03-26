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
            if (string.IsNullOrEmpty(firstValueInput.Text) || string.IsNullOrEmpty(secondValueInput.Text) ||
                string.IsNullOrEmpty(thirdValueInput.Text))
            {
                // Display an error message box
                MessageBox.Show("Por favor, preencha os campos com os valores.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var firstValue = float.Parse(firstValueInput.Text);
                var secondValue = float.Parse(secondValueInput.Text);
                var thirdValue = float.Parse(thirdValueInput.Text);

                var result = Calculator.GetResult(firstValue, secondValue, thirdValue);

                resultField.Text = result.ToString(CultureInfo.InvariantCulture);
            }
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

        private void UpdateLabels()
        {
            var labels = Calculator.GetLabels();
            firstValueLabel.Text = labels["firstValue"];
            secondValueLabel.Text = labels["secondValue"];
            thirdValueLabel.Text = labels["thirdValue"];
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Get the user's current culture
            var culture = CultureInfo.CurrentCulture;

            // Check if the pressed key is a digit or the decimal separator
            if (!char.IsControl(e.KeyChar) &&
                !(char.IsDigit(e.KeyChar) || e.KeyChar == culture.NumberFormat.NumberDecimalSeparator[0]))
            {
                e.Handled = true;
            }

            // Allow only one decimal separator
            if (e.KeyChar == culture.NumberFormat.NumberDecimalSeparator[0] &&
                (sender as TextBox)!.Text.IndexOf(culture.NumberFormat.NumberDecimalSeparator[0]) > -1)
            {
                e.Handled = true;
            }
        }
    }
}