
namespace CSIS1175Demo10
{
    partial class StudentForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnShowMsg = new System.Windows.Forms.Button();
            this.grpBoxGender = new System.Windows.Forms.GroupBox();
            this.rdbNone = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.lstHobby = new System.Windows.Forms.ListBox();
            this.lblHobbie = new System.Windows.Forms.Label();
            this.grpBoxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(102, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(243, 27);
            this.txtName.TabIndex = 1;
            // 
            // btnShowMsg
            // 
            this.btnShowMsg.Location = new System.Drawing.Point(272, 229);
            this.btnShowMsg.Name = "btnShowMsg";
            this.btnShowMsg.Size = new System.Drawing.Size(94, 29);
            this.btnShowMsg.TabIndex = 2;
            this.btnShowMsg.Text = "ShowInfo";
            this.btnShowMsg.UseVisualStyleBackColor = true;
            this.btnShowMsg.Click += new System.EventHandler(this.btnShowMsg_Click);
            // 
            // grpBoxGender
            // 
            this.grpBoxGender.Controls.Add(this.rdbNone);
            this.grpBoxGender.Controls.Add(this.rdbFemale);
            this.grpBoxGender.Controls.Add(this.rdbMale);
            this.grpBoxGender.Location = new System.Drawing.Point(80, 65);
            this.grpBoxGender.Name = "grpBoxGender";
            this.grpBoxGender.Size = new System.Drawing.Size(250, 125);
            this.grpBoxGender.TabIndex = 3;
            this.grpBoxGender.TabStop = false;
            this.grpBoxGender.Text = "Gender";
            // 
            // rdbNone
            // 
            this.rdbNone.AutoSize = true;
            this.rdbNone.Location = new System.Drawing.Point(33, 88);
            this.rdbNone.Name = "rdbNone";
            this.rdbNone.Size = new System.Drawing.Size(114, 24);
            this.rdbNone.TabIndex = 2;
            this.rdbNone.TabStop = true;
            this.rdbNone.Text = "Not Disclose";
            this.rdbNone.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(33, 57);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(78, 24);
            this.rdbFemale.TabIndex = 1;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(33, 27);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(63, 24);
            this.rdbMale.TabIndex = 0;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            this.rdbMale.Click += new System.EventHandler(this.rdbMale_Click);
            // 
            // lstHobby
            // 
            this.lstHobby.FormattingEnabled = true;
            this.lstHobby.ItemHeight = 20;
            this.lstHobby.Items.AddRange(new object[] {
            "Game",
            "Movie",
            "Pani",
            "Sleep"});
            this.lstHobby.Location = new System.Drawing.Point(430, 44);
            this.lstHobby.Name = "lstHobby";
            this.lstHobby.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstHobby.Size = new System.Drawing.Size(170, 164);
            this.lstHobby.TabIndex = 4;
            // 
            // lblHobbie
            // 
            this.lblHobbie.AutoSize = true;
            this.lblHobbie.Location = new System.Drawing.Point(453, 13);
            this.lblHobbie.Name = "lblHobbie";
            this.lblHobbie.Size = new System.Drawing.Size(86, 20);
            this.lblHobbie.TabIndex = 5;
            this.lblHobbie.Text = "What to Do";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(628, 299);
            this.Controls.Add(this.lblHobbie);
            this.Controls.Add(this.lstHobby);
            this.Controls.Add(this.grpBoxGender);
            this.Controls.Add(this.btnShowMsg);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "StudentForm";
            this.Text = "StudentInfo";
            this.grpBoxGender.ResumeLayout(false);
            this.grpBoxGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnShowMsg;
        private System.Windows.Forms.GroupBox grpBoxGender;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.RadioButton rdbNone;
        private System.Windows.Forms.ListBox lstHobby;
        private System.Windows.Forms.Label lblHobbie;
    }
}

