namespace KlinikaWeterynaryjna
{
    partial class MainForm
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
            zwierzetaGrid = new DataGridView();
            label1 = new Label();
            dodajButton = new Button();
            edytujButton = new Button();
            usunButton = new Button();
            ((System.ComponentModel.ISupportInitialize)zwierzetaGrid).BeginInit();
            SuspendLayout();
            // 
            // zwierzetaGrid
            // 
            zwierzetaGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            zwierzetaGrid.Location = new Point(12, 84);
            zwierzetaGrid.Name = "zwierzetaGrid";
            zwierzetaGrid.RowHeadersWidth = 51;
            zwierzetaGrid.RowTemplate.Height = 29;
            zwierzetaGrid.Size = new Size(1107, 317);
            zwierzetaGrid.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(559, 62);
            label1.TabIndex = 1;
            label1.Text = "Zwierzęta w bazie danych";
            // 
            // dodajButton
            // 
            dodajButton.Location = new Point(12, 407);
            dodajButton.Name = "dodajButton";
            dodajButton.Size = new Size(158, 59);
            dodajButton.TabIndex = 2;
            dodajButton.Text = "Dodaj";
            dodajButton.UseVisualStyleBackColor = true;
            // 
            // edytujButton
            // 
            edytujButton.Location = new Point(176, 407);
            edytujButton.Name = "edytujButton";
            edytujButton.Size = new Size(158, 59);
            edytujButton.TabIndex = 3;
            edytujButton.Text = "Edytuj";
            edytujButton.UseVisualStyleBackColor = true;
            // 
            // usunButton
            // 
            usunButton.Location = new Point(340, 407);
            usunButton.Name = "usunButton";
            usunButton.Size = new Size(158, 59);
            usunButton.TabIndex = 4;
            usunButton.Text = "Usuń";
            usunButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 495);
            Controls.Add(usunButton);
            Controls.Add(edytujButton);
            Controls.Add(dodajButton);
            Controls.Add(label1);
            Controls.Add(zwierzetaGrid);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)zwierzetaGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView zwierzetaGrid;
        private Label label1;
        private Button dodajButton;
        private Button edytujButton;
        private Button usunButton;
    }
}