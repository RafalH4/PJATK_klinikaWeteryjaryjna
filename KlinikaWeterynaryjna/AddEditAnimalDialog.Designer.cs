namespace KlinikaWeterynaryjna
{
    partial class AddEditAnimalDialog
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
            animalInfo = new Label();
            nazwaLabel = new Label();
            gatunekLabel = new Label();
            dataOstWizytyLabel = new Label();
            wlascicielLabel = new Label();
            nazwaTextBox = new TextBox();
            dataOstWIzytyDatePicker = new DateTimePicker();
            wlascicieleComboBox = new ComboBox();
            okButton = new Button();
            anulujButton = new Button();
            gatunekComboBox = new ComboBox();
            SuspendLayout();
            // 
            // animalInfo
            // 
            animalInfo.AutoSize = true;
            animalInfo.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            animalInfo.Location = new Point(12, 9);
            animalInfo.Name = "animalInfo";
            animalInfo.Size = new Size(191, 38);
            animalInfo.TabIndex = 0;
            animalInfo.Text = "Dodaj zwierzę";
            // 
            // nazwaLabel
            // 
            nazwaLabel.AutoSize = true;
            nazwaLabel.Location = new Point(22, 72);
            nazwaLabel.Name = "nazwaLabel";
            nazwaLabel.Size = new Size(54, 20);
            nazwaLabel.TabIndex = 1;
            nazwaLabel.Text = "Nazwa";
            // 
            // gatunekLabel
            // 
            gatunekLabel.AutoSize = true;
            gatunekLabel.Location = new Point(22, 108);
            gatunekLabel.Name = "gatunekLabel";
            gatunekLabel.Size = new Size(63, 20);
            gatunekLabel.TabIndex = 2;
            gatunekLabel.Text = "Gatunek";
            // 
            // dataOstWizytyLabel
            // 
            dataOstWizytyLabel.AutoSize = true;
            dataOstWizytyLabel.Location = new Point(22, 148);
            dataOstWizytyLabel.Name = "dataOstWizytyLabel";
            dataOstWizytyLabel.Size = new Size(110, 20);
            dataOstWizytyLabel.TabIndex = 3;
            dataOstWizytyLabel.Text = "Data ost wizyty";
            // 
            // wlascicielLabel
            // 
            wlascicielLabel.AutoSize = true;
            wlascicielLabel.Location = new Point(22, 187);
            wlascicielLabel.Name = "wlascicielLabel";
            wlascicielLabel.Size = new Size(75, 20);
            wlascicielLabel.TabIndex = 4;
            wlascicielLabel.Text = "Właściciel";
            // 
            // nazwaTextBox
            // 
            nazwaTextBox.Location = new Point(152, 72);
            nazwaTextBox.Name = "nazwaTextBox";
            nazwaTextBox.Size = new Size(250, 27);
            nazwaTextBox.TabIndex = 5;
            // 
            // dataOstWIzytyDatePicker
            // 
            dataOstWIzytyDatePicker.Location = new Point(152, 148);
            dataOstWIzytyDatePicker.Name = "dataOstWIzytyDatePicker";
            dataOstWIzytyDatePicker.Size = new Size(250, 27);
            dataOstWIzytyDatePicker.TabIndex = 7;
            // 
            // wlascicieleComboBox
            // 
            wlascicieleComboBox.FormattingEnabled = true;
            wlascicieleComboBox.Location = new Point(152, 187);
            wlascicieleComboBox.Name = "wlascicieleComboBox";
            wlascicieleComboBox.Size = new Size(250, 28);
            wlascicieleComboBox.TabIndex = 8;
            // 
            // okButton
            // 
            okButton.Location = new Point(172, 234);
            okButton.Name = "okButton";
            okButton.Size = new Size(110, 45);
            okButton.TabIndex = 9;
            okButton.Text = "Ok";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // anulujButton
            // 
            anulujButton.Location = new Point(288, 234);
            anulujButton.Name = "anulujButton";
            anulujButton.Size = new Size(114, 45);
            anulujButton.TabIndex = 10;
            anulujButton.Text = "Anuluj";
            anulujButton.UseVisualStyleBackColor = true;
            anulujButton.Click += anulujButton_Click;
            // 
            // gatunekComboBox
            // 
            gatunekComboBox.FormattingEnabled = true;
            gatunekComboBox.Items.AddRange(new object[] { "Pies", "Kot", "Lew", "Tygrys", "Słoń", "Żyrafa", "Koń", "Niedźwiedź", "Wieloryb", "Orka", "Pingwin" });
            gatunekComboBox.Location = new Point(152, 108);
            gatunekComboBox.Name = "gatunekComboBox";
            gatunekComboBox.Size = new Size(250, 28);
            gatunekComboBox.TabIndex = 11;
            // 
            // AddEditAnimalDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 303);
            Controls.Add(gatunekComboBox);
            Controls.Add(anulujButton);
            Controls.Add(okButton);
            Controls.Add(wlascicieleComboBox);
            Controls.Add(dataOstWIzytyDatePicker);
            Controls.Add(nazwaTextBox);
            Controls.Add(wlascicielLabel);
            Controls.Add(dataOstWizytyLabel);
            Controls.Add(gatunekLabel);
            Controls.Add(nazwaLabel);
            Controls.Add(animalInfo);
            Name = "AddEditAnimalDialog";
            Text = "AddEditAnimalDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label animalInfo;
        private Label nazwaLabel;
        private Label gatunekLabel;
        private Label dataOstWizytyLabel;
        private Label wlascicielLabel;
        private TextBox nazwaTextBox;
        private DateTimePicker dataOstWIzytyDatePicker;
        private ComboBox wlascicieleComboBox;
        private Button okButton;
        private Button anulujButton;
        private ComboBox gatunekComboBox;
    }
}