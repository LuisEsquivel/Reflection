namespace Reflection
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
            this.Generate = new System.Windows.Forms.Button();
            this.RdbSelect = new System.Windows.Forms.RadioButton();
            this.RdbInsert = new System.Windows.Forms.RadioButton();
            this.RdbDelete = new System.Windows.Forms.RadioButton();
            this.RdbUpdate = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RdbEmployee = new System.Windows.Forms.RadioButton();
            this.RdbPosition = new System.Windows.Forms.RadioButton();
            this.RdbAsset = new System.Windows.Forms.RadioButton();
            this.TxtSqlScript = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(387, 25);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(157, 72);
            this.Generate.TabIndex = 0;
            this.Generate.Text = "button1";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // RdbSelect
            // 
            this.RdbSelect.AutoSize = true;
            this.RdbSelect.Location = new System.Drawing.Point(0, 24);
            this.RdbSelect.Name = "RdbSelect";
            this.RdbSelect.Size = new System.Drawing.Size(55, 17);
            this.RdbSelect.TabIndex = 1;
            this.RdbSelect.TabStop = true;
            this.RdbSelect.Text = "Select";
            this.RdbSelect.UseVisualStyleBackColor = true;
            // 
            // RdbInsert
            // 
            this.RdbInsert.AutoSize = true;
            this.RdbInsert.Location = new System.Drawing.Point(145, 24);
            this.RdbInsert.Name = "RdbInsert";
            this.RdbInsert.Size = new System.Drawing.Size(51, 17);
            this.RdbInsert.TabIndex = 2;
            this.RdbInsert.TabStop = true;
            this.RdbInsert.Text = "Insert";
            this.RdbInsert.UseVisualStyleBackColor = true;
            // 
            // RdbDelete
            // 
            this.RdbDelete.AutoSize = true;
            this.RdbDelete.Location = new System.Drawing.Point(461, 24);
            this.RdbDelete.Name = "RdbDelete";
            this.RdbDelete.Size = new System.Drawing.Size(56, 17);
            this.RdbDelete.TabIndex = 4;
            this.RdbDelete.TabStop = true;
            this.RdbDelete.Text = "Delete";
            this.RdbDelete.UseVisualStyleBackColor = true;
            // 
            // RdbUpdate
            // 
            this.RdbUpdate.AutoSize = true;
            this.RdbUpdate.Location = new System.Drawing.Point(313, 24);
            this.RdbUpdate.Name = "RdbUpdate";
            this.RdbUpdate.Size = new System.Drawing.Size(60, 17);
            this.RdbUpdate.TabIndex = 3;
            this.RdbUpdate.TabStop = true;
            this.RdbUpdate.Text = "Update";
            this.RdbUpdate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Generated Sql Script";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdbDelete);
            this.groupBox1.Controls.Add(this.RdbSelect);
            this.groupBox1.Controls.Add(this.RdbInsert);
            this.groupBox1.Controls.Add(this.RdbUpdate);
            this.groupBox1.Location = new System.Drawing.Point(18, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 47);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sql Query Option";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RdbEmployee);
            this.groupBox2.Controls.Add(this.RdbPosition);
            this.groupBox2.Controls.Add(this.RdbAsset);
            this.groupBox2.Location = new System.Drawing.Point(18, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 47);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Model";
            // 
            // RdbEmployee
            // 
            this.RdbEmployee.AutoSize = true;
            this.RdbEmployee.Location = new System.Drawing.Point(0, 24);
            this.RdbEmployee.Name = "RdbEmployee";
            this.RdbEmployee.Size = new System.Drawing.Size(71, 17);
            this.RdbEmployee.TabIndex = 1;
            this.RdbEmployee.TabStop = true;
            this.RdbEmployee.Text = "Employee";
            this.RdbEmployee.UseVisualStyleBackColor = true;
            // 
            // RdbPosition
            // 
            this.RdbPosition.AutoSize = true;
            this.RdbPosition.Location = new System.Drawing.Point(145, 24);
            this.RdbPosition.Name = "RdbPosition";
            this.RdbPosition.Size = new System.Drawing.Size(62, 17);
            this.RdbPosition.TabIndex = 2;
            this.RdbPosition.TabStop = true;
            this.RdbPosition.Text = "Position";
            this.RdbPosition.UseVisualStyleBackColor = true;
            // 
            // RdbAsset
            // 
            this.RdbAsset.AutoSize = true;
            this.RdbAsset.Location = new System.Drawing.Point(313, 24);
            this.RdbAsset.Name = "RdbAsset";
            this.RdbAsset.Size = new System.Drawing.Size(51, 17);
            this.RdbAsset.TabIndex = 3;
            this.RdbAsset.TabStop = true;
            this.RdbAsset.Text = "Asset";
            this.RdbAsset.UseVisualStyleBackColor = true;
            // 
            // TxtSqlScript
            // 
            this.TxtSqlScript.Location = new System.Drawing.Point(18, 302);
            this.TxtSqlScript.Name = "TxtSqlScript";
            this.TxtSqlScript.Size = new System.Drawing.Size(526, 183);
            this.TxtSqlScript.TabIndex = 9;
            this.TxtSqlScript.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 497);
            this.Controls.Add(this.TxtSqlScript);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Generate);
            this.Name = "Form1";
            this.Text = "Reflection";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.RadioButton RdbSelect;
        private System.Windows.Forms.RadioButton RdbInsert;
        private System.Windows.Forms.RadioButton RdbDelete;
        private System.Windows.Forms.RadioButton RdbUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RdbEmployee;
        private System.Windows.Forms.RadioButton RdbPosition;
        private System.Windows.Forms.RadioButton RdbAsset;
        private System.Windows.Forms.RichTextBox TxtSqlScript;
    }
}

