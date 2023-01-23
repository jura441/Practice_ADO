namespace Practice_ADO.NET
{
    partial class AddGoods
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.l_id = new System.Windows.Forms.Label();
            this.l_name = new System.Windows.Forms.Label();
            this.l_cat_id = new System.Windows.Forms.Label();
            this.l_price = new System.Windows.Forms.Label();
            this.l_count = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_cat_id = new System.Windows.Forms.TextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.tb_count = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(119, 206);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // l_id
            // 
            this.l_id.AutoSize = true;
            this.l_id.Location = new System.Drawing.Point(12, 9);
            this.l_id.Name = "l_id";
            this.l_id.Size = new System.Drawing.Size(15, 13);
            this.l_id.TabIndex = 2;
            this.l_id.Text = "id";
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.Location = new System.Drawing.Point(12, 42);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(33, 13);
            this.l_name.TabIndex = 3;
            this.l_name.Text = "name";
            // 
            // l_cat_id
            // 
            this.l_cat_id.AutoSize = true;
            this.l_cat_id.Location = new System.Drawing.Point(12, 80);
            this.l_cat_id.Name = "l_cat_id";
            this.l_cat_id.Size = new System.Drawing.Size(60, 13);
            this.l_cat_id.TabIndex = 4;
            this.l_cat_id.Text = "Category id";
            // 
            // l_price
            // 
            this.l_price.AutoSize = true;
            this.l_price.Location = new System.Drawing.Point(12, 114);
            this.l_price.Name = "l_price";
            this.l_price.Size = new System.Drawing.Size(31, 13);
            this.l_price.TabIndex = 5;
            this.l_price.Text = "Price";
            // 
            // l_count
            // 
            this.l_count.AutoSize = true;
            this.l_count.Location = new System.Drawing.Point(12, 154);
            this.l_count.Name = "l_count";
            this.l_count.Size = new System.Drawing.Size(35, 13);
            this.l_count.TabIndex = 6;
            this.l_count.Text = "Count";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(78, 6);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 20);
            this.tb_id.TabIndex = 7;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(78, 39);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 20);
            this.tb_name.TabIndex = 8;
            // 
            // tb_cat_id
            // 
            this.tb_cat_id.Location = new System.Drawing.Point(78, 80);
            this.tb_cat_id.Name = "tb_cat_id";
            this.tb_cat_id.Size = new System.Drawing.Size(100, 20);
            this.tb_cat_id.TabIndex = 9;
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(78, 114);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(100, 20);
            this.tb_price.TabIndex = 10;
            // 
            // tb_count
            // 
            this.tb_count.Location = new System.Drawing.Point(78, 151);
            this.tb_count.Name = "tb_count";
            this.tb_count.Size = new System.Drawing.Size(100, 20);
            this.tb_count.TabIndex = 11;
            // 
            // AddGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 290);
            this.Controls.Add(this.tb_count);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.tb_cat_id);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.l_count);
            this.Controls.Add(this.l_price);
            this.Controls.Add(this.l_cat_id);
            this.Controls.Add(this.l_name);
            this.Controls.Add(this.l_id);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.button1);
            this.Name = "AddGoods";
            this.Text = "AddGoods";
            this.Load += new System.EventHandler(this.AddGoods_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.TextBox tb_id;
        public System.Windows.Forms.TextBox tb_name;
        public System.Windows.Forms.TextBox tb_cat_id;
        public System.Windows.Forms.TextBox tb_price;
        public System.Windows.Forms.TextBox tb_count;
        public System.Windows.Forms.Label l_id;
        public System.Windows.Forms.Label l_name;
        public System.Windows.Forms.Label l_cat_id;
        public System.Windows.Forms.Label l_price;
        public System.Windows.Forms.Label l_count;
    }
}