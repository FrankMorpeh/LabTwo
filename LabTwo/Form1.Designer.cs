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
            this.studentsOfTeacherPanel = new System.Windows.Forms.Panel();
            this.chooseStudentsOfTeacherButton = new System.Windows.Forms.Button();
            this.studentsOfTeacherListView = new System.Windows.Forms.ListView();
            this.teachersPanel = new System.Windows.Forms.Panel();
            this.addTeacherButton = new System.Windows.Forms.Button();
            this.teachersListView = new System.Windows.Forms.ListView();
            this.addStudentToTeacherButton = new System.Windows.Forms.Button();
            this.teacherSalaryTextBox = new System.Windows.Forms.TextBox();
            this.teacherAgeTextBox = new System.Windows.Forms.TextBox();
            this.teacherNameTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
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
            this.departmentsListView = new System.Windows.Forms.ListView();
            this.addDepartmentButton = new System.Windows.Forms.Button();
            this.addSubjectsButton = new System.Windows.Forms.Button();
            this.deaneryCabinetNumberTextBox = new System.Windows.Forms.TextBox();
            this.departmentNameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.subjectsPanel = new System.Windows.Forms.Panel();
            this.saveSubjectsButton = new System.Windows.Forms.Button();
            this.subjectsListView = new System.Windows.Forms.ListView();
            this.addSubjectButton = new System.Windows.Forms.Button();
            this.subjectCreditTextBox = new System.Windows.Forms.TextBox();
            this.subjectNameTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.studentsPanel = new System.Windows.Forms.Panel();
            this.studentsListView = new System.Windows.Forms.ListView();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.studentYearInUniversityTextBox = new System.Windows.Forms.TextBox();
            this.studentRecordBookTextBox = new System.Windows.Forms.TextBox();
            this.studentAgeTextBox = new System.Windows.Forms.TextBox();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
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
            this.studentsOfTeacherPanel.SuspendLayout();
            this.teachersPanel.SuspendLayout();
            this.warningPanel.SuspendLayout();
            this.mainInfoPanel.SuspendLayout();
            this.departmentsPanel.SuspendLayout();
            this.subjectsPanel.SuspendLayout();
            this.studentsPanel.SuspendLayout();
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
            this.addUniversityPanel.Controls.Add(this.studentsOfTeacherPanel);
            this.addUniversityPanel.Controls.Add(this.teachersPanel);
            this.addUniversityPanel.Controls.Add(this.warningPanel);
            this.addUniversityPanel.Controls.Add(this.mainInfoPanel);
            this.addUniversityPanel.Controls.Add(this.departmentsPanel);
            this.addUniversityPanel.Controls.Add(this.subjectsPanel);
            this.addUniversityPanel.Controls.Add(this.studentsPanel);
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
            // studentsOfTeacherPanel
            // 
            this.studentsOfTeacherPanel.Controls.Add(this.chooseStudentsOfTeacherButton);
            this.studentsOfTeacherPanel.Controls.Add(this.studentsOfTeacherListView);
            this.studentsOfTeacherPanel.Location = new System.Drawing.Point(196, 24);
            this.studentsOfTeacherPanel.Name = "studentsOfTeacherPanel";
            this.studentsOfTeacherPanel.Size = new System.Drawing.Size(669, 480);
            this.studentsOfTeacherPanel.TabIndex = 14;
            studentsOfTeacherPanel.Hide();
            // 
            // chooseStudentsOfTeacherButton
            // 
            this.chooseStudentsOfTeacherButton.Location = new System.Drawing.Point(262, 376);
            this.chooseStudentsOfTeacherButton.Name = "chooseStudentsOfTeacherButton";
            this.chooseStudentsOfTeacherButton.Size = new System.Drawing.Size(144, 62);
            this.chooseStudentsOfTeacherButton.TabIndex = 1;
            this.chooseStudentsOfTeacherButton.Text = "Choose";
            this.chooseStudentsOfTeacherButton.UseVisualStyleBackColor = true;
            this.chooseStudentsOfTeacherButton.Click += new System.EventHandler(this.chooseStudentsOfTeacherButton_Click);
            // 
            // studentsOfTeacherListView
            // 
            this.studentsOfTeacherListView.Location = new System.Drawing.Point(71, 51);
            this.studentsOfTeacherListView.Name = "studentsOfTeacherListView";
            this.studentsOfTeacherListView.Size = new System.Drawing.Size(523, 297);
            this.studentsOfTeacherListView.TabIndex = 0;
            this.studentsOfTeacherListView.UseCompatibleStateImageBehavior = false;
            // 
            // teachersPanel
            // 
            this.teachersPanel.Controls.Add(this.addTeacherButton);
            this.teachersPanel.Controls.Add(this.teachersListView);
            this.teachersPanel.Controls.Add(this.addStudentToTeacherButton);
            this.teachersPanel.Controls.Add(this.teacherSalaryTextBox);
            this.teachersPanel.Controls.Add(this.teacherAgeTextBox);
            this.teachersPanel.Controls.Add(this.teacherNameTextBox);
            this.teachersPanel.Controls.Add(this.label16);
            this.teachersPanel.Controls.Add(this.label15);
            this.teachersPanel.Controls.Add(this.label14);
            this.teachersPanel.Location = new System.Drawing.Point(201, 32);
            this.teachersPanel.Name = "teachersPanel";
            this.teachersPanel.Size = new System.Drawing.Size(666, 470);
            this.teachersPanel.TabIndex = 13;
            // 
            // addTeacherButton
            // 
            this.addTeacherButton.Location = new System.Drawing.Point(63, 240);
            this.addTeacherButton.Name = "addTeacherButton";
            this.addTeacherButton.Size = new System.Drawing.Size(120, 58);
            this.addTeacherButton.TabIndex = 16;
            this.addTeacherButton.Text = "Add teacher";
            this.addTeacherButton.UseVisualStyleBackColor = true;
            this.addTeacherButton.Click += new System.EventHandler(this.addTeacherButton_Click);
            // 
            // teachersListView
            // 
            this.teachersListView.Location = new System.Drawing.Point(63, 309);
            this.teachersListView.Name = "teachersListView";
            this.teachersListView.Size = new System.Drawing.Size(289, 133);
            this.teachersListView.TabIndex = 15;
            this.teachersListView.UseCompatibleStateImageBehavior = false;
            this.teachersListView.View = System.Windows.Forms.View.Details;
            // 
            // addStudentToTeacherButton
            // 
            this.addStudentToTeacherButton.Location = new System.Drawing.Point(63, 183);
            this.addStudentToTeacherButton.Name = "addStudentToTeacherButton";
            this.addStudentToTeacherButton.Size = new System.Drawing.Size(110, 39);
            this.addStudentToTeacherButton.TabIndex = 14;
            this.addStudentToTeacherButton.Text = "Add students";
            this.addStudentToTeacherButton.UseVisualStyleBackColor = true;
            this.addStudentToTeacherButton.Click += new System.EventHandler(this.addStudentToTeacherButton_Click);
            // 
            // teacherSalaryTextBox
            // 
            this.teacherSalaryTextBox.Location = new System.Drawing.Point(151, 136);
            this.teacherSalaryTextBox.Name = "teacherSalaryTextBox";
            this.teacherSalaryTextBox.Size = new System.Drawing.Size(137, 27);
            this.teacherSalaryTextBox.TabIndex = 5;
            // 
            // teacherAgeTextBox
            // 
            this.teacherAgeTextBox.Location = new System.Drawing.Point(130, 95);
            this.teacherAgeTextBox.Name = "teacherAgeTextBox";
            this.teacherAgeTextBox.Size = new System.Drawing.Size(59, 27);
            this.teacherAgeTextBox.TabIndex = 4;
            // 
            // teacherNameTextBox
            // 
            this.teacherNameTextBox.Location = new System.Drawing.Point(152, 51);
            this.teacherNameTextBox.Name = "teacherNameTextBox";
            this.teacherNameTextBox.Size = new System.Drawing.Size(253, 27);
            this.teacherNameTextBox.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(63, 131);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 32);
            this.label16.TabIndex = 2;
            this.label16.Text = "Salary:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(63, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 32);
            this.label15.TabIndex = 1;
            this.label15.Text = "Age:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(63, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 32);
            this.label14.TabIndex = 0;
            this.label14.Text = "Name:";
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
            this.departmentsPanel.Controls.Add(this.departmentsListView);
            this.departmentsPanel.Controls.Add(this.addDepartmentButton);
            this.departmentsPanel.Controls.Add(this.addSubjectsButton);
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
            // departmentsListView
            // 
            this.departmentsListView.Location = new System.Drawing.Point(44, 244);
            this.departmentsListView.Name = "departmentsListView";
            this.departmentsListView.Size = new System.Drawing.Size(270, 139);
            this.departmentsListView.TabIndex = 13;
            this.departmentsListView.UseCompatibleStateImageBehavior = false;
            this.departmentsListView.View = System.Windows.Forms.View.Details;
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
            // addSubjectsButton
            // 
            this.addSubjectsButton.Location = new System.Drawing.Point(162, 126);
            this.addSubjectsButton.Name = "addSubjectsButton";
            this.addSubjectsButton.Size = new System.Drawing.Size(117, 36);
            this.addSubjectsButton.TabIndex = 11;
            this.addSubjectsButton.Text = "Add subjects";
            this.addSubjectsButton.UseVisualStyleBackColor = true;
            this.addSubjectsButton.Click += new System.EventHandler(this.addSubjectsButton_Click);
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
            this.label7.Size = new System.Drawing.Size(108, 32);
            this.label7.TabIndex = 2;
            this.label7.Text = "Subjects:";
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
            // subjectsPanel
            // 
            this.subjectsPanel.Controls.Add(this.saveSubjectsButton);
            this.subjectsPanel.Controls.Add(this.subjectsListView);
            this.subjectsPanel.Controls.Add(this.addSubjectButton);
            this.subjectsPanel.Controls.Add(this.subjectCreditTextBox);
            this.subjectsPanel.Controls.Add(this.subjectNameTextBox);
            this.subjectsPanel.Controls.Add(this.label9);
            this.subjectsPanel.Controls.Add(this.label8);
            this.subjectsPanel.Location = new System.Drawing.Point(186, 27);
            this.subjectsPanel.Name = "subjectsPanel";
            this.subjectsPanel.Size = new System.Drawing.Size(673, 463);
            this.subjectsPanel.TabIndex = 11;
            // 
            // saveSubjectsButton
            // 
            this.saveSubjectsButton.Location = new System.Drawing.Point(38, 373);
            this.saveSubjectsButton.Name = "saveSubjectsButton";
            this.saveSubjectsButton.Size = new System.Drawing.Size(129, 48);
            this.saveSubjectsButton.TabIndex = 14;
            this.saveSubjectsButton.Text = "Save subjects";
            this.saveSubjectsButton.UseVisualStyleBackColor = true;
            this.saveSubjectsButton.Click += new System.EventHandler(this.saveSubjectsButton_Click);
            // 
            // subjectsListView
            // 
            this.subjectsListView.Location = new System.Drawing.Point(38, 211);
            this.subjectsListView.Name = "subjectsListView";
            this.subjectsListView.Size = new System.Drawing.Size(229, 135);
            this.subjectsListView.TabIndex = 13;
            this.subjectsListView.UseCompatibleStateImageBehavior = false;
            this.subjectsListView.View = System.Windows.Forms.View.Details;
            // 
            // addSubjectButton
            // 
            this.addSubjectButton.Location = new System.Drawing.Point(38, 146);
            this.addSubjectButton.Name = "addSubjectButton";
            this.addSubjectButton.Size = new System.Drawing.Size(104, 38);
            this.addSubjectButton.TabIndex = 12;
            this.addSubjectButton.Text = "Add subject";
            this.addSubjectButton.UseVisualStyleBackColor = true;
            this.addSubjectButton.Click += new System.EventHandler(this.addSubjectButton_Click);
            // 
            // subjectCreditTextBox
            // 
            this.subjectCreditTextBox.Location = new System.Drawing.Point(209, 99);
            this.subjectCreditTextBox.Name = "subjectCreditTextBox";
            this.subjectCreditTextBox.Size = new System.Drawing.Size(166, 27);
            this.subjectCreditTextBox.TabIndex = 3;
            // 
            // subjectNameTextBox
            // 
            this.subjectNameTextBox.Location = new System.Drawing.Point(209, 47);
            this.subjectNameTextBox.Name = "subjectNameTextBox";
            this.subjectNameTextBox.Size = new System.Drawing.Size(166, 27);
            this.subjectNameTextBox.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(38, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 32);
            this.label9.TabIndex = 1;
            this.label9.Text = "Subject credit:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(38, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Subject name:";
            // 
            // studentsPanel
            // 
            this.studentsPanel.Controls.Add(this.studentsListView);
            this.studentsPanel.Controls.Add(this.addStudentButton);
            this.studentsPanel.Controls.Add(this.studentYearInUniversityTextBox);
            this.studentsPanel.Controls.Add(this.studentRecordBookTextBox);
            this.studentsPanel.Controls.Add(this.studentAgeTextBox);
            this.studentsPanel.Controls.Add(this.studentNameTextBox);
            this.studentsPanel.Controls.Add(this.label13);
            this.studentsPanel.Controls.Add(this.label12);
            this.studentsPanel.Controls.Add(this.label11);
            this.studentsPanel.Controls.Add(this.label10);
            this.studentsPanel.Location = new System.Drawing.Point(205, 39);
            this.studentsPanel.Name = "studentsPanel";
            this.studentsPanel.Size = new System.Drawing.Size(642, 457);
            this.studentsPanel.TabIndex = 12;
            // 
            // studentsListView
            // 
            this.studentsListView.Location = new System.Drawing.Point(56, 281);
            this.studentsListView.Name = "studentsListView";
            this.studentsListView.Size = new System.Drawing.Size(362, 158);
            this.studentsListView.TabIndex = 9;
            this.studentsListView.UseCompatibleStateImageBehavior = false;
            this.studentsListView.View = System.Windows.Forms.View.Details;
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(51, 213);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(128, 48);
            this.addStudentButton.TabIndex = 8;
            this.addStudentButton.Text = "Add student";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // studentYearInUniversityTextBox
            // 
            this.studentYearInUniversityTextBox.Location = new System.Drawing.Point(257, 165);
            this.studentYearInUniversityTextBox.Name = "studentYearInUniversityTextBox";
            this.studentYearInUniversityTextBox.Size = new System.Drawing.Size(57, 27);
            this.studentYearInUniversityTextBox.TabIndex = 7;
            // 
            // studentRecordBookTextBox
            // 
            this.studentRecordBookTextBox.Location = new System.Drawing.Point(205, 122);
            this.studentRecordBookTextBox.Name = "studentRecordBookTextBox";
            this.studentRecordBookTextBox.Size = new System.Drawing.Size(174, 27);
            this.studentRecordBookTextBox.TabIndex = 6;
            // 
            // studentAgeTextBox
            // 
            this.studentAgeTextBox.Location = new System.Drawing.Point(118, 79);
            this.studentAgeTextBox.Name = "studentAgeTextBox";
            this.studentAgeTextBox.Size = new System.Drawing.Size(57, 27);
            this.studentAgeTextBox.TabIndex = 5;
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Location = new System.Drawing.Point(140, 32);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(225, 27);
            this.studentNameTextBox.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(51, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(200, 32);
            this.label13.TabIndex = 3;
            this.label13.Text = "Year in university:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(51, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 32);
            this.label12.TabIndex = 2;
            this.label12.Text = "Record book:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(51, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 32);
            this.label11.TabIndex = 1;
            this.label11.Text = "Age:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(51, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 32);
            this.label10.TabIndex = 0;
            this.label10.Text = "Name:";
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
            this.teachersButton.Click += new System.EventHandler(this.teachersButton_Click);
            // 
            // studentsButton
            // 
            this.studentsButton.Location = new System.Drawing.Point(25, 156);
            this.studentsButton.Name = "studentsButton";
            this.studentsButton.Size = new System.Drawing.Size(125, 55);
            this.studentsButton.TabIndex = 3;
            this.studentsButton.Text = "Students";
            this.studentsButton.UseVisualStyleBackColor = true;
            this.studentsButton.Click += new System.EventHandler(this.studentsButton_Click);
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
            this.studentsOfTeacherPanel.ResumeLayout(false);
            this.teachersPanel.ResumeLayout(false);
            this.teachersPanel.PerformLayout();
            this.warningPanel.ResumeLayout(false);
            this.warningPanel.PerformLayout();
            this.mainInfoPanel.ResumeLayout(false);
            this.mainInfoPanel.PerformLayout();
            this.departmentsPanel.ResumeLayout(false);
            this.departmentsPanel.PerformLayout();
            this.subjectsPanel.ResumeLayout(false);
            this.subjectsPanel.PerformLayout();
            this.studentsPanel.ResumeLayout(false);
            this.studentsPanel.PerformLayout();
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
        public ListView departmentsListView;
        public Button addDepartmentButton;
        public Button addSubjectsButton;
        public TextBox deaneryCabinetNumberTextBox;
        public TextBox departmentNameTextBox;
        public Panel subjectsPanel;
        public Button saveSubjectsButton;
        public ListView subjectsListView;
        public Button addSubjectButton;
        public TextBox subjectCreditTextBox;
        public TextBox subjectNameTextBox;
        public Label label9;
        public Label label8;
        public Panel studentsPanel;
        public Button addStudentButton;
        public TextBox studentYearInUniversityTextBox;
        public TextBox studentRecordBookTextBox;
        public TextBox studentAgeTextBox;
        public TextBox studentNameTextBox;
        public Label label13;
        public Label label12;
        public Label label11;
        public Label label10;
        public ListView studentsListView;
        public Panel teachersPanel;
        public ListView teachersListView;
        public Button addStudentToTeacherButton;
        public TextBox teacherSalaryTextBox;
        public TextBox teacherAgeTextBox;
        public TextBox teacherNameTextBox;
        public Label label16;
        public Label label15;
        public Label label14;
        public Panel studentsOfTeacherPanel;
        public Button chooseStudentsOfTeacherButton;
        public ListView studentsOfTeacherListView;
        public Button addTeacherButton;
    }
}