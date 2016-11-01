namespace Library
{
    partial class AddNewAuthorForm
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
            this.addNewAuthor_btn = new System.Windows.Forms.Button();
            this.addNewAuthorCancel_btn = new System.Windows.Forms.Button();
            this.addNewAuthor_textbox = new System.Windows.Forms.TextBox();
            this.addNewAuthor_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addNewAuthor_btn
            // 
            this.addNewAuthor_btn.Location = new System.Drawing.Point(143, 61);
            this.addNewAuthor_btn.Name = "addNewAuthor_btn";
            this.addNewAuthor_btn.Size = new System.Drawing.Size(114, 36);
            this.addNewAuthor_btn.TabIndex = 0;
            this.addNewAuthor_btn.Text = "Add";
            this.addNewAuthor_btn.UseVisualStyleBackColor = true;
            this.addNewAuthor_btn.Click += new System.EventHandler(this.addNewAuthor_btn_Click);
            // 
            // addNewAuthorCancel_btn
            // 
            this.addNewAuthorCancel_btn.Location = new System.Drawing.Point(12, 61);
            this.addNewAuthorCancel_btn.Name = "addNewAuthorCancel_btn";
            this.addNewAuthorCancel_btn.Size = new System.Drawing.Size(125, 36);
            this.addNewAuthorCancel_btn.TabIndex = 1;
            this.addNewAuthorCancel_btn.Text = "Cancel";
            this.addNewAuthorCancel_btn.UseVisualStyleBackColor = true;
            // 
            // addNewAuthor_textbox
            // 
            this.addNewAuthor_textbox.Location = new System.Drawing.Point(12, 33);
            this.addNewAuthor_textbox.Name = "addNewAuthor_textbox";
            this.addNewAuthor_textbox.Size = new System.Drawing.Size(245, 22);
            this.addNewAuthor_textbox.TabIndex = 2;
            // 
            // addNewAuthor_label
            // 
            this.addNewAuthor_label.AutoSize = true;
            this.addNewAuthor_label.Location = new System.Drawing.Point(13, 13);
            this.addNewAuthor_label.Name = "addNewAuthor_label";
            this.addNewAuthor_label.Size = new System.Drawing.Size(156, 17);
            this.addNewAuthor_label.TabIndex = 3;
            this.addNewAuthor_label.Text = "Add new author (name)";
            // 
            // AddNewAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 109);
            this.Controls.Add(this.addNewAuthor_label);
            this.Controls.Add(this.addNewAuthor_textbox);
            this.Controls.Add(this.addNewAuthorCancel_btn);
            this.Controls.Add(this.addNewAuthor_btn);
            this.Name = "AddNewAuthorForm";
            this.Text = "AddNewAuthorForm";
            this.Load += new System.EventHandler(this.AddNewAuthorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNewAuthor_btn;
        private System.Windows.Forms.Button addNewAuthorCancel_btn;
        private System.Windows.Forms.TextBox addNewAuthor_textbox;
        private System.Windows.Forms.Label addNewAuthor_label;
    }
}