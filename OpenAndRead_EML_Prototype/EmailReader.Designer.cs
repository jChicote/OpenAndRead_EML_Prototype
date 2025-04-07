namespace OpenAndRead_EML_Prototype
{
    partial class EmailReader
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
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.panel1 = new Panel();
            this.tableLayoutPanel2 = new TableLayoutPanel();
            this.panel3 = new Panel();
            this.ccTextBox = new TextBox();
            this.bccTextBox = new TextBox();
            this.fromTextBox = new TextBox();
            this.toTextBox = new TextBox();
            this.panel4 = new Panel();
            this.panel2 = new Panel();
            this.selectEmailButton = new Button();
            this.subjectTextBox = new TextBox();
            this.tableLayoutPanel3 = new TableLayoutPanel();
            this.messageBodyTextBox = new RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = DockStyle.Fill;
            this.panel1.Location = new Point(209, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(588, 444);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel2.Dock = DockStyle.Fill;
            this.tableLayoutPanel2.Location = new Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            this.tableLayoutPanel2.Size = new Size(588, 444);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ccTextBox);
            this.panel3.Controls.Add(this.bccTextBox);
            this.panel3.Controls.Add(this.fromTextBox);
            this.panel3.Controls.Add(this.toTextBox);
            this.panel3.Dock = DockStyle.Fill;
            this.panel3.Location = new Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new Size(582, 127);
            this.panel3.TabIndex = 2;
            // 
            // ccTextBox
            // 
            this.ccTextBox.Location = new Point(3, 90);
            this.ccTextBox.Name = "ccTextBox";
            this.ccTextBox.Size = new Size(576, 23);
            this.ccTextBox.TabIndex = 4;
            // 
            // bccTextBox
            // 
            this.bccTextBox.Location = new Point(3, 61);
            this.bccTextBox.Name = "bccTextBox";
            this.bccTextBox.Size = new Size(576, 23);
            this.bccTextBox.TabIndex = 3;
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new Point(3, 3);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new Size(576, 23);
            this.fromTextBox.TabIndex = 2;
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new Point(3, 32);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new Size(576, 23);
            this.toTextBox.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel3);
            this.panel4.Dock = DockStyle.Fill;
            this.panel4.Location = new Point(3, 136);
            this.panel4.Name = "panel4";
            this.panel4.Size = new Size(582, 305);
            this.panel4.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.selectEmailButton);
            this.panel2.Dock = DockStyle.Fill;
            this.panel2.Location = new Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(200, 444);
            this.panel2.TabIndex = 1;
            // 
            // selectEmailButton
            // 
            this.selectEmailButton.Location = new Point(0, 0);
            this.selectEmailButton.Name = "selectEmailButton";
            this.selectEmailButton.Size = new Size(200, 50);
            this.selectEmailButton.TabIndex = 0;
            this.selectEmailButton.Text = "Select Eml File";
            this.selectEmailButton.UseVisualStyleBackColor = true;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new Point(3, 3);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new Size(576, 23);
            this.subjectTextBox.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.subjectTextBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.messageBodyTextBox, 0, 1);
            this.tableLayoutPanel3.Dock = DockStyle.Fill;
            this.tableLayoutPanel3.Location = new Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new Size(582, 305);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // messageBodyTextBox
            // 
            this.messageBodyTextBox.Dock = DockStyle.Fill;
            this.messageBodyTextBox.Location = new Point(3, 32);
            this.messageBodyTextBox.Name = "messageBodyTextBox";
            this.messageBodyTextBox.Size = new Size(576, 270);
            this.messageBodyTextBox.TabIndex = 6;
            this.messageBodyTextBox.Text = "";
            // 
            // EmailReader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(this.tableLayoutPanel1);
            Name = "EmailReader";
            Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Button selectEmailButton;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private TextBox ccTextBox;
        private TextBox bccTextBox;
        private TextBox fromTextBox;
        private TextBox toTextBox;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox subjectTextBox;
        private RichTextBox messageBodyTextBox;
    }
}
