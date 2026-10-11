namespace DonovanColemanProject1.View
{
    partial class CarLotForm
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
            mainMenuStrip = new MenuStrip();
            fileMenuItem = new ToolStripMenuItem();
            exitMenuItem = new ToolStripMenuItem();
            inventoryMenuItem = new ToolStripMenuItem();
            addCarMenuItem = new ToolStripMenuItem();
            viewInventoryMenuItem = new ToolStripMenuItem();
            inventoryMenuSeparator = new ToolStripSeparator();
            findByMakeMenuItem = new ToolStripMenuItem();
            showAllCarsMenuItem = new ToolStripMenuItem();
            carsForSaleLbl = new Label();
            makeFilterLbl = new Label();
            makeFilterTxtBox = new TextBox();
            findByMakeBtn = new Button();
            showAllCarsBtn = new Button();
            inventoryDisplayLbl = new Label();
            inventoryListBox = new ListBox();
            purchaseBtn = new Button();
            viewInventoryBtn = new Button();
            shopperGroupBox = new GroupBox();
            createShopperBtn = new Button();
            shopperNameTitleLbl = new Label();
            shopperNameLbl = new Label();
            shopperMoneyTitleLbl = new Label();
            shopperMoneyLbl = new Label();
            purchasedCarsLbl = new Label();
            purchasedCarsListBox = new ListBox();
            mainMenuStrip.SuspendLayout();
            shopperGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { fileMenuItem, inventoryMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new Size(784, 24);
            mainMenuStrip.TabIndex = 0;
            mainMenuStrip.Text = "mainMenuStrip";
            // 
            // fileMenuItem
            // 
            fileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitMenuItem });
            fileMenuItem.Name = "fileMenuItem";
            fileMenuItem.Size = new Size(37, 20);
            fileMenuItem.Text = "&File";
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new Size(180, 22);
            exitMenuItem.Text = "E&xit";
            exitMenuItem.Click += exitMenuItem_Click;
            // 
            // inventoryMenuItem
            // 
            inventoryMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addCarMenuItem, viewInventoryMenuItem, inventoryMenuSeparator, findByMakeMenuItem, showAllCarsMenuItem });
            inventoryMenuItem.Name = "inventoryMenuItem";
            inventoryMenuItem.Size = new Size(69, 20);
            inventoryMenuItem.Text = "&Inventory";
            // 
            // addCarMenuItem
            // 
            addCarMenuItem.Name = "addCarMenuItem";
            addCarMenuItem.Size = new Size(205, 22);
            addCarMenuItem.Text = "&Add Car...";
            addCarMenuItem.Click += addCarMenuItem_Click;
            // 
            // viewInventoryMenuItem
            // 
            viewInventoryMenuItem.Name = "viewInventoryMenuItem";
            viewInventoryMenuItem.Size = new Size(205, 22);
            viewInventoryMenuItem.Text = "&View Inventory Details...";
            viewInventoryMenuItem.Click += viewInventory_Click;
            // 
            // inventoryMenuSeparator
            // 
            inventoryMenuSeparator.Name = "inventoryMenuSeparator";
            inventoryMenuSeparator.Size = new Size(202, 6);
            // 
            // findByMakeMenuItem
            // 
            findByMakeMenuItem.Name = "findByMakeMenuItem";
            findByMakeMenuItem.Size = new Size(205, 22);
            findByMakeMenuItem.Text = "&Find Cars by Make";
            findByMakeMenuItem.Click += findByMake_Click;
            // 
            // showAllCarsMenuItem
            // 
            showAllCarsMenuItem.Name = "showAllCarsMenuItem";
            showAllCarsMenuItem.Size = new Size(205, 22);
            showAllCarsMenuItem.Text = "&Show All Cars";
            showAllCarsMenuItem.Click += showAllCars_Click;
            // 
            // carsForSaleLbl
            // 
            carsForSaleLbl.AutoSize = true;
            carsForSaleLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            carsForSaleLbl.Location = new Point(12, 34);
            carsForSaleLbl.Name = "carsForSaleLbl";
            carsForSaleLbl.Size = new Size(108, 21);
            carsForSaleLbl.TabIndex = 1;
            carsForSaleLbl.Text = "Cars for Sale";
            // 
            // makeFilterLbl
            // 
            makeFilterLbl.AutoSize = true;
            makeFilterLbl.Location = new Point(12, 66);
            makeFilterLbl.Name = "makeFilterLbl";
            makeFilterLbl.Size = new Size(87, 15);
            makeFilterLbl.TabIndex = 2;
            makeFilterLbl.Text = "Filter by make:";
            // 
            // makeFilterTxtBox
            // 
            makeFilterTxtBox.Location = new Point(105, 63);
            makeFilterTxtBox.Name = "makeFilterTxtBox";
            makeFilterTxtBox.Size = new Size(150, 23);
            makeFilterTxtBox.TabIndex = 3;
            // 
            // findByMakeBtn
            // 
            findByMakeBtn.Location = new Point(261, 62);
            findByMakeBtn.Name = "findByMakeBtn";
            findByMakeBtn.Size = new Size(80, 25);
            findByMakeBtn.TabIndex = 4;
            findByMakeBtn.Text = "Find";
            findByMakeBtn.UseVisualStyleBackColor = true;
            findByMakeBtn.Click += findByMake_Click;
            // 
            // showAllCarsBtn
            // 
            showAllCarsBtn.Location = new Point(347, 62);
            showAllCarsBtn.Name = "showAllCarsBtn";
            showAllCarsBtn.Size = new Size(85, 25);
            showAllCarsBtn.TabIndex = 5;
            showAllCarsBtn.Text = "Show All";
            showAllCarsBtn.UseVisualStyleBackColor = true;
            showAllCarsBtn.Click += showAllCars_Click;
            // 
            // inventoryDisplayLbl
            // 
            inventoryDisplayLbl.AutoSize = true;
            inventoryDisplayLbl.ForeColor = SystemColors.GrayText;
            inventoryDisplayLbl.Location = new Point(12, 96);
            inventoryDisplayLbl.Name = "inventoryDisplayLbl";
            inventoryDisplayLbl.Size = new Size(100, 15);
            inventoryDisplayLbl.TabIndex = 6;
            inventoryDisplayLbl.Text = "Showing all cars";
            // 
            // inventoryListBox
            // 
            inventoryListBox.FormattingEnabled = true;
            inventoryListBox.HorizontalScrollbar = true;
            inventoryListBox.ItemHeight = 15;
            inventoryListBox.Location = new Point(12, 116);
            inventoryListBox.Name = "inventoryListBox";
            inventoryListBox.Size = new Size(420, 274);
            inventoryListBox.TabIndex = 7;
            // 
            // purchaseBtn
            // 
            purchaseBtn.Location = new Point(12, 400);
            purchaseBtn.Name = "purchaseBtn";
            purchaseBtn.Size = new Size(205, 32);
            purchaseBtn.TabIndex = 8;
            purchaseBtn.Text = "Purchase Selected Car";
            purchaseBtn.UseVisualStyleBackColor = true;
            purchaseBtn.Click += purchaseBtn_Click;
            // 
            // viewInventoryBtn
            // 
            viewInventoryBtn.Location = new Point(227, 400);
            viewInventoryBtn.Name = "viewInventoryBtn";
            viewInventoryBtn.Size = new Size(205, 32);
            viewInventoryBtn.TabIndex = 9;
            viewInventoryBtn.Text = "View Inventory Details";
            viewInventoryBtn.UseVisualStyleBackColor = true;
            viewInventoryBtn.Click += viewInventory_Click;
            // 
            // shopperGroupBox
            // 
            shopperGroupBox.Controls.Add(createShopperBtn);
            shopperGroupBox.Controls.Add(shopperNameTitleLbl);
            shopperGroupBox.Controls.Add(shopperNameLbl);
            shopperGroupBox.Controls.Add(shopperMoneyTitleLbl);
            shopperGroupBox.Controls.Add(shopperMoneyLbl);
            shopperGroupBox.Controls.Add(purchasedCarsLbl);
            shopperGroupBox.Controls.Add(purchasedCarsListBox);
            shopperGroupBox.Location = new Point(450, 34);
            shopperGroupBox.Name = "shopperGroupBox";
            shopperGroupBox.Size = new Size(322, 398);
            shopperGroupBox.TabIndex = 10;
            shopperGroupBox.TabStop = false;
            shopperGroupBox.Text = "Shopper";
            // 
            // createShopperBtn
            // 
            createShopperBtn.Location = new Point(15, 25);
            createShopperBtn.Name = "createShopperBtn";
            createShopperBtn.Size = new Size(150, 30);
            createShopperBtn.TabIndex = 0;
            createShopperBtn.Text = "Create Shopper...";
            createShopperBtn.UseVisualStyleBackColor = true;
            createShopperBtn.Click += createShopperBtn_Click;
            // 
            // shopperNameTitleLbl
            // 
            shopperNameTitleLbl.AutoSize = true;
            shopperNameTitleLbl.Location = new Point(15, 72);
            shopperNameTitleLbl.Name = "shopperNameTitleLbl";
            shopperNameTitleLbl.Size = new Size(42, 15);
            shopperNameTitleLbl.TabIndex = 1;
            shopperNameTitleLbl.Text = "Name:";
            // 
            // shopperNameLbl
            // 
            shopperNameLbl.AutoSize = true;
            shopperNameLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            shopperNameLbl.Location = new Point(125, 72);
            shopperNameLbl.Name = "shopperNameLbl";
            shopperNameLbl.Size = new Size(100, 15);
            shopperNameLbl.TabIndex = 2;
            shopperNameLbl.Text = "(no shopper yet)";
            // 
            // shopperMoneyTitleLbl
            // 
            shopperMoneyTitleLbl.AutoSize = true;
            shopperMoneyTitleLbl.Location = new Point(15, 97);
            shopperMoneyTitleLbl.Name = "shopperMoneyTitleLbl";
            shopperMoneyTitleLbl.Size = new Size(99, 15);
            shopperMoneyTitleLbl.TabIndex = 3;
            shopperMoneyTitleLbl.Text = "Money available:";
            // 
            // shopperMoneyLbl
            // 
            shopperMoneyLbl.AutoSize = true;
            shopperMoneyLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            shopperMoneyLbl.Location = new Point(125, 97);
            shopperMoneyLbl.Name = "shopperMoneyLbl";
            shopperMoneyLbl.Size = new Size(12, 15);
            shopperMoneyLbl.TabIndex = 4;
            shopperMoneyLbl.Text = "-";
            // 
            // purchasedCarsLbl
            // 
            purchasedCarsLbl.AutoSize = true;
            purchasedCarsLbl.Location = new Point(15, 130);
            purchasedCarsLbl.Name = "purchasedCarsLbl";
            purchasedCarsLbl.Size = new Size(91, 15);
            purchasedCarsLbl.TabIndex = 5;
            purchasedCarsLbl.Text = "Cars purchased:";
            // 
            // purchasedCarsListBox
            // 
            purchasedCarsListBox.FormattingEnabled = true;
            purchasedCarsListBox.HorizontalScrollbar = true;
            purchasedCarsListBox.ItemHeight = 15;
            purchasedCarsListBox.Location = new Point(15, 150);
            purchasedCarsListBox.Name = "purchasedCarsListBox";
            purchasedCarsListBox.SelectionMode = SelectionMode.None;
            purchasedCarsListBox.Size = new Size(292, 229);
            purchasedCarsListBox.TabIndex = 6;
            // 
            // CarLotForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 446);
            Controls.Add(mainMenuStrip);
            Controls.Add(carsForSaleLbl);
            Controls.Add(makeFilterLbl);
            Controls.Add(makeFilterTxtBox);
            Controls.Add(findByMakeBtn);
            Controls.Add(showAllCarsBtn);
            Controls.Add(inventoryDisplayLbl);
            Controls.Add(inventoryListBox);
            Controls.Add(purchaseBtn);
            Controls.Add(viewInventoryBtn);
            Controls.Add(shopperGroupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = mainMenuStrip;
            MaximizeBox = false;
            Name = "CarLotForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Lot Manager";
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            shopperGroupBox.ResumeLayout(false);
            shopperGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem fileMenuItem;
        private ToolStripMenuItem exitMenuItem;
        private ToolStripMenuItem inventoryMenuItem;
        private ToolStripMenuItem addCarMenuItem;
        private ToolStripMenuItem viewInventoryMenuItem;
        private ToolStripSeparator inventoryMenuSeparator;
        private ToolStripMenuItem findByMakeMenuItem;
        private ToolStripMenuItem showAllCarsMenuItem;
        private Label carsForSaleLbl;
        private Label makeFilterLbl;
        private TextBox makeFilterTxtBox;
        private Button findByMakeBtn;
        private Button showAllCarsBtn;
        private Label inventoryDisplayLbl;
        private ListBox inventoryListBox;
        private Button purchaseBtn;
        private Button viewInventoryBtn;
        private GroupBox shopperGroupBox;
        private Button createShopperBtn;
        private Label shopperNameTitleLbl;
        private Label shopperNameLbl;
        private Label shopperMoneyTitleLbl;
        private Label shopperMoneyLbl;
        private Label purchasedCarsLbl;
        private ListBox purchasedCarsListBox;
    }
}