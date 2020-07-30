using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace Case1
{
    public partial class MainForm : Form
    { 
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Main.ClearTable(tableLayoutPanel1);

            Main.UpdateStartEnd(startNumericUpDown1, startNumericUpDown2,
                                endNumericUpDown1, endNumericUpDown2);

            Main.PaintOnlyStartEnd(tableLayoutPanel1);
        }

        private void buttonBegin_Click(object sender, EventArgs e)
        {
            Main.ClearTable(tableLayoutPanel1);

            Main.UpdateStartEnd(startNumericUpDown1, startNumericUpDown2,
                                endNumericUpDown1, endNumericUpDown2);

            Main.FillTable(tableLayoutPanel1);

            Main.FillMatrixWeights();

            //DEBUG
            //Main.DrawMatrixWeights(tableLayoutPanel1);

            OnOffControlPanel(false);

            Main.StartEmulation(tableLayoutPanel1);

            Main.ShowResult();

            OnOffControlPanel(true);
        }

        private void OnOffControlPanel(bool newCondition = false)
        {
            buttonUpdate.Enabled = newCondition;
            buttonBegin.Enabled = newCondition;
            startNumericUpDown1.Enabled = newCondition;
            startNumericUpDown2.Enabled = newCondition;
            endNumericUpDown1.Enabled = newCondition;
            endNumericUpDown2.Enabled = newCondition;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Filling the table with labels
            for (int y = 0; y < tableLayoutPanel1.RowCount; y++)
            {
                for (int x = 0; x < tableLayoutPanel1.ColumnCount; x++)
                {
                    tableLayoutPanel1.Controls.Add(new Label() { TextAlign = System.Drawing.ContentAlignment.MiddleCenter}, x, y);
                }
            }

            // Set size of table
            Settings.CountRows = tableLayoutPanel1.RowCount;
            Settings.CountColumns = tableLayoutPanel1.ColumnCount;
            Settings.Area = Settings.CountColumns * Settings.CountRows;

            // Update table
            Main.UpdateStartEnd(startNumericUpDown1, startNumericUpDown2,
                                endNumericUpDown1, endNumericUpDown2);
            Main.PaintOnlyStartEnd(tableLayoutPanel1);

            //Init random
            Settings.random = new Random();
        }
    }

    public static class Settings
    {
        public static int CountColumns { get; set; }
        public static int CountRows { get; set; }
        public static int Area { get; set; }
       
        /*
        public const double ProbabilityStep = 0.1;
        public const double ProbabilityStart = 0.7;
        public const double ProbabilityEnd = 1;
        */

        public const double ProbabilityStep = 10;
        public const double ProbabilityStart = 60;
        public const double ProbabilityEnd = 100;

        public static List<Tuple<double, Color>> ProbabilityColors = new List<Tuple<double, Color>>         
        {
            new Tuple<double, Color>(0, Color.LightGray),
            new Tuple<double, Color>(20, Color.LightBlue),
            new Tuple<double, Color>(40, Color.SkyBlue),
            new Tuple<double, Color>(60, Color.LightSkyBlue),
            new Tuple<double, Color>(80, Color.DeepSkyBlue)
        };
        public static Color DroneColor = Color.Magenta;

        public static Random random;

        public const int StepSleep = 100;
    }

    public static class Main
    {
        private static int start_x;
        private static int start_y;
        private static int end_x;
        private static int end_y;

        private static double[,] probability = new double[Settings.CountRows, Settings.CountColumns];
        private static bool[,] used = new bool[Settings.CountRows, Settings.CountColumns];
        private static int count_used = 0;
        private static bool found_flag = false;

        public static void ClearTable(TableLayoutPanel table)
        {
            table.Visible = false;

            for (int y = 0; y < table.RowCount; y++)
            {
                for (int x = 0; x < table.ColumnCount; x++)
                {
                    table.GetControlFromPosition(x, y).Text = "";
                    table.GetControlFromPosition(x, y).BackColor = SystemColors.Control;
                }
            }

            table.Visible = true;
        }

        public static void UpdateStartEnd(NumericUpDown startX, NumericUpDown startY, NumericUpDown endX, NumericUpDown endY)
        {
            start_x = Decimal.ToInt32(startX.Value) - 1;
            start_y = Decimal.ToInt32(startY.Value) - 1;
            end_x = Decimal.ToInt32(endX.Value) - 1;
            end_y = Decimal.ToInt32(endY.Value) - 1;
        }

        public static void PaintOnlyStartEnd(TableLayoutPanel table)
        {
            table.Visible = false;

            for (int y = 0; y < table.RowCount; y++)
            {
                for (int x = 0; x < table.ColumnCount; x++)
                {
                    table.GetControlFromPosition(x, y).Text = "";
                    table.GetControlFromPosition(x, y).ForeColor = Color.Black;
                    table.GetControlFromPosition(x, y).Font = new Font("Microsoft Sans Serif", 8);
                }
            }

            if (start_x == end_x && start_y == end_y)
            {
                table.GetControlFromPosition(start_x, start_y).Text = "SX";
                table.GetControlFromPosition(start_x, start_y).ForeColor = Color.Violet;
                table.GetControlFromPosition(start_x, start_y).Font = new Font("Microsoft Sans Serif", 6);
            }
            else
            {
                table.GetControlFromPosition(start_x, start_y).Text = "S";
                table.GetControlFromPosition(start_x, start_y).ForeColor = Color.Blue;
                table.GetControlFromPosition(start_x, start_y).Font = new Font("Microsoft Sans Serif", 8);

                table.GetControlFromPosition(end_x, end_y).Text = "X";
                table.GetControlFromPosition(end_x, end_y).ForeColor = Color.Red;
                table.GetControlFromPosition(end_x, end_y).Font = new Font("Microsoft Sans Serif", 8);
            }

            table.Visible = true;
        }

        public static void FillTable(TableLayoutPanel table)
        {
            table.Visible = false;
            for (int y = 0; y < table.RowCount; y++)
            {
                for (int x = 0; x < table.ColumnCount; x++)
                {
                    if (x == start_x && x == end_x && y == start_y && y == end_y)
                    {
                        table.GetControlFromPosition(x, y).Text = "SX";
                        table.GetControlFromPosition(x, y).ForeColor = Color.Violet;
                        table.GetControlFromPosition(x, y).Font = new Font("Microsoft Sans Serif", 6);

                    }
                    else if (x == start_x && y == start_y)
                    {
                        table.GetControlFromPosition(x, y).Text = "S";
                        table.GetControlFromPosition(x, y).ForeColor = Color.Blue;
                        table.GetControlFromPosition(x, y).Font = new Font("Microsoft Sans Serif", 8);
                    }
                    else if (x == end_x && y == end_y)
                    {
                        table.GetControlFromPosition(x, y).Text = "X";
                        table.GetControlFromPosition(x, y).ForeColor = Color.Red;
                        table.GetControlFromPosition(x, y).Font = new Font("Microsoft Sans Serif", 8);
                    }
                    else
                    {
                        table.GetControlFromPosition(x, y).Text = "?";
                        table.GetControlFromPosition(x, y).ForeColor = Color.Black;
                        table.GetControlFromPosition(x, y).Font = new Font("Microsoft Sans Serif", 8);
                    }
                }
            }
            table.Visible = true;
        }

        public static void FillMatrixWeights()
        {
            double ProbabilityOnLine(Geometry.Point a, Geometry.Point b, Geometry.Point c)
            {
                if (a == b)
                    return Settings.ProbabilityEnd;

                Geometry.Point ac = new Geometry.Point(a, c);
                Geometry.Point ab = new Geometry.Point(a, b);
                double k = ac.Lenght() / ab.Lenght();
                double prob = Settings.ProbabilityStart + k * (Settings.ProbabilityEnd - Settings.ProbabilityStart);
                return prob;
            }

            // init
            for (int y = 0; y < Settings.CountRows; y++)
            {
                for (int x = 0; x < Settings.CountColumns; x++)
                {
                    probability[y, x] = 0;
                    used[y, x] = false;
                }
            }

            // calc line
            Geometry.Point start = new Geometry.Point(start_x + 0.5, start_y + 0.5);
            Geometry.Point end = new Geometry.Point(end_x + 0.5, end_y + 0.5);

            // calc weights
            for (int y = 0; y < Settings.CountRows; y++)
            {
                for (int x = 0; x < Settings.CountColumns; x++)
                {
                    double x1 = x + 0.5;
                    double y1 = y + 0.5;

                    Geometry.Point o = new Geometry.Point(x1, y1);
                    Geometry.Point c = Geometry.NearestPointOnSegment(o, start, end);
                    Geometry.Point oc = new Geometry.Point(o, c);

                    double c_prob = ProbabilityOnLine(start, end, c);
                    double prob = Math.Max(c_prob - Settings.ProbabilityStep * oc.Lenght(), 0);

                    probability[y, x] = prob;
                }
            }
        }

        public static void DrawMatrixWeights(TableLayoutPanel table)
        {
            table.Visible = false;

            for (int y = 0; y < Settings.CountRows; y++)
            {
                for (int x = 0; x < Settings.CountColumns; x++)
                {
                    table.GetControlFromPosition(x, y).Text = Math.Round(probability[y, x]).ToString();
                    table.GetControlFromPosition(x, y).Font = new Font("Microsoft Sans Serif", 6);
                }
            }

            table.Visible = true;
        }

        public static void StartEmulation(TableLayoutPanel table)
        {
            //pre init
            count_used = 0;
            found_flag = false;

            //init
            List<Drone> drones = new List<Drone>
            {
                new Drone(1, start_x, start_y, 0, 1),
                new Drone(2, start_x, start_y, 1, 0),
                new Drone(3, start_x, start_y, 0, -1),
                new Drone(4, start_x, start_y, -1, 0)
            };
            double gbest = -1;
            int gbest_x = -1;
            int gbest_y = -1;

            //start_point processing
            used[start_y, start_x] = true;
            count_used++;
            PaintUsedCell(table, start_x, start_y, probability[start_y, start_x]);

            for (int i = 0; i < drones.Count; i++)
                drones[i].UpdateBest(probability[start_y, start_x], start_x, start_y);
            if (probability[start_y, start_x] > gbest)
            {
                gbest = probability[start_y, start_x];
                gbest_x = start_x;
                gbest_y = start_y;
            }

            //Main search cycle (Particle swarm optimization)
            while (!(count_used == Settings.Area || found_flag))
            {
                for (int i = 0; i < drones.Count; i++)
                {
                    int x0 = drones[i].x;
                    int y0 = drones[i].y;

                    drones[i].UpdateV(gbest_x, gbest_y);
                    drones[i].Move(used);
                    int x = drones[i].x;
                    int y = drones[i].y;
                    PaintDroneMove(table, x0, y0, x, y, drones[i].id);

                    double w = probability[y, x];
                    if (w == Settings.ProbabilityEnd)
                        found_flag = true;
                    
                    drones[i].UpdateBest(w, x, y);
                    if (w > gbest)
                    {
                        gbest = w;
                        gbest_x = x;
                        gbest_y = y;
                    }

                    used[y, x] = true;
                    count_used++;
                    PaintUsedCell(table, x, y, w);

                    //break if found or full explored
                    if (count_used == Settings.Area || found_flag)
                        break;
                }

                //Thread.Sleep(Settings.StepSleep);
                table.Refresh();
            }
        }

        private static void PaintDroneMove(TableLayoutPanel table, int x, int y, int nx, int ny, int id)
        {
            if (x == start_x && y == start_y)
                table.GetControlFromPosition(x, y).Text = "S";
            else if (x == end_x && y == end_y)
                table.GetControlFromPosition(x, y).Text = "X";
            else
                table.GetControlFromPosition(x, y).Text = "";
            table.GetControlFromPosition(nx, ny).Text = id.ToString();
            table.GetControlFromPosition(nx, ny).ForeColor = Settings.DroneColor;
        }

        private static void PaintUsedCell(TableLayoutPanel table, int x, int y, double prob)
        {
            int last = 0;
            for (int i = 1; i < Settings.ProbabilityColors.Count; i++)
            {
                if (prob >= Settings.ProbabilityColors[i].Item1)
                    last = i;
                else
                    break;
            }

            if (table.GetControlFromPosition(x, y).Text == "?")
                table.GetControlFromPosition(x, y).Text = "";
            table.GetControlFromPosition(x, y).BackColor = Settings.ProbabilityColors[last].Item2;
        }

        public static void ShowResult()
        {
            List<Tuple<double, int, int>> res = new List<Tuple<double, int, int>>();

            for (int y = 0; y < Settings.CountRows; y++)
            {
                for (int x = 0; x < Settings.CountColumns; x++)
                {
                    if (used[y, x])
                        res.Add(new Tuple<double, int, int>(probability[y, x], x, y));
                }
            }

            res.Sort();
            String ans = "";
            for (int i = res.Count - 1; i >= Math.Max(res.Count - 5, 0); --i)
                ans += (res[i].Item2 + 1).ToString() + " " + 
                    (res[i].Item3 + 1).ToString() + ": " + 
                    Math.Round(res[i].Item1).ToString() + "\n";

            MessageBox.Show("Конец поисков\n" +
                            "Наибольшая вероятность найти человека в следующих точках:\n" +
                            ans);
        }
    }

    public class Drone
    {
        public int id { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int vx { get; set; }
        public int vy { get; set; }
        public double pbest { get; set; }
        public int pbest_x { get; set; }
        public int pbest_y { get; set; }

        public Drone()
        {
            this.id = 1;
            this.x = 1; this.y = 1;
            this.vx = 0; this.vy = 0;
            this.pbest = -1;
            this.pbest_x = -1;
            this.pbest_y = -1;
        }

        public Drone(int id, int x, int y, int vx, int vy)
        {
            this.id = id;
            this.x = x; this.y = y;
            this.vx = vx; this.vy = vy;
            this.pbest = -1;
            this.pbest_x = -1;
            this.pbest_y = -1;
        }

        public void Move(in bool[,] used)
        {
            int nx = x + vx;
            int ny = y + vy;

            if (IsPermissilbleXY(nx, ny, used))
            {
                x = nx;
                y = ny;
            }
            else
            {
                int minlen = 100 * (Settings.CountColumns * Settings.CountColumns + 
                            Settings.CountRows * Settings.CountRows + 1);
                int minlen2 = Settings.CountColumns * Settings.CountColumns +
                            Settings.CountRows * Settings.CountRows + 1;
                int minx = -1;
                int miny = -1;

                for (int y1 = 0; y1 < Settings.CountRows; y1++)
                {
                    for (int x1 = 0; x1 < Settings.CountColumns; x1++)
                    {
                        if (IsPermissilbleXY(x1, y1, used))
                        {
                            int len = (nx - x1) * (nx - x1) + (ny - y1) * (ny - y1);
                            int len2 = (x - x1) * (x - x1) + (y - y1) * (y - y1);

                            if (len < minlen)
                            {
                                minlen = len;
                                minlen2 = len2;
                                minx = x1;
                                miny = y1;
                            }
                            else if (len == minlen && len2 < minlen2)
                            {
                                minlen2 = len2;
                                minx = x1;
                                miny = y1;
                            }
                        }
                    }
                }

                vx = minx - x;
                vy = miny - y;
                x = minx;
                y = miny;
            }
        }

        public bool IsPermissilbleXY(int xn, int yn, in bool[,] used)
        {
            if (0 <= xn && xn < Settings.CountColumns && 0 <= yn && yn < Settings.CountRows)
            {
                return !used[yn, xn];
            }
            return false;
        }

        public void UpdateV(int gbest_x, int gbest_y)
        {
            double pers_rand = 2 * (Settings.random.NextDouble() - 0.5);
            double glob_rand = 2 * (Settings.random.NextDouble() - 0.5);

            vx = (int)(vx + pers_rand * (pbest_x - x) + glob_rand * (gbest_x - x));
            vy = (int)(vy + pers_rand * (pbest_y - y) + glob_rand * (gbest_y - y));
        }

        public void UpdateBest(double prob, int x1, int y1)
        {
            if (prob > this.pbest)
            {
                pbest = prob;
                pbest_x = x1;
                pbest_y = y1;
            }
        }
    }
}
