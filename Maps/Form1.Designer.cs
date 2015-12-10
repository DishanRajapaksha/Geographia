namespace Maps
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
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.label1 = new System.Windows.Forms.Label();
            this.Keyword = new System.Windows.Forms.TextBox();
            this.latitude = new System.Windows.Forms.TextBox();
            this.longitude = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.SetCordinates = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Label();
            this.lblLat = new System.Windows.Forms.Label();
            this.lblLong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxMapType = new MetroFramework.Controls.MetroComboBox();
            this.Mode = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // gmap
            // 
            this.gmap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gmap.AutoSize = true;
            this.gmap.BackColor = System.Drawing.Color.White;
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(-2, 5);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 20;
            this.gmap.MinZoom = 3;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(947, 703);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 4D;
            this.gmap.Load += new System.EventHandler(this.gmap_Load);
            this.gmap.Click += new System.EventHandler(this.gmap_Click);
            this.gmap.DoubleClick += new System.EventHandler(this.gmap_DoubleClick);
            this.gmap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gmap_KeyPress);
            this.gmap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gmap_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Geographia";
            // 
            // Keyword
            // 
            this.Keyword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Keyword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Keyword.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Keyword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Keyword.Location = new System.Drawing.Point(961, 60);
            this.Keyword.Name = "Keyword";
            this.Keyword.Size = new System.Drawing.Size(203, 27);
            this.Keyword.TabIndex = 2;
            this.Keyword.Text = "Enter Keywords";
            this.Keyword.Click += new System.EventHandler(this.Keyword_Click);
            // 
            // latitude
            // 
            this.latitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.latitude.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.latitude.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latitude.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.latitude.Location = new System.Drawing.Point(961, 107);
            this.latitude.Name = "latitude";
            this.latitude.Size = new System.Drawing.Size(174, 27);
            this.latitude.TabIndex = 3;
            // 
            // longitude
            // 
            this.longitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.longitude.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.longitude.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longitude.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.longitude.Location = new System.Drawing.Point(961, 142);
            this.longitude.Name = "longitude";
            this.longitude.Size = new System.Drawing.Size(174, 27);
            this.longitude.TabIndex = 4;
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Search.Location = new System.Drawing.Point(1196, 58);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(72, 28);
            this.Search.TabIndex = 5;
            this.Search.Text = "Search";
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // SetCordinates
            // 
            this.SetCordinates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SetCordinates.AutoSize = true;
            this.SetCordinates.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetCordinates.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SetCordinates.Location = new System.Drawing.Point(956, 190);
            this.SetCordinates.Name = "SetCordinates";
            this.SetCordinates.Size = new System.Drawing.Size(175, 28);
            this.SetCordinates.TabIndex = 6;
            this.SetCordinates.Text = "Go to coordinates";
            this.SetCordinates.Click += new System.EventHandler(this.SetCordinates_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.AutoSize = true;
            this.SaveBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SaveBtn.Location = new System.Drawing.Point(956, 238);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(104, 28);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "Save View";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // lblLat
            // 
            this.lblLat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLat.AutoSize = true;
            this.lblLat.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLat.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblLat.Location = new System.Drawing.Point(1186, 106);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(79, 28);
            this.lblLat.TabIndex = 9;
            this.lblLat.Text = "Latitude";
            // 
            // lblLong
            // 
            this.lblLong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLong.AutoSize = true;
            this.lblLong.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLong.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblLong.Location = new System.Drawing.Point(1169, 141);
            this.lblLong.Name = "lblLong";
            this.lblLong.Size = new System.Drawing.Size(96, 28);
            this.lblLong.TabIndex = 10;
            this.lblLong.Text = "Longitude";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(1029, 640);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 45);
            this.label3.TabIndex = 15;
            this.label3.Text = "Geographia";
            // 
            // comboBoxMapType
            // 
            this.comboBoxMapType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMapType.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.comboBoxMapType.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.comboBoxMapType.FormattingEnabled = true;
            this.comboBoxMapType.ItemHeight = 29;
            this.comboBoxMapType.Location = new System.Drawing.Point(961, 295);
            this.comboBoxMapType.Name = "comboBoxMapType";
            this.comboBoxMapType.Size = new System.Drawing.Size(304, 35);
            this.comboBoxMapType.Style = MetroFramework.MetroColorStyle.Blue;
            this.comboBoxMapType.TabIndex = 17;
            this.comboBoxMapType.DropDownClosed += new System.EventHandler(this.comboBoxMapType_DropDownClosed);
            // 
            // Mode
            // 
            this.Mode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Mode.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.Mode.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.Mode.FormattingEnabled = true;
            this.Mode.ItemHeight = 29;
            this.Mode.Location = new System.Drawing.Point(961, 359);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(304, 35);
            this.Mode.Style = MetroFramework.MetroColorStyle.Blue;
            this.Mode.TabIndex = 18;
            this.Mode.DropDownClosed += new System.EventHandler(this.Mode_DropDownClosed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 706);
            this.Controls.Add(this.Mode);
            this.Controls.Add(this.comboBoxMapType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLong);
            this.Controls.Add(this.lblLat);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.SetCordinates);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.longitude);
            this.Controls.Add(this.latitude);
            this.Controls.Add(this.Keyword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gmap);
            this.DisplayHeader = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.Text = "Geographia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Keyword;
        private System.Windows.Forms.Label SaveBtn;
        private System.Windows.Forms.Label SetCordinates;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.TextBox longitude;
        private System.Windows.Forms.TextBox latitude;
        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.Label lblLong;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox comboBoxMapType;
        private MetroFramework.Controls.MetroComboBox Mode;
    }
}

