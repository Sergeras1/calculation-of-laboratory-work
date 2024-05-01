using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel.Com2Interop;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace РасчетПрактических
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;

            textBox21.Visible = false;
            textBox22.Visible = false;
            textBox23.Visible = false;
            textBox24.Visible = false;
            textBox25.Visible = false;
            textBox26.Visible = false;
            textBox27.Visible = false;
            textBox28.Visible = false;
            textBox29.Visible = false;
            textBox30.Visible = false;
            textBox31.Visible = false;
            textBox32.Visible = false;
            textBox33.Visible = false;
            textBox34.Visible = false;
            textBox35.Visible = false;
            textBox36.Visible = false;
            textBox37.Visible = false;
            textBox38.Visible = false;
            textBox39.Visible = false;
            textBox40.Visible = false;
            textBox41.Visible = false;
            textBox42.Visible = false;
            textBox43.Visible = false;
            textBox44.Visible = false;
            textBox45.Visible = false;
            textBox46.Visible = false;
            textBox47.Visible = false;
            textBox48.Visible = false;
            textBox49.Visible = false;
            textBox50.Visible = false;
            textBox51.Visible = false;
            textBox52.Visible = false;
            textBox53.Visible = false;
            textBox54.Visible = false;
            textBox55.Visible = false;
            textBox56.Visible = false;
            textBox57.Visible = false;
            textBox58.Visible = false;
            textBox59.Visible = false;
            textBox60.Visible = false;
            textBox61.Visible = false;
            textBox62.Visible = false;
            textBox63.Visible = false;
            textBox64.Visible = false;
            textBox65.Visible = false;
            textBox66.Visible = false;
            textBox67.Visible = false;
            textBox68.Visible = false;
            textBox69.Visible = false;
            textBox70.Visible = false;
            textBox71.Visible = false;
            textBox72.Visible = false;
            textBox73.Visible = false;
            textBox74.Visible = false;
            textBox75.Visible = false;
            textBox76.Visible = false;
            textBox77.Visible = false;
            textBox78.Visible = false;
            textBox79.Visible = false;
            textBox80.Visible = false;
            textBox81.Visible = false;
            textBox82.Visible = false;
            textBox83.Visible = false;
            textBox84.Visible = false;
            textBox85.Visible = false;
            textBox86.Visible = false;
            textBox87.Visible = false;
            textBox88.Visible = false;
            textBox89.Visible = false;
            textBox90.Visible = false;
            textBox91.Visible = false;
            textBox92.Visible = false;
            textBox93.Visible = false;
            textBox94.Visible = false;
            textBox95.Visible = false;
            textBox96.Visible = false;
            textBox97.Visible = false;
            textBox98.Visible = false;
            textBox99.Visible = false;
            textBox100.Visible = false;
            textBox101.Visible = false;
            textBox102.Visible = false;
            textBox103.Visible = false;
            textBox104.Visible = false;
            textBox105.Visible = false;
            textBox106.Visible = false;
            textBox107.Visible = false;
            textBox108.Visible = false;
            textBox109.Visible = false;
            textBox110.Visible = false;
            chart1.Visible = false;
            chart2.Visible = false;
            chart3.Visible = false;
            chart4.Visible = false;
            chart5.Visible = false;
            chart6.Visible = false;
            chart7.Visible = false;
            chart8.Visible = false;

            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7" });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        string index;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = comboBox1.Text;

            if (index == "7")
            { 
                label1.Text = "U2";
                label2.Text = "Iн";
                label13.Visible = false;
                label12.Visible = false;
                textBox111.Visible = false;
                textBox112.Visible = false;
            } 
            else 
            { 
                label1.Text = "Uo";
                label2.Text = "Po";
                label13.Visible = true;
                label12.Visible = true;
                textBox111.Visible = true;
                textBox112.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Idop;
            double Uobr;

            double t1_1;
            double t1_2;
            double t1_3;
            double t1_4;
            double t1_5;
            double t1_6;
            double t1_7;
            double t1_8;
            double t1_9;
            double t1_10;

            double t2_1;
            double t2_2;
            double t2_3;
            double t2_4;
            double t2_5;
            double t2_6;
            double t2_7;
            double t2_8;
            double t2_9;
            double t2_10;

            double t3_1;
            double t3_2;
            double t3_3;
            double t3_4;
            double t3_5;
            double t3_6;
            double t3_7;
            double t3_8;
            double t3_9;
            double t3_10;

            double t4_1;
            double t4_2;
            double t4_3;
            double t4_4;
            double t4_5;
            double t4_6;
            double t4_7;
            double t4_8;
            double t4_9;
            double t4_10;

            double t5_1;
            double t5_2;
            double t5_3;
            double t5_4;
            double t5_5;
            double t5_6;
            double t5_7;
            double t5_8;
            double t5_9;
            double t5_10;

            double t6_1;
            double t6_2;
            double t6_3;
            double t6_4;
            double t6_5;
            double t6_6;
            double t6_7;
            double t6_8;
            double t6_9;
            double t6_10;

            double t7_1;
            double t7_2;
            double t7_3;
            double t7_4;
            double t7_5;
            double t7_6;
            double t7_7;
            double t7_8;
            double t7_9;
            double t7_10;

            double t8_1;
            double t8_2;
            double t8_3;
            double t8_4;
            double t8_5;
            double t8_6;
            double t8_7;
            double t8_8;
            double t8_9;
            double t8_10;

            double t9_1;
            double t9_2;
            double t9_3;
            double t9_4;
            double t9_5;
            double t9_6;
            double t9_7;
            double t9_8;
            double t9_9;
            double t9_10;

            double t10_1;
            double t10_2;
            double t10_3;
            double t10_4;
            double t10_5;
            double t10_6;
            double t10_7;
            double t10_8;
            double t10_9;
            double t10_10;

            double t11_1;
            double t11_2;
            double t11_3;
            double t11_4;
            double t11_5;
            double t11_6;
            double t11_7;
            double t11_8;
            double t11_9;
            double t11_10;

            double t12_1;
            double t12_2;
            double t12_3;
            double t12_4;
            double t12_5;
            double t12_6;
            double t12_7;
            double t12_8;
            double t12_9;
            double t12_10;


            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show(@" ОШИБКА: Выберите номер работы.");
            }

            if (index == "1")
            {
                label3.Text = "Io";
                label4.Text = "Uв";
                label5.Text = "R";
                label6.Text = "N посл.";
                label7.Text = "N пар.";

                Idop = Convert.ToDouble(textBox111.Text);
                Uobr = Convert.ToDouble(textBox112.Text);

                t1_1 = Convert.ToDouble(textBox1.Text);
                t1_2 = Convert.ToDouble(textBox2.Text);
                t1_3 = Convert.ToDouble(textBox3.Text);
                t1_4 = Convert.ToDouble(textBox4.Text);
                t1_5 = Convert.ToDouble(textBox5.Text);
                t1_6 = Convert.ToDouble(textBox6.Text);
                t1_7 = Convert.ToDouble(textBox7.Text);
                t1_8 = Convert.ToDouble(textBox8.Text);
                t1_9 = Convert.ToDouble(textBox9.Text);
                t1_10 = Convert.ToDouble(textBox10.Text);

                t2_1 = Convert.ToDouble(textBox11.Text);
                t2_2 = Convert.ToDouble(textBox12.Text);
                t2_3 = Convert.ToDouble(textBox13.Text);
                t2_4 = Convert.ToDouble(textBox14.Text);
                t2_5 = Convert.ToDouble(textBox15.Text);
                t2_6 = Convert.ToDouble(textBox16.Text);
                t2_7 = Convert.ToDouble(textBox17.Text);
                t2_8 = Convert.ToDouble(textBox18.Text);
                t2_9 = Convert.ToDouble(textBox19.Text);
                t2_10 = Convert.ToDouble(textBox20.Text);

                t3_1 = t2_1 / t1_1;
                t3_2 = t2_2 / t1_2;
                t3_3 = t2_3 / t1_3;
                t3_4 = t2_4 / t1_4;
                t3_5 = t2_5 / t1_5;
                t3_6 = t2_6 / t1_6;
                t3_7 = t2_7 / t1_7;
                t3_8 = t2_8 / t1_8;
                t3_9 = t2_9 / t1_9;
                t3_10 = t2_10 / t1_10;

                textBox21.Text = t3_1.ToString("0.##");
                textBox22.Text = t3_2.ToString("0.##");
                textBox23.Text = t3_3.ToString("0.##");
                textBox24.Text = t3_4.ToString("0.##");
                textBox25.Text = t3_5.ToString("0.##");
                textBox26.Text = t3_6.ToString("0.##");
                textBox27.Text = t3_7.ToString("0.##");
                textBox28.Text = t3_8.ToString("0.##");
                textBox29.Text = t3_9.ToString("0.##");
                textBox30.Text = t3_10.ToString("0.##");

                t4_1 = 3.14 * t1_1;
                t4_2 = 3.14 * t1_2;
                t4_3 = 3.14 * t1_3;
                t4_4 = 3.14 * t1_4;
                t4_5 = 3.14 * t1_5;
                t4_6 = 3.14 * t1_6;
                t4_7 = 3.14 * t1_7;
                t4_8 = 3.14 * t1_8;
                t4_9 = 3.14 * t1_9;
                t4_10 = 3.14 * t1_10;

                textBox31.Text = t4_1.ToString("0.##");
                textBox32.Text = t4_2.ToString("0.##");
                textBox33.Text = t4_3.ToString("0.##");
                textBox34.Text = t4_4.ToString("0.##");
                textBox35.Text = t4_5.ToString("0.##");
                textBox36.Text = t4_6.ToString("0.##");
                textBox37.Text = t4_7.ToString("0.##");
                textBox38.Text = t4_8.ToString("0.##");
                textBox39.Text = t4_9.ToString("0.##");
                textBox40.Text = t4_10.ToString("0.##");

                t5_1 = t1_1 / t3_1;
                t5_2 = t1_2 / t3_2;
                t5_3 = t1_3 / t3_3;
                t5_4 = t1_4 / t3_4;
                t5_5 = t1_5 / t3_5;
                t5_6 = t1_6 / t3_6;
                t5_7 = t1_7 / t3_7;
                t5_8 = t1_8 / t3_8;
                t5_9 = t1_9 / t3_9;
                t5_10 = t1_10 / t3_10;

                textBox41.Text = t5_1.ToString("0.##");
                textBox42.Text = t5_2.ToString("0.##");
                textBox43.Text = t5_3.ToString("0.##");
                textBox44.Text = t5_4.ToString("0.##");
                textBox45.Text = t5_5.ToString("0.##");
                textBox46.Text = t5_6.ToString("0.##");
                textBox47.Text = t5_7.ToString("0.##");
                textBox48.Text = t5_8.ToString("0.##");
                textBox49.Text = t5_9.ToString("0.##");
                textBox50.Text = t5_10.ToString("0.##");

                t6_1 = t4_1 / Uobr;
                int T6_1 = Convert.ToInt32(Math.Ceiling(t6_1));
                t6_2 = t4_2 / Uobr;
                int T6_2 = Convert.ToInt32(Math.Ceiling(t6_2));
                t6_3 = t4_3 / Uobr;
                int T6_3 = Convert.ToInt32(Math.Ceiling(t6_3));
                t6_4 = t4_4 / Uobr;
                int T6_4 = Convert.ToInt32(Math.Ceiling(t6_4));
                t6_5 = t4_5 / Uobr;
                int T6_5 = Convert.ToInt32(Math.Ceiling(t6_5));
                t6_6 = t4_6 / Uobr;
                int T6_6 = Convert.ToInt32(Math.Ceiling(t6_6));
                t6_7 = t4_7 / Uobr;
                int T6_7 = Convert.ToInt32(Math.Ceiling(t6_7));
                t6_8 = t4_8 / Uobr;
                int T6_8 = Convert.ToInt32(Math.Ceiling(t6_8));
                t6_9 = t4_9 / Uobr;
                int T6_9 = Convert.ToInt32(Math.Ceiling(t6_9));
                t6_10 = t4_10 / Uobr;
                int T6_10 = Convert.ToInt32(Math.Ceiling(t6_10));

                textBox51.Text = T6_1.ToString("0.##");
                textBox52.Text = T6_2.ToString("0.##");
                textBox53.Text = T6_3.ToString("0.##");
                textBox54.Text = T6_4.ToString("0.##");
                textBox55.Text = T6_5.ToString("0.##");
                textBox56.Text = T6_6.ToString("0.##");
                textBox57.Text = T6_7.ToString("0.##");
                textBox58.Text = T6_8.ToString("0.##");
                textBox59.Text = T6_9.ToString("0.##");
                textBox60.Text = T6_10.ToString("0.##");

                t7_1 = t3_1 / Idop;
                int T7_1 = Convert.ToInt32(Math.Ceiling(t7_1));
                t7_2 = t3_2 / Idop;
                int T7_2 = Convert.ToInt32(Math.Ceiling(t7_2));
                t7_3 = t3_3 / Idop;
                int T7_3 = Convert.ToInt32(Math.Ceiling(t7_3));
                t7_4 = t3_4 / Idop;
                int T7_4 = Convert.ToInt32(Math.Ceiling(t7_4));
                t7_5 = t3_5 / Idop;
                int T7_5 = Convert.ToInt32(Math.Ceiling(t7_5));
                t7_6 = t3_6 / Idop;
                int T7_6 = Convert.ToInt32(Math.Ceiling(t7_6));
                t7_7 = t3_7 / Idop;
                int T7_7 = Convert.ToInt32(Math.Ceiling(t7_7));
                t7_8 = t3_8 / Idop;
                int T7_8 = Convert.ToInt32(Math.Ceiling(t7_8));
                t7_9 = t3_9 / Idop;
                int T7_9 = Convert.ToInt32(Math.Ceiling(t7_9));
                t7_10 = t3_10 / Idop;
                int T7_10 = Convert.ToInt32(Math.Ceiling(t7_10));

                textBox61.Text = T7_1.ToString("0.##");
                textBox62.Text = T7_2.ToString("0.##");
                textBox63.Text = T7_3.ToString("0.##");
                textBox64.Text = T7_4.ToString("0.##");
                textBox65.Text = T7_5.ToString("0.##");
                textBox66.Text = T7_6.ToString("0.##");
                textBox67.Text = T7_7.ToString("0.##");
                textBox68.Text = T7_8.ToString("0.##");
                textBox69.Text = T7_9.ToString("0.##");
                textBox70.Text = T7_10.ToString("0.##");

                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                textBox21.Visible = true;
                textBox22.Visible = true;
                textBox23.Visible = true;
                textBox24.Visible = true;
                textBox25.Visible = true;
                textBox26.Visible = true;
                textBox27.Visible = true;
                textBox28.Visible = true;
                textBox29.Visible = true;
                textBox30.Visible = true;
                textBox31.Visible = true;
                textBox32.Visible = true;
                textBox33.Visible = true;
                textBox34.Visible = true;
                textBox35.Visible = true;
                textBox36.Visible = true;
                textBox37.Visible = true;
                textBox38.Visible = true;
                textBox39.Visible = true;
                textBox40.Visible = true;
                textBox41.Visible = true;
                textBox42.Visible = true;
                textBox43.Visible = true;
                textBox44.Visible = true;
                textBox45.Visible = true;
                textBox46.Visible = true;
                textBox47.Visible = true;
                textBox48.Visible = true;
                textBox49.Visible = true;
                textBox50.Visible = true;
                textBox51.Visible = true;
                textBox52.Visible = true;
                textBox53.Visible = true;
                textBox54.Visible = true;
                textBox55.Visible = true;
                textBox56.Visible = true;
                textBox57.Visible = true;
                textBox58.Visible = true;
                textBox59.Visible = true;
                textBox60.Visible = true;
                textBox61.Visible = true;
                textBox62.Visible = true;
                textBox63.Visible = true;
                textBox64.Visible = true;
                textBox65.Visible = true;
                textBox66.Visible = true;
                textBox67.Visible = true;
                textBox68.Visible = true;
                textBox69.Visible = true;
                textBox70.Visible = true;
                textBox71.Visible = false;
                textBox72.Visible = false;
                textBox73.Visible = false;
                textBox74.Visible = false;
                textBox75.Visible = false;
                textBox76.Visible = false;
                textBox77.Visible = false;
                textBox78.Visible = false;
                textBox79.Visible = false;
                textBox80.Visible = false;
                textBox81.Visible = false;
                textBox82.Visible = false;
                textBox83.Visible = false;
                textBox84.Visible = false;
                textBox85.Visible = false;
                textBox86.Visible = false;
                textBox87.Visible = false;
                textBox88.Visible = false;
                textBox89.Visible = false;
                textBox90.Visible = false;
                textBox91.Visible = false;
                textBox92.Visible = false;
                textBox93.Visible = false;
                textBox94.Visible = false;
                textBox95.Visible = false;
                textBox96.Visible = false;
                textBox97.Visible = false;
                textBox98.Visible = false;
                textBox99.Visible = false;
                textBox100.Visible = false;
                textBox101.Visible = false;
                textBox102.Visible = false;
                textBox103.Visible = false;
                textBox104.Visible = false;
                textBox105.Visible = false;
                textBox106.Visible = false;
                textBox107.Visible = false;
                textBox108.Visible = false;
                textBox109.Visible = false;
                textBox110.Visible = false;
                chart1.Visible = true;
                chart2.Visible = true;
                chart3.Visible = true;
                chart4.Visible = false;
                chart5.Visible = true;
                chart6.Visible = true;
                chart7.Visible = true;
                chart8.Visible = false;

                double aaa, bbb, hhh, xxx, max2, max3, max4, max5, MAX2, MAX3, MAX4, MAX5;
                aaa = 0.01;
                bbb = 0.01;
                hhh = 0.01;
                xxx = aaa;
                this.chart1.Series[0].Points.Clear();
                this.chart2.Series[0].Points.Clear();
                this.chart3.Series[0].Points.Clear();
                this.chart5.Series[0].Points.Clear();
                this.chart6.Series[0].Points.Clear();
                this.chart7.Series[0].Points.Clear();
                this.chart1.ChartAreas[0].AxisX.Title = "Po(Uв)";
                this.chart2.ChartAreas[0].AxisX.Title = "Po(Io)";
                this.chart3.ChartAreas[0].AxisX.Title = "Po(R)";
                this.chart5.ChartAreas[0].AxisX.Title = "Io(Uв)";
                this.chart6.ChartAreas[0].AxisX.Title = "Io(R)";
                this.chart7.ChartAreas[0].AxisX.Title = "Uв(R)";

                max2 = Math.Max(Math.Max(Math.Max(Math.Max(t2_1, t2_2), Math.Max(t2_3, t2_4)), Math.Max(Math.Max(t2_5, t2_6), Math.Max(t2_7, t2_8))), Math.Max(t2_9, t2_10));
                max3 = Math.Max(Math.Max(Math.Max(Math.Max(t3_1, t3_2), Math.Max(t3_3, t3_4)), Math.Max(Math.Max(t3_5, t3_6), Math.Max(t3_7, t3_8))), Math.Max(t3_9, t3_10));
                max4 = Math.Max(Math.Max(Math.Max(Math.Max(t4_1, t4_2), Math.Max(t4_3, t4_4)), Math.Max(Math.Max(t4_5, t4_6), Math.Max(t4_7, t4_8))), Math.Max(t4_9, t4_10));
                max5 = Math.Max(Math.Max(Math.Max(Math.Max(t5_1, t5_2), Math.Max(t5_3, t5_4)), Math.Max(Math.Max(t5_5, t5_6), Math.Max(t5_7, t5_8))), Math.Max(t5_9, t5_10));

                MAX2 = ((int)((max2 + 150) / 100)) * 100;
                MAX3 = ((int)((max3 + 10) / 10)) * 10;
                MAX4 = ((int)((max4 + 150) / 100)) * 100;
                MAX5 = ((int)((max5 + 20) / 10)) * 10;

                while (xxx <= bbb)
                {
                    this.chart1.ChartAreas[0].AxisX.Minimum = 0; // X - Uв    Y - Po
                    this.chart1.ChartAreas[0].AxisX.Maximum = MAX4;
                    this.chart1.ChartAreas[0].AxisX.Interval = MAX4 / 5;
                    this.chart1.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart1.ChartAreas[0].AxisY.Maximum = MAX2;
                    this.chart1.ChartAreas[0].AxisY.Interval = MAX2 / 5;
                    this.chart1.Series[0].Points.AddXY(t4_1, t2_1);
                    this.chart1.Series[0].Points.AddXY(t4_2, t2_2);
                    this.chart1.Series[0].Points.AddXY(t4_3, t2_3);
                    this.chart1.Series[0].Points.AddXY(t4_4, t2_4);
                    this.chart1.Series[0].Points.AddXY(t4_5, t2_5);
                    this.chart1.Series[0].Points.AddXY(t4_6, t2_6);
                    this.chart1.Series[0].Points.AddXY(t4_7, t2_7);
                    this.chart1.Series[0].Points.AddXY(t4_8, t2_8);
                    this.chart1.Series[0].Points.AddXY(t4_9, t2_9);
                    this.chart1.Series[0].Points.AddXY(t4_10, t2_10);

                    this.chart2.ChartAreas[0].AxisX.Minimum = 0; // X - Io    Y - Po
                    this.chart2.ChartAreas[0].AxisX.Maximum = MAX3;
                    this.chart2.ChartAreas[0].AxisX.Interval = MAX3 / 5;
                    this.chart2.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart2.ChartAreas[0].AxisY.Maximum = MAX2;
                    this.chart2.ChartAreas[0].AxisY.Interval = MAX2 / 5;
                    this.chart2.Series[0].Points.AddXY(t3_1, t2_1);
                    this.chart2.Series[0].Points.AddXY(t3_2, t2_2);
                    this.chart2.Series[0].Points.AddXY(t3_3, t2_3);
                    this.chart2.Series[0].Points.AddXY(t3_4, t2_4);
                    this.chart2.Series[0].Points.AddXY(t3_5, t2_5);
                    this.chart2.Series[0].Points.AddXY(t3_6, t2_6);
                    this.chart2.Series[0].Points.AddXY(t3_7, t2_7);
                    this.chart2.Series[0].Points.AddXY(t3_8, t2_8);
                    this.chart2.Series[0].Points.AddXY(t3_9, t2_9);
                    this.chart2.Series[0].Points.AddXY(t3_10, t2_10);

                    this.chart3.ChartAreas[0].AxisX.Minimum = 0; // X - R    Y - Po
                    this.chart3.ChartAreas[0].AxisX.Maximum = MAX5;
                    this.chart3.ChartAreas[0].AxisX.Interval = MAX5 / 5;
                    this.chart3.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart3.ChartAreas[0].AxisY.Maximum = MAX2;
                    this.chart3.ChartAreas[0].AxisY.Interval = MAX2 / 5;
                    this.chart3.Series[0].Points.AddXY(t5_1, t2_1);
                    this.chart3.Series[0].Points.AddXY(t5_2, t2_2);
                    this.chart3.Series[0].Points.AddXY(t5_3, t2_3);
                    this.chart3.Series[0].Points.AddXY(t5_4, t2_4);
                    this.chart3.Series[0].Points.AddXY(t5_5, t2_5);
                    this.chart3.Series[0].Points.AddXY(t5_6, t2_6);
                    this.chart3.Series[0].Points.AddXY(t5_7, t2_7);
                    this.chart3.Series[0].Points.AddXY(t5_8, t2_8);
                    this.chart3.Series[0].Points.AddXY(t5_9, t2_9);
                    this.chart3.Series[0].Points.AddXY(t5_10, t2_10);

                    this.chart5.ChartAreas[0].AxisX.Minimum = 0; // X - Uв    Y - Io
                    this.chart5.ChartAreas[0].AxisX.Maximum = MAX4;
                    this.chart5.ChartAreas[0].AxisX.Interval = MAX4 / 5;
                    this.chart5.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart5.ChartAreas[0].AxisY.Maximum = MAX3;
                    this.chart5.ChartAreas[0].AxisY.Interval = MAX3 / 5;
                    this.chart5.Series[0].Points.AddXY(t4_1, t3_1);
                    this.chart5.Series[0].Points.AddXY(t4_2, t3_2);
                    this.chart5.Series[0].Points.AddXY(t4_3, t3_3);
                    this.chart5.Series[0].Points.AddXY(t4_4, t3_4);
                    this.chart5.Series[0].Points.AddXY(t4_5, t3_5);
                    this.chart5.Series[0].Points.AddXY(t4_6, t3_6);
                    this.chart5.Series[0].Points.AddXY(t4_7, t3_7);
                    this.chart5.Series[0].Points.AddXY(t4_8, t3_8);
                    this.chart5.Series[0].Points.AddXY(t4_9, t3_9);
                    this.chart5.Series[0].Points.AddXY(t4_10, t3_10);

                    this.chart6.ChartAreas[0].AxisX.Minimum = 0; // X - R    Y - Io
                    this.chart6.ChartAreas[0].AxisX.Maximum = MAX5;
                    this.chart6.ChartAreas[0].AxisX.Interval = MAX5 / 5;
                    this.chart6.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart6.ChartAreas[0].AxisY.Maximum = MAX3;
                    this.chart6.ChartAreas[0].AxisY.Interval = MAX3 / 5;
                    this.chart6.Series[0].Points.AddXY(t5_1, t3_1);
                    this.chart6.Series[0].Points.AddXY(t5_2, t3_2);
                    this.chart6.Series[0].Points.AddXY(t5_3, t3_3);
                    this.chart6.Series[0].Points.AddXY(t5_4, t3_4);
                    this.chart6.Series[0].Points.AddXY(t5_5, t3_5);
                    this.chart6.Series[0].Points.AddXY(t5_6, t3_6);
                    this.chart6.Series[0].Points.AddXY(t5_7, t3_7);
                    this.chart6.Series[0].Points.AddXY(t5_8, t3_8);
                    this.chart6.Series[0].Points.AddXY(t5_9, t3_9);
                    this.chart6.Series[0].Points.AddXY(t5_10, t3_10);

                    this.chart7.ChartAreas[0].AxisX.Minimum = 0; // X - R    Y - Uв
                    this.chart7.ChartAreas[0].AxisX.Maximum = MAX5;
                    this.chart7.ChartAreas[0].AxisX.Interval = MAX5 / 5;
                    this.chart7.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart7.ChartAreas[0].AxisY.Maximum = MAX4;
                    this.chart7.ChartAreas[0].AxisY.Interval = MAX4 / 5;
                    this.chart7.Series[0].Points.AddXY(t5_1, t4_1);
                    this.chart7.Series[0].Points.AddXY(t5_2, t4_2);
                    this.chart7.Series[0].Points.AddXY(t5_3, t4_3);
                    this.chart7.Series[0].Points.AddXY(t5_4, t4_4);
                    this.chart7.Series[0].Points.AddXY(t5_5, t4_5);
                    this.chart7.Series[0].Points.AddXY(t5_6, t4_6);
                    this.chart7.Series[0].Points.AddXY(t5_7, t4_7);
                    this.chart7.Series[0].Points.AddXY(t5_8, t4_8);
                    this.chart7.Series[0].Points.AddXY(t5_9, t4_9);
                    this.chart7.Series[0].Points.AddXY(t5_10, t4_10);

                    xxx += hhh;
                }
            }

            if (index == "2")
            {
                label3.Text = "Io";
                label4.Text = "Uв";
                label5.Text = "R";
                label6.Text = "C";
                label7.Text = "N посл.";
                label8.Text = "N пар.";

                Idop = Convert.ToDouble(textBox111.Text);
                Uobr = Convert.ToDouble(textBox112.Text);

                t1_1 = Convert.ToDouble(textBox1.Text);
                t1_2 = Convert.ToDouble(textBox2.Text);
                t1_3 = Convert.ToDouble(textBox3.Text);
                t1_4 = Convert.ToDouble(textBox4.Text);
                t1_5 = Convert.ToDouble(textBox5.Text);
                t1_6 = Convert.ToDouble(textBox6.Text);
                t1_7 = Convert.ToDouble(textBox7.Text);
                t1_8 = Convert.ToDouble(textBox8.Text);
                t1_9 = Convert.ToDouble(textBox9.Text);
                t1_10 = Convert.ToDouble(textBox10.Text);

                t2_1 = Convert.ToDouble(textBox11.Text);
                t2_2 = Convert.ToDouble(textBox12.Text);
                t2_3 = Convert.ToDouble(textBox13.Text);
                t2_4 = Convert.ToDouble(textBox14.Text);
                t2_5 = Convert.ToDouble(textBox15.Text);
                t2_6 = Convert.ToDouble(textBox16.Text);
                t2_7 = Convert.ToDouble(textBox17.Text);
                t2_8 = Convert.ToDouble(textBox18.Text);
                t2_9 = Convert.ToDouble(textBox19.Text);
                t2_10 = Convert.ToDouble(textBox20.Text);

                t3_1 = t2_1 / t1_1;
                t3_2 = t2_2 / t1_2;
                t3_3 = t2_3 / t1_3;
                t3_4 = t2_4 / t1_4;
                t3_5 = t2_5 / t1_5;
                t3_6 = t2_6 / t1_6;
                t3_7 = t2_7 / t1_7;
                t3_8 = t2_8 / t1_8;
                t3_9 = t2_9 / t1_9;
                t3_10 = t2_10 / t1_10;

                textBox21.Text = t3_1.ToString("0.##");
                textBox22.Text = t3_2.ToString("0.##");
                textBox23.Text = t3_3.ToString("0.##");
                textBox24.Text = t3_4.ToString("0.##");
                textBox25.Text = t3_5.ToString("0.##");
                textBox26.Text = t3_6.ToString("0.##");
                textBox27.Text = t3_7.ToString("0.##");
                textBox28.Text = t3_8.ToString("0.##");
                textBox29.Text = t3_9.ToString("0.##");
                textBox30.Text = t3_10.ToString("0.##");

                t4_1 = 1.41 * t1_1;
                t4_2 = 1.41 * t1_2;
                t4_3 = 1.41 * t1_3;
                t4_4 = 1.41 * t1_4;
                t4_5 = 1.41 * t1_5;
                t4_6 = 1.41 * t1_6;
                t4_7 = 1.41 * t1_7;
                t4_8 = 1.41 * t1_8;
                t4_9 = 1.41 * t1_9;
                t4_10 = 1.41 * t1_10;

                textBox31.Text = t4_1.ToString("0.##");
                textBox32.Text = t4_2.ToString("0.##");
                textBox33.Text = t4_3.ToString("0.##");
                textBox34.Text = t4_4.ToString("0.##");
                textBox35.Text = t4_5.ToString("0.##");
                textBox36.Text = t4_6.ToString("0.##");
                textBox37.Text = t4_7.ToString("0.##");
                textBox38.Text = t4_8.ToString("0.##");
                textBox39.Text = t4_9.ToString("0.##");
                textBox40.Text = t4_10.ToString("0.##");

                t5_1 = t1_1 / t3_1;
                t5_2 = t1_2 / t3_2;
                t5_3 = t1_3 / t3_3;
                t5_4 = t1_4 / t3_4;
                t5_5 = t1_5 / t3_5;
                t5_6 = t1_6 / t3_6;
                t5_7 = t1_7 / t3_7;
                t5_8 = t1_8 / t3_8;
                t5_9 = t1_9 / t3_9;
                t5_10 = t1_10 / t3_10;

                textBox41.Text = t5_1.ToString("0.##");
                textBox42.Text = t5_2.ToString("0.##");
                textBox43.Text = t5_3.ToString("0.##");
                textBox44.Text = t5_4.ToString("0.##");
                textBox45.Text = t5_5.ToString("0.##");
                textBox46.Text = t5_6.ToString("0.##");
                textBox47.Text = t5_7.ToString("0.##");
                textBox48.Text = t5_8.ToString("0.##");
                textBox49.Text = t5_9.ToString("0.##");
                textBox50.Text = t5_10.ToString("0.##");

                t6_1 = 3.14 * (t4_1 - t1_1) / t3_1;
                t6_2 = 3.14 * (t4_2 - t1_2) / t3_2;
                t6_3 = 3.14 * (t4_3 - t1_3) / t3_3;
                t6_4 = 3.14 * (t4_4 - t1_4) / t3_4;
                t6_5 = 3.14 * (t4_5 - t1_5) / t3_5;
                t6_6 = 3.14 * (t4_6 - t1_6) / t3_6;
                t6_7 = 3.14 * (t4_7 - t1_7) / t3_7;
                t6_8 = 3.14 * (t4_8 - t1_8) / t3_8;
                t6_9 = 3.14 * (t4_9 - t1_9) / t3_9;
                t6_10 = 3.14 * (t4_10 - t1_10) / t3_10;

                textBox51.Text = t6_1.ToString("0.##");
                textBox52.Text = t6_2.ToString("0.##");
                textBox53.Text = t6_3.ToString("0.##");
                textBox54.Text = t6_4.ToString("0.##");
                textBox55.Text = t6_5.ToString("0.##");
                textBox56.Text = t6_6.ToString("0.##");
                textBox57.Text = t6_7.ToString("0.##");
                textBox58.Text = t6_8.ToString("0.##");
                textBox59.Text = t6_9.ToString("0.##");
                textBox60.Text = t6_10.ToString("0.##");

                t7_1 = t4_1 / Uobr;
                int T7_1 = Convert.ToInt32(Math.Ceiling(t7_1));
                t7_2 = t4_2 / Uobr;
                int T7_2 = Convert.ToInt32(Math.Ceiling(t7_2));
                t7_3 = t4_3 / Uobr;
                int T7_3 = Convert.ToInt32(Math.Ceiling(t7_3));
                t7_4 = t4_4 / Uobr;
                int T7_4 = Convert.ToInt32(Math.Ceiling(t7_4));
                t7_5 = t4_5 / Uobr;
                int T7_5 = Convert.ToInt32(Math.Ceiling(t7_5));
                t7_6 = t4_6 / Uobr;
                int T7_6 = Convert.ToInt32(Math.Ceiling(t7_6));
                t7_7 = t4_7 / Uobr;
                int T7_7 = Convert.ToInt32(Math.Ceiling(t7_7));
                t7_8 = t4_8 / Uobr;
                int T7_8 = Convert.ToInt32(Math.Ceiling(t7_8));
                t7_9 = t4_9 / Uobr;
                int T7_9 = Convert.ToInt32(Math.Ceiling(t7_9));
                t7_10 = t4_10 / Uobr;
                int T7_10 = Convert.ToInt32(Math.Ceiling(t7_10));

                textBox61.Text = T7_1.ToString("0.##");
                textBox62.Text = T7_2.ToString("0.##");
                textBox63.Text = T7_3.ToString("0.##");
                textBox64.Text = T7_4.ToString("0.##");
                textBox65.Text = T7_5.ToString("0.##");
                textBox66.Text = T7_6.ToString("0.##");
                textBox67.Text = T7_7.ToString("0.##");
                textBox68.Text = T7_8.ToString("0.##");
                textBox69.Text = T7_9.ToString("0.##");
                textBox70.Text = T7_10.ToString("0.##");

                t8_1 = t3_1 / Idop;
                int T8_1 = Convert.ToInt32(Math.Ceiling(t8_1));
                t8_2 = t3_2 / Idop;
                int T8_2 = Convert.ToInt32(Math.Ceiling(t8_2));
                t8_3 = t3_3 / Idop;
                int T8_3 = Convert.ToInt32(Math.Ceiling(t8_3));
                t8_4 = t3_4 / Idop;
                int T8_4 = Convert.ToInt32(Math.Ceiling(t8_4));
                t8_5 = t3_5 / Idop;
                int T8_5 = Convert.ToInt32(Math.Ceiling(t8_5));
                t8_6 = t3_6 / Idop;
                int T8_6 = Convert.ToInt32(Math.Ceiling(t8_6));
                t8_7 = t3_7 / Idop;
                int T8_7 = Convert.ToInt32(Math.Ceiling(t8_7));
                t8_8 = t3_8 / Idop;
                int T8_8 = Convert.ToInt32(Math.Ceiling(t8_8));
                t8_9 = t3_9 / Idop;
                int T8_9 = Convert.ToInt32(Math.Ceiling(t8_9));
                t8_10 = t3_10 / Idop;
                int T8_10 = Convert.ToInt32(Math.Ceiling(t8_10));

                textBox71.Text = T8_1.ToString("0.##");
                textBox72.Text = T8_2.ToString("0.##");
                textBox73.Text = T8_3.ToString("0.##");
                textBox74.Text = T8_4.ToString("0.##");
                textBox75.Text = T8_5.ToString("0.##");
                textBox76.Text = T8_6.ToString("0.##");
                textBox77.Text = T8_7.ToString("0.##");
                textBox78.Text = T8_8.ToString("0.##");
                textBox79.Text = T8_9.ToString("0.##");
                textBox80.Text = T8_10.ToString("0.##");

                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                textBox21.Visible = true;
                textBox22.Visible = true;
                textBox23.Visible = true;
                textBox24.Visible = true;
                textBox25.Visible = true;
                textBox26.Visible = true;
                textBox27.Visible = true;
                textBox28.Visible = true;
                textBox29.Visible = true;
                textBox30.Visible = true;
                textBox31.Visible = true;
                textBox32.Visible = true;
                textBox33.Visible = true;
                textBox34.Visible = true;
                textBox35.Visible = true;
                textBox36.Visible = true;
                textBox37.Visible = true;
                textBox38.Visible = true;
                textBox39.Visible = true;
                textBox40.Visible = true;
                textBox41.Visible = true;
                textBox42.Visible = true;
                textBox43.Visible = true;
                textBox44.Visible = true;
                textBox45.Visible = true;
                textBox46.Visible = true;
                textBox47.Visible = true;
                textBox48.Visible = true;
                textBox49.Visible = true;
                textBox50.Visible = true;
                textBox51.Visible = true;
                textBox52.Visible = true;
                textBox53.Visible = true;
                textBox54.Visible = true;
                textBox55.Visible = true;
                textBox56.Visible = true;
                textBox57.Visible = true;
                textBox58.Visible = true;
                textBox59.Visible = true;
                textBox60.Visible = true;
                textBox61.Visible = true;
                textBox62.Visible = true;
                textBox63.Visible = true;
                textBox64.Visible = true;
                textBox65.Visible = true;
                textBox66.Visible = true;
                textBox67.Visible = true;
                textBox68.Visible = true;
                textBox69.Visible = true;
                textBox70.Visible = true;
                textBox71.Visible = true;
                textBox72.Visible = true;
                textBox73.Visible = true;
                textBox74.Visible = true;
                textBox75.Visible = true;
                textBox76.Visible = true;
                textBox77.Visible = true;
                textBox78.Visible = true;
                textBox79.Visible = true;
                textBox80.Visible = true;
                textBox81.Visible = false;
                textBox82.Visible = false;
                textBox83.Visible = false;
                textBox84.Visible = false;
                textBox85.Visible = false;
                textBox86.Visible = false;
                textBox87.Visible = false;
                textBox88.Visible = false;
                textBox89.Visible = false;
                textBox90.Visible = false;
                textBox91.Visible = false;
                textBox92.Visible = false;
                textBox93.Visible = false;
                textBox94.Visible = false;
                textBox95.Visible = false;
                textBox96.Visible = false;
                textBox97.Visible = false;
                textBox98.Visible = false;
                textBox99.Visible = false;
                textBox100.Visible = false;
                textBox101.Visible = false;
                textBox102.Visible = false;
                textBox103.Visible = false;
                textBox104.Visible = false;
                textBox105.Visible = false;
                textBox106.Visible = false;
                textBox107.Visible = false;
                textBox108.Visible = false;
                textBox109.Visible = false;
                textBox110.Visible = false;
                chart1.Visible = true;
                chart2.Visible = true;
                chart3.Visible = true;
                chart4.Visible = true;
                chart5.Visible = true;
                chart6.Visible = true;
                chart7.Visible = true;
                chart8.Visible = true;

                double aaa, bbb, hhh, xxx, max2, max3, max4, max5, max6, MAX2, MAX3, MAX4, MAX5, MAX6;
                aaa = 0.01;
                bbb = 0.01;
                hhh = 0.01;
                xxx = aaa;
                this.chart1.Series[0].Points.Clear();
                this.chart2.Series[0].Points.Clear();
                this.chart3.Series[0].Points.Clear();
                this.chart4.Series[0].Points.Clear();
                this.chart5.Series[0].Points.Clear();
                this.chart6.Series[0].Points.Clear();
                this.chart7.Series[0].Points.Clear();
                this.chart8.Series[0].Points.Clear();
                this.chart1.ChartAreas[0].AxisX.Title = "Po(Uв)";
                this.chart2.ChartAreas[0].AxisX.Title = "Po(Io)";
                this.chart3.ChartAreas[0].AxisX.Title = "Po(R)";
                this.chart4.ChartAreas[0].AxisX.Title = "Io(Uв)";
                this.chart5.ChartAreas[0].AxisX.Title = "Io(R)";
                this.chart6.ChartAreas[0].AxisX.Title = "Uв(R)";
                this.chart7.ChartAreas[0].AxisX.Title = "Io(C)";
                this.chart8.ChartAreas[0].AxisX.Title = "Uв(C)";

                max2 = Math.Max(Math.Max(Math.Max(Math.Max(t2_1, t2_2), Math.Max(t2_3, t2_4)), Math.Max(Math.Max(t2_5, t2_6), Math.Max(t2_7, t2_8))), Math.Max(t2_9, t2_10));
                max3 = Math.Max(Math.Max(Math.Max(Math.Max(t3_1, t3_2), Math.Max(t3_3, t3_4)), Math.Max(Math.Max(t3_5, t3_6), Math.Max(t3_7, t3_8))), Math.Max(t3_9, t3_10));
                max4 = Math.Max(Math.Max(Math.Max(Math.Max(t4_1, t4_2), Math.Max(t4_3, t4_4)), Math.Max(Math.Max(t4_5, t4_6), Math.Max(t4_7, t4_8))), Math.Max(t4_9, t4_10));
                max5 = Math.Max(Math.Max(Math.Max(Math.Max(t5_1, t5_2), Math.Max(t5_3, t5_4)), Math.Max(Math.Max(t5_5, t5_6), Math.Max(t5_7, t5_8))), Math.Max(t5_9, t5_10));
                max6 = Math.Max(Math.Max(Math.Max(Math.Max(t6_1, t6_2), Math.Max(t6_3, t6_4)), Math.Max(Math.Max(t6_5, t6_6), Math.Max(t6_7, t6_8))), Math.Max(t6_9, t6_10));

                MAX2 = ((int)((max2 + 150) / 100)) * 100;
                MAX3 = ((int)((max3 + 10) / 10)) * 10;
                MAX4 = ((int)((max4 + 150) / 100)) * 100;
                MAX5 = ((int)((max5 + 20) / 10)) * 10;
                MAX6 = ((int)((max6 + 150) / 100)) * 100;

                while (xxx <= bbb)
                {
                    this.chart1.ChartAreas[0].AxisX.Minimum = 0; // X - Uв    Y - Po
                    this.chart1.ChartAreas[0].AxisX.Maximum = MAX4;
                    this.chart1.ChartAreas[0].AxisX.Interval = MAX4 / 5;
                    this.chart1.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart1.ChartAreas[0].AxisY.Maximum = MAX2;
                    this.chart1.ChartAreas[0].AxisY.Interval = MAX2 / 5;
                    this.chart1.Series[0].Points.AddXY(t4_1, t2_1);
                    this.chart1.Series[0].Points.AddXY(t4_2, t2_2);
                    this.chart1.Series[0].Points.AddXY(t4_3, t2_3);
                    this.chart1.Series[0].Points.AddXY(t4_4, t2_4);
                    this.chart1.Series[0].Points.AddXY(t4_5, t2_5);
                    this.chart1.Series[0].Points.AddXY(t4_6, t2_6);
                    this.chart1.Series[0].Points.AddXY(t4_7, t2_7);
                    this.chart1.Series[0].Points.AddXY(t4_8, t2_8);
                    this.chart1.Series[0].Points.AddXY(t4_9, t2_9);
                    this.chart1.Series[0].Points.AddXY(t4_10, t2_10);

                    this.chart2.ChartAreas[0].AxisX.Minimum = 0; // X - Io    Y - Po
                    this.chart2.ChartAreas[0].AxisX.Maximum = MAX3;
                    this.chart2.ChartAreas[0].AxisX.Interval = MAX3 / 5;
                    this.chart2.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart2.ChartAreas[0].AxisY.Maximum = MAX2;
                    this.chart2.ChartAreas[0].AxisY.Interval = MAX2 / 5;
                    this.chart2.Series[0].Points.AddXY(t3_1, t2_1);
                    this.chart2.Series[0].Points.AddXY(t3_2, t2_2);
                    this.chart2.Series[0].Points.AddXY(t3_3, t2_3);
                    this.chart2.Series[0].Points.AddXY(t3_4, t2_4);
                    this.chart2.Series[0].Points.AddXY(t3_5, t2_5);
                    this.chart2.Series[0].Points.AddXY(t3_6, t2_6);
                    this.chart2.Series[0].Points.AddXY(t3_7, t2_7);
                    this.chart2.Series[0].Points.AddXY(t3_8, t2_8);
                    this.chart2.Series[0].Points.AddXY(t3_9, t2_9);
                    this.chart2.Series[0].Points.AddXY(t3_10, t2_10);

                    this.chart3.ChartAreas[0].AxisX.Minimum = 0; // X - R    Y - Po
                    this.chart3.ChartAreas[0].AxisX.Maximum = MAX5;
                    this.chart3.ChartAreas[0].AxisX.Interval = MAX5 / 5;
                    this.chart3.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart3.ChartAreas[0].AxisY.Maximum = MAX2;
                    this.chart3.ChartAreas[0].AxisY.Interval = MAX2 / 5;
                    this.chart3.Series[0].Points.AddXY(t5_1, t2_1);
                    this.chart3.Series[0].Points.AddXY(t5_2, t2_2);
                    this.chart3.Series[0].Points.AddXY(t5_3, t2_3);
                    this.chart3.Series[0].Points.AddXY(t5_4, t2_4);
                    this.chart3.Series[0].Points.AddXY(t5_5, t2_5);
                    this.chart3.Series[0].Points.AddXY(t5_6, t2_6);
                    this.chart3.Series[0].Points.AddXY(t5_7, t2_7);
                    this.chart3.Series[0].Points.AddXY(t5_8, t2_8);
                    this.chart3.Series[0].Points.AddXY(t5_9, t2_9);
                    this.chart3.Series[0].Points.AddXY(t5_10, t2_10);

                    this.chart4.ChartAreas[0].AxisX.Minimum = 0; // X - Uв    Y - Io
                    this.chart4.ChartAreas[0].AxisX.Maximum = MAX4;
                    this.chart4.ChartAreas[0].AxisX.Interval = MAX4 / 5;
                    this.chart4.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart4.ChartAreas[0].AxisY.Maximum = MAX3;
                    this.chart4.ChartAreas[0].AxisY.Interval = MAX3 / 5;
                    this.chart4.Series[0].Points.AddXY(t4_1, t3_1);
                    this.chart4.Series[0].Points.AddXY(t4_2, t3_2);
                    this.chart4.Series[0].Points.AddXY(t4_3, t3_3);
                    this.chart4.Series[0].Points.AddXY(t4_4, t3_4);
                    this.chart4.Series[0].Points.AddXY(t4_5, t3_5);
                    this.chart4.Series[0].Points.AddXY(t4_6, t3_6);
                    this.chart4.Series[0].Points.AddXY(t4_7, t3_7);
                    this.chart4.Series[0].Points.AddXY(t4_8, t3_8);
                    this.chart4.Series[0].Points.AddXY(t4_9, t3_9);
                    this.chart4.Series[0].Points.AddXY(t4_10, t3_10);

                    this.chart5.ChartAreas[0].AxisX.Minimum = 0; // X - R    Y - Io
                    this.chart5.ChartAreas[0].AxisX.Maximum = MAX5;
                    this.chart5.ChartAreas[0].AxisX.Interval = MAX5 / 5;
                    this.chart5.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart5.ChartAreas[0].AxisY.Maximum = MAX3;
                    this.chart5.ChartAreas[0].AxisY.Interval = MAX3 / 5;
                    this.chart5.Series[0].Points.AddXY(t5_1, t3_1);
                    this.chart5.Series[0].Points.AddXY(t5_2, t3_2);
                    this.chart5.Series[0].Points.AddXY(t5_3, t3_3);
                    this.chart5.Series[0].Points.AddXY(t5_4, t3_4);
                    this.chart5.Series[0].Points.AddXY(t5_5, t3_5);
                    this.chart5.Series[0].Points.AddXY(t5_6, t3_6);
                    this.chart5.Series[0].Points.AddXY(t5_7, t3_7);
                    this.chart5.Series[0].Points.AddXY(t5_8, t3_8);
                    this.chart5.Series[0].Points.AddXY(t5_9, t3_9);
                    this.chart5.Series[0].Points.AddXY(t5_10, t3_10);

                    this.chart6.ChartAreas[0].AxisX.Minimum = 0; // X - R    Y - Uв
                    this.chart6.ChartAreas[0].AxisX.Maximum = MAX5;
                    this.chart6.ChartAreas[0].AxisX.Interval = MAX5 / 5;
                    this.chart6.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart6.ChartAreas[0].AxisY.Maximum = MAX4;
                    this.chart6.ChartAreas[0].AxisY.Interval = MAX4 / 5;
                    this.chart6.Series[0].Points.AddXY(t5_1, t4_1);
                    this.chart6.Series[0].Points.AddXY(t5_2, t4_2);
                    this.chart6.Series[0].Points.AddXY(t5_3, t4_3);
                    this.chart6.Series[0].Points.AddXY(t5_4, t4_4);
                    this.chart6.Series[0].Points.AddXY(t5_5, t4_5);
                    this.chart6.Series[0].Points.AddXY(t5_6, t4_6);
                    this.chart6.Series[0].Points.AddXY(t5_7, t4_7);
                    this.chart6.Series[0].Points.AddXY(t5_8, t4_8);
                    this.chart6.Series[0].Points.AddXY(t5_9, t4_9);
                    this.chart6.Series[0].Points.AddXY(t5_10, t4_10);

                    this.chart7.ChartAreas[0].AxisX.Minimum = 0; // X - C    Y - Io
                    this.chart7.ChartAreas[0].AxisX.Maximum = MAX6;
                    this.chart7.ChartAreas[0].AxisX.Interval = MAX6 / 5;
                    this.chart7.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart7.ChartAreas[0].AxisY.Maximum = MAX3;
                    this.chart7.ChartAreas[0].AxisY.Interval = MAX3 / 5;
                    this.chart7.Series[0].Points.AddXY(t6_1, t3_1);
                    this.chart7.Series[0].Points.AddXY(t6_2, t3_2);
                    this.chart7.Series[0].Points.AddXY(t6_3, t3_3);
                    this.chart7.Series[0].Points.AddXY(t6_4, t3_4);
                    this.chart7.Series[0].Points.AddXY(t6_5, t3_5);
                    this.chart7.Series[0].Points.AddXY(t6_6, t3_6);
                    this.chart7.Series[0].Points.AddXY(t6_7, t3_7);
                    this.chart7.Series[0].Points.AddXY(t6_8, t3_8);
                    this.chart7.Series[0].Points.AddXY(t6_9, t3_9);
                    this.chart7.Series[0].Points.AddXY(t6_10, t3_10);

                    this.chart8.ChartAreas[0].AxisX.Minimum = 0; // X - C    Y - Uв
                    this.chart8.ChartAreas[0].AxisX.Maximum = MAX6;
                    this.chart8.ChartAreas[0].AxisX.Interval = MAX6 / 5;
                    this.chart8.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart8.ChartAreas[0].AxisY.Maximum = MAX4;
                    this.chart8.ChartAreas[0].AxisY.Interval = MAX4 / 5;
                    this.chart8.Series[0].Points.AddXY(t6_1, t4_1);
                    this.chart8.Series[0].Points.AddXY(t6_2, t4_2);
                    this.chart8.Series[0].Points.AddXY(t6_3, t4_3);
                    this.chart8.Series[0].Points.AddXY(t6_4, t4_4);
                    this.chart8.Series[0].Points.AddXY(t6_5, t4_5);
                    this.chart8.Series[0].Points.AddXY(t6_6, t4_6);
                    this.chart8.Series[0].Points.AddXY(t6_7, t4_7);
                    this.chart8.Series[0].Points.AddXY(t6_8, t4_8);
                    this.chart8.Series[0].Points.AddXY(t6_9, t4_9);
                    this.chart8.Series[0].Points.AddXY(t6_10, t4_10);

                    xxx += hhh;
                }
            }

            if (index == "3")
            {
                label3.Text = "Io";
                label4.Text = "Uв";
                label5.Text = "R";
                label6.Text = "C";
                label7.Text = "N посл.";
                label8.Text = "N пар.";

                Idop = Convert.ToDouble(textBox111.Text);
                Uobr = Convert.ToDouble(textBox112.Text);

                t1_1 = Convert.ToDouble(textBox1.Text);
                t1_2 = Convert.ToDouble(textBox2.Text);
                t1_3 = Convert.ToDouble(textBox3.Text);
                t1_4 = Convert.ToDouble(textBox4.Text);
                t1_5 = Convert.ToDouble(textBox5.Text);
                t1_6 = Convert.ToDouble(textBox6.Text);
                t1_7 = Convert.ToDouble(textBox7.Text);
                t1_8 = Convert.ToDouble(textBox8.Text);
                t1_9 = Convert.ToDouble(textBox9.Text);
                t1_10 = Convert.ToDouble(textBox10.Text);

                t2_1 = Convert.ToDouble(textBox11.Text);
                t2_2 = Convert.ToDouble(textBox12.Text);
                t2_3 = Convert.ToDouble(textBox13.Text);
                t2_4 = Convert.ToDouble(textBox14.Text);
                t2_5 = Convert.ToDouble(textBox15.Text);
                t2_6 = Convert.ToDouble(textBox16.Text);
                t2_7 = Convert.ToDouble(textBox17.Text);
                t2_8 = Convert.ToDouble(textBox18.Text);
                t2_9 = Convert.ToDouble(textBox19.Text);
                t2_10 = Convert.ToDouble(textBox20.Text);

                t3_1 = t2_1 / t1_1;
                t3_2 = t2_2 / t1_2;
                t3_3 = t2_3 / t1_3;
                t3_4 = t2_4 / t1_4;
                t3_5 = t2_5 / t1_5;
                t3_6 = t2_6 / t1_6;
                t3_7 = t2_7 / t1_7;
                t3_8 = t2_8 / t1_8;
                t3_9 = t2_9 / t1_9;
                t3_10 = t2_10 / t1_10;

                textBox21.Text = t3_1.ToString("0.##");
                textBox22.Text = t3_2.ToString("0.##");
                textBox23.Text = t3_3.ToString("0.##");
                textBox24.Text = t3_4.ToString("0.##");
                textBox25.Text = t3_5.ToString("0.##");
                textBox26.Text = t3_6.ToString("0.##");
                textBox27.Text = t3_7.ToString("0.##");
                textBox28.Text = t3_8.ToString("0.##");
                textBox29.Text = t3_9.ToString("0.##");
                textBox30.Text = t3_10.ToString("0.##");

                t4_1 = 2.35 * t1_1;
                t4_2 = 2.35 * t1_2;
                t4_3 = 2.35 * t1_3;
                t4_4 = 2.35 * t1_4;
                t4_5 = 2.35 * t1_5;
                t4_6 = 2.35 * t1_6;
                t4_7 = 2.35 * t1_7;
                t4_8 = 2.35 * t1_8;
                t4_9 = 2.35 * t1_9;
                t4_10 = 2.35 * t1_10;

                textBox31.Text = t4_1.ToString("0.##");
                textBox32.Text = t4_2.ToString("0.##");
                textBox33.Text = t4_3.ToString("0.##");
                textBox34.Text = t4_4.ToString("0.##");
                textBox35.Text = t4_5.ToString("0.##");
                textBox36.Text = t4_6.ToString("0.##");
                textBox37.Text = t4_7.ToString("0.##");
                textBox38.Text = t4_8.ToString("0.##");
                textBox39.Text = t4_9.ToString("0.##");
                textBox40.Text = t4_10.ToString("0.##");

                t5_1 = t1_1 / t3_1;
                t5_2 = t1_2 / t3_2;
                t5_3 = t1_3 / t3_3;
                t5_4 = t1_4 / t3_4;
                t5_5 = t1_5 / t3_5;
                t5_6 = t1_6 / t3_6;
                t5_7 = t1_7 / t3_7;
                t5_8 = t1_8 / t3_8;
                t5_9 = t1_9 / t3_9;
                t5_10 = t1_10 / t3_10;

                textBox41.Text = t5_1.ToString("0.##");
                textBox42.Text = t5_2.ToString("0.##");
                textBox43.Text = t5_3.ToString("0.##");
                textBox44.Text = t5_4.ToString("0.##");
                textBox45.Text = t5_5.ToString("0.##");
                textBox46.Text = t5_6.ToString("0.##");
                textBox47.Text = t5_7.ToString("0.##");
                textBox48.Text = t5_8.ToString("0.##");
                textBox49.Text = t5_9.ToString("0.##");
                textBox50.Text = t5_10.ToString("0.##");

                t6_1 = 3.14 * (t4_1 - t1_1) / 2 * t3_1;
                t6_2 = 3.14 * (t4_2 - t1_2) / 2 * t3_2;
                t6_3 = 3.14 * (t4_3 - t1_3) / 2 * t3_3;
                t6_4 = 3.14 * (t4_4 - t1_4) / 2 * t3_4;
                t6_5 = 3.14 * (t4_5 - t1_5) / 2 * t3_5;
                t6_6 = 3.14 * (t4_6 - t1_6) / 2 * t3_6;
                t6_7 = 3.14 * (t4_7 - t1_7) / 2 * t3_7;
                t6_8 = 3.14 * (t4_8 - t1_8) / 2 * t3_8;
                t6_9 = 3.14 * (t4_9 - t1_9) / 2 * t3_9;
                t6_10 = 3.14 * (t4_10 - t1_10) / 2 * t3_10;

                textBox51.Text = t6_1.ToString("0.##");
                textBox52.Text = t6_2.ToString("0.##");
                textBox53.Text = t6_3.ToString("0.##");
                textBox54.Text = t6_4.ToString("0.##");
                textBox55.Text = t6_5.ToString("0.##");
                textBox56.Text = t6_6.ToString("0.##");
                textBox57.Text = t6_7.ToString("0.##");
                textBox58.Text = t6_8.ToString("0.##");
                textBox59.Text = t6_9.ToString("0.##");
                textBox60.Text = t6_10.ToString("0.##");

                t7_1 = t4_1 / Uobr;
                int T7_1 = Convert.ToInt32(Math.Ceiling(t7_1));
                t7_2 = t4_2 / Uobr;
                int T7_2 = Convert.ToInt32(Math.Ceiling(t7_2));
                t7_3 = t4_3 / Uobr;
                int T7_3 = Convert.ToInt32(Math.Ceiling(t7_3));
                t7_4 = t4_4 / Uobr;
                int T7_4 = Convert.ToInt32(Math.Ceiling(t7_4));
                t7_5 = t4_5 / Uobr;
                int T7_5 = Convert.ToInt32(Math.Ceiling(t7_5));
                t7_6 = t4_6 / Uobr;
                int T7_6 = Convert.ToInt32(Math.Ceiling(t7_6));
                t7_7 = t4_7 / Uobr;
                int T7_7 = Convert.ToInt32(Math.Ceiling(t7_7));
                t7_8 = t4_8 / Uobr;
                int T7_8 = Convert.ToInt32(Math.Ceiling(t7_8));
                t7_9 = t4_9 / Uobr;
                int T7_9 = Convert.ToInt32(Math.Ceiling(t7_9));
                t7_10 = t4_10 / Uobr;
                int T7_10 = Convert.ToInt32(Math.Ceiling(t7_10));

                textBox61.Text = T7_1.ToString("0.##");
                textBox62.Text = T7_2.ToString("0.##");
                textBox63.Text = T7_3.ToString("0.##");
                textBox64.Text = T7_4.ToString("0.##");
                textBox65.Text = T7_5.ToString("0.##");
                textBox66.Text = T7_6.ToString("0.##");
                textBox67.Text = T7_7.ToString("0.##");
                textBox68.Text = T7_8.ToString("0.##");
                textBox69.Text = T7_9.ToString("0.##");
                textBox70.Text = T7_10.ToString("0.##");

                t8_1 = t3_1 / Idop;
                int T8_1 = Convert.ToInt32(Math.Ceiling(t8_1));
                t8_2 = t3_2 / Idop;
                int T8_2 = Convert.ToInt32(Math.Ceiling(t8_2));
                t8_3 = t3_3 / Idop;
                int T8_3 = Convert.ToInt32(Math.Ceiling(t8_3));
                t8_4 = t3_4 / Idop;
                int T8_4 = Convert.ToInt32(Math.Ceiling(t8_4));
                t8_5 = t3_5 / Idop;
                int T8_5 = Convert.ToInt32(Math.Ceiling(t8_5));
                t8_6 = t3_6 / Idop;
                int T8_6 = Convert.ToInt32(Math.Ceiling(t8_6));
                t8_7 = t3_7 / Idop;
                int T8_7 = Convert.ToInt32(Math.Ceiling(t8_7));
                t8_8 = t3_8 / Idop;
                int T8_8 = Convert.ToInt32(Math.Ceiling(t8_8));
                t8_9 = t3_9 / Idop;
                int T8_9 = Convert.ToInt32(Math.Ceiling(t8_9));
                t8_10 = t3_10 / Idop;
                int T8_10 = Convert.ToInt32(Math.Ceiling(t8_10));

                textBox71.Text = T8_1.ToString("0.##");
                textBox72.Text = T8_2.ToString("0.##");
                textBox73.Text = T8_3.ToString("0.##");
                textBox74.Text = T8_4.ToString("0.##");
                textBox75.Text = T8_5.ToString("0.##");
                textBox76.Text = T8_6.ToString("0.##");
                textBox77.Text = T8_7.ToString("0.##");
                textBox78.Text = T8_8.ToString("0.##");
                textBox79.Text = T8_9.ToString("0.##");
                textBox80.Text = T8_10.ToString("0.##");

                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                textBox21.Visible = true;
                textBox22.Visible = true;
                textBox23.Visible = true;
                textBox24.Visible = true;
                textBox25.Visible = true;
                textBox26.Visible = true;
                textBox27.Visible = true;
                textBox28.Visible = true;
                textBox29.Visible = true;
                textBox30.Visible = true;
                textBox31.Visible = true;
                textBox32.Visible = true;
                textBox33.Visible = true;
                textBox34.Visible = true;
                textBox35.Visible = true;
                textBox36.Visible = true;
                textBox37.Visible = true;
                textBox38.Visible = true;
                textBox39.Visible = true;
                textBox40.Visible = true;
                textBox41.Visible = true;
                textBox42.Visible = true;
                textBox43.Visible = true;
                textBox44.Visible = true;
                textBox45.Visible = true;
                textBox46.Visible = true;
                textBox47.Visible = true;
                textBox48.Visible = true;
                textBox49.Visible = true;
                textBox50.Visible = true;
                textBox51.Visible = true;
                textBox52.Visible = true;
                textBox53.Visible = true;
                textBox54.Visible = true;
                textBox55.Visible = true;
                textBox56.Visible = true;
                textBox57.Visible = true;
                textBox58.Visible = true;
                textBox59.Visible = true;
                textBox60.Visible = true;
                textBox61.Visible = true;
                textBox62.Visible = true;
                textBox63.Visible = true;
                textBox64.Visible = true;
                textBox65.Visible = true;
                textBox66.Visible = true;
                textBox67.Visible = true;
                textBox68.Visible = true;
                textBox69.Visible = true;
                textBox70.Visible = true;
                textBox71.Visible = true;
                textBox72.Visible = true;
                textBox73.Visible = true;
                textBox74.Visible = true;
                textBox75.Visible = true;
                textBox76.Visible = true;
                textBox77.Visible = true;
                textBox78.Visible = true;
                textBox79.Visible = true;
                textBox80.Visible = true;
                textBox81.Visible = false;
                textBox82.Visible = false;
                textBox83.Visible = false;
                textBox84.Visible = false;
                textBox85.Visible = false;
                textBox86.Visible = false;
                textBox87.Visible = false;
                textBox88.Visible = false;
                textBox89.Visible = false;
                textBox90.Visible = false;
                textBox91.Visible = false;
                textBox92.Visible = false;
                textBox93.Visible = false;
                textBox94.Visible = false;
                textBox95.Visible = false;
                textBox96.Visible = false;
                textBox97.Visible = false;
                textBox98.Visible = false;
                textBox99.Visible = false;
                textBox100.Visible = false;
                textBox101.Visible = false;
                textBox102.Visible = false;
                textBox103.Visible = false;
                textBox104.Visible = false;
                textBox105.Visible = false;
                textBox106.Visible = false;
                textBox107.Visible = false;
                textBox108.Visible = false;
                textBox109.Visible = false;
                textBox110.Visible = false;
                chart1.Visible = true;
                chart2.Visible = true;
                chart3.Visible = true;
                chart4.Visible = true;
                chart5.Visible = true;
                chart6.Visible = true;
                chart7.Visible = true;
                chart8.Visible = true;

                double aaa, bbb, hhh, xxx, max2, max3, max4, max5, max6, MAX2, MAX3, MAX4, MAX5, MAX6;
                aaa = 0.01;
                bbb = 0.01;
                hhh = 0.01;
                xxx = aaa;
                this.chart1.Series[0].Points.Clear();
                this.chart2.Series[0].Points.Clear();
                this.chart3.Series[0].Points.Clear();
                this.chart4.Series[0].Points.Clear();
                this.chart5.Series[0].Points.Clear();
                this.chart6.Series[0].Points.Clear();
                this.chart7.Series[0].Points.Clear();
                this.chart8.Series[0].Points.Clear();
                this.chart1.ChartAreas[0].AxisX.Title = "Po(Uв)";
                this.chart2.ChartAreas[0].AxisX.Title = "Po(Io)";
                this.chart3.ChartAreas[0].AxisX.Title = "Po(R)";
                this.chart4.ChartAreas[0].AxisX.Title = "Io(Uв)";
                this.chart5.ChartAreas[0].AxisX.Title = "Io(R)";
                this.chart6.ChartAreas[0].AxisX.Title = "Uв(R)";
                this.chart7.ChartAreas[0].AxisX.Title = "Io(C)";
                this.chart8.ChartAreas[0].AxisX.Title = "Uв(C)";

                max2 = Math.Max(Math.Max(Math.Max(Math.Max(t2_1, t2_2), Math.Max(t2_3, t2_4)), Math.Max(Math.Max(t2_5, t2_6), Math.Max(t2_7, t2_8))), Math.Max(t2_9, t2_10));
                max3 = Math.Max(Math.Max(Math.Max(Math.Max(t3_1, t3_2), Math.Max(t3_3, t3_4)), Math.Max(Math.Max(t3_5, t3_6), Math.Max(t3_7, t3_8))), Math.Max(t3_9, t3_10));
                max4 = Math.Max(Math.Max(Math.Max(Math.Max(t4_1, t4_2), Math.Max(t4_3, t4_4)), Math.Max(Math.Max(t4_5, t4_6), Math.Max(t4_7, t4_8))), Math.Max(t4_9, t4_10));
                max5 = Math.Max(Math.Max(Math.Max(Math.Max(t5_1, t5_2), Math.Max(t5_3, t5_4)), Math.Max(Math.Max(t5_5, t5_6), Math.Max(t5_7, t5_8))), Math.Max(t5_9, t5_10));
                max6 = Math.Max(Math.Max(Math.Max(Math.Max(t6_1, t6_2), Math.Max(t6_3, t6_4)), Math.Max(Math.Max(t6_5, t6_6), Math.Max(t6_7, t6_8))), Math.Max(t6_9, t6_10));

                MAX2 = ((int)((max2 + 150) / 100)) * 100;
                MAX3 = ((int)((max3 + 10) / 10)) * 10;
                MAX4 = ((int)((max4 + 150) / 100)) * 100;
                MAX5 = ((int)((max5 + 20) / 10)) * 10;
                MAX6 = ((int)((max6 + 150) / 100)) * 100;

                while (xxx <= bbb)
                {
                    this.chart1.ChartAreas[0].AxisX.Minimum = 0; // X - Uв    Y - Po
                    this.chart1.ChartAreas[0].AxisX.Maximum = MAX4;
                    this.chart1.ChartAreas[0].AxisX.Interval = MAX4 / 5;
                    this.chart1.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart1.ChartAreas[0].AxisY.Maximum = MAX2;
                    this.chart1.ChartAreas[0].AxisY.Interval = MAX2 / 5;
                    this.chart1.Series[0].Points.AddXY(t4_1, t2_1);
                    this.chart1.Series[0].Points.AddXY(t4_2, t2_2);
                    this.chart1.Series[0].Points.AddXY(t4_3, t2_3);
                    this.chart1.Series[0].Points.AddXY(t4_4, t2_4);
                    this.chart1.Series[0].Points.AddXY(t4_5, t2_5);
                    this.chart1.Series[0].Points.AddXY(t4_6, t2_6);
                    this.chart1.Series[0].Points.AddXY(t4_7, t2_7);
                    this.chart1.Series[0].Points.AddXY(t4_8, t2_8);
                    this.chart1.Series[0].Points.AddXY(t4_9, t2_9);
                    this.chart1.Series[0].Points.AddXY(t4_10, t2_10);

                    this.chart2.ChartAreas[0].AxisX.Minimum = 0; // X - Io    Y - Po
                    this.chart2.ChartAreas[0].AxisX.Maximum = MAX3;
                    this.chart2.ChartAreas[0].AxisX.Interval = MAX3 / 5;
                    this.chart2.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart2.ChartAreas[0].AxisY.Maximum = MAX2;
                    this.chart2.ChartAreas[0].AxisY.Interval = MAX2 / 5;
                    this.chart2.Series[0].Points.AddXY(t3_1, t2_1);
                    this.chart2.Series[0].Points.AddXY(t3_2, t2_2);
                    this.chart2.Series[0].Points.AddXY(t3_3, t2_3);
                    this.chart2.Series[0].Points.AddXY(t3_4, t2_4);
                    this.chart2.Series[0].Points.AddXY(t3_5, t2_5);
                    this.chart2.Series[0].Points.AddXY(t3_6, t2_6);
                    this.chart2.Series[0].Points.AddXY(t3_7, t2_7);
                    this.chart2.Series[0].Points.AddXY(t3_8, t2_8);
                    this.chart2.Series[0].Points.AddXY(t3_9, t2_9);
                    this.chart2.Series[0].Points.AddXY(t3_10, t2_10);

                    this.chart3.ChartAreas[0].AxisX.Minimum = 0; // X - R    Y - Po
                    this.chart3.ChartAreas[0].AxisX.Maximum = MAX5;
                    this.chart3.ChartAreas[0].AxisX.Interval = MAX5 / 5;
                    this.chart3.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart3.ChartAreas[0].AxisY.Maximum = MAX2;
                    this.chart3.ChartAreas[0].AxisY.Interval = MAX2 / 5;
                    this.chart3.Series[0].Points.AddXY(t5_1, t2_1);
                    this.chart3.Series[0].Points.AddXY(t5_2, t2_2);
                    this.chart3.Series[0].Points.AddXY(t5_3, t2_3);
                    this.chart3.Series[0].Points.AddXY(t5_4, t2_4);
                    this.chart3.Series[0].Points.AddXY(t5_5, t2_5);
                    this.chart3.Series[0].Points.AddXY(t5_6, t2_6);
                    this.chart3.Series[0].Points.AddXY(t5_7, t2_7);
                    this.chart3.Series[0].Points.AddXY(t5_8, t2_8);
                    this.chart3.Series[0].Points.AddXY(t5_9, t2_9);
                    this.chart3.Series[0].Points.AddXY(t5_10, t2_10);

                    this.chart4.ChartAreas[0].AxisX.Minimum = 0; // X - Uв    Y - Io
                    this.chart4.ChartAreas[0].AxisX.Maximum = MAX4;
                    this.chart4.ChartAreas[0].AxisX.Interval = MAX4 / 5;
                    this.chart4.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart4.ChartAreas[0].AxisY.Maximum = MAX3;
                    this.chart4.ChartAreas[0].AxisY.Interval = MAX3 / 5;
                    this.chart4.Series[0].Points.AddXY(t4_1, t3_1);
                    this.chart4.Series[0].Points.AddXY(t4_2, t3_2);
                    this.chart4.Series[0].Points.AddXY(t4_3, t3_3);
                    this.chart4.Series[0].Points.AddXY(t4_4, t3_4);
                    this.chart4.Series[0].Points.AddXY(t4_5, t3_5);
                    this.chart4.Series[0].Points.AddXY(t4_6, t3_6);
                    this.chart4.Series[0].Points.AddXY(t4_7, t3_7);
                    this.chart4.Series[0].Points.AddXY(t4_8, t3_8);
                    this.chart4.Series[0].Points.AddXY(t4_9, t3_9);
                    this.chart4.Series[0].Points.AddXY(t4_10, t3_10);

                    this.chart5.ChartAreas[0].AxisX.Minimum = 0; // X - R    Y - Io
                    this.chart5.ChartAreas[0].AxisX.Maximum = MAX5;
                    this.chart5.ChartAreas[0].AxisX.Interval = MAX5 / 5;
                    this.chart5.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart5.ChartAreas[0].AxisY.Maximum = MAX3;
                    this.chart5.ChartAreas[0].AxisY.Interval = MAX3 / 5;
                    this.chart5.Series[0].Points.AddXY(t5_1, t3_1);
                    this.chart5.Series[0].Points.AddXY(t5_2, t3_2);
                    this.chart5.Series[0].Points.AddXY(t5_3, t3_3);
                    this.chart5.Series[0].Points.AddXY(t5_4, t3_4);
                    this.chart5.Series[0].Points.AddXY(t5_5, t3_5);
                    this.chart5.Series[0].Points.AddXY(t5_6, t3_6);
                    this.chart5.Series[0].Points.AddXY(t5_7, t3_7);
                    this.chart5.Series[0].Points.AddXY(t5_8, t3_8);
                    this.chart5.Series[0].Points.AddXY(t5_9, t3_9);
                    this.chart5.Series[0].Points.AddXY(t5_10, t3_10);

                    this.chart6.ChartAreas[0].AxisX.Minimum = 0; // X - R    Y - Uв
                    this.chart6.ChartAreas[0].AxisX.Maximum = MAX5;
                    this.chart6.ChartAreas[0].AxisX.Interval = MAX5 / 5;
                    this.chart6.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart6.ChartAreas[0].AxisY.Maximum = MAX4;
                    this.chart6.ChartAreas[0].AxisY.Interval = MAX4 / 5;
                    this.chart6.Series[0].Points.AddXY(t5_1, t4_1);
                    this.chart6.Series[0].Points.AddXY(t5_2, t4_2);
                    this.chart6.Series[0].Points.AddXY(t5_3, t4_3);
                    this.chart6.Series[0].Points.AddXY(t5_4, t4_4);
                    this.chart6.Series[0].Points.AddXY(t5_5, t4_5);
                    this.chart6.Series[0].Points.AddXY(t5_6, t4_6);
                    this.chart6.Series[0].Points.AddXY(t5_7, t4_7);
                    this.chart6.Series[0].Points.AddXY(t5_8, t4_8);
                    this.chart6.Series[0].Points.AddXY(t5_9, t4_9);
                    this.chart6.Series[0].Points.AddXY(t5_10, t4_10);

                    this.chart7.ChartAreas[0].AxisX.Minimum = 0; // X - C    Y - Io
                    this.chart7.ChartAreas[0].AxisX.Maximum = MAX6;
                    this.chart7.ChartAreas[0].AxisX.Interval = MAX6 / 5;
                    this.chart7.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart7.ChartAreas[0].AxisY.Maximum = MAX3;
                    this.chart7.ChartAreas[0].AxisY.Interval = MAX3 / 5;
                    this.chart7.Series[0].Points.AddXY(t6_1, t3_1);
                    this.chart7.Series[0].Points.AddXY(t6_2, t3_2);
                    this.chart7.Series[0].Points.AddXY(t6_3, t3_3);
                    this.chart7.Series[0].Points.AddXY(t6_4, t3_4);
                    this.chart7.Series[0].Points.AddXY(t6_5, t3_5);
                    this.chart7.Series[0].Points.AddXY(t6_6, t3_6);
                    this.chart7.Series[0].Points.AddXY(t6_7, t3_7);
                    this.chart7.Series[0].Points.AddXY(t6_8, t3_8);
                    this.chart7.Series[0].Points.AddXY(t6_9, t3_9);
                    this.chart7.Series[0].Points.AddXY(t6_10, t3_10);

                    this.chart8.ChartAreas[0].AxisX.Minimum = 0; // X - C    Y - Uв
                    this.chart8.ChartAreas[0].AxisX.Maximum = MAX6;
                    this.chart8.ChartAreas[0].AxisX.Interval = MAX6 / 5;
                    this.chart8.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart8.ChartAreas[0].AxisY.Maximum = MAX4;
                    this.chart8.ChartAreas[0].AxisY.Interval = MAX4 / 5;
                    this.chart8.Series[0].Points.AddXY(t6_1, t4_1);
                    this.chart8.Series[0].Points.AddXY(t6_2, t4_2);
                    this.chart8.Series[0].Points.AddXY(t6_3, t4_3);
                    this.chart8.Series[0].Points.AddXY(t6_4, t4_4);
                    this.chart8.Series[0].Points.AddXY(t6_5, t4_5);
                    this.chart8.Series[0].Points.AddXY(t6_6, t4_6);
                    this.chart8.Series[0].Points.AddXY(t6_7, t4_7);
                    this.chart8.Series[0].Points.AddXY(t6_8, t4_8);
                    this.chart8.Series[0].Points.AddXY(t6_9, t4_9);
                    this.chart8.Series[0].Points.AddXY(t6_10, t4_10);

                    xxx += hhh;
                }
            }

            if (index == "4")
            {
                label3.Text = "Io";
                label4.Text = "Uв";
                label5.Text = "R";
                label6.Text = "C";
                label7.Text = "N посл.";
                label8.Text = "N пар.";

                Idop = Convert.ToDouble(textBox111.Text);
                Uobr = Convert.ToDouble(textBox112.Text);

                t1_1 = Convert.ToDouble(textBox1.Text);
                t1_2 = Convert.ToDouble(textBox2.Text);
                t1_3 = Convert.ToDouble(textBox3.Text);
                t1_4 = Convert.ToDouble(textBox4.Text);
                t1_5 = Convert.ToDouble(textBox5.Text);
                t1_6 = Convert.ToDouble(textBox6.Text);
                t1_7 = Convert.ToDouble(textBox7.Text);
                t1_8 = Convert.ToDouble(textBox8.Text);
                t1_9 = Convert.ToDouble(textBox9.Text);
                t1_10 = Convert.ToDouble(textBox10.Text);

                t2_1 = Convert.ToDouble(textBox11.Text);
                t2_2 = Convert.ToDouble(textBox12.Text);
                t2_3 = Convert.ToDouble(textBox13.Text);
                t2_4 = Convert.ToDouble(textBox14.Text);
                t2_5 = Convert.ToDouble(textBox15.Text);
                t2_6 = Convert.ToDouble(textBox16.Text);
                t2_7 = Convert.ToDouble(textBox17.Text);
                t2_8 = Convert.ToDouble(textBox18.Text);
                t2_9 = Convert.ToDouble(textBox19.Text);
                t2_10 = Convert.ToDouble(textBox20.Text);

                t3_1 = t2_1 / t1_1;
                t3_2 = t2_2 / t1_2;
                t3_3 = t2_3 / t1_3;
                t3_4 = t2_4 / t1_4;
                t3_5 = t2_5 / t1_5;
                t3_6 = t2_6 / t1_6;
                t3_7 = t2_7 / t1_7;
                t3_8 = t2_8 / t1_8;
                t3_9 = t2_9 / t1_9;
                t3_10 = t2_10 / t1_10;

                textBox21.Text = t3_1.ToString("0.##");
                textBox22.Text = t3_2.ToString("0.##");
                textBox23.Text = t3_3.ToString("0.##");
                textBox24.Text = t3_4.ToString("0.##");
                textBox25.Text = t3_5.ToString("0.##");
                textBox26.Text = t3_6.ToString("0.##");
                textBox27.Text = t3_7.ToString("0.##");
                textBox28.Text = t3_8.ToString("0.##");
                textBox29.Text = t3_9.ToString("0.##");
                textBox30.Text = t3_10.ToString("0.##");

                t4_1 = 1.41 * t1_1;
                t4_2 = 1.41 * t1_2;
                t4_3 = 1.41 * t1_3;
                t4_4 = 1.41 * t1_4;
                t4_5 = 1.41 * t1_5;
                t4_6 = 1.41 * t1_6;
                t4_7 = 1.41 * t1_7;
                t4_8 = 1.41 * t1_8;
                t4_9 = 1.41 * t1_9;
                t4_10 = 1.41 * t1_10;

                textBox31.Text = t4_1.ToString("0.##");
                textBox32.Text = t4_2.ToString("0.##");
                textBox33.Text = t4_3.ToString("0.##");
                textBox34.Text = t4_4.ToString("0.##");
                textBox35.Text = t4_5.ToString("0.##");
                textBox36.Text = t4_6.ToString("0.##");
                textBox37.Text = t4_7.ToString("0.##");
                textBox38.Text = t4_8.ToString("0.##");
                textBox39.Text = t4_9.ToString("0.##");
                textBox40.Text = t4_10.ToString("0.##");

                t5_1 = t1_1 / t3_1;
                t5_2 = t1_2 / t3_2;
                t5_3 = t1_3 / t3_3;
                t5_4 = t1_4 / t3_4;
                t5_5 = t1_5 / t3_5;
                t5_6 = t1_6 / t3_6;
                t5_7 = t1_7 / t3_7;
                t5_8 = t1_8 / t3_8;
                t5_9 = t1_9 / t3_9;
                t5_10 = t1_10 / t3_10;

                textBox41.Text = t5_1.ToString("0.##");
                textBox42.Text = t5_2.ToString("0.##");
                textBox43.Text = t5_3.ToString("0.##");
                textBox44.Text = t5_4.ToString("0.##");
                textBox45.Text = t5_5.ToString("0.##");
                textBox46.Text = t5_6.ToString("0.##");
                textBox47.Text = t5_7.ToString("0.##");
                textBox48.Text = t5_8.ToString("0.##");
                textBox49.Text = t5_9.ToString("0.##");
                textBox50.Text = t5_10.ToString("0.##");

                t6_1 = 3.14 * (t4_1 - t1_1) / 2 * t3_1;
                t6_2 = 3.14 * (t4_2 - t1_2) / 2 * t3_2;
                t6_3 = 3.14 * (t4_3 - t1_3) / 2 * t3_3;
                t6_4 = 3.14 * (t4_4 - t1_4) / 2 * t3_4;
                t6_5 = 3.14 * (t4_5 - t1_5) / 2 * t3_5;
                t6_6 = 3.14 * (t4_6 - t1_6) / 2 * t3_6;
                t6_7 = 3.14 * (t4_7 - t1_7) / 2 * t3_7;
                t6_8 = 3.14 * (t4_8 - t1_8) / 2 * t3_8;
                t6_9 = 3.14 * (t4_9 - t1_9) / 2 * t3_9;
                t6_10 = 3.14 * (t4_10 - t1_10) / 2 * t3_10;

                textBox51.Text = t6_1.ToString("0.##");
                textBox52.Text = t6_2.ToString("0.##");
                textBox53.Text = t6_3.ToString("0.##");
                textBox54.Text = t6_4.ToString("0.##");
                textBox55.Text = t6_5.ToString("0.##");
                textBox56.Text = t6_6.ToString("0.##");
                textBox57.Text = t6_7.ToString("0.##");
                textBox58.Text = t6_8.ToString("0.##");
                textBox59.Text = t6_9.ToString("0.##");
                textBox60.Text = t6_10.ToString("0.##");

                t7_1 = t4_1 / Uobr;
                int T7_1 = Convert.ToInt32(Math.Ceiling(t7_1));
                t7_2 = t4_2 / Uobr;
                int T7_2 = Convert.ToInt32(Math.Ceiling(t7_2));
                t7_3 = t4_3 / Uobr;
                int T7_3 = Convert.ToInt32(Math.Ceiling(t7_3));
                t7_4 = t4_4 / Uobr;
                int T7_4 = Convert.ToInt32(Math.Ceiling(t7_4));
                t7_5 = t4_5 / Uobr;
                int T7_5 = Convert.ToInt32(Math.Ceiling(t7_5));
                t7_6 = t4_6 / Uobr;
                int T7_6 = Convert.ToInt32(Math.Ceiling(t7_6));
                t7_7 = t4_7 / Uobr;
                int T7_7 = Convert.ToInt32(Math.Ceiling(t7_7));
                t7_8 = t4_8 / Uobr;
                int T7_8 = Convert.ToInt32(Math.Ceiling(t7_8));
                t7_9 = t4_9 / Uobr;
                int T7_9 = Convert.ToInt32(Math.Ceiling(t7_9));
                t7_10 = t4_10 / Uobr;
                int T7_10 = Convert.ToInt32(Math.Ceiling(t7_10));

                textBox61.Text = T7_1.ToString("0.##");
                textBox62.Text = T7_2.ToString("0.##");
                textBox63.Text = T7_3.ToString("0.##");
                textBox64.Text = T7_4.ToString("0.##");
                textBox65.Text = T7_5.ToString("0.##");
                textBox66.Text = T7_6.ToString("0.##");
                textBox67.Text = T7_7.ToString("0.##");
                textBox68.Text = T7_8.ToString("0.##");
                textBox69.Text = T7_9.ToString("0.##");
                textBox70.Text = T7_10.ToString("0.##");

                t8_1 = t3_1 / Idop;
                int T8_1 = Convert.ToInt32(Math.Ceiling(t8_1));
                t8_2 = t3_2 / Idop;
                int T8_2 = Convert.ToInt32(Math.Ceiling(t8_2));
                t8_3 = t3_3 / Idop;
                int T8_3 = Convert.ToInt32(Math.Ceiling(t8_3));
                t8_4 = t3_4 / Idop;
                int T8_4 = Convert.ToInt32(Math.Ceiling(t8_4));
                t8_5 = t3_5 / Idop;
                int T8_5 = Convert.ToInt32(Math.Ceiling(t8_5));
                t8_6 = t3_6 / Idop;
                int T8_6 = Convert.ToInt32(Math.Ceiling(t8_6));
                t8_7 = t3_7 / Idop;
                int T8_7 = Convert.ToInt32(Math.Ceiling(t8_7));
                t8_8 = t3_8 / Idop;
                int T8_8 = Convert.ToInt32(Math.Ceiling(t8_8));
                t8_9 = t3_9 / Idop;
                int T8_9 = Convert.ToInt32(Math.Ceiling(t8_9));
                t8_10 = t3_10 / Idop;
                int T8_10 = Convert.ToInt32(Math.Ceiling(t8_10));

                textBox71.Text = T8_1.ToString("0.##");
                textBox72.Text = T8_2.ToString("0.##");
                textBox73.Text = T8_3.ToString("0.##");
                textBox74.Text = T8_4.ToString("0.##");
                textBox75.Text = T8_5.ToString("0.##");
                textBox76.Text = T8_6.ToString("0.##");
                textBox77.Text = T8_7.ToString("0.##");
                textBox78.Text = T8_8.ToString("0.##");
                textBox79.Text = T8_9.ToString("0.##");
                textBox80.Text = T8_10.ToString("0.##");

                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                textBox21.Visible = true;
                textBox22.Visible = true;
                textBox23.Visible = true;
                textBox24.Visible = true;
                textBox25.Visible = true;
                textBox26.Visible = true;
                textBox27.Visible = true;
                textBox28.Visible = true;
                textBox29.Visible = true;
                textBox30.Visible = true;
                textBox31.Visible = true;
                textBox32.Visible = true;
                textBox33.Visible = true;
                textBox34.Visible = true;
                textBox35.Visible = true;
                textBox36.Visible = true;
                textBox37.Visible = true;
                textBox38.Visible = true;
                textBox39.Visible = true;
                textBox40.Visible = true;
                textBox41.Visible = true;
                textBox42.Visible = true;
                textBox43.Visible = true;
                textBox44.Visible = true;
                textBox45.Visible = true;
                textBox46.Visible = true;
                textBox47.Visible = true;
                textBox48.Visible = true;
                textBox49.Visible = true;
                textBox50.Visible = true;
                textBox51.Visible = true;
                textBox52.Visible = true;
                textBox53.Visible = true;
                textBox54.Visible = true;
                textBox55.Visible = true;
                textBox56.Visible = true;
                textBox57.Visible = true;
                textBox58.Visible = true;
                textBox59.Visible = true;
                textBox60.Visible = true;
                textBox61.Visible = true;
                textBox62.Visible = true;
                textBox63.Visible = true;
                textBox64.Visible = true;
                textBox65.Visible = true;
                textBox66.Visible = true;
                textBox67.Visible = true;
                textBox68.Visible = true;
                textBox69.Visible = true;
                textBox70.Visible = true;
                textBox71.Visible = true;
                textBox72.Visible = true;
                textBox73.Visible = true;
                textBox74.Visible = true;
                textBox75.Visible = true;
                textBox76.Visible = true;
                textBox77.Visible = true;
                textBox78.Visible = true;
                textBox79.Visible = true;
                textBox80.Visible = true;
                textBox81.Visible = false;
                textBox82.Visible = false;
                textBox83.Visible = false;
                textBox84.Visible = false;
                textBox85.Visible = false;
                textBox86.Visible = false;
                textBox87.Visible = false;
                textBox88.Visible = false;
                textBox89.Visible = false;
                textBox90.Visible = false;
                textBox91.Visible = false;
                textBox92.Visible = false;
                textBox93.Visible = false;
                textBox94.Visible = false;
                textBox95.Visible = false;
                textBox96.Visible = false;
                textBox97.Visible = false;
                textBox98.Visible = false;
                textBox99.Visible = false;
                textBox100.Visible = false;
                textBox101.Visible = false;
                textBox102.Visible = false;
                textBox103.Visible = false;
                textBox104.Visible = false;
                textBox105.Visible = false;
                textBox106.Visible = false;
                textBox107.Visible = false;
                textBox108.Visible = false;
                textBox109.Visible = false;
                textBox110.Visible = false;
                chart1.Visible = true;
                chart2.Visible = true;
                chart3.Visible = true;
                chart4.Visible = true;
                chart5.Visible = true;
                chart6.Visible = true;
                chart7.Visible = true;
                chart8.Visible = true;

                double aaa, bbb, hhh, xxx, max2, max3, max4, max5, max6, MAX2, MAX3, MAX4, MAX5, MAX6;
                aaa = 0.01;
                bbb = 0.01;
                hhh = 0.01;
                xxx = aaa;
                this.chart1.Series[0].Points.Clear();
                this.chart2.Series[0].Points.Clear();
                this.chart3.Series[0].Points.Clear();
                this.chart4.Series[0].Points.Clear();
                this.chart5.Series[0].Points.Clear();
                this.chart6.Series[0].Points.Clear();
                this.chart7.Series[0].Points.Clear();
                this.chart8.Series[0].Points.Clear();
                this.chart1.ChartAreas[0].AxisX.Title = "Po(Uв)";
                this.chart2.ChartAreas[0].AxisX.Title = "Po(Io)";
                this.chart3.ChartAreas[0].AxisX.Title = "Po(R)";
                this.chart4.ChartAreas[0].AxisX.Title = "Io(Uв)";
                this.chart5.ChartAreas[0].AxisX.Title = "Io(R)";
                this.chart6.ChartAreas[0].AxisX.Title = "Uв(R)";
                this.chart7.ChartAreas[0].AxisX.Title = "Io(C)";
                this.chart8.ChartAreas[0].AxisX.Title = "Uв(C)";

                max2 = Math.Max(Math.Max(Math.Max(Math.Max(t2_1, t2_2), Math.Max(t2_3, t2_4)), Math.Max(Math.Max(t2_5, t2_6), Math.Max(t2_7, t2_8))), Math.Max(t2_9, t2_10));
                max3 = Math.Max(Math.Max(Math.Max(Math.Max(t3_1, t3_2), Math.Max(t3_3, t3_4)), Math.Max(Math.Max(t3_5, t3_6), Math.Max(t3_7, t3_8))), Math.Max(t3_9, t3_10));
                max4 = Math.Max(Math.Max(Math.Max(Math.Max(t4_1, t4_2), Math.Max(t4_3, t4_4)), Math.Max(Math.Max(t4_5, t4_6), Math.Max(t4_7, t4_8))), Math.Max(t4_9, t4_10));
                max5 = Math.Max(Math.Max(Math.Max(Math.Max(t5_1, t5_2), Math.Max(t5_3, t5_4)), Math.Max(Math.Max(t5_5, t5_6), Math.Max(t5_7, t5_8))), Math.Max(t5_9, t5_10));
                max6 = Math.Max(Math.Max(Math.Max(Math.Max(t6_1, t6_2), Math.Max(t6_3, t6_4)), Math.Max(Math.Max(t6_5, t6_6), Math.Max(t6_7, t6_8))), Math.Max(t6_9, t6_10));

                MAX2 = ((int)((max2 + 150) / 100)) * 100;
                MAX3 = ((int)((max3 + 10) / 10)) * 10;
                MAX4 = ((int)((max4 + 150) / 100)) * 100;
                MAX5 = ((int)((max5 + 20) / 10)) * 10;
                MAX6 = ((int)((max6 + 150) / 100)) * 100;

                while (xxx <= bbb)
                {
                    this.chart1.ChartAreas[0].AxisX.Minimum = 0; // X - Uв    Y - Po
                    this.chart1.ChartAreas[0].AxisX.Maximum = MAX4;
                    this.chart1.ChartAreas[0].AxisX.Interval = MAX4 / 5;
                    this.chart1.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart1.ChartAreas[0].AxisY.Maximum = MAX2;
                    this.chart1.ChartAreas[0].AxisY.Interval = MAX2 / 5;
                    this.chart1.Series[0].Points.AddXY(t4_1, t2_1);
                    this.chart1.Series[0].Points.AddXY(t4_2, t2_2);
                    this.chart1.Series[0].Points.AddXY(t4_3, t2_3);
                    this.chart1.Series[0].Points.AddXY(t4_4, t2_4);
                    this.chart1.Series[0].Points.AddXY(t4_5, t2_5);
                    this.chart1.Series[0].Points.AddXY(t4_6, t2_6);
                    this.chart1.Series[0].Points.AddXY(t4_7, t2_7);
                    this.chart1.Series[0].Points.AddXY(t4_8, t2_8);
                    this.chart1.Series[0].Points.AddXY(t4_9, t2_9);
                    this.chart1.Series[0].Points.AddXY(t4_10, t2_10);

                    this.chart2.ChartAreas[0].AxisX.Minimum = 0; // X - Io    Y - Po
                    this.chart2.ChartAreas[0].AxisX.Maximum = MAX3;
                    this.chart2.ChartAreas[0].AxisX.Interval = MAX3 / 5;
                    this.chart2.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart2.ChartAreas[0].AxisY.Maximum = MAX2;
                    this.chart2.ChartAreas[0].AxisY.Interval = MAX2 / 5;
                    this.chart2.Series[0].Points.AddXY(t3_1, t2_1);
                    this.chart2.Series[0].Points.AddXY(t3_2, t2_2);
                    this.chart2.Series[0].Points.AddXY(t3_3, t2_3);
                    this.chart2.Series[0].Points.AddXY(t3_4, t2_4);
                    this.chart2.Series[0].Points.AddXY(t3_5, t2_5);
                    this.chart2.Series[0].Points.AddXY(t3_6, t2_6);
                    this.chart2.Series[0].Points.AddXY(t3_7, t2_7);
                    this.chart2.Series[0].Points.AddXY(t3_8, t2_8);
                    this.chart2.Series[0].Points.AddXY(t3_9, t2_9);
                    this.chart2.Series[0].Points.AddXY(t3_10, t2_10);

                    this.chart3.ChartAreas[0].AxisX.Minimum = 0; // X - R    Y - Po
                    this.chart3.ChartAreas[0].AxisX.Maximum = MAX5;
                    this.chart3.ChartAreas[0].AxisX.Interval = MAX5 / 5;
                    this.chart3.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart3.ChartAreas[0].AxisY.Maximum = MAX2;
                    this.chart3.ChartAreas[0].AxisY.Interval = MAX2 / 5;
                    this.chart3.Series[0].Points.AddXY(t5_1, t2_1);
                    this.chart3.Series[0].Points.AddXY(t5_2, t2_2);
                    this.chart3.Series[0].Points.AddXY(t5_3, t2_3);
                    this.chart3.Series[0].Points.AddXY(t5_4, t2_4);
                    this.chart3.Series[0].Points.AddXY(t5_5, t2_5);
                    this.chart3.Series[0].Points.AddXY(t5_6, t2_6);
                    this.chart3.Series[0].Points.AddXY(t5_7, t2_7);
                    this.chart3.Series[0].Points.AddXY(t5_8, t2_8);
                    this.chart3.Series[0].Points.AddXY(t5_9, t2_9);
                    this.chart3.Series[0].Points.AddXY(t5_10, t2_10);

                    this.chart4.ChartAreas[0].AxisX.Minimum = 0; // X - Uв    Y - Io
                    this.chart4.ChartAreas[0].AxisX.Maximum = MAX4;
                    this.chart4.ChartAreas[0].AxisX.Interval = MAX4 / 5;
                    this.chart4.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart4.ChartAreas[0].AxisY.Maximum = MAX3;
                    this.chart4.ChartAreas[0].AxisY.Interval = MAX3 / 5;
                    this.chart4.Series[0].Points.AddXY(t4_1, t3_1);
                    this.chart4.Series[0].Points.AddXY(t4_2, t3_2);
                    this.chart4.Series[0].Points.AddXY(t4_3, t3_3);
                    this.chart4.Series[0].Points.AddXY(t4_4, t3_4);
                    this.chart4.Series[0].Points.AddXY(t4_5, t3_5);
                    this.chart4.Series[0].Points.AddXY(t4_6, t3_6);
                    this.chart4.Series[0].Points.AddXY(t4_7, t3_7);
                    this.chart4.Series[0].Points.AddXY(t4_8, t3_8);
                    this.chart4.Series[0].Points.AddXY(t4_9, t3_9);
                    this.chart4.Series[0].Points.AddXY(t4_10, t3_10);

                    this.chart5.ChartAreas[0].AxisX.Minimum = 0; // X - R    Y - Io
                    this.chart5.ChartAreas[0].AxisX.Maximum = MAX5;
                    this.chart5.ChartAreas[0].AxisX.Interval = MAX5 / 5;
                    this.chart5.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart5.ChartAreas[0].AxisY.Maximum = MAX3;
                    this.chart5.ChartAreas[0].AxisY.Interval = MAX3 / 5;
                    this.chart5.Series[0].Points.AddXY(t5_1, t3_1);
                    this.chart5.Series[0].Points.AddXY(t5_2, t3_2);
                    this.chart5.Series[0].Points.AddXY(t5_3, t3_3);
                    this.chart5.Series[0].Points.AddXY(t5_4, t3_4);
                    this.chart5.Series[0].Points.AddXY(t5_5, t3_5);
                    this.chart5.Series[0].Points.AddXY(t5_6, t3_6);
                    this.chart5.Series[0].Points.AddXY(t5_7, t3_7);
                    this.chart5.Series[0].Points.AddXY(t5_8, t3_8);
                    this.chart5.Series[0].Points.AddXY(t5_9, t3_9);
                    this.chart5.Series[0].Points.AddXY(t5_10, t3_10);

                    this.chart6.ChartAreas[0].AxisX.Minimum = 0; // X - R    Y - Uв
                    this.chart6.ChartAreas[0].AxisX.Maximum = MAX5;
                    this.chart6.ChartAreas[0].AxisX.Interval = MAX5 / 5;
                    this.chart6.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart6.ChartAreas[0].AxisY.Maximum = MAX4;
                    this.chart6.ChartAreas[0].AxisY.Interval = MAX4 / 5;
                    this.chart6.Series[0].Points.AddXY(t5_1, t4_1);
                    this.chart6.Series[0].Points.AddXY(t5_2, t4_2);
                    this.chart6.Series[0].Points.AddXY(t5_3, t4_3);
                    this.chart6.Series[0].Points.AddXY(t5_4, t4_4);
                    this.chart6.Series[0].Points.AddXY(t5_5, t4_5);
                    this.chart6.Series[0].Points.AddXY(t5_6, t4_6);
                    this.chart6.Series[0].Points.AddXY(t5_7, t4_7);
                    this.chart6.Series[0].Points.AddXY(t5_8, t4_8);
                    this.chart6.Series[0].Points.AddXY(t5_9, t4_9);
                    this.chart6.Series[0].Points.AddXY(t5_10, t4_10);

                    this.chart7.ChartAreas[0].AxisX.Minimum = 0; // X - C    Y - Io
                    this.chart7.ChartAreas[0].AxisX.Maximum = MAX6;
                    this.chart7.ChartAreas[0].AxisX.Interval = MAX6 / 5;
                    this.chart7.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart7.ChartAreas[0].AxisY.Maximum = MAX3;
                    this.chart7.ChartAreas[0].AxisY.Interval = MAX3 / 5;
                    this.chart7.Series[0].Points.AddXY(t6_1, t3_1);
                    this.chart7.Series[0].Points.AddXY(t6_2, t3_2);
                    this.chart7.Series[0].Points.AddXY(t6_3, t3_3);
                    this.chart7.Series[0].Points.AddXY(t6_4, t3_4);
                    this.chart7.Series[0].Points.AddXY(t6_5, t3_5);
                    this.chart7.Series[0].Points.AddXY(t6_6, t3_6);
                    this.chart7.Series[0].Points.AddXY(t6_7, t3_7);
                    this.chart7.Series[0].Points.AddXY(t6_8, t3_8);
                    this.chart7.Series[0].Points.AddXY(t6_9, t3_9);
                    this.chart7.Series[0].Points.AddXY(t6_10, t3_10);

                    this.chart8.ChartAreas[0].AxisX.Minimum = 0; // X - C    Y - Uв
                    this.chart8.ChartAreas[0].AxisX.Maximum = MAX6;
                    this.chart8.ChartAreas[0].AxisX.Interval = MAX6 / 5;
                    this.chart8.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart8.ChartAreas[0].AxisY.Maximum = MAX4;
                    this.chart8.ChartAreas[0].AxisY.Interval = MAX4 / 5;
                    this.chart8.Series[0].Points.AddXY(t6_1, t4_1);
                    this.chart8.Series[0].Points.AddXY(t6_2, t4_2);
                    this.chart8.Series[0].Points.AddXY(t6_3, t4_3);
                    this.chart8.Series[0].Points.AddXY(t6_4, t4_4);
                    this.chart8.Series[0].Points.AddXY(t6_5, t4_5);
                    this.chart8.Series[0].Points.AddXY(t6_6, t4_6);
                    this.chart8.Series[0].Points.AddXY(t6_7, t4_7);
                    this.chart8.Series[0].Points.AddXY(t6_8, t4_8);
                    this.chart8.Series[0].Points.AddXY(t6_9, t4_9);
                    this.chart8.Series[0].Points.AddXY(t6_10, t4_10);

                    xxx += hhh;
                }
            }

            if (index == "5")
            {
                label3.Text = "Io";
                label4.Text = "Uв";
                label5.Text = "R";
                label6.Text = "C";
                label7.Text = "N посл.";
                label8.Text = "N пар.";

                Idop = Convert.ToDouble(textBox111.Text);
                Uobr = Convert.ToDouble(textBox112.Text);

                t1_1 = Convert.ToDouble(textBox1.Text);
                t1_2 = Convert.ToDouble(textBox2.Text);
                t1_3 = Convert.ToDouble(textBox3.Text);
                t1_4 = Convert.ToDouble(textBox4.Text);
                t1_5 = Convert.ToDouble(textBox5.Text);
                t1_6 = Convert.ToDouble(textBox6.Text);
                t1_7 = Convert.ToDouble(textBox7.Text);
                t1_8 = Convert.ToDouble(textBox8.Text);
                t1_9 = Convert.ToDouble(textBox9.Text);
                t1_10 = Convert.ToDouble(textBox10.Text);

                t2_1 = Convert.ToDouble(textBox11.Text);
                t2_2 = Convert.ToDouble(textBox12.Text);
                t2_3 = Convert.ToDouble(textBox13.Text);
                t2_4 = Convert.ToDouble(textBox14.Text);
                t2_5 = Convert.ToDouble(textBox15.Text);
                t2_6 = Convert.ToDouble(textBox16.Text);
                t2_7 = Convert.ToDouble(textBox17.Text);
                t2_8 = Convert.ToDouble(textBox18.Text);
                t2_9 = Convert.ToDouble(textBox19.Text);
                t2_10 = Convert.ToDouble(textBox20.Text);

                t3_1 = t2_1 / t1_1;
                t3_2 = t2_2 / t1_2;
                t3_3 = t2_3 / t1_3;
                t3_4 = t2_4 / t1_4;
                t3_5 = t2_5 / t1_5;
                t3_6 = t2_6 / t1_6;
                t3_7 = t2_7 / t1_7;
                t3_8 = t2_8 / t1_8;
                t3_9 = t2_9 / t1_9;
                t3_10 = t2_10 / t1_10;

                textBox21.Text = t3_1.ToString("0.##");
                textBox22.Text = t3_2.ToString("0.##");
                textBox23.Text = t3_3.ToString("0.##");
                textBox24.Text = t3_4.ToString("0.##");
                textBox25.Text = t3_5.ToString("0.##");
                textBox26.Text = t3_6.ToString("0.##");
                textBox27.Text = t3_7.ToString("0.##");
                textBox28.Text = t3_8.ToString("0.##");
                textBox29.Text = t3_9.ToString("0.##");
                textBox30.Text = t3_10.ToString("0.##");

                t4_1 = Math.Sqrt(3) * t1_1;
                t4_2 = Math.Sqrt(3) * t1_2;
                t4_3 = Math.Sqrt(3) * t1_3;
                t4_4 = Math.Sqrt(3) * t1_4;
                t4_5 = Math.Sqrt(3) * t1_5;
                t4_6 = Math.Sqrt(3) * t1_6;
                t4_7 = Math.Sqrt(3) * t1_7;
                t4_8 = Math.Sqrt(3) * t1_8;
                t4_9 = Math.Sqrt(3) * t1_9;
                t4_10 = Math.Sqrt(3) * t1_10;

                textBox31.Text = t4_1.ToString("0.##");
                textBox32.Text = t4_2.ToString("0.##");
                textBox33.Text = t4_3.ToString("0.##");
                textBox34.Text = t4_4.ToString("0.##");
                textBox35.Text = t4_5.ToString("0.##");
                textBox36.Text = t4_6.ToString("0.##");
                textBox37.Text = t4_7.ToString("0.##");
                textBox38.Text = t4_8.ToString("0.##");
                textBox39.Text = t4_9.ToString("0.##");
                textBox40.Text = t4_10.ToString("0.##");

                t5_1 = t1_1 / t3_1;
                t5_2 = t1_2 / t3_2;
                t5_3 = t1_3 / t3_3;
                t5_4 = t1_4 / t3_4;
                t5_5 = t1_5 / t3_5;
                t5_6 = t1_6 / t3_6;
                t5_7 = t1_7 / t3_7;
                t5_8 = t1_8 / t3_8;
                t5_9 = t1_9 / t3_9;
                t5_10 = t1_10 / t3_10;

                textBox41.Text = t5_1.ToString("0.##");
                textBox42.Text = t5_2.ToString("0.##");
                textBox43.Text = t5_3.ToString("0.##");
                textBox44.Text = t5_4.ToString("0.##");
                textBox45.Text = t5_5.ToString("0.##");
                textBox46.Text = t5_6.ToString("0.##");
                textBox47.Text = t5_7.ToString("0.##");
                textBox48.Text = t5_8.ToString("0.##");
                textBox49.Text = t5_9.ToString("0.##");
                textBox50.Text = t5_10.ToString("0.##");

                t6_1 = 3.14 * (t4_1 - t1_1) / 2 * t3_1;
                t6_2 = 3.14 * (t4_2 - t1_2) / 2 * t3_2;
                t6_3 = 3.14 * (t4_3 - t1_3) / 2 * t3_3;
                t6_4 = 3.14 * (t4_4 - t1_4) / 2 * t3_4;
                t6_5 = 3.14 * (t4_5 - t1_5) / 2 * t3_5;
                t6_6 = 3.14 * (t4_6 - t1_6) / 2 * t3_6;
                t6_7 = 3.14 * (t4_7 - t1_7) / 2 * t3_7;
                t6_8 = 3.14 * (t4_8 - t1_8) / 2 * t3_8;
                t6_9 = 3.14 * (t4_9 - t1_9) / 2 * t3_9;
                t6_10 = 3.14 * (t4_10 - t1_10) / 2 * t3_10;

                textBox51.Text = t6_1.ToString("0.##");
                textBox52.Text = t6_2.ToString("0.##");
                textBox53.Text = t6_3.ToString("0.##");
                textBox54.Text = t6_4.ToString("0.##");
                textBox55.Text = t6_5.ToString("0.##");
                textBox56.Text = t6_6.ToString("0.##");
                textBox57.Text = t6_7.ToString("0.##");
                textBox58.Text = t6_8.ToString("0.##");
                textBox59.Text = t6_9.ToString("0.##");
                textBox60.Text = t6_10.ToString("0.##");

                t7_1 = t4_1 / Uobr;
                int T7_1 = Convert.ToInt32(Math.Ceiling(t7_1));
                t7_2 = t4_2 / Uobr;
                int T7_2 = Convert.ToInt32(Math.Ceiling(t7_2));
                t7_3 = t4_3 / Uobr;
                int T7_3 = Convert.ToInt32(Math.Ceiling(t7_3));
                t7_4 = t4_4 / Uobr;
                int T7_4 = Convert.ToInt32(Math.Ceiling(t7_4));
                t7_5 = t4_5 / Uobr;
                int T7_5 = Convert.ToInt32(Math.Ceiling(t7_5));
                t7_6 = t4_6 / Uobr;
                int T7_6 = Convert.ToInt32(Math.Ceiling(t7_6));
                t7_7 = t4_7 / Uobr;
                int T7_7 = Convert.ToInt32(Math.Ceiling(t7_7));
                t7_8 = t4_8 / Uobr;
                int T7_8 = Convert.ToInt32(Math.Ceiling(t7_8));
                t7_9 = t4_9 / Uobr;
                int T7_9 = Convert.ToInt32(Math.Ceiling(t7_9));
                t7_10 = t4_10 / Uobr;
                int T7_10 = Convert.ToInt32(Math.Ceiling(t7_10));

                textBox61.Text = T7_1.ToString("0.##");
                textBox62.Text = T7_2.ToString("0.##");
                textBox63.Text = T7_3.ToString("0.##");
                textBox64.Text = T7_4.ToString("0.##");
                textBox65.Text = T7_5.ToString("0.##");
                textBox66.Text = T7_6.ToString("0.##");
                textBox67.Text = T7_7.ToString("0.##");
                textBox68.Text = T7_8.ToString("0.##");
                textBox69.Text = T7_9.ToString("0.##");
                textBox70.Text = T7_10.ToString("0.##");

                t8_1 = t3_1 / Idop;
                int T8_1 = Convert.ToInt32(Math.Ceiling(t8_1));
                t8_2 = t3_2 / Idop;
                int T8_2 = Convert.ToInt32(Math.Ceiling(t8_2));
                t8_3 = t3_3 / Idop;
                int T8_3 = Convert.ToInt32(Math.Ceiling(t8_3));
                t8_4 = t3_4 / Idop;
                int T8_4 = Convert.ToInt32(Math.Ceiling(t8_4));
                t8_5 = t3_5 / Idop;
                int T8_5 = Convert.ToInt32(Math.Ceiling(t8_5));
                t8_6 = t3_6 / Idop;
                int T8_6 = Convert.ToInt32(Math.Ceiling(t8_6));
                t8_7 = t3_7 / Idop;
                int T8_7 = Convert.ToInt32(Math.Ceiling(t8_7));
                t8_8 = t3_8 / Idop;
                int T8_8 = Convert.ToInt32(Math.Ceiling(t8_8));
                t8_9 = t3_9 / Idop;
                int T8_9 = Convert.ToInt32(Math.Ceiling(t8_9));
                t8_10 = t3_10 / Idop;
                int T8_10 = Convert.ToInt32(Math.Ceiling(t8_10));

                textBox71.Text = T8_1.ToString("0.##");
                textBox72.Text = T8_2.ToString("0.##");
                textBox73.Text = T8_3.ToString("0.##");
                textBox74.Text = T8_4.ToString("0.##");
                textBox75.Text = T8_5.ToString("0.##");
                textBox76.Text = T8_6.ToString("0.##");
                textBox77.Text = T8_7.ToString("0.##");
                textBox78.Text = T8_8.ToString("0.##");
                textBox79.Text = T8_9.ToString("0.##");
                textBox80.Text = T8_10.ToString("0.##");

                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                textBox21.Visible = true;
                textBox22.Visible = true;
                textBox23.Visible = true;
                textBox24.Visible = true;
                textBox25.Visible = true;
                textBox26.Visible = true;
                textBox27.Visible = true;
                textBox28.Visible = true;
                textBox29.Visible = true;
                textBox30.Visible = true;
                textBox31.Visible = true;
                textBox32.Visible = true;
                textBox33.Visible = true;
                textBox34.Visible = true;
                textBox35.Visible = true;
                textBox36.Visible = true;
                textBox37.Visible = true;
                textBox38.Visible = true;
                textBox39.Visible = true;
                textBox40.Visible = true;
                textBox41.Visible = true;
                textBox42.Visible = true;
                textBox43.Visible = true;
                textBox44.Visible = true;
                textBox45.Visible = true;
                textBox46.Visible = true;
                textBox47.Visible = true;
                textBox48.Visible = true;
                textBox49.Visible = true;
                textBox50.Visible = true;
                textBox51.Visible = true;
                textBox52.Visible = true;
                textBox53.Visible = true;
                textBox54.Visible = true;
                textBox55.Visible = true;
                textBox56.Visible = true;
                textBox57.Visible = true;
                textBox58.Visible = true;
                textBox59.Visible = true;
                textBox60.Visible = true;
                textBox61.Visible = true;
                textBox62.Visible = true;
                textBox63.Visible = true;
                textBox64.Visible = true;
                textBox65.Visible = true;
                textBox66.Visible = true;
                textBox67.Visible = true;
                textBox68.Visible = true;
                textBox69.Visible = true;
                textBox70.Visible = true;
                textBox71.Visible = true;
                textBox72.Visible = true;
                textBox73.Visible = true;
                textBox74.Visible = true;
                textBox75.Visible = true;
                textBox76.Visible = true;
                textBox77.Visible = true;
                textBox78.Visible = true;
                textBox79.Visible = true;
                textBox80.Visible = true;
                textBox81.Visible = false;
                textBox82.Visible = false;
                textBox83.Visible = false;
                textBox84.Visible = false;
                textBox85.Visible = false;
                textBox86.Visible = false;
                textBox87.Visible = false;
                textBox88.Visible = false;
                textBox89.Visible = false;
                textBox90.Visible = false;
                textBox91.Visible = false;
                textBox92.Visible = false;
                textBox93.Visible = false;
                textBox94.Visible = false;
                textBox95.Visible = false;
                textBox96.Visible = false;
                textBox97.Visible = false;
                textBox98.Visible = false;
                textBox99.Visible = false;
                textBox100.Visible = false;
                textBox101.Visible = false;
                textBox102.Visible = false;
                textBox103.Visible = false;
                textBox104.Visible = false;
                textBox105.Visible = false;
                textBox106.Visible = false;
                textBox107.Visible = false;
                textBox108.Visible = false;
                textBox109.Visible = false;
                textBox110.Visible = false;
                chart1.Visible = true;
                chart2.Visible = true;
                chart3.Visible = true;
                chart4.Visible = true;
                chart5.Visible = true;
                chart6.Visible = true;
                chart7.Visible = true;
                chart8.Visible = true;

                double aaa, bbb, hhh, xxx, max2, max3, max4, max5, max6, MAX2, MAX3, MAX4, MAX5, MAX6;
                aaa = 0.01;
                bbb = 0.01;
                hhh = 0.01;
                xxx = aaa;
                this.chart1.Series[0].Points.Clear();
                this.chart2.Series[0].Points.Clear();
                this.chart3.Series[0].Points.Clear();
                this.chart4.Series[0].Points.Clear();
                this.chart5.Series[0].Points.Clear();
                this.chart6.Series[0].Points.Clear();
                this.chart7.Series[0].Points.Clear();
                this.chart8.Series[0].Points.Clear();
                this.chart1.ChartAreas[0].AxisX.Title = "Po(Uв)";
                this.chart2.ChartAreas[0].AxisX.Title = "Po(Io)";
                this.chart3.ChartAreas[0].AxisX.Title = "Po(R)";
                this.chart4.ChartAreas[0].AxisX.Title = "Io(Uв)";
                this.chart5.ChartAreas[0].AxisX.Title = "Io(R)";
                this.chart6.ChartAreas[0].AxisX.Title = "Uв(R)";
                this.chart7.ChartAreas[0].AxisX.Title = "Io(C)";
                this.chart8.ChartAreas[0].AxisX.Title = "Uв(C)";

                max2 = Math.Max(Math.Max(Math.Max(Math.Max(t2_1, t2_2), Math.Max(t2_3, t2_4)), Math.Max(Math.Max(t2_5, t2_6), Math.Max(t2_7, t2_8))), Math.Max(t2_9, t2_10));
                max3 = Math.Max(Math.Max(Math.Max(Math.Max(t3_1, t3_2), Math.Max(t3_3, t3_4)), Math.Max(Math.Max(t3_5, t3_6), Math.Max(t3_7, t3_8))), Math.Max(t3_9, t3_10));
                max4 = Math.Max(Math.Max(Math.Max(Math.Max(t4_1, t4_2), Math.Max(t4_3, t4_4)), Math.Max(Math.Max(t4_5, t4_6), Math.Max(t4_7, t4_8))), Math.Max(t4_9, t4_10));
                max5 = Math.Max(Math.Max(Math.Max(Math.Max(t5_1, t5_2), Math.Max(t5_3, t5_4)), Math.Max(Math.Max(t5_5, t5_6), Math.Max(t5_7, t5_8))), Math.Max(t5_9, t5_10));
                max6 = Math.Max(Math.Max(Math.Max(Math.Max(t6_1, t6_2), Math.Max(t6_3, t6_4)), Math.Max(Math.Max(t6_5, t6_6), Math.Max(t6_7, t6_8))), Math.Max(t6_9, t6_10));

                MAX2 = ((int)((max2 + 150) / 100)) * 100;
                MAX3 = ((int)((max3 + 10) / 10)) * 10;
                MAX4 = ((int)((max4 + 150) / 100)) * 100;
                MAX5 = ((int)((max5 + 20) / 10)) * 10;
                MAX6 = ((int)((max6 + 150) / 100)) * 100;

                while (xxx <= bbb)
                {
                    this.chart1.ChartAreas[0].AxisX.Minimum = 0; // X - Uв    Y - Po
                    this.chart1.ChartAreas[0].AxisX.Maximum = MAX4;
                    this.chart1.ChartAreas[0].AxisX.Interval = MAX4 / 5;
                    this.chart1.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart1.ChartAreas[0].AxisY.Maximum = MAX2;
                    this.chart1.ChartAreas[0].AxisY.Interval = MAX2 / 5;
                    this.chart1.Series[0].Points.AddXY(t4_1, t2_1);
                    this.chart1.Series[0].Points.AddXY(t4_2, t2_2);
                    this.chart1.Series[0].Points.AddXY(t4_3, t2_3);
                    this.chart1.Series[0].Points.AddXY(t4_4, t2_4);
                    this.chart1.Series[0].Points.AddXY(t4_5, t2_5);
                    this.chart1.Series[0].Points.AddXY(t4_6, t2_6);
                    this.chart1.Series[0].Points.AddXY(t4_7, t2_7);
                    this.chart1.Series[0].Points.AddXY(t4_8, t2_8);
                    this.chart1.Series[0].Points.AddXY(t4_9, t2_9);
                    this.chart1.Series[0].Points.AddXY(t4_10, t2_10);

                    this.chart2.ChartAreas[0].AxisX.Minimum = 0; // X - Io    Y - Po
                    this.chart2.ChartAreas[0].AxisX.Maximum = MAX3;
                    this.chart2.ChartAreas[0].AxisX.Interval = MAX3 / 5;
                    this.chart2.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart2.ChartAreas[0].AxisY.Maximum = MAX2;
                    this.chart2.ChartAreas[0].AxisY.Interval = MAX2 / 5;
                    this.chart2.Series[0].Points.AddXY(t3_1, t2_1);
                    this.chart2.Series[0].Points.AddXY(t3_2, t2_2);
                    this.chart2.Series[0].Points.AddXY(t3_3, t2_3);
                    this.chart2.Series[0].Points.AddXY(t3_4, t2_4);
                    this.chart2.Series[0].Points.AddXY(t3_5, t2_5);
                    this.chart2.Series[0].Points.AddXY(t3_6, t2_6);
                    this.chart2.Series[0].Points.AddXY(t3_7, t2_7);
                    this.chart2.Series[0].Points.AddXY(t3_8, t2_8);
                    this.chart2.Series[0].Points.AddXY(t3_9, t2_9);
                    this.chart2.Series[0].Points.AddXY(t3_10, t2_10);

                    this.chart3.ChartAreas[0].AxisX.Minimum = 0; // X - R    Y - Po
                    this.chart3.ChartAreas[0].AxisX.Maximum = MAX5;
                    this.chart3.ChartAreas[0].AxisX.Interval = MAX5 / 5;
                    this.chart3.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart3.ChartAreas[0].AxisY.Maximum = MAX2;
                    this.chart3.ChartAreas[0].AxisY.Interval = MAX2 / 5;
                    this.chart3.Series[0].Points.AddXY(t5_1, t2_1);
                    this.chart3.Series[0].Points.AddXY(t5_2, t2_2);
                    this.chart3.Series[0].Points.AddXY(t5_3, t2_3);
                    this.chart3.Series[0].Points.AddXY(t5_4, t2_4);
                    this.chart3.Series[0].Points.AddXY(t5_5, t2_5);
                    this.chart3.Series[0].Points.AddXY(t5_6, t2_6);
                    this.chart3.Series[0].Points.AddXY(t5_7, t2_7);
                    this.chart3.Series[0].Points.AddXY(t5_8, t2_8);
                    this.chart3.Series[0].Points.AddXY(t5_9, t2_9);
                    this.chart3.Series[0].Points.AddXY(t5_10, t2_10);

                    this.chart4.ChartAreas[0].AxisX.Minimum = 0; // X - Uв    Y - Io
                    this.chart4.ChartAreas[0].AxisX.Maximum = MAX4;
                    this.chart4.ChartAreas[0].AxisX.Interval = MAX4 / 5;
                    this.chart4.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart4.ChartAreas[0].AxisY.Maximum = MAX3;
                    this.chart4.ChartAreas[0].AxisY.Interval = MAX3 / 5;
                    this.chart4.Series[0].Points.AddXY(t4_1, t3_1);
                    this.chart4.Series[0].Points.AddXY(t4_2, t3_2);
                    this.chart4.Series[0].Points.AddXY(t4_3, t3_3);
                    this.chart4.Series[0].Points.AddXY(t4_4, t3_4);
                    this.chart4.Series[0].Points.AddXY(t4_5, t3_5);
                    this.chart4.Series[0].Points.AddXY(t4_6, t3_6);
                    this.chart4.Series[0].Points.AddXY(t4_7, t3_7);
                    this.chart4.Series[0].Points.AddXY(t4_8, t3_8);
                    this.chart4.Series[0].Points.AddXY(t4_9, t3_9);
                    this.chart4.Series[0].Points.AddXY(t4_10, t3_10);

                    this.chart5.ChartAreas[0].AxisX.Minimum = 0; // X - R    Y - Io
                    this.chart5.ChartAreas[0].AxisX.Maximum = MAX5;
                    this.chart5.ChartAreas[0].AxisX.Interval = MAX5 / 5;
                    this.chart5.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart5.ChartAreas[0].AxisY.Maximum = MAX3;
                    this.chart5.ChartAreas[0].AxisY.Interval = MAX3 / 5;
                    this.chart5.Series[0].Points.AddXY(t5_1, t3_1);
                    this.chart5.Series[0].Points.AddXY(t5_2, t3_2);
                    this.chart5.Series[0].Points.AddXY(t5_3, t3_3);
                    this.chart5.Series[0].Points.AddXY(t5_4, t3_4);
                    this.chart5.Series[0].Points.AddXY(t5_5, t3_5);
                    this.chart5.Series[0].Points.AddXY(t5_6, t3_6);
                    this.chart5.Series[0].Points.AddXY(t5_7, t3_7);
                    this.chart5.Series[0].Points.AddXY(t5_8, t3_8);
                    this.chart5.Series[0].Points.AddXY(t5_9, t3_9);
                    this.chart5.Series[0].Points.AddXY(t5_10, t3_10);

                    this.chart6.ChartAreas[0].AxisX.Minimum = 0; // X - R    Y - Uв
                    this.chart6.ChartAreas[0].AxisX.Maximum = MAX5;
                    this.chart6.ChartAreas[0].AxisX.Interval = MAX5 / 5;
                    this.chart6.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart6.ChartAreas[0].AxisY.Maximum = MAX4;
                    this.chart6.ChartAreas[0].AxisY.Interval = MAX4 / 5;
                    this.chart6.Series[0].Points.AddXY(t5_1, t4_1);
                    this.chart6.Series[0].Points.AddXY(t5_2, t4_2);
                    this.chart6.Series[0].Points.AddXY(t5_3, t4_3);
                    this.chart6.Series[0].Points.AddXY(t5_4, t4_4);
                    this.chart6.Series[0].Points.AddXY(t5_5, t4_5);
                    this.chart6.Series[0].Points.AddXY(t5_6, t4_6);
                    this.chart6.Series[0].Points.AddXY(t5_7, t4_7);
                    this.chart6.Series[0].Points.AddXY(t5_8, t4_8);
                    this.chart6.Series[0].Points.AddXY(t5_9, t4_9);
                    this.chart6.Series[0].Points.AddXY(t5_10, t4_10);

                    this.chart7.ChartAreas[0].AxisX.Minimum = 0; // X - C    Y - Io
                    this.chart7.ChartAreas[0].AxisX.Maximum = MAX6;
                    this.chart7.ChartAreas[0].AxisX.Interval = MAX6 / 5;
                    this.chart7.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart7.ChartAreas[0].AxisY.Maximum = MAX3;
                    this.chart7.ChartAreas[0].AxisY.Interval = MAX3 / 5;
                    this.chart7.Series[0].Points.AddXY(t6_1, t3_1);
                    this.chart7.Series[0].Points.AddXY(t6_2, t3_2);
                    this.chart7.Series[0].Points.AddXY(t6_3, t3_3);
                    this.chart7.Series[0].Points.AddXY(t6_4, t3_4);
                    this.chart7.Series[0].Points.AddXY(t6_5, t3_5);
                    this.chart7.Series[0].Points.AddXY(t6_6, t3_6);
                    this.chart7.Series[0].Points.AddXY(t6_7, t3_7);
                    this.chart7.Series[0].Points.AddXY(t6_8, t3_8);
                    this.chart7.Series[0].Points.AddXY(t6_9, t3_9);
                    this.chart7.Series[0].Points.AddXY(t6_10, t3_10);

                    this.chart8.ChartAreas[0].AxisX.Minimum = 0; // X - C    Y - Uв
                    this.chart8.ChartAreas[0].AxisX.Maximum = MAX6;
                    this.chart8.ChartAreas[0].AxisX.Interval = MAX6 / 5;
                    this.chart8.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart8.ChartAreas[0].AxisY.Maximum = MAX4;
                    this.chart8.ChartAreas[0].AxisY.Interval = MAX4 / 5;
                    this.chart8.Series[0].Points.AddXY(t6_1, t4_1);
                    this.chart8.Series[0].Points.AddXY(t6_2, t4_2);
                    this.chart8.Series[0].Points.AddXY(t6_3, t4_3);
                    this.chart8.Series[0].Points.AddXY(t6_4, t4_4);
                    this.chart8.Series[0].Points.AddXY(t6_5, t4_5);
                    this.chart8.Series[0].Points.AddXY(t6_6, t4_6);
                    this.chart8.Series[0].Points.AddXY(t6_7, t4_7);
                    this.chart8.Series[0].Points.AddXY(t6_8, t4_8);
                    this.chart8.Series[0].Points.AddXY(t6_9, t4_9);
                    this.chart8.Series[0].Points.AddXY(t6_10, t4_10);

                    xxx += hhh;
                }
            }

            if (index == "6")
            {
                label3.Text = "Io";
                label4.Text = "Uв";
                label5.Text = "R";
                label6.Text = "C";
                label7.Text = "N посл.";
                label8.Text = "N пар.";

                Idop = Convert.ToDouble(textBox111.Text);
                Uobr = Convert.ToDouble(textBox112.Text);

                t1_1 = Convert.ToDouble(textBox1.Text);
                t1_2 = Convert.ToDouble(textBox2.Text);
                t1_3 = Convert.ToDouble(textBox3.Text);
                t1_4 = Convert.ToDouble(textBox4.Text);
                t1_5 = Convert.ToDouble(textBox5.Text);
                t1_6 = Convert.ToDouble(textBox6.Text);
                t1_7 = Convert.ToDouble(textBox7.Text);
                t1_8 = Convert.ToDouble(textBox8.Text);
                t1_9 = Convert.ToDouble(textBox9.Text);
                t1_10 = Convert.ToDouble(textBox10.Text);

                t2_1 = Convert.ToDouble(textBox11.Text);
                t2_2 = Convert.ToDouble(textBox12.Text);
                t2_3 = Convert.ToDouble(textBox13.Text);
                t2_4 = Convert.ToDouble(textBox14.Text);
                t2_5 = Convert.ToDouble(textBox15.Text);
                t2_6 = Convert.ToDouble(textBox16.Text);
                t2_7 = Convert.ToDouble(textBox17.Text);
                t2_8 = Convert.ToDouble(textBox18.Text);
                t2_9 = Convert.ToDouble(textBox19.Text);
                t2_10 = Convert.ToDouble(textBox20.Text);

                t3_1 = t2_1 / t1_1;
                t3_2 = t2_2 / t1_2;
                t3_3 = t2_3 / t1_3;
                t3_4 = t2_4 / t1_4;
                t3_5 = t2_5 / t1_5;
                t3_6 = t2_6 / t1_6;
                t3_7 = t2_7 / t1_7;
                t3_8 = t2_8 / t1_8;
                t3_9 = t2_9 / t1_9;
                t3_10 = t2_10 / t1_10;

                textBox21.Text = t3_1.ToString("0.##");
                textBox22.Text = t3_2.ToString("0.##");
                textBox23.Text = t3_3.ToString("0.##");
                textBox24.Text = t3_4.ToString("0.##");
                textBox25.Text = t3_5.ToString("0.##");
                textBox26.Text = t3_6.ToString("0.##");
                textBox27.Text = t3_7.ToString("0.##");
                textBox28.Text = t3_8.ToString("0.##");
                textBox29.Text = t3_9.ToString("0.##");
                textBox30.Text = t3_10.ToString("0.##");

                t4_1 = Math.Sqrt(3) * t1_1;
                t4_2 = Math.Sqrt(3) * t1_2;
                t4_3 = Math.Sqrt(3) * t1_3;
                t4_4 = Math.Sqrt(3) * t1_4;
                t4_5 = Math.Sqrt(3) * t1_5;
                t4_6 = Math.Sqrt(3) * t1_6;
                t4_7 = Math.Sqrt(3) * t1_7;
                t4_8 = Math.Sqrt(3) * t1_8;
                t4_9 = Math.Sqrt(3) * t1_9;
                t4_10 = Math.Sqrt(3) * t1_10;

                textBox31.Text = t4_1.ToString("0.##");
                textBox32.Text = t4_2.ToString("0.##");
                textBox33.Text = t4_3.ToString("0.##");
                textBox34.Text = t4_4.ToString("0.##");
                textBox35.Text = t4_5.ToString("0.##");
                textBox36.Text = t4_6.ToString("0.##");
                textBox37.Text = t4_7.ToString("0.##");
                textBox38.Text = t4_8.ToString("0.##");
                textBox39.Text = t4_9.ToString("0.##");
                textBox40.Text = t4_10.ToString("0.##");

                t5_1 = t1_1 / t3_1;
                t5_2 = t1_2 / t3_2;
                t5_3 = t1_3 / t3_3;
                t5_4 = t1_4 / t3_4;
                t5_5 = t1_5 / t3_5;
                t5_6 = t1_6 / t3_6;
                t5_7 = t1_7 / t3_7;
                t5_8 = t1_8 / t3_8;
                t5_9 = t1_9 / t3_9;
                t5_10 = t1_10 / t3_10;

                textBox41.Text = t5_1.ToString("0.##");
                textBox42.Text = t5_2.ToString("0.##");
                textBox43.Text = t5_3.ToString("0.##");
                textBox44.Text = t5_4.ToString("0.##");
                textBox45.Text = t5_5.ToString("0.##");
                textBox46.Text = t5_6.ToString("0.##");
                textBox47.Text = t5_7.ToString("0.##");
                textBox48.Text = t5_8.ToString("0.##");
                textBox49.Text = t5_9.ToString("0.##");
                textBox50.Text = t5_10.ToString("0.##");

                t6_1 = 3.14 * (t4_1 - t1_1) / 4 * t3_1;
                t6_2 = 3.14 * (t4_2 - t1_2) / 4 * t3_2;
                t6_3 = 3.14 * (t4_3 - t1_3) / 4 * t3_3;
                t6_4 = 3.14 * (t4_4 - t1_4) / 4 * t3_4;
                t6_5 = 3.14 * (t4_5 - t1_5) / 4 * t3_5;
                t6_6 = 3.14 * (t4_6 - t1_6) / 4 * t3_6;
                t6_7 = 3.14 * (t4_7 - t1_7) / 4 * t3_7;
                t6_8 = 3.14 * (t4_8 - t1_8) / 4 * t3_8;
                t6_9 = 3.14 * (t4_9 - t1_9) / 4 * t3_9;
                t6_10 = 3.14 * (t4_10 - t1_10) / 4 * t3_10;

                textBox51.Text = t6_1.ToString("0.##");
                textBox52.Text = t6_2.ToString("0.##");
                textBox53.Text = t6_3.ToString("0.##");
                textBox54.Text = t6_4.ToString("0.##");
                textBox55.Text = t6_5.ToString("0.##");
                textBox56.Text = t6_6.ToString("0.##");
                textBox57.Text = t6_7.ToString("0.##");
                textBox58.Text = t6_8.ToString("0.##");
                textBox59.Text = t6_9.ToString("0.##");
                textBox60.Text = t6_10.ToString("0.##");

                t7_1 = t4_1 / Uobr;
                int T7_1 = Convert.ToInt32(Math.Ceiling(t7_1));
                t7_2 = t4_2 / Uobr;
                int T7_2 = Convert.ToInt32(Math.Ceiling(t7_2));
                t7_3 = t4_3 / Uobr;
                int T7_3 = Convert.ToInt32(Math.Ceiling(t7_3));
                t7_4 = t4_4 / Uobr;
                int T7_4 = Convert.ToInt32(Math.Ceiling(t7_4));
                t7_5 = t4_5 / Uobr;
                int T7_5 = Convert.ToInt32(Math.Ceiling(t7_5));
                t7_6 = t4_6 / Uobr;
                int T7_6 = Convert.ToInt32(Math.Ceiling(t7_6));
                t7_7 = t4_7 / Uobr;
                int T7_7 = Convert.ToInt32(Math.Ceiling(t7_7));
                t7_8 = t4_8 / Uobr;
                int T7_8 = Convert.ToInt32(Math.Ceiling(t7_8));
                t7_9 = t4_9 / Uobr;
                int T7_9 = Convert.ToInt32(Math.Ceiling(t7_9));
                t7_10 = t4_10 / Uobr;
                int T7_10 = Convert.ToInt32(Math.Ceiling(t7_10));

                textBox61.Text = T7_1.ToString("0.##");
                textBox62.Text = T7_2.ToString("0.##");
                textBox63.Text = T7_3.ToString("0.##");
                textBox64.Text = T7_4.ToString("0.##");
                textBox65.Text = T7_5.ToString("0.##");
                textBox66.Text = T7_6.ToString("0.##");
                textBox67.Text = T7_7.ToString("0.##");
                textBox68.Text = T7_8.ToString("0.##");
                textBox69.Text = T7_9.ToString("0.##");
                textBox70.Text = T7_10.ToString("0.##");

                t8_1 = t3_1 / Idop;
                int T8_1 = Convert.ToInt32(Math.Ceiling(t8_1));
                t8_2 = t3_2 / Idop;
                int T8_2 = Convert.ToInt32(Math.Ceiling(t8_2));
                t8_3 = t3_3 / Idop;
                int T8_3 = Convert.ToInt32(Math.Ceiling(t8_3));
                t8_4 = t3_4 / Idop;
                int T8_4 = Convert.ToInt32(Math.Ceiling(t8_4));
                t8_5 = t3_5 / Idop;
                int T8_5 = Convert.ToInt32(Math.Ceiling(t8_5));
                t8_6 = t3_6 / Idop;
                int T8_6 = Convert.ToInt32(Math.Ceiling(t8_6));
                t8_7 = t3_7 / Idop;
                int T8_7 = Convert.ToInt32(Math.Ceiling(t8_7));
                t8_8 = t3_8 / Idop;
                int T8_8 = Convert.ToInt32(Math.Ceiling(t8_8));
                t8_9 = t3_9 / Idop;
                int T8_9 = Convert.ToInt32(Math.Ceiling(t8_9));
                t8_10 = t3_10 / Idop;
                int T8_10 = Convert.ToInt32(Math.Ceiling(t8_10));

                textBox71.Text = T8_1.ToString("0.##");
                textBox72.Text = T8_2.ToString("0.##");
                textBox73.Text = T8_3.ToString("0.##");
                textBox74.Text = T8_4.ToString("0.##");
                textBox75.Text = T8_5.ToString("0.##");
                textBox76.Text = T8_6.ToString("0.##");
                textBox77.Text = T8_7.ToString("0.##");
                textBox78.Text = T8_8.ToString("0.##");
                textBox79.Text = T8_9.ToString("0.##");
                textBox80.Text = T8_10.ToString("0.##");

                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                textBox21.Visible = true;
                textBox22.Visible = true;
                textBox23.Visible = true;
                textBox24.Visible = true;
                textBox25.Visible = true;
                textBox26.Visible = true;
                textBox27.Visible = true;
                textBox28.Visible = true;
                textBox29.Visible = true;
                textBox30.Visible = true;
                textBox31.Visible = true;
                textBox32.Visible = true;
                textBox33.Visible = true;
                textBox34.Visible = true;
                textBox35.Visible = true;
                textBox36.Visible = true;
                textBox37.Visible = true;
                textBox38.Visible = true;
                textBox39.Visible = true;
                textBox40.Visible = true;
                textBox41.Visible = true;
                textBox42.Visible = true;
                textBox43.Visible = true;
                textBox44.Visible = true;
                textBox45.Visible = true;
                textBox46.Visible = true;
                textBox47.Visible = true;
                textBox48.Visible = true;
                textBox49.Visible = true;
                textBox50.Visible = true;
                textBox51.Visible = true;
                textBox52.Visible = true;
                textBox53.Visible = true;
                textBox54.Visible = true;
                textBox55.Visible = true;
                textBox56.Visible = true;
                textBox57.Visible = true;
                textBox58.Visible = true;
                textBox59.Visible = true;
                textBox60.Visible = true;
                textBox61.Visible = true;
                textBox62.Visible = true;
                textBox63.Visible = true;
                textBox64.Visible = true;
                textBox65.Visible = true;
                textBox66.Visible = true;
                textBox67.Visible = true;
                textBox68.Visible = true;
                textBox69.Visible = true;
                textBox70.Visible = true;
                textBox71.Visible = true;
                textBox72.Visible = true;
                textBox73.Visible = true;
                textBox74.Visible = true;
                textBox75.Visible = true;
                textBox76.Visible = true;
                textBox77.Visible = true;
                textBox78.Visible = true;
                textBox79.Visible = true;
                textBox80.Visible = true;
                textBox81.Visible = false;
                textBox82.Visible = false;
                textBox83.Visible = false;
                textBox84.Visible = false;
                textBox85.Visible = false;
                textBox86.Visible = false;
                textBox87.Visible = false;
                textBox88.Visible = false;
                textBox89.Visible = false;
                textBox90.Visible = false;
                textBox91.Visible = false;
                textBox92.Visible = false;
                textBox93.Visible = false;
                textBox94.Visible = false;
                textBox95.Visible = false;
                textBox96.Visible = false;
                textBox97.Visible = false;
                textBox98.Visible = false;
                textBox99.Visible = false;
                textBox100.Visible = false;
                textBox101.Visible = false;
                textBox102.Visible = false;
                textBox103.Visible = false;
                textBox104.Visible = false;
                textBox105.Visible = false;
                textBox106.Visible = false;
                textBox107.Visible = false;
                textBox108.Visible = false;
                textBox109.Visible = false;
                textBox110.Visible = false;
                chart1.Visible = true;
                chart2.Visible = true;
                chart3.Visible = true;
                chart4.Visible = true;
                chart5.Visible = true;
                chart6.Visible = true;
                chart7.Visible = true;
                chart8.Visible = true;

                double aaa, bbb, hhh, xxx, max2, max3, max4, max5, max6, MAX2, MAX3, MAX4, MAX5, MAX6;
                aaa = 0.01;
                bbb = 0.01;
                hhh = 0.01;
                xxx = aaa;
                this.chart1.Series[0].Points.Clear();
                this.chart2.Series[0].Points.Clear();
                this.chart3.Series[0].Points.Clear();
                this.chart4.Series[0].Points.Clear();
                this.chart5.Series[0].Points.Clear();
                this.chart6.Series[0].Points.Clear();
                this.chart7.Series[0].Points.Clear();
                this.chart8.Series[0].Points.Clear();
                this.chart1.ChartAreas[0].AxisX.Title = "Po(Uв)";
                this.chart2.ChartAreas[0].AxisX.Title = "Po(Io)";
                this.chart3.ChartAreas[0].AxisX.Title = "Po(R)";
                this.chart4.ChartAreas[0].AxisX.Title = "Io(Uв)";
                this.chart5.ChartAreas[0].AxisX.Title = "Io(R)";
                this.chart6.ChartAreas[0].AxisX.Title = "Uв(R)";
                this.chart7.ChartAreas[0].AxisX.Title = "Io(C)";
                this.chart8.ChartAreas[0].AxisX.Title = "Uв(C)";

                max2 = Math.Max(Math.Max(Math.Max(Math.Max(t2_1, t2_2), Math.Max(t2_3, t2_4)), Math.Max(Math.Max(t2_5, t2_6), Math.Max(t2_7, t2_8))), Math.Max(t2_9, t2_10));
                max3 = Math.Max(Math.Max(Math.Max(Math.Max(t3_1, t3_2), Math.Max(t3_3, t3_4)), Math.Max(Math.Max(t3_5, t3_6), Math.Max(t3_7, t3_8))), Math.Max(t3_9, t3_10));
                max4 = Math.Max(Math.Max(Math.Max(Math.Max(t4_1, t4_2), Math.Max(t4_3, t4_4)), Math.Max(Math.Max(t4_5, t4_6), Math.Max(t4_7, t4_8))), Math.Max(t4_9, t4_10));
                max5 = Math.Max(Math.Max(Math.Max(Math.Max(t5_1, t5_2), Math.Max(t5_3, t5_4)), Math.Max(Math.Max(t5_5, t5_6), Math.Max(t5_7, t5_8))), Math.Max(t5_9, t5_10));
                max6 = Math.Max(Math.Max(Math.Max(Math.Max(t6_1, t6_2), Math.Max(t6_3, t6_4)), Math.Max(Math.Max(t6_5, t6_6), Math.Max(t6_7, t6_8))), Math.Max(t6_9, t6_10));

                MAX2 = ((int)((max2 + 150) / 100)) * 100;
                MAX3 = ((int)((max3 + 10) / 10)) * 10;
                MAX4 = ((int)((max4 + 150) / 100)) * 100;
                MAX5 = ((int)((max5 + 20) / 10)) * 10;
                MAX6 = ((int)((max6 + 150) / 100)) * 100;

                while (xxx <= bbb)
                {
                    this.chart1.ChartAreas[0].AxisX.Minimum = 0; // X - Uв    Y - Po
                    this.chart1.ChartAreas[0].AxisX.Maximum = MAX4;
                    this.chart1.ChartAreas[0].AxisX.Interval = MAX4 / 5;
                    this.chart1.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart1.ChartAreas[0].AxisY.Maximum = MAX2;
                    this.chart1.ChartAreas[0].AxisY.Interval = MAX2 / 5;
                    this.chart1.Series[0].Points.AddXY(t4_1, t2_1);
                    this.chart1.Series[0].Points.AddXY(t4_2, t2_2);
                    this.chart1.Series[0].Points.AddXY(t4_3, t2_3);
                    this.chart1.Series[0].Points.AddXY(t4_4, t2_4);
                    this.chart1.Series[0].Points.AddXY(t4_5, t2_5);
                    this.chart1.Series[0].Points.AddXY(t4_6, t2_6);
                    this.chart1.Series[0].Points.AddXY(t4_7, t2_7);
                    this.chart1.Series[0].Points.AddXY(t4_8, t2_8);
                    this.chart1.Series[0].Points.AddXY(t4_9, t2_9);
                    this.chart1.Series[0].Points.AddXY(t4_10, t2_10);

                    this.chart2.ChartAreas[0].AxisX.Minimum = 0; // X - Io    Y - Po
                    this.chart2.ChartAreas[0].AxisX.Maximum = MAX3;
                    this.chart2.ChartAreas[0].AxisX.Interval = MAX3 / 5;
                    this.chart2.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart2.ChartAreas[0].AxisY.Maximum = MAX2;
                    this.chart2.ChartAreas[0].AxisY.Interval = MAX2 / 5;
                    this.chart2.Series[0].Points.AddXY(t3_1, t2_1);
                    this.chart2.Series[0].Points.AddXY(t3_2, t2_2);
                    this.chart2.Series[0].Points.AddXY(t3_3, t2_3);
                    this.chart2.Series[0].Points.AddXY(t3_4, t2_4);
                    this.chart2.Series[0].Points.AddXY(t3_5, t2_5);
                    this.chart2.Series[0].Points.AddXY(t3_6, t2_6);
                    this.chart2.Series[0].Points.AddXY(t3_7, t2_7);
                    this.chart2.Series[0].Points.AddXY(t3_8, t2_8);
                    this.chart2.Series[0].Points.AddXY(t3_9, t2_9);
                    this.chart2.Series[0].Points.AddXY(t3_10, t2_10);

                    this.chart3.ChartAreas[0].AxisX.Minimum = 0; // X - R    Y - Po
                    this.chart3.ChartAreas[0].AxisX.Maximum = MAX5;
                    this.chart3.ChartAreas[0].AxisX.Interval = MAX5 / 5;
                    this.chart3.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart3.ChartAreas[0].AxisY.Maximum = MAX2;
                    this.chart3.ChartAreas[0].AxisY.Interval = MAX2 / 5;
                    this.chart3.Series[0].Points.AddXY(t5_1, t2_1);
                    this.chart3.Series[0].Points.AddXY(t5_2, t2_2);
                    this.chart3.Series[0].Points.AddXY(t5_3, t2_3);
                    this.chart3.Series[0].Points.AddXY(t5_4, t2_4);
                    this.chart3.Series[0].Points.AddXY(t5_5, t2_5);
                    this.chart3.Series[0].Points.AddXY(t5_6, t2_6);
                    this.chart3.Series[0].Points.AddXY(t5_7, t2_7);
                    this.chart3.Series[0].Points.AddXY(t5_8, t2_8);
                    this.chart3.Series[0].Points.AddXY(t5_9, t2_9);
                    this.chart3.Series[0].Points.AddXY(t5_10, t2_10);

                    this.chart4.ChartAreas[0].AxisX.Minimum = 0; // X - Uв    Y - Io
                    this.chart4.ChartAreas[0].AxisX.Maximum = MAX4;
                    this.chart4.ChartAreas[0].AxisX.Interval = MAX4 / 5;
                    this.chart4.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart4.ChartAreas[0].AxisY.Maximum = MAX3;
                    this.chart4.ChartAreas[0].AxisY.Interval = MAX3 / 5;
                    this.chart4.Series[0].Points.AddXY(t4_1, t3_1);
                    this.chart4.Series[0].Points.AddXY(t4_2, t3_2);
                    this.chart4.Series[0].Points.AddXY(t4_3, t3_3);
                    this.chart4.Series[0].Points.AddXY(t4_4, t3_4);
                    this.chart4.Series[0].Points.AddXY(t4_5, t3_5);
                    this.chart4.Series[0].Points.AddXY(t4_6, t3_6);
                    this.chart4.Series[0].Points.AddXY(t4_7, t3_7);
                    this.chart4.Series[0].Points.AddXY(t4_8, t3_8);
                    this.chart4.Series[0].Points.AddXY(t4_9, t3_9);
                    this.chart4.Series[0].Points.AddXY(t4_10, t3_10);

                    this.chart5.ChartAreas[0].AxisX.Minimum = 0; // X - R    Y - Io
                    this.chart5.ChartAreas[0].AxisX.Maximum = MAX5;
                    this.chart5.ChartAreas[0].AxisX.Interval = MAX5 / 5;
                    this.chart5.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart5.ChartAreas[0].AxisY.Maximum = MAX3;
                    this.chart5.ChartAreas[0].AxisY.Interval = MAX3 / 5;
                    this.chart5.Series[0].Points.AddXY(t5_1, t3_1);
                    this.chart5.Series[0].Points.AddXY(t5_2, t3_2);
                    this.chart5.Series[0].Points.AddXY(t5_3, t3_3);
                    this.chart5.Series[0].Points.AddXY(t5_4, t3_4);
                    this.chart5.Series[0].Points.AddXY(t5_5, t3_5);
                    this.chart5.Series[0].Points.AddXY(t5_6, t3_6);
                    this.chart5.Series[0].Points.AddXY(t5_7, t3_7);
                    this.chart5.Series[0].Points.AddXY(t5_8, t3_8);
                    this.chart5.Series[0].Points.AddXY(t5_9, t3_9);
                    this.chart5.Series[0].Points.AddXY(t5_10, t3_10);

                    this.chart6.ChartAreas[0].AxisX.Minimum = 0; // X - R    Y - Uв
                    this.chart6.ChartAreas[0].AxisX.Maximum = MAX5;
                    this.chart6.ChartAreas[0].AxisX.Interval = MAX5 / 5;
                    this.chart6.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart6.ChartAreas[0].AxisY.Maximum = MAX4;
                    this.chart6.ChartAreas[0].AxisY.Interval = MAX4 / 5;
                    this.chart6.Series[0].Points.AddXY(t5_1, t4_1);
                    this.chart6.Series[0].Points.AddXY(t5_2, t4_2);
                    this.chart6.Series[0].Points.AddXY(t5_3, t4_3);
                    this.chart6.Series[0].Points.AddXY(t5_4, t4_4);
                    this.chart6.Series[0].Points.AddXY(t5_5, t4_5);
                    this.chart6.Series[0].Points.AddXY(t5_6, t4_6);
                    this.chart6.Series[0].Points.AddXY(t5_7, t4_7);
                    this.chart6.Series[0].Points.AddXY(t5_8, t4_8);
                    this.chart6.Series[0].Points.AddXY(t5_9, t4_9);
                    this.chart6.Series[0].Points.AddXY(t5_10, t4_10);

                    this.chart7.ChartAreas[0].AxisX.Minimum = 0; // X - C    Y - Io
                    this.chart7.ChartAreas[0].AxisX.Maximum = MAX6;
                    this.chart7.ChartAreas[0].AxisX.Interval = MAX6 / 5;
                    this.chart7.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart7.ChartAreas[0].AxisY.Maximum = MAX3;
                    this.chart7.ChartAreas[0].AxisY.Interval = MAX3 / 5;
                    this.chart7.Series[0].Points.AddXY(t6_1, t3_1);
                    this.chart7.Series[0].Points.AddXY(t6_2, t3_2);
                    this.chart7.Series[0].Points.AddXY(t6_3, t3_3);
                    this.chart7.Series[0].Points.AddXY(t6_4, t3_4);
                    this.chart7.Series[0].Points.AddXY(t6_5, t3_5);
                    this.chart7.Series[0].Points.AddXY(t6_6, t3_6);
                    this.chart7.Series[0].Points.AddXY(t6_7, t3_7);
                    this.chart7.Series[0].Points.AddXY(t6_8, t3_8);
                    this.chart7.Series[0].Points.AddXY(t6_9, t3_9);
                    this.chart7.Series[0].Points.AddXY(t6_10, t3_10);

                    this.chart8.ChartAreas[0].AxisX.Minimum = 0; // X - C    Y - Uв
                    this.chart8.ChartAreas[0].AxisX.Maximum = MAX6;
                    this.chart8.ChartAreas[0].AxisX.Interval = MAX6 / 5;
                    this.chart8.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart8.ChartAreas[0].AxisY.Maximum = MAX4;
                    this.chart8.ChartAreas[0].AxisY.Interval = MAX4 / 5;
                    this.chart8.Series[0].Points.AddXY(t6_1, t4_1);
                    this.chart8.Series[0].Points.AddXY(t6_2, t4_2);
                    this.chart8.Series[0].Points.AddXY(t6_3, t4_3);
                    this.chart8.Series[0].Points.AddXY(t6_4, t4_4);
                    this.chart8.Series[0].Points.AddXY(t6_5, t4_5);
                    this.chart8.Series[0].Points.AddXY(t6_6, t4_6);
                    this.chart8.Series[0].Points.AddXY(t6_7, t4_7);
                    this.chart8.Series[0].Points.AddXY(t6_8, t4_8);
                    this.chart8.Series[0].Points.AddXY(t6_9, t4_9);
                    this.chart8.Series[0].Points.AddXY(t6_10, t4_10);

                    xxx += hhh;
                }
            }

            if (index == "7")
            {
                label3.Text = "I2";
                label4.Text = "P2";
                label5.Text = "Pтр";
                label6.Text = "I1";
                label7.Text = "S";
                label8.Text = "w1";
                label9.Text = "w2";
                label10.Text = "d1";
                label11.Text = "d2";

                t1_1 = Convert.ToDouble(textBox1.Text);
                t1_2 = Convert.ToDouble(textBox2.Text);
                t1_3 = Convert.ToDouble(textBox3.Text);
                t1_4 = Convert.ToDouble(textBox4.Text);
                t1_5 = Convert.ToDouble(textBox5.Text);
                t1_6 = Convert.ToDouble(textBox6.Text);
                t1_7 = Convert.ToDouble(textBox7.Text);
                t1_8 = Convert.ToDouble(textBox8.Text);
                t1_9 = Convert.ToDouble(textBox9.Text);
                t1_10 = Convert.ToDouble(textBox10.Text);

                t2_1 = Convert.ToDouble(textBox11.Text);
                t2_2 = Convert.ToDouble(textBox12.Text);
                t2_3 = Convert.ToDouble(textBox13.Text);
                t2_4 = Convert.ToDouble(textBox14.Text);
                t2_5 = Convert.ToDouble(textBox15.Text);
                t2_6 = Convert.ToDouble(textBox16.Text);
                t2_7 = Convert.ToDouble(textBox17.Text);
                t2_8 = Convert.ToDouble(textBox18.Text);
                t2_9 = Convert.ToDouble(textBox19.Text);
                t2_10 = Convert.ToDouble(textBox20.Text);

                t3_1 = t2_1 * 1.5;
                t3_2 = t2_2 * 1.5;
                t3_3 = t2_3 * 1.5;
                t3_4 = t2_4 * 1.5;
                t3_5 = t2_5 * 1.5;
                t3_6 = t2_6 * 1.5;
                t3_7 = t2_7 * 1.5;
                t3_8 = t2_8 * 1.5;
                t3_9 = t2_9 * 1.5;
                t3_10 = t2_10 * 1.5;

                textBox21.Text = t3_1.ToString("0.##");
                textBox22.Text = t3_2.ToString("0.##");
                textBox23.Text = t3_3.ToString("0.##");
                textBox24.Text = t3_4.ToString("0.##");
                textBox25.Text = t3_5.ToString("0.##");
                textBox26.Text = t3_6.ToString("0.##");
                textBox27.Text = t3_7.ToString("0.##");
                textBox28.Text = t3_8.ToString("0.##");
                textBox29.Text = t3_9.ToString("0.##");
                textBox30.Text = t3_10.ToString("0.##");

                t4_1 = t3_1 * t1_1;
                t4_2 = t3_1 * t1_2;
                t4_3 = t3_1 * t1_3;
                t4_4 = t3_1 * t1_4;
                t4_5 = t3_1 * t1_5;
                t4_6 = t3_1 * t1_6;
                t4_7 = t3_1 * t1_7;
                t4_8 = t3_1 * t1_8;
                t4_9 = t3_1 * t1_9;
                t4_10 = t3_1 * t1_10;

                textBox31.Text = t4_1.ToString("0.##");
                textBox32.Text = t4_2.ToString("0.##");
                textBox33.Text = t4_3.ToString("0.##");
                textBox34.Text = t4_4.ToString("0.##");
                textBox35.Text = t4_5.ToString("0.##");
                textBox36.Text = t4_6.ToString("0.##");
                textBox37.Text = t4_7.ToString("0.##");
                textBox38.Text = t4_8.ToString("0.##");
                textBox39.Text = t4_9.ToString("0.##");
                textBox40.Text = t4_10.ToString("0.##");

                t5_1 = 1.25 * t4_1;
                t5_2 = 1.25 * t4_2;
                t5_3 = 1.25 * t4_3;
                t5_4 = 1.25 * t4_4;
                t5_5 = 1.25 * t4_5;
                t5_6 = 1.25 * t4_6;
                t5_7 = 1.25 * t4_7;
                t5_8 = 1.25 * t4_8;
                t5_9 = 1.25 * t4_9;
                t5_10 = 1.25 * t4_10;

                textBox41.Text = t5_1.ToString("0.##");
                textBox42.Text = t5_2.ToString("0.##");
                textBox43.Text = t5_3.ToString("0.##");
                textBox44.Text = t5_4.ToString("0.##");
                textBox45.Text = t5_5.ToString("0.##");
                textBox46.Text = t5_6.ToString("0.##");
                textBox47.Text = t5_7.ToString("0.##");
                textBox48.Text = t5_8.ToString("0.##");
                textBox49.Text = t5_9.ToString("0.##");
                textBox50.Text = t5_10.ToString("0.##");

                t12_1 = 1.3 * t1_1;
                t12_2 = 1.3 * t1_2;
                t12_3 = 1.3 * t1_3;
                t12_4 = 1.3 * t1_4;
                t12_5 = 1.3 * t1_5;
                t12_6 = 1.3 * t1_6;
                t12_7 = 1.3 * t1_7;
                t12_8 = 1.3 * t1_8;
                t12_9 = 1.3 * t1_9;
                t12_10 = 1.3 * t1_10; // это U1, она используется в графиках и расчетах но не выводится в textBox

                t6_1 = t5_1 / t12_1;
                t6_2 = t5_2 / t12_2;
                t6_3 = t5_3 / t12_3;
                t6_4 = t5_4 / t12_4;
                t6_5 = t5_5 / t12_5;
                t6_6 = t5_6 / t12_6;
                t6_7 = t5_7 / t12_7;
                t6_8 = t5_8 / t12_8;
                t6_9 = t5_9 / t12_9;
                t6_10 = t5_10 / t12_10;

                textBox51.Text = t6_1.ToString("0.##");
                textBox52.Text = t6_2.ToString("0.##");
                textBox53.Text = t6_3.ToString("0.##");
                textBox54.Text = t6_4.ToString("0.##");
                textBox55.Text = t6_5.ToString("0.##");
                textBox56.Text = t6_6.ToString("0.##");
                textBox57.Text = t6_7.ToString("0.##");
                textBox58.Text = t6_8.ToString("0.##");
                textBox59.Text = t6_9.ToString("0.##");
                textBox60.Text = t6_10.ToString("0.##");

                t7_1 = 1.3 * t5_1;
                t7_2 = 1.3 * t5_2;
                t7_3 = 1.3 * t5_3;
                t7_4 = 1.3 * t5_4;
                t7_5 = 1.3 * t5_5;
                t7_6 = 1.3 * t5_6;
                t7_7 = 1.3 * t5_7;
                t7_8 = 1.3 * t5_8;
                t7_9 = 1.3 * t5_9;
                t7_10 = 1.3 * t5_10;

                textBox61.Text = t7_1.ToString("0.##");
                textBox62.Text = t7_2.ToString("0.##");
                textBox63.Text = t7_3.ToString("0.##");
                textBox64.Text = t7_4.ToString("0.##");
                textBox65.Text = t7_5.ToString("0.##");
                textBox66.Text = t7_6.ToString("0.##");
                textBox67.Text = t7_7.ToString("0.##");
                textBox68.Text = t7_8.ToString("0.##");
                textBox69.Text = t7_9.ToString("0.##");
                textBox70.Text = t7_10.ToString("0.##");

                t8_1 = (t12_1 * 50) / t7_1;
                t8_2 = (t12_2 * 50) / t7_2;
                t8_3 = (t12_3 * 50) / t7_3;
                t8_4 = (t12_4 * 50) / t7_4;
                t8_5 = (t12_5 * 50) / t7_5;
                t8_6 = (t12_6 * 50) / t7_6;
                t8_7 = (t12_7 * 50) / t7_7;
                t8_8 = (t12_8 * 50) / t7_8;
                t8_9 = (t12_9 * 50) / t7_9;
                t8_10 = (t12_10 * 50) / t7_10;

                textBox71.Text = t8_1.ToString("0.##");
                textBox72.Text = t8_2.ToString("0.##");
                textBox73.Text = t8_3.ToString("0.##");
                textBox74.Text = t8_4.ToString("0.##");
                textBox75.Text = t8_5.ToString("0.##");
                textBox76.Text = t8_6.ToString("0.##");
                textBox77.Text = t8_7.ToString("0.##");
                textBox78.Text = t8_8.ToString("0.##");
                textBox79.Text = t8_9.ToString("0.##");
                textBox80.Text = t8_10.ToString("0.##");

                t9_1 = (t1_1 * 55) / t7_1;
                t9_2 = (t1_2 * 55) / t7_2;
                t9_3 = (t1_3 * 55) / t7_3;
                t9_4 = (t1_4 * 55) / t7_4;
                t9_5 = (t1_5 * 55) / t7_5;
                t9_6 = (t1_6 * 55) / t7_6;
                t9_7 = (t1_7 * 55) / t7_7;
                t9_8 = (t1_8 * 55) / t7_8;
                t9_9 = (t1_9 * 55) / t7_9;
                t9_10 = (t1_10 * 55) / t7_10;

                textBox81.Text = t9_1.ToString("0.##");
                textBox82.Text = t9_2.ToString("0.##");
                textBox83.Text = t9_3.ToString("0.##");
                textBox84.Text = t9_4.ToString("0.##");
                textBox85.Text = t9_5.ToString("0.##");
                textBox86.Text = t9_6.ToString("0.##");
                textBox87.Text = t9_7.ToString("0.##");
                textBox88.Text = t9_8.ToString("0.##");
                textBox89.Text = t9_9.ToString("0.##");
                textBox90.Text = t9_10.ToString("0.##");

                t10_1 = 0.2 * t6_1;
                t10_2 = 0.2 * t6_2;
                t10_3 = 0.2 * t6_3;
                t10_4 = 0.2 * t6_4;
                t10_5 = 0.2 * t6_5;
                t10_6 = 0.2 * t6_6;
                t10_7 = 0.2 * t6_7;
                t10_8 = 0.2 * t6_8;
                t10_9 = 0.2 * t6_9;
                t10_10 = 0.2 * t6_10;

                textBox91.Text = t10_1.ToString("0.##");
                textBox92.Text = t10_2.ToString("0.##");
                textBox93.Text = t10_3.ToString("0.##");
                textBox94.Text = t10_4.ToString("0.##");
                textBox95.Text = t10_5.ToString("0.##");
                textBox96.Text = t10_6.ToString("0.##");
                textBox97.Text = t10_7.ToString("0.##");
                textBox98.Text = t10_8.ToString("0.##");
                textBox99.Text = t10_9.ToString("0.##");
                textBox100.Text = t10_10.ToString("0.##");

                t11_1 = 0.2 * t3_1;
                t11_2 = 0.2 * t3_2;
                t11_3 = 0.2 * t3_3;
                t11_4 = 0.2 * t3_4;
                t11_5 = 0.2 * t3_5;
                t11_6 = 0.2 * t3_6;
                t11_7 = 0.2 * t3_7;
                t11_8 = 0.2 * t3_8;
                t11_9 = 0.2 * t3_9;
                t11_10 = 0.2 * t3_10;

                textBox101.Text = t11_1.ToString("0.##");
                textBox102.Text = t11_2.ToString("0.##");
                textBox103.Text = t11_3.ToString("0.##");
                textBox104.Text = t11_4.ToString("0.##");
                textBox105.Text = t11_5.ToString("0.##");
                textBox106.Text = t11_6.ToString("0.##");
                textBox107.Text = t11_7.ToString("0.##");
                textBox108.Text = t11_8.ToString("0.##");
                textBox109.Text = t11_9.ToString("0.##");
                textBox110.Text = t11_10.ToString("0.##");

                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                textBox21.Visible = true;
                textBox22.Visible = true;
                textBox23.Visible = true;
                textBox24.Visible = true;
                textBox25.Visible = true;
                textBox26.Visible = true;
                textBox27.Visible = true;
                textBox28.Visible = true;
                textBox29.Visible = true;
                textBox30.Visible = true;
                textBox31.Visible = true;
                textBox32.Visible = true;
                textBox33.Visible = true;
                textBox34.Visible = true;
                textBox35.Visible = true;
                textBox36.Visible = true;
                textBox37.Visible = true;
                textBox38.Visible = true;
                textBox39.Visible = true;
                textBox40.Visible = true;
                textBox41.Visible = true;
                textBox42.Visible = true;
                textBox43.Visible = true;
                textBox44.Visible = true;
                textBox45.Visible = true;
                textBox46.Visible = true;
                textBox47.Visible = true;
                textBox48.Visible = true;
                textBox49.Visible = true;
                textBox50.Visible = true;
                textBox51.Visible = true;
                textBox52.Visible = true;
                textBox53.Visible = true;
                textBox54.Visible = true;
                textBox55.Visible = true;
                textBox56.Visible = true;
                textBox57.Visible = true;
                textBox58.Visible = true;
                textBox59.Visible = true;
                textBox60.Visible = true;
                textBox61.Visible = true;
                textBox62.Visible = true;
                textBox63.Visible = true;
                textBox64.Visible = true;
                textBox65.Visible = true;
                textBox66.Visible = true;
                textBox67.Visible = true;
                textBox68.Visible = true;
                textBox69.Visible = true;
                textBox70.Visible = true;
                textBox71.Visible = true;
                textBox72.Visible = true;
                textBox73.Visible = true;
                textBox74.Visible = true;
                textBox75.Visible = true;
                textBox76.Visible = true;
                textBox77.Visible = true;
                textBox78.Visible = true;
                textBox79.Visible = true;
                textBox80.Visible = true;
                textBox81.Visible = true;
                textBox82.Visible = true;
                textBox83.Visible = true;
                textBox84.Visible = true;
                textBox85.Visible = true;
                textBox86.Visible = true;
                textBox87.Visible = true;
                textBox88.Visible = true;
                textBox89.Visible = true;
                textBox90.Visible = true;
                textBox91.Visible = true;
                textBox92.Visible = true;
                textBox93.Visible = true;
                textBox94.Visible = true;
                textBox95.Visible = true;
                textBox96.Visible = true;
                textBox97.Visible = true;
                textBox98.Visible = true;
                textBox99.Visible = true;
                textBox100.Visible = true;
                textBox101.Visible = true;
                textBox102.Visible = true;
                textBox103.Visible = true;
                textBox104.Visible = true;
                textBox105.Visible = true;
                textBox106.Visible = true;
                textBox107.Visible = true;
                textBox108.Visible = true;
                textBox109.Visible = true;
                textBox110.Visible = true;
                chart1.Visible = true;
                chart2.Visible = true;
                chart3.Visible = true;
                chart4.Visible = true;
                chart5.Visible = true;
                chart6.Visible = true;
                chart7.Visible = true;
                chart8.Visible = true;

                double aaa, bbb, hhh, xxx, max1, max3, max4, max5, max6, max8, max9, max12, MAX1, MAX3, MAX4, MAX5, MAX6, MAX8, MAX9, MAX12;
                aaa = 0.01;
                bbb = 0.01;
                hhh = 0.01;
                xxx = aaa;
                this.chart1.Series[0].Points.Clear();
                this.chart2.Series[0].Points.Clear();
                this.chart3.Series[0].Points.Clear();
                this.chart4.Series[0].Points.Clear();
                this.chart5.Series[0].Points.Clear();
                this.chart6.Series[0].Points.Clear();
                this.chart7.Series[0].Points.Clear();
                this.chart8.Series[0].Points.Clear();
                this.chart1.ChartAreas[0].AxisX.Title = "Р2(U2)";
                this.chart2.ChartAreas[0].AxisX.Title = "Р2(I2)";
                this.chart3.ChartAreas[0].AxisX.Title = "Ртр(I1)";
                this.chart4.ChartAreas[0].AxisX.Title = "Ртр(U1)";
                this.chart5.ChartAreas[0].AxisX.Title = "I2(U2)";
                this.chart6.ChartAreas[0].AxisX.Title = "I1(U1)";
                this.chart7.ChartAreas[0].AxisX.Title = "P2(w1)";
                this.chart8.ChartAreas[0].AxisX.Title = "Pтр(w2)";

                max1 = Math.Max(Math.Max(Math.Max(Math.Max(t1_1, t1_2), Math.Max(t1_3, t1_4)), Math.Max(Math.Max(t1_5, t1_6), Math.Max(t1_7, t1_8))), Math.Max(t1_9, t1_10));
                max3 = Math.Max(Math.Max(Math.Max(Math.Max(t3_1, t3_2), Math.Max(t3_3, t3_4)), Math.Max(Math.Max(t3_5, t3_6), Math.Max(t3_7, t3_8))), Math.Max(t3_9, t3_10));
                max4 = Math.Max(Math.Max(Math.Max(Math.Max(t4_1, t4_2), Math.Max(t4_3, t4_4)), Math.Max(Math.Max(t4_5, t4_6), Math.Max(t4_7, t4_8))), Math.Max(t4_9, t4_10));
                max5 = Math.Max(Math.Max(Math.Max(Math.Max(t5_1, t5_2), Math.Max(t5_3, t5_4)), Math.Max(Math.Max(t5_5, t5_6), Math.Max(t5_7, t5_8))), Math.Max(t5_9, t5_10));
                max6 = Math.Max(Math.Max(Math.Max(Math.Max(t6_1, t6_2), Math.Max(t6_3, t6_4)), Math.Max(Math.Max(t6_5, t6_6), Math.Max(t6_7, t6_8))), Math.Max(t6_9, t6_10));
                max8 = Math.Max(Math.Max(Math.Max(Math.Max(t8_1, t8_2), Math.Max(t8_3, t8_4)), Math.Max(Math.Max(t8_5, t8_6), Math.Max(t8_7, t8_8))), Math.Max(t8_9, t8_10));
                max9 = Math.Max(Math.Max(Math.Max(Math.Max(t9_1, t9_2), Math.Max(t9_3, t9_4)), Math.Max(Math.Max(t9_5, t9_6), Math.Max(t9_7, t9_8))), Math.Max(t9_9, t9_10));
                max12 = Math.Max(Math.Max(Math.Max(Math.Max(t12_1, t12_2), Math.Max(t12_3, t12_4)), Math.Max(Math.Max(t12_5, t12_6), Math.Max(t12_7, t12_8))), Math.Max(t12_9, t12_10));

                MAX1 = ((int)((max1 + 100) / 100)) * 100;
                MAX3 = ((int)((max3 + 10) / 10)) * 10;
                MAX4 = ((int)((max4 + 150) / 100)) * 100;
                MAX5 = ((int)((max5 + 150) / 100)) * 100;
                MAX6 = ((int)((max6 + 10) / 10)) * 10;
                MAX8 = ((int)((max8 + 10) / 10)) * 10;
                MAX9 = ((int)((max9 + 10) / 10)) * 10;
                MAX12 = ((int)((max12 + 100) / 100)) * 100;

                while (xxx <= bbb)
                {
                    this.chart1.ChartAreas[0].AxisX.Minimum = 0; // X - U2    Y - Р2
                    this.chart1.ChartAreas[0].AxisX.Maximum = MAX1;
                    this.chart1.ChartAreas[0].AxisX.Interval = MAX1 / 5;
                    this.chart1.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart1.ChartAreas[0].AxisY.Maximum = MAX4;
                    this.chart1.ChartAreas[0].AxisY.Interval = MAX4 / 5;
                    this.chart1.Series[0].Points.AddXY(t1_1, t4_1);
                    this.chart1.Series[0].Points.AddXY(t1_2, t4_2);
                    this.chart1.Series[0].Points.AddXY(t1_3, t4_3);
                    this.chart1.Series[0].Points.AddXY(t1_4, t4_4);
                    this.chart1.Series[0].Points.AddXY(t1_5, t4_5);
                    this.chart1.Series[0].Points.AddXY(t1_6, t4_6);
                    this.chart1.Series[0].Points.AddXY(t1_7, t4_7);
                    this.chart1.Series[0].Points.AddXY(t1_8, t4_8);
                    this.chart1.Series[0].Points.AddXY(t1_9, t4_9);
                    this.chart1.Series[0].Points.AddXY(t1_10, t4_10);

                    this.chart2.ChartAreas[0].AxisX.Minimum = 0; // X - I2    Y - Р2
                    this.chart2.ChartAreas[0].AxisX.Maximum = MAX3;
                    this.chart2.ChartAreas[0].AxisX.Interval = MAX3 / 5;
                    this.chart2.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart2.ChartAreas[0].AxisY.Maximum = MAX4;
                    this.chart2.ChartAreas[0].AxisY.Interval = MAX4 / 5;
                    this.chart2.Series[0].Points.AddXY(t3_1, t4_1);
                    this.chart2.Series[0].Points.AddXY(t3_2, t4_2);
                    this.chart2.Series[0].Points.AddXY(t3_3, t4_3);
                    this.chart2.Series[0].Points.AddXY(t3_4, t4_4);
                    this.chart2.Series[0].Points.AddXY(t3_5, t4_5);
                    this.chart2.Series[0].Points.AddXY(t3_6, t4_6);
                    this.chart2.Series[0].Points.AddXY(t3_7, t4_7);
                    this.chart2.Series[0].Points.AddXY(t3_8, t4_8);
                    this.chart2.Series[0].Points.AddXY(t3_9, t4_9);
                    this.chart2.Series[0].Points.AddXY(t3_10, t4_10);

                    this.chart3.ChartAreas[0].AxisX.Minimum = 0; // X - I1    Y - Ртр
                    this.chart3.ChartAreas[0].AxisX.Maximum = MAX6;
                    this.chart3.ChartAreas[0].AxisX.Interval = MAX6 / 5;
                    this.chart3.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart3.ChartAreas[0].AxisY.Maximum = MAX5;
                    this.chart3.ChartAreas[0].AxisY.Interval = MAX5 / 5;
                    this.chart3.Series[0].Points.AddXY(t6_1, t5_1);
                    this.chart3.Series[0].Points.AddXY(t6_2, t5_2);
                    this.chart3.Series[0].Points.AddXY(t6_3, t5_3);
                    this.chart3.Series[0].Points.AddXY(t6_4, t5_4);
                    this.chart3.Series[0].Points.AddXY(t6_5, t5_5);
                    this.chart3.Series[0].Points.AddXY(t6_6, t5_6);
                    this.chart3.Series[0].Points.AddXY(t6_7, t5_7);
                    this.chart3.Series[0].Points.AddXY(t6_8, t5_8);
                    this.chart3.Series[0].Points.AddXY(t6_9, t5_9);
                    this.chart3.Series[0].Points.AddXY(t6_10, t5_10);

                    this.chart4.ChartAreas[0].AxisX.Minimum = 0; // X - U1    Y - Ртр
                    this.chart4.ChartAreas[0].AxisX.Maximum = MAX12;
                    this.chart4.ChartAreas[0].AxisX.Interval = MAX12 / 5;
                    this.chart4.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart4.ChartAreas[0].AxisY.Maximum = MAX5;
                    this.chart4.ChartAreas[0].AxisY.Interval = MAX5 / 5;
                    this.chart4.Series[0].Points.AddXY(t12_1, t5_1);
                    this.chart4.Series[0].Points.AddXY(t12_2, t5_2);
                    this.chart4.Series[0].Points.AddXY(t12_3, t5_3);
                    this.chart4.Series[0].Points.AddXY(t12_4, t5_4);
                    this.chart4.Series[0].Points.AddXY(t12_5, t5_5);
                    this.chart4.Series[0].Points.AddXY(t12_6, t5_6);
                    this.chart4.Series[0].Points.AddXY(t12_7, t5_7);
                    this.chart4.Series[0].Points.AddXY(t12_8, t5_8);
                    this.chart4.Series[0].Points.AddXY(t12_9, t5_9);
                    this.chart4.Series[0].Points.AddXY(t12_10, t5_10);

                    this.chart5.ChartAreas[0].AxisX.Minimum = 0; // X - U2    Y - I2
                    this.chart5.ChartAreas[0].AxisX.Maximum = MAX1;
                    this.chart5.ChartAreas[0].AxisX.Interval = MAX1 / 5;
                    this.chart5.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart5.ChartAreas[0].AxisY.Maximum = MAX3;
                    this.chart5.ChartAreas[0].AxisY.Interval = MAX3 / 5;
                    this.chart5.Series[0].Points.AddXY(t1_1, t3_1);
                    this.chart5.Series[0].Points.AddXY(t1_2, t3_2);
                    this.chart5.Series[0].Points.AddXY(t1_3, t3_3);
                    this.chart5.Series[0].Points.AddXY(t1_4, t3_4);
                    this.chart5.Series[0].Points.AddXY(t1_5, t3_5);
                    this.chart5.Series[0].Points.AddXY(t1_6, t3_6);
                    this.chart5.Series[0].Points.AddXY(t1_7, t3_7);
                    this.chart5.Series[0].Points.AddXY(t1_8, t3_8);
                    this.chart5.Series[0].Points.AddXY(t1_9, t3_9);
                    this.chart5.Series[0].Points.AddXY(t1_10, t3_10);

                    this.chart6.ChartAreas[0].AxisX.Minimum = 0; // X - U1    Y - I1
                    this.chart6.ChartAreas[0].AxisX.Maximum = MAX12;
                    this.chart6.ChartAreas[0].AxisX.Interval = MAX12 / 5;
                    this.chart6.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart6.ChartAreas[0].AxisY.Maximum = MAX6;
                    this.chart6.ChartAreas[0].AxisY.Interval = MAX6 / 5;
                    this.chart6.Series[0].Points.AddXY(t12_1, t6_1);
                    this.chart6.Series[0].Points.AddXY(t12_2, t6_2);
                    this.chart6.Series[0].Points.AddXY(t12_3, t6_3);
                    this.chart6.Series[0].Points.AddXY(t12_4, t6_4);
                    this.chart6.Series[0].Points.AddXY(t12_5, t6_5);
                    this.chart6.Series[0].Points.AddXY(t12_6, t6_6);
                    this.chart6.Series[0].Points.AddXY(t12_7, t6_7);
                    this.chart6.Series[0].Points.AddXY(t12_8, t6_8);
                    this.chart6.Series[0].Points.AddXY(t12_9, t6_9);
                    this.chart6.Series[0].Points.AddXY(t12_10, t6_10);

                    this.chart7.ChartAreas[0].AxisX.Minimum = 0; // X - w1    Y - P2
                    this.chart7.ChartAreas[0].AxisX.Maximum = MAX8;
                    this.chart7.ChartAreas[0].AxisX.Interval = MAX8 / 5;
                    this.chart7.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart7.ChartAreas[0].AxisY.Maximum = MAX4;
                    this.chart7.ChartAreas[0].AxisY.Interval = MAX4 / 5;
                    this.chart7.Series[0].Points.AddXY(t8_1, t4_1);
                    this.chart7.Series[0].Points.AddXY(t8_2, t4_2);
                    this.chart7.Series[0].Points.AddXY(t8_3, t4_3);
                    this.chart7.Series[0].Points.AddXY(t8_4, t4_4);
                    this.chart7.Series[0].Points.AddXY(t8_5, t4_5);
                    this.chart7.Series[0].Points.AddXY(t8_6, t4_6);
                    this.chart7.Series[0].Points.AddXY(t8_7, t4_7);
                    this.chart7.Series[0].Points.AddXY(t8_8, t4_8);
                    this.chart7.Series[0].Points.AddXY(t8_9, t4_9);
                    this.chart7.Series[0].Points.AddXY(t8_10, t4_10);

                    this.chart8.ChartAreas[0].AxisX.Minimum = 0; // X - w2    Y - Pтр
                    this.chart8.ChartAreas[0].AxisX.Maximum = MAX9;
                    this.chart8.ChartAreas[0].AxisX.Interval = MAX9 / 5;
                    this.chart8.ChartAreas[0].AxisY.Minimum = 0;
                    this.chart8.ChartAreas[0].AxisY.Maximum = MAX5;
                    this.chart8.ChartAreas[0].AxisY.Interval = MAX5 / 5;
                    this.chart8.Series[0].Points.AddXY(t9_1, t5_1);
                    this.chart8.Series[0].Points.AddXY(t9_2, t5_2);
                    this.chart8.Series[0].Points.AddXY(t9_3, t5_3);
                    this.chart8.Series[0].Points.AddXY(t9_4, t5_4);
                    this.chart8.Series[0].Points.AddXY(t9_5, t5_5);
                    this.chart8.Series[0].Points.AddXY(t9_6, t5_6);
                    this.chart8.Series[0].Points.AddXY(t9_7, t5_7);
                    this.chart8.Series[0].Points.AddXY(t9_8, t5_8);
                    this.chart8.Series[0].Points.AddXY(t9_9, t5_9);
                    this.chart8.Series[0].Points.AddXY(t9_10, t5_10);

                    xxx += hhh;
                }
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox111.Clear();
            textBox112.Clear();

            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;

            textBox21.Visible = false;
            textBox22.Visible = false;
            textBox23.Visible = false;
            textBox24.Visible = false;
            textBox25.Visible = false;
            textBox26.Visible = false;
            textBox27.Visible = false;
            textBox28.Visible = false;
            textBox29.Visible = false;
            textBox30.Visible = false;
            textBox31.Visible = false;
            textBox32.Visible = false;
            textBox33.Visible = false;
            textBox34.Visible = false;
            textBox35.Visible = false;
            textBox36.Visible = false;
            textBox37.Visible = false;
            textBox38.Visible = false;
            textBox39.Visible = false;
            textBox40.Visible = false;
            textBox41.Visible = false;
            textBox42.Visible = false;
            textBox43.Visible = false;
            textBox44.Visible = false;
            textBox45.Visible = false;
            textBox46.Visible = false;
            textBox47.Visible = false;
            textBox48.Visible = false;
            textBox49.Visible = false;
            textBox50.Visible = false;
            textBox51.Visible = false;
            textBox52.Visible = false;
            textBox53.Visible = false;
            textBox54.Visible = false;
            textBox55.Visible = false;
            textBox56.Visible = false;
            textBox57.Visible = false;
            textBox58.Visible = false;
            textBox59.Visible = false;
            textBox60.Visible = false;
            textBox61.Visible = false;
            textBox62.Visible = false;
            textBox63.Visible = false;
            textBox64.Visible = false;
            textBox65.Visible = false;
            textBox66.Visible = false;
            textBox67.Visible = false;
            textBox68.Visible = false;
            textBox69.Visible = false;
            textBox70.Visible = false;
            textBox71.Visible = false;
            textBox72.Visible = false;
            textBox73.Visible = false;
            textBox74.Visible = false;
            textBox75.Visible = false;
            textBox76.Visible = false;
            textBox77.Visible = false;
            textBox78.Visible = false;
            textBox79.Visible = false;
            textBox80.Visible = false;
            textBox81.Visible = false;
            textBox82.Visible = false;
            textBox83.Visible = false;
            textBox84.Visible = false;
            textBox85.Visible = false;
            textBox86.Visible = false;
            textBox87.Visible = false;
            textBox88.Visible = false;
            textBox89.Visible = false;
            textBox90.Visible = false;
            textBox91.Visible = false;
            textBox92.Visible = false;
            textBox93.Visible = false;
            textBox94.Visible = false;
            textBox95.Visible = false;
            textBox96.Visible = false;
            textBox97.Visible = false;
            textBox98.Visible = false;
            textBox99.Visible = false;
            textBox100.Visible = false;
            textBox101.Visible = false;
            textBox102.Visible = false;
            textBox103.Visible = false;
            textBox104.Visible = false;
            textBox105.Visible = false;
            textBox106.Visible = false;
            textBox107.Visible = false;
            textBox108.Visible = false;
            textBox109.Visible = false;
            textBox110.Visible = false;

            this.chart1.Series[0].Points.Clear();
            this.chart2.Series[0].Points.Clear();
            this.chart3.Series[0].Points.Clear();
            this.chart4.Series[0].Points.Clear();
            this.chart5.Series[0].Points.Clear();
            this.chart6.Series[0].Points.Clear();
            this.chart7.Series[0].Points.Clear();
            this.chart8.Series[0].Points.Clear();

            chart1.Visible = false;
            chart2.Visible = false;
            chart3.Visible = false;
            chart4.Visible = false;
            chart5.Visible = false;
            chart6.Visible = false;
            chart7.Visible = false;
            chart8.Visible = false;
        }
    }
}
