namespace WindowsFormsApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.GroupBox groupBoxProductions;
        private System.Windows.Forms.ListBox listBoxProductions;
        private System.Windows.Forms.GroupBox groupBoxWarehouse;
        private System.Windows.Forms.ListView listViewWarehouse;
        private System.Windows.Forms.ColumnHeader colResource;
        private System.Windows.Forms.ColumnHeader colAmount;
        private System.Windows.Forms.GroupBox groupBoxLog;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.NumericUpDown numericUpDownDays;
        private System.Windows.Forms.Button buttonRun;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxProductions = new System.Windows.Forms.GroupBox();
            this.listBoxProductions = new System.Windows.Forms.ListBox();
            this.groupBoxWarehouse = new System.Windows.Forms.GroupBox();
            this.listViewWarehouse = new System.Windows.Forms.ListView();
            this.colResource = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxLog = new System.Windows.Forms.GroupBox();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.buttonRun = new System.Windows.Forms.Button();
            this.numericUpDownDays = new System.Windows.Forms.NumericUpDown();
            this.labelDays = new System.Windows.Forms.Label();
            this.tableLayoutMain.SuspendLayout();
            this.groupBoxProductions.SuspendLayout();
            this.groupBoxWarehouse.SuspendLayout();
            this.groupBoxLog.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDays)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.ColumnCount = 3;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this.tableLayoutMain.Controls.Add(this.groupBoxProductions, 0, 0);
            this.tableLayoutMain.Controls.Add(this.groupBoxWarehouse, 1, 0);
            this.tableLayoutMain.Controls.Add(this.groupBoxLog, 2, 0);
            this.tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableLayoutMain.RowCount = 1;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMain.Size = new System.Drawing.Size(1307, 699);
            this.tableLayoutMain.TabIndex = 0;
            // 
            // groupBoxProductions
            // 
            this.groupBoxProductions.Controls.Add(this.listBoxProductions);
            this.groupBoxProductions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxProductions.Location = new System.Drawing.Point(12, 11);
            this.groupBoxProductions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxProductions.Name = "groupBoxProductions";
            this.groupBoxProductions.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBoxProductions.Size = new System.Drawing.Size(340, 677);
            this.groupBoxProductions.TabIndex = 0;
            this.groupBoxProductions.TabStop = false;
            this.groupBoxProductions.Text = "Підприємства";
            // 
            // listBoxProductions
            // 
            this.listBoxProductions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxProductions.ItemHeight = 16;
            this.listBoxProductions.Location = new System.Drawing.Point(7, 21);
            this.listBoxProductions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxProductions.Name = "listBoxProductions";
            this.listBoxProductions.Size = new System.Drawing.Size(326, 650);
            this.listBoxProductions.TabIndex = 0;
            this.listBoxProductions.SelectedIndexChanged += new System.EventHandler(this.listBoxProductions_SelectedIndexChanged);
            // 
            // groupBoxWarehouse
            // 
            this.groupBoxWarehouse.Controls.Add(this.listViewWarehouse);
            this.groupBoxWarehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxWarehouse.Location = new System.Drawing.Point(360, 11);
            this.groupBoxWarehouse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxWarehouse.Name = "groupBoxWarehouse";
            this.groupBoxWarehouse.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBoxWarehouse.Size = new System.Drawing.Size(340, 677);
            this.groupBoxWarehouse.TabIndex = 1;
            this.groupBoxWarehouse.TabStop = false;
            this.groupBoxWarehouse.Text = "Склад";
            // 
            // listViewWarehouse
            // 
            this.listViewWarehouse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colResource,
            this.colAmount});
            this.listViewWarehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewWarehouse.FullRowSelect = true;
            this.listViewWarehouse.GridLines = true;
            this.listViewWarehouse.HideSelection = false;
            this.listViewWarehouse.Location = new System.Drawing.Point(7, 21);
            this.listViewWarehouse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewWarehouse.Name = "listViewWarehouse";
            this.listViewWarehouse.Size = new System.Drawing.Size(326, 650);
            this.listViewWarehouse.TabIndex = 0;
            this.listViewWarehouse.UseCompatibleStateImageBehavior = false;
            this.listViewWarehouse.View = System.Windows.Forms.View.Details;
            // 
            // colResource
            // 
            this.colResource.Text = "Ресурс";
            this.colResource.Width = 130;
            // 
            // colAmount
            // 
            this.colAmount.Text = "Кількість";
            this.colAmount.Width = 80;
            // 
            // groupBoxLog
            // 
            this.groupBoxLog.Controls.Add(this.richTextBoxLog);
            this.groupBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxLog.Location = new System.Drawing.Point(708, 11);
            this.groupBoxLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxLog.Name = "groupBoxLog";
            this.groupBoxLog.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBoxLog.Size = new System.Drawing.Size(587, 677);
            this.groupBoxLog.TabIndex = 2;
            this.groupBoxLog.TabStop = false;
            this.groupBoxLog.Text = "Журнал симуляції";
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.richTextBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxLog.Font = new System.Drawing.Font("Consolas", 9F);
            this.richTextBoxLog.Location = new System.Drawing.Point(7, 21);
            this.richTextBoxLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.ReadOnly = true;
            this.richTextBoxLog.Size = new System.Drawing.Size(573, 650);
            this.richTextBoxLog.TabIndex = 0;
            this.richTextBoxLog.Text = "";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.buttonRun);
            this.panelBottom.Controls.Add(this.numericUpDownDays);
            this.panelBottom.Controls.Add(this.labelDays);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 699);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.panelBottom.Size = new System.Drawing.Size(1307, 64);
            this.panelBottom.TabIndex = 1;
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(267, 14);
            this.buttonRun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(280, 37);
            this.buttonRun.TabIndex = 0;
            this.buttonRun.Text = "▶  Запустити симуляцію";
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // numericUpDownDays
            // 
            this.numericUpDownDays.Location = new System.Drawing.Point(160, 16);
            this.numericUpDownDays.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownDays.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.numericUpDownDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDays.Name = "numericUpDownDays";
            this.numericUpDownDays.Size = new System.Drawing.Size(87, 22);
            this.numericUpDownDays.TabIndex = 1;
            this.numericUpDownDays.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.Location = new System.Drawing.Point(13, 20);
            this.labelDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(97, 16);
            this.labelDays.TabIndex = 2;
            this.labelDays.Text = "Кількість днів:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 763);
            this.Controls.Add(this.tableLayoutMain);
            this.Controls.Add(this.panelBottom);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(927, 580);
            this.Name = "Form1";
            this.Text = "Симулятор концерну";
            this.tableLayoutMain.ResumeLayout(false);
            this.groupBoxProductions.ResumeLayout(false);
            this.groupBoxWarehouse.ResumeLayout(false);
            this.groupBoxLog.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDays)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
