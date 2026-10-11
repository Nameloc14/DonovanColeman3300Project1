namespace DonovanColemanProject1.View
{
    partial class ShopperDialog
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
            nameLbl = new Label();
            nameTxtBox = new TextBox();
            nameErrorLbl = new Label();
            moneyLbl = new Label();
            moneyTxtBox = new TextBox();
            moneyErrorLbl = new Label();
            okBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Location = new Point(15, 20);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(42, 15);
            nameLbl.TabIndex = 0;
            nameLbl.Text = "Name:";
            // 
            // nameTxtBox
            // 
            nameTxtBox.Location = new Point(130, 17);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(215, 23);
            nameTxtBox.TabIndex = 1;
            // 
            // nameErrorLbl
            // 
            nameErrorLbl.AutoSize = true;
            nameErrorLbl.ForeColor = Color.Firebrick;
            nameErrorLbl.Location = new Point(130, 43);
            nameErrorLbl.Name = "nameErrorLbl";
            nameErrorLbl.Size = new Size(129, 15);
            nameErrorLbl.TabIndex = 2;
            nameErrorLbl.Text = "Please enter a name.";
            nameErrorLbl.Visible = false;
            // 
            // moneyLbl
            // 
            moneyLbl.AutoSize = true;
            moneyLbl.Location = new Point(15, 75);
            moneyLbl.Name = "moneyLbl";
            moneyLbl.Size = new Size(99, 15);
            moneyLbl.TabIndex = 3;
            moneyLbl.Text = "Money available:";
            // 
            // moneyTxtBox
            // 
            moneyTxtBox.Location = new Point(130, 72);
            moneyTxtBox.Name = "moneyTxtBox";
            moneyTxtBox.Size = new Size(215, 23);
            moneyTxtBox.TabIndex = 4;
            // 
            // moneyErrorLbl
            // 
            moneyErrorLbl.ForeColor = Color.Firebrick;
            moneyErrorLbl.Location = new Point(130, 98);
            moneyErrorLbl.Name = "moneyErrorLbl";
            moneyErrorLbl.Size = new Size(215, 32);
            moneyErrorLbl.TabIndex = 5;
            moneyErrorLbl.Text = "Enter a dollar amount of 0 or more with at most 2 decimal places.";
            moneyErrorLbl.Visible = false;
            // 
            // okBtn
            // 
            okBtn.Location = new Point(189, 145);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(75, 28);
            okBtn.TabIndex = 6;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.DialogResult = DialogResult.Cancel;
            cancelBtn.Location = new Point(270, 145);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 28);
            cancelBtn.TabIndex = 7;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // ShopperDialog
            // 
            AcceptButton = okBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelBtn;
            ClientSize = new Size(360, 188);
            Controls.Add(nameLbl);
            Controls.Add(nameTxtBox);
            Controls.Add(nameErrorLbl);
            Controls.Add(moneyLbl);
            Controls.Add(moneyTxtBox);
            Controls.Add(moneyErrorLbl);
            Controls.Add(okBtn);
            Controls.Add(cancelBtn);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ShopperDialog";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Create Shopper";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLbl;
        private TextBox nameTxtBox;
        private Label nameErrorLbl;
        private Label moneyLbl;
        private TextBox moneyTxtBox;
        private Label moneyErrorLbl;
        private Button okBtn;
        private Button cancelBtn;
    }
}