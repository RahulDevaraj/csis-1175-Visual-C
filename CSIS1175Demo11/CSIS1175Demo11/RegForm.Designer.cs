
namespace CSIS1175Demo11
{
    partial class RegForm
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
            this.textName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.grbLesson = new System.Windows.Forms.GroupBox();
            this.chkDive = new System.Windows.Forms.CheckBox();
            this.chkSnorkel = new System.Windows.Forms.CheckBox();
            this.chkSwim = new System.Windows.Forms.CheckBox();
            this.grbSkill = new System.Windows.Forms.GroupBox();
            this.rdbAdvanced = new System.Windows.Forms.RadioButton();
            this.rdbIntermediate = new System.Windows.Forms.RadioButton();
            this.rdbBeginner = new System.Windows.Forms.RadioButton();
            this.cobGender = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.grbLesson.SuspendLayout();
            this.grbSkill.SuspendLayout();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(126, 23);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(388, 27);
            this.textName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(59, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // grbLesson
            // 
            this.grbLesson.Controls.Add(this.chkDive);
            this.grbLesson.Controls.Add(this.chkSnorkel);
            this.grbLesson.Controls.Add(this.chkSwim);
            this.grbLesson.Location = new System.Drawing.Point(59, 79);
            this.grbLesson.Name = "grbLesson";
            this.grbLesson.Size = new System.Drawing.Size(195, 125);
            this.grbLesson.TabIndex = 2;
            this.grbLesson.TabStop = false;
            this.grbLesson.Text = "select Lesson";
            // 
            // chkDive
            // 
            this.chkDive.AutoSize = true;
            this.chkDive.Location = new System.Drawing.Point(44, 88);
            this.chkDive.Name = "chkDive";
            this.chkDive.Size = new System.Drawing.Size(107, 24);
            this.chkDive.TabIndex = 2;
            this.chkDive.Text = "Dive - $100";
            this.chkDive.UseVisualStyleBackColor = true;
            this.chkDive.CheckedChanged += new System.EventHandler(this.computeCost_CheckedChanged);
            // 
            // chkSnorkel
            // 
            this.chkSnorkel.AutoSize = true;
            this.chkSnorkel.Location = new System.Drawing.Point(44, 57);
            this.chkSnorkel.Name = "chkSnorkel";
            this.chkSnorkel.Size = new System.Drawing.Size(118, 24);
            this.chkSnorkel.TabIndex = 1;
            this.chkSnorkel.Text = "Snorkel - $25";
            this.chkSnorkel.UseVisualStyleBackColor = true;
            this.chkSnorkel.CheckedChanged += new System.EventHandler(this.computeCost_CheckedChanged);
            // 
            // chkSwim
            // 
            this.chkSwim.AutoSize = true;
            this.chkSwim.Location = new System.Drawing.Point(44, 26);
            this.chkSwim.Name = "chkSwim";
            this.chkSwim.Size = new System.Drawing.Size(105, 24);
            this.chkSwim.TabIndex = 0;
            this.chkSwim.Text = "Swim - $50";
            this.chkSwim.UseVisualStyleBackColor = true;
            this.chkSwim.CheckedChanged += new System.EventHandler(this.computeCost_CheckedChanged);
            // 
            // grbSkill
            // 
            this.grbSkill.Controls.Add(this.rdbAdvanced);
            this.grbSkill.Controls.Add(this.rdbIntermediate);
            this.grbSkill.Controls.Add(this.rdbBeginner);
            this.grbSkill.Location = new System.Drawing.Point(297, 79);
            this.grbSkill.Name = "grbSkill";
            this.grbSkill.Size = new System.Drawing.Size(180, 125);
            this.grbSkill.TabIndex = 3;
            this.grbSkill.TabStop = false;
            this.grbSkill.Text = "Skill Level";
            // 
            // rdbAdvanced
            // 
            this.rdbAdvanced.AutoSize = true;
            this.rdbAdvanced.Location = new System.Drawing.Point(40, 88);
            this.rdbAdvanced.Name = "rdbAdvanced";
            this.rdbAdvanced.Size = new System.Drawing.Size(17, 16);
            this.rdbAdvanced.TabIndex = 2;
            this.rdbAdvanced.TabStop = true;
            this.rdbAdvanced.UseVisualStyleBackColor = true;
            this.rdbAdvanced.CheckedChanged += new System.EventHandler(this.rdbAdvanced_CheckedChanged);
            // 
            // rdbIntermediate
            // 
            this.rdbIntermediate.AutoSize = true;
            this.rdbIntermediate.Location = new System.Drawing.Point(40, 57);
            this.rdbIntermediate.Name = "rdbIntermediate";
            this.rdbIntermediate.Size = new System.Drawing.Size(17, 16);
            this.rdbIntermediate.TabIndex = 1;
            this.rdbIntermediate.TabStop = true;
            this.rdbIntermediate.UseVisualStyleBackColor = true;
            this.rdbIntermediate.CheckedChanged += new System.EventHandler(this.rdbIntermediate_CheckedChanged);
            // 
            // rdbBeginner
            // 
            this.rdbBeginner.AutoSize = true;
            this.rdbBeginner.Location = new System.Drawing.Point(40, 26);
            this.rdbBeginner.Name = "rdbBeginner";
            this.rdbBeginner.Size = new System.Drawing.Size(17, 16);
            this.rdbBeginner.TabIndex = 0;
            this.rdbBeginner.TabStop = true;
            this.rdbBeginner.UseVisualStyleBackColor = true;
            this.rdbBeginner.CheckedChanged += new System.EventHandler(this.rdbBeginner_CheckedChanged);
            // 
            // cobGender
            // 
            this.cobGender.FormattingEnabled = true;
            this.cobGender.Location = new System.Drawing.Point(567, 23);
            this.cobGender.Name = "cobGender";
            this.cobGender.Size = new System.Drawing.Size(90, 28);
            this.cobGender.TabIndex = 4;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(103, 245);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(77, 32);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(337, 257);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 20);
            this.lblMessage.TabIndex = 6;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(337, 319);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(111, 47);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirm Reg";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 377);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cobGender);
            this.Controls.Add(this.grbSkill);
            this.Controls.Add(this.grbLesson);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.textName);
            this.Name = "RegForm";
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.RegForm_Load);
            this.grbLesson.ResumeLayout(false);
            this.grbLesson.PerformLayout();
            this.grbSkill.ResumeLayout(false);
            this.grbSkill.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grbLesson;
        private System.Windows.Forms.CheckBox chkDive;
        private System.Windows.Forms.CheckBox chkSnorkel;
        private System.Windows.Forms.CheckBox chkSwim;
        private System.Windows.Forms.GroupBox grbSkill;
        private System.Windows.Forms.RadioButton rdbBeginner;
        private System.Windows.Forms.RadioButton rdbAdvanced;
        private System.Windows.Forms.RadioButton rdbIntermediate;
        private System.Windows.Forms.ComboBox cobGender;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnConfirm;
    }
}

