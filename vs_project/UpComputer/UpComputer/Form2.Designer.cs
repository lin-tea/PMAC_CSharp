namespace UpComputer
{
    partial class Form2
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
            this.form2SaveFile = new System.Windows.Forms.Button();
            this.form2Text = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // form2SaveFile
            // 
            this.form2SaveFile.Location = new System.Drawing.Point(3, 3);
            this.form2SaveFile.Name = "form2SaveFile";
            this.form2SaveFile.Size = new System.Drawing.Size(110, 46);
            this.form2SaveFile.TabIndex = 0;
            this.form2SaveFile.Text = "保存";
            this.form2SaveFile.UseVisualStyleBackColor = true;
            this.form2SaveFile.Click += new System.EventHandler(this.form2SaveFile_Click);
            // 
            // form2Text
            // 
            this.form2Text.AcceptsReturn = true;
            this.form2Text.AcceptsTab = true;
            this.form2Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form2Text.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.form2Text.Location = new System.Drawing.Point(3, 65);
            this.form2Text.Multiline = true;
            this.form2Text.Name = "form2Text";
            this.form2Text.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.form2Text.Size = new System.Drawing.Size(849, 471);
            this.form2Text.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.form2Text, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.form2SaveFile, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.68831F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.31169F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(855, 539);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(855, 539);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form2";
            this.Text = "文件";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button form2SaveFile;
        private System.Windows.Forms.TextBox form2Text;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}