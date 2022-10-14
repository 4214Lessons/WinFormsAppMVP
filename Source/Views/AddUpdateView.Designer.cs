namespace Source.Views
{
    partial class AddUpdateView
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
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.num_score = new System.Windows.Forms.NumericUpDown();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_date = new System.Windows.Forms.Label();
            this.llb_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_score)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_firstName
            // 
            this.txt_firstName.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_firstName.Location = new System.Drawing.Point(30, 164);
            this.txt_firstName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.PlaceholderText = "FirstName";
            this.txt_firstName.Size = new System.Drawing.Size(171, 33);
            this.txt_firstName.TabIndex = 3;
            // 
            // txt_lastName
            // 
            this.txt_lastName.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_lastName.Location = new System.Drawing.Point(30, 228);
            this.txt_lastName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.PlaceholderText = "LastName";
            this.txt_lastName.Size = new System.Drawing.Size(169, 33);
            this.txt_lastName.TabIndex = 4;
            // 
            // num_score
            // 
            this.num_score.DecimalPlaces = 1;
            this.num_score.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.num_score.Location = new System.Drawing.Point(28, 292);
            this.num_score.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.num_score.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.num_score.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_score.Name = "num_score";
            this.num_score.Size = new System.Drawing.Size(169, 33);
            this.num_score.TabIndex = 5;
            this.num_score.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(218, 163);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 6;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cancel.Location = new System.Drawing.Point(235, 354);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(173, 46);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Green;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Location = new System.Drawing.Point(45, 354);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(173, 46);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_date.Location = new System.Drawing.Point(255, 137);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(136, 23);
            this.lbl_date.TabIndex = 5;
            this.lbl_date.Text = "Date of birth";
            // 
            // llb_title
            // 
            this.llb_title.AutoSize = true;
            this.llb_title.Font = new System.Drawing.Font("Century", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.llb_title.Location = new System.Drawing.Point(130, 36);
            this.llb_title.Name = "llb_title";
            this.llb_title.Size = new System.Drawing.Size(191, 44);
            this.llb_title.TabIndex = 5;
            this.llb_title.Text = "Add Page";
            // 
            // AddView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 451);
            this.Controls.Add(this.llb_title);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.num_score);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.txt_firstName);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddView";
            ((System.ComponentModel.ISupportInitialize)(this.num_score)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_firstName;
        private TextBox txt_lastName;
        private NumericUpDown num_score;
        private MonthCalendar monthCalendar;
        private Button btn_cancel;
        private Button btn_save;
        private Label lbl_date;
        private Label llb_title;
    }
}