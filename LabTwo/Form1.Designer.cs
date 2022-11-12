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
            this.universityComboBox = new System.Windows.Forms.ComboBox();
            this.openUniversityButton = new System.Windows.Forms.Button();
            this.addUniversityButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.addUniversityPanel.SuspendLayout();
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
            this.mainPanel.Location = new System.Drawing.Point(1, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(799, 450);
            this.mainPanel.TabIndex = 0;
            //this.mainPanel.Hide();
            // 
            // addUniversityPanel
            // 
            this.addUniversityPanel.Controls.Add(this.label2);
            this.addUniversityPanel.Location = new System.Drawing.Point(6, 3);
            this.addUniversityPanel.Name = "addUniversityPanel";
            this.addUniversityPanel.Size = new System.Drawing.Size(790, 441);
            this.addUniversityPanel.TabIndex = 5;
            this.addUniversityPanel.Controls.Add(label2);
            this.addUniversityPanel.Visible = false;
            this.addUniversityPanel.Hide();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.addUniversityPanel.ResumeLayout(false);
            this.addUniversityPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel mainPanel;
        private Label label1;
        private Button openUniversityButton;
        private ComboBox universityComboBox;
        private Panel addUniversityPanel;
        private Button addUniversityButton;
        private Label label2;
    }
}