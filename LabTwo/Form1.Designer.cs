using System.Text;

namespace LabTwo
{
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.addUniversityPanel = new System.Windows.Forms.Panel();
            this.warningPanel = new System.Windows.Forms.Panel();
            this.warningTextBox = new System.Windows.Forms.TextBox();
            this.okWarningButton = new System.Windows.Forms.Button();
            this.mainInfoPanel = new System.Windows.Forms.Panel();
            this.saveMainInfoButton = new System.Windows.Forms.Button();
            this.rankTextBox = new System.Windows.Forms.TextBox();
            this.foundationYearTextBox = new System.Windows.Forms.TextBox();
            this.universityNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.departmentsPanel = new System.Windows.Forms.Panel();
            this.saveDepartmentsButton = new System.Windows.Forms.Button();
            this.departmentsListView = new System.Windows.Forms.ListView();
            this.addDepartmentButton = new System.Windows.Forms.Button();
            this.addStudentsButton = new System.Windows.Forms.Button();
            this.deaneryCabinetNumberTextBox = new System.Windows.Forms.TextBox();
            this.departmentNameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.createUniversityButton = new System.Windows.Forms.Button();
            this.auditoriumsButton = new System.Windows.Forms.Button();
            this.engineersButton = new System.Windows.Forms.Button();
            this.teachersButton = new System.Windows.Forms.Button();
            this.studentsButton = new System.Windows.Forms.Button();
            this.departmentsButton = new System.Windows.Forms.Button();
            this.mainInfoButton = new System.Windows.Forms.Button();
            this.universityComboBox = new System.Windows.Forms.ComboBox();
            this.openUniversityButton = new System.Windows.Forms.Button();
            this.addUniversityButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.addUniversityPanel.SuspendLayout();
            this.warningPanel.SuspendLayout();
            this.mainInfoPanel.SuspendLayout();
            this.departmentsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainPanel.Controls.Add(this.addUniversityPanel);
            this.mainPanel.Controls.Add(this.universityComboBox);
            this.mainPanel.Controls.Add(this.openUniversityButton);
            this.mainPanel.Controls.Add(this.addUniversityButton);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Location = new System.Drawing.Point(2, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(890, 536);
            this.mainPanel.TabIndex = 0;
            // 
            // addUniversityPanel
            // 
            this.addUniversityPanel.Controls.Add(this.warningPanel);
            this.addUniversityPanel.Controls.Add(this.mainInfoPanel);
            this.addUniversityPanel.Controls.Add(this.departmentsPanel);
            this.addUniversityPanel.Controls.Add(this.createUniversityButton);
            this.addUniversityPanel.Controls.Add(this.auditoriumsButton);
            this.addUniversityPanel.Controls.Add(this.engineersButton);
            this.addUniversityPanel.Controls.Add(this.teachersButton);
            this.addUniversityPanel.Controls.Add(this.studentsButton);
            this.addUniversityPanel.Controls.Add(this.departmentsButton);
            this.addUniversityPanel.Controls.Add(this.mainInfoButton);
            this.addUniversityPanel.Location = new System.Drawing.Point(6, 3);
            this.addUniversityPanel.Name = "addUniversityPanel";
            this.addUniversityPanel.Size = new System.Drawing.Size(881, 533);
            this.addUniversityPanel.TabIndex = 5;
            // 
            // warningPanel
            // 
            this.warningPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.warningPanel.Controls.Add(this.warningTextBox);
            this.warningPanel.Controls.Add(this.okWarningButton);
            this.warningPanel.Location = new System.Drawing.Point(303, 159);
            this.warningPanel.Name = "warningPanel";
            this.warningPanel.Size = new System.Drawing.Size(309, 240);
            this.warningPanel.TabIndex = 0;
            this.warningPanel.Hide();
            // 
            // warningTextBox
            // 
            this.warningTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.warningTextBox.Location = new System.Drawing.Point(41, 25);
            this.warningTextBox.Multiline = true;
            this.warningTextBox.Name = "warningTextBox";
            this.warningTextBox.ReadOnly = true;
            this.warningTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.warningTextBox.Size = new System.Drawing.Size(219, 150);
            this.warningTextBox.TabIndex = 1;
            // 
            // okWarningButton
            // 
            this.okWarningButton.Location = new System.Drawing.Point(126, 187);
            this.okWarningButton.Name = "okWarningButton";
            this.okWarningButton.Size = new System.Drawing.Size(54, 31);
            this.okWarningButton.TabIndex = 0;
            this.okWarningButton.Text = "OK";
            this.okWarningButton.UseVisualStyleBackColor = true;
            this.okWarningButton.Click += new System.EventHandler(this.okWarningButton_Click);
            // 
            // mainInfoPanel
            // 
            this.mainInfoPanel.Controls.Add(this.saveMainInfoButton);
            this.mainInfoPanel.Controls.Add(this.rankTextBox);
            this.mainInfoPanel.Controls.Add(this.foundationYearTextBox);
            this.mainInfoPanel.Controls.Add(this.universityNameTextBox);
            this.mainInfoPanel.Controls.Add(this.label4);
            this.mainInfoPanel.Controls.Add(this.label3);
            this.mainInfoPanel.Controls.Add(this.label2);
            this.mainInfoPanel.Location = new System.Drawing.Point(185, 18);
            this.mainInfoPanel.Name = "mainInfoPanel";
            this.mainInfoPanel.Size = new System.Drawing.Size(686, 503);
            this.mainInfoPanel.TabIndex = 8;
            // 
            // saveMainInfoButton
            // 
            this.saveMainInfoButton.Location = new System.Drawing.Point(40, 243);
            this.saveMainInfoButton.Name = "saveMainInfoButton";
            this.saveMainInfoButton.Size = new System.Drawing.Size(125, 55);
            this.saveMainInfoButton.TabIndex = 9;
            this.saveMainInfoButton.Text = "Save changes";
            this.saveMainInfoButton.UseVisualStyleBackColor = true;
            this.saveMainInfoButton.Click += new System.EventHandler(this.saveMainInfoButton_Click);
            // 
            // rankTextBox
            // 
            this.rankTextBox.Location = new System.Drawing.Point(117, 166);
            this.rankTextBox.Name = "rankTextBox";
            this.rankTextBox.Size = new System.Drawing.Size(188, 27);
            this.rankTextBox.TabIndex = 5;
            // 
            // foundationYearTextBox
            // 
            this.foundationYearTextBox.Location = new System.Drawing.Point(242, 109);
            this.foundationYearTextBox.Name = "foundationYearTextBox";
            this.foundationYearTextBox.Size = new System.Drawing.Size(188, 27);
            this.foundationYearTextBox.TabIndex = 4;
            // 
            // universityNameTextBox
            // 
            this.universityNameTextBox.Location = new System.Drawing.Point(242, 48);
            this.universityNameTextBox.Name = "universityNameTextBox";
            this.universityNameTextBox.Size = new System.Drawing.Size(188, 27);
            this.universityNameTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(40, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Rank:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(40, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Founation year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "University name:";
            // 
            // departmentsPanel
            // 
            this.departmentsPanel.Controls.Add(this.saveDepartmentsButton);
            this.departmentsPanel.Controls.Add(this.departmentsListView);
            this.departmentsPanel.Controls.Add(this.addDepartmentButton);
            this.departmentsPanel.Controls.Add(this.addStudentsButton);
            this.departmentsPanel.Controls.Add(this.deaneryCabinetNumberTextBox);
            this.departmentsPanel.Controls.Add(this.departmentNameTextBox);
            this.departmentsPanel.Controls.Add(this.label7);
            this.departmentsPanel.Controls.Add(this.label6);
            this.departmentsPanel.Controls.Add(this.label5);
            this.departmentsPanel.Location = new System.Drawing.Point(198, 28);
            this.departmentsPanel.Name = "departmentsPanel";
            this.departmentsPanel.Size = new System.Drawing.Size(663, 478);
            this.departmentsPanel.TabIndex = 10;
            // 
            // saveDepartmentsButton
            // 
            this.saveDepartmentsButton.Location = new System.Drawing.Point(44, 409);
            this.saveDepartmentsButton.Name = "saveDepartmentsButton";
            this.saveDepartmentsButton.Size = new System.Drawing.Size(125, 55);
            this.saveDepartmentsButton.TabIndex = 11;
            this.saveDepartmentsButton.Text = "Save departments";
            this.saveDepartmentsButton.UseVisualStyleBackColor = true;
            // 
            // departmentsListView
            // 
            this.departmentsListView.Location = new System.Drawing.Point(44, 244);
            this.departmentsListView.Name = "departmentsListView";
            this.departmentsListView.Size = new System.Drawing.Size(270, 139);
            this.departmentsListView.TabIndex = 13;
            this.departmentsListView.UseCompatibleStateImageBehavior = false;
            // 
            // addDepartmentButton
            // 
            this.addDepartmentButton.Location = new System.Drawing.Point(44, 183);
            this.addDepartmentButton.Name = "addDepartmentButton";
            this.addDepartmentButton.Size = new System.Drawing.Size(129, 46);
            this.addDepartmentButton.TabIndex = 12;
            this.addDepartmentButton.Text = "Add department";
            this.addDepartmentButton.UseVisualStyleBackColor = true;
            this.addDepartmentButton.Click += new System.EventHandler(this.addDepartmentButton_Click);
            // 
            // addStudentsButton
            // 
            this.addStudentsButton.Location = new System.Drawing.Point(162, 126);
            this.addStudentsButton.Name = "addStudentsButton";
            this.addStudentsButton.Size = new System.Drawing.Size(117, 36);
            this.addStudentsButton.TabIndex = 11;
            this.addStudentsButton.Text = "Add students";
            this.addStudentsButton.UseVisualStyleBackColor = true;
            // 
            // deaneryCabinetNumberTextBox
            // 
            this.deaneryCabinetNumberTextBox.Location = new System.Drawing.Point(334, 81);
            this.deaneryCabinetNumberTextBox.Name = "deaneryCabinetNumberTextBox";
            this.deaneryCabinetNumberTextBox.Size = new System.Drawing.Size(206, 27);
            this.deaneryCabinetNumberTextBox.TabIndex = 4;
            // 
            // departmentNameTextBox
            // 
            this.departmentNameTextBox.Location = new System.Drawing.Point(264, 28);
            this.departmentNameTextBox.Name = "departmentNameTextBox";
            this.departmentNameTextBox.Size = new System.Drawing.Size(206, 27);
            this.departmentNameTextBox.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(44, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 32);
            this.label7.TabIndex = 2;
            this.label7.Text = "Students:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(44, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "Deanery cabinet number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(44, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Department name:";
            // 
            // createUniversityButton
            // 
            this.createUniversityButton.Location = new System.Drawing.Point(25, 467);
            this.createUniversityButton.Name = "createUniversityButton";
            this.createUniversityButton.Size = new System.Drawing.Size(125, 55);
            this.createUniversityButton.TabIndex = 7;
            this.createUniversityButton.Text = "Create";
            this.createUniversityButton.UseVisualStyleBackColor = true;
            // 
            // auditoriumsButton
            // 
            this.auditoriumsButton.Location = new System.Drawing.Point(25, 368);
            this.auditoriumsButton.Name = "auditoriumsButton";
            this.auditoriumsButton.Size = new System.Drawing.Size(125, 55);
            this.auditoriumsButton.TabIndex = 6;
            this.auditoriumsButton.Text = "Auditoriums";
            this.auditoriumsButton.UseVisualStyleBackColor = true;
            // 
            // engineersButton
            // 
            this.engineersButton.Location = new System.Drawing.Point(25, 298);
            this.engineersButton.Name = "engineersButton";
            this.engineersButton.Size = new System.Drawing.Size(125, 55);
            this.engineersButton.TabIndex = 5;
            this.engineersButton.Text = "Engineers";
            this.engineersButton.UseVisualStyleBackColor = true;
            // 
            // teachersButton
            // 
            this.teachersButton.Location = new System.Drawing.Point(25, 228);
            this.teachersButton.Name = "teachersButton";
            this.teachersButton.Size = new System.Drawing.Size(125, 55);
            this.teachersButton.TabIndex = 4;
            this.teachersButton.Text = "Teachers";
            this.teachersButton.UseVisualStyleBackColor = true;
            // 
            // studentsButton
            // 
            this.studentsButton.Location = new System.Drawing.Point(25, 156);
            this.studentsButton.Name = "studentsButton";
            this.studentsButton.Size = new System.Drawing.Size(125, 55);
            this.studentsButton.TabIndex = 3;
            this.studentsButton.Text = "Students";
            this.studentsButton.UseVisualStyleBackColor = true;
            // 
            // departmentsButton
            // 
            this.departmentsButton.Location = new System.Drawing.Point(25, 89);
            this.departmentsButton.Name = "departmentsButton";
            this.departmentsButton.Size = new System.Drawing.Size(125, 55);
            this.departmentsButton.TabIndex = 2;
            this.departmentsButton.Text = "Departments";
            this.departmentsButton.UseVisualStyleBackColor = true;
            this.departmentsButton.Click += new System.EventHandler(this.departmentsButton_Click);
            // 
            // mainInfoButton
            // 
            this.mainInfoButton.Location = new System.Drawing.Point(25, 18);
            this.mainInfoButton.Name = "mainInfoButton";
            this.mainInfoButton.Size = new System.Drawing.Size(125, 55);
            this.mainInfoButton.TabIndex = 1;
            this.mainInfoButton.Text = "Main";
            this.mainInfoButton.UseVisualStyleBackColor = true;
            this.mainInfoButton.Click += new System.EventHandler(this.mainInfoButton_Click);
            // 
            // universityComboBox
            // 
            this.universityComboBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.universityComboBox.FormattingEnabled = true;
            this.universityComboBox.Location = new System.Drawing.Point(154, 159);
            this.universityComboBox.Name = "universityComboBox";
            this.universityComboBox.Size = new System.Drawing.Size(190, 39);
            this.universityComboBox.TabIndex = 3;
            // 
            // openUniversityButton
            // 
            this.openUniversityButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openUniversityButton.Location = new System.Drawing.Point(130, 231);
            this.openUniversityButton.Name = "openUniversityButton";
            this.openUniversityButton.Size = new System.Drawing.Size(229, 109);
            this.openUniversityButton.TabIndex = 1;
            this.openUniversityButton.Text = "Open university";
            this.openUniversityButton.UseVisualStyleBackColor = true;
            // 
            // addUniversityButton
            // 
            this.addUniversityButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addUniversityButton.Location = new System.Drawing.Point(435, 176);
            this.addUniversityButton.Name = "addUniversityButton";
            this.addUniversityButton.Size = new System.Drawing.Size(206, 81);
            this.addUniversityButton.TabIndex = 6;
            this.addUniversityButton.Text = "Add university";
            this.addUniversityButton.UseVisualStyleBackColor = true;
            this.addUniversityButton.Click += new System.EventHandler(this.addUniversityButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(189, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "University:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 537);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.addUniversityPanel.ResumeLayout(false);
            this.warningPanel.ResumeLayout(false);
            this.warningPanel.PerformLayout();
            this.mainInfoPanel.ResumeLayout(false);
            this.mainInfoPanel.PerformLayout();
            this.departmentsPanel.ResumeLayout(false);
            this.departmentsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Panel mainPanel;
        public Label label1;
        public Button openUniversityButton;
        public ComboBox universityComboBox;
        public Panel addUniversityPanel;
        public Button addUniversityButton;
        public Button auditoriumsButton;
        public Button engineersButton;
        public Button teachersButton;
        public Button studentsButton;
        public Button departmentsButton;
        public Button mainInfoButton;
        public Button createUniversityButton;
        public Panel mainInfoPanel;
        public Button saveMainInfoButton;
        public TextBox rankTextBox;
        public TextBox foundationYearTextBox;
        public TextBox universityNameTextBox;
        public Label label4;
        public Label label3;
        public Label label2;
        public Panel warningPanel;
        public Button okWarningButton;
        public TextBox warningTextBox;
        public Panel departmentsPanel;
        public Label label5;
        public Label label6;
        public Label label7;
        public Button saveDepartmentsButton;
        public ListView departmentsListView;
        public Button addDepartmentButton;
        public Button addStudentsButton;
        public TextBox deaneryCabinetNumberTextBox;
        public TextBox departmentNameTextBox;
    }
}