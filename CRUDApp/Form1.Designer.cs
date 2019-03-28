namespace CRUDApp
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.deleteControl1 = new CRUDApp.DeleteControl();
            this.updateControl1 = new CRUDApp.UpdateControl();
            this.viewControl1 = new CRUDApp.ViewControl();
            this.insertControl1 = new CRUDApp.InsertControl();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 87);
            this.button1.TabIndex = 0;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 76);
            this.button2.TabIndex = 1;
            this.button2.Text = "VIEW";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 83);
            this.button3.TabIndex = 2;
            this.button3.Text = "UPDATE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 276);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 80);
            this.button4.TabIndex = 3;
            this.button4.Text = "DELETE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // deleteControl1
            // 
            this.deleteControl1.Location = new System.Drawing.Point(128, 19);
            this.deleteControl1.Name = "deleteControl1";
            this.deleteControl1.Size = new System.Drawing.Size(521, 340);
            this.deleteControl1.TabIndex = 7;
            // 
            // updateControl1
            // 
            this.updateControl1.Location = new System.Drawing.Point(128, 19);
            this.updateControl1.Name = "updateControl1";
            this.updateControl1.Size = new System.Drawing.Size(499, 348);
            this.updateControl1.TabIndex = 6;
            // 
            // viewControl1
            // 
            this.viewControl1.Location = new System.Drawing.Point(141, 12);
            this.viewControl1.Name = "viewControl1";
            this.viewControl1.Size = new System.Drawing.Size(482, 355);
            this.viewControl1.TabIndex = 5;
            // 
            // insertControl1
            // 
            this.insertControl1.Location = new System.Drawing.Point(128, 12);
            this.insertControl1.Name = "insertControl1";
            this.insertControl1.Size = new System.Drawing.Size(516, 344);
            this.insertControl1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 365);
            this.Controls.Add(this.deleteControl1);
            this.Controls.Add(this.updateControl1);
            this.Controls.Add(this.viewControl1);
            this.Controls.Add(this.insertControl1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "CRUD Application // Ahmad Irfan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private InsertControl insertControl1;
        private ViewControl viewControl1;
        private UpdateControl updateControl1;
        private DeleteControl deleteControl1;
    }
}

