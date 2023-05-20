namespace KlinikaWeterynaryjna
{
    partial class LoginForm
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
            loginLabel = new Label();
            hasloLabel = new Label();
            loginTextBox = new TextBox();
            hasloTextBox = new TextBox();
            loginButton = new Button();
            anulujButton = new Button();
            SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new Point(12, 42);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(49, 20);
            loginLabel.TabIndex = 0;
            loginLabel.Text = "Login:";
            // 
            // hasloLabel
            // 
            hasloLabel.AutoSize = true;
            hasloLabel.Location = new Point(11, 82);
            hasloLabel.Name = "hasloLabel";
            hasloLabel.Size = new Size(50, 20);
            hasloLabel.TabIndex = 1;
            hasloLabel.Text = "Haslo:";
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(82, 42);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(215, 27);
            loginTextBox.TabIndex = 2;
            loginTextBox.Text = "Login";
            // 
            // hasloTextBox
            // 
            hasloTextBox.Location = new Point(82, 82);
            hasloTextBox.Name = "hasloTextBox";
            hasloTextBox.Size = new Size(215, 27);
            hasloTextBox.TabIndex = 3;
            hasloTextBox.Text = "Haslo";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(44, 132);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(81, 29);
            loginButton.TabIndex = 4;
            loginButton.Text = "Ok";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // anulujButton
            // 
            anulujButton.Location = new Point(181, 132);
            anulujButton.Name = "anulujButton";
            anulujButton.Size = new Size(94, 29);
            anulujButton.TabIndex = 5;
            anulujButton.Text = "Anuluj";
            anulujButton.UseVisualStyleBackColor = true;
            anulujButton.Click += anulujButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 225);
            Controls.Add(anulujButton);
            Controls.Add(loginButton);
            Controls.Add(hasloTextBox);
            Controls.Add(loginTextBox);
            Controls.Add(hasloLabel);
            Controls.Add(loginLabel);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginLabel;
        private Label hasloLabel;
        private TextBox loginTextBox;
        private TextBox hasloTextBox;
        private Button loginButton;
        private Button anulujButton;
    }
}