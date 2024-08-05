namespace Application1;

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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        this.inputTextBox = new System.Windows.Forms.TextBox();
        this.outputLabel = new System.Windows.Forms.Label();
        this.inputTitleLabel = new System.Windows.Forms.Label();
        this.outputTitleLabel = new System.Windows.Forms.Label();
        this.tableLayoutPanel1.SuspendLayout();
        this.SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 1;
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tableLayoutPanel1.Controls.Add(this.inputTextBox, 0, 1);
        this.tableLayoutPanel1.Controls.Add(this.outputLabel, 0, 3);
        this.tableLayoutPanel1.Controls.Add(this.inputTitleLabel, 0, 0);
        this.tableLayoutPanel1.Controls.Add(this.outputTitleLabel, 0, 2);
        this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 4;
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
        this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
        this.tableLayoutPanel1.TabIndex = 0;
        // 
        // inputTextBox
        // 
        this.inputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        this.inputTextBox.Location = new System.Drawing.Point(3, 48);
        this.inputTextBox.Multiline = true;
        this.inputTextBox.Name = "inputTextBox";
        this.inputTextBox.Size = new System.Drawing.Size(794, 174);
        this.inputTextBox.TabIndex = 0;
        this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
        // 
        // outputLabel
        // 
        this.outputLabel.AutoSize = true;
        this.outputLabel.BackColor = System.Drawing.SystemColors.ControlLight;
        this.outputLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        this.outputLabel.Location = new System.Drawing.Point(3, 270);
        this.outputLabel.Name = "outputLabel";
        this.outputLabel.Size = new System.Drawing.Size(794, 180);
        this.outputLabel.TabIndex = 1;
        this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // inputTitleLabel
        // 
        this.inputTitleLabel.AutoSize = true;
        this.inputTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        this.inputTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.inputTitleLabel.Location = new System.Drawing.Point(3, 0);
        this.inputTitleLabel.Name = "inputTitleLabel";
        this.inputTitleLabel.Size = new System.Drawing.Size(794, 45);
        this.inputTitleLabel.TabIndex = 2;
        this.inputTitleLabel.Text = "Enter Message:";
        this.inputTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // outputTitleLabel
        // 
        this.outputTitleLabel.AutoSize = true;
        this.outputTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        this.outputTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.outputTitleLabel.Location = new System.Drawing.Point(3, 225);
        this.outputTitleLabel.Name = "outputTitleLabel";
        this.outputTitleLabel.Size = new System.Drawing.Size(794, 45);
        this.outputTitleLabel.TabIndex = 3;
        this.outputTitleLabel.Text = "Message from App 2:";
        this.outputTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.tableLayoutPanel1);
        this.Name = "Form1";
        this.Text = "Form1";
        this.tableLayoutPanel1.ResumeLayout(false);
        this.tableLayoutPanel1.PerformLayout();
        this.ResumeLayout(false);

        #endregion
    }

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TextBox inputTextBox;
    private System.Windows.Forms.Label outputLabel;
    private System.Windows.Forms.Label inputTitleLabel;
    private System.Windows.Forms.Label outputTitleLabel;

}
