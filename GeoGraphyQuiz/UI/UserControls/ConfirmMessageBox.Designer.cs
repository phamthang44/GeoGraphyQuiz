namespace GeoGraphyQuiz.UI.UserControls
{
    partial class ConfirmMessageBox
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblMessage;
        private Button btnYes;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblMessage = new Label();
            btnYes = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(25, 20);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 25);
            lblMessage.TabIndex = 0;
            // 
            // btnYes
            // 
            btnYes.BackColor = Color.FromArgb(0, 192, 0);
            btnYes.Font = new Font("Segoe UI", 11F);
            btnYes.ForeColor = Color.White;
            btnYes.Location = new Point(42, 145);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(107, 48);
            btnYes.TabIndex = 1;
            btnYes.Text = "Yes";
            btnYes.UseVisualStyleBackColor = false;
            btnYes.Click += agreeBtn_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.Font = new Font("Segoe UI", 11F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(218, 145);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(102, 48);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += cancelBtn_Click;
            // 
            // ConfirmMessageBox
            // 
            ClientSize = new Size(368, 224);
            Controls.Add(lblMessage);
            Controls.Add(btnYes);
            Controls.Add(btnCancel);
            Name = "ConfirmMessageBox";
            Text = "Confirm Delete";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
