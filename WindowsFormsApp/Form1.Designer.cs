namespace WindowsFormsApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.GroupBox groupBoxProductions;
        private System.Windows.Forms.ListBox listBoxProductions;
        private System.Windows.Forms.FlowLayoutPanel flowAddProduction;
        private System.Windows.Forms.Button buttonAddPowerStation;
        private System.Windows.Forms.Button buttonAddCoalMine;
        private System.Windows.Forms.Button buttonAddIronMine;
        private System.Windows.Forms.Button buttonAddOilWell;
        private System.Windows.Forms.Button buttonAddSteelPlant;
        private System.Windows.Forms.Button buttonAddOilRefinery;
        private System.Windows.Forms.Button buttonAddApplianceFactory;
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxProductions = new System.Windows.Forms.GroupBox();
            this.listBoxProductions = new System.Windows.Forms.ListBox();
            this.flowAddProduction = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddPowerStation = new System.Windows.Forms.Button();
            this.buttonAddCoalMine = new System.Windows.Forms.Button();
            this.buttonAddIronMine = new System.Windows.Forms.Button();
            this.buttonAddOilWell = new System.Windows.Forms.Button();
            this.buttonAddSteelPlant = new System.Windows.Forms.Button();
            this.buttonAddOilRefinery = new System.Windows.Forms.Button();
            this.buttonAddApplianceFactory = new System.Windows.Forms.Button();
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
            this.panelHeader.SuspendLayout();
            this.tableLayoutMain.SuspendLayout();
            this.groupBoxProductions.SuspendLayout();
            this.flowAddProduction.SuspendLayout();
            this.groupBoxWarehouse.SuspendLayout();
            this.groupBoxLog.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDays)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.panelHeader.Size = new System.Drawing.Size(1307, 56);
            this.panelHeader.TabIndex = 3;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(16, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Padding = new System.Windows.Forms.Padding(0, 16, 0, 0);
            this.labelHeader.Size = new System.Drawing.Size(252, 48);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Симулятор концерну";
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
            this.tableLayoutMain.Location = new System.Drawing.Point(0, 56);
            this.tableLayoutMain.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.Padding = new System.Windows.Forms.Padding(12, 12, 12, 8);
            this.tableLayoutMain.RowCount = 1;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMain.Size = new System.Drawing.Size(1307, 643);
            this.tableLayoutMain.TabIndex = 0;
            // 
            // groupBoxProductions
            // 
            this.groupBoxProductions.Controls.Add(this.listBoxProductions);
            this.groupBoxProductions.Controls.Add(this.flowAddProduction);
            this.groupBoxProductions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxProductions.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.groupBoxProductions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.groupBoxProductions.Location = new System.Drawing.Point(16, 16);
            this.groupBoxProductions.Margin = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.groupBoxProductions.Name = "groupBoxProductions";
            this.groupBoxProductions.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            this.groupBoxProductions.Size = new System.Drawing.Size(334, 615);
            this.groupBoxProductions.TabIndex = 0;
            this.groupBoxProductions.TabStop = false;
            this.groupBoxProductions.Text = "Підприємства";
            // 
            // listBoxProductions
            // 
            this.listBoxProductions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxProductions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxProductions.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.listBoxProductions.FormattingEnabled = true;
            this.listBoxProductions.ItemHeight = 21;
            this.listBoxProductions.Location = new System.Drawing.Point(10, 30);
            this.listBoxProductions.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxProductions.Name = "listBoxProductions";
            this.listBoxProductions.Size = new System.Drawing.Size(314, 427);
            this.listBoxProductions.TabIndex = 0;
            this.listBoxProductions.SelectedIndexChanged += new System.EventHandler(this.listBoxProductions_SelectedIndexChanged);
            // 
            // flowAddProduction
            // 
            this.flowAddProduction.Controls.Add(this.buttonAddPowerStation);
            this.flowAddProduction.Controls.Add(this.buttonAddCoalMine);
            this.flowAddProduction.Controls.Add(this.buttonAddIronMine);
            this.flowAddProduction.Controls.Add(this.buttonAddOilWell);
            this.flowAddProduction.Controls.Add(this.buttonAddSteelPlant);
            this.flowAddProduction.Controls.Add(this.buttonAddOilRefinery);
            this.flowAddProduction.Controls.Add(this.buttonAddApplianceFactory);
            this.flowAddProduction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowAddProduction.Location = new System.Drawing.Point(10, 457);
            this.flowAddProduction.Name = "flowAddProduction";
            this.flowAddProduction.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.flowAddProduction.Size = new System.Drawing.Size(314, 148);
            this.flowAddProduction.TabIndex = 1;
            // 
            // buttonAddPowerStation
            // 
            this.buttonAddPowerStation.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.buttonAddPowerStation.Location = new System.Drawing.Point(0, 6);
            this.buttonAddPowerStation.Margin = new System.Windows.Forms.Padding(0, 0, 6, 6);
            this.buttonAddPowerStation.Name = "buttonAddPowerStation";
            this.buttonAddPowerStation.Size = new System.Drawing.Size(150, 28);
            this.buttonAddPowerStation.TabIndex = 0;
            this.buttonAddPowerStation.Text = "+ Електростанція";
            this.buttonAddPowerStation.UseVisualStyleBackColor = true;
            this.buttonAddPowerStation.Click += new System.EventHandler(this.buttonAddPowerStation_Click);
            // 
            // buttonAddCoalMine
            // 
            this.buttonAddCoalMine.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.buttonAddCoalMine.Location = new System.Drawing.Point(156, 6);
            this.buttonAddCoalMine.Margin = new System.Windows.Forms.Padding(0, 0, 6, 6);
            this.buttonAddCoalMine.Name = "buttonAddCoalMine";
            this.buttonAddCoalMine.Size = new System.Drawing.Size(150, 28);
            this.buttonAddCoalMine.TabIndex = 1;
            this.buttonAddCoalMine.Text = "+ Вугільна шахта";
            this.buttonAddCoalMine.UseVisualStyleBackColor = true;
            this.buttonAddCoalMine.Click += new System.EventHandler(this.buttonAddCoalMine_Click);
            // 
            // buttonAddIronMine
            // 
            this.buttonAddIronMine.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.buttonAddIronMine.Location = new System.Drawing.Point(0, 40);
            this.buttonAddIronMine.Margin = new System.Windows.Forms.Padding(0, 0, 6, 6);
            this.buttonAddIronMine.Name = "buttonAddIronMine";
            this.buttonAddIronMine.Size = new System.Drawing.Size(150, 28);
            this.buttonAddIronMine.TabIndex = 2;
            this.buttonAddIronMine.Text = "+ Залізна шахта";
            this.buttonAddIronMine.UseVisualStyleBackColor = true;
            this.buttonAddIronMine.Click += new System.EventHandler(this.buttonAddIronMine_Click);
            // 
            // buttonAddOilWell
            // 
            this.buttonAddOilWell.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.buttonAddOilWell.Location = new System.Drawing.Point(156, 40);
            this.buttonAddOilWell.Margin = new System.Windows.Forms.Padding(0, 0, 6, 6);
            this.buttonAddOilWell.Name = "buttonAddOilWell";
            this.buttonAddOilWell.Size = new System.Drawing.Size(150, 28);
            this.buttonAddOilWell.TabIndex = 3;
            this.buttonAddOilWell.Text = "+ Свердловина";
            this.buttonAddOilWell.UseVisualStyleBackColor = true;
            this.buttonAddOilWell.Click += new System.EventHandler(this.buttonAddOilWell_Click);
            // 
            // buttonAddSteelPlant
            // 
            this.buttonAddSteelPlant.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.buttonAddSteelPlant.Location = new System.Drawing.Point(0, 74);
            this.buttonAddSteelPlant.Margin = new System.Windows.Forms.Padding(0, 0, 6, 6);
            this.buttonAddSteelPlant.Name = "buttonAddSteelPlant";
            this.buttonAddSteelPlant.Size = new System.Drawing.Size(150, 28);
            this.buttonAddSteelPlant.TabIndex = 4;
            this.buttonAddSteelPlant.Text = "+ Сталеливарний";
            this.buttonAddSteelPlant.UseVisualStyleBackColor = true;
            this.buttonAddSteelPlant.Click += new System.EventHandler(this.buttonAddSteelPlant_Click);
            // 
            // buttonAddOilRefinery
            // 
            this.buttonAddOilRefinery.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.buttonAddOilRefinery.Location = new System.Drawing.Point(156, 74);
            this.buttonAddOilRefinery.Margin = new System.Windows.Forms.Padding(0, 0, 6, 6);
            this.buttonAddOilRefinery.Name = "buttonAddOilRefinery";
            this.buttonAddOilRefinery.Size = new System.Drawing.Size(150, 28);
            this.buttonAddOilRefinery.TabIndex = 5;
            this.buttonAddOilRefinery.Text = "+ Нафтопереробний";
            this.buttonAddOilRefinery.UseVisualStyleBackColor = true;
            this.buttonAddOilRefinery.Click += new System.EventHandler(this.buttonAddOilRefinery_Click);
            // 
            // buttonAddApplianceFactory
            // 
            this.buttonAddApplianceFactory.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.buttonAddApplianceFactory.Location = new System.Drawing.Point(0, 108);
            this.buttonAddApplianceFactory.Margin = new System.Windows.Forms.Padding(0, 0, 6, 6);
            this.buttonAddApplianceFactory.Name = "buttonAddApplianceFactory";
            this.buttonAddApplianceFactory.Size = new System.Drawing.Size(150, 28);
            this.buttonAddApplianceFactory.TabIndex = 6;
            this.buttonAddApplianceFactory.Text = "+ Завод техніки";
            this.buttonAddApplianceFactory.UseVisualStyleBackColor = true;
            this.buttonAddApplianceFactory.Click += new System.EventHandler(this.buttonAddApplianceFactory_Click);
            // 
            // groupBoxWarehouse
            // 
            this.groupBoxWarehouse.Controls.Add(this.listViewWarehouse);
            this.groupBoxWarehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxWarehouse.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.groupBoxWarehouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.groupBoxWarehouse.Location = new System.Drawing.Point(362, 16);
            this.groupBoxWarehouse.Margin = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.groupBoxWarehouse.Name = "groupBoxWarehouse";
            this.groupBoxWarehouse.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            this.groupBoxWarehouse.Size = new System.Drawing.Size(334, 615);
            this.groupBoxWarehouse.TabIndex = 1;
            this.groupBoxWarehouse.TabStop = false;
            this.groupBoxWarehouse.Text = "Склад";
            // 
            // listViewWarehouse
            // 
            this.listViewWarehouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewWarehouse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colResource,
            this.colAmount});
            this.listViewWarehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewWarehouse.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.listViewWarehouse.FullRowSelect = true;
            this.listViewWarehouse.GridLines = true;
            this.listViewWarehouse.HideSelection = false;
            this.listViewWarehouse.Location = new System.Drawing.Point(10, 30);
            this.listViewWarehouse.Margin = new System.Windows.Forms.Padding(4);
            this.listViewWarehouse.Name = "listViewWarehouse";
            this.listViewWarehouse.Size = new System.Drawing.Size(314, 575);
            this.listViewWarehouse.TabIndex = 0;
            this.listViewWarehouse.UseCompatibleStateImageBehavior = false;
            this.listViewWarehouse.View = System.Windows.Forms.View.Details;
            this.listViewWarehouse.SelectedIndexChanged += new System.EventHandler(this.listViewWarehouse_SelectedIndexChanged);
            // 
            // colResource
            // 
            this.colResource.Text = "Ресурс";
            this.colResource.Width = 150;
            // 
            // colAmount
            // 
            this.colAmount.Text = "Кількість";
            this.colAmount.Width = 90;
            // 
            // groupBoxLog
            // 
            this.groupBoxLog.Controls.Add(this.richTextBoxLog);
            this.groupBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxLog.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.groupBoxLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.groupBoxLog.Location = new System.Drawing.Point(712, 16);
            this.groupBoxLog.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.groupBoxLog.Name = "groupBoxLog";
            this.groupBoxLog.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            this.groupBoxLog.Size = new System.Drawing.Size(579, 615);
            this.groupBoxLog.TabIndex = 2;
            this.groupBoxLog.TabStop = false;
            this.groupBoxLog.Text = "Журнал симуляції";
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.BackColor = System.Drawing.Color.White;
            this.richTextBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxLog.Font = new System.Drawing.Font("Consolas", 9.5F);
            this.richTextBoxLog.Location = new System.Drawing.Point(10, 30);
            this.richTextBoxLog.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.ReadOnly = true;
            this.richTextBoxLog.Size = new System.Drawing.Size(559, 575);
            this.richTextBoxLog.TabIndex = 0;
            this.richTextBoxLog.Text = "";
            this.richTextBoxLog.TextChanged += new System.EventHandler(this.richTextBoxLog_TextChanged);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.panelBottom.Controls.Add(this.buttonRun);
            this.panelBottom.Controls.Add(this.numericUpDownDays);
            this.panelBottom.Controls.Add(this.labelDays);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 699);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(4);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.panelBottom.Size = new System.Drawing.Size(1307, 64);
            this.panelBottom.TabIndex = 1;
            // 
            // buttonRun
            // 
            this.buttonRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRun.FlatAppearance.BorderSize = 0;
            this.buttonRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRun.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.buttonRun.ForeColor = System.Drawing.Color.White;
            this.buttonRun.Location = new System.Drawing.Point(270, 12);
            this.buttonRun.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(280, 40);
            this.buttonRun.TabIndex = 0;
            this.buttonRun.Text = "▶  Запустити симуляцію";
            this.buttonRun.UseVisualStyleBackColor = false;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            this.buttonRun.MouseEnter += new System.EventHandler(this.buttonRun_MouseEnter);
            this.buttonRun.MouseLeave += new System.EventHandler(this.buttonRun_MouseLeave);
            // 
            // numericUpDownDays
            // 
            this.numericUpDownDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownDays.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numericUpDownDays.Location = new System.Drawing.Point(160, 18);
            this.numericUpDownDays.Margin = new System.Windows.Forms.Padding(4);
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
            this.numericUpDownDays.Size = new System.Drawing.Size(90, 29);
            this.numericUpDownDays.TabIndex = 1;
            this.numericUpDownDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownDays.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelDays.Location = new System.Drawing.Point(16, 22);
            this.labelDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(110, 21);
            this.labelDays.TabIndex = 2;
            this.labelDays.Text = "Кількість днів:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1307, 763);
            this.Controls.Add(this.tableLayoutMain);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(927, 580);
            this.Name = "Form1";
            this.Text = "Симулятор концерну";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tableLayoutMain.ResumeLayout(false);
            this.groupBoxProductions.ResumeLayout(false);
            this.flowAddProduction.ResumeLayout(false);
            this.groupBoxWarehouse.ResumeLayout(false);
            this.groupBoxLog.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDays)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
