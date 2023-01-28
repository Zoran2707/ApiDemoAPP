namespace UseApiByWinForms
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
            this.btnGetAllData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGetSuplierByID = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPutDeleteSuplier = new System.Windows.Forms.Button();
            this.gbSuplierInfo = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPut = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblFax = new System.Windows.Forms.Label();
            this.lblHomePage = new System.Windows.Forms.Label();
            this.lblContactTitle = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblContactName = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lblSuplierID = new System.Windows.Forms.Label();
            this.tbHomePage = new System.Windows.Forms.TextBox();
            this.tbContactTitle = new System.Windows.Forms.TextBox();
            this.tbFax = new System.Windows.Forms.TextBox();
            this.tbSuplierID = new System.Windows.Forms.TextBox();
            this.tbCompanyName = new System.Windows.Forms.TextBox();
            this.tbContactName = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbRegion = new System.Windows.Forms.TextBox();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbPostalCode = new System.Windows.Forms.TextBox();
            this.gbSuplierAction = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbSuplierInfo.SuspendLayout();
            this.gbSuplierAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetAllData
            // 
            this.btnGetAllData.Location = new System.Drawing.Point(3, 91);
            this.btnGetAllData.Name = "btnGetAllData";
            this.btnGetAllData.Size = new System.Drawing.Size(157, 23);
            this.btnGetAllData.TabIndex = 0;
            this.btnGetAllData.Text = "Get All Supliers";
            this.btnGetAllData.UseVisualStyleBackColor = true;
            this.btnGetAllData.Click += new System.EventHandler(this.btnGetAllData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(454, 290);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnGetSuplierByID
            // 
            this.btnGetSuplierByID.Location = new System.Drawing.Point(3, 51);
            this.btnGetSuplierByID.Name = "btnGetSuplierByID";
            this.btnGetSuplierByID.Size = new System.Drawing.Size(157, 23);
            this.btnGetSuplierByID.TabIndex = 2;
            this.btnGetSuplierByID.Text = "GetSuplierByID";
            this.btnGetSuplierByID.UseVisualStyleBackColor = true;
            this.btnGetSuplierByID.Click += new System.EventHandler(this.btnGetSuplierByID_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(3, 14);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 3;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(213, 21);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(157, 23);
            this.btnPost.TabIndex = 4;
            this.btnPost.Text = "Post Suplier";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_ClickAsync);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbID);
            this.panel1.Controls.Add(this.btnGetSuplierByID);
            this.panel1.Controls.Add(this.btnGetAllData);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 117);
            this.panel1.TabIndex = 5;
            // 
            // btnPutDeleteSuplier
            // 
            this.btnPutDeleteSuplier.Location = new System.Drawing.Point(213, 72);
            this.btnPutDeleteSuplier.Name = "btnPutDeleteSuplier";
            this.btnPutDeleteSuplier.Size = new System.Drawing.Size(157, 63);
            this.btnPutDeleteSuplier.TabIndex = 6;
            this.btnPutDeleteSuplier.Text = "Put Suplier\r\nor Delete Suplier";
            this.btnPutDeleteSuplier.UseVisualStyleBackColor = true;
            this.btnPutDeleteSuplier.Click += new System.EventHandler(this.btnPutDeleteSuplier_Click);
            // 
            // gbSuplierInfo
            // 
            this.gbSuplierInfo.Controls.Add(this.lblPhone);
            this.gbSuplierInfo.Controls.Add(this.lblFax);
            this.gbSuplierInfo.Controls.Add(this.lblHomePage);
            this.gbSuplierInfo.Controls.Add(this.lblContactTitle);
            this.gbSuplierInfo.Controls.Add(this.lblCity);
            this.gbSuplierInfo.Controls.Add(this.lblRegion);
            this.gbSuplierInfo.Controls.Add(this.lblCountry);
            this.gbSuplierInfo.Controls.Add(this.lblPostalCode);
            this.gbSuplierInfo.Controls.Add(this.lblCompanyName);
            this.gbSuplierInfo.Controls.Add(this.lblContactName);
            this.gbSuplierInfo.Controls.Add(this.lbAddress);
            this.gbSuplierInfo.Controls.Add(this.lblSuplierID);
            this.gbSuplierInfo.Controls.Add(this.tbHomePage);
            this.gbSuplierInfo.Controls.Add(this.tbContactTitle);
            this.gbSuplierInfo.Controls.Add(this.tbFax);
            this.gbSuplierInfo.Controls.Add(this.tbSuplierID);
            this.gbSuplierInfo.Controls.Add(this.tbCompanyName);
            this.gbSuplierInfo.Controls.Add(this.tbContactName);
            this.gbSuplierInfo.Controls.Add(this.tbAddress);
            this.gbSuplierInfo.Controls.Add(this.tbCity);
            this.gbSuplierInfo.Controls.Add(this.tbRegion);
            this.gbSuplierInfo.Controls.Add(this.tbCountry);
            this.gbSuplierInfo.Controls.Add(this.tbPhone);
            this.gbSuplierInfo.Controls.Add(this.tbPostalCode);
            this.gbSuplierInfo.Location = new System.Drawing.Point(472, 21);
            this.gbSuplierInfo.Name = "gbSuplierInfo";
            this.gbSuplierInfo.Size = new System.Drawing.Size(316, 360);
            this.gbSuplierInfo.TabIndex = 8;
            this.gbSuplierInfo.TabStop = false;
            this.gbSuplierInfo.Text = "Suplier info";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(221, 24);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 23);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(126, 24);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 23);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete Suplier";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPut
            // 
            this.btnPut.Location = new System.Drawing.Point(27, 24);
            this.btnPut.Name = "btnPut";
            this.btnPut.Size = new System.Drawing.Size(89, 23);
            this.btnPut.TabIndex = 28;
            this.btnPut.Text = "Put Suplier";
            this.btnPut.UseVisualStyleBackColor = true;
            this.btnPut.Click += new System.EventHandler(this.btnPut_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(24, 282);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 27;
            this.lblPhone.Text = "Phone";
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(24, 308);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(24, 13);
            this.lblFax.TabIndex = 26;
            this.lblFax.Text = "Fax";
            // 
            // lblHomePage
            // 
            this.lblHomePage.AutoSize = true;
            this.lblHomePage.Location = new System.Drawing.Point(24, 334);
            this.lblHomePage.Name = "lblHomePage";
            this.lblHomePage.Size = new System.Drawing.Size(62, 13);
            this.lblHomePage.TabIndex = 25;
            this.lblHomePage.Text = "Home page";
            // 
            // lblContactTitle
            // 
            this.lblContactTitle.AutoSize = true;
            this.lblContactTitle.Location = new System.Drawing.Point(24, 114);
            this.lblContactTitle.Name = "lblContactTitle";
            this.lblContactTitle.Size = new System.Drawing.Size(67, 13);
            this.lblContactTitle.TabIndex = 24;
            this.lblContactTitle.Text = "Contact Title";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(24, 176);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 23;
            this.lblCity.Text = "City";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(24, 204);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(41, 13);
            this.lblRegion.TabIndex = 22;
            this.lblRegion.Text = "Region";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(24, 256);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 21;
            this.lblCountry.Text = "Country";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(24, 226);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(63, 13);
            this.lblPostalCode.TabIndex = 20;
            this.lblPostalCode.Text = "Postal code";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(24, 58);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(80, 13);
            this.lblCompanyName.TabIndex = 19;
            this.lblCompanyName.Text = "Company name";
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Location = new System.Drawing.Point(24, 84);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(73, 13);
            this.lblContactName.TabIndex = 18;
            this.lblContactName.Text = "Contact name";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(24, 139);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(45, 13);
            this.lbAddress.TabIndex = 17;
            this.lbAddress.Text = "Address";
            // 
            // lblSuplierID
            // 
            this.lblSuplierID.AutoSize = true;
            this.lblSuplierID.Location = new System.Drawing.Point(24, 26);
            this.lblSuplierID.Name = "lblSuplierID";
            this.lblSuplierID.Size = new System.Drawing.Size(53, 13);
            this.lblSuplierID.TabIndex = 16;
            this.lblSuplierID.Text = "Suplier ID";
            // 
            // tbHomePage
            // 
            this.tbHomePage.Location = new System.Drawing.Point(156, 327);
            this.tbHomePage.Name = "tbHomePage";
            this.tbHomePage.Size = new System.Drawing.Size(135, 20);
            this.tbHomePage.TabIndex = 15;
            // 
            // tbContactTitle
            // 
            this.tbContactTitle.Location = new System.Drawing.Point(156, 107);
            this.tbContactTitle.Name = "tbContactTitle";
            this.tbContactTitle.Size = new System.Drawing.Size(135, 20);
            this.tbContactTitle.TabIndex = 14;
            // 
            // tbFax
            // 
            this.tbFax.Location = new System.Drawing.Point(156, 301);
            this.tbFax.Name = "tbFax";
            this.tbFax.Size = new System.Drawing.Size(135, 20);
            this.tbFax.TabIndex = 13;
            // 
            // tbSuplierID
            // 
            this.tbSuplierID.Location = new System.Drawing.Point(156, 19);
            this.tbSuplierID.Name = "tbSuplierID";
            this.tbSuplierID.Size = new System.Drawing.Size(135, 20);
            this.tbSuplierID.TabIndex = 12;
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.Location = new System.Drawing.Point(156, 51);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.Size = new System.Drawing.Size(135, 20);
            this.tbCompanyName.TabIndex = 11;
            this.tbCompanyName.TextChanged += new System.EventHandler(this.tbCompanyName_TextChanged);
            // 
            // tbContactName
            // 
            this.tbContactName.Location = new System.Drawing.Point(156, 77);
            this.tbContactName.Name = "tbContactName";
            this.tbContactName.Size = new System.Drawing.Size(135, 20);
            this.tbContactName.TabIndex = 10;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(156, 132);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(135, 20);
            this.tbAddress.TabIndex = 9;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(156, 169);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(135, 20);
            this.tbCity.TabIndex = 8;
            // 
            // tbRegion
            // 
            this.tbRegion.Location = new System.Drawing.Point(156, 197);
            this.tbRegion.Name = "tbRegion";
            this.tbRegion.Size = new System.Drawing.Size(135, 20);
            this.tbRegion.TabIndex = 7;
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(156, 249);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(135, 20);
            this.tbCountry.TabIndex = 6;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(156, 275);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(135, 20);
            this.tbPhone.TabIndex = 5;
            // 
            // tbPostalCode
            // 
            this.tbPostalCode.Location = new System.Drawing.Point(156, 223);
            this.tbPostalCode.Name = "tbPostalCode";
            this.tbPostalCode.Size = new System.Drawing.Size(135, 20);
            this.tbPostalCode.TabIndex = 4;
            // 
            // gbSuplierAction
            // 
            this.gbSuplierAction.Controls.Add(this.btnCancel);
            this.gbSuplierAction.Controls.Add(this.btnPut);
            this.gbSuplierAction.Controls.Add(this.btnDelete);
            this.gbSuplierAction.Location = new System.Drawing.Point(472, 387);
            this.gbSuplierAction.Name = "gbSuplierAction";
            this.gbSuplierAction.Size = new System.Drawing.Size(316, 63);
            this.gbSuplierAction.TabIndex = 31;
            this.gbSuplierAction.TabStop = false;
            this.gbSuplierAction.Text = "Suplier action";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbSuplierAction);
            this.Controls.Add(this.gbSuplierInfo);
            this.Controls.Add(this.btnPutDeleteSuplier);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbSuplierInfo.ResumeLayout(false);
            this.gbSuplierInfo.PerformLayout();
            this.gbSuplierAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetAllData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGetSuplierByID;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPutDeleteSuplier;
        private System.Windows.Forms.GroupBox gbSuplierInfo;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.Label lblHomePage;
        private System.Windows.Forms.Label lblContactTitle;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lblSuplierID;
        private System.Windows.Forms.TextBox tbHomePage;
        private System.Windows.Forms.TextBox tbContactTitle;
        private System.Windows.Forms.TextBox tbFax;
        private System.Windows.Forms.TextBox tbSuplierID;
        private System.Windows.Forms.TextBox tbCompanyName;
        private System.Windows.Forms.TextBox tbContactName;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbRegion;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbPostalCode;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPut;
        private System.Windows.Forms.GroupBox gbSuplierAction;
    }
}

