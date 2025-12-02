using System.ComponentModel;

namespace DesktopApp;

partial class ControlPanel
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
        wholesaleCheckout = new System.Windows.Forms.CheckBox();
        deliveryCheckout = new System.Windows.Forms.CheckBox();
        cardCheckout = new System.Windows.Forms.CheckBox();
        addMachine = new System.Windows.Forms.Button();
        tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
        cashOnDeliveryCheckbox = new System.Windows.Forms.CheckBox();
        deliveryCheckbox = new System.Windows.Forms.CheckBox();
        onlineCheckbox = new System.Windows.Forms.CheckBox();
        cashCheckbox = new System.Windows.Forms.CheckBox();
        tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        saveTransactionsButton = new System.Windows.Forms.Button();
        loadFromFileButton = new System.Windows.Forms.Button();
        saveToFileButton = new System.Windows.Forms.Button();
        tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
        nameLabel = new System.Windows.Forms.TextBox();
        adressLabel = new System.Windows.Forms.TextBox();
        numberLabel = new System.Windows.Forms.TextBox();
        transactionsTable = new System.Windows.Forms.DataGridView();
        tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
        itemPrice = new System.Windows.Forms.NumericUpDown();
        itemCode = new System.Windows.Forms.NumericUpDown();
        itemQuantity = new System.Windows.Forms.NumericUpDown();
        itemName = new System.Windows.Forms.TextBox();
        itemCategory = new System.Windows.Forms.TextBox();
        itemAdd = new System.Windows.Forms.Button();
        tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
        launchButton = new System.Windows.Forms.Button();
        machineCombobox = new System.Windows.Forms.ComboBox();
        deleteButton = new System.Windows.Forms.Button();
        itemsTable = new System.Windows.Forms.DataGridView();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel4.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        tableLayoutPanel5.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)transactionsTable).BeginInit();
        tableLayoutPanel6.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)itemPrice).BeginInit();
        ((System.ComponentModel.ISupportInitialize)itemCode).BeginInit();
        ((System.ComponentModel.ISupportInitialize)itemQuantity).BeginInit();
        tableLayoutPanel7.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)itemsTable).BeginInit();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 3;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.333336F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.333336F));
        tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 1);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 0);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 1, 0);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel7, 2, 1);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.666664F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // tableLayoutPanel4
        // 
        tableLayoutPanel4.ColumnCount = 1;
        tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel4.Controls.Add(wholesaleCheckout, 0, 2);
        tableLayoutPanel4.Controls.Add(deliveryCheckout, 0, 1);
        tableLayoutPanel4.Controls.Add(cardCheckout, 0, 0);
        tableLayoutPanel4.Controls.Add(addMachine, 0, 3);
        tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel4.Location = new System.Drawing.Point(276, 309);
        tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(10);
        tableLayoutPanel4.Name = "tableLayoutPanel4";
        tableLayoutPanel4.RowCount = 4;
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel4.Size = new System.Drawing.Size(246, 131);
        tableLayoutPanel4.TabIndex = 2;
        // 
        // wholesaleCheckout
        // 
        wholesaleCheckout.Dock = System.Windows.Forms.DockStyle.Fill;
        wholesaleCheckout.Location = new System.Drawing.Point(3, 67);
        wholesaleCheckout.Name = "wholesaleCheckout";
        wholesaleCheckout.Size = new System.Drawing.Size(240, 26);
        wholesaleCheckout.TabIndex = 2;
        wholesaleCheckout.Text = "Wholesale";
        wholesaleCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        wholesaleCheckout.UseVisualStyleBackColor = true;
        // 
        // deliveryCheckout
        // 
        deliveryCheckout.Dock = System.Windows.Forms.DockStyle.Fill;
        deliveryCheckout.Location = new System.Drawing.Point(3, 35);
        deliveryCheckout.Name = "deliveryCheckout";
        deliveryCheckout.Size = new System.Drawing.Size(240, 26);
        deliveryCheckout.TabIndex = 1;
        deliveryCheckout.Text = "Delivery";
        deliveryCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        deliveryCheckout.UseVisualStyleBackColor = true;
        // 
        // cardCheckout
        // 
        cardCheckout.Dock = System.Windows.Forms.DockStyle.Fill;
        cardCheckout.Location = new System.Drawing.Point(3, 3);
        cardCheckout.Name = "cardCheckout";
        cardCheckout.Size = new System.Drawing.Size(240, 26);
        cardCheckout.TabIndex = 0;
        cardCheckout.Text = "Card";
        cardCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        cardCheckout.UseVisualStyleBackColor = true;
        // 
        // addMachine
        // 
        addMachine.Dock = System.Windows.Forms.DockStyle.Fill;
        addMachine.Location = new System.Drawing.Point(3, 99);
        addMachine.Name = "addMachine";
        addMachine.Size = new System.Drawing.Size(240, 29);
        addMachine.TabIndex = 3;
        addMachine.Text = "Add Checkout Machine";
        addMachine.UseVisualStyleBackColor = true;
        addMachine.Click += addMachine_Click;
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 1;
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel3.Controls.Add(cashOnDeliveryCheckbox, 0, 3);
        tableLayoutPanel3.Controls.Add(deliveryCheckbox, 0, 2);
        tableLayoutPanel3.Controls.Add(onlineCheckbox, 0, 1);
        tableLayoutPanel3.Controls.Add(cashCheckbox, 0, 0);
        tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel3.Location = new System.Drawing.Point(542, 10);
        tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(10);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 4;
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel3.Size = new System.Drawing.Size(248, 279);
        tableLayoutPanel3.TabIndex = 4;
        // 
        // cashOnDeliveryCheckbox
        // 
        cashOnDeliveryCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
        cashOnDeliveryCheckbox.Location = new System.Drawing.Point(3, 210);
        cashOnDeliveryCheckbox.Name = "cashOnDeliveryCheckbox";
        cashOnDeliveryCheckbox.Size = new System.Drawing.Size(242, 66);
        cashOnDeliveryCheckbox.TabIndex = 3;
        cashOnDeliveryCheckbox.Text = "Cash on delivery available";
        cashOnDeliveryCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        cashOnDeliveryCheckbox.UseVisualStyleBackColor = true;
        cashOnDeliveryCheckbox.CheckedChanged += cashOnDeliveryCheckbox_CheckedChanged;
        // 
        // deliveryCheckbox
        // 
        deliveryCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
        deliveryCheckbox.Location = new System.Drawing.Point(3, 141);
        deliveryCheckbox.Name = "deliveryCheckbox";
        deliveryCheckbox.Size = new System.Drawing.Size(242, 63);
        deliveryCheckbox.TabIndex = 2;
        deliveryCheckbox.Text = "Delivery available";
        deliveryCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        deliveryCheckbox.UseVisualStyleBackColor = true;
        deliveryCheckbox.CheckedChanged += deliveryCheckbox_CheckedChanged;
        // 
        // onlineCheckbox
        // 
        onlineCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
        onlineCheckbox.Location = new System.Drawing.Point(3, 72);
        onlineCheckbox.Name = "onlineCheckbox";
        onlineCheckbox.Size = new System.Drawing.Size(242, 63);
        onlineCheckbox.TabIndex = 1;
        onlineCheckbox.Text = "Online orders available";
        onlineCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        onlineCheckbox.UseVisualStyleBackColor = true;
        onlineCheckbox.CheckedChanged += onlineCheckbox_CheckedChanged;
        // 
        // cashCheckbox
        // 
        cashCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
        cashCheckbox.Location = new System.Drawing.Point(3, 3);
        cashCheckbox.Name = "cashCheckbox";
        cashCheckbox.Size = new System.Drawing.Size(242, 63);
        cashCheckbox.TabIndex = 0;
        cashCheckbox.Text = "Cash payments accepted";
        cashCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        cashCheckbox.UseVisualStyleBackColor = true;
        cashCheckbox.CheckedChanged += cashCheckbox_CheckedChanged;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 1;
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel2.Controls.Add(saveTransactionsButton, 0, 2);
        tableLayoutPanel2.Controls.Add(loadFromFileButton, 0, 1);
        tableLayoutPanel2.Controls.Add(saveToFileButton, 0, 0);
        tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel2.Location = new System.Drawing.Point(10, 309);
        tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(10);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 3;
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        tableLayoutPanel2.Size = new System.Drawing.Size(246, 131);
        tableLayoutPanel2.TabIndex = 3;
        // 
        // saveTransactionsButton
        // 
        saveTransactionsButton.Dock = System.Windows.Forms.DockStyle.Fill;
        saveTransactionsButton.Location = new System.Drawing.Point(3, 89);
        saveTransactionsButton.Name = "saveTransactionsButton";
        saveTransactionsButton.Size = new System.Drawing.Size(240, 39);
        saveTransactionsButton.TabIndex = 2;
        saveTransactionsButton.Text = "Save Transactions";
        saveTransactionsButton.UseVisualStyleBackColor = true;
        saveTransactionsButton.Click += saveTransactionsButton_Click;
        // 
        // loadFromFileButton
        // 
        loadFromFileButton.Dock = System.Windows.Forms.DockStyle.Fill;
        loadFromFileButton.Location = new System.Drawing.Point(3, 46);
        loadFromFileButton.Name = "loadFromFileButton";
        loadFromFileButton.Size = new System.Drawing.Size(240, 37);
        loadFromFileButton.TabIndex = 1;
        loadFromFileButton.Text = "Load from File";
        loadFromFileButton.UseVisualStyleBackColor = true;
        loadFromFileButton.Click += loadFromFileButton_Click;
        // 
        // saveToFileButton
        // 
        saveToFileButton.Dock = System.Windows.Forms.DockStyle.Fill;
        saveToFileButton.Location = new System.Drawing.Point(3, 3);
        saveToFileButton.Name = "saveToFileButton";
        saveToFileButton.Size = new System.Drawing.Size(240, 37);
        saveToFileButton.TabIndex = 0;
        saveToFileButton.Text = "Save to File";
        saveToFileButton.UseVisualStyleBackColor = true;
        saveToFileButton.Click += saveToFileButton_Click;
        // 
        // tableLayoutPanel5
        // 
        tableLayoutPanel5.ColumnCount = 1;
        tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel5.Controls.Add(nameLabel, 0, 0);
        tableLayoutPanel5.Controls.Add(adressLabel, 0, 1);
        tableLayoutPanel5.Controls.Add(numberLabel, 0, 2);
        tableLayoutPanel5.Controls.Add(transactionsTable, 0, 3);
        tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel5.Location = new System.Drawing.Point(10, 10);
        tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(10);
        tableLayoutPanel5.Name = "tableLayoutPanel5";
        tableLayoutPanel5.RowCount = 4;
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.00001F));
        tableLayoutPanel5.Size = new System.Drawing.Size(246, 279);
        tableLayoutPanel5.TabIndex = 5;
        // 
        // nameLabel
        // 
        nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        nameLabel.Location = new System.Drawing.Point(3, 3);
        nameLabel.Name = "nameLabel";
        nameLabel.PlaceholderText = "SupermarketName";
        nameLabel.Size = new System.Drawing.Size(240, 23);
        nameLabel.TabIndex = 4;
        // 
        // adressLabel
        // 
        adressLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        adressLabel.Location = new System.Drawing.Point(3, 32);
        adressLabel.Name = "adressLabel";
        adressLabel.PlaceholderText = "SupermarketAddress";
        adressLabel.Size = new System.Drawing.Size(240, 23);
        adressLabel.TabIndex = 5;
        // 
        // numberLabel
        // 
        numberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        numberLabel.Location = new System.Drawing.Point(3, 61);
        numberLabel.Name = "numberLabel";
        numberLabel.PlaceholderText = "SupermarketNumber";
        numberLabel.Size = new System.Drawing.Size(240, 23);
        numberLabel.TabIndex = 6;
        // 
        // transactionsTable
        // 
        transactionsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        transactionsTable.Dock = System.Windows.Forms.DockStyle.Fill;
        transactionsTable.Location = new System.Drawing.Point(3, 90);
        transactionsTable.Name = "transactionsTable";
        transactionsTable.Size = new System.Drawing.Size(240, 186);
        transactionsTable.TabIndex = 7;
        transactionsTable.Text = "dataGridView1";
        // 
        // tableLayoutPanel6
        // 
        tableLayoutPanel6.ColumnCount = 1;
        tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel6.Controls.Add(itemPrice, 0, 2);
        tableLayoutPanel6.Controls.Add(itemCode, 0, 3);
        tableLayoutPanel6.Controls.Add(itemQuantity, 0, 5);
        tableLayoutPanel6.Controls.Add(itemName, 0, 1);
        tableLayoutPanel6.Controls.Add(itemCategory, 0, 2);
        tableLayoutPanel6.Controls.Add(itemAdd, 0, 6);
        tableLayoutPanel6.Controls.Add(itemsTable, 0, 0);
        tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel6.Location = new System.Drawing.Point(276, 10);
        tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(10);
        tableLayoutPanel6.Name = "tableLayoutPanel6";
        tableLayoutPanel6.RowCount = 7;
        tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.395695F));
        tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.434052F));
        tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.434049F));
        tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.434049F));
        tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.434049F));
        tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.434049F));
        tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.434049F));
        tableLayoutPanel6.Size = new System.Drawing.Size(246, 279);
        tableLayoutPanel6.TabIndex = 6;
        // 
        // itemPrice
        // 
        itemPrice.DecimalPlaces = 2;
        itemPrice.Dock = System.Windows.Forms.DockStyle.Fill;
        itemPrice.Location = new System.Drawing.Point(3, 136);
        itemPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        itemPrice.Name = "itemPrice";
        itemPrice.Size = new System.Drawing.Size(240, 23);
        itemPrice.TabIndex = 0;
        // 
        // itemCode
        // 
        itemCode.Dock = System.Windows.Forms.DockStyle.Fill;
        itemCode.Location = new System.Drawing.Point(3, 194);
        itemCode.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
        itemCode.Minimum = new decimal(new int[] { 100000, 0, 0, 0 });
        itemCode.Name = "itemCode";
        itemCode.Size = new System.Drawing.Size(240, 23);
        itemCode.TabIndex = 1;
        itemCode.Value = new decimal(new int[] { 100000, 0, 0, 0 });
        // 
        // itemQuantity
        // 
        itemQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
        itemQuantity.Location = new System.Drawing.Point(3, 223);
        itemQuantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        itemQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        itemQuantity.Name = "itemQuantity";
        itemQuantity.Size = new System.Drawing.Size(240, 23);
        itemQuantity.TabIndex = 2;
        itemQuantity.Tag = "";
        itemQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // itemName
        // 
        itemName.Dock = System.Windows.Forms.DockStyle.Fill;
        itemName.Location = new System.Drawing.Point(3, 107);
        itemName.Name = "itemName";
        itemName.PlaceholderText = "Name";
        itemName.Size = new System.Drawing.Size(240, 23);
        itemName.TabIndex = 3;
        // 
        // itemCategory
        // 
        itemCategory.Dock = System.Windows.Forms.DockStyle.Fill;
        itemCategory.Location = new System.Drawing.Point(3, 165);
        itemCategory.Name = "itemCategory";
        itemCategory.PlaceholderText = "Category, below - price, code, quantity";
        itemCategory.Size = new System.Drawing.Size(240, 23);
        itemCategory.TabIndex = 4;
        // 
        // itemAdd
        // 
        itemAdd.Dock = System.Windows.Forms.DockStyle.Fill;
        itemAdd.Location = new System.Drawing.Point(3, 252);
        itemAdd.Name = "itemAdd";
        itemAdd.Size = new System.Drawing.Size(240, 24);
        itemAdd.TabIndex = 5;
        itemAdd.Text = "Add Item";
        itemAdd.UseVisualStyleBackColor = true;
        itemAdd.Click += itemAdd_Click;
        // 
        // tableLayoutPanel7
        // 
        tableLayoutPanel7.ColumnCount = 1;
        tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel7.Controls.Add(launchButton, 0, 2);
        tableLayoutPanel7.Controls.Add(machineCombobox, 0, 0);
        tableLayoutPanel7.Controls.Add(deleteButton, 0, 1);
        tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel7.Location = new System.Drawing.Point(542, 309);
        tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(10);
        tableLayoutPanel7.Name = "tableLayoutPanel7";
        tableLayoutPanel7.RowCount = 3;
        tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        tableLayoutPanel7.Size = new System.Drawing.Size(248, 131);
        tableLayoutPanel7.TabIndex = 7;
        // 
        // launchButton
        // 
        launchButton.Dock = System.Windows.Forms.DockStyle.Fill;
        launchButton.Location = new System.Drawing.Point(10, 96);
        launchButton.Margin = new System.Windows.Forms.Padding(10);
        launchButton.Name = "launchButton";
        launchButton.Size = new System.Drawing.Size(228, 25);
        launchButton.TabIndex = 2;
        launchButton.Text = "Launch Checkout Machine";
        launchButton.UseVisualStyleBackColor = true;
        launchButton.Click += launchButton_Click;
        // 
        // machineCombobox
        // 
        machineCombobox.Dock = System.Windows.Forms.DockStyle.Fill;
        machineCombobox.FormattingEnabled = true;
        machineCombobox.Location = new System.Drawing.Point(10, 20);
        machineCombobox.Margin = new System.Windows.Forms.Padding(10, 20, 10, 10);
        machineCombobox.Name = "machineCombobox";
        machineCombobox.Size = new System.Drawing.Size(228, 23);
        machineCombobox.TabIndex = 0;
        // 
        // deleteButton
        // 
        deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
        deleteButton.Location = new System.Drawing.Point(10, 53);
        deleteButton.Margin = new System.Windows.Forms.Padding(10);
        deleteButton.Name = "deleteButton";
        deleteButton.Size = new System.Drawing.Size(228, 23);
        deleteButton.TabIndex = 1;
        deleteButton.Text = "Delete Checkout Machine";
        deleteButton.UseVisualStyleBackColor = true;
        deleteButton.Click += deleteButton_Click;
        // 
        // itemsTable
        // 
        itemsTable.AllowUserToAddRows = false;
        itemsTable.AllowUserToDeleteRows = false;
        itemsTable.AllowUserToResizeRows = false;
        itemsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        itemsTable.Dock = System.Windows.Forms.DockStyle.Fill;
        itemsTable.Location = new System.Drawing.Point(3, 3);
        itemsTable.Name = "itemsTable";
        itemsTable.RowHeadersVisible = false;
        itemsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        itemsTable.Size = new System.Drawing.Size(240, 98);
        itemsTable.TabIndex = 6;
        itemsTable.Text = "dataGridView1";
        // 
        // ControlPanel
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(tableLayoutPanel1);
        Text = "ControlPanel";
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel4.ResumeLayout(false);
        tableLayoutPanel3.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel5.ResumeLayout(false);
        tableLayoutPanel5.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)transactionsTable).EndInit();
        tableLayoutPanel6.ResumeLayout(false);
        tableLayoutPanel6.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)itemPrice).EndInit();
        ((System.ComponentModel.ISupportInitialize)itemCode).EndInit();
        ((System.ComponentModel.ISupportInitialize)itemQuantity).EndInit();
        tableLayoutPanel7.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)itemsTable).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView itemsTable;

    private System.Windows.Forms.DataGridView transactionsTable;

    private System.Windows.Forms.TextBox adressLabel;

    private System.Windows.Forms.TextBox nameLabel;

    private System.Windows.Forms.Button launchButton;

    private System.Windows.Forms.ComboBox machineCombobox;
    private System.Windows.Forms.Button deleteButton;

    private System.Windows.Forms.NumericUpDown itemPrice;
    private System.Windows.Forms.NumericUpDown itemCode;
    private System.Windows.Forms.NumericUpDown itemQuantity;
    private System.Windows.Forms.TextBox itemName;
    private System.Windows.Forms.TextBox itemCategory;
    private System.Windows.Forms.Button itemAdd;

    private System.Windows.Forms.CheckBox onlineCheckbox;
    private System.Windows.Forms.CheckBox deliveryCheckbox;
    private System.Windows.Forms.CheckBox cashOnDeliveryCheckbox;

    private System.Windows.Forms.CheckBox cashCheckbox;

    private System.Windows.Forms.TextBox numberLabel;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;

    private System.Windows.Forms.Button loadFromFileButton;
    private System.Windows.Forms.Button saveTransactionsButton;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

    private System.Windows.Forms.Button saveToFileButton;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

    private System.Windows.Forms.CheckBox deliveryCheckout;
    private System.Windows.Forms.CheckBox wholesaleCheckout;
    private System.Windows.Forms.Button addMachine;

    private System.Windows.Forms.CheckBox cardCheckout;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    #endregion
}