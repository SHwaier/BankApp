namespace BankApp
{
    partial class Form1
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
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            overviewBtn = new Button();
            actionsBtn = new Button();
            settingsBtn = new Button();
            signOutBtn = new Button();
            mainContainer = new Panel();
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = SystemColors.ControlLight;
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(overviewBtn);
            sidebar.Controls.Add(actionsBtn);
            sidebar.Controls.Add(settingsBtn);
            sidebar.Controls.Add(signOutBtn);
            sidebar.Dock = DockStyle.Left;
            sidebar.FlowDirection = FlowDirection.TopDown;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(168, 450);
            sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 35);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 0;
            label1.Text = "Bank App";
            // 
            // overviewBtn
            // 
            overviewBtn.FlatAppearance.BorderSize = 0;
            overviewBtn.FlatAppearance.MouseDownBackColor = SystemColors.ButtonFace;
            overviewBtn.FlatStyle = FlatStyle.Flat;
            overviewBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            overviewBtn.Location = new Point(0, 106);
            overviewBtn.Margin = new Padding(0);
            overviewBtn.Name = "overviewBtn";
            overviewBtn.Size = new Size(168, 54);
            overviewBtn.TabIndex = 1;
            overviewBtn.Text = "Overview";
            overviewBtn.UseVisualStyleBackColor = true;
            overviewBtn.Click += overviewBtn_Click;
            // 
            // actionsBtn
            // 
            actionsBtn.FlatAppearance.BorderSize = 0;
            actionsBtn.FlatAppearance.MouseDownBackColor = SystemColors.ButtonFace;
            actionsBtn.FlatStyle = FlatStyle.Flat;
            actionsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            actionsBtn.Location = new Point(0, 160);
            actionsBtn.Margin = new Padding(0);
            actionsBtn.Name = "actionsBtn";
            actionsBtn.Size = new Size(168, 54);
            actionsBtn.TabIndex = 2;
            actionsBtn.Text = "Actions";
            actionsBtn.UseVisualStyleBackColor = true;
            actionsBtn.Click += actionsBtn_Click;
            // 
            // settingsBtn
            // 
            settingsBtn.FlatAppearance.BorderSize = 0;
            settingsBtn.FlatAppearance.MouseDownBackColor = SystemColors.ButtonFace;
            settingsBtn.FlatStyle = FlatStyle.Flat;
            settingsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            settingsBtn.Location = new Point(0, 214);
            settingsBtn.Margin = new Padding(0);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(168, 54);
            settingsBtn.TabIndex = 4;
            settingsBtn.Text = "Settings";
            settingsBtn.UseVisualStyleBackColor = true;
            settingsBtn.Click += settingsBtn_Click;
            // 
            // signOutBtn
            // 
            signOutBtn.FlatAppearance.BorderSize = 0;
            signOutBtn.FlatAppearance.MouseDownBackColor = SystemColors.ButtonFace;
            signOutBtn.FlatStyle = FlatStyle.Flat;
            signOutBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signOutBtn.Location = new Point(0, 268);
            signOutBtn.Margin = new Padding(0);
            signOutBtn.Name = "signOutBtn";
            signOutBtn.Size = new Size(168, 33);
            signOutBtn.TabIndex = 3;
            signOutBtn.Text = "Sign Out";
            signOutBtn.UseVisualStyleBackColor = true;
            signOutBtn.Click += signOutBtn_Click;
            // 
            // mainContainer
            // 
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.Location = new Point(168, 0);
            mainContainer.Name = "mainContainer";
            mainContainer.Size = new Size(632, 450);
            mainContainer.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainContainer);
            Controls.Add(sidebar);
            Name = "Form1";
            Load += Form1_Load;
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private Button overviewBtn;
        private Button actionsBtn;
        private Button signOutBtn;
        private Button settingsBtn;
        private Label label1;
        private Panel mainContainer;
    }
}
