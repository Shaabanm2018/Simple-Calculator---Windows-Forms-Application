namespace basicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region
        private void FocusInputText()
        {
            this.UserInputText.Focus();
        }
        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CEButton_Click(object sender, EventArgs e)
        {
            this.UserInputText.Text = string.Empty;
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            this.UserInputText.Text = string.Empty;
            FocusInputText();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {

            DeleteTextValue();
            FocusInputText();
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("/");
            FocusInputText();
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");
            FocusInputText();
        }

        private void InsertTextValue(string v)
        {
            var selectionStar = this.UserInputText.SelectionStart;

            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, v);
            this.UserInputText.SelectionStart = selectionStar + v.Length;
            this.UserInputText.SelectionLength = 0;
        }

        private void DeleteTextValue()
        {
            if (this.UserInputText.SelectionStart > 0)
            {
                int selectionStart = this.UserInputText.SelectionStart;

                // Delete the character before the cursor position
                this.UserInputText.Text = this.UserInputText.Text.Remove(selectionStart - 1, 1);

                // Set the cursor position after deletion
                this.UserInputText.SelectionStart = selectionStart - 1;
                this.UserInputText.SelectionLength = 0;
            }
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");
        }

        private void Xbutton_Click(object sender, EventArgs e)
        {
            InsertTextValue("*");
            FocusInputText();
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");
            FocusInputText();
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");
            FocusInputText();
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");
        }

        private void PluseButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");
        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            CalculateEquation();
        }

        private void CalculateEquation()
        {
            

            this.CalculationResultText.Text = ParseOperation();

            
            FocusInputText();


        }

        private string ParseOperation()
        {
            try
            {
                var input = this.UserInputText.Text;
                input = input.Replace(" ", "");

                var operation = new Operation();
                var leftSide = true;

                for (int i = 0; i < input.Length; i++)
                {
                    var myString = "0123456789.";
                    if(myString.Any(c => input[i] == c))
                    {
                        if (leftSide)
                            operation.LeftSide = AddNumberPart(operation.LeftSide, input[i]);
                        else
                            operation.RightSide = AddNumberPart(operation.RightSide, input[i]);
                    }
                    else if ("+-*/".Any(c => input[i] == c))
                        {
                        if (!leftSide)
                        {
                            var operatorType = GetOperationType(input[i]);
                            if (operation.RightSide.Length == 0)
                            {
                                if (operatorType != OperationType.Minus)
                                    throw new InvalidOperationException($"Operator (+ * / or more than one -) specified withotu an right side number");
                                operation.RightSide += input[i];
                            }
                            else
                            {
                                // 4 + 5 * 
                                operation.LeftSide = CalculateOperation(operation);
                                operation.OperationType = operatorType;
                                operation.RightSide = string.Empty ;

                            }
                        }
                        else
                        {
                            var operatorType = GetOperationType(input[i]);
                            if (operation.LeftSide.Length == 0)
                            {
                                if (operatorType != OperationType.Minus)
                                    throw new InvalidOperationException($"Operator (+ * / or more than one -) specified withotu an left side number");
                                operation.LeftSide += input[i];
                            }
                            else
                            {
                                operation.OperationType = operatorType;
                                leftSide = false;

                            }
                        }

                        }
                }
                CalculateOperation(operation);
                
                return CalculateOperation(operation);
            }
            catch(Exception ex) {
                return $"Invlalid equation. {ex.Message}";
            }
        }

        private string CalculateOperation(Operation operation)
        {
            double left = 0;
            double right = 0;

            if (string.IsNullOrEmpty(operation.LeftSide) || !double.TryParse(operation.LeftSide, out left))
                throw new InvalidOperationException($"Left Side of the operation was not a number. {operation.LeftSide}");

            if (string.IsNullOrEmpty(operation.RightSide) || !double.TryParse(operation.RightSide, out right))
                throw new InvalidOperationException($"Right Side of the operation was not a number. {operation.RightSide}");
            try
            {
                switch (operation.OperationType)
                {
                    case OperationType.Add:
                        return (left + right).ToString();
                    case OperationType.Minus:
                        return (left - right).ToString();
                    case OperationType.Divide:
                        return (left / right).ToString();
                    case OperationType.Multiply:
                        return (left * right).ToString();
                    default:
                        throw new InvalidOperationException($"Unkown operator type when calculating opertion. {operation.OperationType}");
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Falied to calculate operation {operation.LeftSide} {operation.OperationType} {operation.RightSide}. {ex.Message}");
            }
            return string.Empty;
        }

        private object getOperationType(char v)
        {
            throw new NotImplementedException();
        }

        private OperationType GetOperationType(char character)
        {
            switch (character)
            {
                case '+':
                    return OperationType.Add;
                case '-':
                    return OperationType.Minus;
                case '/':
                    return OperationType.Divide;
                case '*':
                    return OperationType.Multiply;
                default:
                    throw new InvalidOperationException($"Unknown operator type {character}");  

            }
           
        }

        private string AddNumberPart(string currentNumber, char newCharacter)
        {
            if (newCharacter == '.' && currentNumber.Contains('.'))
                throw new InvalidOperationException($"Number {currentNumber} already contains a . and another canot be added");
            return currentNumber + newCharacter;
        }
    }
}
