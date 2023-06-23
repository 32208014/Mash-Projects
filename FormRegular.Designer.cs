namespace safeprojectname$safeprojectname$
{
    partial class FormRegular
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegular));
        this.label1 = new System.Windows.Forms.Label();
        this.btnDone = new System.Windows.Forms.Button();
        this.btnHome3 = new System.Windows.Forms.Button();
        this.groupBoxCheckConditions = new System.Windows.Forms.GroupBox();
        this.label3 = new System.Windows.Forms.Label();
        this.txtBxOtherIllnesses = new System.Windows.Forms.TextBox();
        this.label2 = new System.Windows.Forms.Label();
        this.listBox1 = new System.Windows.Forms.ListBox();
        this.BtnBack = new System.Windows.Forms.Button();
        this.label4 = new System.Windows.Forms.Label();
        this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
        this.ttxBxidnum = new System.Windows.Forms.TextBox();
        this.label5 = new System.Windows.Forms.Label();
        this.groupBoxCheckConditions.SuspendLayout();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.BackColor = System.Drawing.Color.Transparent;
        this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label1.Location = new System.Drawing.Point(12, 77);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(238, 17);
        this.label1.TabIndex = 0;
        this.label1.Text = "Date of last Check Up (dd/mm/yyyy):";
        // 
        // btnDone
        // 
        this.btnDone.BackColor = System.Drawing.Color.MidnightBlue;
        this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        this.btnDone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnDone.ForeColor = System.Drawing.Color.White;
        this.btnDone.Location = new System.Drawing.Point(353, 391);
        this.btnDone.Name = "btnDone";
        this.btnDone.Size = new System.Drawing.Size(179, 33);
        this.btnDone.TabIndex = 2;
        this.btnDone.Text = "Done";
        this.btnDone.UseVisualStyleBackColor = false;
        this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
        // 
        // btnHome3
        // 
        this.btnHome3.BackColor = System.Drawing.Color.MidnightBlue;
        this.btnHome3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        this.btnHome3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnHome3.ForeColor = System.Drawing.Color.White;
        this.btnHome3.Location = new System.Drawing.Point(34, 356);
        this.btnHome3.Name = "btnHome3";
        this.btnHome3.Size = new System.Drawing.Size(179, 35);
        this.btnHome3.TabIndex = 3;
        this.btnHome3.Text = "Home";
        this.btnHome3.UseVisualStyleBackColor = false;
        this.btnHome3.Click += new System.EventHandler(this.btnHome3_Click);
        // 
        // groupBoxCheckConditions
        // 
        this.groupBoxCheckConditions.Controls.Add(this.label3);
        this.groupBoxCheckConditions.Controls.Add(this.txtBxOtherIllnesses);
        this.groupBoxCheckConditions.Controls.Add(this.label2);
        this.groupBoxCheckConditions.Controls.Add(this.btnDone);
        this.groupBoxCheckConditions.Controls.Add(this.listBox1);
        this.groupBoxCheckConditions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.groupBoxCheckConditions.Location = new System.Drawing.Point(269, 64);
        this.groupBoxCheckConditions.Name = "groupBoxCheckConditions";
        this.groupBoxCheckConditions.Size = new System.Drawing.Size(538, 430);
        this.groupBoxCheckConditions.TabIndex = 4;
        this.groupBoxCheckConditions.TabStop = false;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.BackColor = System.Drawing.Color.White;
        this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label3.Location = new System.Drawing.Point(13, 358);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(100, 16);
        this.label3.TabIndex = 3;
        this.label3.Text = "If Other,Specify:";
        // 
        // txtBxOtherIllnesses
        // 
        this.txtBxOtherIllnesses.Location = new System.Drawing.Point(119, 354);
        this.txtBxOtherIllnesses.Name = "txtBxOtherIllnesses";
        this.txtBxOtherIllnesses.Size = new System.Drawing.Size(173, 20);
        this.txtBxOtherIllnesses.TabIndex = 2;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label2.Location = new System.Drawing.Point(12, 31);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(290, 20);
        this.label2.TabIndex = 1;
        this.label2.Text = "Check The Conditions that Apply to you:";
        // 
        // listBox1
        // 
        this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.listBox1.FormattingEnabled = true;
        this.listBox1.ItemHeight = 24;
        this.listBox1.Location = new System.Drawing.Point(15, 59);
        this.listBox1.Name = "listBox1";
        this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
        this.listBox1.Size = new System.Drawing.Size(277, 268);
        this.listBox1.TabIndex = 0;
        this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
        // 
        // BtnBack
        // 
        this.BtnBack.BackColor = System.Drawing.Color.MidnightBlue;
        this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        this.BtnBack.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.BtnBack.ForeColor = System.Drawing.Color.White;
        this.BtnBack.Location = new System.Drawing.Point(34, 309);
        this.BtnBack.Name = "BtnBack";
        this.BtnBack.Size = new System.Drawing.Size(179, 32);
        this.BtnBack.TabIndex = 4;
        this.BtnBack.Text = "Back";
        this.BtnBack.UseVisualStyleBackColor = false;
        this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.BackColor = System.Drawing.Color.Transparent;
        this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label4.Location = new System.Drawing.Point(12, 136);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(76, 17);
        this.label4.TabIndex = 5;
        this.label4.Text = "ID Number";
        // 
        // dateTimePicker1
        // 
        this.dateTimePicker1.Location = new System.Drawing.Point(15, 95);
        this.dateTimePicker1.Name = "dateTimePicker1";
        this.dateTimePicker1.Size = new System.Drawing.Size(235, 20);
        this.dateTimePicker1.TabIndex = 30;
        // 
        // ttxBxidnum
        // 
        this.ttxBxidnum.Location = new System.Drawing.Point(15, 156);
        this.ttxBxidnum.Name = "ttxBxidnum";
        this.ttxBxidnum.Size = new System.Drawing.Size(179, 20);
        this.ttxBxidnum.TabIndex = 32;
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.BackColor = System.Drawing.Color.Transparent;
        this.label5.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label5.ForeColor = System.Drawing.Color.Black;
        this.label5.Location = new System.Drawing.Point(95, 9);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(304, 32);
        this.label5.TabIndex = 33;
        this.label5.Text = "REGULAR CHECK-UP";
        // 
        // FormRegular
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.White;
        this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
        this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        this.ClientSize = new System.Drawing.Size(828, 506);
        this.Controls.Add(this.label5);
        this.Controls.Add(this.ttxBxidnum);
        this.Controls.Add(this.dateTimePicker1);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.BtnBack);
        this.Controls.Add(this.groupBoxCheckConditions);
        this.Controls.Add(this.btnHome3);
        this.Controls.Add(this.label1);
        this.Name = "FormRegular";
        this.Text = "FormRegular";
        this.groupBoxCheckConditions.ResumeLayout(false);
        this.groupBoxCheckConditions.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnDone;
    private System.Windows.Forms.Button btnHome3;
    private System.Windows.Forms.GroupBox groupBoxCheckConditions;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtBxOtherIllnesses;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Button BtnBack;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.TextBox ttxBxidnum;
    private System.Windows.Forms.Label label5;
}
}