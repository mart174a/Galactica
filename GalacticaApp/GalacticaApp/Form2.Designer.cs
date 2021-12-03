namespace GalacticaApp
{
    partial class Form2
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
            this.planetListBox = new System.Windows.Forms.ListBox();
            this.boolGasGiant = new System.Windows.Forms.CheckBox();
            this.boolDwarfPlanet = new System.Windows.Forms.CheckBox();
            this.boolGiant = new System.Windows.Forms.CheckBox();
            this.boolTerrestial = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.moonsTable = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.planetMainTitle = new System.Windows.Forms.Label();
            this.planetTable = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.starMainTable = new System.Windows.Forms.Label();
            this.starTable = new System.Windows.Forms.TableLayoutPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.planetTable.SuspendLayout();
            this.starTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // planetListBox
            // 
            this.planetListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.planetListBox.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planetListBox.FormattingEnabled = true;
            this.planetListBox.ItemHeight = 25;
            this.planetListBox.Location = new System.Drawing.Point(47, 132);
            this.planetListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.planetListBox.Name = "planetListBox";
            this.planetListBox.Size = new System.Drawing.Size(190, 400);
            this.planetListBox.TabIndex = 6;
            this.planetListBox.SelectedIndexChanged += new System.EventHandler(this.planetListBox_SelectedIndexChanged);
            // 
            // boolGasGiant
            // 
            this.boolGasGiant.AutoSize = true;
            this.boolGasGiant.Checked = true;
            this.boolGasGiant.CheckState = System.Windows.Forms.CheckState.Checked;
            this.boolGasGiant.Font = new System.Drawing.Font("Ebrima", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boolGasGiant.Location = new System.Drawing.Point(154, 105);
            this.boolGasGiant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boolGasGiant.Name = "boolGasGiant";
            this.boolGasGiant.Size = new System.Drawing.Size(76, 17);
            this.boolGasGiant.TabIndex = 16;
            this.boolGasGiant.Text = "Gas Giant";
            this.boolGasGiant.UseVisualStyleBackColor = true;
            this.boolGasGiant.CheckedChanged += new System.EventHandler(this.PlanetBool_CheckedChanged);
            // 
            // boolDwarfPlanet
            // 
            this.boolDwarfPlanet.AutoSize = true;
            this.boolDwarfPlanet.Checked = true;
            this.boolDwarfPlanet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.boolDwarfPlanet.Font = new System.Drawing.Font("Ebrima", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boolDwarfPlanet.Location = new System.Drawing.Point(56, 105);
            this.boolDwarfPlanet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boolDwarfPlanet.Name = "boolDwarfPlanet";
            this.boolDwarfPlanet.Size = new System.Drawing.Size(57, 17);
            this.boolDwarfPlanet.TabIndex = 15;
            this.boolDwarfPlanet.Text = "Dwarf";
            this.boolDwarfPlanet.UseVisualStyleBackColor = true;
            this.boolDwarfPlanet.CheckedChanged += new System.EventHandler(this.PlanetBool_CheckedChanged);
            // 
            // boolGiant
            // 
            this.boolGiant.AutoSize = true;
            this.boolGiant.Checked = true;
            this.boolGiant.CheckState = System.Windows.Forms.CheckState.Checked;
            this.boolGiant.Font = new System.Drawing.Font("Ebrima", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boolGiant.Location = new System.Drawing.Point(154, 82);
            this.boolGiant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boolGiant.Name = "boolGiant";
            this.boolGiant.Size = new System.Drawing.Size(54, 17);
            this.boolGiant.TabIndex = 14;
            this.boolGiant.Text = "Giant";
            this.boolGiant.UseVisualStyleBackColor = true;
            this.boolGiant.CheckedChanged += new System.EventHandler(this.PlanetBool_CheckedChanged);
            // 
            // boolTerrestial
            // 
            this.boolTerrestial.AutoSize = true;
            this.boolTerrestial.Checked = true;
            this.boolTerrestial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.boolTerrestial.Font = new System.Drawing.Font("Ebrima", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boolTerrestial.Location = new System.Drawing.Point(56, 82);
            this.boolTerrestial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boolTerrestial.Name = "boolTerrestial";
            this.boolTerrestial.Size = new System.Drawing.Size(73, 17);
            this.boolTerrestial.TabIndex = 13;
            this.boolTerrestial.Text = "Terrestial";
            this.boolTerrestial.UseVisualStyleBackColor = true;
            this.boolTerrestial.CheckedChanged += new System.EventHandler(this.PlanetBool_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 40);
            this.label2.TabIndex = 20;
            this.label2.Text = "Planets";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // moonsTable
            // 
            this.moonsTable.BackColor = System.Drawing.SystemColors.Window;
            this.moonsTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.moonsTable.ColumnCount = 5;
            this.moonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.moonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.moonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.moonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.moonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.moonsTable.Location = new System.Drawing.Point(336, 431);
            this.moonsTable.Margin = new System.Windows.Forms.Padding(0);
            this.moonsTable.Name = "moonsTable";
            this.moonsTable.RowCount = 1;
            this.moonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.moonsTable.Size = new System.Drawing.Size(591, 32);
            this.moonsTable.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Ebrima", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(336, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(591, 43);
            this.label11.TabIndex = 26;
            this.label11.Text = "Moons";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(336, 377);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(591, 53);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(357, 1);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 51);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rotation Period";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(475, 1);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 51);
            this.label5.TabIndex = 4;
            this.label5.Text = "Revolution Period";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(239, 1);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 51);
            this.label8.TabIndex = 3;
            this.label8.Text = "Diameter";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 1);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 51);
            this.label9.TabIndex = 2;
            this.label9.Text = "Name";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(121, 1);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 51);
            this.label10.TabIndex = 0;
            this.label10.Text = "Distance To Planet";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // planetMainTitle
            // 
            this.planetMainTitle.Font = new System.Drawing.Font("Ebrima", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planetMainTitle.Location = new System.Drawing.Point(312, 178);
            this.planetMainTitle.Name = "planetMainTitle";
            this.planetMainTitle.Size = new System.Drawing.Size(631, 54);
            this.planetMainTitle.TabIndex = 23;
            this.planetMainTitle.Text = "mainTitle";
            this.planetMainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // planetTable
            // 
            this.planetTable.BackColor = System.Drawing.SystemColors.Window;
            this.planetTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.planetTable.ColumnCount = 5;
            this.planetTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.planetTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.planetTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.planetTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.planetTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.planetTable.Controls.Add(this.label7, 0, 0);
            this.planetTable.Controls.Add(this.label6, 0, 0);
            this.planetTable.Controls.Add(this.label12, 0, 0);
            this.planetTable.Controls.Add(this.label13, 0, 0);
            this.planetTable.Controls.Add(this.label14, 0, 0);
            this.planetTable.Location = new System.Drawing.Point(312, 233);
            this.planetTable.Margin = new System.Windows.Forms.Padding(0);
            this.planetTable.Name = "planetTable";
            this.planetTable.RowCount = 2;
            this.planetTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.planetTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.planetTable.Size = new System.Drawing.Size(631, 86);
            this.planetTable.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(381, 1);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 53);
            this.label7.TabIndex = 5;
            this.label7.Text = "Rotation Period";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(507, 1);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 53);
            this.label6.TabIndex = 4;
            this.label6.Text = "Revolution Period";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(255, 1);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 53);
            this.label12.TabIndex = 3;
            this.label12.Text = "Diameter";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 1);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 53);
            this.label13.TabIndex = 2;
            this.label13.Text = "Distance To Star";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(129, 1);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 53);
            this.label14.TabIndex = 0;
            this.label14.Text = "Planet Type";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // starMainTable
            // 
            this.starMainTable.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starMainTable.Location = new System.Drawing.Point(456, 32);
            this.starMainTable.Name = "starMainTable";
            this.starMainTable.Size = new System.Drawing.Size(339, 39);
            this.starMainTable.TabIndex = 28;
            this.starMainTable.Text = "Star";
            this.starMainTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // starTable
            // 
            this.starTable.BackColor = System.Drawing.SystemColors.Window;
            this.starTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.starTable.ColumnCount = 3;
            this.starTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.starTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.starTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.starTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.starTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.starTable.Controls.Add(this.label17, 0, 0);
            this.starTable.Controls.Add(this.label19, 0, 0);
            this.starTable.Controls.Add(this.label1, 2, 0);
            this.starTable.Location = new System.Drawing.Point(459, 71);
            this.starTable.Margin = new System.Windows.Forms.Padding(0);
            this.starTable.Name = "starTable";
            this.starTable.RowCount = 2;
            this.starTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.starTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.starTable.Size = new System.Drawing.Size(339, 66);
            this.starTable.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(115, 1);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 35);
            this.label17.TabIndex = 3;
            this.label17.Text = "Star Type";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(3, 1);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(107, 35);
            this.label19.TabIndex = 0;
            this.label19.Text = "Name";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Temperature";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.starMainTable);
            this.Controls.Add(this.starTable);
            this.Controls.Add(this.moonsTable);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.planetMainTitle);
            this.Controls.Add(this.planetTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boolGasGiant);
            this.Controls.Add(this.boolDwarfPlanet);
            this.Controls.Add(this.boolGiant);
            this.Controls.Add(this.boolTerrestial);
            this.Controls.Add(this.planetListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.planetTable.ResumeLayout(false);
            this.planetTable.PerformLayout();
            this.starTable.ResumeLayout(false);
            this.starTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox planetListBox;
        private System.Windows.Forms.CheckBox boolGasGiant;
        private System.Windows.Forms.CheckBox boolDwarfPlanet;
        private System.Windows.Forms.CheckBox boolGiant;
        private System.Windows.Forms.CheckBox boolTerrestial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel moonsTable;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label planetMainTitle;
        private System.Windows.Forms.TableLayoutPanel planetTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label starMainTable;
        private System.Windows.Forms.TableLayoutPanel starTable;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label1;
    }
}