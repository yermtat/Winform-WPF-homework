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
            this.ButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ResultButton = new System.Windows.Forms.Button();
            this.FloatButton = new System.Windows.Forms.Button();
            this.Button0 = new System.Windows.Forms.Button();
            this.PlusMinusButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.MultiplyButtton = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.DevideButton = new System.Windows.Forms.Button();
            this.SquareRootButton = new System.Windows.Forms.Button();
            this.XSquaredButton = new System.Windows.Forms.Button();
            this.OneByXButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.CEButton = new System.Windows.Forms.Button();
            this.PercentButton = new System.Windows.Forms.Button();
            this.TextPanel = new System.Windows.Forms.Panel();
            this.ExpressionTextBox = new System.Windows.Forms.TextBox();
            this.NumbersTextBox = new System.Windows.Forms.TextBox();
            this.ButtonPanel.SuspendLayout();
            this.TextPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.ButtonPanel.ColumnCount = 4;
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonPanel.Controls.Add(this.ResultButton, 3, 5);
            this.ButtonPanel.Controls.Add(this.FloatButton, 2, 5);
            this.ButtonPanel.Controls.Add(this.Button0, 1, 5);
            this.ButtonPanel.Controls.Add(this.PlusMinusButton, 0, 5);
            this.ButtonPanel.Controls.Add(this.PlusButton, 3, 4);
            this.ButtonPanel.Controls.Add(this.Button3, 2, 4);
            this.ButtonPanel.Controls.Add(this.Button2, 1, 4);
            this.ButtonPanel.Controls.Add(this.Button1, 0, 4);
            this.ButtonPanel.Controls.Add(this.MinusButton, 3, 3);
            this.ButtonPanel.Controls.Add(this.Button6, 2, 3);
            this.ButtonPanel.Controls.Add(this.Button5, 1, 3);
            this.ButtonPanel.Controls.Add(this.Button4, 0, 3);
            this.ButtonPanel.Controls.Add(this.MultiplyButtton, 3, 2);
            this.ButtonPanel.Controls.Add(this.Button9, 2, 2);
            this.ButtonPanel.Controls.Add(this.Button8, 1, 2);
            this.ButtonPanel.Controls.Add(this.Button7, 0, 2);
            this.ButtonPanel.Controls.Add(this.DevideButton, 3, 1);
            this.ButtonPanel.Controls.Add(this.SquareRootButton, 2, 1);
            this.ButtonPanel.Controls.Add(this.XSquaredButton, 1, 1);
            this.ButtonPanel.Controls.Add(this.OneByXButton, 0, 1);
            this.ButtonPanel.Controls.Add(this.DeleteButton, 3, 0);
            this.ButtonPanel.Controls.Add(this.CButton, 2, 0);
            this.ButtonPanel.Controls.Add(this.CEButton, 1, 0);
            this.ButtonPanel.Controls.Add(this.PercentButton, 0, 0);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 107);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.RowCount = 6;
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ButtonPanel.Size = new System.Drawing.Size(378, 321);
            this.ButtonPanel.TabIndex = 0;
            // 
            // ResultButton
            // 
            this.ResultButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ResultButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultButton.Location = new System.Drawing.Point(285, 268);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(90, 50);
            this.ResultButton.TabIndex = 23;
            this.ResultButton.Text = "=";
            this.ResultButton.UseVisualStyleBackColor = false;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // FloatButton
            // 
            this.FloatButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.FloatButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FloatButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FloatButton.Location = new System.Drawing.Point(191, 268);
            this.FloatButton.Name = "FloatButton";
            this.FloatButton.Size = new System.Drawing.Size(88, 50);
            this.FloatButton.TabIndex = 22;
            this.FloatButton.Text = ",";
            this.FloatButton.UseVisualStyleBackColor = false;
            this.FloatButton.Click += new System.EventHandler(this.FloatButton_Click);
            // 
            // Button0
            // 
            this.Button0.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Button0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button0.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button0.Location = new System.Drawing.Point(97, 268);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(88, 50);
            this.Button0.TabIndex = 21;
            this.Button0.Text = "0";
            this.Button0.UseVisualStyleBackColor = false;
            this.Button0.Click += new System.EventHandler(this.Button1_Click);
            // 
            // PlusMinusButton
            // 
            this.PlusMinusButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PlusMinusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlusMinusButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlusMinusButton.Location = new System.Drawing.Point(3, 268);
            this.PlusMinusButton.Name = "PlusMinusButton";
            this.PlusMinusButton.Size = new System.Drawing.Size(88, 50);
            this.PlusMinusButton.TabIndex = 20;
            this.PlusMinusButton.Text = "±";
            this.PlusMinusButton.UseVisualStyleBackColor = false;
            this.PlusMinusButton.Click += new System.EventHandler(this.PlusMinusButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PlusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlusButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlusButton.Location = new System.Drawing.Point(285, 215);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(90, 47);
            this.PlusButton.TabIndex = 19;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = false;
            this.PlusButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button3.Location = new System.Drawing.Point(191, 215);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(88, 47);
            this.Button3.TabIndex = 18;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button2.Location = new System.Drawing.Point(97, 215);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(88, 47);
            this.Button2.TabIndex = 17;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button1.Location = new System.Drawing.Point(3, 215);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(88, 47);
            this.Button1.TabIndex = 16;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MinusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinusButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinusButton.Location = new System.Drawing.Point(285, 162);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(90, 47);
            this.MinusButton.TabIndex = 15;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = false;
            this.MinusButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // Button6
            // 
            this.Button6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button6.Location = new System.Drawing.Point(191, 162);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(88, 47);
            this.Button6.TabIndex = 14;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = false;
            this.Button6.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button5.Location = new System.Drawing.Point(97, 162);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(88, 47);
            this.Button5.TabIndex = 13;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button4.Location = new System.Drawing.Point(3, 162);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(88, 47);
            this.Button4.TabIndex = 12;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MultiplyButtton
            // 
            this.MultiplyButtton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MultiplyButtton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MultiplyButtton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MultiplyButtton.Location = new System.Drawing.Point(285, 109);
            this.MultiplyButtton.Name = "MultiplyButtton";
            this.MultiplyButtton.Size = new System.Drawing.Size(90, 47);
            this.MultiplyButtton.TabIndex = 11;
            this.MultiplyButtton.Text = "×";
            this.MultiplyButtton.UseVisualStyleBackColor = false;
            this.MultiplyButtton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // Button9
            // 
            this.Button9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button9.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button9.Location = new System.Drawing.Point(191, 109);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(88, 47);
            this.Button9.TabIndex = 10;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = false;
            this.Button9.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button8
            // 
            this.Button8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button8.Location = new System.Drawing.Point(97, 109);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(88, 47);
            this.Button8.TabIndex = 9;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = false;
            this.Button8.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button7
            // 
            this.Button7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button7.Location = new System.Drawing.Point(3, 109);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(88, 47);
            this.Button7.TabIndex = 8;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = false;
            this.Button7.Click += new System.EventHandler(this.Button1_Click);
            // 
            // DevideButton
            // 
            this.DevideButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DevideButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DevideButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DevideButton.Location = new System.Drawing.Point(285, 56);
            this.DevideButton.Name = "DevideButton";
            this.DevideButton.Size = new System.Drawing.Size(90, 47);
            this.DevideButton.TabIndex = 7;
            this.DevideButton.Text = "÷";
            this.DevideButton.UseVisualStyleBackColor = false;
            this.DevideButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // SquareRootButton
            // 
            this.SquareRootButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SquareRootButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SquareRootButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SquareRootButton.Location = new System.Drawing.Point(191, 56);
            this.SquareRootButton.Name = "SquareRootButton";
            this.SquareRootButton.Size = new System.Drawing.Size(88, 47);
            this.SquareRootButton.TabIndex = 6;
            this.SquareRootButton.Text = "√";
            this.SquareRootButton.UseVisualStyleBackColor = false;
            this.SquareRootButton.Click += new System.EventHandler(this.SquareRootButton_Click);
            // 
            // XSquaredButton
            // 
            this.XSquaredButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.XSquaredButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XSquaredButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.XSquaredButton.Location = new System.Drawing.Point(97, 56);
            this.XSquaredButton.Name = "XSquaredButton";
            this.XSquaredButton.Size = new System.Drawing.Size(88, 47);
            this.XSquaredButton.TabIndex = 5;
            this.XSquaredButton.Text = "x²";
            this.XSquaredButton.UseVisualStyleBackColor = false;
            this.XSquaredButton.Click += new System.EventHandler(this.XSquaredButton_Click);
            // 
            // OneByXButton
            // 
            this.OneByXButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OneByXButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OneByXButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OneByXButton.Location = new System.Drawing.Point(3, 56);
            this.OneByXButton.Name = "OneByXButton";
            this.OneByXButton.Size = new System.Drawing.Size(88, 47);
            this.OneByXButton.TabIndex = 4;
            this.OneByXButton.Text = "1/x";
            this.OneByXButton.UseVisualStyleBackColor = false;
            this.OneByXButton.Click += new System.EventHandler(this.OneByXButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.Location = new System.Drawing.Point(285, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(90, 47);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "⌫";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CButton
            // 
            this.CButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CButton.Location = new System.Drawing.Point(191, 3);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(88, 47);
            this.CButton.TabIndex = 2;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = false;
            this.CButton.Click += new System.EventHandler(this.CButton_Click);
            // 
            // CEButton
            // 
            this.CEButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CEButton.Location = new System.Drawing.Point(97, 3);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(88, 47);
            this.CEButton.TabIndex = 1;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = false;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // PercentButton
            // 
            this.PercentButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PercentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PercentButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PercentButton.Location = new System.Drawing.Point(3, 3);
            this.PercentButton.Name = "PercentButton";
            this.PercentButton.Size = new System.Drawing.Size(88, 47);
            this.PercentButton.TabIndex = 0;
            this.PercentButton.Text = "%";
            this.PercentButton.UseVisualStyleBackColor = false;
            this.PercentButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // TextPanel
            // 
            this.TextPanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.TextPanel.Controls.Add(this.ExpressionTextBox);
            this.TextPanel.Controls.Add(this.NumbersTextBox);
            this.TextPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextPanel.Location = new System.Drawing.Point(0, 0);
            this.TextPanel.Name = "TextPanel";
            this.TextPanel.Size = new System.Drawing.Size(378, 107);
            this.TextPanel.TabIndex = 1;
            // 
            // ExpressionTextBox
            // 
            this.ExpressionTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.ExpressionTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExpressionTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExpressionTextBox.Location = new System.Drawing.Point(0, 73);
            this.ExpressionTextBox.Name = "ExpressionTextBox";
            this.ExpressionTextBox.ReadOnly = true;
            this.ExpressionTextBox.Size = new System.Drawing.Size(378, 34);
            this.ExpressionTextBox.TabIndex = 1;
            this.ExpressionTextBox.Text = "0";
            // 
            // NumbersTextBox
            // 
            this.NumbersTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NumbersTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumbersTextBox.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumbersTextBox.Location = new System.Drawing.Point(0, 0);
            this.NumbersTextBox.Name = "NumbersTextBox";
            this.NumbersTextBox.ReadOnly = true;
            this.NumbersTextBox.Size = new System.Drawing.Size(378, 70);
            this.NumbersTextBox.TabIndex = 0;
            this.NumbersTextBox.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 428);
            this.Controls.Add(this.TextPanel);
            this.Controls.Add(this.ButtonPanel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ButtonPanel.ResumeLayout(false);
            this.TextPanel.ResumeLayout(false);
            this.TextPanel.PerformLayout();
            this.ResumeLayout(false);

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