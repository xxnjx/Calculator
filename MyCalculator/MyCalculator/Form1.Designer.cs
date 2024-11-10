namespace MyCalculator
{
    partial class CalculatorForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDev = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonSetClear = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonNum3 = new System.Windows.Forms.Button();
            this.buttonNum2 = new System.Windows.Forms.Button();
            this.buttonNum1 = new System.Windows.Forms.Button();
            this.buttonNum4 = new System.Windows.Forms.Button();
            this.buttonNum5 = new System.Windows.Forms.Button();
            this.buttonNum6 = new System.Windows.Forms.Button();
            this.buttonNum7 = new System.Windows.Forms.Button();
            this.buttonNum8 = new System.Windows.Forms.Button();
            this.buttonNum9 = new System.Windows.Forms.Button();
            this.buttonNum0 = new System.Windows.Forms.Button();
            this.buttonSum = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputTextBox.Font = new System.Drawing.Font("굴림", 24F);
            this.inputTextBox.Location = new System.Drawing.Point(0, 0);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(652, 53);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.resultTextBox.Font = new System.Drawing.Font("굴림", 24F);
            this.resultTextBox.Location = new System.Drawing.Point(0, 53);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(652, 53);
            this.resultTextBox.TabIndex = 1;
            this.resultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.buttonDev, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonResult, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonSetClear, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonMul, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonSub, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonNum3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonNum2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonNum1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonNum4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonNum5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonNum6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonNum7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonNum8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonNum9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonNum0, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonSum, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 106);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(652, 505);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // buttonDev
            // 
            this.buttonDev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDev.Font = new System.Drawing.Font("굴림", 20F);
            this.buttonDev.Location = new System.Drawing.Point(492, 381);
            this.buttonDev.Name = "buttonDev";
            this.buttonDev.Size = new System.Drawing.Size(157, 121);
            this.buttonDev.TabIndex = 15;
            this.buttonDev.Text = "/";
            this.buttonDev.UseVisualStyleBackColor = true;
            this.buttonDev.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonResult.Font = new System.Drawing.Font("굴림", 20F);
            this.buttonResult.Location = new System.Drawing.Point(329, 381);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(157, 121);
            this.buttonResult.TabIndex = 14;
            this.buttonResult.Text = "=";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // buttonSetClear
            // 
            this.buttonSetClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSetClear.Font = new System.Drawing.Font("굴림", 20F);
            this.buttonSetClear.Location = new System.Drawing.Point(3, 381);
            this.buttonSetClear.Name = "buttonSetClear";
            this.buttonSetClear.Size = new System.Drawing.Size(157, 121);
            this.buttonSetClear.TabIndex = 13;
            this.buttonSetClear.Text = "C";
            this.buttonSetClear.UseVisualStyleBackColor = true;
            this.buttonSetClear.Click += new System.EventHandler(this.buttonSetClear_Click);
            // 
            // buttonMul
            // 
            this.buttonMul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMul.Font = new System.Drawing.Font("굴림", 20F);
            this.buttonMul.Location = new System.Drawing.Point(492, 255);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(157, 120);
            this.buttonMul.TabIndex = 12;
            this.buttonMul.Text = "*";
            this.buttonMul.UseVisualStyleBackColor = true;
            this.buttonMul.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSub.Font = new System.Drawing.Font("굴림", 20F);
            this.buttonSub.Location = new System.Drawing.Point(492, 129);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(157, 120);
            this.buttonSub.TabIndex = 11;
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonNum3
            // 
            this.buttonNum3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNum3.Font = new System.Drawing.Font("굴림", 20F);
            this.buttonNum3.Location = new System.Drawing.Point(329, 3);
            this.buttonNum3.Name = "buttonNum3";
            this.buttonNum3.Size = new System.Drawing.Size(157, 120);
            this.buttonNum3.TabIndex = 2;
            this.buttonNum3.Text = "3";
            this.buttonNum3.UseVisualStyleBackColor = true;
            this.buttonNum3.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonNum2
            // 
            this.buttonNum2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNum2.Font = new System.Drawing.Font("굴림", 20F);
            this.buttonNum2.Location = new System.Drawing.Point(166, 3);
            this.buttonNum2.Name = "buttonNum2";
            this.buttonNum2.Size = new System.Drawing.Size(157, 120);
            this.buttonNum2.TabIndex = 1;
            this.buttonNum2.Text = "2";
            this.buttonNum2.UseVisualStyleBackColor = true;
            this.buttonNum2.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonNum1
            // 
            this.buttonNum1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNum1.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonNum1.Location = new System.Drawing.Point(3, 3);
            this.buttonNum1.Name = "buttonNum1";
            this.buttonNum1.Size = new System.Drawing.Size(157, 120);
            this.buttonNum1.TabIndex = 0;
            this.buttonNum1.Text = "1";
            this.buttonNum1.UseVisualStyleBackColor = true;
            this.buttonNum1.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonNum4
            // 
            this.buttonNum4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNum4.Font = new System.Drawing.Font("굴림", 20F);
            this.buttonNum4.Location = new System.Drawing.Point(3, 129);
            this.buttonNum4.Name = "buttonNum4";
            this.buttonNum4.Size = new System.Drawing.Size(157, 120);
            this.buttonNum4.TabIndex = 3;
            this.buttonNum4.Text = "4";
            this.buttonNum4.UseVisualStyleBackColor = true;
            this.buttonNum4.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonNum5
            // 
            this.buttonNum5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNum5.Font = new System.Drawing.Font("굴림", 20F);
            this.buttonNum5.Location = new System.Drawing.Point(166, 129);
            this.buttonNum5.Name = "buttonNum5";
            this.buttonNum5.Size = new System.Drawing.Size(157, 120);
            this.buttonNum5.TabIndex = 4;
            this.buttonNum5.Text = "5";
            this.buttonNum5.UseVisualStyleBackColor = true;
            this.buttonNum5.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonNum6
            // 
            this.buttonNum6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNum6.Font = new System.Drawing.Font("굴림", 20F);
            this.buttonNum6.Location = new System.Drawing.Point(329, 129);
            this.buttonNum6.Name = "buttonNum6";
            this.buttonNum6.Size = new System.Drawing.Size(157, 120);
            this.buttonNum6.TabIndex = 5;
            this.buttonNum6.Text = "6";
            this.buttonNum6.UseVisualStyleBackColor = true;
            this.buttonNum6.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonNum7
            // 
            this.buttonNum7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNum7.Font = new System.Drawing.Font("굴림", 20F);
            this.buttonNum7.Location = new System.Drawing.Point(3, 255);
            this.buttonNum7.Name = "buttonNum7";
            this.buttonNum7.Size = new System.Drawing.Size(157, 120);
            this.buttonNum7.TabIndex = 6;
            this.buttonNum7.Text = "7";
            this.buttonNum7.UseVisualStyleBackColor = true;
            this.buttonNum7.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonNum8
            // 
            this.buttonNum8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNum8.Font = new System.Drawing.Font("굴림", 20F);
            this.buttonNum8.Location = new System.Drawing.Point(166, 255);
            this.buttonNum8.Name = "buttonNum8";
            this.buttonNum8.Size = new System.Drawing.Size(157, 120);
            this.buttonNum8.TabIndex = 7;
            this.buttonNum8.Text = "8";
            this.buttonNum8.UseVisualStyleBackColor = true;
            this.buttonNum8.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonNum9
            // 
            this.buttonNum9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNum9.Font = new System.Drawing.Font("굴림", 20F);
            this.buttonNum9.Location = new System.Drawing.Point(329, 255);
            this.buttonNum9.Name = "buttonNum9";
            this.buttonNum9.Size = new System.Drawing.Size(157, 120);
            this.buttonNum9.TabIndex = 8;
            this.buttonNum9.Text = "9";
            this.buttonNum9.UseVisualStyleBackColor = true;
            this.buttonNum9.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonNum0
            // 
            this.buttonNum0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNum0.Font = new System.Drawing.Font("굴림", 20F);
            this.buttonNum0.Location = new System.Drawing.Point(166, 381);
            this.buttonNum0.Name = "buttonNum0";
            this.buttonNum0.Size = new System.Drawing.Size(157, 121);
            this.buttonNum0.TabIndex = 9;
            this.buttonNum0.Text = "0";
            this.buttonNum0.UseVisualStyleBackColor = true;
            this.buttonNum0.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonSum
            // 
            this.buttonSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSum.Font = new System.Drawing.Font("굴림", 20F);
            this.buttonSum.Location = new System.Drawing.Point(492, 3);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(157, 120);
            this.buttonSum.TabIndex = 10;
            this.buttonSum.Text = "+";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.button_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 611);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Name = "CalculatorForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonNum3;
        private System.Windows.Forms.Button buttonNum2;
        private System.Windows.Forms.Button buttonNum1;
        private System.Windows.Forms.Button buttonNum4;
        private System.Windows.Forms.Button buttonNum5;
        private System.Windows.Forms.Button buttonNum6;
        private System.Windows.Forms.Button buttonNum7;
        private System.Windows.Forms.Button buttonNum8;
        private System.Windows.Forms.Button buttonNum9;
        private System.Windows.Forms.Button buttonNum0;
        private System.Windows.Forms.Button buttonDev;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button buttonSetClear;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonSum;
    }
}

