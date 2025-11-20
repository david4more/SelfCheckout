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
        addCheckout = new System.Windows.Forms.Button();
        tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
        cashOnDeliveryCheckbox = new System.Windows.Forms.CheckBox();
        deliveryCheckbox = new System.Windows.Forms.CheckBox();
        onlineCheckbox = new System.Windows.Forms.CheckBox();
        cashCheckbox = new System.Windows.Forms.CheckBox();
        tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        button4 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
        numberLabel = new System.Windows.Forms.Label();
        adressLabel = new System.Windows.Forms.Label();
        nameLabel = new System.Windows.Forms.Label();
        tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
        itemPrice = new System.Windows.Forms.NumericUpDown();
        itemCode = new System.Windows.Forms.NumericUpDown();
        itemQuantity = new System.Windows.Forms.NumericUpDown();
        itemName = new System.Windows.Forms.TextBox();
        itemCategory = new System.Windows.Forms.TextBox();
        itemAdd = new System.Windows.Forms.Button();
        tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
        deleteCombobox = new System.Windows.Forms.ComboBox();
        deleteButton = new System.Windows.Forms.Button();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel4.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        tableLayoutPanel5.SuspendLayout();
        tableLayoutPanel6.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)itemPrice).BeginInit();
        ((System.ComponentModel.ISupportInitialize)itemCode).BeginInit();
        ((System.ComponentModel.ISupportInitialize)itemQuantity).BeginInit();
        tableLayoutPanel7.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 3;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
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
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
        tableLayoutPanel4.Controls.Add(addCheckout, 0, 3);
        tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel4.Location = new System.Drawing.Point(276, 235);
        tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(10);
        tableLayoutPanel4.Name = "tableLayoutPanel4";
        tableLayoutPanel4.RowCount = 4;
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel4.Size = new System.Drawing.Size(246, 205);
        tableLayoutPanel4.TabIndex = 2;
        // 
        // wholesaleCheckout
        // 
        wholesaleCheckout.Dock = System.Windows.Forms.DockStyle.Fill;
        wholesaleCheckout.Location = new System.Drawing.Point(3, 105);
        wholesaleCheckout.Name = "wholesaleCheckout";
        wholesaleCheckout.Size = new System.Drawing.Size(240, 45);
        wholesaleCheckout.TabIndex = 2;
        wholesaleCheckout.Text = "Wholesale";
        wholesaleCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        wholesaleCheckout.UseVisualStyleBackColor = true;
        // 
        // deliveryCheckout
        // 
        deliveryCheckout.Dock = System.Windows.Forms.DockStyle.Fill;
        deliveryCheckout.Location = new System.Drawing.Point(3, 54);
        deliveryCheckout.Name = "deliveryCheckout";
        deliveryCheckout.Size = new System.Drawing.Size(240, 45);
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
        cardCheckout.Size = new System.Drawing.Size(240, 45);
        cardCheckout.TabIndex = 0;
        cardCheckout.Text = "Card";
        cardCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        cardCheckout.UseVisualStyleBackColor = true;
        // 
        // addCheckout
        // 
        addCheckout.Dock = System.Windows.Forms.DockStyle.Fill;
        addCheckout.Location = new System.Drawing.Point(3, 156);
        addCheckout.Name = "addCheckout";
        addCheckout.Size = new System.Drawing.Size(240, 46);
        addCheckout.TabIndex = 3;
        addCheckout.Text = "Add Checkout";
        addCheckout.UseVisualStyleBackColor = true;
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
        tableLayoutPanel3.Size = new System.Drawing.Size(248, 205);
        tableLayoutPanel3.TabIndex = 4;
        // 
        // cashOnDeliveryCheckbox
        // 
        cashOnDeliveryCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
        cashOnDeliveryCheckbox.Location = new System.Drawing.Point(3, 156);
        cashOnDeliveryCheckbox.Name = "cashOnDeliveryCheckbox";
        cashOnDeliveryCheckbox.Size = new System.Drawing.Size(242, 46);
        cashOnDeliveryCheckbox.TabIndex = 3;
        cashOnDeliveryCheckbox.Text = "Cash on delivery available";
        cashOnDeliveryCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        cashOnDeliveryCheckbox.UseVisualStyleBackColor = true;
        // 
        // deliveryCheckbox
        // 
        deliveryCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
        deliveryCheckbox.Location = new System.Drawing.Point(3, 105);
        deliveryCheckbox.Name = "deliveryCheckbox";
        deliveryCheckbox.Size = new System.Drawing.Size(242, 45);
        deliveryCheckbox.TabIndex = 2;
        deliveryCheckbox.Text = "Delivery available";
        deliveryCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        deliveryCheckbox.UseVisualStyleBackColor = true;
        deliveryCheckbox.CheckedChanged += deliveryCheckbox_CheckedChanged;
        // 
        // onlineCheckbox
        // 
        onlineCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
        onlineCheckbox.Location = new System.Drawing.Point(3, 54);
        onlineCheckbox.Name = "onlineCheckbox";
        onlineCheckbox.Size = new System.Drawing.Size(242, 45);
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
        cashCheckbox.Size = new System.Drawing.Size(242, 45);
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
        tableLayoutPanel2.Controls.Add(button4, 0, 2);
        tableLayoutPanel2.Controls.Add(button3, 0, 1);
        tableLayoutPanel2.Controls.Add(button2, 0, 0);
        tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel2.Location = new System.Drawing.Point(10, 235);
        tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(10);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 3;
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        tableLayoutPanel2.Size = new System.Drawing.Size(246, 205);
        tableLayoutPanel2.TabIndex = 3;
        // 
        // button4
        // 
        button4.Dock = System.Windows.Forms.DockStyle.Fill;
        button4.Location = new System.Drawing.Point(3, 139);
        button4.Name = "button4";
        button4.Size = new System.Drawing.Size(240, 63);
        button4.TabIndex = 2;
        button4.Text = "Save Transactions";
        button4.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        button3.Dock = System.Windows.Forms.DockStyle.Fill;
        button3.Location = new System.Drawing.Point(3, 71);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(240, 62);
        button3.TabIndex = 1;
        button3.Text = "Load from File";
        button3.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Dock = System.Windows.Forms.DockStyle.Fill;
        button2.Location = new System.Drawing.Point(3, 3);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(240, 62);
        button2.TabIndex = 0;
        button2.Text = "Save to File";
        button2.UseVisualStyleBackColor = true;
        // 
        // tableLayoutPanel5
        // 
        tableLayoutPanel5.ColumnCount = 1;
        tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel5.Controls.Add(numberLabel, 0, 2);
        tableLayoutPanel5.Controls.Add(adressLabel, 0, 1);
        tableLayoutPanel5.Controls.Add(nameLabel, 0, 0);
        tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel5.Location = new System.Drawing.Point(10, 10);
        tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(10);
        tableLayoutPanel5.Name = "tableLayoutPanel5";
        tableLayoutPanel5.RowCount = 3;
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        tableLayoutPanel5.Size = new System.Drawing.Size(246, 205);
        tableLayoutPanel5.TabIndex = 5;
        // 
        // numberLabel
        // 
        numberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        numberLabel.Location = new System.Drawing.Point(3, 139);
        numberLabel.Margin = new System.Windows.Forms.Padding(3);
        numberLabel.Name = "numberLabel";
        numberLabel.Size = new System.Drawing.Size(240, 63);
        numberLabel.TabIndex = 2;
        numberLabel.Text = "Number";
        numberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // adressLabel
        // 
        adressLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        adressLabel.Location = new System.Drawing.Point(3, 71);
        adressLabel.Margin = new System.Windows.Forms.Padding(3);
        adressLabel.Name = "adressLabel";
        adressLabel.Size = new System.Drawing.Size(240, 62);
        adressLabel.TabIndex = 1;
        adressLabel.Text = "Adress";
        adressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // nameLabel
        // 
        nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        nameLabel.Location = new System.Drawing.Point(3, 3);
        nameLabel.Margin = new System.Windows.Forms.Padding(3);
        nameLabel.Name = "nameLabel";
        nameLabel.Size = new System.Drawing.Size(240, 62);
        nameLabel.TabIndex = 0;
        nameLabel.Text = "Name";
        nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // tableLayoutPanel6
        // 
        tableLayoutPanel6.ColumnCount = 1;
        tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel6.Controls.Add(itemPrice, 0, 1);
        tableLayoutPanel6.Controls.Add(itemCode, 0, 2);
        tableLayoutPanel6.Controls.Add(itemQuantity, 0, 4);
        tableLayoutPanel6.Controls.Add(itemName, 0, 0);
        tableLayoutPanel6.Controls.Add(itemCategory, 0, 1);
        tableLayoutPanel6.Controls.Add(itemAdd, 0, 5);
        tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel6.Location = new System.Drawing.Point(276, 10);
        tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(10);
        tableLayoutPanel6.Name = "tableLayoutPanel6";
        tableLayoutPanel6.RowCount = 6;
        tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.666666F));
        tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.666666F));
        tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.666666F));
        tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.666666F));
        tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.666666F));
        tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.666666F));
        tableLayoutPanel6.Size = new System.Drawing.Size(246, 205);
        tableLayoutPanel6.TabIndex = 6;
        // 
        // itemPrice
        // 
        itemPrice.DecimalPlaces = 2;
        itemPrice.Dock = System.Windows.Forms.DockStyle.Fill;
        itemPrice.Location = new System.Drawing.Point(3, 71);
        itemPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        itemPrice.Name = "itemPrice";
        itemPrice.Size = new System.Drawing.Size(240, 23);
        itemPrice.TabIndex = 0;
        // 
        // itemCode
        // 
        itemCode.Dock = System.Windows.Forms.DockStyle.Fill;
        itemCode.Location = new System.Drawing.Point(3, 105);
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
        itemQuantity.Location = new System.Drawing.Point(3, 139);
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
        itemName.Location = new System.Drawing.Point(3, 3);
        itemName.Name = "itemName";
        itemName.PlaceholderText = "Name";
        itemName.Size = new System.Drawing.Size(240, 23);
        itemName.TabIndex = 3;
        // 
        // itemCategory
        // 
        itemCategory.Dock = System.Windows.Forms.DockStyle.Fill;
        itemCategory.Location = new System.Drawing.Point(3, 37);
        itemCategory.Name = "itemCategory";
        itemCategory.PlaceholderText = "Category, below - price, code, quantity";
        itemCategory.Size = new System.Drawing.Size(240, 23);
        itemCategory.TabIndex = 4;
        // 
        // itemAdd
        // 
        itemAdd.Dock = System.Windows.Forms.DockStyle.Fill;
        itemAdd.Location = new System.Drawing.Point(3, 173);
        itemAdd.Name = "itemAdd";
        itemAdd.Size = new System.Drawing.Size(240, 29);
        itemAdd.TabIndex = 5;
        itemAdd.Text = "Add Item";
        itemAdd.UseVisualStyleBackColor = true;
        itemAdd.Click += itemAdd_Click;
        // 
        // tableLayoutPanel7
        // 
        tableLayoutPanel7.ColumnCount = 1;
        tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel7.Controls.Add(deleteCombobox, 0, 0);
        tableLayoutPanel7.Controls.Add(deleteButton, 0, 1);
        tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel7.Location = new System.Drawing.Point(542, 235);
        tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(10);
        tableLayoutPanel7.Name = "tableLayoutPanel7";
        tableLayoutPanel7.RowCount = 2;
        tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel7.Size = new System.Drawing.Size(248, 205);
        tableLayoutPanel7.TabIndex = 7;
        // 
        // deleteCombobox
        // 
        deleteCombobox.Dock = System.Windows.Forms.DockStyle.Fill;
        deleteCombobox.FormattingEnabled = true;
        deleteCombobox.Location = new System.Drawing.Point(3, 3);
        deleteCombobox.Name = "deleteCombobox";
        deleteCombobox.Size = new System.Drawing.Size(242, 23);
        deleteCombobox.TabIndex = 0;
        // 
        // deleteButton
        // 
        deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
        deleteButton.Location = new System.Drawing.Point(30, 132);
        deleteButton.Margin = new System.Windows.Forms.Padding(30);
        deleteButton.Name = "deleteButton";
        deleteButton.Size = new System.Drawing.Size(188, 43);
        deleteButton.TabIndex = 1;
        deleteButton.Text = "Delete Checkout Machine";
        deleteButton.UseVisualStyleBackColor = true;
        deleteButton.Click += deleteButton_Click;
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
        tableLayoutPanel6.ResumeLayout(false);
        tableLayoutPanel6.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)itemPrice).EndInit();
        ((System.ComponentModel.ISupportInitialize)itemCode).EndInit();
        ((System.ComponentModel.ISupportInitialize)itemQuantity).EndInit();
        tableLayoutPanel7.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.ComboBox deleteCombobox;
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

    private System.Windows.Forms.Label adressLabel;
    private System.Windows.Forms.Label numberLabel;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;

    private System.Windows.Forms.Label nameLabel;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;

    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

    private System.Windows.Forms.CheckBox deliveryCheckout;
    private System.Windows.Forms.CheckBox wholesaleCheckout;
    private System.Windows.Forms.Button addCheckout;

    private System.Windows.Forms.CheckBox cardCheckout;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    #endregion
}