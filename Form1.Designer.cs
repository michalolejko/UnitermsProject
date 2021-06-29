
using System;

namespace MASI_pro
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.operationAtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.operationBtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.eliminateOperatorTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.unitermOfCyclicSequencing = new System.Windows.Forms.Label();
            this.horizontalUnitermEradicationOperation = new System.Windows.Forms.Label();
            this.suppresionOperator = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.fontTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fontSizeBox = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.loadComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.loadButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // operationAtextBox
            // 
            this.operationAtextBox.Location = new System.Drawing.Point(12, 42);
            this.operationAtextBox.Name = "operationAtextBox";
            this.operationAtextBox.Size = new System.Drawing.Size(142, 20);
            this.operationAtextBox.TabIndex = 0;
            this.operationAtextBox.TextChanged += new System.EventHandler(this.generateUnitermOfCyclicSequencing);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operacja A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Operacja B:";
            // 
            // operationBtextBox
            // 
            this.operationBtextBox.Location = new System.Drawing.Point(12, 91);
            this.operationBtextBox.Name = "operationBtextBox";
            this.operationBtextBox.Size = new System.Drawing.Size(142, 20);
            this.operationBtextBox.TabIndex = 3;
            this.operationBtextBox.TextChanged += new System.EventHandler(this.generateUnitermOfCyclicSequencing);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(491, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Zamiana poziomej operacji cyklicznego sekwencjowania na poziomą operację eliminow" +
    "ania unitermów:";
            // 
            // eliminateOperatorTextBox
            // 
            this.eliminateOperatorTextBox.Location = new System.Drawing.Point(12, 140);
            this.eliminateOperatorTextBox.Name = "eliminateOperatorTextBox";
            this.eliminateOperatorTextBox.Size = new System.Drawing.Size(142, 20);
            this.eliminateOperatorTextBox.TabIndex = 5;
            this.eliminateOperatorTextBox.TextChanged += new System.EventHandler(this.eliminateOperatorTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Operator eliminowania:";
            // 
            // unitermOfCyclicSequencing
            // 
            this.unitermOfCyclicSequencing.AutoSize = true;
            this.unitermOfCyclicSequencing.Location = new System.Drawing.Point(300, 65);
            this.unitermOfCyclicSequencing.Name = "unitermOfCyclicSequencing";
            this.unitermOfCyclicSequencing.Size = new System.Drawing.Size(0, 13);
            this.unitermOfCyclicSequencing.TabIndex = 7;
            // 
            // horizontalUnitermEradicationOperation
            // 
            this.horizontalUnitermEradicationOperation.AutoSize = true;
            this.horizontalUnitermEradicationOperation.Location = new System.Drawing.Point(300, 220);
            this.horizontalUnitermEradicationOperation.Name = "horizontalUnitermEradicationOperation";
            this.horizontalUnitermEradicationOperation.Size = new System.Drawing.Size(0, 13);
            this.horizontalUnitermEradicationOperation.TabIndex = 8;
            // 
            // suppresionOperator
            // 
            this.suppresionOperator.AutoSize = true;
            this.suppresionOperator.Location = new System.Drawing.Point(345, 143);
            this.suppresionOperator.Name = "suppresionOperator";
            this.suppresionOperator.Size = new System.Drawing.Size(0, 13);
            this.suppresionOperator.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 70);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rodzaje operacji:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(137, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "operacja nieprzemienna";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(123, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "operacja przemienna";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // fontTypeComboBox
            // 
            this.fontTypeComboBox.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.fontTypeComboBox.FormattingEnabled = true;
            this.fontTypeComboBox.Location = new System.Drawing.Point(15, 291);
            this.fontTypeComboBox.Name = "fontTypeComboBox";
            this.fontTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.fontTypeComboBox.TabIndex = 11;
            this.fontTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Czcionka:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Rozmiar czcionki:";
            // 
            // fontSizeBox
            // 
            this.fontSizeBox.Location = new System.Drawing.Point(15, 341);
            this.fontSizeBox.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.fontSizeBox.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.fontSizeBox.Name = "fontSizeBox";
            this.fontSizeBox.Size = new System.Drawing.Size(120, 20);
            this.fontSizeBox.TabIndex = 15;
            this.fontSizeBox.Value = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.fontSizeBox.ValueChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(391, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Pozioma operacja cyklicznego sekwencjowania:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(391, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Pozioma operacja eliminowania:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Załaduj:";
            // 
            // loadComboBox
            // 
            this.loadComboBox.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.loadComboBox.FormattingEnabled = true;
            this.loadComboBox.Location = new System.Drawing.Point(12, 391);
            this.loadComboBox.Name = "loadComboBox";
            this.loadComboBox.Size = new System.Drawing.Size(121, 21);
            this.loadComboBox.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 438);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 20);
            this.nameTextBox.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 422);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Nazwa:";
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(139, 391);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 23;
            this.loadButton.Text = "Załaduj";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loadComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fontSizeBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fontTypeComboBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.suppresionOperator);
            this.Controls.Add(this.horizontalUnitermEradicationOperation);
            this.Controls.Add(this.unitermOfCyclicSequencing);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.eliminateOperatorTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.operationBtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.operationAtextBox);
            this.Name = "Form1";
            this.Text = "MASI PROJEKT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox operationAtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox operationBtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox eliminateOperatorTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label unitermOfCyclicSequencing;
        private System.Windows.Forms.Label horizontalUnitermEradicationOperation;
        private System.Windows.Forms.Label suppresionOperator;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox fontTypeComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown fontSizeBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox loadComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button loadButton;
    }
}

