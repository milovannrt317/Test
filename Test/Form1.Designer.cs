namespace Test
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.chkUI = new System.Windows.Forms.CheckBox();
            this.chkFile = new System.Windows.Forms.CheckBox();
            this.gbDsplMode = new System.Windows.Forms.GroupBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.gbOrder = new System.Windows.Forms.GroupBox();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbAsc = new System.Windows.Forms.RadioButton();
            this.rbDesc = new System.Windows.Forms.RadioButton();
            this.gbDsplMode.SuspendLayout();
            this.gbOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numbers:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(12, 46);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(164, 20);
            this.txtNum.TabIndex = 2;
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // chkUI
            // 
            this.chkUI.AutoSize = true;
            this.chkUI.Checked = true;
            this.chkUI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUI.Location = new System.Drawing.Point(30, 34);
            this.chkUI.Name = "chkUI";
            this.chkUI.Size = new System.Drawing.Size(54, 17);
            this.chkUI.TabIndex = 3;
            this.chkUI.Text = "On UI";
            this.chkUI.UseVisualStyleBackColor = true;
            // 
            // chkFile
            // 
            this.chkFile.AutoSize = true;
            this.chkFile.Location = new System.Drawing.Point(30, 57);
            this.chkFile.Name = "chkFile";
            this.chkFile.Size = new System.Drawing.Size(54, 17);
            this.chkFile.TabIndex = 4;
            this.chkFile.Text = "In File";
            this.chkFile.UseVisualStyleBackColor = true;
            // 
            // gbDsplMode
            // 
            this.gbDsplMode.Controls.Add(this.chkUI);
            this.gbDsplMode.Controls.Add(this.chkFile);
            this.gbDsplMode.Location = new System.Drawing.Point(12, 96);
            this.gbDsplMode.Name = "gbDsplMode";
            this.gbDsplMode.Size = new System.Drawing.Size(123, 100);
            this.gbDsplMode.TabIndex = 5;
            this.gbDsplMode.TabStop = false;
            this.gbDsplMode.Text = "Display mode";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(12, 346);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(434, 34);
            this.btnSort.TabIndex = 6;
            this.btnSort.Text = "SORT";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // gbOrder
            // 
            this.gbOrder.Controls.Add(this.rbDesc);
            this.gbOrder.Controls.Add(this.rbAsc);
            this.gbOrder.Location = new System.Drawing.Point(15, 202);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Size = new System.Drawing.Size(123, 90);
            this.gbOrder.TabIndex = 8;
            this.gbOrder.TabStop = false;
            this.gbOrder.Text = "Order";
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.HorizontalScrollbar = true;
            this.lstResults.Location = new System.Drawing.Point(193, 46);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(253, 277);
            this.lstResults.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Result:";
            // 
            // rbAsc
            // 
            this.rbAsc.AutoSize = true;
            this.rbAsc.Checked = true;
            this.rbAsc.Location = new System.Drawing.Point(21, 25);
            this.rbAsc.Name = "rbAsc";
            this.rbAsc.Size = new System.Drawing.Size(75, 17);
            this.rbAsc.TabIndex = 0;
            this.rbAsc.TabStop = true;
            this.rbAsc.Text = "Ascending";
            this.rbAsc.UseVisualStyleBackColor = true;
            // 
            // rbDesc
            // 
            this.rbDesc.AutoSize = true;
            this.rbDesc.Location = new System.Drawing.Point(21, 57);
            this.rbDesc.Name = "rbDesc";
            this.rbDesc.Size = new System.Drawing.Size(82, 17);
            this.rbDesc.TabIndex = 1;
            this.rbDesc.Text = "Descending";
            this.rbDesc.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 398);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.gbOrder);
            this.Controls.Add(this.gbDsplMode);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbDsplMode.ResumeLayout(false);
            this.gbDsplMode.PerformLayout();
            this.gbOrder.ResumeLayout(false);
            this.gbOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.CheckBox chkUI;
        private System.Windows.Forms.CheckBox chkFile;
        private System.Windows.Forms.GroupBox gbDsplMode;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.GroupBox gbOrder;
        private System.Windows.Forms.RadioButton rbDesc;
        private System.Windows.Forms.RadioButton rbAsc;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Label label2;
    }
}

