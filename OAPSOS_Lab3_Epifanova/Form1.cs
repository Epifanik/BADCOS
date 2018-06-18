using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace OAPSOS_Lab3_Epifanova
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ClearAll();
        }

        private void ClearAll()
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";

            ZeroText.Text = ""; ZeroText.BackColor = Color.White;
            OneText.Text = ""; OneText.BackColor = Color.White;
            TwoText.Text = ""; TwoText.BackColor = Color.White;
            ThreeText.Text = ""; ThreeText.BackColor = Color.White;
            FourText.Text = ""; FourText.BackColor = Color.White;
            FiveText.Text = ""; FiveText.BackColor = Color.White;
            SixText.Text = ""; SixText.BackColor = Color.White;
            SevenText.Text = ""; SevenText.BackColor = Color.White;
            EightText.Text = ""; EightText.BackColor = Color.White;
            NineText.Text = ""; NineText.BackColor = Color.White;
            TenText.Text = ""; TenText.BackColor = Color.White;
            ElevenText.Text = ""; ElevenText.BackColor = Color.White;
            TwelveText.Text = ""; TwelveText.BackColor = Color.White;
            SumBox123.Text = ""; 
            SumBox456.Text = ""; 
            SumBox789.Text = ""; 
            SumBox101112.Text = ""; 
        }

        int[] X = new int[15];
        int n1, n2, n3, n4;
        int[] sum = new int[13];
        int Sum123 = 0, Sum456 = 0, Sum789 = 0, Sum101112 = 0;

        
        public string goodday(String kusok)
        {
            ClearAll();
            String Result = "";
            int s = 1; char buf;
            Array.Clear(sum, 0, sum.Length);

            for (int i = 0; i < kusok.Length; i++)
            {
                if (kusok[i] != '.') {
                    buf = kusok[i];
                    X[s] = (int)Char.GetNumericValue(buf); 
                    if (s != 8) { label1.Text = label1.Text + X[s] + " + "; }
                    else label1.Text = label1.Text + X[s] + " = ";
                    s++;
                }
            }
            X[9] = X[1] + X[2] + X[3] + X[4] + X[5] + X[6] + X[7] + X[8];
            

            n1 = X[9] / 10;
            n2 = X[9] % 10;
            X[10] = n1 + n2;
            

            X[11] = X[9] - 2 * X[1];
            

            n3 = X[11] / 10;
            n4 = X[11] % 10;
            X[12] = n3 + n4;
            

            X[13] = X[9] + X[11];
            
            X[14] = X[10] + X[12];
            
            for (int i = 1; i < 15; i++)
            {
                Result += Convert.ToString(X[i]);
            }
            for (int i = 0; i < Result.Length; i++)
            {
                if (i < 14)
                {
                    switch (Result[i])
                    {
                        case '0':
                            ZeroText.Text += 0;
                            break;
                        case '1':
                            OneText.Text += 1;
                            sum[1] += 1;
                            break;
                        case '2':
                            TwoText.Text += 2;
                            sum[2] += 2;
                            break;
                        case '3':
                            ThreeText.Text += 3;
                            sum[3] += 3;
                            break;
                        case '4':
                            FourText.Text += 4;
                            sum[4] += 4;
                            break;
                        case '5':
                            FiveText.Text += 5;
                            sum[5] += 5;
                            break;
                        case '6':
                            SixText.Text += 6;
                            sum[6] += 6;
                            break;
                        case '7':
                            SevenText.Text += 7;
                            sum[7] += 7;
                            break;
                        case '8':
                            EightText.Text += 8;
                            sum[8] += 8;
                            break;
                        case '9':
                            NineText.Text += 9;
                            sum[9] += 9;
                            break;
                    }
                }
                else
                {
                    switch (Result[i])
                    {
                        case '0':
                            ZeroText.Text += "(" + 0 + ")";
                            break;
                        case '1':
                            OneText.Text += "(" + 1 + ")";
                            break;
                        case '2':
                            TwoText.Text += "(" + 2 + ")";
                            break;
                        case '3':
                            ThreeText.Text += "(" + 3 + ")";
                            break;
                        case '4':
                            FourText.Text += "(" + 4 + ")";
                            break;
                        case '5':
                            FiveText.Text += "(" + 5 + ")";
                            break;
                        case '6':
                            SixText.Text += "(" + 6 + ")";
                            break;
                        case '7':
                            SevenText.Text += "(" + 7 + ")";
                            break;
                        case '8':
                            EightText.Text += "(" + 8 + ")";
                            break;
                        case '9':
                            NineText.Text += "(" + 9 + ")";
                            break;
                    }
                }
            }

            for (int i = 9; i < 13; i++)
            {
                switch (X[i])
                {
                    case 10:
                        TenText.Text += 10;
                        sum[10] += 10;
                        break;
                    case 11:
                        ElevenText.Text += 11;
                        sum[11] += 11;
                        break;
                    case 12:
                        TwelveText.Text += 12;
                        sum[12] += 12;
                        break;
                }
            }
            for (int i = 13; i < 15; i++)
            {
                switch (X[i])
                {
                    case 10:
                        TenText.Text += "(" + 10 + ")";
                        break;
                    case 11:
                        ElevenText.Text += "(" + 11 + ")";
                        break;
                    case 12:
                        TwelveText.Text += "(" + 12 + ")";
                        break;
                }
            }

            Sum123 = sum[1] + sum[2] + sum[3];
            if (Sum123 >= 12) { int buffer = Sum123; Sum123 = 0; Sum123 = Sum123 + buffer % 10 + buffer / 10; }
            SumBox123.Text += Sum123;
            Sum456 = sum[4] + sum[5] + sum[6];
            if (Sum456 >= 12) { int buffer = Sum456; Sum456 = 0; Sum456 = Sum456 + buffer % 10 + buffer / 10; }
            SumBox456.Text += Sum456;
            Sum789 = sum[7] + sum[8] + sum[9];
            if (Sum789 >= 12) { int buffer = Sum789; Sum789 = 0; Sum789 = Sum789 + buffer % 10 + buffer / 10; }
            SumBox789.Text += Sum789;
            Sum101112 = sum[10] + sum[11] + sum[12];
            if (Sum101112 >= 12) { int buffer = Sum101112; Sum101112 = 0; Sum101112 = Sum101112 + buffer % 10 + buffer / 10; }
            SumBox101112.Text += Sum101112;
            return Result;
        }

        

        private void CalcButton_Click(object sender, EventArgs e)
        {
            String Result = goodday(DateBDay.Text);

            label1.Text = label1.Text + X[9];
            label2.Text = n1 + " + " + n2 + " = " + X[10];
            label3.Text = X[9] + " - 2*" + X[1] + " = " + X[11];
            label4.Text = n3 + " + " + n4 + " = " + X[12];
            label5.Text = X[9] + " + " + X[11] + " = " + X[13];
            label6.Text = X[10] + " + " + X[12] + " = " + X[14];
                     
            if (OneText.Text == "") OneText.BackColor = Color.Red;
            else OneText.BackColor = Color.Green;
            if (TwoText.Text == "") TwoText.BackColor = Color.Red;
            else TwoText.BackColor = Color.Green;
            if (ThreeText.Text == "") ThreeText.BackColor = Color.Red;
            else ThreeText.BackColor = Color.Green;
            if (FourText.Text == "") FourText.BackColor = Color.Red;
            else FourText.BackColor = Color.Green;
            if (FiveText.Text == "") FiveText.BackColor = Color.Red;
            else FiveText.BackColor = Color.Green;
            if (SixText.Text == "") SixText.BackColor = Color.Red;
            else SixText.BackColor = Color.Green;
            if (SevenText.Text == "") SevenText.BackColor = Color.Red;
            else SevenText.BackColor = Color.Green;
            if (EightText.Text == "") EightText.BackColor = Color.Red;
            else EightText.BackColor = Color.Green;
            if (NineText.Text == "") NineText.BackColor = Color.Red;
            else NineText.BackColor = Color.Green;
            if (TenText.Text == "") TenText.BackColor = Color.Red;
            else TenText.BackColor = Color.Green;
            if (ElevenText.Text == "") ElevenText.BackColor = Color.Red;
            else ElevenText.BackColor = Color.Green;
            if (TwelveText.Text == "") TwelveText.BackColor = Color.Red;
            else TwelveText.BackColor = Color.Green;
        }

        void clearskob(RichTextBox box)
        {
            box.Text = new string(box.Text.Where(char.IsDigit).ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Parse("01.06.17");  // дата начала
            DateTime dt2 = DateTime.Parse("30.06.17");  // дата конца
            int i = 0;

            dataGridView1.Rows.Clear();
            chart1.Series.Clear();
            for (int i1 = 1; i1 <= 12; i1++) // добавление строк
            {
                dataGridView1.Rows.Add(); // добавление строки
                dataGridView1.Rows[i1 - 1].HeaderCell.Value = i1.ToString();
                string serieName = "Значение ячейки " + i1.ToString();
                chart1.Series.Add(serieName); // создаем график
                chart1.Series[i1 - 1].ChartType = SeriesChartType.Spline;
            }
            chart1.Update();
            for (DateTime id = dt1; id <= dt2; id = id.AddDays(1)) {
                    goodday(Convert.ToString(id.Day) + "." + Convert.ToString(id.Month) + "." + Convert.ToString(id.Year)); 
                    clearskob(OneText); clearskob(TwoText); clearskob(ThreeText); clearskob(FourText); clearskob(FiveText); clearskob(SixText);
                    clearskob(SevenText); clearskob(EightText); clearskob(NineText); clearskob(TenText); clearskob(ElevenText); clearskob(TwelveText);
                    //в каждую строку записывается значение по столбцам
                    dataGridView1.Rows[0].Cells[i].Value = Convert.ToString(OneText.Text.Length);
                    dataGridView1.Rows[1].Cells[i].Value = Convert.ToString(TwoText.Text.Length);
                    dataGridView1.Rows[2].Cells[i].Value = Convert.ToString(ThreeText.Text.Length);
                    dataGridView1.Rows[3].Cells[i].Value = Convert.ToString(FourText.Text.Length);
                    dataGridView1.Rows[4].Cells[i].Value = Convert.ToString(FiveText.Text.Length);
                    dataGridView1.Rows[5].Cells[i].Value = Convert.ToString(SixText.Text.Length);
                    dataGridView1.Rows[6].Cells[i].Value = Convert.ToString(SevenText.Text.Length);
                    dataGridView1.Rows[7].Cells[i].Value = Convert.ToString(EightText.Text.Length);
                    dataGridView1.Rows[8].Cells[i].Value = Convert.ToString(NineText.Text.Length);
                    dataGridView1.Rows[9].Cells[i].Value = Convert.ToString(TenText.Text.Length);
                    dataGridView1.Rows[10].Cells[i].Value = Convert.ToString(ElevenText.Text.Length);
                    dataGridView1.Rows[11].Cells[i].Value = Convert.ToString(TwelveText.Text.Length);
                    //координаты точек на графике
                    chart1.Series[0].Points.AddXY(i + 1, OneText.Text.Length);
                    chart1.Series[1].Points.AddXY(i + 1, TwoText.Text.Length);
                    chart1.Series[2].Points.AddXY(i + 1, ThreeText.Text.Length);
                    chart1.Series[3].Points.AddXY(i + 1, FourText.Text.Length);
                    chart1.Series[4].Points.AddXY(i + 1, FiveText.Text.Length);
                    chart1.Series[5].Points.AddXY(i + 1, SixText.Text.Length);
                    chart1.Series[6].Points.AddXY(i + 1, SevenText.Text.Length);
                    chart1.Series[7].Points.AddXY(i + 1, EightText.Text.Length);
                    chart1.Series[8].Points.AddXY(i + 1, NineText.Text.Length);
                    chart1.Series[9].Points.AddXY(i + 1, TenText.Text.Length);
                    chart1.Series[10].Points.AddXY(i + 1, ElevenText.Text.Length);
                    chart1.Series[11].Points.AddXY(i + 1, TwelveText.Text.Length);
                    i++;
                    if (i > dataGridView1.Columns.Count - 1) i = 0;
                    tabControl2.SelectedTab = tabPage16;
                }
            }

        private void tabControl2_Selected1(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabPage4)
                for (int i = 0; i < chart1.Series.Count; i++)
                {
                    chart1.Series[i].Enabled = false;
                    if (i == 0)
                        chart1.Series[i].Enabled = true;
                }
            if (e.TabPage == tabPage5)
                for (int i = 0; i < chart1.Series.Count; i++)
                {
                    chart1.Series[i].Enabled = false;
                    if (i == 1)
                        chart1.Series[i].Enabled = true;
                }
            if (e.TabPage == tabPage6)
                for (int i = 0; i < chart1.Series.Count; i++)
                {
                    chart1.Series[i].Enabled = false;
                    if (i == 2)
                        chart1.Series[i].Enabled = true;
                }
            if (e.TabPage == tabPage7)
                for (int i = 0; i < chart1.Series.Count; i++)
                {
                    chart1.Series[i].Enabled = false;
                    if (i == 3)
                        chart1.Series[i].Enabled = true;
                }
            if (e.TabPage == tabPage8)
                for (int i = 0; i < chart1.Series.Count; i++)
                {
                    chart1.Series[i].Enabled = false;
                    if (i == 4)
                        chart1.Series[i].Enabled = true;
                }
            if (e.TabPage == tabPage9)
                for (int i = 0; i < chart1.Series.Count; i++)
                {
                    chart1.Series[i].Enabled = false;
                    if (i == 5)
                        chart1.Series[i].Enabled = true;
                }
            if (e.TabPage == tabPage10)
                for (int i = 0; i < chart1.Series.Count; i++)
                {
                    chart1.Series[i].Enabled = false;
                    if (i == 6)
                        chart1.Series[i].Enabled = true;
                }
            if (e.TabPage == tabPage11)
                for (int i = 0; i < chart1.Series.Count; i++)
                {
                    chart1.Series[i].Enabled = false;
                    if (i == 7)
                        chart1.Series[i].Enabled = true;
                }
            if (e.TabPage == tabPage12)
                for (int i = 0; i < chart1.Series.Count; i++)
                {
                    chart1.Series[i].Enabled = false;
                    if (i == 8)
                        chart1.Series[i].Enabled = true;
                }
            if (e.TabPage == tabPage13)
                for (int i = 0; i < chart1.Series.Count; i++)
                {
                    chart1.Series[i].Enabled = false;
                    if (i == 9)
                        chart1.Series[i].Enabled = true;
                }
            if (e.TabPage == tabPage14)
                for (int i = 0; i < chart1.Series.Count; i++)
                {
                    chart1.Series[i].Enabled = false;
                    if (i == 10)
                        chart1.Series[i].Enabled = true;
                }
            if (e.TabPage == tabPage15)
                for (int i = 0; i < chart1.Series.Count; i++)
                {
                    chart1.Series[i].Enabled = false;
                    if (i == 11)
                        chart1.Series[i].Enabled = true;
                }
            if (e.TabPage == tabPage16)
                for (int i = 0; i < chart1.Series.Count; i++)
                {
                    chart1.Series[i].Enabled = true;
                }
        }


        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpbutton_Click(object sender, EventArgs e)
        {
            Form2 helpes = new Form2();
            helpes.Show();
        }
    }
}
