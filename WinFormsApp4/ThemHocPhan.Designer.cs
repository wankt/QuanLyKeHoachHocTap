﻿namespace WinFormsApp4
{
    partial class ThemHocPhan
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            dataGridView1 = new DataGridView();
            filehtml = new OpenFileDialog();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            button5 = new Button();
            bordera = new Panel();
            button1 = new Button();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            bordera.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(dataGridView1);
            flowLayoutPanel1.Location = new Point(5, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1335, 716);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1321, 538);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(5, 6);
            panel1.Margin = new Padding(20);
            panel1.Name = "panel1";
            panel1.Size = new Size(1572, 106);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(521, 81);
            label1.TabIndex = 2;
            label1.Text = "Kế hoạch học tập";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button5);
            panel2.Location = new Point(1356, 115);
            panel2.Name = "panel2";
            panel2.Size = new Size(221, 731);
            panel2.TabIndex = 10;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(52, 36);
            button5.Name = "button5";
            button5.Size = new Size(142, 52);
            button5.TabIndex = 7;
            button5.Text = "Xác nhận";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // bordera
            // 
            bordera.BorderStyle = BorderStyle.FixedSingle;
            bordera.Controls.Add(flowLayoutPanel1);
            bordera.Location = new Point(5, 115);
            bordera.Name = "bordera";
            bordera.Size = new Size(1345, 731);
            bordera.TabIndex = 11;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(52, 125);
            button1.Name = "button1";
            button1.Size = new Size(142, 52);
            button1.TabIndex = 8;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // ThemHocPhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(bordera);
            Name = "ThemHocPhan";
            Text = "ThemHocPhan";
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            bordera.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private OpenFileDialog filehtml;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button button5;
        private Panel bordera;
        private DataGridView dataGridView1;
        private Button button1;
    }
}