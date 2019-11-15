namespace FloorFlooring
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
            this.lengthlbl = new System.Windows.Forms.Label();
            this.widthlbl = new System.Windows.Forms.Label();
            this.lengthfeet = new System.Windows.Forms.TextBox();
            this.lengthinch = new System.Windows.Forms.TextBox();
            this.footlbl = new System.Windows.Forms.Label();
            this.inchlbl = new System.Windows.Forms.Label();
            this.widthfeet = new System.Windows.Forms.TextBox();
            this.widthinch = new System.Windows.Forms.TextBox();
            this.floortypes = new System.Windows.Forms.TabControl();
            this.hardwood = new System.Windows.Forms.TabPage();
            this.hardwoodprices = new System.Windows.Forms.ComboBox();
            this.Carpet = new System.Windows.Forms.TabPage();
            this.carpetprices = new System.Windows.Forms.ComboBox();
            this.Laminate = new System.Windows.Forms.TabPage();
            this.laminateprices = new System.Windows.Forms.ComboBox();
            this.pricebtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.mathcheck = new System.Windows.Forms.Label();
            this.floortypes.SuspendLayout();
            this.hardwood.SuspendLayout();
            this.Carpet.SuspendLayout();
            this.Laminate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lengthlbl
            // 
            this.lengthlbl.AutoSize = true;
            this.lengthlbl.Location = new System.Drawing.Point(83, 102);
            this.lengthlbl.Name = "lengthlbl";
            this.lengthlbl.Size = new System.Drawing.Size(43, 13);
            this.lengthlbl.TabIndex = 0;
            this.lengthlbl.Text = "Length:";
            // 
            // widthlbl
            // 
            this.widthlbl.AutoSize = true;
            this.widthlbl.Location = new System.Drawing.Point(83, 177);
            this.widthlbl.Name = "widthlbl";
            this.widthlbl.Size = new System.Drawing.Size(35, 13);
            this.widthlbl.TabIndex = 1;
            this.widthlbl.Text = "Width";
            // 
            // lengthfeet
            // 
            this.lengthfeet.Location = new System.Drawing.Point(145, 102);
            this.lengthfeet.Name = "lengthfeet";
            this.lengthfeet.Size = new System.Drawing.Size(100, 20);
            this.lengthfeet.TabIndex = 2;
            this.lengthfeet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lengthfeet_KeyPress);
            // 
            // lengthinch
            // 
            this.lengthinch.Location = new System.Drawing.Point(279, 102);
            this.lengthinch.Name = "lengthinch";
            this.lengthinch.Size = new System.Drawing.Size(100, 20);
            this.lengthinch.TabIndex = 3;
            this.lengthinch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lengthinch_KeyPress);
            // 
            // footlbl
            // 
            this.footlbl.AutoSize = true;
            this.footlbl.Location = new System.Drawing.Point(178, 71);
            this.footlbl.Name = "footlbl";
            this.footlbl.Size = new System.Drawing.Size(28, 13);
            this.footlbl.TabIndex = 4;
            this.footlbl.Text = "Feet";
            // 
            // inchlbl
            // 
            this.inchlbl.AutoSize = true;
            this.inchlbl.Location = new System.Drawing.Point(314, 70);
            this.inchlbl.Name = "inchlbl";
            this.inchlbl.Size = new System.Drawing.Size(39, 13);
            this.inchlbl.TabIndex = 5;
            this.inchlbl.Text = "Inches";
            // 
            // widthfeet
            // 
            this.widthfeet.Location = new System.Drawing.Point(145, 177);
            this.widthfeet.Name = "widthfeet";
            this.widthfeet.Size = new System.Drawing.Size(100, 20);
            this.widthfeet.TabIndex = 6;
            this.widthfeet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.widthfeet_KeyPress);
            // 
            // widthinch
            // 
            this.widthinch.Location = new System.Drawing.Point(279, 176);
            this.widthinch.Name = "widthinch";
            this.widthinch.Size = new System.Drawing.Size(100, 20);
            this.widthinch.TabIndex = 7;
            this.widthinch.TextChanged += new System.EventHandler(this.widthinch_TextChanged);
            this.widthinch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.widthinch_KeyPress);
            // 
            // floortypes
            // 
            this.floortypes.Controls.Add(this.hardwood);
            this.floortypes.Controls.Add(this.Carpet);
            this.floortypes.Controls.Add(this.Laminate);
            this.floortypes.Location = new System.Drawing.Point(86, 224);
            this.floortypes.Name = "floortypes";
            this.floortypes.SelectedIndex = 0;
            this.floortypes.Size = new System.Drawing.Size(267, 57);
            this.floortypes.TabIndex = 8;
            // 
            // hardwood
            // 
            this.hardwood.Controls.Add(this.hardwoodprices);
            this.hardwood.Location = new System.Drawing.Point(4, 22);
            this.hardwood.Name = "hardwood";
            this.hardwood.Padding = new System.Windows.Forms.Padding(3);
            this.hardwood.Size = new System.Drawing.Size(259, 31);
            this.hardwood.TabIndex = 0;
            this.hardwood.Text = "Hardwood";
            this.hardwood.UseVisualStyleBackColor = true;
            // 
            // hardwoodprices
            // 
            this.hardwoodprices.FormattingEnabled = true;
            this.hardwoodprices.Items.AddRange(new object[] {
            "Oak\t\t $30.75 per sq. yd.",
            "Cherry\t\t $34.90 per sq. yd.",
            "Walnut\t\t $35.50 per sq. yd.",
            "Maple\t\t $41.20 per sq. yd."});
            this.hardwoodprices.Location = new System.Drawing.Point(6, 6);
            this.hardwoodprices.Name = "hardwoodprices";
            this.hardwoodprices.Size = new System.Drawing.Size(247, 21);
            this.hardwoodprices.TabIndex = 0;
            this.hardwoodprices.SelectedIndexChanged += new System.EventHandler(this.hardwoodprices_SelectedIndexChanged);
            // 
            // Carpet
            // 
            this.Carpet.Controls.Add(this.carpetprices);
            this.Carpet.Location = new System.Drawing.Point(4, 22);
            this.Carpet.Name = "Carpet";
            this.Carpet.Padding = new System.Windows.Forms.Padding(3);
            this.Carpet.Size = new System.Drawing.Size(259, 31);
            this.Carpet.TabIndex = 1;
            this.Carpet.Text = "Carpet";
            this.Carpet.UseVisualStyleBackColor = true;
            // 
            // carpetprices
            // 
            this.carpetprices.FormattingEnabled = true;
            this.carpetprices.Items.AddRange(new object[] {
            "Acrylic\t\t$15.35 per sq. yd.",
            "Nylon\t\t$20.25 per sq. yd.",
            "Polyester\t\t$21.99 per sq. yd.",
            "Wool\t\t$25.24 per sq. yd."});
            this.carpetprices.Location = new System.Drawing.Point(6, 6);
            this.carpetprices.Name = "carpetprices";
            this.carpetprices.Size = new System.Drawing.Size(247, 21);
            this.carpetprices.TabIndex = 0;
            this.carpetprices.SelectedIndexChanged += new System.EventHandler(this.carpetprices_SelectedIndexChanged);
            // 
            // Laminate
            // 
            this.Laminate.Controls.Add(this.laminateprices);
            this.Laminate.Location = new System.Drawing.Point(4, 22);
            this.Laminate.Name = "Laminate";
            this.Laminate.Size = new System.Drawing.Size(259, 31);
            this.Laminate.TabIndex = 2;
            this.Laminate.Text = "Laminate";
            this.Laminate.UseVisualStyleBackColor = true;
            // 
            // laminateprices
            // 
            this.laminateprices.FormattingEnabled = true;
            this.laminateprices.Items.AddRange(new object[] {
            "Particle Board\t\t$10 per sq. yd.",
            "Faux Marble\t              $12.50 per sq. yd."});
            this.laminateprices.Location = new System.Drawing.Point(9, 7);
            this.laminateprices.Name = "laminateprices";
            this.laminateprices.Size = new System.Drawing.Size(247, 21);
            this.laminateprices.TabIndex = 1;
            this.laminateprices.SelectedIndexChanged += new System.EventHandler(this.laminateprices_SelectedIndexChanged);
            // 
            // pricebtn
            // 
            this.pricebtn.Location = new System.Drawing.Point(90, 332);
            this.pricebtn.Name = "pricebtn";
            this.pricebtn.Size = new System.Drawing.Size(75, 23);
            this.pricebtn.TabIndex = 9;
            this.pricebtn.Text = "Price";
            this.pricebtn.UseVisualStyleBackColor = true;
            this.pricebtn.Click += new System.EventHandler(this.pricebtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(279, 331);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(75, 23);
            this.clearbtn.TabIndex = 10;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // mathcheck
            // 
            this.mathcheck.AutoSize = true;
            this.mathcheck.Location = new System.Drawing.Point(592, 108);
            this.mathcheck.Name = "mathcheck";
            this.mathcheck.Size = new System.Drawing.Size(0, 13);
            this.mathcheck.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mathcheck);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.pricebtn);
            this.Controls.Add(this.floortypes);
            this.Controls.Add(this.widthinch);
            this.Controls.Add(this.widthfeet);
            this.Controls.Add(this.inchlbl);
            this.Controls.Add(this.footlbl);
            this.Controls.Add(this.lengthinch);
            this.Controls.Add(this.lengthfeet);
            this.Controls.Add(this.widthlbl);
            this.Controls.Add(this.lengthlbl);
            this.Name = "Form1";
            this.Text = "Floor Pricing";
            this.floortypes.ResumeLayout(false);
            this.hardwood.ResumeLayout(false);
            this.Carpet.ResumeLayout(false);
            this.Laminate.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lengthlbl;
        private System.Windows.Forms.Label widthlbl;
        private System.Windows.Forms.TextBox lengthfeet;
        private System.Windows.Forms.TextBox lengthinch;
        private System.Windows.Forms.Label footlbl;
        private System.Windows.Forms.Label inchlbl;
        private System.Windows.Forms.TextBox widthfeet;
        private System.Windows.Forms.TextBox widthinch;
        private System.Windows.Forms.TabControl floortypes;
        private System.Windows.Forms.TabPage hardwood;
        private System.Windows.Forms.ComboBox hardwoodprices;
        private System.Windows.Forms.TabPage Carpet;
        private System.Windows.Forms.TabPage Laminate;
        private System.Windows.Forms.ComboBox carpetprices;
        private System.Windows.Forms.ComboBox laminateprices;
        private System.Windows.Forms.Button pricebtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Label mathcheck;
    }
}

