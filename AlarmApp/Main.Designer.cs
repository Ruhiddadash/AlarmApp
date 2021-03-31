namespace AlarmApp
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_quo = new System.Windows.Forms.Label();
            this.lbl_minute = new System.Windows.Forms.Label();
            this.lbl_second = new System.Windows.Forms.Label();
            this.lbl_hour = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_curtime = new System.Windows.Forms.Label();
            this.lbl_curdate = new System.Windows.Forms.Label();
            this.pnl_btm = new System.Windows.Forms.Panel();
            this.lbl_keyhelp = new System.Windows.Forms.Label();
            this.lbl_keyinfo = new System.Windows.Forms.Label();
            this.lbl_alarm = new System.Windows.Forms.Label();
            this.cb_second = new System.Windows.Forms.ComboBox();
            this.btn_set = new System.Windows.Forms.Button();
            this.panel_alarm = new System.Windows.Forms.Panel();
            this.cb_minute = new System.Windows.Forms.ComboBox();
            this.cb_hour = new System.Windows.Forms.ComboBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_remove = new System.Windows.Forms.Button();
            this.timer_alarm = new System.Windows.Forms.Timer(this.components);
            this.timer_current = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.panel_stopwatch = new System.Windows.Forms.Panel();
            this.btn_swpause = new System.Windows.Forms.Button();
            this.btn_swreset = new System.Windows.Forms.Button();
            this.btn_swstart = new System.Windows.Forms.Button();
            this.lbl_countdown = new System.Windows.Forms.Label();
            this.timer_count = new System.Windows.Forms.Timer(this.components);
            this.pnl_top.SuspendLayout();
            this.pnl_btm.SuspendLayout();
            this.panel_alarm.SuspendLayout();
            this.panel_stopwatch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.Controls.Add(this.lbl_date);
            this.pnl_top.Controls.Add(this.label2);
            this.pnl_top.Controls.Add(this.lbl_quo);
            this.pnl_top.Controls.Add(this.lbl_minute);
            this.pnl_top.Controls.Add(this.lbl_second);
            this.pnl_top.Controls.Add(this.lbl_hour);
            this.pnl_top.Controls.Add(this.label1);
            this.pnl_top.Controls.Add(this.lbl_curtime);
            this.pnl_top.Controls.Add(this.lbl_curdate);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(908, 61);
            this.pnl_top.TabIndex = 0;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_date.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.Lime;
            this.lbl_date.Location = new System.Drawing.Point(600, 37);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(46, 21);
            this.lbl_date.TabIndex = 13;
            this.lbl_date.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(310, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = ":";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_quo
            // 
            this.lbl_quo.AutoSize = true;
            this.lbl_quo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_quo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quo.ForeColor = System.Drawing.Color.Lime;
            this.lbl_quo.Location = new System.Drawing.Point(222, 37);
            this.lbl_quo.Name = "lbl_quo";
            this.lbl_quo.Size = new System.Drawing.Size(16, 21);
            this.lbl_quo.TabIndex = 11;
            this.lbl_quo.Text = ":";
            this.lbl_quo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_minute
            // 
            this.lbl_minute.AutoSize = true;
            this.lbl_minute.BackColor = System.Drawing.Color.Transparent;
            this.lbl_minute.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_minute.ForeColor = System.Drawing.Color.Lime;
            this.lbl_minute.Location = new System.Drawing.Point(244, 37);
            this.lbl_minute.Name = "lbl_minute";
            this.lbl_minute.Size = new System.Drawing.Size(60, 21);
            this.lbl_minute.TabIndex = 10;
            this.lbl_minute.Text = "Minute";
            this.lbl_minute.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_second
            // 
            this.lbl_second.AutoSize = true;
            this.lbl_second.BackColor = System.Drawing.Color.Transparent;
            this.lbl_second.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_second.ForeColor = System.Drawing.Color.Lime;
            this.lbl_second.Location = new System.Drawing.Point(332, 37);
            this.lbl_second.Name = "lbl_second";
            this.lbl_second.Size = new System.Drawing.Size(63, 21);
            this.lbl_second.TabIndex = 9;
            this.lbl_second.Text = "Second";
            this.lbl_second.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_hour
            // 
            this.lbl_hour.AutoSize = true;
            this.lbl_hour.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hour.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hour.ForeColor = System.Drawing.Color.Lime;
            this.lbl_hour.Location = new System.Drawing.Point(171, 37);
            this.lbl_hour.Name = "lbl_hour";
            this.lbl_hour.Size = new System.Drawing.Size(45, 21);
            this.lbl_hour.TabIndex = 8;
            this.lbl_hour.Text = "Hour";
            this.lbl_hour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // lbl_curtime
            // 
            this.lbl_curtime.AutoSize = true;
            this.lbl_curtime.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_curtime.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_curtime.Location = new System.Drawing.Point(28, 34);
            this.lbl_curtime.Name = "lbl_curtime";
            this.lbl_curtime.Size = new System.Drawing.Size(140, 24);
            this.lbl_curtime.TabIndex = 6;
            this.lbl_curtime.Text = "Current Time :";
            // 
            // lbl_curdate
            // 
            this.lbl_curdate.AutoSize = true;
            this.lbl_curdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_curdate.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_curdate.Location = new System.Drawing.Point(456, 34);
            this.lbl_curdate.Name = "lbl_curdate";
            this.lbl_curdate.Size = new System.Drawing.Size(138, 24);
            this.lbl_curdate.TabIndex = 4;
            this.lbl_curdate.Text = "Current Date :";
            // 
            // pnl_btm
            // 
            this.pnl_btm.Controls.Add(this.lbl_keyhelp);
            this.pnl_btm.Controls.Add(this.lbl_keyinfo);
            this.pnl_btm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_btm.Location = new System.Drawing.Point(0, 509);
            this.pnl_btm.Name = "pnl_btm";
            this.pnl_btm.Size = new System.Drawing.Size(908, 62);
            this.pnl_btm.TabIndex = 1;
            // 
            // lbl_keyhelp
            // 
            this.lbl_keyhelp.AutoSize = true;
            this.lbl_keyhelp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_keyhelp.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_keyhelp.ForeColor = System.Drawing.Color.Lime;
            this.lbl_keyhelp.Location = new System.Drawing.Point(526, 15);
            this.lbl_keyhelp.Name = "lbl_keyhelp";
            this.lbl_keyhelp.Size = new System.Drawing.Size(234, 29);
            this.lbl_keyhelp.TabIndex = 1;
            this.lbl_keyhelp.Text = "Press F11 for help ";
            // 
            // lbl_keyinfo
            // 
            this.lbl_keyinfo.AutoSize = true;
            this.lbl_keyinfo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_keyinfo.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_keyinfo.ForeColor = System.Drawing.Color.Lime;
            this.lbl_keyinfo.Location = new System.Drawing.Point(165, 15);
            this.lbl_keyinfo.Name = "lbl_keyinfo";
            this.lbl_keyinfo.Size = new System.Drawing.Size(214, 29);
            this.lbl_keyinfo.TabIndex = 0;
            this.lbl_keyinfo.Text = "Press F1 for info ";
            // 
            // lbl_alarm
            // 
            this.lbl_alarm.AutoSize = true;
            this.lbl_alarm.BackColor = System.Drawing.Color.Transparent;
            this.lbl_alarm.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alarm.ForeColor = System.Drawing.Color.Lime;
            this.lbl_alarm.Location = new System.Drawing.Point(164, 93);
            this.lbl_alarm.Name = "lbl_alarm";
            this.lbl_alarm.Size = new System.Drawing.Size(123, 34);
            this.lbl_alarm.TabIndex = 2;
            this.lbl_alarm.Text = "Alarm";
            // 
            // cb_second
            // 
            this.cb_second.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_second.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_second.FormattingEnabled = true;
            this.cb_second.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cb_second.Location = new System.Drawing.Point(127, 108);
            this.cb_second.Name = "cb_second";
            this.cb_second.Size = new System.Drawing.Size(121, 29);
            this.cb_second.TabIndex = 5;
            this.cb_second.Text = "Second";
            // 
            // btn_set
            // 
            this.btn_set.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_set.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_set.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_set.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_set.Location = new System.Drawing.Point(59, 181);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(100, 33);
            this.btn_set.TabIndex = 6;
            this.btn_set.Text = "Set Alarm";
            this.btn_set.UseVisualStyleBackColor = false;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // panel_alarm
            // 
            this.panel_alarm.Controls.Add(this.cb_minute);
            this.panel_alarm.Controls.Add(this.cb_hour);
            this.panel_alarm.Controls.Add(this.lbl_status);
            this.panel_alarm.Controls.Add(this.btn_remove);
            this.panel_alarm.Controls.Add(this.btn_set);
            this.panel_alarm.Controls.Add(this.cb_second);
            this.panel_alarm.Location = new System.Drawing.Point(43, 147);
            this.panel_alarm.Name = "panel_alarm";
            this.panel_alarm.Size = new System.Drawing.Size(380, 280);
            this.panel_alarm.TabIndex = 7;
            // 
            // cb_minute
            // 
            this.cb_minute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_minute.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_minute.FormattingEnabled = true;
            this.cb_minute.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cb_minute.Location = new System.Drawing.Point(127, 73);
            this.cb_minute.Name = "cb_minute";
            this.cb_minute.Size = new System.Drawing.Size(121, 29);
            this.cb_minute.TabIndex = 10;
            this.cb_minute.Text = "Minute";
            // 
            // cb_hour
            // 
            this.cb_hour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_hour.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_hour.FormattingEnabled = true;
            this.cb_hour.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cb_hour.Location = new System.Drawing.Point(127, 38);
            this.cb_hour.Name = "cb_hour";
            this.cb_hour.Size = new System.Drawing.Size(121, 29);
            this.cb_hour.TabIndex = 9;
            this.cb_hour.Text = "Hour";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_status.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.Red;
            this.lbl_status.Location = new System.Drawing.Point(139, 222);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(65, 21);
            this.lbl_status.TabIndex = 8;
            this.lbl_status.Text = "Status";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.Red;
            this.btn_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_remove.Location = new System.Drawing.Point(195, 181);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(100, 33);
            this.btn_remove.TabIndex = 7;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // timer_alarm
            // 
            this.timer_alarm.Interval = 500;
            this.timer_alarm.Tick += new System.EventHandler(this.timer_alarm_Tick);
            // 
            // timer_current
            // 
            this.timer_current.Interval = 500;
            this.timer_current.Tick += new System.EventHandler(this.timer_current_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(565, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 34);
            this.label3.TabIndex = 9;
            this.label3.Text = "Stopwatch";
            // 
            // panel_stopwatch
            // 
            this.panel_stopwatch.Controls.Add(this.btn_swpause);
            this.panel_stopwatch.Controls.Add(this.btn_swreset);
            this.panel_stopwatch.Controls.Add(this.btn_swstart);
            this.panel_stopwatch.Controls.Add(this.lbl_countdown);
            this.panel_stopwatch.Location = new System.Drawing.Point(460, 147);
            this.panel_stopwatch.Name = "panel_stopwatch";
            this.panel_stopwatch.Size = new System.Drawing.Size(403, 280);
            this.panel_stopwatch.TabIndex = 10;
            // 
            // btn_swpause
            // 
            this.btn_swpause.BackColor = System.Drawing.Color.Gray;
            this.btn_swpause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_swpause.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_swpause.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_swpause.Location = new System.Drawing.Point(156, 181);
            this.btn_swpause.Name = "btn_swpause";
            this.btn_swpause.Size = new System.Drawing.Size(90, 35);
            this.btn_swpause.TabIndex = 3;
            this.btn_swpause.Text = "Pause";
            this.btn_swpause.UseVisualStyleBackColor = false;
            this.btn_swpause.Click += new System.EventHandler(this.btn_swpause_Click);
            // 
            // btn_swreset
            // 
            this.btn_swreset.BackColor = System.Drawing.Color.Red;
            this.btn_swreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_swreset.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_swreset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_swreset.Location = new System.Drawing.Point(270, 181);
            this.btn_swreset.Name = "btn_swreset";
            this.btn_swreset.Size = new System.Drawing.Size(90, 35);
            this.btn_swreset.TabIndex = 2;
            this.btn_swreset.Text = "Reset";
            this.btn_swreset.UseVisualStyleBackColor = false;
            this.btn_swreset.Click += new System.EventHandler(this.btn_swreset_Click);
            // 
            // btn_swstart
            // 
            this.btn_swstart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_swstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_swstart.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_swstart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_swstart.Location = new System.Drawing.Point(44, 181);
            this.btn_swstart.Name = "btn_swstart";
            this.btn_swstart.Size = new System.Drawing.Size(90, 35);
            this.btn_swstart.TabIndex = 1;
            this.btn_swstart.Text = "Start";
            this.btn_swstart.UseVisualStyleBackColor = false;
            this.btn_swstart.Click += new System.EventHandler(this.btn_swstart_Click);
            // 
            // lbl_countdown
            // 
            this.lbl_countdown.AutoSize = true;
            this.lbl_countdown.BackColor = System.Drawing.Color.White;
            this.lbl_countdown.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lbl_countdown.Location = new System.Drawing.Point(122, 38);
            this.lbl_countdown.Name = "lbl_countdown";
            this.lbl_countdown.Size = new System.Drawing.Size(156, 41);
            this.lbl_countdown.TabIndex = 0;
            this.lbl_countdown.Text = "00:00:00";
            this.lbl_countdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_count
            // 
            this.timer_count.Enabled = true;
            this.timer_count.Interval = 500;
            this.timer_count.Tick += new System.EventHandler(this.timer_count_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(908, 571);
            this.Controls.Add(this.panel_stopwatch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel_alarm);
            this.Controls.Add(this.lbl_alarm);
            this.Controls.Add(this.pnl_btm);
            this.Controls.Add(this.pnl_top);
            this.KeyPreview = true;
            this.Name = "Main";
            this.Text = "Alarm";
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.pnl_btm.ResumeLayout(false);
            this.pnl_btm.PerformLayout();
            this.panel_alarm.ResumeLayout(false);
            this.panel_alarm.PerformLayout();
            this.panel_stopwatch.ResumeLayout(false);
            this.panel_stopwatch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_btm;
        private System.Windows.Forms.Label lbl_curdate;
        private System.Windows.Forms.Label lbl_curtime;
        private System.Windows.Forms.Label lbl_alarm;
        private System.Windows.Forms.ComboBox cb_second;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Panel panel_alarm;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Timer timer_alarm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_quo;
        private System.Windows.Forms.Label lbl_minute;
        private System.Windows.Forms.Label lbl_second;
        private System.Windows.Forms.Label lbl_hour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.ComboBox cb_minute;
        private System.Windows.Forms.ComboBox cb_hour;
        private System.Windows.Forms.Timer timer_current;
        private System.Windows.Forms.Label lbl_keyhelp;
        private System.Windows.Forms.Label lbl_keyinfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_stopwatch;
        private System.Windows.Forms.Label lbl_countdown;
        private System.Windows.Forms.Button btn_swpause;
        private System.Windows.Forms.Button btn_swreset;
        private System.Windows.Forms.Button btn_swstart;
        private System.Windows.Forms.Timer timer_count;
    }
}

