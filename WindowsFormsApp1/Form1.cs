using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.IO.Ports;
using System.Xml;

// adding Zedgraph
using ZedGraph;

using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class com_box : Form
    {
        public com_box()
        {
            InitializeComponent();
            cb_baudrate.Items.Add(4800);
            cb_baudrate.Items.Add(9600);
            cb_baudrate.Items.Add(19200);
            cb_baudrate.Items.Add(38400);
            cb_baudrate.Items.Add(115200);

            // Initiate Zedgraph
            GraphPane my_pane = chart_zedgraph.GraphPane;
            my_pane.Title.Text = "Motor DC control time chart";
            my_pane.XAxis.Title.Text = "Time(s)";
            my_pane.YAxis.Title.Text = "Speed";
            RollingPointPairList list = new RollingPointPairList(60000);
            RollingPointPairList list1 = new RollingPointPairList(60000);
            RollingPointPairList list2 = new RollingPointPairList(60000);
            LineItem curve = my_pane.AddCurve("Speed", list, Color.Green, SymbolType.None);
            LineItem curve1 = my_pane.AddCurve("Set Speed", list1, Color.Red, SymbolType.None);
            LineItem curve2 = my_pane.AddCurve("Speed1", list2, Color.Blue, SymbolType.None);
            my_pane.XAxis.Scale.Min = 0;
            my_pane.XAxis.Scale.MinorStep = 1;
            my_pane.XAxis.Scale.MajorStep = 1;
            my_pane.YAxis.Scale.Min = -800;
            my_pane.YAxis.Scale.Max = 800;
            my_pane.AxisChange();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int int_len = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lb_status.Text == "Disconnect")
            {
                com.PortName = comport1_box.Text;
                com.BaudRate = Convert.ToInt32(cb_baudrate.Text);
                com.DataBits = 8;
                com.Parity = Parity.None;
                com.Handshake = Handshake.None;
                com.ReadTimeout = 500;
                com.ReceivedBytesThreshold = 4;
                com.Open();
                lb_status.Text = "Connected";
                button2.Text = "disconnect";
            }
            else
            {
                com.Close();
                lb_status.Text = "Disconnect";
                button2.Text = "connect";
            }
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            if (int_len != ports.Length)
            {
                int_len = ports.Length;
                comport1_box.Items.Clear();
                for (int i = 0; i < int_len; i++)
                {
                    comport1_box.Items.Add(ports[i]);
                }
            }
            if (com.IsOpen)
            {
                if (status == true)
                {
                    status = false;
                    draw();// draw on the zedgraph
                }
            }
        }

        private void bt_send_Click(object sender, EventArgs e)
        {
            string str;
            if (lb_status.Text == "Connected")
            {
                str = tbox_send.Text;
                com.WriteLine(str);

            }
        }
        string time_str = "0", data_str = "0";
        string[] time_str_2, data_str_2;
        Int32 data, data1 = 0, data2 = 0, data_max = 0, data_min = 0;
        Int32 time;
        bool status = false;
        private void com_receive(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string[] str = com.ReadLine().Split('\n');
                data_str = str[0];
                data_str_2 = data_str.Split('s');
                data = Int32.Parse(data_str_2[1]);

                str = com.ReadLine().Split('\n');
                data_str = str[0];
                data_str_2 = data_str.Split('s');
                data2 = -Int32.Parse(data_str_2[1]);
                //str = com.ReadExisting();
                //tbox_receive.Text = str;
                str = com.ReadLine().Split('\n');
                time_str = str[0];
                time_str_2 = time_str.Split('t');
                time = Int32.Parse(time_str_2[1]);
                status = true;// note to received data 
                Display(str);
            }
            catch
            {
                return;
            }

        }
        UInt32 num;
        private delegate void DlDisplay(string[] str);
        private void Display(string[] str)
        {
            
            if (tbox_receive.InvokeRequired)
            {
                DlDisplay sd = new DlDisplay(Display);
                tbox_receive.Invoke(sd, new object[] { str });
            }
            else
            {
                tbox_receive.AppendText("This speed right: ");
                tbox_receive.AppendText(data.ToString());
                tbox_receive.AppendText("\n");
                tbox_receive.AppendText("This speed left: ");
                tbox_receive.AppendText(data2.ToString());
                tbox_receive.AppendText("\n");
                tbox_receive.AppendText("This time:  ");
                tbox_receive.AppendText(time.ToString());
                tbox_receive.AppendText("\n");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tbox_setpoint_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void com_box_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bt_send_pid_Click(object sender, EventArgs e)
        {
            // create message notice
            //NotifyIcon notice = new NotifyIcon();
            if (com.IsOpen)
            {
                if (string.IsNullOrEmpty(tbox_setpoint.Text) || string.IsNullOrEmpty(tbox_kp.Text) || string.IsNullOrEmpty(tbox_ki.Text) || string.IsNullOrEmpty(tbox_kd.Text))
                {
                    notifyIcon1.Icon = SystemIcons.Warning;
                    notifyIcon1.BalloonTipText = "some of PID parameters not exist, please check again!";
                    notifyIcon1.BalloonTipTitle = "write comport warning";
                    notifyIcon1.ShowBalloonTip(2000);
                }
                else
                {
                    data1 = Int32.Parse(tbox_setpoint.Text);
                    com.Write(tbox_setpoint.Text);
                    com.Write("|");
                    com.Write(tbox_setpoint_1.Text);
                    com.Write("|");
                    com.Write(tbox_kp.Text);
                    com.Write("|");
                    com.Write(tbox_ki.Text);
                    com.Write("|");
                    com.Write(tbox_kd.Text);
                    com.Write("!");
                }
            }
        }

        private void bt_clearchart_Click(object sender, EventArgs e)
        {

            chart_zedgraph.GraphPane.CurveList.Clear();
            chart_zedgraph.GraphPane.GraphObjList.Clear();

            chart_zedgraph.AxisChange();
            chart_zedgraph.Invalidate();

            // Initiate Zedgraph
            GraphPane my_pane = chart_zedgraph.GraphPane;
            my_pane.Title.Text = "Motor DC control time chart";
            my_pane.XAxis.Title.Text = "Time(s)";
            my_pane.YAxis.Title.Text = "Speed";
            RollingPointPairList list = new RollingPointPairList(60000);
            RollingPointPairList list1 = new RollingPointPairList(60000);
            RollingPointPairList list2 = new RollingPointPairList(60000);
            LineItem curve = my_pane.AddCurve("Speed", list, Color.Green, SymbolType.None);
            LineItem curve1 = my_pane.AddCurve("Set Speed", list1, Color.Red, SymbolType.None);
            LineItem curve2 = my_pane.AddCurve("Speed 1", list2, Color.Blue, SymbolType.None);
            my_pane.XAxis.Scale.Min = 0;
            my_pane.XAxis.Scale.MinorStep = 1;
            my_pane.XAxis.Scale.MajorStep = 1;
            my_pane.YAxis.Scale.Min = -800;
            my_pane.YAxis.Scale.Max = 800;
            my_pane.AxisChange();

            data_min = 0;
            data_max = 0;
        }

        private void bt_modechart_Click(object sender, EventArgs e)
        {
            if (bt_modechart.Text == "Sroll")
                bt_modechart.Text = "Compact";
            else if (bt_modechart.Text == "Compact")
                bt_modechart.Text = "Sroll";
        }

        private void lb_status_Click(object sender, EventArgs e)
        {

        }

        private void draw()
        {
            if (chart_zedgraph.GraphPane.CurveList.Count <= 0)
                return;
            LineItem curve = chart_zedgraph.GraphPane.CurveList[0] as LineItem;
            LineItem curve1 = chart_zedgraph.GraphPane.CurveList[1] as LineItem;
            LineItem curve2 = chart_zedgraph.GraphPane.CurveList[2] as LineItem;
            if (curve == null || curve1 == null || curve2 == null)
                return;
            IPointListEdit list = curve.Points as IPointListEdit;
            IPointListEdit list1 = curve1.Points as IPointListEdit;
            IPointListEdit list2 = curve2.Points as IPointListEdit;
            if (list == null || list1 == null || list2 == null)
                return;
            list.Add(time, data);
            list1.Add(time, data1);
            list2.Add(time, data2);

            Scale Xscale = chart_zedgraph.GraphPane.XAxis.Scale;
            Scale Yscale = chart_zedgraph.GraphPane.YAxis.Scale;

            // Auto Scale X axis
            if (time > Xscale.Max - Xscale.MajorStep)
            {
                Xscale.Max = time + Xscale.MajorStep;
                if (bt_modechart.Text == "Sroll")
                {
                    Xscale.Min = 0;
                }
                if(bt_modechart.Text == "Compact")
                {
                    Xscale.Min = Xscale.Max - 30;
                }
            }


            //Auto scale scale Y axis
            if (data > 0 && data > data_max)
            {
                data_max = data;
            }
            else if(data < 0 && data < data_min)
            {
                data_min = data;
            }
            Yscale.Max = data_max + 50;
            Yscale.Min = data_min - 50;

            chart_zedgraph.AxisChange();

            chart_zedgraph.Invalidate();

            chart_zedgraph.Refresh();
        }
    }
}
