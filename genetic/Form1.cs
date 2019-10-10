using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace genetic
{
  public partial class Form1 : Form
  {
    public int Population;

    private int function(Point point)
    {
      int F;
      F = -point.X * point.X - 5 * point.Y * point.Y + 10 * point.X + (20 * point.Y) + 400;
      return F;
    }

    private int functionX(int x)
    {
      int F;
      F = -2 * x + 10;
      return F;
    }

    private int functionY(int y)
    {
      int F;
      F = -10 * y + 20;
      return F;
    }

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void calc_Click(object sender, EventArgs e)
    {


    }

    private string decToBin(int dec)
    {
      return Convert.ToString(dec, 2).PadLeft(5, '0');
    }

    private int binToDec(string bin)
    {
      return Convert.ToInt32("0b" + bin);
    }

    private string stick(Point point)
    {
      return decToBin(point.X) + decToBin(point.Y);
    }

    private Point unstick(string chromosome)
    {
      Point point = new Point(binToDec(chromosome.Substring(0, 5)), binToDec(chromosome.Substring(5)));
      return point;
    }

    private void clean_Click(object sender, EventArgs e)
    {
      dgv.ColumnCount = 0;
      dgv.RowCount = 1;
      nudCount.Enabled = true;
    }

    private void generate_Click(object sender, EventArgs e)
    {
      Population = Convert.ToInt32(nudCount.Value);
      nudCount.Enabled = false;
      dgv.RowCount = Population + 4;
      dgv.ColumnCount = 13;
      dgv.Columns[0].Name = "№";
      dgv.Columns[1].Name = "decimal X";
      dgv.Columns[2].Name = "decimal Y";
      dgv.Columns[3].Name = "binary X";
      dgv.Columns[4].Name = "binary Y";
      dgv.Columns[5].Name = "chromosome";
      dgv.Columns[6].Name = "F(X,Y)";
      dgv.Columns[7].Name = "F(X,Y)/Sum";
      dgv.Columns[8].Name = "Copies planned";
      dgv.Columns[9].Name = "Copies real";
      dgv.Columns[10].Name = "Pairs";
      dgv.Columns[11].Name = "Breakpoint";
      dgv.Columns[12].Name = "Children";
      dgv[0, dgv.RowCount - 3].Value = "Sum";
      dgv[0, dgv.RowCount - 2].Value = "Average";
      dgv[0, dgv.RowCount - 1].Value = "Max";
      Random random = new Random();
      for (int i = 0; i < Population; i++)
      {
        dgv[0, i].Value = i + 1;
        dgv[1, i].Value = random.Next(32);
        dgv[2, i].Value = random.Next(32);
        dgv[3, i].Value = decToBin(Convert.ToInt32(dgv[1, i].Value));
        dgv[4, i].Value = decToBin(Convert.ToInt32(dgv[2, i].Value));
        Point point = new Point(Convert.ToInt32(dgv[1, i].Value), Convert.ToInt32(dgv[2, i].Value));
        dgv[5, i].Value = stick(point);
        dgv[6, i].Value = function(point);
      }
      int sum = 0;
      int max = 0;
      for (int i = 0; i < Population; i++)
      {
        sum += Convert.ToInt32(dgv[6, i].Value);
        if (Convert.ToInt32(dgv[6, i].Value) > max)
        {
          max = Convert.ToInt32(dgv[6, i].Value);
        }
      }
      dgv[6, dgv.RowCount - 3].Value = sum;
      dgv[6, dgv.RowCount - 2].Value = sum / Population;
      dgv[6, dgv.RowCount - 1].Value = max;
      for (int i = 0; i < Population + 1; i++)
      {
        dgv[7, i].Value = Convert.ToDouble(dgv[6, i].Value) / sum;
        dgv[8, i].Value = Convert.ToDouble(dgv[7, i].Value) * Population;
      }
      for (int i = 0; i < Population; i++)
      {
        if (Convert.ToDouble(dgv[8, i].Value) > 0)
        {
          dgv[9, i].Value = Math.Round(Convert.ToDouble(dgv[8, i].Value));
        }
        else
        {
          dgv[9, i].Value = 0;
        }
        dgv[10, i].Value = Convert.ToDouble(dgv[7, i].Value) * Population;
      }
    }
  }
}
