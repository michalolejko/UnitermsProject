using System;

namespace MASI_pro
{
    [Serializable]
    public class Uniterm
    {
        public string operationA;
        public string operationB;
        public string eliminateOperator;
        public bool isRadioButton1Checked;
        public string fontName;
        public int fontSize;

        public Uniterm(string A, string B, string eliminate, bool isRadioBtn1Check, string fontName, int fontSize)
        {
            this.operationA = A;
            this.operationB = B;
            this.eliminateOperator = eliminate;
            this.isRadioButton1Checked = isRadioBtn1Check;
            this.fontName = fontName;
            this.fontSize = fontSize;
        }

        //4 Serialization
        public Uniterm() { }
    }
}
