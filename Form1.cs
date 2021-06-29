using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Text;

namespace MASI_pro
{
    public partial class Form1 : Form
    {
        private char typeOfOperation;
        private Color linesColor;

        public Form1()
        {
            linesColor = Color.FromArgb(255, 1, 1, 1);
            InitializeComponent();
            initFontComboBox();
            initFilesComboBox();
            typeOfOperation = getTypeOfOperation();
        }

        private void initFilesComboBox()
        {
            loadComboBox.Items.Clear();
            string[] paths = System.IO.Directory.GetFiles(MySerialization.getUnitermsPath());
            foreach (string path in paths)
                loadComboBox.Items.Add(path.Substring(path.LastIndexOf("/")+1));
        }

        private void generateUnitermOfCyclicSequencing(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(operationBtextBox.Text))
                unitermOfCyclicSequencing.Text = "ȼ " + operationAtextBox.Text + " " + getTypeOfOperation() + " " + operationBtextBox.Text;
            else if (!string.IsNullOrEmpty(operationAtextBox.Text))
                unitermOfCyclicSequencing.Text = "ȼ " + operationAtextBox.Text;
            else
                unitermOfCyclicSequencing.Text = "";
            generateHorizontalUnitermEradicationOperation();
            operationAtextBox.BackColor = Color.White;
            operationBtextBox.BackColor = Color.White;
            eliminateOperatorTextBox.BackColor = Color.White;
        }

        private void eliminateOperatorTextBox_TextChanged(object sender, EventArgs e)
        {
            generateHorizontalUnitermEradicationOperation();
        }

        private void generateHorizontalUnitermEradicationOperation()
        {
            if (string.IsNullOrEmpty(operationBtextBox.Text)
                || string.IsNullOrEmpty(operationAtextBox.Text)
                || string.IsNullOrEmpty(eliminateOperatorTextBox.Text))
            {
                clearMyLines();
                horizontalUnitermEradicationOperation.Text = "";
                return;
            }

            horizontalUnitermEradicationOperation.Text = operationAtextBox.Text + " " + getTypeOfOperation() + " " + operationBtextBox.Text + " " + getTypeOfOperation() + " " + eliminateOperatorTextBox.Text;
            drawMyLines();
        }

        private void drawMyLines()
        {
            clearMyLines();
            Pen pen = new Pen(linesColor);
            int x1 = horizontalUnitermEradicationOperation.Location.X;
            int y1 = horizontalUnitermEradicationOperation.Location.Y - 5;
            int x2 = horizontalUnitermEradicationOperation.Location.X + horizontalUnitermEradicationOperation.Size.Width;
            int offset = (int)fontSizeBox.Value / 6;
            pen.Width = offset;
            this.CreateGraphics().DrawLine(pen, x1, y1, x2, y1); //glowna linia
            this.CreateGraphics().DrawLine(pen, x1, y1 + offset, x1, y1 - offset); //linia boczna lewa
            this.CreateGraphics().DrawLine(pen, x2, y1 + offset, x2, y1 - offset); //linia boczna prawa
        }

        private void clearMyLines()
        {
            this.CreateGraphics().Clear(SystemColors.Control);
        }

        private char getTypeOfOperation()
        {
            if (radioButton1.Checked)
                return ',';
            return ';';
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font font = new Font(this.fontTypeComboBox.Text, (float)fontSizeBox.Value, FontStyle.Bold);
            unitermOfCyclicSequencing.Font = font;
            horizontalUnitermEradicationOperation.Font = font;
            suppresionOperator.Font = font;
            generateHorizontalUnitermEradicationOperation();
        }

        private void initFontComboBox()
        {
            using (InstalledFontCollection col = new InstalledFontCollection())
                foreach (FontFamily fa in col.Families)
                    fontTypeComboBox.Items.Add(fa.Name);
            this.fontTypeComboBox.Text = "Arial";
            comboBox1_SelectedIndexChanged(null, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            generateHorizontalUnitermEradicationOperation();
            generateUnitermOfCyclicSequencing(null, null);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(operationAtextBox.Text))
            {
                operationAtextBox.BackColor = Color.Red;
                return;
            }
            if (string.IsNullOrEmpty(operationBtextBox.Text))
            {
                operationBtextBox.BackColor = Color.Red;
                return;
            }
            if (string.IsNullOrEmpty(eliminateOperatorTextBox.Text))
            {
                eliminateOperatorTextBox.BackColor = Color.Red;
                return;
            }
            if (!string.IsNullOrEmpty(nameTextBox.Text))
            {
                nameTextBox.BackColor = Color.White;
                MySerialization.TrySerializeObject<Uniterm>(new Uniterm(operationAtextBox.Text,
                    operationBtextBox.Text,
                    eliminateOperatorTextBox.Text,
                    radioButton1.Checked,
                    fontTypeComboBox.Text,
                    (int)fontSizeBox.Value), MySerialization.getUnitermsPath() + nameTextBox.Text);
                initFilesComboBox();
            }
            else
                nameTextBox.BackColor = Color.Red;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(loadComboBox.Text))
            {
                Uniterm uniterm = MySerialization.DeSerializeObject<Uniterm>(MySerialization.getUnitermsPath() + loadComboBox.Text);
                operationAtextBox.Text = uniterm.operationA;
                operationBtextBox.Text = uniterm.operationB;
                eliminateOperatorTextBox.Text = uniterm.eliminateOperator;
                if (uniterm.isRadioButton1Checked)
                    radioButton1.Checked = true;
                else
                    radioButton2.Checked = true;
                fontTypeComboBox.Text = uniterm.fontName;
                fontSizeBox.Value = uniterm.fontSize;
                comboBox1_SelectedIndexChanged(null, null);
                generateHorizontalUnitermEradicationOperation();
            }
        }
    }
}
