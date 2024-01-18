using System.Diagnostics.Eventing.Reader;
using System.Security.Policy;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Calculator cal = new Calculator();
        NumData numData = new NumData();
        private double calValue1 = -1;
        private double calValue2 = 0;
        
        private double pastValue = 0;

        private string pastOperation = "";
        private string operation = "";

        public Form1()
        {
            InitializeComponent();

            this.btnZero.Click += ButtonNumber_Click;
            this.btnOne.Click += ButtonNumber_Click;
            this.btnTwo.Click += ButtonNumber_Click;
            this.btnThree.Click += ButtonNumber_Click;
            this.btnFour.Click += ButtonNumber_Click;
            this.btnFive.Click += ButtonNumber_Click;
            this.btnSix.Click += ButtonNumber_Click;
            this.btnSeven.Click += ButtonNumber_Click;
            this.btnEight.Click += ButtonNumber_Click;
            this.btnNine.Click += ButtonNumber_Click;
            this.btnDot.Click += ButtonNumber_Click;
            this.btnEqual.Click += BtnEqual_Click;
            this.btnPlus.Click += BtnOperator_Click;
            this.btnMinus.Click += BtnOperator_Click;
            this.btnMulti.Click += BtnOperator_Click;
            this.btnDivide.Click += BtnOperator_Click;
            this.btnClear.Click += BtnClear_Click;
            this.btnBack.Click += BtnBack_Click;
            this.btnReciprocal.Click += BtnReciprocal_Click;
            this.btnSquare.Click += BtnSquare_Click;
            this.btnRoot.Click += BtnRoot_Click;

            this.KeyDown += Form1_KeyDown;
            this.PreviewKeyDown += Form1_PreviewKeyDown;

            this.tbNumeric.TextAlign = HorizontalAlignment.Right;
            this.tbCalculate.TextAlign = HorizontalAlignment.Right;
        }

        private void Form1_PreviewKeyDown(object? sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnEqual_Click(sender, e);
            }
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Back:
                    BtnBack_Click(sender, e);
                    break;
                case Keys.Escape:
                    BtnClear_Click(sender, e);
                    break;
                case Keys.Oemplus:
                    BtnOperator_Click(btnPlus, e);
                    break;
                case Keys.Add:
                    BtnOperator_Click(btnPlus, e);
                    break;
                case Keys.OemMinus:
                    BtnOperator_Click(btnMinus, e);
                    break;
                case Keys.Subtract:
                    BtnOperator_Click(btnMinus, e);
                    break;
                case Keys.Multiply:
                    BtnOperator_Click(btnMulti, e);
                    break;
                case Keys.Divide:
                    BtnOperator_Click(btnDivide, e);
                    break;
                case Keys.NumPad0:
                    ButtonNumber_Click(btnZero, e);
                    break;
                case Keys.D0:
                    ButtonNumber_Click(btnZero, e);
                    break;
                case Keys.NumPad1:
                    ButtonNumber_Click(btnOne, e);
                    break;
                case Keys.D1:
                    ButtonNumber_Click(btnOne, e);
                    break;
                case Keys.NumPad2:
                    ButtonNumber_Click(btnTwo, e);
                    break;
                case Keys.D2:
                    ButtonNumber_Click(btnTwo, e);
                    break;
                case Keys.NumPad3:
                    ButtonNumber_Click(btnThree, e);
                    break;
                case Keys.D3:
                    ButtonNumber_Click(btnThree, e);
                    break;
                case Keys.NumPad4:
                    ButtonNumber_Click(btnFour, e);
                    break;
                case Keys.D4:
                    ButtonNumber_Click(btnFour, e);
                    break;
                case Keys.NumPad5:
                    ButtonNumber_Click(btnFive, e);
                    break;
                case Keys.D5:
                    ButtonNumber_Click(btnFive, e);
                    break;
                case Keys.NumPad6:
                    ButtonNumber_Click(btnSix, e);
                    break;
                case Keys.D6:
                    ButtonNumber_Click(btnSix, e);
                    break;
                case Keys.NumPad7:
                    ButtonNumber_Click(btnSeven, e);
                    break;
                case Keys.D7:
                    ButtonNumber_Click(btnSeven, e);
                    break;
                case Keys.NumPad8:
                    ButtonNumber_Click(btnEight, e);
                    break;
                case Keys.D8:
                    ButtonNumber_Click(btnEight, e);
                    break;
                case Keys.NumPad9:
                    ButtonNumber_Click(btnNine, e);
                    break;
                case Keys.D9:
                    ButtonNumber_Click(btnNine, e);
                    break;
                case Keys.Decimal:
                    ButtonNumber_Click(btnDot, e);
                    break;
                case Keys.Q:
                    BtnSquare_Click(sender, e);
                    break;
                case Keys.R:
                    BtnReciprocal_Click(sender, e);
                    break;
            }
        }

        private void BtnRoot_Click(object? sender, EventArgs e)
        {
            Calculator cal = new Calculator();
            string num = "0";

            if (numData.IsOperation() == true && calValue1 >= 0)
            {
                num = tbNumeric.Text;
                tbCalculate.Text = $"{calValue1}{operation}v/({num})";
            }
            else if (numData.IsSpecialOperation() == false)
            {
                num = tbNumeric.Text;
                tbCalculate.Text = $"v/({num})";
            }
            else
            {
                num = tbCalculate.Text;
                tbCalculate.Text = $"v/({num})";
            }
            calValue2 = double.Parse(tbNumeric.Text);
            tbNumeric.Text = cal.Root(calValue2).ToString();
            numData.UseSpecialOperation();
        }

        private void BtnSquare_Click(object? sender, EventArgs e)
        {
            Calculator cal = new Calculator();
            string num = "0";

            if (numData.IsOperation() == true && calValue1 >= 0)
            {
                num = tbNumeric.Text;
                tbCalculate.Text = $"{calValue1}{operation}sqr({num})";
            }
            else if (numData.IsSpecialOperation() == false)
            {
                num = tbNumeric.Text;
                tbCalculate.Text = $"sqr({num})";
            }
            else
            {
                num = tbCalculate.Text;
                tbCalculate.Text = $"sqr({num})";
            }
            calValue2 = double.Parse(tbNumeric.Text);
            tbNumeric.Text = cal.Sqaure(calValue2).ToString();
            numData.UseSpecialOperation();
        }

        private void BtnReciprocal_Click(object? sender, EventArgs e)
        {
            Calculator cal = new Calculator();
            string num = "0";

            if (numData.IsOperation() == true && calValue1 >= 0)
            {
                num = tbNumeric.Text;
                tbCalculate.Text = $"{calValue1}{operation}1/({num})";
            }
            else if (numData.IsSpecialOperation() == false)
            {
                num = tbNumeric.Text;
                tbCalculate.Text = $"1/({num})";
            }
            else
            {
                num = tbCalculate.Text;
                tbCalculate.Text = $"1/({num})";
            }
            calValue2 = double.Parse(tbNumeric.Text);
            tbNumeric.Text = cal.Reciprocal(calValue2).ToString();
            numData.UseSpecialOperation();
        }

        private void BtnBack_Click(object? sender, EventArgs e)
        {
            // 지우기 버튼 클릭
            // 잘못 입력된 숫자 지우기
            try
            {
                numData.PopNum();
                tbNumeric.Text = numData.getNum();
            }
            catch (FormatException exc)
            {
                Console.WriteLine(exc);
            }
        }

        private void BtnClear_Click(object? sender, EventArgs e)
        {
            // C버튼 클릭
            // 모두 지우기
            numData.ClearNum();
            calValue1 = -1;
            operation = "";
            tbNumeric.Text = "0";
            tbCalculate.Text = "";
            numData.NotUseSpecialOperation();
            pastValue = 0;
            pastOperation = "";
        }

        private void BtnOperator_Click(object? sender, EventArgs e)
        {
            string num = "";
            double result = 0;

            if (calValue1 >= 0 && numData.IsOperation() == true)
            {
                num = tbNumeric.Text;
                calValue2 = double.Parse(num);
                if (operation == "+")
                {
                    result = calValue1 + calValue2;
                    tbNumeric.Text = cal.Plus(calValue1, calValue2).ToString();
                }
                else if (operation == "-")
                {
                    result = calValue1 - calValue2;
                    tbNumeric.Text = cal.Minus(calValue1, calValue2).ToString();
                }
                else if (operation == "*")
                {
                    result = calValue1 * calValue2;
                    tbNumeric.Text = cal.Multiply(calValue1, calValue2).ToString();
                }
                else if (operation == "/")
                {
                    result = calValue1 / calValue2;
                    if (calValue2 == 0)
                        tbNumeric.Text = "0으로 나눌 수 없습니다.";
                    else
                        tbNumeric.Text = cal.Divide(calValue1, calValue2).ToString();
                }

                if (sender == btnDivide)
                    operation = "/";
                else if (sender == btnMulti)
                    operation = "*";
                else if (sender == btnMinus)
                    operation = "-";
                else if (sender == btnPlus)
                    operation = "+";

                numData.NotUseOperation();
                calValue1 = result;
                tbCalculate.Text = result.ToString() + operation;
                numData.ClearNum();
            }
            // 아닐 경우 입력받은 수와 연산자를 tbCalculate에 출력
            else
            {
                if (sender == btnDivide)
                    operation = "/";
                else if (sender == btnMulti)
                    operation = "*";
                else if (sender == btnMinus)
                    operation = "-";
                else if (sender == btnPlus)
                    operation = "+";

                numData.NotUseOperation();
                num = tbNumeric.Text;
                calValue1 = double.Parse(num);
                tbCalculate.Text = $"{num}{operation}";
                numData.ClearNum();
            }
        }

        private void BtnEqual_Click(object? sender, EventArgs e)
        {
            string num = "";

            // = 연산자
            // 값을 계산하는 연산자

            num = tbNumeric.Text;
            calValue2 = double.Parse(num);

            if (numData.IsSpecialOperation() == true)
            {
                tbCalculate.Text += "=";
            }
            else if(operation == "" && pastOperation != "")
            {
                if(pastOperation == "+")
                {
                    tbCalculate.Text = $"{calValue2}{pastOperation}{pastValue}=";
                    tbNumeric.Text = (calValue2 + pastValue).ToString();
                    pastOperation = "+";
                }
                else if(pastOperation == "-")
                {
                    tbCalculate.Text = $"{calValue2}{pastOperation}{pastValue}=";
                    tbNumeric.Text = (calValue2 - pastValue).ToString();
                    pastOperation = "-";
                }
                else if(pastOperation == "*")
                {
                    tbCalculate.Text = $"{calValue2}{pastOperation}{pastValue}=";
                    tbNumeric.Text = (calValue2 * pastValue).ToString();
                    pastOperation = "*";
                }
                else if(pastOperation == "/")
                {
                    tbCalculate.Text = $"{calValue2}{pastOperation}{pastValue}=";
                    tbNumeric.Text = (calValue2 / pastValue).ToString();
                    pastOperation = "/";
                }
            }
            else if(operation == "")
            {
                tbCalculate.Text = num + "=";
            }
            else
            {
                tbCalculate.Text += num + "=";
            }

            if (operation == "+")
            {
                tbNumeric.Text = cal.Plus(calValue1, calValue2).ToString();
                pastOperation = "+";
            }
            else if (operation == "-")
            {
                tbNumeric.Text = cal.Minus(calValue1, calValue2).ToString();
                pastOperation = "-";
            }
            else if (operation == "*")
            {
                tbNumeric.Text = cal.Multiply(calValue1, calValue2).ToString();
                pastOperation = "*";
            }
            else if (operation == "/")
            {
                if (calValue2 == 0)
                {
                    tbNumeric.Text = "0으로 나눌 수 없습니다.";
                }
                else
                {
                    tbNumeric.Text = cal.Divide(calValue1, calValue2).ToString();
                    pastOperation = "/";
                }

            }
            if (numData.IsOperation())
            {
                pastValue = calValue2;
            }
            numData.NotUseOperation();
            numData.NotUseSpecialOperation();
            calValue1 = -1;
            numData.ClearNum();
            operation = "";
        }

        // Tag 활용할 수 있음.
        private void ButtonNumber_Click(object? sender, EventArgs e)
        {
            string num = numData.getNum();

            if ((Button?)sender == btnZero)
            {
                if (num == "0")
                {
                    numData.PopNum();
                    numData.setNum("0");
                }
                else
                    numData.setNum("0");
            }
            else if ((Button?)sender == btnOne)
            {
                if (num == "0")
                {
                    numData.PopNum();
                    numData.setNum("1");
                }
                else
                    numData.setNum("1");
            }
            else if ((Button?)sender == btnTwo)
            {
                if (num == "0")
                {
                    numData.PopNum();
                    numData.setNum("2");
                }
                else
                    numData.setNum("2");
            }
            else if ((Button?)sender == btnThree)
            {
                if (num == "0")
                {
                    numData.PopNum();
                    numData.setNum("3");
                }
                else
                    numData.setNum("3");
            }
            else if ((Button?)sender == btnFour)
            {
                if (num == "0")
                {
                    numData.PopNum();
                    numData.setNum("4");
                }
                else
                    numData.setNum("4");
            }
            else if ((Button?)sender == btnFive)
            {
                if (num == "0")
                {
                    numData.PopNum();
                    numData.setNum("5");
                }
                else
                    numData.setNum("5");
            }
            else if ((Button?)sender == btnSix)
            {
                if (num == "0")
                {
                    numData.PopNum();
                    numData.setNum("6");
                }
                else
                    numData.setNum("6");
            }
            else if ((Button?)sender == btnSeven)
            {
                if (num == "0")
                {
                    numData.PopNum();
                    numData.setNum("7");
                }
                else
                    numData.setNum("7");
            }
            else if ((Button?)sender == btnEight)
            {
                if (num == "0")
                {
                    numData.PopNum();
                    numData.setNum("8");
                }
                else
                    numData.setNum("8");
            }
            else if ((Button?)sender == btnNine)
            {
                if (num == "0")
                {
                    numData.PopNum();
                    numData.setNum("9");
                }
                else
                    numData.setNum("9");
            }
            else if ((Button?)sender == btnDot)
            {
                if (num == null)
                {
                    numData.setNum("0");
                    numData.setNum(".");
                }
                else
                    numData.setNum(".");
            }
            tbNumeric.Text = numData.getNum();
            numData.UseOperation();
        }

    }
}
