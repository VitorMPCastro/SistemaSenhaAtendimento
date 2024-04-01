namespace SistemaSenhaAtendimento
{
    partial class FormSenhaAtendimento
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
            BTN_novaSenha = new Button();
            currentNumber = new Label();
            BTN_senhaPref = new Button();
            currentSenhaPref = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BTN_chamarSenha = new Button();
            fullQueue = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // BTN_novaSenha
            // 
            BTN_novaSenha.BackColor = Color.FromArgb(114, 137, 218);
            BTN_novaSenha.FlatAppearance.BorderColor = Color.DimGray;
            BTN_novaSenha.FlatStyle = FlatStyle.Popup;
            BTN_novaSenha.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            BTN_novaSenha.ForeColor = Color.White;
            BTN_novaSenha.Location = new Point(251, 286);
            BTN_novaSenha.Name = "BTN_novaSenha";
            BTN_novaSenha.Size = new Size(120, 30);
            BTN_novaSenha.TabIndex = 5;
            BTN_novaSenha.Text = "Nova Senha";
            BTN_novaSenha.UseVisualStyleBackColor = false;
            BTN_novaSenha.Click += BTN_novaSenha_Click;
            // 
            // currentNumber
            // 
            currentNumber.AutoSize = true;
            currentNumber.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            currentNumber.ForeColor = SystemColors.ControlLight;
            currentNumber.Location = new Point(298, 195);
            currentNumber.Name = "currentNumber";
            currentNumber.RightToLeft = RightToLeft.No;
            currentNumber.Size = new Size(31, 19);
            currentNumber.TabIndex = 6;
            currentNumber.Text = "XX";
            currentNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BTN_senhaPref
            // 
            BTN_senhaPref.BackColor = Color.FromArgb(114, 137, 218);
            BTN_senhaPref.FlatAppearance.BorderColor = Color.DimGray;
            BTN_senhaPref.FlatStyle = FlatStyle.Popup;
            BTN_senhaPref.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            BTN_senhaPref.ForeColor = Color.White;
            BTN_senhaPref.Location = new Point(419, 286);
            BTN_senhaPref.Name = "BTN_senhaPref";
            BTN_senhaPref.Size = new Size(120, 30);
            BTN_senhaPref.TabIndex = 5;
            BTN_senhaPref.Text = "Nova Senha";
            BTN_senhaPref.UseVisualStyleBackColor = false;
            BTN_senhaPref.Click += BTN_senhaPref_Click;
            // 
            // currentSenhaPref
            // 
            currentSenhaPref.AutoSize = true;
            currentSenhaPref.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            currentSenhaPref.ForeColor = SystemColors.ControlLight;
            currentSenhaPref.Location = new Point(466, 195);
            currentSenhaPref.Name = "currentSenhaPref";
            currentSenhaPref.RightToLeft = RightToLeft.No;
            currentSenhaPref.Size = new Size(31, 19);
            currentSenhaPref.TabIndex = 6;
            currentSenhaPref.Text = "XX";
            currentSenhaPref.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(262, 162);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(98, 19);
            label1.TabIndex = 6;
            label1.Text = "Fila Normal";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(413, 162);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(132, 19);
            label2.TabIndex = 6;
            label2.Text = "Fila Preferencial";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(347, 33);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(88, 19);
            label3.TabIndex = 6;
            label3.Text = "Senha: XX";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BTN_chamarSenha
            // 
            BTN_chamarSenha.BackColor = Color.FromArgb(114, 137, 218);
            BTN_chamarSenha.FlatAppearance.BorderColor = Color.DimGray;
            BTN_chamarSenha.FlatStyle = FlatStyle.Popup;
            BTN_chamarSenha.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            BTN_chamarSenha.ForeColor = Color.White;
            BTN_chamarSenha.Location = new Point(331, 74);
            BTN_chamarSenha.Name = "BTN_chamarSenha";
            BTN_chamarSenha.Size = new Size(120, 30);
            BTN_chamarSenha.TabIndex = 5;
            BTN_chamarSenha.Text = "Chamar Senha";
            BTN_chamarSenha.UseVisualStyleBackColor = false;
            BTN_chamarSenha.Click += BTN_chamarSenha_Click;
            // 
            // fullQueue
            // 
            fullQueue.AutoSize = true;
            fullQueue.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fullQueue.ForeColor = SystemColors.ControlLight;
            fullQueue.Location = new Point(347, 397);
            fullQueue.Name = "fullQueue";
            fullQueue.RightToLeft = RightToLeft.No;
            fullQueue.Size = new Size(84, 19);
            fullQueue.TabIndex = 6;
            fullQueue.Text = "Fila Vazia";
            fullQueue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(114, 137, 218);
            button1.FlatAppearance.BorderColor = Color.DimGray;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(668, 408);
            button1.Name = "button1";
            button1.Size = new Size(120, 30);
            button1.TabIndex = 5;
            button1.Text = "Clear Queue";
            button1.UseVisualStyleBackColor = false;
            button1.Click += BTN_clearQueue_Click;
            // 
            // FormSenhaAtendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 39, 42);
            ClientSize = new Size(800, 450);
            Controls.Add(currentSenhaPref);
            Controls.Add(fullQueue);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(currentNumber);
            Controls.Add(BTN_chamarSenha);
            Controls.Add(button1);
            Controls.Add(BTN_senhaPref);
            Controls.Add(BTN_novaSenha);
            Name = "FormSenhaAtendimento";
            Text = "FormSenhaAtendimento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTN_novaSenha;
        private Label currentNumber;
        private Button BTN_senhaPref;
        private Label currentSenhaPref;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button BTN_chamarSenha;
        private Label fullQueue;
        private Button button1;
    }
}
