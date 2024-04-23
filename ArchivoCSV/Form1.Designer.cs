namespace ArchivoCSV
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtvUserData = new System.Windows.Forms.DataGridView();
            this.gpDataViewer = new System.Windows.Forms.GroupBox();
            this.txtInsertData = new System.Windows.Forms.TextBox();
            this.btnButton = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnTxl = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvUserData)).BeginInit();
            this.gpDataViewer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtvUserData
            // 
            this.dtvUserData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvUserData.Location = new System.Drawing.Point(82, 59);
            this.dtvUserData.Name = "dtvUserData";
            this.dtvUserData.Size = new System.Drawing.Size(393, 235);
            this.dtvUserData.TabIndex = 0;
            // 
            // gpDataViewer
            // 
            this.gpDataViewer.Controls.Add(this.dtvUserData);
            this.gpDataViewer.Location = new System.Drawing.Point(141, 69);
            this.gpDataViewer.Name = "gpDataViewer";
            this.gpDataViewer.Size = new System.Drawing.Size(552, 369);
            this.gpDataViewer.TabIndex = 1;
            this.gpDataViewer.TabStop = false;
            // 
            // txtInsertData
            // 
            this.txtInsertData.Location = new System.Drawing.Point(141, 43);
            this.txtInsertData.Name = "txtInsertData";
            this.txtInsertData.Size = new System.Drawing.Size(267, 20);
            this.txtInsertData.TabIndex = 2;
            this.txtInsertData.Text = "Data viewer (TXT/CSV/XML/RTF)";
            // 
            // btnButton
            // 
            this.btnButton.Location = new System.Drawing.Point(16, 112);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(119, 20);
            this.btnButton.TabIndex = 3;
            this.btnButton.Text = "Select your CSV file";
            this.btnButton.UseVisualStyleBackColor = true;
            this.btnButton.Click += new System.EventHandler(this.btnButton_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(699, 91);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnTxl
            // 
            this.btnTxl.Location = new System.Drawing.Point(16, 149);
            this.btnTxl.Name = "btnTxl";
            this.btnTxl.Size = new System.Drawing.Size(119, 20);
            this.btnTxl.TabIndex = 5;
            this.btnTxl.Text = "Select your TXT file";
            this.btnTxl.UseVisualStyleBackColor = true;
            this.btnTxl.Click += new System.EventHandler(this.btnTxl_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 20);
            this.button1.TabIndex = 6;
            this.button1.Text = "Select your XML file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTxl);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnButton);
            this.Controls.Add(this.txtInsertData);
            this.Controls.Add(this.gpDataViewer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtvUserData)).EndInit();
            this.gpDataViewer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvUserData;
        private System.Windows.Forms.GroupBox gpDataViewer;
        private System.Windows.Forms.TextBox txtInsertData;
        private System.Windows.Forms.Button btnButton;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnTxl;
        private System.Windows.Forms.Button button1;
    }
}

