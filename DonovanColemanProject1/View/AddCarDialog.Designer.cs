namespace DonovanColemanProject1.View
{
    partial class AddCarDialog
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
            makeLbl = new Label();
            makeTxtBox = new TextBox();
            makeErrorLbl = new Label();
            modelLbl = new Label();
            modelTxtBox = new TextBox();
            modelErrorLbl = new Label();
            mpgLbl = new Label();
            mpgTxtBox = new TextBox();
            mpgErrorLbl = new Label();
            priceLbl = new Label();
            priceTxtBox = new TextBox();
            priceErrorLbl = new Label();
            addCarBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // makeLbl
            // 
            makeLbl.AutoSize = true;
            makeLbl.Location = new Point(15, 20);
            makeLbl.Name = "makeLbl";
            makeLbl.Size = new Size(39, 15);
            makeLbl.TabIndex = 0;
            makeLbl.Text = "Make:";
            // 
            // makeTxtBox
            // 
            makeTxtBox.Location = new Point(110, 17);
            makeTxtBox.Name = "makeTxtBox";
            makeTxtBox.Size = new Size(235, 23);
            makeTxtBox.TabIndex = 1;
            // 
            // makeErrorLbl
            // 
            makeErrorLbl.AutoSize = true;
            makeErrorLbl.ForeColor = Color.Firebrick;
            makeErrorLbl.Location = new Point(110, 43);
            makeErrorLbl.Name = "makeErrorLbl";
            makeErrorLbl.Size = new Size(126, 15);
            makeErrorLbl.TabIndex = 2;
            makeErrorLbl.Text = "Please enter a make.";
            makeErrorLbl.Visible = false;
            // 
            // modelLbl
            // 
            modelLbl.AutoSize = true;
            modelLbl.Location = new Point(15, 72);
            modelLbl.Name = "modelLbl";
            modelLbl.Size = new Size(44, 15);
            modelLbl.TabIndex = 3;
            modelLbl.Text = "Model:";
            // 
            // modelTxtBox
            // 
            modelTxtBox.Location = new Point(110, 69);
            modelTxtBox.Name = "modelTxtBox";
            modelTxtBox.Size = new Size(235, 23);
            modelTxtBox.TabIndex = 4;
            // 
            // modelErrorLbl
            // 
            modelErrorLbl.AutoSize = true;
            modelErrorLbl.ForeColor = Color.Firebrick;
            modelErrorLbl.Location = new Point(110, 95);
            modelErrorLbl.Name = "modelErrorLbl";
            modelErrorLbl.Size = new Size(131, 15);
            modelErrorLbl.TabIndex = 5;
            modelErrorLbl.Text = "Please enter a model.";
            modelErrorLbl.Visible = false;
            // 
            // mpgLbl
            // 
            mpgLbl.AutoSize = true;
            mpgLbl.Location = new Point(15, 124);
            mpgLbl.Name = "mpgLbl";
            mpgLbl.Size = new Size(36, 15);
            mpgLbl.TabIndex = 6;
            mpgLbl.Text = "MPG:";
            // 
            // mpgTxtBox
            // 
            mpgTxtBox.Location = new Point(110, 121);
            mpgTxtBox.Name = "mpgTxtBox";
            mpgTxtBox.Size = new Size(235, 23);
            mpgTxtBox.TabIndex = 7;
            // 
            // mpgErrorLbl
            // 
            mpgErrorLbl.AutoSize = true;
            mpgErrorLbl.ForeColor = Color.Firebrick;
            mpgErrorLbl.Location = new Point(110, 147);
            mpgErrorLbl.Name = "mpgErrorLbl";
            mpgErrorLbl.Size = new Size(197, 15);
            mpgErrorLbl.TabIndex = 8;
            mpgErrorLbl.Text = "Enter an MPG greater than zero.";
            mpgErrorLbl.Visible = false;
            // 
            // priceLbl
            // 
            priceLbl.AutoSize = true;
            priceLbl.Location = new Point(15, 176);
            priceLbl.Name = "priceLbl";
            priceLbl.Size = new Size(36, 15);
            priceLbl.TabIndex = 9;
            priceLbl.Text = "Price:";
            // 
            // priceTxtBox
            // 
            priceTxtBox.Location = new Point(110, 173);
            priceTxtBox.Name = "priceTxtBox";
            priceTxtBox.Size = new Size(235, 23);
            priceTxtBox.TabIndex = 10;
            // 
            // priceErrorLbl
            // 
            priceErrorLbl.ForeColor = Color.Firebrick;
            priceErrorLbl.Location = new Point(110, 199);
            priceErrorLbl.Name = "priceErrorLbl";
            priceErrorLbl.Size = new Size(235, 32);
            priceErrorLbl.TabIndex = 11;
            priceErrorLbl.Text = "Enter a price greater than zero with at most 2 decimal places.";
            priceErrorLbl.Visible = false;
            // 
            // addCarBtn
            // 
            addCarBtn.Location = new Point(189, 245);
            addCarBtn.Name = "addCarBtn";
            addCarBtn.Size = new Size(75, 28);
            addCarBtn.TabIndex = 12;
            addCarBtn.Text = "Add Car";
            addCarBtn.UseVisualStyleBackColor = true;
            addCarBtn.Click += addCarBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.DialogResult = DialogResult.Cancel;
            cancelBtn.Location = new Point(270, 245);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 28);
            cancelBtn.TabIndex = 13;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // AddCarDialog
            // 
            AcceptButton = addCarBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelBtn;
            ClientSize = new Size(360, 288);
            Controls.Add(makeLbl);
            Controls.Add(makeTxtBox);
            Controls.Add(makeErrorLbl);
            Controls.Add(modelLbl);
            Controls.Add(modelTxtBox);
            Controls.Add(modelErrorLbl);
            Controls.Add(mpgLbl);
            Controls.Add(mpgTxtBox);
            Controls.Add(mpgErrorLbl);
            Controls.Add(priceLbl);
            Controls.Add(priceTxtBox);
            Controls.Add(priceErrorLbl);
            Controls.Add(addCarBtn);
            Controls.Add(cancelBtn);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddCarDialog";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add New Car";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label makeLbl;
        private TextBox makeTxtBox;
        private Label makeErrorLbl;
        private Label modelLbl;
        private TextBox modelTxtBox;
        private Label modelErrorLbl;
        private Label mpgLbl;
        private TextBox mpgTxtBox;
        private Label mpgErrorLbl;
        private Label priceLbl;
        private TextBox priceTxtBox;
        private Label priceErrorLbl;
        private Button addCarBtn;
        private Button cancelBtn;
    }
}