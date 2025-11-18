namespace DesktopApp;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        pages = new System.Windows.Forms.TabControl();
        main = new System.Windows.Forms.TabPage();
        mainLayout = new System.Windows.Forms.TableLayoutPanel();
        mainProceed = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        deliveryCheckbox = new System.Windows.Forms.CheckBox();
        wholesaleCheckbox = new System.Windows.Forms.CheckBox();
        cardCheckbox = new System.Windows.Forms.CheckBox();
        label2 = new System.Windows.Forms.Label();
        adressLabel = new System.Windows.Forms.Label();
        items = new System.Windows.Forms.TabPage();
        splitContainer1 = new System.Windows.Forms.SplitContainer();
        itemsTable = new System.Windows.Forms.DataGridView();
        itemsGroup = new System.Windows.Forms.GroupBox();
        pickedItemsTable = new System.Windows.Forms.DataGridView();
        itemsProceedButton = new System.Windows.Forms.Button();
        categoryCombobox = new System.Windows.Forms.ComboBox();
        checkout = new System.Windows.Forms.TabPage();
        transactionLayout = new System.Windows.Forms.TableLayoutPanel();
        tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        transactionTable = new System.Windows.Forms.DataGridView();
        transactionBackButton = new System.Windows.Forms.Button();
        transactionProceedButton = new System.Windows.Forms.Button();
        complete = new System.Windows.Forms.TabPage();
        backButton = new System.Windows.Forms.Button();
        adminButton = new System.Windows.Forms.Button();
        admin = new System.Windows.Forms.TabPage();
        pages.SuspendLayout();
        main.SuspendLayout();
        mainLayout.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        items.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)itemsTable).BeginInit();
        itemsGroup.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pickedItemsTable).BeginInit();
        checkout.SuspendLayout();
        transactionLayout.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)transactionTable).BeginInit();
        complete.SuspendLayout();
        SuspendLayout();
        // 
        // pages
        // 
        pages.Controls.Add(main);
        pages.Controls.Add(items);
        pages.Controls.Add(checkout);
        pages.Controls.Add(complete);
        pages.Controls.Add(admin);
        pages.Dock = System.Windows.Forms.DockStyle.Fill;
        pages.Location = new System.Drawing.Point(0, 0);
        pages.Name = "pages";
        pages.SelectedIndex = 0;
        pages.Size = new System.Drawing.Size(800, 450);
        pages.TabIndex = 0;
        // 
        // main
        // 
        main.Controls.Add(mainLayout);
        main.Location = new System.Drawing.Point(4, 24);
        main.Name = "main";
        main.Padding = new System.Windows.Forms.Padding(3);
        main.Size = new System.Drawing.Size(792, 422);
        main.TabIndex = 0;
        main.Text = "main";
        main.UseVisualStyleBackColor = true;
        // 
        // mainLayout
        // 
        mainLayout.ColumnCount = 3;
        mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        mainLayout.Controls.Add(mainProceed, 1, 2);
        mainLayout.Controls.Add(label1, 1, 0);
        mainLayout.Controls.Add(tableLayoutPanel1, 1, 1);
        mainLayout.Controls.Add(label2, 2, 0);
        mainLayout.Controls.Add(adressLabel, 0, 0);
        mainLayout.Controls.Add(adminButton, 2, 2);
        mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
        mainLayout.Location = new System.Drawing.Point(3, 3);
        mainLayout.Name = "mainLayout";
        mainLayout.RowCount = 3;
        mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        mainLayout.Size = new System.Drawing.Size(786, 416);
        mainLayout.TabIndex = 5;
        // 
        // mainProceed
        // 
        mainProceed.Dock = System.Windows.Forms.DockStyle.Top;
        mainProceed.Location = new System.Drawing.Point(264, 306);
        mainProceed.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
        mainProceed.Name = "mainProceed";
        mainProceed.Size = new System.Drawing.Size(255, 37);
        mainProceed.TabIndex = 3;
        mainProceed.Text = "Proceed";
        mainProceed.UseVisualStyleBackColor = true;
        mainProceed.Click += proceedButton_Click;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(291, 30);
        label1.Margin = new System.Windows.Forms.Padding(30);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(201, 78);
        label1.TabIndex = 4;
        label1.Text = "Welcome!\r\nPick your type of order:";
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(deliveryCheckbox, 0, 1);
        tableLayoutPanel1.Controls.Add(wholesaleCheckbox, 0, 2);
        tableLayoutPanel1.Controls.Add(cardCheckbox, 0, 0);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(264, 141);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        tableLayoutPanel1.Size = new System.Drawing.Size(255, 132);
        tableLayoutPanel1.TabIndex = 5;
        // 
        // deliveryCheckbox
        // 
        deliveryCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
        deliveryCheckbox.Location = new System.Drawing.Point(3, 47);
        deliveryCheckbox.Name = "deliveryCheckbox";
        deliveryCheckbox.Size = new System.Drawing.Size(249, 38);
        deliveryCheckbox.TabIndex = 1;
        deliveryCheckbox.Text = "Delivery";
        deliveryCheckbox.UseVisualStyleBackColor = true;
        // 
        // wholesaleCheckbox
        // 
        wholesaleCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
        wholesaleCheckbox.Location = new System.Drawing.Point(3, 91);
        wholesaleCheckbox.Name = "wholesaleCheckbox";
        wholesaleCheckbox.Size = new System.Drawing.Size(249, 38);
        wholesaleCheckbox.TabIndex = 2;
        wholesaleCheckbox.Text = "Wholesale";
        wholesaleCheckbox.UseVisualStyleBackColor = true;
        // 
        // cardCheckbox
        // 
        cardCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
        cardCheckbox.Location = new System.Drawing.Point(3, 3);
        cardCheckbox.Name = "cardCheckbox";
        cardCheckbox.Size = new System.Drawing.Size(249, 38);
        cardCheckbox.TabIndex = 0;
        cardCheckbox.Text = "Card";
        cardCheckbox.UseVisualStyleBackColor = true;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)));
        label2.Location = new System.Drawing.Point(552, 30);
        label2.Margin = new System.Windows.Forms.Padding(30);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(204, 78);
        label2.TabIndex = 6;
        label2.Text = "Card payment on delivery is not supported\r\n";
        // 
        // adressLabel
        // 
        adressLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        adressLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)));
        adressLabel.Location = new System.Drawing.Point(30, 30);
        adressLabel.Margin = new System.Windows.Forms.Padding(30);
        adressLabel.Name = "adressLabel";
        adressLabel.Size = new System.Drawing.Size(201, 78);
        adressLabel.TabIndex = 7;
        adressLabel.Text = "Adress:\r\n";
        // 
        // items
        // 
        items.Controls.Add(splitContainer1);
        items.Location = new System.Drawing.Point(4, 24);
        items.Name = "items";
        items.Padding = new System.Windows.Forms.Padding(3);
        items.Size = new System.Drawing.Size(792, 422);
        items.TabIndex = 1;
        items.Text = "items";
        items.UseVisualStyleBackColor = true;
        // 
        // splitContainer1
        // 
        splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
        splitContainer1.Location = new System.Drawing.Point(3, 3);
        splitContainer1.Name = "splitContainer1";
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.Controls.Add(itemsTable);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(itemsGroup);
        splitContainer1.Size = new System.Drawing.Size(786, 416);
        splitContainer1.SplitterDistance = 517;
        splitContainer1.TabIndex = 3;
        splitContainer1.Text = "splitContainer1";
        // 
        // itemsTable
        // 
        itemsTable.AllowUserToAddRows = false;
        itemsTable.AllowUserToDeleteRows = false;
        itemsTable.AllowUserToResizeRows = false;
        itemsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        itemsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        itemsTable.Dock = System.Windows.Forms.DockStyle.Fill;
        itemsTable.Location = new System.Drawing.Point(0, 0);
        itemsTable.Name = "itemsTable";
        itemsTable.ReadOnly = true;
        itemsTable.RowHeadersVisible = false;
        itemsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        itemsTable.Size = new System.Drawing.Size(517, 416);
        itemsTable.TabIndex = 0;
        itemsTable.Text = "dataGridView1";
        itemsTable.CellDoubleClick += itemsTable_CellDoubleClick;
        // 
        // itemsGroup
        // 
        itemsGroup.Controls.Add(pickedItemsTable);
        itemsGroup.Controls.Add(itemsProceedButton);
        itemsGroup.Controls.Add(categoryCombobox);
        itemsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
        itemsGroup.Location = new System.Drawing.Point(0, 0);
        itemsGroup.Name = "itemsGroup";
        itemsGroup.Size = new System.Drawing.Size(265, 416);
        itemsGroup.TabIndex = 2;
        itemsGroup.TabStop = false;
        itemsGroup.Text = "Checkout type placeholder";
        // 
        // pickedItemsTable
        // 
        pickedItemsTable.AllowUserToAddRows = false;
        pickedItemsTable.AllowUserToDeleteRows = false;
        pickedItemsTable.AllowUserToResizeRows = false;
        pickedItemsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        pickedItemsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        pickedItemsTable.Dock = System.Windows.Forms.DockStyle.Fill;
        pickedItemsTable.Location = new System.Drawing.Point(3, 42);
        pickedItemsTable.Name = "pickedItemsTable";
        pickedItemsTable.RowHeadersVisible = false;
        pickedItemsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        pickedItemsTable.Size = new System.Drawing.Size(259, 338);
        pickedItemsTable.TabIndex = 3;
        pickedItemsTable.Text = "dataGridView1";
        pickedItemsTable.CellDoubleClick += pickedItemsTable_CellDoubleClick;
        pickedItemsTable.CellValueChanged += pickedItemsTable_CellValueChanged;
        // 
        // itemsProceedButton
        // 
        itemsProceedButton.Dock = System.Windows.Forms.DockStyle.Bottom;
        itemsProceedButton.Location = new System.Drawing.Point(3, 380);
        itemsProceedButton.Name = "itemsProceedButton";
        itemsProceedButton.Size = new System.Drawing.Size(259, 33);
        itemsProceedButton.TabIndex = 2;
        itemsProceedButton.Text = "Proceed";
        itemsProceedButton.UseVisualStyleBackColor = true;
        itemsProceedButton.Click += itemsProceed_Click;
        // 
        // categoryCombobox
        // 
        categoryCombobox.Dock = System.Windows.Forms.DockStyle.Top;
        categoryCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        categoryCombobox.FormattingEnabled = true;
        categoryCombobox.Location = new System.Drawing.Point(3, 19);
        categoryCombobox.Name = "categoryCombobox";
        categoryCombobox.Size = new System.Drawing.Size(259, 23);
        categoryCombobox.TabIndex = 1;
        categoryCombobox.SelectedIndexChanged += categoryCombobox_SelectedIndexChanged;
        // 
        // checkout
        // 
        checkout.Controls.Add(transactionLayout);
        checkout.Location = new System.Drawing.Point(4, 24);
        checkout.Name = "checkout";
        checkout.Padding = new System.Windows.Forms.Padding(3);
        checkout.Size = new System.Drawing.Size(792, 422);
        checkout.TabIndex = 2;
        checkout.Text = "checkout";
        checkout.UseVisualStyleBackColor = true;
        // 
        // transactionLayout
        // 
        transactionLayout.ColumnCount = 2;
        transactionLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        transactionLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        transactionLayout.Controls.Add(tableLayoutPanel2, 1, 0);
        transactionLayout.Dock = System.Windows.Forms.DockStyle.Fill;
        transactionLayout.Location = new System.Drawing.Point(3, 3);
        transactionLayout.Name = "transactionLayout";
        transactionLayout.RowCount = 1;
        transactionLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        transactionLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        transactionLayout.Size = new System.Drawing.Size(786, 416);
        transactionLayout.TabIndex = 0;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 1;
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel2.Controls.Add(transactionTable, 0, 1);
        tableLayoutPanel2.Controls.Add(transactionBackButton, 0, 0);
        tableLayoutPanel2.Controls.Add(transactionProceedButton, 0, 2);
        tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel2.Location = new System.Drawing.Point(396, 3);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 3;
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.666666F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.666664F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.666666F));
        tableLayoutPanel2.Size = new System.Drawing.Size(387, 410);
        tableLayoutPanel2.TabIndex = 0;
        // 
        // transactionTable
        // 
        transactionTable.AllowUserToAddRows = false;
        transactionTable.AllowUserToDeleteRows = false;
        transactionTable.AllowUserToResizeRows = false;
        transactionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        transactionTable.Dock = System.Windows.Forms.DockStyle.Fill;
        transactionTable.Location = new System.Drawing.Point(3, 71);
        transactionTable.Name = "transactionTable";
        transactionTable.RowHeadersVisible = false;
        transactionTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        transactionTable.Size = new System.Drawing.Size(381, 267);
        transactionTable.TabIndex = 0;
        transactionTable.Text = "dataGridView1";
        transactionTable.CellDoubleClick += transactionTable_CellDoubleClick;
        transactionTable.CellValueChanged += transactionTable_CellValueChanged;
        // 
        // transactionBackButton
        // 
        transactionBackButton.Dock = System.Windows.Forms.DockStyle.Fill;
        transactionBackButton.Location = new System.Drawing.Point(15, 15);
        transactionBackButton.Margin = new System.Windows.Forms.Padding(15);
        transactionBackButton.Name = "transactionBackButton";
        transactionBackButton.Size = new System.Drawing.Size(357, 38);
        transactionBackButton.TabIndex = 1;
        transactionBackButton.Text = "Back";
        transactionBackButton.UseVisualStyleBackColor = true;
        transactionBackButton.Click += transactionBackButton_Click;
        // 
        // transactionProceedButton
        // 
        transactionProceedButton.Dock = System.Windows.Forms.DockStyle.Fill;
        transactionProceedButton.Location = new System.Drawing.Point(15, 356);
        transactionProceedButton.Margin = new System.Windows.Forms.Padding(15);
        transactionProceedButton.Name = "transactionProceedButton";
        transactionProceedButton.Size = new System.Drawing.Size(357, 39);
        transactionProceedButton.TabIndex = 2;
        transactionProceedButton.Text = "Proceed";
        transactionProceedButton.UseVisualStyleBackColor = true;
        transactionProceedButton.Click += transactionProceedButton_Click;
        // 
        // complete
        // 
        complete.Controls.Add(backButton);
        complete.Location = new System.Drawing.Point(4, 24);
        complete.Name = "complete";
        complete.Padding = new System.Windows.Forms.Padding(3);
        complete.Size = new System.Drawing.Size(792, 422);
        complete.TabIndex = 3;
        complete.Text = "complete";
        complete.UseVisualStyleBackColor = true;
        // 
        // backButton
        // 
        backButton.Location = new System.Drawing.Point(167, 81);
        backButton.Name = "backButton";
        backButton.Size = new System.Drawing.Size(287, 77);
        backButton.TabIndex = 0;
        backButton.Text = "button1";
        backButton.UseVisualStyleBackColor = true;
        backButton.Click += backButton_Click;
        // 
        // adminButton
        // 
        adminButton.Dock = System.Windows.Forms.DockStyle.Right;
        adminButton.Location = new System.Drawing.Point(677, 306);
        adminButton.Margin = new System.Windows.Forms.Padding(30);
        adminButton.Name = "adminButton";
        adminButton.Size = new System.Drawing.Size(79, 80);
        adminButton.TabIndex = 8;
        adminButton.Text = "Admin";
        adminButton.UseVisualStyleBackColor = true;
        adminButton.Click += adminButton_Click;
        // 
        // admin
        // 
        admin.Location = new System.Drawing.Point(4, 24);
        admin.Name = "admin";
        admin.Padding = new System.Windows.Forms.Padding(3);
        admin.Size = new System.Drawing.Size(792, 422);
        admin.TabIndex = 4;
        admin.Text = "admin";
        admin.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(pages);
        Text = "Self-Checkout";
        pages.ResumeLayout(false);
        main.ResumeLayout(false);
        mainLayout.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        items.ResumeLayout(false);
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)itemsTable).EndInit();
        itemsGroup.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pickedItemsTable).EndInit();
        checkout.ResumeLayout(false);
        transactionLayout.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)transactionTable).EndInit();
        complete.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.TabPage admin;

    private System.Windows.Forms.Button adminButton;

    private System.Windows.Forms.Label adressLabel;

    private System.Windows.Forms.Button backButton;

    private System.Windows.Forms.Button transactionBackButton;
    private System.Windows.Forms.Button transactionProceedButton;

    private System.Windows.Forms.TabPage complete;

    private System.Windows.Forms.DataGridView transactionTable;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

    private System.Windows.Forms.TableLayoutPanel transactionLayout;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    private System.Windows.Forms.TableLayoutPanel mainLayout;

    private System.Windows.Forms.SplitContainer splitContainer1;

    private System.Windows.Forms.DataGridView pickedItemsTable;

    private System.Windows.Forms.Button itemsProceedButton;

    private System.Windows.Forms.GroupBox itemsGroup;

    private System.Windows.Forms.ComboBox categoryCombobox;

    private System.Windows.Forms.DataGridView itemsTable;

    private System.Windows.Forms.TabPage checkout;

    private System.Windows.Forms.Button mainProceed;
    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.CheckBox cardCheckbox;
    private System.Windows.Forms.CheckBox deliveryCheckbox;
    private System.Windows.Forms.CheckBox wholesaleCheckbox;

    private System.Windows.Forms.TabControl pages;
    private System.Windows.Forms.TabPage main;
    private System.Windows.Forms.TabPage items;

    #endregion
}
