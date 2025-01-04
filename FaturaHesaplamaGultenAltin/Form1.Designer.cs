namespace FaturaHesaplamaGultenAltin
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTasimaYolu = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCifTry = new System.Windows.Forms.TextBox();
            this.txtCifUsd = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTutar015 = new System.Windows.Forms.TextBox();
            this.txtTutar15225 = new System.Windows.Forms.TextBox();
            this.txtTutar2252m = new System.Windows.Forms.TextBox();
            this.txtTutar2m10m = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtTutar10mUstu = new System.Windows.Forms.Label();
            this.btnHesapla = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnTemizle = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "CIF Tutarı (TRY)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dolar Kuru";
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Location = new System.Drawing.Point(251, 90);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(136, 20);
            this.lblDolar.TabIndex = 3;
            this.lblDolar.Text = "Veri Bekleniyor. . . ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Doların Alındığı Site: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Taşıma Yolu";
            // 
            // cmbTasimaYolu
            // 
            this.cmbTasimaYolu.BackColor = System.Drawing.Color.Transparent;
            this.cmbTasimaYolu.BackgroundColor = System.Drawing.Color.White;
            this.cmbTasimaYolu.BorderColor = System.Drawing.Color.Silver;
            this.cmbTasimaYolu.BorderRadius = 1;
            this.cmbTasimaYolu.Color = System.Drawing.Color.Silver;
            this.cmbTasimaYolu.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmbTasimaYolu.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbTasimaYolu.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbTasimaYolu.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbTasimaYolu.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbTasimaYolu.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbTasimaYolu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTasimaYolu.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cmbTasimaYolu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTasimaYolu.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbTasimaYolu.FillDropDown = true;
            this.cmbTasimaYolu.FillIndicator = false;
            this.cmbTasimaYolu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTasimaYolu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbTasimaYolu.ForeColor = System.Drawing.Color.Black;
            this.cmbTasimaYolu.FormattingEnabled = true;
            this.cmbTasimaYolu.Icon = null;
            this.cmbTasimaYolu.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbTasimaYolu.IndicatorColor = System.Drawing.Color.Gray;
            this.cmbTasimaYolu.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbTasimaYolu.ItemBackColor = System.Drawing.Color.White;
            this.cmbTasimaYolu.ItemBorderColor = System.Drawing.Color.White;
            this.cmbTasimaYolu.ItemForeColor = System.Drawing.Color.Black;
            this.cmbTasimaYolu.ItemHeight = 26;
            this.cmbTasimaYolu.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cmbTasimaYolu.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmbTasimaYolu.Items.AddRange(new object[] {
            "ROAD",
            "AIR",
            "SEA"});
            this.cmbTasimaYolu.ItemTopMargin = 3;
            this.cmbTasimaYolu.Location = new System.Drawing.Point(255, 120);
            this.cmbTasimaYolu.Name = "cmbTasimaYolu";
            this.cmbTasimaYolu.Size = new System.Drawing.Size(175, 32);
            this.cmbTasimaYolu.TabIndex = 6;
            this.cmbTasimaYolu.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbTasimaYolu.TextLeftMargin = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "CIF Tutarı (USD)";
            // 
            // txtCifTry
            // 
            this.txtCifTry.Location = new System.Drawing.Point(255, 49);
            this.txtCifTry.Name = "txtCifTry";
            this.txtCifTry.Size = new System.Drawing.Size(175, 27);
            this.txtCifTry.TabIndex = 9;
            // 
            // txtCifUsd
            // 
            this.txtCifUsd.Location = new System.Drawing.Point(255, 158);
            this.txtCifUsd.Name = "txtCifUsd";
            this.txtCifUsd.Size = new System.Drawing.Size(175, 27);
            this.txtCifUsd.TabIndex = 10;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(155, 11);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(239, 15);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://www.tcmb.gov.tr/kurlar/today.xml";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tutar(0-15.000)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tutar(15.001-225.000)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tutar(225.000-2.000.000)";
            // 
            // txtTutar015
            // 
            this.txtTutar015.Location = new System.Drawing.Point(255, 240);
            this.txtTutar015.Name = "txtTutar015";
            this.txtTutar015.Size = new System.Drawing.Size(175, 27);
            this.txtTutar015.TabIndex = 15;
            // 
            // txtTutar15225
            // 
            this.txtTutar15225.Location = new System.Drawing.Point(255, 270);
            this.txtTutar15225.Name = "txtTutar15225";
            this.txtTutar15225.Size = new System.Drawing.Size(175, 27);
            this.txtTutar15225.TabIndex = 16;
            // 
            // txtTutar2252m
            // 
            this.txtTutar2252m.Location = new System.Drawing.Point(255, 303);
            this.txtTutar2252m.Name = "txtTutar2252m";
            this.txtTutar2252m.Size = new System.Drawing.Size(175, 27);
            this.txtTutar2252m.TabIndex = 17;
            // 
            // txtTutar2m10m
            // 
            this.txtTutar2m10m.Location = new System.Drawing.Point(255, 336);
            this.txtTutar2m10m.Name = "txtTutar2m10m";
            this.txtTutar2m10m.Size = new System.Drawing.Size(175, 27);
            this.txtTutar2m10m.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tutar(2.000.001,10.000.000)";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(255, 369);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(175, 27);
            this.textBox5.TabIndex = 20;
            // 
            // txtTutar10mUstu
            // 
            this.txtTutar10mUstu.AutoSize = true;
            this.txtTutar10mUstu.Location = new System.Drawing.Point(31, 372);
            this.txtTutar10mUstu.Name = "txtTutar10mUstu";
            this.txtTutar10mUstu.Size = new System.Drawing.Size(134, 20);
            this.txtTutar10mUstu.TabIndex = 21;
            this.txtTutar10mUstu.Text = "Tutar(>10.000.000)";
            // 
            // btnHesapla
            // 
            this.btnHesapla.AllowAnimations = true;
            this.btnHesapla.AllowMouseEffects = true;
            this.btnHesapla.AllowToggling = false;
            this.btnHesapla.AnimationSpeed = 200;
            this.btnHesapla.AutoGenerateColors = false;
            this.btnHesapla.AutoRoundBorders = false;
            this.btnHesapla.AutoSizeLeftIcon = true;
            this.btnHesapla.AutoSizeRightIcon = true;
            this.btnHesapla.BackColor = System.Drawing.Color.Transparent;
            this.btnHesapla.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnHesapla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHesapla.BackgroundImage")));
            this.btnHesapla.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHesapla.ButtonText = "Hesapla";
            this.btnHesapla.ButtonTextMarginLeft = 0;
            this.btnHesapla.ColorContrastOnClick = 45;
            this.btnHesapla.ColorContrastOnHover = 45;
            this.btnHesapla.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnHesapla.CustomizableEdges = borderEdges1;
            this.btnHesapla.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHesapla.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnHesapla.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnHesapla.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnHesapla.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnHesapla.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.ForeColor = System.Drawing.Color.White;
            this.btnHesapla.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHesapla.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnHesapla.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnHesapla.IconMarginLeft = 11;
            this.btnHesapla.IconPadding = 10;
            this.btnHesapla.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHesapla.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnHesapla.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnHesapla.IconSize = 25;
            this.btnHesapla.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnHesapla.IdleBorderRadius = 1;
            this.btnHesapla.IdleBorderThickness = 1;
            this.btnHesapla.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnHesapla.IdleIconLeftImage = null;
            this.btnHesapla.IdleIconRightImage = null;
            this.btnHesapla.IndicateFocus = false;
            this.btnHesapla.Location = new System.Drawing.Point(255, 402);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnHesapla.OnDisabledState.BorderRadius = 1;
            this.btnHesapla.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHesapla.OnDisabledState.BorderThickness = 1;
            this.btnHesapla.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnHesapla.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnHesapla.OnDisabledState.IconLeftImage = null;
            this.btnHesapla.OnDisabledState.IconRightImage = null;
            this.btnHesapla.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnHesapla.onHoverState.BorderRadius = 1;
            this.btnHesapla.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHesapla.onHoverState.BorderThickness = 1;
            this.btnHesapla.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnHesapla.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnHesapla.onHoverState.IconLeftImage = null;
            this.btnHesapla.onHoverState.IconRightImage = null;
            this.btnHesapla.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnHesapla.OnIdleState.BorderRadius = 1;
            this.btnHesapla.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHesapla.OnIdleState.BorderThickness = 1;
            this.btnHesapla.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnHesapla.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnHesapla.OnIdleState.IconLeftImage = null;
            this.btnHesapla.OnIdleState.IconRightImage = null;
            this.btnHesapla.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnHesapla.OnPressedState.BorderRadius = 1;
            this.btnHesapla.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHesapla.OnPressedState.BorderThickness = 1;
            this.btnHesapla.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnHesapla.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnHesapla.OnPressedState.IconLeftImage = null;
            this.btnHesapla.OnPressedState.IconRightImage = null;
            this.btnHesapla.Size = new System.Drawing.Size(175, 39);
            this.btnHesapla.TabIndex = 22;
            this.btnHesapla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHesapla.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHesapla.TextMarginLeft = 0;
            this.btnHesapla.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnHesapla.UseDefaultRadiusAndThickness = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.AllowAnimations = true;
            this.btnTemizle.AllowMouseEffects = true;
            this.btnTemizle.AllowToggling = false;
            this.btnTemizle.AnimationSpeed = 200;
            this.btnTemizle.AutoGenerateColors = false;
            this.btnTemizle.AutoRoundBorders = false;
            this.btnTemizle.AutoSizeLeftIcon = true;
            this.btnTemizle.AutoSizeRightIcon = true;
            this.btnTemizle.BackColor = System.Drawing.Color.Transparent;
            this.btnTemizle.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnTemizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTemizle.BackgroundImage")));
            this.btnTemizle.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTemizle.ButtonText = "Temizle";
            this.btnTemizle.ButtonTextMarginLeft = 0;
            this.btnTemizle.ColorContrastOnClick = 45;
            this.btnTemizle.ColorContrastOnHover = 45;
            this.btnTemizle.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnTemizle.CustomizableEdges = borderEdges2;
            this.btnTemizle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTemizle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTemizle.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTemizle.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnTemizle.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemizle.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnTemizle.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnTemizle.IconMarginLeft = 11;
            this.btnTemizle.IconPadding = 10;
            this.btnTemizle.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTemizle.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnTemizle.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnTemizle.IconSize = 25;
            this.btnTemizle.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnTemizle.IdleBorderRadius = 1;
            this.btnTemizle.IdleBorderThickness = 1;
            this.btnTemizle.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnTemizle.IdleIconLeftImage = null;
            this.btnTemizle.IdleIconRightImage = null;
            this.btnTemizle.IndicateFocus = false;
            this.btnTemizle.Location = new System.Drawing.Point(255, 447);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTemizle.OnDisabledState.BorderRadius = 1;
            this.btnTemizle.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTemizle.OnDisabledState.BorderThickness = 1;
            this.btnTemizle.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTemizle.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnTemizle.OnDisabledState.IconLeftImage = null;
            this.btnTemizle.OnDisabledState.IconRightImage = null;
            this.btnTemizle.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnTemizle.onHoverState.BorderRadius = 1;
            this.btnTemizle.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTemizle.onHoverState.BorderThickness = 1;
            this.btnTemizle.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnTemizle.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.onHoverState.IconLeftImage = null;
            this.btnTemizle.onHoverState.IconRightImage = null;
            this.btnTemizle.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnTemizle.OnIdleState.BorderRadius = 1;
            this.btnTemizle.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTemizle.OnIdleState.BorderThickness = 1;
            this.btnTemizle.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnTemizle.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.OnIdleState.IconLeftImage = null;
            this.btnTemizle.OnIdleState.IconRightImage = null;
            this.btnTemizle.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnTemizle.OnPressedState.BorderRadius = 1;
            this.btnTemizle.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTemizle.OnPressedState.BorderThickness = 1;
            this.btnTemizle.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnTemizle.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.OnPressedState.IconLeftImage = null;
            this.btnTemizle.OnPressedState.IconRightImage = null;
            this.btnTemizle.Size = new System.Drawing.Size(175, 39);
            this.btnTemizle.TabIndex = 23;
            this.btnTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTemizle.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTemizle.TextMarginLeft = 0;
            this.btnTemizle.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnTemizle.UseDefaultRadiusAndThickness = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(472, 491);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtTutar10mUstu);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTutar2m10m);
            this.Controls.Add(this.txtTutar2252m);
            this.Controls.Add(this.txtTutar15225);
            this.Controls.Add(this.txtTutar015);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtCifUsd);
            this.Controls.Add(this.txtCifTry);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTasimaYolu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "İyi çalışmalar, Gülten Hanım";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuDropdown cmbTasimaYolu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCifTry;
        private System.Windows.Forms.TextBox txtCifUsd;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTutar015;
        private System.Windows.Forms.TextBox txtTutar15225;
        private System.Windows.Forms.TextBox txtTutar2252m;
        private System.Windows.Forms.TextBox txtTutar2m10m;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label txtTutar10mUstu;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnHesapla;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnTemizle;
    }
}

