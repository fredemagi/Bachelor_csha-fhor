namespace QR_generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.path_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.generate_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.print_qr_code_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(100, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // path_textbox
            // 
            this.path_textbox.Location = new System.Drawing.Point(118, 312);
            this.path_textbox.Name = "path_textbox";
            this.path_textbox.Size = new System.Drawing.Size(182, 20);
            this.path_textbox.TabIndex = 1;
            this.path_textbox.TextChanged += new System.EventHandler(this.path_textbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data-adresse";
            // 
            // generate_button
            // 
            this.generate_button.Location = new System.Drawing.Point(12, 355);
            this.generate_button.Name = "generate_button";
            this.generate_button.Size = new System.Drawing.Size(287, 43);
            this.generate_button.TabIndex = 3;
            this.generate_button.Text = "Generér QR kode";
            this.generate_button.UseVisualStyleBackColor = true;
            this.generate_button.Click += new System.EventHandler(this.generate_button_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(12, 404);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(287, 42);
            this.save_button.TabIndex = 4;
            this.save_button.Text = "Gem QR kode";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // print_qr_code_button
            // 
            this.print_qr_code_button.Location = new System.Drawing.Point(12, 452);
            this.print_qr_code_button.Name = "print_qr_code_button";
            this.print_qr_code_button.Size = new System.Drawing.Size(287, 42);
            this.print_qr_code_button.TabIndex = 5;
            this.print_qr_code_button.Text = "Print QR kode";
            this.print_qr_code_button.UseVisualStyleBackColor = true;
            this.print_qr_code_button.Click += new System.EventHandler(this.print_qr_code_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(312, 517);
            this.Controls.Add(this.print_qr_code_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.generate_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.path_textbox);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "QR Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox path_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generate_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button print_qr_code_button;
    }
}

