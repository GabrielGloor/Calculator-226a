using System;

namespace MathsLib
{
    public class MathsRequest
    {
        #region private attributes
        private int _op1;
        private int _op2;
        private char _oper;
        #endregion private attributes

        #region public methods
        public MathsRequest(int op1, char oper, int op2)
        {
            _op1 = op1;
            _oper = oper;
            _op2 = op2;
        }

        public int GetOp1()
        {
            return _op1;
        }

        public void SetOp1(int value)
        {
            _op1 = value;
        }

        public int Op2
        {
            get { return _op2; }

            set
            {
                _op2 = value;
            }
        }

        public char Oper
        {
            get
            {
               return _oper;
            }
        }
        #endregion public methods
    }
}
