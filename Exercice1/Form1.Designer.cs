namespace Exercice1
{
    partial class Form1
    {
        public Form1(string gate,string ipLocal,string hosstName,string username,string SSID,string SSIDStatus,string mac,string installed,string version,string conectionStatus)
        {
            InitializeComponent();
            this.ipgateway.Text = gate;
            this.iphost.Text = ipLocal;
            this.hostname.Text = hosstName;
            this.username.Text = username;
            this.ssid.Text = SSID;
            this.ssidstat.Text = SSIDStatus;
            this.mac.Text= mac;
            this.installed.Text= installed;
            this.version.Text = version;
            this.con.Text= conectionStatus;
        }
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.version = new System.Windows.Forms.Label();
            this.con = new System.Windows.Forms.Label();
            this.installed = new System.Windows.Forms.Label();
            this.ssid = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.iphost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ipgateway = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.hostname = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ssidstat = new System.Windows.Forms.Label();
            this.mac = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.version, 9, 2);
            this.tableLayoutPanel1.Controls.Add(this.con, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.installed, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.ssid, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.username, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.iphost, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ipgateway, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.hostname, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label12, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.label13, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.label14, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.label15, 8, 2);
            this.tableLayoutPanel1.Controls.Add(this.ssidstat, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.mac, 7, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(966, 348);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // version
            // 
            this.version.Location = new System.Drawing.Point(867, 232);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(90, 116);
            this.version.TabIndex = 20;
            this.version.Text = "<Version>";
            this.version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // con
            // 
            this.con.Location = new System.Drawing.Point(675, 232);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(90, 116);
            this.con.TabIndex = 19;
            this.con.Text = "<Connection>";
            this.con.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // installed
            // 
            this.installed.Location = new System.Drawing.Point(867, 116);
            this.installed.Name = "installed";
            this.installed.Size = new System.Drawing.Size(90, 116);
            this.installed.TabIndex = 18;
            this.installed.Text = "<VBinstall>";
            this.installed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ssid
            // 
            this.ssid.Location = new System.Drawing.Point(483, 116);
            this.ssid.Name = "ssid";
            this.ssid.Size = new System.Drawing.Size(90, 116);
            this.ssid.TabIndex = 15;
            this.ssid.Text = "<SSID>";
            this.ssid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(387, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 116);
            this.label10.TabIndex = 9;
            this.label10.Text = "SSID:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(291, 116);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(90, 116);
            this.username.TabIndex = 7;
            this.username.Text = "<username>";
            this.username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(195, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 116);
            this.label6.TabIndex = 5;
            this.label6.Text = "Username:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iphost
            // 
            this.iphost.Location = new System.Drawing.Point(99, 116);
            this.iphost.Name = "iphost";
            this.iphost.Size = new System.Drawing.Size(90, 116);
            this.iphost.TabIndex = 3;
            this.iphost.Text = "<iphost>";
            this.iphost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 10);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(966, 116);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To VirtualBox Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 116);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP Host:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 116);
            this.label3.TabIndex = 2;
            this.label3.Text = "IP Gateway:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ipgateway
            // 
            this.ipgateway.Location = new System.Drawing.Point(99, 232);
            this.ipgateway.Name = "ipgateway";
            this.ipgateway.Size = new System.Drawing.Size(90, 116);
            this.ipgateway.TabIndex = 4;
            this.ipgateway.Text = "<ipgateway>";
            this.ipgateway.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(195, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 116);
            this.label7.TabIndex = 6;
            this.label7.Text = "HostName:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hostname
            // 
            this.hostname.Location = new System.Drawing.Point(291, 232);
            this.hostname.Name = "hostname";
            this.hostname.Size = new System.Drawing.Size(90, 116);
            this.hostname.TabIndex = 8;
            this.hostname.Text = "<hostname>";
            this.hostname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(387, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 116);
            this.label11.TabIndex = 10;
            this.label11.Text = "SSID Status:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(579, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 116);
            this.label12.TabIndex = 11;
            this.label12.Text = "MAC Adress:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(579, 232);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 116);
            this.label13.TabIndex = 12;
            this.label13.Text = "Internet Connection:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(771, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 116);
            this.label14.TabIndex = 13;
            this.label14.Text = "Is VB installed?";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(771, 232);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 116);
            this.label15.TabIndex = 14;
            this.label15.Text = "VB Version:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ssidstat
            // 
            this.ssidstat.Location = new System.Drawing.Point(483, 232);
            this.ssidstat.Name = "ssidstat";
            this.ssidstat.Size = new System.Drawing.Size(90, 116);
            this.ssidstat.TabIndex = 16;
            this.ssidstat.Text = "<SSID Status>";
            this.ssidstat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mac
            // 
            this.mac.Location = new System.Drawing.Point(675, 116);
            this.mac.Name = "mac";
            this.mac.Size = new System.Drawing.Size(90, 116);
            this.mac.TabIndex = 17;
            this.mac.Text = "<MAC>";
            this.mac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 372);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label con;
        private System.Windows.Forms.Label installed;
        private System.Windows.Forms.Label ssid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label iphost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ipgateway;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label hostname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label ssidstat;
        private System.Windows.Forms.Label mac;
    }
}

