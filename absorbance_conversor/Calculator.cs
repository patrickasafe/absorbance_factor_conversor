namespace absorbance_factor_conversor
{
    public class Calculator
    {
        private float _firstValue = 0;
        private string _firstValueLabel = string.Empty;
        private int _modeState = 0;
        private float _secondValue = 0;
        private string _secondValueLabel = string.Empty;
        private float _thirdValue = 0;
        private string _thirdValueLabel = string.Empty;

        public Dictionary<string, string> GetLabels()
        {
            var labels = new Dictionary<string, string>
            {
                { "firstValue", _firstValueLabel },
                { "secondValue", _secondValueLabel },
                { "thirdValue", _thirdValueLabel }
            };
            return labels;
        }

        public float GetResult(float firstValue, float secondValue, float thirdValue)
        {
            var result = Calculate(firstValue, secondValue, thirdValue);

            return result;
        }

        public void Mode_Changer(int mode)
        {
            Select_Mode(mode);
        }

        private float Calculate(float firstValue, float secondValue, float thirdValue)
        {
            Update_Values(firstValue, secondValue, thirdValue);

            float result = _modeState switch
            {
                0 => _secondValue * _thirdValue / _firstValue,
                1 => _firstValue * _secondValue / _thirdValue,
                _ => 0
            };

            return result;
        }

        private void Select_Mode(int mode)
        {
            _modeState = mode;

            switch (mode)
            {
                case 0:
                    _firstValueLabel = "Concentração obtida";
                    _secondValueLabel = "Fator utilizado";
                    _thirdValueLabel = "Concentração desejada";
                    break;

                case 1:
                    _firstValueLabel = "Concentração obtida";
                    _secondValueLabel = "Absorbância utilizada";
                    _thirdValueLabel = "Concentração desejada";
                    break;
            }
        }

        private void Update_Values(float firstValue, float secondValue, float thirdValue)
        {
            _firstValue = firstValue;
            _secondValue = secondValue;
            _thirdValue = thirdValue;
        }
    }
}