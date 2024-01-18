using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class NumData
    {
        // num은 Stack으로 구현
        private Stack<string> num = new Stack<string>();

        private bool checkSpecialOperation = false;
        private bool checkOperation = true;

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
            this.num.Push(num);
        }

        public void ClearNum()
        {
            num.Clear();
        }

        public void PopNum()
        {
            num.Pop();
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
