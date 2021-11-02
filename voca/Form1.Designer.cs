
namespace voca
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.tbword = new System.Windows.Forms.TextBox();
            this.tbmean = new System.Windows.Forms.TextBox();
            this.word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meaning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.word,
            this.meaning});
            this.dataGridView1.Location = new System.Drawing.Point(12, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(243, 371);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(186, 13);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(69, 48);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "추가";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // tbword
            // 
            this.tbword.Location = new System.Drawing.Point(13, 13);
            this.tbword.Name = "tbword";
            this.tbword.Size = new System.Drawing.Size(168, 23);
            this.tbword.TabIndex = 2;
            // 
            // tbmean
            // 
            this.tbmean.Location = new System.Drawing.Point(13, 39);
            this.tbmean.Name = "tbmean";
            this.tbmean.Size = new System.Drawing.Size(168, 23);
            this.tbmean.TabIndex = 3;
            // 
            // word
            // 
            this.word.HeaderText = "Word";
            this.word.Name = "word";
            // 
            // meaning
            // 
            this.meaning.HeaderText = "Meaning";
            this.meaning.Name = "meaning";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 450);
            this.Controls.Add(this.tbmean);
            this.Controls.Add(this.tbword);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn word;
        private System.Windows.Forms.DataGridViewTextBoxColumn meaning;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox tbword;
        private System.Windows.Forms.TextBox tbmean;
    }
}

