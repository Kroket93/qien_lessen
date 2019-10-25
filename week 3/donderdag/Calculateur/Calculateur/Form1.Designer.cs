namespace Calculateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.inputBoxA = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.operatorBox = new System.Windows.Forms.TextBox();
            this.inputBoxB = new System.Windows.Forms.TextBox();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonTimes = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.formulaInputBox = new System.Windows.Forms.TextBox();
            this.formulaOutputBox = new System.Windows.Forms.TextBox();
            this.formulaCalculateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.numberButtonClick);
            // 
            // inputBoxA
            // 
            this.inputBoxA.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBoxA.Location = new System.Drawing.Point(12, 12);
            this.inputBoxA.Multiline = true;
            this.inputBoxA.Name = "inputBoxA";
            this.inputBoxA.Size = new System.Drawing.Size(304, 82);
            this.inputBoxA.TabIndex = 1;
            this.inputBoxA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // outputBox
            // 
            this.outputBox.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBox.Location = new System.Drawing.Point(12, 100);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(695, 82);
            this.outputBox.TabIndex = 3;
            this.outputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 62);
            this.button2.TabIndex = 4;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.numberButtonClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 62);
            this.button3.TabIndex = 5;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.numberButtonClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 256);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 62);
            this.button4.TabIndex = 6;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.numberButtonClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(93, 256);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 62);
            this.button5.TabIndex = 7;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.numberButtonClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(174, 256);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 62);
            this.button6.TabIndex = 8;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.numberButtonClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 324);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 62);
            this.button7.TabIndex = 9;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.numberButtonClick);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(93, 324);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 62);
            this.button8.TabIndex = 10;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.numberButtonClick);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(174, 324);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 62);
            this.button9.TabIndex = 11;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.numberButtonClick);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(93, 392);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(75, 62);
            this.button0.TabIndex = 12;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.numberButtonClick);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(322, 188);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(75, 62);
            this.buttonPlus.TabIndex = 13;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.operatorButtonClick);
            // 
            // operatorBox
            // 
            this.operatorBox.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorBox.Location = new System.Drawing.Point(322, 12);
            this.operatorBox.Multiline = true;
            this.operatorBox.Name = "operatorBox";
            this.operatorBox.Size = new System.Drawing.Size(75, 82);
            this.operatorBox.TabIndex = 14;
            this.operatorBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputBoxB
            // 
            this.inputBoxB.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBoxB.Location = new System.Drawing.Point(403, 12);
            this.inputBoxB.Multiline = true;
            this.inputBoxB.Name = "inputBoxB";
            this.inputBoxB.Size = new System.Drawing.Size(304, 82);
            this.inputBoxB.TabIndex = 15;
            this.inputBoxB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonEquals
            // 
            this.buttonEquals.Location = new System.Drawing.Point(322, 462);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(75, 62);
            this.buttonEquals.TabIndex = 16;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(403, 462);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 62);
            this.buttonReset.TabIndex = 17;
            this.buttonReset.Text = "reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(322, 256);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(75, 62);
            this.buttonMinus.TabIndex = 18;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.operatorButtonClick);
            // 
            // buttonTimes
            // 
            this.buttonTimes.Location = new System.Drawing.Point(322, 324);
            this.buttonTimes.Name = "buttonTimes";
            this.buttonTimes.Size = new System.Drawing.Size(75, 62);
            this.buttonTimes.TabIndex = 19;
            this.buttonTimes.Text = "*";
            this.buttonTimes.UseVisualStyleBackColor = true;
            this.buttonTimes.Click += new System.EventHandler(this.operatorButtonClick);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Location = new System.Drawing.Point(322, 392);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(75, 62);
            this.buttonDivision.TabIndex = 20;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.operatorButtonClick);
            // 
            // buttonDot
            // 
            this.buttonDot.Location = new System.Drawing.Point(12, 392);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(75, 62);
            this.buttonDot.TabIndex = 21;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.numberButtonClick);
            // 
            // formulaInputBox
            // 
            this.formulaInputBox.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formulaInputBox.Location = new System.Drawing.Point(713, 49);
            this.formulaInputBox.Name = "formulaInputBox";
            this.formulaInputBox.Size = new System.Drawing.Size(426, 45);
            this.formulaInputBox.TabIndex = 22;
            // 
            // formulaOutputBox
            // 
            this.formulaOutputBox.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formulaOutputBox.Location = new System.Drawing.Point(713, 188);
            this.formulaOutputBox.Name = "formulaOutputBox";
            this.formulaOutputBox.Size = new System.Drawing.Size(426, 45);
            this.formulaOutputBox.TabIndex = 23;
            // 
            // formulaCalculateButton
            // 
            this.formulaCalculateButton.Location = new System.Drawing.Point(713, 111);
            this.formulaCalculateButton.Name = "formulaCalculateButton";
            this.formulaCalculateButton.Size = new System.Drawing.Size(426, 62);
            this.formulaCalculateButton.TabIndex = 24;
            this.formulaCalculateButton.Text = "Calculate!";
            this.formulaCalculateButton.UseVisualStyleBackColor = true;
            this.formulaCalculateButton.Click += new System.EventHandler(this.formulaCalculateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(708, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 26);
            this.label1.TabIndex = 25;
            this.label1.Text = "doe hieronder je formule in en druk op calculate!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1151, 536);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formulaCalculateButton);
            this.Controls.Add(this.formulaOutputBox);
            this.Controls.Add(this.formulaInputBox);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonTimes);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.inputBoxB);
            this.Controls.Add(this.operatorBox);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.inputBoxA);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Calculateur";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputBoxA;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.TextBox operatorBox;
        private System.Windows.Forms.TextBox inputBoxB;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonTimes;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.TextBox formulaInputBox;
        private System.Windows.Forms.TextBox formulaOutputBox;
        private System.Windows.Forms.Button formulaCalculateButton;
        private System.Windows.Forms.Label label1;
    }
}

