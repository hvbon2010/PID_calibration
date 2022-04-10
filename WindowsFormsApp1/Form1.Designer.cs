namespace WindowsFormsApp1
{
    partial class com_box
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
            this.com_lable = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.com = new System.IO.Ports.SerialPort(this.components);
            this.bt_send = new System.Windows.Forms.Button();
            this.tbox_send = new System.Windows.Forms.TextBox();
            this.tbox_receive = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart_zedgraph = new ZedGraph.ZedGraphControl();
            this.button2 = new System.Windows.Forms.Button();
            this.lb_status = new System.Windows.Forms.Label();
            this.comport1_box = new System.Windows.Forms.ComboBox();
            this.cb_baudrate = new System.Windows.Forms.ComboBox();
            this.lb_baudrate = new System.Windows.Forms.Label();
            this.lb_comport = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbox_setpoint = new System.Windows.Forms.TextBox();
            this.tbox_kp = new System.Windows.Forms.TextBox();
            this.tbox_ki = new System.Windows.Forms.TextBox();
            this.tbox_kd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_send_pid = new System.Windows.Forms.Button();
            this.bt_modechart = new System.Windows.Forms.Button();
            this.bt_clearchart = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tbox_setpoint_1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // com_lable
            // 
            this.com_lable.AutoSize = true;
            this.com_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_lable.Location = new System.Drawing.Point(38, 2);
            this.com_lable.Name = "com_lable";
            this.com_lable.Size = new System.Drawing.Size(76, 18);
            this.com_lable.TabIndex = 1;
            this.com_lable.Text = "com port";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // com
            // 
            this.com.ReceivedBytesThreshold = 8;
            this.com.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.com_receive);
            // 
            // bt_send
            // 
            this.bt_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_send.Location = new System.Drawing.Point(9, 43);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(75, 27);
            this.bt_send.TabIndex = 4;
            this.bt_send.Text = "send";
            this.bt_send.UseVisualStyleBackColor = true;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // tbox_send
            // 
            this.tbox_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_send.Location = new System.Drawing.Point(9, 10);
            this.tbox_send.Name = "tbox_send";
            this.tbox_send.Size = new System.Drawing.Size(218, 22);
            this.tbox_send.TabIndex = 5;
            // 
            // tbox_receive
            // 
            this.tbox_receive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_receive.Location = new System.Drawing.Point(9, 12);
            this.tbox_receive.Multiline = true;
            this.tbox_receive.Name = "tbox_receive";
            this.tbox_receive.Size = new System.Drawing.Size(213, 64);
            this.tbox_receive.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Receive";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbox_receive);
            this.groupBox3.Location = new System.Drawing.Point(8, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 89);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbox_send);
            this.groupBox1.Controls.Add(this.bt_send);
            this.groupBox1.Location = new System.Drawing.Point(8, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 76);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // chart_zedgraph
            // 
            this.chart_zedgraph.Location = new System.Drawing.Point(277, 14);
            this.chart_zedgraph.Name = "chart_zedgraph";
            this.chart_zedgraph.ScrollGrace = 0D;
            this.chart_zedgraph.ScrollMaxX = 0D;
            this.chart_zedgraph.ScrollMaxY = 0D;
            this.chart_zedgraph.ScrollMaxY2 = 0D;
            this.chart_zedgraph.ScrollMinX = 0D;
            this.chart_zedgraph.ScrollMinY = 0D;
            this.chart_zedgraph.ScrollMinY2 = 0D;
            this.chart_zedgraph.Size = new System.Drawing.Size(924, 437);
            this.chart_zedgraph.TabIndex = 12;
            this.chart_zedgraph.UseExtendedPrintDialog = true;
            this.chart_zedgraph.Load += new System.EventHandler(this.Form1_Load);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(10, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 32);
            this.button2.TabIndex = 0;
            this.button2.Text = "connect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.ForeColor = System.Drawing.Color.Red;
            this.lb_status.Location = new System.Drawing.Point(78, -4);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(93, 18);
            this.lb_status.TabIndex = 2;
            this.lb_status.Text = "Disconnect";
            this.lb_status.Click += new System.EventHandler(this.lb_status_Click);
            // 
            // comport1_box
            // 
            this.comport1_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comport1_box.FormattingEnabled = true;
            this.comport1_box.Location = new System.Drawing.Point(10, 35);
            this.comport1_box.Name = "comport1_box";
            this.comport1_box.Size = new System.Drawing.Size(121, 24);
            this.comport1_box.TabIndex = 3;
            // 
            // cb_baudrate
            // 
            this.cb_baudrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_baudrate.FormattingEnabled = true;
            this.cb_baudrate.Location = new System.Drawing.Point(157, 35);
            this.cb_baudrate.Name = "cb_baudrate";
            this.cb_baudrate.Size = new System.Drawing.Size(82, 24);
            this.cb_baudrate.TabIndex = 12;
            // 
            // lb_baudrate
            // 
            this.lb_baudrate.AutoSize = true;
            this.lb_baudrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_baudrate.Location = new System.Drawing.Point(170, 59);
            this.lb_baudrate.Name = "lb_baudrate";
            this.lb_baudrate.Size = new System.Drawing.Size(60, 15);
            this.lb_baudrate.TabIndex = 13;
            this.lb_baudrate.Text = "Baud rate";
            // 
            // lb_comport
            // 
            this.lb_comport.AutoSize = true;
            this.lb_comport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_comport.Location = new System.Drawing.Point(41, 59);
            this.lb_comport.Name = "lb_comport";
            this.lb_comport.Size = new System.Drawing.Size(60, 16);
            this.lb_comport.TabIndex = 12;
            this.lb_comport.Text = "com port";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_comport);
            this.groupBox2.Controls.Add(this.lb_baudrate);
            this.groupBox2.Controls.Add(this.cb_baudrate);
            this.groupBox2.Controls.Add(this.comport1_box);
            this.groupBox2.Controls.Add(this.lb_status);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(5, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 126);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // tbox_setpoint
            // 
            this.tbox_setpoint.Location = new System.Drawing.Point(145, 333);
            this.tbox_setpoint.Name = "tbox_setpoint";
            this.tbox_setpoint.Size = new System.Drawing.Size(107, 22);
            this.tbox_setpoint.TabIndex = 13;
            // 
            // tbox_kp
            // 
            this.tbox_kp.Location = new System.Drawing.Point(12, 380);
            this.tbox_kp.Name = "tbox_kp";
            this.tbox_kp.Size = new System.Drawing.Size(71, 22);
            this.tbox_kp.TabIndex = 14;
            // 
            // tbox_ki
            // 
            this.tbox_ki.Location = new System.Drawing.Point(100, 379);
            this.tbox_ki.Name = "tbox_ki";
            this.tbox_ki.Size = new System.Drawing.Size(66, 22);
            this.tbox_ki.TabIndex = 15;
            // 
            // tbox_kd
            // 
            this.tbox_kd.Location = new System.Drawing.Point(186, 379);
            this.tbox_kd.Name = "tbox_kd";
            this.tbox_kd.Size = new System.Drawing.Size(66, 22);
            this.tbox_kd.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "set point right";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Kp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Ki";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Kd";
            // 
            // bt_send_pid
            // 
            this.bt_send_pid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_send_pid.Location = new System.Drawing.Point(91, 428);
            this.bt_send_pid.Name = "bt_send_pid";
            this.bt_send_pid.Size = new System.Drawing.Size(85, 23);
            this.bt_send_pid.TabIndex = 21;
            this.bt_send_pid.Text = "send";
            this.bt_send_pid.UseVisualStyleBackColor = true;
            this.bt_send_pid.Click += new System.EventHandler(this.bt_send_pid_Click);
            // 
            // bt_modechart
            // 
            this.bt_modechart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_modechart.Location = new System.Drawing.Point(404, 468);
            this.bt_modechart.Name = "bt_modechart";
            this.bt_modechart.Size = new System.Drawing.Size(90, 23);
            this.bt_modechart.TabIndex = 22;
            this.bt_modechart.Text = "Sroll";
            this.bt_modechart.UseVisualStyleBackColor = true;
            this.bt_modechart.Click += new System.EventHandler(this.bt_modechart_Click);
            // 
            // bt_clearchart
            // 
            this.bt_clearchart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_clearchart.Location = new System.Drawing.Point(277, 468);
            this.bt_clearchart.Name = "bt_clearchart";
            this.bt_clearchart.Size = new System.Drawing.Size(106, 23);
            this.bt_clearchart.TabIndex = 23;
            this.bt_clearchart.Text = "Clear chart";
            this.bt_clearchart.UseVisualStyleBackColor = true;
            this.bt_clearchart.Click += new System.EventHandler(this.bt_clearchart_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // tbox_setpoint_1
            // 
            this.tbox_setpoint_1.Location = new System.Drawing.Point(17, 333);
            this.tbox_setpoint_1.Name = "tbox_setpoint_1";
            this.tbox_setpoint_1.Size = new System.Drawing.Size(100, 22);
            this.tbox_setpoint_1.TabIndex = 24;
            this.tbox_setpoint_1.TextChanged += new System.EventHandler(this.tbox_setpoint_1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "set point left";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // com_box
            // 
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1232, 548);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbox_setpoint_1);
            this.Controls.Add(this.bt_clearchart);
            this.Controls.Add(this.bt_modechart);
            this.Controls.Add(this.bt_send_pid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbox_kd);
            this.Controls.Add(this.tbox_ki);
            this.Controls.Add(this.tbox_kp);
            this.Controls.Add(this.tbox_setpoint);
            this.Controls.Add(this.chart_zedgraph);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.com_lable);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "com_box";
            this.Load += new System.EventHandler(this.com_box_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_connect;
        private System.Windows.Forms.ComboBox comport_box;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label connect_status;
        private System.Windows.Forms.Label select_lable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label com_lable;
        private System.Windows.Forms.Timer timer2;
        private System.IO.Ports.SerialPort com;
        private System.Windows.Forms.Button bt_send;
        private System.Windows.Forms.TextBox tbox_send;
        private System.Windows.Forms.TextBox tbox_receive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private ZedGraph.ZedGraphControl chart_zedgraph;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.ComboBox comport1_box;
        private System.Windows.Forms.ComboBox cb_baudrate;
        private System.Windows.Forms.Label lb_baudrate;
        private System.Windows.Forms.Label lb_comport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbox_setpoint;
        private System.Windows.Forms.TextBox tbox_kp;
        private System.Windows.Forms.TextBox tbox_ki;
        private System.Windows.Forms.TextBox tbox_kd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_send_pid;
        private System.Windows.Forms.Button bt_modechart;
        private System.Windows.Forms.Button bt_clearchart;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox tbox_setpoint_1;
        private System.Windows.Forms.Label label8;
    }
}

