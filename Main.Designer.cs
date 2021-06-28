namespace WindowsFormsApplication1
{
    partial class frmMain
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
            this.cmdPr = new System.Windows.Forms.Button();
            this.txtNm = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.NumericUpDown();
            this.txtNasc = new System.Windows.Forms.DateTimePicker();
            this.txtSx = new System.Windows.Forms.ComboBox();
            this.lblNm = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNasc = new System.Windows.Forms.Label();
            this.lblSx = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdPr
            // 
            this.cmdPr.Location = new System.Drawing.Point(15, 129);
            this.cmdPr.Name = "cmdPr";
            this.cmdPr.Size = new System.Drawing.Size(108, 23);
            this.cmdPr.TabIndex = 0;
            this.cmdPr.Text = "Auto preencher";
            this.cmdPr.UseVisualStyleBackColor = true;
            this.cmdPr.Click += new System.EventHandler(this.cmdPr_Click);
            // 
            // txtNm
            // 
            this.txtNm.Location = new System.Drawing.Point(80, 12);
            this.txtNm.Name = "txtNm";
            this.txtNm.Size = new System.Drawing.Size(127, 20);
            this.txtNm.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(80, 38);
            this.txtId.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(127, 20);
            this.txtId.TabIndex = 2;
            // 
            // txtNasc
            // 
            this.txtNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNasc.Location = new System.Drawing.Point(80, 64);
            this.txtNasc.Name = "txtNasc";
            this.txtNasc.Size = new System.Drawing.Size(127, 20);
            this.txtNasc.TabIndex = 3;
            // 
            // txtSx
            // 
            this.txtSx.FormattingEnabled = true;
            this.txtSx.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.txtSx.Location = new System.Drawing.Point(80, 90);
            this.txtSx.Name = "txtSx";
            this.txtSx.Size = new System.Drawing.Size(127, 21);
            this.txtSx.TabIndex = 4;
            // 
            // lblNm
            // 
            this.lblNm.AutoSize = true;
            this.lblNm.Location = new System.Drawing.Point(12, 19);
            this.lblNm.Name = "lblNm";
            this.lblNm.Size = new System.Drawing.Size(38, 13);
            this.lblNm.TabIndex = 5;
            this.lblNm.Text = "Nome:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 45);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(37, 13);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "Idade:";
            // 
            // lblNasc
            // 
            this.lblNasc.AutoSize = true;
            this.lblNasc.Location = new System.Drawing.Point(12, 70);
            this.lblNasc.Name = "lblNasc";
            this.lblNasc.Size = new System.Drawing.Size(66, 13);
            this.lblNasc.TabIndex = 7;
            this.lblNasc.Text = "Nascimento:";
            // 
            // lblSx
            // 
            this.lblSx.AutoSize = true;
            this.lblSx.Location = new System.Drawing.Point(12, 98);
            this.lblSx.Name = "lblSx";
            this.lblSx.Size = new System.Drawing.Size(34, 13);
            this.lblSx.TabIndex = 8;
            this.lblSx.Text = "Sexo:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 162);
            this.Controls.Add(this.lblSx);
            this.Controls.Add(this.lblNasc);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblNm);
            this.Controls.Add(this.txtSx);
            this.Controls.Add(this.txtNasc);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNm);
            this.Controls.Add(this.cmdPr);
            this.Name = "frmMain";
            this.Text = "Auto preenchimento";
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdPr;
        private System.Windows.Forms.TextBox txtNm;
        private System.Windows.Forms.NumericUpDown txtId;
        private System.Windows.Forms.DateTimePicker txtNasc;
        private System.Windows.Forms.ComboBox txtSx;
        private System.Windows.Forms.Label lblNm;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNasc;
        private System.Windows.Forms.Label lblSx;
    }
}

