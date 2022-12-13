namespace Gyakorlas2
{
    partial class UserControl3
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lessonSkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseFkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorFkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayFkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeFkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomFkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(24, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 244);
            this.listBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lessonSkDataGridViewTextBoxColumn,
            this.courseFkDataGridViewTextBoxColumn,
            this.instructorFkDataGridViewTextBoxColumn,
            this.dayFkDataGridViewTextBoxColumn,
            this.timeFkDataGridViewTextBoxColumn,
            this.roomFkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lessonBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(150, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(651, 244);
            this.dataGridView1.TabIndex = 1;
            // 
            // lessonSkDataGridViewTextBoxColumn
            // 
            this.lessonSkDataGridViewTextBoxColumn.DataPropertyName = "LessonSk";
            this.lessonSkDataGridViewTextBoxColumn.HeaderText = "LessonSk";
            this.lessonSkDataGridViewTextBoxColumn.Name = "lessonSkDataGridViewTextBoxColumn";
            // 
            // courseFkDataGridViewTextBoxColumn
            // 
            this.courseFkDataGridViewTextBoxColumn.DataPropertyName = "CourseFk";
            this.courseFkDataGridViewTextBoxColumn.HeaderText = "CourseFk";
            this.courseFkDataGridViewTextBoxColumn.Name = "courseFkDataGridViewTextBoxColumn";
            // 
            // instructorFkDataGridViewTextBoxColumn
            // 
            this.instructorFkDataGridViewTextBoxColumn.DataPropertyName = "InstructorFk";
            this.instructorFkDataGridViewTextBoxColumn.HeaderText = "InstructorFk";
            this.instructorFkDataGridViewTextBoxColumn.Name = "instructorFkDataGridViewTextBoxColumn";
            // 
            // dayFkDataGridViewTextBoxColumn
            // 
            this.dayFkDataGridViewTextBoxColumn.DataPropertyName = "DayFk";
            this.dayFkDataGridViewTextBoxColumn.HeaderText = "DayFk";
            this.dayFkDataGridViewTextBoxColumn.Name = "dayFkDataGridViewTextBoxColumn";
            // 
            // timeFkDataGridViewTextBoxColumn
            // 
            this.timeFkDataGridViewTextBoxColumn.DataPropertyName = "TimeFk";
            this.timeFkDataGridViewTextBoxColumn.HeaderText = "TimeFk";
            this.timeFkDataGridViewTextBoxColumn.Name = "timeFkDataGridViewTextBoxColumn";
            // 
            // roomFkDataGridViewTextBoxColumn
            // 
            this.roomFkDataGridViewTextBoxColumn.DataPropertyName = "RoomFk";
            this.roomFkDataGridViewTextBoxColumn.HeaderText = "RoomFk";
            this.roomFkDataGridViewTextBoxColumn.Name = "roomFkDataGridViewTextBoxColumn";
            // 
            // lessonBindingSource
            // 
            this.lessonBindingSource.DataSource = typeof(Gyakorlas2.Models.Lesson);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(34, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(861, 493);
            this.Load += new System.EventHandler(this.UserControl3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn lessonSkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn courseFkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn instructorFkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dayFkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeFkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomFkDataGridViewTextBoxColumn;
        private BindingSource lessonBindingSource;
        private Button button1;
    }
}
