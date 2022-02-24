using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public bool newVal = false;
        public bool equalAgain = false;
        public bool alreadyPreview2 = false;
        public bool squared = false;
        public bool abs = false;
        public bool fact = false;
        public bool sqrt = false;
        public bool squared10 = false;
        public bool log = false;
        public string previewHolder = string.Empty;
        public string operation = string.Empty;
        public string preview2Holder = string.Empty;
        public double newCalculated = 0;
        public double previewCalculated = 0;
        public double calculatedAnswer = 0;
        public double lastNumber = 0;
        public ArrayList paranLastValue = new ArrayList();
        public ArrayList paranOperations = new ArrayList();
        public int paranCounter = 0;
        public bool needChange = false;

       
    }
}
