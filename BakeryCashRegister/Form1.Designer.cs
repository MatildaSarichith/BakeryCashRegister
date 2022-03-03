namespace BakeryCashRegister
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
            this.numOfCupcakeLabel = new System.Windows.Forms.Label();
            this.numOfCakeLabel = new System.Windows.Forms.Label();
            this.numOfCookiesLabel = new System.Windows.Forms.Label();
            this.cupcakeInput = new System.Windows.Forms.TextBox();
            this.cakeInput = new System.Windows.Forms.TextBox();
            this.cookieInput = new System.Windows.Forms.TextBox();
            this.calulateTotalButton = new System.Windows.Forms.Button();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reciptButton = new System.Windows.Forms.Button();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.reciptBaseLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.reciptDescription = new System.Windows.Forms.Label();
            this.bannerLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numOfCupcakeLabel
            // 
            this.numOfCupcakeLabel.AutoSize = true;
            this.numOfCupcakeLabel.Font = new System.Drawing.Font("Rockwell", 10F);
            this.numOfCupcakeLabel.Location = new System.Drawing.Point(43, 71);
            this.numOfCupcakeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numOfCupcakeLabel.Name = "numOfCupcakeLabel";
            this.numOfCupcakeLabel.Size = new System.Drawing.Size(171, 20);
            this.numOfCupcakeLabel.TabIndex = 0;
            this.numOfCupcakeLabel.Text = "Number of cupcakes";
            // 
            // numOfCakeLabel
            // 
            this.numOfCakeLabel.AutoSize = true;
            this.numOfCakeLabel.Font = new System.Drawing.Font("Rockwell", 10F);
            this.numOfCakeLabel.Location = new System.Drawing.Point(43, 121);
            this.numOfCakeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numOfCakeLabel.Name = "numOfCakeLabel";
            this.numOfCakeLabel.Size = new System.Drawing.Size(142, 20);
            this.numOfCakeLabel.TabIndex = 1;
            this.numOfCakeLabel.Text = "Number of cakes";
            // 
            // numOfCookiesLabel
            // 
            this.numOfCookiesLabel.AutoSize = true;
            this.numOfCookiesLabel.Font = new System.Drawing.Font("Rockwell", 10F);
            this.numOfCookiesLabel.Location = new System.Drawing.Point(43, 170);
            this.numOfCookiesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numOfCookiesLabel.Name = "numOfCookiesLabel";
            this.numOfCookiesLabel.Size = new System.Drawing.Size(158, 20);
            this.numOfCookiesLabel.TabIndex = 2;
            this.numOfCookiesLabel.Text = "Number of cookies";
            // 
            // cupcakeInput
            // 
            this.cupcakeInput.Location = new System.Drawing.Point(235, 70);
            this.cupcakeInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cupcakeInput.Name = "cupcakeInput";
            this.cupcakeInput.Size = new System.Drawing.Size(89, 22);
            this.cupcakeInput.TabIndex = 3;
            // 
            // cakeInput
            // 
            this.cakeInput.Location = new System.Drawing.Point(235, 121);
            this.cakeInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cakeInput.Name = "cakeInput";
            this.cakeInput.Size = new System.Drawing.Size(89, 22);
            this.cakeInput.TabIndex = 4;
            // 
            // cookieInput
            // 
            this.cookieInput.Location = new System.Drawing.Point(235, 170);
            this.cookieInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cookieInput.Name = "cookieInput";
            this.cookieInput.Size = new System.Drawing.Size(89, 22);
            this.cookieInput.TabIndex = 5;
            // 
            // calulateTotalButton
            // 
            this.calulateTotalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.calulateTotalButton.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.calulateTotalButton.ForeColor = System.Drawing.Color.White;
            this.calulateTotalButton.Location = new System.Drawing.Point(47, 214);
            this.calulateTotalButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calulateTotalButton.Name = "calulateTotalButton";
            this.calulateTotalButton.Size = new System.Drawing.Size(279, 43);
            this.calulateTotalButton.TabIndex = 6;
            this.calulateTotalButton.Text = "Calculate Totals";
            this.calulateTotalButton.UseVisualStyleBackColor = false;
            this.calulateTotalButton.Click += new System.EventHandler(this.calulateTotalButton_Click);
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Font = new System.Drawing.Font("Rockwell", 10F);
            this.subTotalLabel.Location = new System.Drawing.Point(43, 283);
            this.subTotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(81, 20);
            this.subTotalLabel.TabIndex = 7;
            this.subTotalLabel.Text = "Sub Total";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Rockwell", 10F);
            this.taxLabel.Location = new System.Drawing.Point(43, 322);
            this.taxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(37, 20);
            this.taxLabel.TabIndex = 8;
            this.taxLabel.Text = "Tax";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Rockwell", 10F);
            this.totalLabel.Location = new System.Drawing.Point(43, 364);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(48, 20);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "Total";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("Rockwell", 10F);
            this.tenderedLabel.Location = new System.Drawing.Point(43, 402);
            this.tenderedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(86, 20);
            this.tenderedLabel.TabIndex = 10;
            this.tenderedLabel.Text = "Tendered";
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(235, 402);
            this.tenderedInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(89, 22);
            this.tenderedInput.TabIndex = 11;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.changeButton.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.changeButton.ForeColor = System.Drawing.Color.White;
            this.changeButton.Location = new System.Drawing.Point(47, 449);
            this.changeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(291, 48);
            this.changeButton.TabIndex = 12;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10F);
            this.label1.Location = new System.Drawing.Point(43, 512);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Change";
            // 
            // reciptButton
            // 
            this.reciptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.reciptButton.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.reciptButton.ForeColor = System.Drawing.Color.White;
            this.reciptButton.Location = new System.Drawing.Point(47, 549);
            this.reciptButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reciptButton.Name = "reciptButton";
            this.reciptButton.Size = new System.Drawing.Size(291, 47);
            this.reciptButton.TabIndex = 14;
            this.reciptButton.Text = "Print Recipt";
            this.reciptButton.UseVisualStyleBackColor = false;
            this.reciptButton.Click += new System.EventHandler(this.reciptButton_Click);
            // 
            // newOrderButton
            // 
            this.newOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.newOrderButton.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.newOrderButton.ForeColor = System.Drawing.Color.White;
            this.newOrderButton.Location = new System.Drawing.Point(536, 532);
            this.newOrderButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(445, 53);
            this.newOrderButton.TabIndex = 15;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = false;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // reciptBaseLabel
            // 
            this.reciptBaseLabel.BackColor = System.Drawing.Color.White;
            this.reciptBaseLabel.Location = new System.Drawing.Point(541, 71);
            this.reciptBaseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reciptBaseLabel.Name = "reciptBaseLabel";
            this.reciptBaseLabel.Size = new System.Drawing.Size(440, 439);
            this.reciptBaseLabel.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(231, 283);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 17;
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.subtotalOutput.Location = new System.Drawing.Point(245, 283);
            this.subtotalOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(92, 21);
            this.subtotalOutput.TabIndex = 20;
            // 
            // taxOutput
            // 
            this.taxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.taxOutput.Location = new System.Drawing.Point(245, 322);
            this.taxOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(92, 21);
            this.taxOutput.TabIndex = 21;
            // 
            // totalOutput
            // 
            this.totalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.totalOutput.Location = new System.Drawing.Point(245, 364);
            this.totalOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(92, 21);
            this.totalOutput.TabIndex = 22;
            // 
            // changeOutput
            // 
            this.changeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.changeOutput.Location = new System.Drawing.Point(233, 512);
            this.changeOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(92, 21);
            this.changeOutput.TabIndex = 23;
            // 
            // reciptDescription
            // 
            this.reciptDescription.BackColor = System.Drawing.Color.White;
            this.reciptDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.reciptDescription.Location = new System.Drawing.Point(563, 92);
            this.reciptDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reciptDescription.Name = "reciptDescription";
            this.reciptDescription.Size = new System.Drawing.Size(400, 390);
            this.reciptDescription.TabIndex = 24;
            // 
            // bannerLabel
            // 
            this.bannerLabel.BackColor = System.Drawing.Color.Crimson;
            this.bannerLabel.Location = new System.Drawing.Point(0, 0);
            this.bannerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bannerLabel.Name = "bannerLabel";
            this.bannerLabel.Size = new System.Drawing.Size(1039, 53);
            this.bannerLabel.TabIndex = 25;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Crimson;
            this.titleLabel.Font = new System.Drawing.Font("Cooper Black", 25F);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(349, 0);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(377, 49);
            this.titleLabel.TabIndex = 26;
            this.titleLabel.Text = "Cookies n\' Cakes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1036, 599);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.bannerLabel);
            this.Controls.Add(this.reciptDescription);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reciptBaseLabel);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.reciptButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.calulateTotalButton);
            this.Controls.Add(this.cookieInput);
            this.Controls.Add(this.cakeInput);
            this.Controls.Add(this.cupcakeInput);
            this.Controls.Add(this.numOfCookiesLabel);
            this.Controls.Add(this.numOfCakeLabel);
            this.Controls.Add(this.numOfCupcakeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numOfCupcakeLabel;
        private System.Windows.Forms.Label numOfCakeLabel;
        private System.Windows.Forms.Label numOfCookiesLabel;
        private System.Windows.Forms.TextBox cupcakeInput;
        private System.Windows.Forms.TextBox cakeInput;
        private System.Windows.Forms.TextBox cookieInput;
        private System.Windows.Forms.Button calulateTotalButton;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reciptButton;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Label reciptBaseLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Label reciptDescription;
        private System.Windows.Forms.Label bannerLabel;
        private System.Windows.Forms.Label titleLabel;
    }
}

