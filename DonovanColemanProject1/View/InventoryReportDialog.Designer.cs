namespace DonovanColemanProject1.View
{
    partial class InventoryReportDialog
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
            reportTxtBox = new TextBox();
            closeBtn = new Button();
            SuspendLayout();
            // 
            // reportTxtBox
            // 
            reportTxtBox.BackColor = SystemColors.Window;
            reportTxtBox.Font = new Font("Consolas", 10F);
            reportTxtBox.Location = new Point(12, 12);
            reportTxtBox.Multiline = true;
            reportTxtBox.Name = "reportTxtBox";
            reportTxtBox.ReadOnly = true;
            reportTxtBox.ScrollBars = ScrollBars.Both;
            reportTxtBox.Size = new Size(460, 300);
            reportTxtBox.TabIndex = 1;
            reportTxtBox.WordWrap = false;
            // 
            // closeBtn
            // 
            closeBtn.DialogResult = DialogResult.OK;
            closeBtn.Location = new Point(397, 322);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(75, 28);
            closeBtn.TabIndex = 0;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            // 
            // InventoryReportDialog
            // 
            AcceptButton = closeBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = closeBtn;
            ClientSize = new Size(484, 362);
            Controls.Add(reportTxtBox);
            Controls.Add(closeBtn);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InventoryReportDialog";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Inventory Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox reportTxtBox;
        private Button closeBtn;
    }
}