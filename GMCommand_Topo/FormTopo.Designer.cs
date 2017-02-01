namespace FH.Kaernten.GIS.GeoMedia.Topo.Command
{
    partial class FormTopo
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
            this.cboConnection = new System.Windows.Forms.ComboBox();
            this.cboTable = new System.Windows.Forms.ComboBox();
            this.cbxNodex = new System.Windows.Forms.CheckBox();
            this.cbxEdges = new System.Windows.Forms.CheckBox();
            this.cbxFaces = new System.Windows.Forms.CheckBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Table";
            // 
            // cboConnection
            // 
            this.cboConnection.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cboConnection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConnection.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboConnection.FormattingEnabled = true;
            this.cboConnection.Location = new System.Drawing.Point(126, 21);
            this.cboConnection.Name = "cboConnection";
            this.cboConnection.Size = new System.Drawing.Size(320, 27);
            this.cboConnection.TabIndex = 2;
            this.cboConnection.SelectedIndexChanged += new System.EventHandler(this.cboConnection_SelectedIndexChanged);
            // 
            // cboTable
            // 
            this.cboTable.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cboTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTable.FormattingEnabled = true;
            this.cboTable.Location = new System.Drawing.Point(126, 55);
            this.cboTable.Name = "cboTable";
            this.cboTable.Size = new System.Drawing.Size(320, 27);
            this.cboTable.TabIndex = 3;
            this.cboTable.SelectedIndexChanged += new System.EventHandler(this.cboTable_SelectedIndexChanged);
            // 
            // cbxNodex
            // 
            this.cbxNodex.AutoSize = true;
            this.cbxNodex.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNodex.Location = new System.Drawing.Point(126, 94);
            this.cbxNodex.Name = "cbxNodex";
            this.cbxNodex.Size = new System.Drawing.Size(67, 22);
            this.cbxNodex.TabIndex = 4;
            this.cbxNodex.Text = "Nodes";
            this.cbxNodex.UseVisualStyleBackColor = true;
            this.cbxNodex.CheckedChanged += new System.EventHandler(this.cbxNodex_CheckedChanged);
            // 
            // cbxEdges
            // 
            this.cbxEdges.AutoSize = true;
            this.cbxEdges.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEdges.Location = new System.Drawing.Point(246, 94);
            this.cbxEdges.Name = "cbxEdges";
            this.cbxEdges.Size = new System.Drawing.Size(63, 22);
            this.cbxEdges.TabIndex = 5;
            this.cbxEdges.Text = "Edges";
            this.cbxEdges.UseVisualStyleBackColor = true;
            this.cbxEdges.CheckedChanged += new System.EventHandler(this.cbxEdges_CheckedChanged);
            // 
            // cbxFaces
            // 
            this.cbxFaces.AutoSize = true;
            this.cbxFaces.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFaces.Location = new System.Drawing.Point(385, 94);
            this.cbxFaces.Name = "cbxFaces";
            this.cbxFaces.Size = new System.Drawing.Size(61, 22);
            this.cbxFaces.TabIndex = 6;
            this.cbxFaces.Text = "Faces";
            this.cbxFaces.UseVisualStyleBackColor = true;
            this.cbxFaces.CheckedChanged += new System.EventHandler(this.cbxFaces_CheckedChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Enabled = false;
            this.btnConvert.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(267, 132);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 30);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(371, 132);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "To Create";
            // 
            // FormTopo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(485, 181);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.cbxFaces);
            this.Controls.Add(this.cbxEdges);
            this.Controls.Add(this.cbxNodex);
            this.Controls.Add(this.cboTable);
            this.Controls.Add(this.cboConnection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTopo";
            this.Text = "Topology";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboConnection;
        private System.Windows.Forms.ComboBox cboTable;
        private System.Windows.Forms.CheckBox cbxNodex;
        private System.Windows.Forms.CheckBox cbxEdges;
        private System.Windows.Forms.CheckBox cbxFaces;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
    }
}