namespace MultiColumnComboBox
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
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable1 = new Syncfusion.Windows.Forms.MetroColorTable();
            this.multiColumnComboBox1 = new Syncfusion.Windows.Forms.Tools.MultiColumnComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.multiColumnComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // multiColumnComboBox1
            // 
            this.multiColumnComboBox1.BeforeTouchSize = new System.Drawing.Size(165, 21);
            this.multiColumnComboBox1.Location = new System.Drawing.Point(279, 62);
            this.multiColumnComboBox1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.multiColumnComboBox1.Name = "multiColumnComboBox1";
            this.multiColumnComboBox1.ScrollMetroColorTable = metroColorTable1;
            this.multiColumnComboBox1.Size = new System.Drawing.Size(165, 21);
            this.multiColumnComboBox1.TabIndex = 0;
            this.multiColumnComboBox1.Text = "multiColumnComboBox1";
            this.multiColumnComboBox1.DataSource = GetData();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.multiColumnComboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.multiColumnComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.MultiColumnComboBox multiColumnComboBox1;
    }
}

