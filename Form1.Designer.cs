namespace REST_API_CALL
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbFieldProjectKey = new System.Windows.Forms.ComboBox();
            this.cmbFieldIssueType = new System.Windows.Forms.ComboBox();
            this.txtFieldSummary = new System.Windows.Forms.TextBox();
            this.txtFieldDescription = new System.Windows.Forms.TextBox();
            this.txtFieldComponents = new System.Windows.Forms.TextBox();
            this.cmbFieldProjectStage = new System.Windows.Forms.ComboBox();
            this.cmbFieldPriority = new System.Windows.Forms.ComboBox();
            this.txtFieldLabels = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPostJira = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(2, 2);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(165, 54);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "SEARCH ISSUES";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(340, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 54);
            this.button2.TabIndex = 15;
            this.button2.Text = "HTML";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 32);
            this.label8.TabIndex = 16;
            this.label8.Text = "Project Key";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 34);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 32);
            this.label9.TabIndex = 17;
            this.label9.Text = "Issue Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 66);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 32);
            this.label10.TabIndex = 18;
            this.label10.Text = "Summary";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(2, 233);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 32);
            this.label11.TabIndex = 19;
            this.label11.Text = "Description";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(2, 133);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 32);
            this.label12.TabIndex = 20;
            this.label12.Text = "Components";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(2, 165);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 32);
            this.label13.TabIndex = 21;
            this.label13.Text = "Stage";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(2, 199);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 32);
            this.label14.TabIndex = 22;
            this.label14.Text = "Priority";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(2, 100);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 32);
            this.label15.TabIndex = 23;
            this.label15.Text = "Labels";
            // 
            // cmbFieldProjectKey
            // 
            this.cmbFieldProjectKey.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbFieldProjectKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFieldProjectKey.FormattingEnabled = true;
            this.cmbFieldProjectKey.Items.AddRange(new object[] {
            "TA"});
            this.cmbFieldProjectKey.Location = new System.Drawing.Point(158, 2);
            this.cmbFieldProjectKey.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFieldProjectKey.Name = "cmbFieldProjectKey";
            this.cmbFieldProjectKey.Size = new System.Drawing.Size(168, 36);
            this.cmbFieldProjectKey.TabIndex = 24;
            // 
            // cmbFieldIssueType
            // 
            this.cmbFieldIssueType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFieldIssueType.FormattingEnabled = true;
            this.cmbFieldIssueType.Items.AddRange(new object[] {
            "Task",
            "Requirement",
            "Issue"});
            this.cmbFieldIssueType.Location = new System.Drawing.Point(158, 36);
            this.cmbFieldIssueType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFieldIssueType.Name = "cmbFieldIssueType";
            this.cmbFieldIssueType.Size = new System.Drawing.Size(168, 36);
            this.cmbFieldIssueType.TabIndex = 25;
            // 
            // txtFieldSummary
            // 
            this.txtFieldSummary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFieldSummary.Location = new System.Drawing.Point(158, 68);
            this.txtFieldSummary.Margin = new System.Windows.Forms.Padding(2);
            this.txtFieldSummary.Name = "txtFieldSummary";
            this.txtFieldSummary.Size = new System.Drawing.Size(168, 34);
            this.txtFieldSummary.TabIndex = 26;
            this.txtFieldSummary.Text = "[TA] TEST ISSUE ONLY";
            // 
            // txtFieldDescription
            // 
            this.txtFieldDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFieldDescription.Location = new System.Drawing.Point(158, 235);
            this.txtFieldDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtFieldDescription.Multiline = true;
            this.txtFieldDescription.Name = "txtFieldDescription";
            this.txtFieldDescription.Size = new System.Drawing.Size(520, 180);
            this.txtFieldDescription.TabIndex = 27;
            this.txtFieldDescription.Text = "TEST ISSUE ONLY";
            // 
            // txtFieldComponents
            // 
            this.txtFieldComponents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFieldComponents.Location = new System.Drawing.Point(158, 135);
            this.txtFieldComponents.Margin = new System.Windows.Forms.Padding(2);
            this.txtFieldComponents.Name = "txtFieldComponents";
            this.txtFieldComponents.Size = new System.Drawing.Size(168, 34);
            this.txtFieldComponents.TabIndex = 28;
            this.txtFieldComponents.Text = "Test Development";
            // 
            // cmbFieldProjectStage
            // 
            this.cmbFieldProjectStage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFieldProjectStage.FormattingEnabled = true;
            this.cmbFieldProjectStage.Items.AddRange(new object[] {
            "Non-gate Stage/Project"});
            this.cmbFieldProjectStage.Location = new System.Drawing.Point(158, 167);
            this.cmbFieldProjectStage.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFieldProjectStage.Name = "cmbFieldProjectStage";
            this.cmbFieldProjectStage.Size = new System.Drawing.Size(168, 36);
            this.cmbFieldProjectStage.TabIndex = 29;
            // 
            // cmbFieldPriority
            // 
            this.cmbFieldPriority.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFieldPriority.FormattingEnabled = true;
            this.cmbFieldPriority.Items.AddRange(new object[] {
            "Medium",
            "High"});
            this.cmbFieldPriority.Location = new System.Drawing.Point(158, 201);
            this.cmbFieldPriority.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFieldPriority.Name = "cmbFieldPriority";
            this.cmbFieldPriority.Size = new System.Drawing.Size(168, 36);
            this.cmbFieldPriority.TabIndex = 30;
            // 
            // txtFieldLabels
            // 
            this.txtFieldLabels.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFieldLabels.Location = new System.Drawing.Point(158, 102);
            this.txtFieldLabels.Margin = new System.Windows.Forms.Padding(2);
            this.txtFieldLabels.Name = "txtFieldLabels";
            this.txtFieldLabels.Size = new System.Drawing.Size(168, 34);
            this.txtFieldLabels.TabIndex = 31;
            this.txtFieldLabels.Text = "PARAMETRIC_TEST";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.05433F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.94567F));
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbFieldPriority, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtFieldComponents, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmbFieldIssueType, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbFieldProjectKey, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFieldSummary, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbFieldProjectStage, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFieldDescription, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtFieldLabels, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.393286F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.913669F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.393286F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.153478F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.913669F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.393286F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.393286F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.88489F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(680, 417);
            this.tableLayoutPanel1.TabIndex = 33;
            // 
            // btnPostJira
            // 
            this.btnPostJira.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPostJira.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostJira.Location = new System.Drawing.Point(171, 2);
            this.btnPostJira.Margin = new System.Windows.Forms.Padding(2);
            this.btnPostJira.Name = "btnPostJira";
            this.btnPostJira.Size = new System.Drawing.Size(165, 54);
            this.btnPostJira.TabIndex = 34;
            this.btnPostJira.Text = "Create Ticket";
            this.btnPostJira.UseVisualStyleBackColor = true;
            this.btnPostJira.Click += new System.EventHandler(this.btnPostJira_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btnSearch, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPostJira, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 424);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(678, 58);
            this.tableLayoutPanel2.TabIndex = 36;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(684, 485);
            this.tableLayoutPanel3.TabIndex = 37;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(510, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 52);
            this.button1.TabIndex = 35;
            this.button1.Text = "Upload Test Result";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 565);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Text = "Issue JIRA Ticket";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbFieldProjectKey;
        private System.Windows.Forms.ComboBox cmbFieldIssueType;
        private System.Windows.Forms.TextBox txtFieldSummary;
        private System.Windows.Forms.TextBox txtFieldDescription;
        private System.Windows.Forms.TextBox txtFieldComponents;
        private System.Windows.Forms.ComboBox cmbFieldProjectStage;
        private System.Windows.Forms.ComboBox cmbFieldPriority;
        private System.Windows.Forms.TextBox txtFieldLabels;
        //private System.Windows.Forms.Button btnPOSTIssue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPostJira;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.Button button1;
    }
}

