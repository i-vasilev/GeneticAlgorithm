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
    public int numCalc = 0;
    public Form1()
    {
      InitializeComponent();
    }

    #region События формы

    private void Form1_Load(object sender, EventArgs e)
    {

      chartPoints.Series[0].ToolTip = "X = #VALX, Y = #VALY, Count = #COUNT";
    }

    private void calc_Click(object sender, EventArgs e)
    {
      CalcOneStep(true);
    }

    private void clean_Click(object sender, EventArgs e)
    {
      numCalc = 0;
      dgv.ColumnCount = 0;
      dgv.RowCount = 1;
      nudCount.Enabled = true;
    }

    private void generate_Click(object sender, EventArgs e)
    {
      numCalc = 0;
      Population = Convert.ToInt32(nudCount.Value);
      Random random = new Random();
      List<Point> points = new List<Point>();
      for (int i = 0; i < Population; i++)
      {
        points.Add(new Point(random.Next(32), random.Next(32)));
      }
      ShowGenerations(points);
    }

    private void calc_Click_1(object sender, EventArgs e)
    {
      int stepCount = 20;
      for (int i = 0; i < stepCount; i++)
      {
        if (stepCount == i + 1)
        {
          CalcOneStep(true);
        }
        else
        {
          CalcOneStep(false);
        }
      }
    }

    #endregion

    #region Функционал Программы
    private void CalcOneStep(bool isUpdateVisual)
    {
      List<String> listParents = new System.Collections.Generic.List<String>();
      numCalc++;
      for (int i = 0; i < Population; i++)
      {
        for (int j = 0; j < Convert.ToInt32(dgv[9, i].Value); j++)
        {
          listParents.Add(dgv[5, i].Value.ToString());
        }
      }
      Random rnd = new Random();
      List<int> children = new List<int>();
      for (int i = 0; i < Population; i++)
      {
        int indexFirstParent = rnd.Next(0, listParents.Count), indexSecondParent = rnd.Next(0, listParents.Count);
        while (indexFirstParent == indexSecondParent)
        {
          indexSecondParent = rnd.Next(0, listParents.Count);
        }
        TwoGenerations twoGenerations = new TwoGenerations();
        twoGenerations.Parent1 = binToDec(listParents[indexFirstParent]);
        twoGenerations.Parent2 = binToDec(listParents[indexSecondParent]);
        if (indexFirstParent > indexSecondParent)
        {
          int z = indexFirstParent;
          indexFirstParent = indexSecondParent;
          indexSecondParent = z;
        }
        onePointCrossover(ref twoGenerations);
        if (numCalc % 3 == 0)
        {
          children.Add(mutation(twoGenerations.Child1));
          children.Add(mutation(twoGenerations.Child2));
        }
        else
        {
          children.Add(twoGenerations.Child1);
          children.Add(twoGenerations.Child2);
        }
      }
      children.Sort(new Comparison<int>((a, b) =>
      {
        Point p1 = unstick(decToBinChromosome(a)),
        p2 = unstick(decToBinChromosome(b));
        return function(p2) - function(p1);
      }));
      List<Point> points = new List<Point>();
      for (int i = 0; i < Population; i++)
      {
        points.Add(unstick(decToBinChromosome(children[i])));
      }
      if (isUpdateVisual)
      {
        ShowGenerations(points);
      }
    }


    private int function(Point point)
    {
      return Convert.ToInt32(3 * Math.Pow(point.X, 2) + 15 * Math.Pow(point.Y, 2) - 120 * point.X - 120 * point.Y - 300);
    }

    private void onePointCrossover(ref TwoGenerations twoGenerations)
    {
      int breakpoint = new Random().Next(1, 10);
      int z = 0;
      for (int i = 0; i < breakpoint; i++)
      {
        z <<= 1;
        z += 1;
      }
      int x1 = twoGenerations.Parent1 & z;
      int x2 = twoGenerations.Parent2 & ~z;
      twoGenerations.Child1 = x1 | x2;
      x1 = twoGenerations.Parent2 & z;
      x2 = twoGenerations.Parent1 & ~z;
      twoGenerations.Child2 = x1 | x2;
    }

    private void multiPointCrossover(ref TwoGenerations twoGenerations)
    {
      for (int i = 0; i < 10; i += 2)
      {
        int z = 1;
        z <<= i;
        int x1 = twoGenerations.Parent1 & z;
        int x2 = twoGenerations.Parent2 & z;
        twoGenerations.Child1 |= x1;
        twoGenerations.Child2 |= x2;
        x1 = twoGenerations.Parent1 & z;
        x2 = twoGenerations.Parent2 & z;
        z <<= 1;
        twoGenerations.Child1 |= x1;
        twoGenerations.Child2 |= x2;
      }
    }

    private int mutation(int x)
    {
      Random rnd = new Random();
      for (int i = 0; i < 10; i += 2)
      {
        double d = rnd.NextDouble();
        System.Threading.Thread.Sleep(10);
        if (d > 0.5)
        {
          int z = 3;
          z <<= i;
          int NonPartX = (~x & z);
          x = (x & ~z) | NonPartX;
        }
      }
      return x;
    }

    private string decToBin(int dec)
    {
      return Convert.ToString(dec, 2).PadLeft(5, '0');
    }

    private int binToDec(string bin)
    {
      return Convert.ToInt32(bin, 2);
    }

    private String decToBinChromosome(int dec)
    {
      return Convert.ToString(dec, 2).PadLeft(10, '0');
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


    private void ShowGenerations(List<Point> points)
    {
      Population = Convert.ToInt32(nudCount.Value);
      nudCount.Enabled = false;
      dgv.Rows.Clear();
      dgv.Columns.Clear();
      dgv.RowCount = Population + 3;
      dgv.ColumnCount = 10;
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
      foreach (DataGridViewColumn item in dgv.Columns)
      {
        item.SortMode = DataGridViewColumnSortMode.NotSortable;
      }
      dgv[0, dgv.RowCount - 3].Value = "Sum";
      dgv[0, dgv.RowCount - 2].Value = "Average";
      dgv[0, dgv.RowCount - 1].Value = "Max";
      for (int i = 0; i < Population; i++)
      {
        dgv[0, i].Value = i + 1;
        dgv[1, i].Value = points[i].X;
        dgv[2, i].Value = points[i].Y;
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
        ShowGraph(points);
      }
    }
   
    private void ShowGraph(List<Point> points)
    {
      chartPoints.Series[0].Points.Clear();
      //chartPoints.ChartAreas[0].AxisX.
      foreach (Point item in points)
      {
        chartPoints.Series[0].Points.AddXY(item.X, item.Y);
      }
    }
    #endregion
  }

  public class TwoGenerations
  {
    public int Parent1 { get; set; }
    public int Parent2 { get; set; }
    public int Child1 { get; set; }
    public int Child2 { get; set; }
  }
}
