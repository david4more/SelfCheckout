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
        tabPage1 = new System.Windows.Forms.TabPage();
        label1 = new System.Windows.Forms.Label();
        proceedButton = new System.Windows.Forms.Button();
        wholesaleCheckbox = new System.Windows.Forms.CheckBox();
        deliveryCheckbox = new System.Windows.Forms.CheckBox();
        cardCheckbox = new System.Windows.Forms.CheckBox();
        tabPage2 = new System.Windows.Forms.TabPage();
        groupBox1 = new System.Windows.Forms.GroupBox();
        categoryCombobox = new System.Windows.Forms.ComboBox();
        table = new System.Windows.Forms.DataGridView();
        tabPage3 = new System.Windows.Forms.TabPage();
        pages.SuspendLayout();
        tabPage1.SuspendLayout();
        tabPage2.SuspendLayout();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)table).BeginInit();
        SuspendLayout();
        // 
        // pages
        // 
        pages.Controls.Add(tabPage1);
        pages.Controls.Add(tabPage2);
        pages.Controls.Add(tabPage3);
        pages.Dock = System.Windows.Forms.DockStyle.Fill;
        pages.Location = new System.Drawing.Point(0, 0);
        pages.Name = "pages";
        pages.SelectedIndex = 0;
        pages.Size = new System.Drawing.Size(800, 450);
        pages.TabIndex = 0;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(label1);
        tabPage1.Controls.Add(proceedButton);
        tabPage1.Controls.Add(wholesaleCheckbox);
        tabPage1.Controls.Add(deliveryCheckbox);
        tabPage1.Controls.Add(cardCheckbox);
        tabPage1.Location = new System.Drawing.Point(4, 24);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new System.Windows.Forms.Padding(3);
        tabPage1.Size = new System.Drawing.Size(792, 422);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "tabPage1";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(218, 50);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(341, 50);
        label1.TabIndex = 4;
        label1.Text = "Welcome!";
        // 
        // proceedButton
        // 
        proceedButton.Location = new System.Drawing.Point(298, 338);
        proceedButton.Name = "proceedButton";
        proceedButton.Size = new System.Drawing.Size(200, 37);
        proceedButton.TabIndex = 3;
        proceedButton.Text = "Proceed";
        proceedButton.UseVisualStyleBackColor = true;
        proceedButton.Click += proceedButton_Click;
        // 
        // wholesaleCheckbox
        // 
        wholesaleCheckbox.Location = new System.Drawing.Point(181, 240);
        wholesaleCheckbox.Name = "wholesaleCheckbox";
        wholesaleCheckbox.Size = new System.Drawing.Size(408, 40);
        wholesaleCheckbox.TabIndex = 2;
        wholesaleCheckbox.Text = "Wholesale";
        wholesaleCheckbox.UseVisualStyleBackColor = true;
        // 
        // deliveryCheckbox
        // 
        deliveryCheckbox.Location = new System.Drawing.Point(181, 194);
        deliveryCheckbox.Name = "deliveryCheckbox";
        deliveryCheckbox.Size = new System.Drawing.Size(408, 40);
        deliveryCheckbox.TabIndex = 1;
        deliveryCheckbox.Text = "Delivery";
        deliveryCheckbox.UseVisualStyleBackColor = true;
        // 
        // cardCheckbox
        // 
        cardCheckbox.Location = new System.Drawing.Point(181, 148);
        cardCheckbox.Name = "cardCheckbox";
        cardCheckbox.Size = new System.Drawing.Size(408, 40);
        cardCheckbox.TabIndex = 0;
        cardCheckbox.Text = "Card";
        cardCheckbox.UseVisualStyleBackColor = true;
        // 
        // tabPage2
        // 
        tabPage2.Controls.Add(groupBox1);
        tabPage2.Controls.Add(table);
        tabPage2.Location = new System.Drawing.Point(4, 24);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new System.Windows.Forms.Padding(3);
        tabPage2.Size = new System.Drawing.Size(792, 422);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "tabPage2";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(categoryCombobox);
        groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
        groupBox1.Location = new System.Drawing.Point(618, 3);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(171, 416);
        groupBox1.TabIndex = 2;
        groupBox1.TabStop = false;
        groupBox1.Text = "groupBox1";
        // 
        // categoryCombobox
        // 
        categoryCombobox.Dock = System.Windows.Forms.DockStyle.Top;
        categoryCombobox.FormattingEnabled = true;
        categoryCombobox.Location = new System.Drawing.Point(3, 19);
        categoryCombobox.Name = "categoryCombobox";
        categoryCombobox.Size = new System.Drawing.Size(165, 23);
        categoryCombobox.TabIndex = 1;
        categoryCombobox.SelectedIndexChanged += categoryCombobox_SelectedIndexChanged;
        // 
        // table
        // 
        table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        table.Dock = System.Windows.Forms.DockStyle.Left;
        table.Location = new System.Drawing.Point(3, 3);
        table.Name = "table";
        table.RowHeadersVisible = false;
        table.Size = new System.Drawing.Size(609, 416);
        table.TabIndex = 0;
        table.Text = "dataGridView1";
        // 
        // tabPage3
        // 
        tabPage3.Location = new System.Drawing.Point(4, 24);
        tabPage3.Name = "tabPage3";
        tabPage3.Padding = new System.Windows.Forms.Padding(3);
        tabPage3.Size = new System.Drawing.Size(792, 422);
        tabPage3.TabIndex = 2;
        tabPage3.Text = "tabPage3";
        tabPage3.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(pages);
        Text = "Form1";
        pages.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        tabPage2.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)table).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.GroupBox groupBox1;

    private System.Windows.Forms.ComboBox categoryCombobox;

    private System.Windows.Forms.DataGridView table;

    private System.Windows.Forms.TabPage tabPage3;

    private System.Windows.Forms.Button proceedButton;
    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.CheckBox cardCheckbox;
    private System.Windows.Forms.CheckBox deliveryCheckbox;
    private System.Windows.Forms.CheckBox wholesaleCheckbox;

    private System.Windows.Forms.TabControl pages;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;

    #endregion
}
