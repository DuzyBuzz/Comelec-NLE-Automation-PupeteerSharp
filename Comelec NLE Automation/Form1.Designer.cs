namespace Comelec_NLE_Automation
{
    partial class NLE_automation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NLE_automation));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label7 = new Label();
            label5 = new Label();
            barangayComboBox = new ComboBox();
            label4 = new Label();
            cityMunicipalityComboBox = new ComboBox();
            label3 = new Label();
            districtProvinceComboBox = new ComboBox();
            label2 = new Label();
            regionComboBox = new ComboBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            resultTextBox = new TextBox();
            panel5 = new Panel();
            turnoutCheckBox = new CheckBox();
            validBallotsCastCheckBox = new CheckBox();
            votersVotedCheckBox = new CheckBox();
            registeredVotersCheckBox = new CheckBox();
            absententionsCheckBox = new CheckBox();
            pricinctsClusterCheckBox = new CheckBox();
            votingCenterCheckBox = new CheckBox();
            machineIDCheckBox = new CheckBox();
            panel4 = new Panel();
            panel7 = new Panel();
            label20 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel6 = new Panel();
            nationalPositionsDGV = new DataGridView();
            candidateColumnTextBox = new DataGridViewTextBoxColumn();
            votesColumnCheckBox = new DataGridViewCheckBoxColumn();
            percentageColumnCheckBox = new DataGridViewCheckBoxColumn();
            deleteColumnButton = new DataGridViewButtonColumn();
            panel8 = new Panel();
            label21 = new Label();
            clearButton = new Button();
            button1 = new Button();
            generateButton = new Button();
            pictureBox2 = new PictureBox();
            filterTextBox = new TextBox();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nationalPositionsDGV).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(filterTextBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(barangayComboBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cityMunicipalityComboBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(districtProvinceComboBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(regionComboBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(307, 630);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F);
            label7.Location = new Point(10, 19);
            label7.Name = "label7";
            label7.Size = new Size(282, 16);
            label7.TabIndex = 12;
            label7.Text = "Select geographical level and voting jurisdiction:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F);
            label5.Location = new Point(10, 354);
            label5.Name = "label5";
            label5.Size = new Size(66, 16);
            label5.TabIndex = 9;
            label5.Text = "Barangay:";
            // 
            // barangayComboBox
            // 
            barangayComboBox.Font = new Font("Arial", 9.75F);
            barangayComboBox.FormattingEnabled = true;
            barangayComboBox.Location = new Point(10, 372);
            barangayComboBox.Name = "barangayComboBox";
            barangayComboBox.Size = new Size(238, 24);
            barangayComboBox.TabIndex = 8;
            barangayComboBox.SelectedIndexChanged += barangayComboBox_SelectedIndexChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F);
            label4.Location = new Point(10, 276);
            label4.Name = "label4";
            label4.Size = new Size(107, 16);
            label4.TabIndex = 7;
            label4.Text = "City/Municipality:";
            // 
            // cityMunicipalityComboBox
            // 
            cityMunicipalityComboBox.Font = new Font("Arial", 9.75F);
            cityMunicipalityComboBox.FormattingEnabled = true;
            cityMunicipalityComboBox.Location = new Point(10, 294);
            cityMunicipalityComboBox.Name = "cityMunicipalityComboBox";
            cityMunicipalityComboBox.Size = new Size(238, 24);
            cityMunicipalityComboBox.TabIndex = 6;
            cityMunicipalityComboBox.SelectedIndexChanged += cityMunicipalityComboBox_SelectedIndexChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F);
            label3.Location = new Point(10, 203);
            label3.Name = "label3";
            label3.Size = new Size(105, 16);
            label3.TabIndex = 5;
            label3.Text = "Province/District:";
            // 
            // districtProvinceComboBox
            // 
            districtProvinceComboBox.Font = new Font("Arial", 9.75F);
            districtProvinceComboBox.FormattingEnabled = true;
            districtProvinceComboBox.Location = new Point(10, 221);
            districtProvinceComboBox.Name = "districtProvinceComboBox";
            districtProvinceComboBox.Size = new Size(238, 24);
            districtProvinceComboBox.TabIndex = 4;
            districtProvinceComboBox.SelectedIndexChanged += districtProvinceComboBox_SelectedIndexChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F);
            label2.Location = new Point(10, 126);
            label2.Name = "label2";
            label2.Size = new Size(51, 16);
            label2.TabIndex = 3;
            label2.Text = "Region:";
            // 
            // regionComboBox
            // 
            regionComboBox.Font = new Font("Arial", 9.75F);
            regionComboBox.FormattingEnabled = true;
            regionComboBox.Items.AddRange(new object[] { "Philippines" });
            regionComboBox.Location = new Point(10, 144);
            regionComboBox.Name = "regionComboBox";
            regionComboBox.Size = new Size(238, 24);
            regionComboBox.TabIndex = 2;
            regionComboBox.SelectedValueChanged += regionComboBox_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F);
            label1.Location = new Point(10, 53);
            label1.Name = "label1";
            label1.Size = new Size(56, 16);
            label1.TabIndex = 1;
            label1.Text = "Country:";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Arial", 9.75F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Philippines" });
            comboBox1.Location = new Point(10, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(238, 24);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Philippines";
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(324, 425);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(696, 193);
            resultTextBox.TabIndex = 13;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(turnoutCheckBox);
            panel5.Controls.Add(validBallotsCastCheckBox);
            panel5.Controls.Add(votersVotedCheckBox);
            panel5.Controls.Add(registeredVotersCheckBox);
            panel5.Controls.Add(absententionsCheckBox);
            panel5.Controls.Add(pricinctsClusterCheckBox);
            panel5.Controls.Add(votingCenterCheckBox);
            panel5.Controls.Add(machineIDCheckBox);
            panel5.Controls.Add(panel4);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(240, 340);
            panel5.TabIndex = 26;
            // 
            // turnoutCheckBox
            // 
            turnoutCheckBox.AutoSize = true;
            turnoutCheckBox.Font = new Font("Arial", 9.75F);
            turnoutCheckBox.Location = new Point(17, 283);
            turnoutCheckBox.Name = "turnoutCheckBox";
            turnoutCheckBox.Size = new Size(93, 20);
            turnoutCheckBox.TabIndex = 35;
            turnoutCheckBox.Text = "Turnout (%)";
            turnoutCheckBox.UseVisualStyleBackColor = true;
            // 
            // validBallotsCastCheckBox
            // 
            validBallotsCastCheckBox.AutoSize = true;
            validBallotsCastCheckBox.Font = new Font("Arial", 9.75F);
            validBallotsCastCheckBox.Location = new Point(17, 253);
            validBallotsCastCheckBox.Name = "validBallotsCastCheckBox";
            validBallotsCastCheckBox.Size = new Size(167, 20);
            validBallotsCastCheckBox.TabIndex = 34;
            validBallotsCastCheckBox.Text = "No. of Valid Ballots Cast";
            validBallotsCastCheckBox.UseVisualStyleBackColor = true;
            // 
            // votersVotedCheckBox
            // 
            votersVotedCheckBox.AutoSize = true;
            votersVotedCheckBox.Font = new Font("Arial", 9.75F);
            votersVotedCheckBox.Location = new Point(17, 223);
            votersVotedCheckBox.Name = "votersVotedCheckBox";
            votersVotedCheckBox.Size = new Size(219, 20);
            votersVotedCheckBox.TabIndex = 33;
            votersVotedCheckBox.Text = "No. of Voters Who Actually Voted";
            votersVotedCheckBox.UseVisualStyleBackColor = true;
            // 
            // registeredVotersCheckBox
            // 
            registeredVotersCheckBox.AutoSize = true;
            registeredVotersCheckBox.Font = new Font("Arial", 9.75F);
            registeredVotersCheckBox.Location = new Point(17, 193);
            registeredVotersCheckBox.Name = "registeredVotersCheckBox";
            registeredVotersCheckBox.Size = new Size(192, 20);
            registeredVotersCheckBox.TabIndex = 32;
            registeredVotersCheckBox.Text = "Number of Registered Voters";
            registeredVotersCheckBox.UseVisualStyleBackColor = true;
            // 
            // absententionsCheckBox
            // 
            absententionsCheckBox.AutoSize = true;
            absententionsCheckBox.Font = new Font("Arial", 9.75F);
            absententionsCheckBox.Location = new Point(17, 163);
            absententionsCheckBox.Name = "absententionsCheckBox";
            absententionsCheckBox.Size = new Size(109, 20);
            absententionsCheckBox.TabIndex = 31;
            absententionsCheckBox.Text = "Absententions";
            absententionsCheckBox.UseVisualStyleBackColor = true;
            // 
            // pricinctsClusterCheckBox
            // 
            pricinctsClusterCheckBox.AutoSize = true;
            pricinctsClusterCheckBox.Font = new Font("Arial", 9.75F);
            pricinctsClusterCheckBox.Location = new Point(17, 133);
            pricinctsClusterCheckBox.Name = "pricinctsClusterCheckBox";
            pricinctsClusterCheckBox.Size = new Size(158, 20);
            pricinctsClusterCheckBox.TabIndex = 30;
            pricinctsClusterCheckBox.Text = "Pricincts in the Cluster";
            pricinctsClusterCheckBox.UseVisualStyleBackColor = true;
            // 
            // votingCenterCheckBox
            // 
            votingCenterCheckBox.AutoSize = true;
            votingCenterCheckBox.Font = new Font("Arial", 9.75F);
            votingCenterCheckBox.Location = new Point(17, 103);
            votingCenterCheckBox.Name = "votingCenterCheckBox";
            votingCenterCheckBox.Size = new Size(104, 20);
            votingCenterCheckBox.TabIndex = 28;
            votingCenterCheckBox.Text = "Voting Center";
            votingCenterCheckBox.UseVisualStyleBackColor = true;
            // 
            // machineIDCheckBox
            // 
            machineIDCheckBox.AutoSize = true;
            machineIDCheckBox.Font = new Font("Arial", 9.75F);
            machineIDCheckBox.Location = new Point(17, 73);
            machineIDCheckBox.Name = "machineIDCheckBox";
            machineIDCheckBox.Size = new Size(91, 20);
            machineIDCheckBox.TabIndex = 26;
            machineIDCheckBox.Text = "Machine ID";
            machineIDCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(label8);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(238, 41);
            panel4.TabIndex = 25;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label20);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(238, 41);
            panel7.TabIndex = 26;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Arial", 15.75F);
            label20.ForeColor = Color.FromArgb(0, 0, 64);
            label20.Location = new Point(6, 9);
            label20.Name = "label20";
            label20.Size = new Size(202, 24);
            label20.TabIndex = 0;
            label20.Text = "Common Information";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(0, 0, 64);
            label8.Location = new Point(6, 9);
            label8.Name = "label8";
            label8.Size = new Size(207, 25);
            label8.TabIndex = 0;
            label8.Text = "Common Information";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(324, 348);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(307, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(725, 344);
            panel2.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(nationalPositionsDGV);
            panel6.Controls.Add(panel8);
            panel6.Dock = DockStyle.Fill;
            panel6.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel6.Location = new Point(240, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(481, 340);
            panel6.TabIndex = 27;
            // 
            // nationalPositionsDGV
            // 
            nationalPositionsDGV.BackgroundColor = SystemColors.ButtonFace;
            nationalPositionsDGV.BorderStyle = BorderStyle.Fixed3D;
            nationalPositionsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            nationalPositionsDGV.Columns.AddRange(new DataGridViewColumn[] { candidateColumnTextBox, votesColumnCheckBox, percentageColumnCheckBox, deleteColumnButton });
            nationalPositionsDGV.Dock = DockStyle.Left;
            nationalPositionsDGV.GridColor = SystemColors.ActiveCaptionText;
            nationalPositionsDGV.Location = new Point(0, 41);
            nationalPositionsDGV.Name = "nationalPositionsDGV";
            nationalPositionsDGV.Size = new Size(461, 297);
            nationalPositionsDGV.TabIndex = 27;
            nationalPositionsDGV.CellContentClick += nationalPositionsDGV_CellContentClick;
            // 
            // candidateColumnTextBox
            // 
            candidateColumnTextBox.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            candidateColumnTextBox.DefaultCellStyle = dataGridViewCellStyle5;
            candidateColumnTextBox.HeaderText = "Candidate";
            candidateColumnTextBox.Name = "candidateColumnTextBox";
            // 
            // votesColumnCheckBox
            // 
            votesColumnCheckBox.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = false;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            votesColumnCheckBox.DefaultCellStyle = dataGridViewCellStyle6;
            votesColumnCheckBox.HeaderText = "Votes";
            votesColumnCheckBox.Name = "votesColumnCheckBox";
            votesColumnCheckBox.Width = 50;
            // 
            // percentageColumnCheckBox
            // 
            percentageColumnCheckBox.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.NullValue = false;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            percentageColumnCheckBox.DefaultCellStyle = dataGridViewCellStyle7;
            percentageColumnCheckBox.HeaderText = "%";
            percentageColumnCheckBox.Name = "percentageColumnCheckBox";
            percentageColumnCheckBox.Width = 50;
            // 
            // deleteColumnButton
            // 
            deleteColumnButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.Salmon;
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.Red;
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            deleteColumnButton.DefaultCellStyle = dataGridViewCellStyle8;
            deleteColumnButton.FlatStyle = FlatStyle.Popup;
            deleteColumnButton.HeaderText = "";
            deleteColumnButton.Name = "deleteColumnButton";
            deleteColumnButton.Resizable = DataGridViewTriState.True;
            deleteColumnButton.SortMode = DataGridViewColumnSortMode.Automatic;
            deleteColumnButton.Text = "Del";
            deleteColumnButton.UseColumnTextForButtonValue = true;
            deleteColumnButton.Width = 30;
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(label21);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(479, 41);
            panel8.TabIndex = 26;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Arial", 15.75F);
            label21.ForeColor = Color.FromArgb(0, 0, 64);
            label21.Location = new Point(6, 9);
            label21.Name = "label21";
            label21.Size = new Size(179, 24);
            label21.TabIndex = 0;
            label21.Text = "National Positions";
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Salmon;
            clearButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            clearButton.ForeColor = Color.White;
            clearButton.Location = new Point(557, 346);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(125, 56);
            clearButton.TabIndex = 21;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(714, 346);
            button1.Name = "button1";
            button1.Size = new Size(125, 56);
            button1.TabIndex = 20;
            button1.Text = "Print";
            button1.UseVisualStyleBackColor = false;
            // 
            // generateButton
            // 
            generateButton.BackColor = Color.SteelBlue;
            generateButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            generateButton.ForeColor = Color.White;
            generateButton.Location = new Point(872, 346);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(125, 56);
            generateButton.TabIndex = 19;
            generateButton.Text = "Generate";
            generateButton.UseVisualStyleBackColor = false;
            generateButton.Click += generateButton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(438, 346);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(94, 56);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // filterTextBox
            // 
            filterTextBox.Location = new Point(10, 446);
            filterTextBox.Multiline = true;
            filterTextBox.Name = "filterTextBox";
            filterTextBox.Size = new Size(282, 86);
            filterTextBox.TabIndex = 13;
            // 
            // NLE_automation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1032, 630);
            Controls.Add(resultTextBox);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(clearButton);
            Controls.Add(button1);
            Controls.Add(generateButton);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NLE_automation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comelec NLE Automation";
            Load += NLE_automation_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nationalPositionsDGV).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private ComboBox cityMunicipalityComboBox;
        private Label label3;
        private ComboBox districtProvinceComboBox;
        private Label label2;
        private ComboBox regionComboBox;
        private Label label1;
        private ComboBox comboBox1;
        private Label label7;
        private Label label5;
        private ComboBox barangayComboBox;
        private Panel panel2;
        private Label label8;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel7;
        private Label label20;
        private DataGridView nationalPositionsDGV;
        private Panel panel8;
        private Label label21;
        private CheckBox turnoutCheckBox;
        private CheckBox validBallotsCastCheckBox;
        private CheckBox votersVotedCheckBox;
        private CheckBox registeredVotersCheckBox;
        private CheckBox absententionsCheckBox;
        private CheckBox pricinctsClusterCheckBox;
        private CheckBox votingCenterCheckBox;
        private CheckBox machineIDCheckBox;
        private Button clearButton;
        private Button button1;
        private Button generateButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn candidateColumnTextBox;
        private DataGridViewCheckBoxColumn votesColumnCheckBox;
        private DataGridViewCheckBoxColumn percentageColumnCheckBox;
        private DataGridViewButtonColumn deleteColumnButton;
        private TextBox resultTextBox;
        private TextBox filterTextBox;
    }
}
