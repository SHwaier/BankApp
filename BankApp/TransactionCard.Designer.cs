namespace BankApp
{
    partial class TransactionCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLbl = new Label();
            descLbl = new Label();
            amountLbl = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            dateLbl = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLbl.Location = new Point(3, 0);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(56, 30);
            titleLbl.TabIndex = 0;
            titleLbl.Text = "Title";
            // 
            // descLbl
            // 
            descLbl.Anchor = AnchorStyles.Left;
            descLbl.AutoSize = true;
            descLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descLbl.ForeColor = SystemColors.GrayText;
            descLbl.Location = new Point(3, 34);
            descLbl.Name = "descLbl";
            descLbl.Size = new Size(89, 21);
            descLbl.TabIndex = 1;
            descLbl.Text = "Description";
            descLbl.Click += label1_Click;
            // 
            // amountLbl
            // 
            amountLbl.Anchor = AnchorStyles.Left;
            amountLbl.AutoSize = true;
            amountLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            amountLbl.ForeColor = SystemColors.Desktop;
            amountLbl.Location = new Point(335, 32);
            amountLbl.Name = "amountLbl";
            amountLbl.Size = new Size(77, 25);
            amountLbl.TabIndex = 2;
            amountLbl.Text = "$XX.XX";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(titleLbl, 0, 0);
            tableLayoutPanel1.Controls.Add(amountLbl, 1, 1);
            tableLayoutPanel1.Controls.Add(descLbl, 0, 1);
            tableLayoutPanel1.Controls.Add(dateLbl, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(415, 90);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dateLbl
            // 
            dateLbl.Anchor = AnchorStyles.Left;
            dateLbl.AutoSize = true;
            dateLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateLbl.ForeColor = SystemColors.GrayText;
            dateLbl.Location = new Point(335, 4);
            dateLbl.Name = "dateLbl";
            dateLbl.Size = new Size(42, 21);
            dateLbl.TabIndex = 3;
            dateLbl.Text = "Date";
            // 
            // TransactionCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(tableLayoutPanel1);
            Name = "TransactionCard";
            Size = new Size(415, 90);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLbl;
        private Label descLbl;
        private Label amountLbl;
        private TableLayoutPanel tableLayoutPanel1;
        private Label dateLbl;
    }
}
