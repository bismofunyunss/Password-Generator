namespace Secure_Password_Generator
{
    partial class Password_Generator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Password_Generator));
            passphraseBox = new GroupBox();
            wordAmountLbl = new Label();
            wordAmountCounter = new NumericUpDown();
            generatePass = new Button();
            typeBox = new GroupBox();
            passPhraseOptionsBox = new GroupBox();
            label1 = new Label();
            delimiterBox = new ComboBox();
            includeNumbers = new CheckBox();
            capitalLetters = new CheckBox();
            passwordOptionsBox = new GroupBox();
            passwordOptions = new GroupBox();
            passSpecialChars = new CheckBox();
            passLowerCase = new CheckBox();
            passNumericChars = new CheckBox();
            passCapitalLetters = new CheckBox();
            passLenLbl = new Label();
            passLenNumeric = new NumericUpDown();
            passPhraseRadioBtn = new RadioButton();
            passwordRadioBtn = new RadioButton();
            groupBoxOutput = new GroupBox();
            outputText = new TextBox();
            passphraseBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)wordAmountCounter).BeginInit();
            typeBox.SuspendLayout();
            passPhraseOptionsBox.SuspendLayout();
            passwordOptionsBox.SuspendLayout();
            passwordOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)passLenNumeric).BeginInit();
            groupBoxOutput.SuspendLayout();
            SuspendLayout();
            // 
            // passphraseBox
            // 
            passphraseBox.Controls.Add(wordAmountLbl);
            passphraseBox.Controls.Add(wordAmountCounter);
            passphraseBox.ForeColor = Color.WhiteSmoke;
            passphraseBox.Location = new Point(347, 65);
            passphraseBox.Name = "passphraseBox";
            passphraseBox.Size = new Size(332, 114);
            passphraseBox.TabIndex = 0;
            passphraseBox.TabStop = false;
            passphraseBox.Text = "Pass Phrase";
            // 
            // wordAmountLbl
            // 
            wordAmountLbl.AutoSize = true;
            wordAmountLbl.Location = new Point(6, 33);
            wordAmountLbl.Name = "wordAmountLbl";
            wordAmountLbl.Size = new Size(126, 25);
            wordAmountLbl.TabIndex = 1;
            wordAmountLbl.Text = "Word Amount";
            // 
            // wordAmountCounter
            // 
            wordAmountCounter.BackColor = Color.Black;
            wordAmountCounter.ForeColor = Color.Gold;
            wordAmountCounter.Location = new Point(6, 61);
            wordAmountCounter.Maximum = new decimal(new int[] { 128, 0, 0, 0 });
            wordAmountCounter.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            wordAmountCounter.Name = "wordAmountCounter";
            wordAmountCounter.Size = new Size(320, 31);
            wordAmountCounter.TabIndex = 0;
            wordAmountCounter.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // generatePass
            // 
            generatePass.BackColor = Color.Black;
            generatePass.FlatAppearance.BorderSize = 2;
            generatePass.FlatStyle = FlatStyle.Flat;
            generatePass.ForeColor = Color.Gold;
            generatePass.Location = new Point(12, 461);
            generatePass.Name = "generatePass";
            generatePass.Size = new Size(703, 48);
            generatePass.TabIndex = 1;
            generatePass.Text = "&Generate Password";
            generatePass.UseVisualStyleBackColor = false;
            generatePass.Click += GeneratePass_Click;
            // 
            // typeBox
            // 
            typeBox.Controls.Add(passPhraseOptionsBox);
            typeBox.Controls.Add(passwordOptionsBox);
            typeBox.Controls.Add(passPhraseRadioBtn);
            typeBox.Controls.Add(passwordRadioBtn);
            typeBox.Controls.Add(passphraseBox);
            typeBox.ForeColor = Color.WhiteSmoke;
            typeBox.Location = new Point(12, 88);
            typeBox.Name = "typeBox";
            typeBox.Size = new Size(703, 367);
            typeBox.TabIndex = 2;
            typeBox.TabStop = false;
            typeBox.Text = "Type";
            // 
            // passPhraseOptionsBox
            // 
            passPhraseOptionsBox.Controls.Add(label1);
            passPhraseOptionsBox.Controls.Add(delimiterBox);
            passPhraseOptionsBox.Controls.Add(includeNumbers);
            passPhraseOptionsBox.Controls.Add(capitalLetters);
            passPhraseOptionsBox.ForeColor = Color.WhiteSmoke;
            passPhraseOptionsBox.Location = new Point(347, 178);
            passPhraseOptionsBox.Name = "passPhraseOptionsBox";
            passPhraseOptionsBox.Size = new Size(350, 159);
            passPhraseOptionsBox.TabIndex = 5;
            passPhraseOptionsBox.TabStop = false;
            passPhraseOptionsBox.Text = "Options";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 62);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 3;
            label1.Text = "String Delimiters";
            // 
            // delimiterBox
            // 
            delimiterBox.BackColor = Color.Black;
            delimiterBox.DropDownStyle = ComboBoxStyle.DropDownList;
            delimiterBox.FlatStyle = FlatStyle.Flat;
            delimiterBox.ForeColor = Color.Gold;
            delimiterBox.FormattingEnabled = true;
            delimiterBox.Items.AddRange(new object[] { "\" \"", "\"-\"", "\"/\"", "\".\"" });
            delimiterBox.Location = new Point(6, 90);
            delimiterBox.Name = "delimiterBox";
            delimiterBox.Size = new Size(320, 33);
            delimiterBox.TabIndex = 2;
            // 
            // includeNumbers
            // 
            includeNumbers.AutoSize = true;
            includeNumbers.Location = new Point(179, 30);
            includeNumbers.Name = "includeNumbers";
            includeNumbers.Size = new Size(165, 29);
            includeNumbers.TabIndex = 1;
            includeNumbers.Text = "Include Number";
            includeNumbers.UseVisualStyleBackColor = true;
            // 
            // capitalLetters
            // 
            capitalLetters.AutoSize = true;
            capitalLetters.Location = new Point(6, 30);
            capitalLetters.Name = "capitalLetters";
            capitalLetters.Size = new Size(170, 29);
            capitalLetters.TabIndex = 0;
            capitalLetters.Text = "Capitalize Words";
            capitalLetters.UseVisualStyleBackColor = true;
            // 
            // passwordOptionsBox
            // 
            passwordOptionsBox.Controls.Add(passwordOptions);
            passwordOptionsBox.Controls.Add(passLenLbl);
            passwordOptionsBox.Controls.Add(passLenNumeric);
            passwordOptionsBox.ForeColor = Color.WhiteSmoke;
            passwordOptionsBox.Location = new Point(9, 65);
            passwordOptionsBox.Name = "passwordOptionsBox";
            passwordOptionsBox.Size = new Size(332, 287);
            passwordOptionsBox.TabIndex = 4;
            passwordOptionsBox.TabStop = false;
            passwordOptionsBox.Text = "Password Options";
            // 
            // passwordOptions
            // 
            passwordOptions.Controls.Add(passSpecialChars);
            passwordOptions.Controls.Add(passLowerCase);
            passwordOptions.Controls.Add(passNumericChars);
            passwordOptions.Controls.Add(passCapitalLetters);
            passwordOptions.ForeColor = Color.WhiteSmoke;
            passwordOptions.Location = new Point(6, 98);
            passwordOptions.Name = "passwordOptions";
            passwordOptions.Size = new Size(320, 174);
            passwordOptions.TabIndex = 4;
            passwordOptions.TabStop = false;
            passwordOptions.Text = "Options";
            // 
            // passSpecialChars
            // 
            passSpecialChars.AutoSize = true;
            passSpecialChars.Location = new Point(10, 100);
            passSpecialChars.Name = "passSpecialChars";
            passSpecialChars.Size = new Size(261, 29);
            passSpecialChars.TabIndex = 3;
            passSpecialChars.Text = "!@#$%^&*()-_=+[{]}|\\;:'\",<.>/?";
            passSpecialChars.TextAlign = ContentAlignment.MiddleCenter;
            passSpecialChars.UseVisualStyleBackColor = true;
            // 
            // passLowerCase
            // 
            passLowerCase.AutoSize = true;
            passLowerCase.Location = new Point(10, 135);
            passLowerCase.Name = "passLowerCase";
            passLowerCase.Size = new Size(62, 29);
            passLowerCase.TabIndex = 2;
            passLowerCase.Text = "a-z";
            passLowerCase.UseVisualStyleBackColor = true;
            // 
            // passNumericChars
            // 
            passNumericChars.AutoSize = true;
            passNumericChars.Location = new Point(10, 65);
            passNumericChars.Name = "passNumericChars";
            passNumericChars.Size = new Size(65, 29);
            passNumericChars.TabIndex = 1;
            passNumericChars.Text = "0-9";
            passNumericChars.UseVisualStyleBackColor = true;
            // 
            // passCapitalLetters
            // 
            passCapitalLetters.AutoSize = true;
            passCapitalLetters.Location = new Point(8, 30);
            passCapitalLetters.Name = "passCapitalLetters";
            passCapitalLetters.Size = new Size(67, 29);
            passCapitalLetters.TabIndex = 0;
            passCapitalLetters.Text = "A-Z";
            passCapitalLetters.UseVisualStyleBackColor = true;
            // 
            // passLenLbl
            // 
            passLenLbl.AutoSize = true;
            passLenLbl.Location = new Point(6, 33);
            passLenLbl.Name = "passLenLbl";
            passLenLbl.Size = new Size(146, 25);
            passLenLbl.TabIndex = 3;
            passLenLbl.Text = "Password Length";
            // 
            // passLenNumeric
            // 
            passLenNumeric.BackColor = Color.Black;
            passLenNumeric.ForeColor = Color.Gold;
            passLenNumeric.Location = new Point(6, 61);
            passLenNumeric.Maximum = new decimal(new int[] { 128, 0, 0, 0 });
            passLenNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            passLenNumeric.Name = "passLenNumeric";
            passLenNumeric.Size = new Size(320, 31);
            passLenNumeric.TabIndex = 2;
            passLenNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // passPhraseRadioBtn
            // 
            passPhraseRadioBtn.AutoSize = true;
            passPhraseRadioBtn.Location = new Point(551, 30);
            passPhraseRadioBtn.Name = "passPhraseRadioBtn";
            passPhraseRadioBtn.Size = new Size(128, 29);
            passPhraseRadioBtn.TabIndex = 1;
            passPhraseRadioBtn.TabStop = true;
            passPhraseRadioBtn.Text = "Pass Phrase";
            passPhraseRadioBtn.UseVisualStyleBackColor = true;
            // 
            // passwordRadioBtn
            // 
            passwordRadioBtn.AutoSize = true;
            passwordRadioBtn.Location = new Point(6, 30);
            passwordRadioBtn.Name = "passwordRadioBtn";
            passwordRadioBtn.Size = new Size(112, 29);
            passwordRadioBtn.TabIndex = 3;
            passwordRadioBtn.TabStop = true;
            passwordRadioBtn.Text = "Password";
            passwordRadioBtn.UseVisualStyleBackColor = true;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(outputText);
            groupBoxOutput.ForeColor = Color.WhiteSmoke;
            groupBoxOutput.Location = new Point(12, 12);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(703, 70);
            groupBoxOutput.TabIndex = 3;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Output";
            // 
            // outputText
            // 
            outputText.BackColor = Color.Black;
            outputText.ForeColor = Color.Gold;
            outputText.Location = new Point(6, 30);
            outputText.Name = "outputText";
            outputText.ReadOnly = true;
            outputText.Size = new Size(691, 31);
            outputText.TabIndex = 0;
            // 
            // Password_Generator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(726, 523);
            Controls.Add(generatePass);
            Controls.Add(groupBoxOutput);
            Controls.Add(typeBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Password_Generator";
            Text = "Password Generator";
            passphraseBox.ResumeLayout(false);
            passphraseBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)wordAmountCounter).EndInit();
            typeBox.ResumeLayout(false);
            typeBox.PerformLayout();
            passPhraseOptionsBox.ResumeLayout(false);
            passPhraseOptionsBox.PerformLayout();
            passwordOptionsBox.ResumeLayout(false);
            passwordOptionsBox.PerformLayout();
            passwordOptions.ResumeLayout(false);
            passwordOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)passLenNumeric).EndInit();
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private GroupBox passphraseBox;
        private Label wordAmountLbl;
        private NumericUpDown wordAmountCounter;
        private GroupBox typeBox;
        private RadioButton passwordRadioBtn;
        private RadioButton passPhraseRadioBtn;
        private GroupBox groupBoxOutput;
        private Button generatePass;
        private TextBox outputText;
        private GroupBox passwordOptionsBox;
        private GroupBox passwordOptions;
        private CheckBox passSpecialChars;
        private CheckBox passLowerCase;
        private CheckBox passNumericChars;
        private CheckBox passCapitalLetters;
        private Label passLenLbl;
        private NumericUpDown passLenNumeric;
        private GroupBox passPhraseOptionsBox;
        private CheckBox capitalLetters;
        private CheckBox includeNumbers;
        private Label label1;
        private ComboBox delimiterBox;
    }
}