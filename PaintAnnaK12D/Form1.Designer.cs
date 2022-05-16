namespace PaintAnnaK12D
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.pic_color = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.btn_elipse = new System.Windows.Forms.Button();
            this.btn_rect = new System.Windows.Forms.Button();
            this.btn_pen = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Controls.Add(this.btn_open);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.pic_color);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 130);
            this.panel1.TabIndex = 0;
            // 
            // btn_print
            // 
            this.btn_print.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_print.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.ForeColor = System.Drawing.Color.Black;
            this.btn_print.Location = new System.Drawing.Point(12, 11);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(86, 34);
            this.btn_print.TabIndex = 8;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_open
            // 
            this.btn_open.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_open.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open.ForeColor = System.Drawing.Color.Black;
            this.btn_open.Location = new System.Drawing.Point(12, 52);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(86, 34);
            this.btn_open.TabIndex = 10;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_save
            // 
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.Location = new System.Drawing.Point(104, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(86, 34);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Location = new System.Drawing.Point(104, 52);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(86, 34);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "New";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.Color.White;
            this.pic_color.Location = new System.Drawing.Point(238, 41);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(46, 45);
            this.pic_color.TabIndex = 2;
            this.pic_color.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.btn_eraser);
            this.panel3.Controls.Add(this.btn_color);
            this.panel3.Controls.Add(this.btn_elipse);
            this.panel3.Controls.Add(this.btn_rect);
            this.panel3.Controls.Add(this.btn_pen);
            this.panel3.Controls.Add(this.btn_line);
            this.panel3.Location = new System.Drawing.Point(290, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(413, 84);
            this.panel3.TabIndex = 2;
            // 
            // btn_eraser
            // 
            this.btn_eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eraser.ForeColor = System.Drawing.Color.Black;
            this.btn_eraser.Image = global::PaintAnnaK12D.Properties.Resources.eraser;
            this.btn_eraser.Location = new System.Drawing.Point(341, 10);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(61, 65);
            this.btn_eraser.TabIndex = 9;
            this.btn_eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eraser.UseVisualStyleBackColor = true;
            this.btn_eraser.Click += new System.EventHandler(this.btn_eraser_Click);
            // 
            // btn_color
            // 
            this.btn_color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_color.ForeColor = System.Drawing.Color.Black;
            this.btn_color.Image = global::PaintAnnaK12D.Properties.Resources.color_cerams1;
            this.btn_color.Location = new System.Drawing.Point(6, 10);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(61, 65);
            this.btn_color.TabIndex = 3;
            this.btn_color.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_elipse
            // 
            this.btn_elipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_elipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_elipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_elipse.ForeColor = System.Drawing.Color.Black;
            this.btn_elipse.Image = global::PaintAnnaK12D.Properties.Resources.elipse1;
            this.btn_elipse.Location = new System.Drawing.Point(274, 10);
            this.btn_elipse.Name = "btn_elipse";
            this.btn_elipse.Size = new System.Drawing.Size(61, 65);
            this.btn_elipse.TabIndex = 8;
            this.btn_elipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_elipse.UseVisualStyleBackColor = true;
            this.btn_elipse.Click += new System.EventHandler(this.btn_elipse_Click);
            // 
            // btn_rect
            // 
            this.btn_rect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_rect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rect.ForeColor = System.Drawing.Color.Black;
            this.btn_rect.Image = global::PaintAnnaK12D.Properties.Resources.taisnstūris;
            this.btn_rect.Location = new System.Drawing.Point(207, 10);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(61, 65);
            this.btn_rect.TabIndex = 7;
            this.btn_rect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rect.UseVisualStyleBackColor = true;
            this.btn_rect.Click += new System.EventHandler(this.btn_rect_Click);
            // 
            // btn_pen
            // 
            this.btn_pen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_pen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_pen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pen.ForeColor = System.Drawing.Color.Black;
            this.btn_pen.Image = global::PaintAnnaK12D.Properties.Resources.pen;
            this.btn_pen.Location = new System.Drawing.Point(73, 10);
            this.btn_pen.Name = "btn_pen";
            this.btn_pen.Size = new System.Drawing.Size(61, 65);
            this.btn_pen.TabIndex = 5;
            this.btn_pen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pen.UseVisualStyleBackColor = true;
            this.btn_pen.Click += new System.EventHandler(this.btn_pen_Click);
            // 
            // btn_line
            // 
            this.btn_line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_line.ForeColor = System.Drawing.Color.Black;
            this.btn_line.Image = global::PaintAnnaK12D.Properties.Resources.svītra1;
            this.btn_line.Location = new System.Drawing.Point(140, 10);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(61, 65);
            this.btn_line.TabIndex = 6;
            this.btn_line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_line.UseVisualStyleBackColor = true;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 470);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 30);
            this.panel2.TabIndex = 1;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(778, 500);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Annas Paint";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Button btn_pen;
        private System.Windows.Forms.Button btn_elipse;
        private System.Windows.Forms.Button btn_rect;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Button btn_eraser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

