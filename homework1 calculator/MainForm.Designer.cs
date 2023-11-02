namespace homework1_calculator
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
            ButtonPanel = new TableLayoutPanel();
            ResultButton = new Button();
            FloatButton = new Button();
            Button0 = new Button();
            PlusMinusButton = new Button();
            PlusButton = new Button();
            Button3 = new Button();
            Button2 = new Button();
            Button1 = new Button();
            MinusButton = new Button();
            Button6 = new Button();
            Button5 = new Button();
            Button4 = new Button();
            MultiplyButtton = new Button();
            Button9 = new Button();
            Button8 = new Button();
            Button7 = new Button();
            DevideButton = new Button();
            SquareRootButton = new Button();
            XSquaredButton = new Button();
            OneByXButton = new Button();
            DeleteButton = new Button();
            CButton = new Button();
            CEButton = new Button();
            PercentButton = new Button();
            TextPanel = new Panel();
            ExpressionTextBox = new TextBox();
            NumbersTextBox = new TextBox();
            ButtonPanel.SuspendLayout();
            TextPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonPanel
            // 
            ButtonPanel.BackColor = SystemColors.GrayText;
            ButtonPanel.ColumnCount = 4;
            ButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ButtonPanel.Controls.Add(ResultButton, 3, 5);
            ButtonPanel.Controls.Add(FloatButton, 2, 5);
            ButtonPanel.Controls.Add(Button0, 1, 5);
            ButtonPanel.Controls.Add(PlusMinusButton, 0, 5);
            ButtonPanel.Controls.Add(PlusButton, 3, 4);
            ButtonPanel.Controls.Add(Button3, 2, 4);
            ButtonPanel.Controls.Add(Button2, 1, 4);
            ButtonPanel.Controls.Add(Button1, 0, 4);
            ButtonPanel.Controls.Add(MinusButton, 3, 3);
            ButtonPanel.Controls.Add(Button6, 2, 3);
            ButtonPanel.Controls.Add(Button5, 1, 3);
            ButtonPanel.Controls.Add(Button4, 0, 3);
            ButtonPanel.Controls.Add(MultiplyButtton, 3, 2);
            ButtonPanel.Controls.Add(Button9, 2, 2);
            ButtonPanel.Controls.Add(Button8, 1, 2);
            ButtonPanel.Controls.Add(Button7, 0, 2);
            ButtonPanel.Controls.Add(DevideButton, 3, 1);
            ButtonPanel.Controls.Add(SquareRootButton, 2, 1);
            ButtonPanel.Controls.Add(XSquaredButton, 1, 1);
            ButtonPanel.Controls.Add(OneByXButton, 0, 1);
            ButtonPanel.Controls.Add(DeleteButton, 3, 0);
            ButtonPanel.Controls.Add(CButton, 2, 0);
            ButtonPanel.Controls.Add(CEButton, 1, 0);
            ButtonPanel.Controls.Add(PercentButton, 0, 0);
            ButtonPanel.Dock = DockStyle.Bottom;
            ButtonPanel.Location = new Point(0, 107);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.RowCount = 6;
            ButtonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            ButtonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            ButtonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            ButtonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            ButtonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            ButtonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            ButtonPanel.Size = new Size(378, 321);
            ButtonPanel.TabIndex = 0;
            // 
            // ResultButton
            // 
            ResultButton.BackColor = SystemColors.ButtonHighlight;
            ResultButton.Dock = DockStyle.Fill;
            ResultButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ResultButton.Location = new Point(285, 268);
            ResultButton.Name = "ResultButton";
            ResultButton.Size = new Size(90, 50);
            ResultButton.TabIndex = 23;
            ResultButton.Text = "=";
            ResultButton.UseVisualStyleBackColor = false;
            ResultButton.Click += ResultButton_Click;
            // 
            // FloatButton
            // 
            FloatButton.BackColor = SystemColors.GradientInactiveCaption;
            FloatButton.Dock = DockStyle.Fill;
            FloatButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            FloatButton.Location = new Point(191, 268);
            FloatButton.Name = "FloatButton";
            FloatButton.Size = new Size(88, 50);
            FloatButton.TabIndex = 22;
            FloatButton.Text = ",";
            FloatButton.UseVisualStyleBackColor = false;
            FloatButton.Click += FloatButton_Click;
            // 
            // Button0
            // 
            Button0.BackColor = SystemColors.GradientInactiveCaption;
            Button0.Dock = DockStyle.Fill;
            Button0.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Button0.Location = new Point(97, 268);
            Button0.Name = "Button0";
            Button0.Size = new Size(88, 50);
            Button0.TabIndex = 21;
            Button0.Text = "0";
            Button0.UseVisualStyleBackColor = false;
            Button0.Click += Button1_Click;
            // 
            // PlusMinusButton
            // 
            PlusMinusButton.BackColor = SystemColors.GradientInactiveCaption;
            PlusMinusButton.Dock = DockStyle.Fill;
            PlusMinusButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            PlusMinusButton.Location = new Point(3, 268);
            PlusMinusButton.Name = "PlusMinusButton";
            PlusMinusButton.Size = new Size(88, 50);
            PlusMinusButton.TabIndex = 20;
            PlusMinusButton.Text = "±";
            PlusMinusButton.UseVisualStyleBackColor = false;
            PlusMinusButton.Click += PlusMinusButton_Click;
            // 
            // PlusButton
            // 
            PlusButton.BackColor = SystemColors.ButtonHighlight;
            PlusButton.Dock = DockStyle.Fill;
            PlusButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            PlusButton.Location = new Point(285, 215);
            PlusButton.Name = "PlusButton";
            PlusButton.Size = new Size(90, 47);
            PlusButton.TabIndex = 19;
            PlusButton.Text = "+";
            PlusButton.UseVisualStyleBackColor = false;
            PlusButton.Click += OperationButton_Click;
            // 
            // Button3
            // 
            Button3.BackColor = SystemColors.GradientInactiveCaption;
            Button3.Dock = DockStyle.Fill;
            Button3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Button3.Location = new Point(191, 215);
            Button3.Name = "Button3";
            Button3.Size = new Size(88, 47);
            Button3.TabIndex = 18;
            Button3.Text = "3";
            Button3.UseVisualStyleBackColor = false;
            Button3.Click += Button1_Click;
            // 
            // Button2
            // 
            Button2.BackColor = SystemColors.GradientInactiveCaption;
            Button2.Dock = DockStyle.Fill;
            Button2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Button2.Location = new Point(97, 215);
            Button2.Name = "Button2";
            Button2.Size = new Size(88, 47);
            Button2.TabIndex = 17;
            Button2.Text = "2";
            Button2.UseVisualStyleBackColor = false;
            Button2.Click += Button1_Click;
            // 
            // Button1
            // 
            Button1.BackColor = SystemColors.GradientInactiveCaption;
            Button1.Dock = DockStyle.Fill;
            Button1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Button1.Location = new Point(3, 215);
            Button1.Name = "Button1";
            Button1.Size = new Size(88, 47);
            Button1.TabIndex = 16;
            Button1.Text = "1";
            Button1.UseVisualStyleBackColor = false;
            Button1.Click += Button1_Click;
            // 
            // MinusButton
            // 
            MinusButton.BackColor = SystemColors.ButtonHighlight;
            MinusButton.Dock = DockStyle.Fill;
            MinusButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            MinusButton.Location = new Point(285, 162);
            MinusButton.Name = "MinusButton";
            MinusButton.Size = new Size(90, 47);
            MinusButton.TabIndex = 15;
            MinusButton.Text = "-";
            MinusButton.UseVisualStyleBackColor = false;
            MinusButton.Click += OperationButton_Click;
            // 
            // Button6
            // 
            Button6.BackColor = SystemColors.GradientInactiveCaption;
            Button6.Dock = DockStyle.Fill;
            Button6.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Button6.Location = new Point(191, 162);
            Button6.Name = "Button6";
            Button6.Size = new Size(88, 47);
            Button6.TabIndex = 14;
            Button6.Text = "6";
            Button6.UseVisualStyleBackColor = false;
            Button6.Click += Button1_Click;
            // 
            // Button5
            // 
            Button5.BackColor = SystemColors.GradientInactiveCaption;
            Button5.Dock = DockStyle.Fill;
            Button5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Button5.Location = new Point(97, 162);
            Button5.Name = "Button5";
            Button5.Size = new Size(88, 47);
            Button5.TabIndex = 13;
            Button5.Text = "5";
            Button5.UseVisualStyleBackColor = false;
            Button5.Click += Button1_Click;
            // 
            // Button4
            // 
            Button4.BackColor = SystemColors.GradientInactiveCaption;
            Button4.Dock = DockStyle.Fill;
            Button4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Button4.Location = new Point(3, 162);
            Button4.Name = "Button4";
            Button4.Size = new Size(88, 47);
            Button4.TabIndex = 12;
            Button4.Text = "4";
            Button4.UseVisualStyleBackColor = false;
            Button4.Click += Button1_Click;
            // 
            // MultiplyButtton
            // 
            MultiplyButtton.BackColor = SystemColors.ButtonHighlight;
            MultiplyButtton.Dock = DockStyle.Fill;
            MultiplyButtton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            MultiplyButtton.Location = new Point(285, 109);
            MultiplyButtton.Name = "MultiplyButtton";
            MultiplyButtton.Size = new Size(90, 47);
            MultiplyButtton.TabIndex = 11;
            MultiplyButtton.Text = "×";
            MultiplyButtton.UseVisualStyleBackColor = false;
            MultiplyButtton.Click += OperationButton_Click;
            // 
            // Button9
            // 
            Button9.BackColor = SystemColors.GradientInactiveCaption;
            Button9.Dock = DockStyle.Fill;
            Button9.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Button9.Location = new Point(191, 109);
            Button9.Name = "Button9";
            Button9.Size = new Size(88, 47);
            Button9.TabIndex = 10;
            Button9.Text = "9";
            Button9.UseVisualStyleBackColor = false;
            Button9.Click += Button1_Click;
            // 
            // Button8
            // 
            Button8.BackColor = SystemColors.GradientInactiveCaption;
            Button8.Dock = DockStyle.Fill;
            Button8.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Button8.Location = new Point(97, 109);
            Button8.Name = "Button8";
            Button8.Size = new Size(88, 47);
            Button8.TabIndex = 9;
            Button8.Text = "8";
            Button8.UseVisualStyleBackColor = false;
            Button8.Click += Button1_Click;
            // 
            // Button7
            // 
            Button7.BackColor = SystemColors.GradientInactiveCaption;
            Button7.Dock = DockStyle.Fill;
            Button7.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Button7.Location = new Point(3, 109);
            Button7.Name = "Button7";
            Button7.Size = new Size(88, 47);
            Button7.TabIndex = 8;
            Button7.Text = "7";
            Button7.UseVisualStyleBackColor = false;
            Button7.Click += Button1_Click;
            // 
            // DevideButton
            // 
            DevideButton.BackColor = SystemColors.ButtonHighlight;
            DevideButton.Dock = DockStyle.Fill;
            DevideButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            DevideButton.Location = new Point(285, 56);
            DevideButton.Name = "DevideButton";
            DevideButton.Size = new Size(90, 47);
            DevideButton.TabIndex = 7;
            DevideButton.Text = "÷";
            DevideButton.UseVisualStyleBackColor = false;
            DevideButton.Click += OperationButton_Click;
            // 
            // SquareRootButton
            // 
            SquareRootButton.BackColor = SystemColors.ButtonHighlight;
            SquareRootButton.Dock = DockStyle.Fill;
            SquareRootButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            SquareRootButton.Location = new Point(191, 56);
            SquareRootButton.Name = "SquareRootButton";
            SquareRootButton.Size = new Size(88, 47);
            SquareRootButton.TabIndex = 6;
            SquareRootButton.Text = "√";
            SquareRootButton.UseVisualStyleBackColor = false;
            SquareRootButton.Click += SquareRootButton_Click;
            // 
            // XSquaredButton
            // 
            XSquaredButton.BackColor = SystemColors.ButtonHighlight;
            XSquaredButton.Dock = DockStyle.Fill;
            XSquaredButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            XSquaredButton.Location = new Point(97, 56);
            XSquaredButton.Name = "XSquaredButton";
            XSquaredButton.Size = new Size(88, 47);
            XSquaredButton.TabIndex = 5;
            XSquaredButton.Text = "x²";
            XSquaredButton.UseVisualStyleBackColor = false;
            XSquaredButton.Click += XSquaredButton_Click;
            // 
            // OneByXButton
            // 
            OneByXButton.BackColor = SystemColors.ButtonHighlight;
            OneByXButton.Dock = DockStyle.Fill;
            OneByXButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            OneByXButton.Location = new Point(3, 56);
            OneByXButton.Name = "OneByXButton";
            OneByXButton.Size = new Size(88, 47);
            OneByXButton.TabIndex = 4;
            OneByXButton.Text = "1/x";
            OneByXButton.UseVisualStyleBackColor = false;
            OneByXButton.Click += OneByXButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = SystemColors.ButtonHighlight;
            DeleteButton.Dock = DockStyle.Fill;
            DeleteButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteButton.Location = new Point(285, 3);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(90, 47);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "⌫";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // CButton
            // 
            CButton.BackColor = SystemColors.ButtonHighlight;
            CButton.Dock = DockStyle.Fill;
            CButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            CButton.Location = new Point(191, 3);
            CButton.Name = "CButton";
            CButton.Size = new Size(88, 47);
            CButton.TabIndex = 2;
            CButton.Text = "C";
            CButton.UseVisualStyleBackColor = false;
            CButton.Click += CButton_Click;
            // 
            // CEButton
            // 
            CEButton.BackColor = SystemColors.ButtonHighlight;
            CEButton.Dock = DockStyle.Fill;
            CEButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            CEButton.Location = new Point(97, 3);
            CEButton.Name = "CEButton";
            CEButton.Size = new Size(88, 47);
            CEButton.TabIndex = 1;
            CEButton.Text = "CE";
            CEButton.UseVisualStyleBackColor = false;
            CEButton.Click += CEButton_Click;
            // 
            // PercentButton
            // 
            PercentButton.BackColor = SystemColors.ButtonHighlight;
            PercentButton.Dock = DockStyle.Fill;
            PercentButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            PercentButton.Location = new Point(3, 3);
            PercentButton.Name = "PercentButton";
            PercentButton.Size = new Size(88, 47);
            PercentButton.TabIndex = 0;
            PercentButton.Text = "%";
            PercentButton.UseVisualStyleBackColor = false;
            PercentButton.Click += OperationButton_Click;
            // 
            // TextPanel
            // 
            TextPanel.BackColor = SystemColors.GrayText;
            TextPanel.Controls.Add(ExpressionTextBox);
            TextPanel.Controls.Add(NumbersTextBox);
            TextPanel.Dock = DockStyle.Fill;
            TextPanel.Location = new Point(0, 0);
            TextPanel.Name = "TextPanel";
            TextPanel.Size = new Size(378, 107);
            TextPanel.TabIndex = 1;
            // 
            // ExpressionTextBox
            // 
            ExpressionTextBox.BackColor = SystemColors.Info;
            ExpressionTextBox.Dock = DockStyle.Bottom;
            ExpressionTextBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ExpressionTextBox.Location = new Point(0, 73);
            ExpressionTextBox.Name = "ExpressionTextBox";
            ExpressionTextBox.ReadOnly = true;
            ExpressionTextBox.Size = new Size(378, 34);
            ExpressionTextBox.TabIndex = 1;
            ExpressionTextBox.Text = "0";
            // 
            // NumbersTextBox
            // 
            NumbersTextBox.BackColor = SystemColors.ButtonHighlight;
            NumbersTextBox.Dock = DockStyle.Fill;
            NumbersTextBox.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            NumbersTextBox.Location = new Point(0, 0);
            NumbersTextBox.Name = "NumbersTextBox";
            NumbersTextBox.ReadOnly = true;
            NumbersTextBox.Size = new Size(378, 70);
            NumbersTextBox.TabIndex = 0;
            NumbersTextBox.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 428);
            Controls.Add(TextPanel);
            Controls.Add(ButtonPanel);
            Name = "MainForm";
            Text = "MainForm";
            ButtonPanel.ResumeLayout(false);
            TextPanel.ResumeLayout(false);
            TextPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel ButtonPanel;
        private Button ResultButton;
        private Button FloatButton;
        private Button Button0;
        private Button PlusMinusButton;
        private Button PlusButton;
        private Button Button3;
        private Button Button2;
        private Button Button1;
        private Button MinusButton;
        private Button Button6;
        private Button Button5;
        private Button Button4;
        private Button MultiplyButtton;
        private Button Button9;
        private Button Button8;
        private Button Button7;
        private Button DevideButton;
        private Button SquareRootButton;
        private Button XSquaredButton;
        private Button OneByXButton;
        private Button DeleteButton;
        private Button CButton;
        private Button CEButton;
        private Button PercentButton;
        private Panel TextPanel;
        private TextBox NumbersTextBox;
        private TextBox ExpressionTextBox;
    }
}