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
        checkBox3 = new System.Windows.Forms.CheckBox();
        checkBox2 = new System.Windows.Forms.CheckBox();
        checkBox1 = new System.Windows.Forms.CheckBox();
        button1 = new System.Windows.Forms.Button();
        tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        button4 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
        tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
        tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
        checkBox4 = new System.Windows.Forms.CheckBox();
        checkBox5 = new System.Windows.Forms.CheckBox();
        checkBox6 = new System.Windows.Forms.CheckBox();
        checkBox7 = new System.Windows.Forms.CheckBox();
        numericUpDown1 = new System.Windows.Forms.NumericUpDown();
        numericUpDown2 = new System.Windows.Forms.NumericUpDown();
        numericUpDown3 = new System.Windows.Forms.NumericUpDown();
        textBox1 = new System.Windows.Forms.TextBox();
        textBox2 = new System.Windows.Forms.TextBox();
        button5 = new System.Windows.Forms.Button();
        comboBox1 = new System.Windows.Forms.ComboBox();
        button6 = new System.Windows.Forms.Button();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel4.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        tableLayoutPanel5.SuspendLayout();
        tableLayoutPanel6.SuspendLayout();
        tableLayoutPanel7.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
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
        tableLayoutPanel4.Controls.Add(checkBox3, 0, 2);
        tableLayoutPanel4.Controls.Add(checkBox2, 0, 1);
        tableLayoutPanel4.Controls.Add(checkBox1, 0, 0);
        tableLayoutPanel4.Controls.Add(button1, 0, 3);
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
        // checkBox3
        // 
        checkBox3.Dock = System.Windows.Forms.DockStyle.Fill;
        checkBox3.Location = new System.Drawing.Point(3, 105);
        checkBox3.Name = "checkBox3";
        checkBox3.Size = new System.Drawing.Size(240, 45);
        checkBox3.TabIndex = 2;
        checkBox3.Text = "Wholesale";
        checkBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        checkBox3.UseVisualStyleBackColor = true;
        // 
        // checkBox2
        // 
        checkBox2.Dock = System.Windows.Forms.DockStyle.Fill;
        checkBox2.Location = new System.Drawing.Point(3, 54);
        checkBox2.Name = "checkBox2";
        checkBox2.Size = new System.Drawing.Size(240, 45);
        checkBox2.TabIndex = 1;
        checkBox2.Text = "Delivery";
        checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        checkBox2.UseVisualStyleBackColor = true;
        // 
        // checkBox1
        // 
        checkBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        checkBox1.Location = new System.Drawing.Point(3, 3);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new System.Drawing.Size(240, 45);
        checkBox1.TabIndex = 0;
        checkBox1.Text = "Cash";
        checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        checkBox1.UseVisualStyleBackColor = true;
        // 
        // button1
        // 
        button1.Dock = System.Windows.Forms.DockStyle.Fill;
        button1.Location = new System.Drawing.Point(3, 156);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(240, 46);
        button1.TabIndex = 3;
        button1.Text = "Add Checkout";
        button1.UseVisualStyleBackColor = true;
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
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 1;
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel3.Controls.Add(checkBox7, 0, 3);
        tableLayoutPanel3.Controls.Add(checkBox6, 0, 2);
        tableLayoutPanel3.Controls.Add(checkBox5, 0, 1);
        tableLayoutPanel3.Controls.Add(checkBox4, 0, 0);
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
        // tableLayoutPanel5
        // 
        tableLayoutPanel5.ColumnCount = 1;
        tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel5.Controls.Add(label3, 0, 2);
        tableLayoutPanel5.Controls.Add(label2, 0, 1);
        tableLayoutPanel5.Controls.Add(label1, 0, 0);
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
        // label1
        // 
        label1.Dock = System.Windows.Forms.DockStyle.Fill;
        label1.Location = new System.Drawing.Point(3, 3);
        label1.Margin = new System.Windows.Forms.Padding(3);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(240, 62);
        label1.TabIndex = 0;
        label1.Text = "Name";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.Dock = System.Windows.Forms.DockStyle.Fill;
        label2.Location = new System.Drawing.Point(3, 71);
        label2.Margin = new System.Windows.Forms.Padding(3);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(240, 62);
        label2.TabIndex = 1;
        label2.Text = "Adress";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label3
        // 
        label3.Dock = System.Windows.Forms.DockStyle.Fill;
        label3.Location = new System.Drawing.Point(3, 139);
        label3.Margin = new System.Windows.Forms.Padding(3);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(240, 63);
        label3.TabIndex = 2;
        label3.Text = "Number";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // tableLayoutPanel6
        // 
        tableLayoutPanel6.ColumnCount = 1;
        tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel6.Controls.Add(numericUpDown1, 0, 1);
        tableLayoutPanel6.Controls.Add(numericUpDown2, 0, 2);
        tableLayoutPanel6.Controls.Add(numericUpDown3, 0, 4);
        tableLayoutPanel6.Controls.Add(textBox1, 0, 0);
        tableLayoutPanel6.Controls.Add(textBox2, 0, 3);
        tableLayoutPanel6.Controls.Add(button5, 0, 5);
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
        // tableLayoutPanel7
        // 
        tableLayoutPanel7.ColumnCount = 1;
        tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel7.Controls.Add(comboBox1, 0, 0);
        tableLayoutPanel7.Controls.Add(button6, 0, 1);
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
        // checkBox4
        // 
        checkBox4.Dock = System.Windows.Forms.DockStyle.Fill;
        checkBox4.Location = new System.Drawing.Point(3, 3);
        checkBox4.Name = "checkBox4";
        checkBox4.Size = new System.Drawing.Size(242, 45);
        checkBox4.TabIndex = 0;
        checkBox4.Text = "Cash payments accepted";
        checkBox4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        checkBox4.UseVisualStyleBackColor = true;
        // 
        // checkBox5
        // 
        checkBox5.Dock = System.Windows.Forms.DockStyle.Fill;
        checkBox5.Location = new System.Drawing.Point(3, 54);
        checkBox5.Name = "checkBox5";
        checkBox5.Size = new System.Drawing.Size(242, 45);
        checkBox5.TabIndex = 1;
        checkBox5.Text = "Online orders available";
        checkBox5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        checkBox5.UseVisualStyleBackColor = true;
        // 
        // checkBox6
        // 
        checkBox6.Dock = System.Windows.Forms.DockStyle.Fill;
        checkBox6.Location = new System.Drawing.Point(3, 105);
        checkBox6.Name = "checkBox6";
        checkBox6.Size = new System.Drawing.Size(242, 45);
        checkBox6.TabIndex = 2;
        checkBox6.Text = "Delivery available";
        checkBox6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        checkBox6.UseVisualStyleBackColor = true;
        // 
        // checkBox7
        // 
        checkBox7.Dock = System.Windows.Forms.DockStyle.Fill;
        checkBox7.Location = new System.Drawing.Point(3, 156);
        checkBox7.Name = "checkBox7";
        checkBox7.Size = new System.Drawing.Size(242, 46);
        checkBox7.TabIndex = 3;
        checkBox7.Text = "Cash on delivery available";
        checkBox7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        checkBox7.UseVisualStyleBackColor = true;
        // 
        // numericUpDown1
        // 
        numericUpDown1.Location = new System.Drawing.Point(3, 37);
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new System.Drawing.Size(168, 23);
        numericUpDown1.TabIndex = 0;
        // 
        // numericUpDown2
        // 
        numericUpDown2.Location = new System.Drawing.Point(3, 71);
        numericUpDown2.Name = "numericUpDown2";
        numericUpDown2.Size = new System.Drawing.Size(168, 23);
        numericUpDown2.TabIndex = 1;
        // 
        // numericUpDown3
        // 
        numericUpDown3.Location = new System.Drawing.Point(3, 139);
        numericUpDown3.Name = "numericUpDown3";
        numericUpDown3.Size = new System.Drawing.Size(177, 23);
        numericUpDown3.TabIndex = 2;
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(3, 3);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(156, 23);
        textBox1.TabIndex = 3;
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(3, 105);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(174, 23);
        textBox2.TabIndex = 4;
        // 
        // button5
        // 
        button5.Dock = System.Windows.Forms.DockStyle.Fill;
        button5.Location = new System.Drawing.Point(3, 173);
        button5.Name = "button5";
        button5.Size = new System.Drawing.Size(240, 29);
        button5.TabIndex = 5;
        button5.Text = "Add Item";
        button5.UseVisualStyleBackColor = true;
        // 
        // comboBox1
        // 
        comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new System.Drawing.Point(3, 3);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new System.Drawing.Size(242, 23);
        comboBox1.TabIndex = 0;
        // 
        // button6
        // 
        button6.Dock = System.Windows.Forms.DockStyle.Fill;
        button6.Location = new System.Drawing.Point(30, 132);
        button6.Margin = new System.Windows.Forms.Padding(30);
        button6.Name = "button6";
        button6.Size = new System.Drawing.Size(188, 43);
        button6.TabIndex = 1;
        button6.Text = "Delete Checkout Machine";
        button6.UseVisualStyleBackColor = true;
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
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel3.ResumeLayout(false);
        tableLayoutPanel5.ResumeLayout(false);
        tableLayoutPanel6.ResumeLayout(false);
        tableLayoutPanel6.PerformLayout();
        tableLayoutPanel7.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Button button6;

    private System.Windows.Forms.NumericUpDown numericUpDown1;
    private System.Windows.Forms.NumericUpDown numericUpDown2;
    private System.Windows.Forms.NumericUpDown numericUpDown3;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Button button5;

    private System.Windows.Forms.CheckBox checkBox5;
    private System.Windows.Forms.CheckBox checkBox6;
    private System.Windows.Forms.CheckBox checkBox7;

    private System.Windows.Forms.CheckBox checkBox4;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;

    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

    private System.Windows.Forms.CheckBox checkBox2;
    private System.Windows.Forms.CheckBox checkBox3;
    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.CheckBox checkBox1;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    #endregion
}