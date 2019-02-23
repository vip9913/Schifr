namespace schifr
{
    partial class FormSchifr
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
            this.tBoxMessage = new System.Windows.Forms.TextBox();
            this.tBoxKey = new System.Windows.Forms.TextBox();
            this.tBoxKeyABC = new System.Windows.Forms.TextBox();
            this.tBoxSchifr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btSchifr = new System.Windows.Forms.Button();
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.grid2 = new System.Windows.Forms.DataGridView();
            this.grid4 = new System.Windows.Forms.DataGridView();
            this.grid3 = new System.Windows.Forms.DataGridView();
            this.btDeSchifr = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tBoxGetMessage = new System.Windows.Forms.TextBox();
            this.tBoxGetKeyAbs = new System.Windows.Forms.TextBox();
            this.tBoxGetKey = new System.Windows.Forms.TextBox();
            this.tBoxGetSchifr = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid3)).BeginInit();
            this.SuspendLayout();
            // 
            // tBoxMessage
            // 
            this.tBoxMessage.Location = new System.Drawing.Point(12, 24);
            this.tBoxMessage.Name = "tBoxMessage";
            this.tBoxMessage.Size = new System.Drawing.Size(239, 20);
            this.tBoxMessage.TabIndex = 0;
            this.tBoxMessage.Text = "У ЛУКОМОРЬЯ ДУБ ЗЕЛЕНЫЙ.";
            // 
            // tBoxKey
            // 
            this.tBoxKey.Location = new System.Drawing.Point(11, 65);
            this.tBoxKey.Name = "tBoxKey";
            this.tBoxKey.Size = new System.Drawing.Size(100, 20);
            this.tBoxKey.TabIndex = 1;
            this.tBoxKey.Text = "ПУШКИН";
            // 
            // tBoxKeyABC
            // 
            this.tBoxKeyABC.Location = new System.Drawing.Point(151, 65);
            this.tBoxKeyABC.Name = "tBoxKeyABC";
            this.tBoxKeyABC.ReadOnly = true;
            this.tBoxKeyABC.Size = new System.Drawing.Size(100, 20);
            this.tBoxKeyABC.TabIndex = 2;
            // 
            // tBoxSchifr
            // 
            this.tBoxSchifr.Location = new System.Drawing.Point(12, 146);
            this.tBoxSchifr.Name = "tBoxSchifr";
            this.tBoxSchifr.ReadOnly = true;
            this.tBoxSchifr.Size = new System.Drawing.Size(239, 20);
            this.tBoxSchifr.TabIndex = 3;
       
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Исходное сообщение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Алфавит Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ШИФР";
            // 
            // btSchifr
            // 
            this.btSchifr.Location = new System.Drawing.Point(11, 91);
            this.btSchifr.Name = "btSchifr";
            this.btSchifr.Size = new System.Drawing.Size(240, 23);
            this.btSchifr.TabIndex = 8;
            this.btSchifr.Text = "Шифратор";
            this.btSchifr.UseVisualStyleBackColor = true;
            this.btSchifr.Click += new System.EventHandler(this.btSchifr_Click);
            // 
            // grid1
            // 
            this.grid1.AllowUserToAddRows = false;
            this.grid1.AllowUserToDeleteRows = false;
            this.grid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.Location = new System.Drawing.Point(11, 184);
            this.grid1.Name = "grid1";
            this.grid1.ReadOnly = true;
            this.grid1.Size = new System.Drawing.Size(240, 150);
            this.grid1.TabIndex = 9;
            // 
            // grid2
            // 
            this.grid2.AllowUserToAddRows = false;
            this.grid2.AllowUserToDeleteRows = false;
            this.grid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid2.Location = new System.Drawing.Point(11, 340);
            this.grid2.Name = "grid2";
            this.grid2.ReadOnly = true;
            this.grid2.Size = new System.Drawing.Size(240, 150);
            this.grid2.TabIndex = 10;
            // 
            // grid4
            // 
            this.grid4.AllowUserToAddRows = false;
            this.grid4.AllowUserToDeleteRows = false;
            this.grid4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid4.Location = new System.Drawing.Point(295, 340);
            this.grid4.Name = "grid4";
            this.grid4.ReadOnly = true;
            this.grid4.Size = new System.Drawing.Size(240, 150);
            this.grid4.TabIndex = 21;
            // 
            // grid3
            // 
            this.grid3.AllowUserToAddRows = false;
            this.grid3.AllowUserToDeleteRows = false;
            this.grid3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid3.Location = new System.Drawing.Point(295, 184);
            this.grid3.Name = "grid3";
            this.grid3.ReadOnly = true;
            this.grid3.Size = new System.Drawing.Size(240, 150);
            this.grid3.TabIndex = 20;
            // 
            // btDeSchifr
            // 
            this.btDeSchifr.Location = new System.Drawing.Point(295, 91);
            this.btDeSchifr.Name = "btDeSchifr";
            this.btDeSchifr.Size = new System.Drawing.Size(240, 23);
            this.btDeSchifr.TabIndex = 19;
            this.btDeSchifr.Text = "Дешифратор";
            this.btDeSchifr.UseVisualStyleBackColor = true;
            this.btDeSchifr.Click += new System.EventHandler(this.btDeSchifr_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "РАСШИФРОВКА";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Алфавит Key";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Key";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Полученное сообщение";
            // 
            // tBoxGetMessage
            // 
            this.tBoxGetMessage.Location = new System.Drawing.Point(296, 146);
            this.tBoxGetMessage.Name = "tBoxGetMessage";
            this.tBoxGetMessage.ReadOnly = true;
            this.tBoxGetMessage.Size = new System.Drawing.Size(239, 20);
            this.tBoxGetMessage.TabIndex = 14;
            // 
            // tBoxGetKeyAbs
            // 
            this.tBoxGetKeyAbs.Location = new System.Drawing.Point(435, 65);
            this.tBoxGetKeyAbs.Name = "tBoxGetKeyAbs";
            this.tBoxGetKeyAbs.ReadOnly = true;
            this.tBoxGetKeyAbs.Size = new System.Drawing.Size(100, 20);
            this.tBoxGetKeyAbs.TabIndex = 13;
            // 
            // tBoxGetKey
            // 
            this.tBoxGetKey.Location = new System.Drawing.Point(295, 65);
            this.tBoxGetKey.Name = "tBoxGetKey";
            this.tBoxGetKey.Size = new System.Drawing.Size(100, 20);
            this.tBoxGetKey.TabIndex = 12;
            this.tBoxGetKey.Text = "ПУШКИН";
            // 
            // tBoxGetSchifr
            // 
            this.tBoxGetSchifr.Location = new System.Drawing.Point(296, 24);
            this.tBoxGetSchifr.Name = "tBoxGetSchifr";
            this.tBoxGetSchifr.Size = new System.Drawing.Size(239, 20);
            this.tBoxGetSchifr.TabIndex = 11;
            // 
            // FormSchifr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 534);
            this.Controls.Add(this.grid4);
            this.Controls.Add(this.grid3);
            this.Controls.Add(this.btDeSchifr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tBoxGetMessage);
            this.Controls.Add(this.tBoxGetKeyAbs);
            this.Controls.Add(this.tBoxGetKey);
            this.Controls.Add(this.tBoxGetSchifr);
            this.Controls.Add(this.grid2);
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.btSchifr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxSchifr);
            this.Controls.Add(this.tBoxKeyABC);
            this.Controls.Add(this.tBoxKey);
            this.Controls.Add(this.tBoxMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormSchifr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Методы шифрования";
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxMessage;
        private System.Windows.Forms.TextBox tBoxKey;
        private System.Windows.Forms.TextBox tBoxKeyABC;
        private System.Windows.Forms.TextBox tBoxSchifr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btSchifr;
        private System.Windows.Forms.DataGridView grid1;
        private System.Windows.Forms.DataGridView grid2;
        private System.Windows.Forms.DataGridView grid4;
        private System.Windows.Forms.DataGridView grid3;
        private System.Windows.Forms.Button btDeSchifr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tBoxGetMessage;
        private System.Windows.Forms.TextBox tBoxGetKeyAbs;
        private System.Windows.Forms.TextBox tBoxGetKey;
        private System.Windows.Forms.TextBox tBoxGetSchifr;
    }
}

