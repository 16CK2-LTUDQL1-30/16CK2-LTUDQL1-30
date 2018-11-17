namespace _1660370
{
    partial class frmMain
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
            this.gbCustomerInfor = new System.Windows.Forms.GroupBox();
            this.dtgvCustomer = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCustomerDeTail = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbbCountry = new System.Windows.Forms.ComboBox();
            this.cbbCity = new System.Windows.Forms.ComboBox();
            this.txtbPostalCode = new System.Windows.Forms.TextBox();
            this.txtbAddress = new System.Windows.Forms.TextBox();
            this.txtbRegion = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtbPhone = new System.Windows.Forms.TextBox();
            this.txtbContactTitle = new System.Windows.Forms.TextBox();
            this.txtbContactName = new System.Windows.Forms.TextBox();
            this.txtbCompanyName = new System.Windows.Forms.TextBox();
            this.txtbCustomerID = new System.Windows.Forms.TextBox();
            this.lblFax = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblContactName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblContactTitle = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.gbCustomerInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomer)).BeginInit();
            this.gbCustomerDeTail.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCustomerInfor
            // 
            this.gbCustomerInfor.Controls.Add(this.dtgvCustomer);
            this.gbCustomerInfor.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCustomerInfor.Location = new System.Drawing.Point(3, 13);
            this.gbCustomerInfor.Name = "gbCustomerInfor";
            this.gbCustomerInfor.Size = new System.Drawing.Size(1398, 266);
            this.gbCustomerInfor.TabIndex = 0;
            this.gbCustomerInfor.TabStop = false;
            this.gbCustomerInfor.Text = "Customer Information";
            // 
            // dtgvCustomer
            // 
            this.dtgvCustomer.AllowUserToAddRows = false;
            this.dtgvCustomer.AllowUserToDeleteRows = false;
            this.dtgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.CompanyName,
            this.ContactName,
            this.ContactTitle,
            this.Address,
            this.City,
            this.Region,
            this.PostalCode,
            this.Country,
            this.Phone,
            this.Fax});
            this.dtgvCustomer.Location = new System.Drawing.Point(0, 20);
            this.dtgvCustomer.Name = "dtgvCustomer";
            this.dtgvCustomer.ReadOnly = true;
            this.dtgvCustomer.Size = new System.Drawing.Size(1398, 230);
            this.dtgvCustomer.TabIndex = 0;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // CompanyName
            // 
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.HeaderText = "CompanyName";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            // 
            // ContactName
            // 
            this.ContactName.DataPropertyName = "ContactName";
            this.ContactName.HeaderText = "ContactName";
            this.ContactName.Name = "ContactName";
            this.ContactName.ReadOnly = true;
            // 
            // ContactTitle
            // 
            this.ContactTitle.DataPropertyName = "ContactTitle";
            this.ContactTitle.HeaderText = "ContactTitle";
            this.ContactTitle.Name = "ContactTitle";
            this.ContactTitle.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // Region
            // 
            this.Region.DataPropertyName = "Region";
            this.Region.HeaderText = "Region";
            this.Region.Name = "Region";
            this.Region.ReadOnly = true;
            // 
            // PostalCode
            // 
            this.PostalCode.DataPropertyName = "PostalCode";
            this.PostalCode.HeaderText = "PostalCode";
            this.PostalCode.Name = "PostalCode";
            this.PostalCode.ReadOnly = true;
            // 
            // Country
            // 
            this.Country.DataPropertyName = "Country";
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Fax
            // 
            this.Fax.DataPropertyName = "Fax";
            this.Fax.HeaderText = "Fax";
            this.Fax.Name = "Fax";
            this.Fax.ReadOnly = true;
            // 
            // gbCustomerDeTail
            // 
            this.gbCustomerDeTail.Controls.Add(this.btnDelete);
            this.gbCustomerDeTail.Controls.Add(this.btnUpdate);
            this.gbCustomerDeTail.Controls.Add(this.btnAdd);
            this.gbCustomerDeTail.Controls.Add(this.cbbCountry);
            this.gbCustomerDeTail.Controls.Add(this.cbbCity);
            this.gbCustomerDeTail.Controls.Add(this.txtbPostalCode);
            this.gbCustomerDeTail.Controls.Add(this.txtbAddress);
            this.gbCustomerDeTail.Controls.Add(this.txtbRegion);
            this.gbCustomerDeTail.Controls.Add(this.txtFax);
            this.gbCustomerDeTail.Controls.Add(this.txtbPhone);
            this.gbCustomerDeTail.Controls.Add(this.txtbContactTitle);
            this.gbCustomerDeTail.Controls.Add(this.txtbContactName);
            this.gbCustomerDeTail.Controls.Add(this.txtbCompanyName);
            this.gbCustomerDeTail.Controls.Add(this.txtbCustomerID);
            this.gbCustomerDeTail.Controls.Add(this.lblFax);
            this.gbCustomerDeTail.Controls.Add(this.lblPhone);
            this.gbCustomerDeTail.Controls.Add(this.lblCity);
            this.gbCustomerDeTail.Controls.Add(this.lblRegion);
            this.gbCustomerDeTail.Controls.Add(this.lblCompanyName);
            this.gbCustomerDeTail.Controls.Add(this.lblPostalCode);
            this.gbCustomerDeTail.Controls.Add(this.lblCountry);
            this.gbCustomerDeTail.Controls.Add(this.lblContactName);
            this.gbCustomerDeTail.Controls.Add(this.lblAddress);
            this.gbCustomerDeTail.Controls.Add(this.lblContactTitle);
            this.gbCustomerDeTail.Controls.Add(this.lblCustomerID);
            this.gbCustomerDeTail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCustomerDeTail.Location = new System.Drawing.Point(3, 269);
            this.gbCustomerDeTail.Name = "gbCustomerDeTail";
            this.gbCustomerDeTail.Size = new System.Drawing.Size(1398, 241);
            this.gbCustomerDeTail.TabIndex = 1;
            this.gbCustomerDeTail.TabStop = false;
            this.gbCustomerDeTail.Text = "Customer Details";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1314, 186);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 39);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1154, 186);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 39);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(978, 186);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 39);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbbCountry
            // 
            this.cbbCountry.FormattingEnabled = true;
            this.cbbCountry.Items.AddRange(new object[] {
            "AFGHANISTAN",
            "ÅLAND ISLANDS",
            "ALBANIA",
            "ALGERIA",
            "AMERICAN SAMOA",
            "ANDORRA",
            "ANGOLA",
            "ANGUILLA",
            "ANTARCTICA",
            "ANTIGUA AND BARBUDA",
            "ARGENTINA",
            "ARMENIA",
            "ARUBA",
            "AUSTRALIA",
            "AUSTRIA",
            "AZERBAIJAN",
            "BAHAMAS",
            "BAHRAIN",
            "BANGLADESH",
            "BARBADOS",
            "BELARUS",
            "BELGIUM",
            "BELIZE",
            "BENIN",
            "BERMUDA",
            "BHUTAN",
            "BOLIVIA",
            "BOSNIA AND HERZEGOVINA",
            "BOTSWANA",
            "BOUVET ISLAND",
            "BRAZIL",
            "BRITISH INDIAN OCEAN TERRITORY",
            "BRUNEI DARUSSALAM",
            "BULGARIA",
            "BURKINA FASO",
            "BURUNDI",
            "CAMBODIA",
            "CAMEROON",
            "CANADA",
            "CAPE VERDE",
            "CAYMAN ISLANDS",
            "CENTRAL AFRICAN REPUBLIC",
            "CHAD",
            "CHILE",
            "CHINA",
            "CHRISTMAS ISLAND",
            "COCOS (KEELING) ISLANDS",
            "COLOMBIA",
            "COMOROS",
            "CONGO",
            "CONGO, THE DEMOCRATIC REPUBLIC OF THE",
            "COOK ISLANDS",
            "COSTA RICA",
            "CÔTE D\'IVOIRE",
            "CROATIA",
            "CUBA",
            "CYPRUS",
            "CZECH REPUBLIC",
            "DENMARK",
            "DJIBOUTI",
            "DOMINICA",
            "DOMINICAN REPUBLIC",
            "ECUADOR",
            "EGYPT",
            "EL SALVADOR",
            "EQUATORIAL GUINEA",
            "ERITREA",
            "ESTONIA",
            "ETHIOPIA",
            "FALKLAND ISLANDS (MALVINAS)",
            "FAROE ISLANDS",
            "FIJI",
            "FINLAND",
            "FRANCE",
            "FRENCH GUIANA",
            "FRENCH POLYNESIA",
            "FRENCH SOUTHERN TERRITORIES",
            "GABON",
            "GAMBIA",
            "GEORGIA",
            "GERMANY",
            "GHANA",
            "GIBRALTAR",
            "GREECE",
            "GREENLAND",
            "GRENADA",
            "GUADELOUPE",
            "GUAM",
            "GUATEMALA",
            "GUINEA",
            "GUINEA-BISSAU",
            "GUYANA",
            "HAITI",
            "HEARD ISLAND AND MCDONALD ISLANDS",
            "HOLY SEE (VATICAN CITY STATE)",
            "HONDURAS",
            "HONG KONG",
            "HUNGARY",
            "ICELAND",
            "INDIA",
            "INDONESIA",
            "IRAN, ISLAMIC REPUBLIC OF",
            "IRAQ",
            "IRELAND",
            "ISRAEL",
            "ITALY",
            "JAMAICA",
            "JAPAN",
            "JORDAN",
            "KAZAKHSTAN",
            "KENYA",
            "KIRIBATI",
            "KOREA, DEMOCRATIC PEOPLE\'S REPUBLIC OF",
            "KOREA, REPUBLIC OF",
            "KUWAIT",
            "KYRGYZSTAN",
            "LAO PEOPLE\'S DEMOCRATIC REPUBLIC",
            "LATVIA",
            "LEBANON",
            "LESOTHO",
            "LIBERIA",
            "LIBYAN ARAB JAMAHIRIYA",
            "LIECHTENSTEIN",
            "LITHUANIA",
            "LUXEMBOURG",
            "MACAO",
            "MACEDONIA, THE FORMER YUGOSLAV REPUBLIC OF",
            "MADAGASCAR",
            "MALAWI",
            "MALAYSIA",
            "MALDIVES",
            "MALI",
            "MALTA",
            "MARSHALL ISLANDS",
            "MARTINIQUE",
            "MAURITANIA",
            "MAURITIUS",
            "MAYOTTE",
            "MEXICO",
            "MICRONESIA, FEDERATED STATES OF",
            "MOLDOVA, REPUBLIC OF",
            "MONACO",
            "MONGOLIA",
            "MONTSERRAT",
            "MOROCCO",
            "MOZAMBIQUE",
            "MYANMAR",
            "NAMIBIA",
            "NAURU",
            "NEPAL",
            "NETHERLANDS",
            "NETHERLANDS ANTILLES",
            "NEW CALEDONIA",
            "NEW ZEALAND",
            "NICARAGUA",
            "NIGER",
            "NIGERIA",
            "NIUE",
            "NORFOLK ISLAND",
            "NORTHERN MARIANA ISLANDS",
            "NORWAY",
            "OMAN",
            "PAKISTAN",
            "PALAU",
            "PALESTINIAN TERRITORY, OCCUPIED",
            "PANAMA",
            "PAPUA NEW GUINEA",
            "PARAGUAY",
            "PERU",
            "PHILIPPINES",
            "PITCAIRN",
            "POLAND",
            "PORTUGAL",
            "PUERTO RICO",
            "QATAR",
            "RÉUNION",
            "ROMANIA",
            "RUSSIAN FEDERATION",
            "RWANDA",
            "SAINT HELENA",
            "SAINT KITTS AND NEVIS",
            "SAINT LUCIA",
            "SAINT PIERRE AND MIQUELON",
            "SAINT VINCENT AND THE GRENADINES",
            "SAMOA",
            "SAN MARINO",
            "SAO TOME AND PRINCIPE",
            "SAUDI ARABIA",
            "SENEGAL",
            "SERBIA AND MONTENEGRO",
            "SEYCHELLES",
            "SIERRA LEONE",
            "SINGAPORE",
            "SLOVAKIA",
            "SLOVENIA",
            "SOLOMON ISLANDS",
            "SOMALIA",
            "SOUTH AFRICA",
            "SOUTH GEORGIA AND THE SOUTH SANDWICH ISLANDS",
            "SPAIN",
            "SRI LANKA",
            "SUDAN",
            "SURINAME",
            "SVALBARD AND JAN MAYEN",
            "SWAZILAND",
            "SWEDEN",
            "SWITZERLAND",
            "SYRIAN ARAB REPUBLIC",
            "TAIWAN, PROVINCE OF CHINA",
            "TAJIKISTAN",
            "TANZANIA, UNITED REPUBLIC OF",
            "THAILAND",
            "TIMOR-LESTE",
            "TOGO",
            "TOKELAU",
            "TONGA",
            "TRINIDAD AND TOBAGO",
            "TUNISIA",
            "TURKEY",
            "TURKMENISTAN",
            "TURKS AND CAICOS ISLANDS",
            "TUVALU",
            "UGANDA",
            "UKRAINE",
            "UNITED ARAB EMIRATES",
            "UNITED KINGDOM",
            "UNITED STATES",
            "UNITED STATES MINOR OUTLYING ISLANDS",
            "URUGUAY",
            "UZBEKISTAN",
            "VANUATU",
            "VENEZUELA",
            "VIET NAM",
            "VIRGIN ISLANDS, BRITISH",
            "VIRGIN ISLANDS, U.S.",
            "WALLIS AND FUTUNA",
            "WESTERN SAHARA",
            "YEMEN",
            "ZAMBIA",
            "ZIMBABWE"});
            this.cbbCountry.Location = new System.Drawing.Point(1131, 26);
            this.cbbCountry.Name = "cbbCountry";
            this.cbbCountry.Size = new System.Drawing.Size(258, 29);
            this.cbbCountry.TabIndex = 2;
            // 
            // cbbCity
            // 
            this.cbbCity.FormattingEnabled = true;
            this.cbbCity.Items.AddRange(new object[] {
            "Amsterdam",
            "Athens",
            "Baghdad",
            "Bangkok\t",
            "Barcelona\t",
            "Beijing\t",
            "Belgrade\t",
            "Berlin\t",
            "Bogota\t",
            "Bratislava\t",
            "Brussels\t",
            "Bucharest\t",
            "Budapest\t",
            "Buenos Aires\t",
            "Cairo\t",
            "Cape Town\t",
            "Caracas\t",
            "Chicago\t",
            "Copenhagen\t",
            "Dhaka\t",
            "Dubai\t",
            "Dublin\t",
            "Frankfurt\t",
            "Geneva",
            "The Hague\t",
            "Hanoi\t",
            "Helsinki\t",
            "Hong Kong\t",
            "Istanbul\t",
            "Jakarta\t",
            "Jerusalem\t",
            "Johannesburg",
            "Kabul",
            "Karachi",
            "Kiev",
            "Kuala Lumpur",
            "Lagos",
            "Lahore",
            "Lima",
            "Lisbon",
            "Ljubljana",
            "London",
            "Los Angeles",
            "Luxembourg",
            "Madrid",
            "Marrakesh\t",
            "Manila\t",
            "Mexico City\t",
            "Montreal\t",
            "Moscow\t",
            "Mumbai",
            "Nairobi\t",
            "New Delhi",
            "New York",
            "Nicosia\t",
            "Oslo\t",
            "Ottawa\t",
            "Paris\t",
            "Prague\t",
            "Reykjavik",
            "Riga\t",
            "Rio de Janeiro\t",
            "Rome\t",
            "Saint Petersburg\t",
            "San Francisco\t",
            "Santiago ",
            "São Paulo\t",
            "Seoul\t",
            "Shanghai\t",
            "Singapore\t",
            "Sofia\t",
            "Stockholm\t",
            "Sydney\t",
            "Tallinn\t",
            "Tehran\t",
            "Tokyo\t",
            "Toronto\t",
            "Venice\t",
            "Vienna\t",
            "Vilnius\t",
            "Warsaw\t",
            "Washington, D.C.\t",
            "Wellington",
            "Zagreb\t"});
            this.cbbCity.Location = new System.Drawing.Point(675, 81);
            this.cbbCity.Name = "cbbCity";
            this.cbbCity.Size = new System.Drawing.Size(258, 29);
            this.cbbCity.TabIndex = 2;
            // 
            // txtbPostalCode
            // 
            this.txtbPostalCode.Location = new System.Drawing.Point(675, 192);
            this.txtbPostalCode.Name = "txtbPostalCode";
            this.txtbPostalCode.Size = new System.Drawing.Size(258, 29);
            this.txtbPostalCode.TabIndex = 1;
            // 
            // txtbAddress
            // 
            this.txtbAddress.Location = new System.Drawing.Point(675, 26);
            this.txtbAddress.Name = "txtbAddress";
            this.txtbAddress.Size = new System.Drawing.Size(258, 29);
            this.txtbAddress.TabIndex = 1;
            // 
            // txtbRegion
            // 
            this.txtbRegion.Location = new System.Drawing.Point(675, 139);
            this.txtbRegion.Name = "txtbRegion";
            this.txtbRegion.Size = new System.Drawing.Size(258, 29);
            this.txtbRegion.TabIndex = 1;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(1131, 139);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(258, 29);
            this.txtFax.TabIndex = 1;
            this.txtFax.TextChanged += new System.EventHandler(this.txtbPhone_TextChanged);
            // 
            // txtbPhone
            // 
            this.txtbPhone.Location = new System.Drawing.Point(1131, 81);
            this.txtbPhone.Name = "txtbPhone";
            this.txtbPhone.Size = new System.Drawing.Size(258, 29);
            this.txtbPhone.TabIndex = 1;
            this.txtbPhone.TextChanged += new System.EventHandler(this.txtbPhone_TextChanged);
            // 
            // txtbContactTitle
            // 
            this.txtbContactTitle.Location = new System.Drawing.Point(157, 192);
            this.txtbContactTitle.Name = "txtbContactTitle";
            this.txtbContactTitle.Size = new System.Drawing.Size(258, 29);
            this.txtbContactTitle.TabIndex = 1;
            // 
            // txtbContactName
            // 
            this.txtbContactName.Location = new System.Drawing.Point(157, 139);
            this.txtbContactName.Name = "txtbContactName";
            this.txtbContactName.Size = new System.Drawing.Size(258, 29);
            this.txtbContactName.TabIndex = 1;
            // 
            // txtbCompanyName
            // 
            this.txtbCompanyName.Location = new System.Drawing.Point(157, 81);
            this.txtbCompanyName.Name = "txtbCompanyName";
            this.txtbCompanyName.Size = new System.Drawing.Size(258, 29);
            this.txtbCompanyName.TabIndex = 1;
            // 
            // txtbCustomerID
            // 
            this.txtbCustomerID.Location = new System.Drawing.Point(157, 26);
            this.txtbCustomerID.Name = "txtbCustomerID";
            this.txtbCustomerID.Size = new System.Drawing.Size(258, 29);
            this.txtbCustomerID.TabIndex = 1;
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(1069, 142);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(42, 21);
            this.lblFax.TabIndex = 0;
            this.lblFax.Text = "Fax:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(1050, 84);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(61, 21);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Phone:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(619, 84);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(50, 21);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "City: ";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(597, 142);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(72, 21);
            this.lblRegion.TabIndex = 0;
            this.lblRegion.Text = "Region: ";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(6, 84);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(135, 21);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "Company Name:";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(563, 200);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(106, 21);
            this.lblPostalCode.TabIndex = 0;
            this.lblPostalCode.Text = "Postal Code:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(1036, 29);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(75, 21);
            this.lblCountry.TabIndex = 0;
            this.lblCountry.Text = "Country:";
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Location = new System.Drawing.Point(20, 142);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(121, 21);
            this.lblContactName.TabIndex = 0;
            this.lblContactName.Text = "Contact Name:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(587, 29);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(82, 21);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address: ";
            // 
            // lblContactTitle
            // 
            this.lblContactTitle.AutoSize = true;
            this.lblContactTitle.Location = new System.Drawing.Point(31, 200);
            this.lblContactTitle.Name = "lblContactTitle";
            this.lblContactTitle.Size = new System.Drawing.Size(110, 21);
            this.lblContactTitle.TabIndex = 0;
            this.lblContactTitle.Text = "Contact Title:";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(35, 29);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(106, 21);
            this.lblCustomerID.TabIndex = 0;
            this.lblCustomerID.Text = "CustomerID:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 512);
            this.Controls.Add(this.gbCustomerDeTail);
            this.Controls.Add(this.gbCustomerInfor);
            this.Name = "frmMain";
            this.Text = "Manage Customer";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbCustomerInfor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomer)).EndInit();
            this.gbCustomerDeTail.ResumeLayout(false);
            this.gbCustomerDeTail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCustomerInfor;
        private System.Windows.Forms.GroupBox gbCustomerDeTail;
        private System.Windows.Forms.DataGridView dtgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Region;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fax;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblContactTitle;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtbPhone;
        private System.Windows.Forms.TextBox txtbContactTitle;
        private System.Windows.Forms.TextBox txtbContactName;
        private System.Windows.Forms.TextBox txtbCompanyName;
        private System.Windows.Forms.TextBox txtbCustomerID;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.TextBox txtbPostalCode;
        private System.Windows.Forms.ComboBox cbbCountry;
        private System.Windows.Forms.ComboBox cbbCity;
        private System.Windows.Forms.TextBox txtbRegion;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtbAddress;
        private System.Windows.Forms.TextBox txtFax;
    }
}

