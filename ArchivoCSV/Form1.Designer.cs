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
            this.btnXml = new System.Windows.Forms.Button();
            this.btnRtf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvUserData)).BeginInit();
            this.gpDataViewer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtvUserData
            // 
            this.dtvUserData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvUserData.Location = new System.Drawing.Point(109, 73);
            this.dtvUserData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtvUserData.Name = "dtvUserData";
            this.dtvUserData.RowHeadersWidth = 51;
            this.dtvUserData.Size = new System.Drawing.Size(524, 289);
            this.dtvUserData.TabIndex = 0;
            // 
            // gpDataViewer
            // 
            this.gpDataViewer.Controls.Add(this.dtvUserData);
            this.gpDataViewer.Location = new System.Drawing.Point(188, 85);
            this.gpDataViewer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpDataViewer.Name = "gpDataViewer";
            this.gpDataViewer.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpDataViewer.Size = new System.Drawing.Size(736, 454);
            this.gpDataViewer.TabIndex = 1;
            this.gpDataViewer.TabStop = false;
            // 
            // txtInsertData
            // 
            this.txtInsertData.Location = new System.Drawing.Point(188, 53);
            this.txtInsertData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInsertData.Name = "txtInsertData";
            this.txtInsertData.Size = new System.Drawing.Size(355, 22);
            this.txtInsertData.TabIndex = 2;
            this.txtInsertData.Text = "Data viewer (TXT/CSV/XML/RTF)";
            // 
            // btnButton
            // 
            this.btnButton.Location = new System.Drawing.Point(21, 138);
            this.btnButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(159, 25);
            this.btnButton.TabIndex = 3;
            this.btnButton.Text = "Select your CSV file";
            this.btnButton.UseVisualStyleBackColor = true;
            this.btnButton.Click += new System.EventHandler(this.btnButton_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(932, 112);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnTxl
            // 
            this.btnTxl.Location = new System.Drawing.Point(21, 171);
            this.btnTxl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTxl.Name = "btnTxl";
            this.btnTxl.Size = new System.Drawing.Size(159, 25);
            this.btnTxl.TabIndex = 5;
            this.btnTxl.Text = "Select your TXT file";
            this.btnTxl.UseVisualStyleBackColor = true;
            this.btnTxl.Click += new System.EventHandler(this.btnTxl_Click);
            // 
            // btnXml
            // 
            this.btnXml.Location = new System.Drawing.Point(21, 215);
            this.btnXml.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(159, 25);
            this.btnXml.TabIndex = 6;
            this.btnXml.Text = "Select your XML file";
            this.btnXml.UseVisualStyleBackColor = true;
            this.btnXml.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRtf
            // 
            this.btnRtf.Location = new System.Drawing.Point(21, 257);
            this.btnRtf.Margin = new System.Windows.Forms.Padding(4);
            this.btnRtf.Name = "btnRtf";
            this.btnRtf.Size = new System.Drawing.Size(159, 25);
            this.btnRtf.TabIndex = 7;
            this.btnRtf.Text = "Select your RTF file";
            this.btnRtf.UseVisualStyleBackColor = true;
            this.btnRtf.Click += new System.EventHandler(this.btnRtf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnRtf);
            this.Controls.Add(this.btnXml);
            this.Controls.Add(this.btnTxl);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnButton);
            this.Controls.Add(this.txtInsertData);
            this.Controls.Add(this.gpDataViewer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btnXml;
        private System.Windows.Forms.Button btnRtf;
    }
}

