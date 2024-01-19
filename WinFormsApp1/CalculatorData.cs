using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class CalculatorData
    {
        // num은 Stack으로 구현
        static private Stack<string> num = new Stack<string>();
        static private string operation = null;

        static private double calValue1 = -1;
        static private double calValue2 = 0;

        static private bool checkSpecialOperation = false;
        static private bool checkOperation = true;

        public string getNum()
        {
            string calNumber = "";
            foreach (string stackNumber in num)
            {
                calNumber = stackNumber + calNumber;
            }
            return calNumber;
        }

        public void setNum(string num)
        {
            CalculatorData.num.Push(num);
        }

        public void ClearNum()
        {
            num.Clear();
        }

        public void PopNum()
        {
            num.Pop();
        }

        public string Op
        {
            get
            {
                return CalculatorData.operation;
            }

            set
            {
                CalculatorData.operation = value;
            }
        }

        public double CalValue1
        {
            get
            {
                return CalculatorData.calValue1;
            }
            set
            {
                CalculatorData.calValue1 = value;
            }
        }

        public double CalValue2
        {
            get
            {
                return CalculatorData.calValue2;
            }

            set
            {
                CalculatorData.calValue2 = value;
            }
        }

        public void UseSpecialOperation()
        {
            checkSpecialOperation = true;
        }

        public void NotUseSpecialOperation()
        {
            checkSpecialOperation = false;
        }

        public void UseOperation()
        {
            checkOperation = true;
        }

        public void NotUseOperation()
        {
            checkOperation = false;
        }

        public bool IsSpecialOperation()
        {
            return checkSpecialOperation;
        }

        public bool IsOperation()
        {
            return checkOperation;
        }
    }
}
