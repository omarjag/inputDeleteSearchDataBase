namespace sample1DB
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.fNametxtBox = new System.Windows.Forms.TextBox();
			this.lNametxtBox = new System.Windows.Forms.TextBox();
			this.stateTxtBox = new System.Windows.Forms.TextBox();
			this.insertBtn = new System.Windows.Forms.Button();
			this.deleteBtn = new System.Windows.Forms.Button();
			this.disBtn = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.searchBtn = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(0, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "First Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(0, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Last Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(0, 109);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "State";
			// 
			// fNametxtBox
			// 
			this.fNametxtBox.Location = new System.Drawing.Point(63, 23);
			this.fNametxtBox.Name = "fNametxtBox";
			this.fNametxtBox.Size = new System.Drawing.Size(100, 20);
			this.fNametxtBox.TabIndex = 3;
			this.fNametxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// lNametxtBox
			// 
			this.lNametxtBox.Location = new System.Drawing.Point(63, 68);
			this.lNametxtBox.Name = "lNametxtBox";
			this.lNametxtBox.Size = new System.Drawing.Size(100, 20);
			this.lNametxtBox.TabIndex = 4;
			// 
			// stateTxtBox
			// 
			this.stateTxtBox.Location = new System.Drawing.Point(63, 109);
			this.stateTxtBox.Name = "stateTxtBox";
			this.stateTxtBox.Size = new System.Drawing.Size(100, 20);
			this.stateTxtBox.TabIndex = 5;
			// 
			// insertBtn
			// 
			this.insertBtn.Location = new System.Drawing.Point(3, 183);
			this.insertBtn.Name = "insertBtn";
			this.insertBtn.Size = new System.Drawing.Size(75, 23);
			this.insertBtn.TabIndex = 6;
			this.insertBtn.Text = "Insert";
			this.insertBtn.UseVisualStyleBackColor = true;
			this.insertBtn.Click += new System.EventHandler(this.button1_Click);
			// 
			// deleteBtn
			// 
			this.deleteBtn.Location = new System.Drawing.Point(84, 183);
			this.deleteBtn.Name = "deleteBtn";
			this.deleteBtn.Size = new System.Drawing.Size(75, 23);
			this.deleteBtn.TabIndex = 7;
			this.deleteBtn.Text = "Delete";
			this.deleteBtn.UseVisualStyleBackColor = true;
			this.deleteBtn.Click += new System.EventHandler(this.button2_Click);
			// 
			// disBtn
			// 
			this.disBtn.Location = new System.Drawing.Point(84, 228);
			this.disBtn.Name = "disBtn";
			this.disBtn.Size = new System.Drawing.Size(75, 23);
			this.disBtn.TabIndex = 9;
			this.disBtn.Text = "Display";
			this.disBtn.UseVisualStyleBackColor = true;
			this.disBtn.Click += new System.EventHandler(this.button4_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(281, 23);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(297, 271);
			this.dataGridView1.TabIndex = 10;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// searchBtn
			// 
			this.searchBtn.Location = new System.Drawing.Point(3, 228);
			this.searchBtn.Name = "searchBtn";
			this.searchBtn.Size = new System.Drawing.Size(75, 23);
			this.searchBtn.TabIndex = 11;
			this.searchBtn.Text = "Search";
			this.searchBtn.UseVisualStyleBackColor = true;
			this.searchBtn.Click += new System.EventHandler(this.button5_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(0, 137);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(159, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "*This program is CASE Sensitive";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(0, 150);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(173, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "*Press Display to return to Main List";
			// 
			// Form1
			// 
			this.AcceptButton = this.insertBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(590, 347);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.searchBtn);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.disBtn);
			this.Controls.Add(this.deleteBtn);
			this.Controls.Add(this.insertBtn);
			this.Controls.Add(this.stateTxtBox);
			this.Controls.Add(this.lNametxtBox);
			this.Controls.Add(this.fNametxtBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Insert/Delete/Search Sample";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox fNametxtBox;
		private System.Windows.Forms.TextBox lNametxtBox;
		private System.Windows.Forms.TextBox stateTxtBox;
		private System.Windows.Forms.Button insertBtn;
		private System.Windows.Forms.Button deleteBtn;
		private System.Windows.Forms.Button disBtn;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button searchBtn;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}

