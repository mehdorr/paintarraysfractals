using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Image MyImage
        {
            get { return pictureBox1.Image; }
            set
            {
                pictureBox1.Image = value;
            }
        }

        public Form1()
        {
            InitializeComponent();
            g = panelDraw.CreateGraphics();
        }


        public static Bitmap MatrixAsBitmap(int[,] data)
        {
            Form1 form1 = new Form1();

            if (Object.ReferenceEquals(null, data))
                return null;

            //array of usable brushes for drawing
            Brush[] brushes = new Brush[]
            {
                Brushes.LightGreen,
                Brushes.LightSalmon,
                Brushes.LightBlue,
                Brushes.LightPink,
                Brushes.LightSeaGreen,
                Brushes.LightCoral,
                Brushes.Gray
            };

            //array of usable pens for outline(s)
            Pen[] pens = new Pen[]
            {
                Pens.Black
            };

            //set step size
            int step_x = form1.pictureBox1.Width / (data.GetUpperBound(1) - data.GetLowerBound(1) + 1);
            int step_y = form1.pictureBox1.Height / (data.GetUpperBound(0) - data.GetLowerBound(0) + 1);

            //create a bitmap called result
            Bitmap result = new Bitmap((data.GetUpperBound(1) - data.GetLowerBound(1) + 1) * step_x, (data.GetUpperBound(0) - data.GetLowerBound(0) + 1) * step_y);

            //loop filling and drawing rectangles, conditional to size of the array
            using (Graphics gc = Graphics.FromImage(result))
            {
                for (int i = data.GetLowerBound(0); i <= data.GetUpperBound(0); ++i)
                    for (int j = data.GetLowerBound(1); j <= data.GetUpperBound(1); ++j)
                    {
                        int v = data[i, j];
                        gc.FillRectangle(brushes[v % brushes.Length], new Rectangle(j * step_x, i * step_y, step_x, step_y));
                        gc.DrawRectangle(pens[v % pens.Length], new Rectangle(j * step_x, i * step_y, step_x, step_y));
                    }
            }
            return result;
        }

        public void Draw()
        {
            Form1 form1 = new Form1();
            form1.pictureBox1.Image = MyImage;
            int sizeX = trackBar1.Value;
            int sizeY = trackBar2.Value;
            Random random = new Random();

            //initialise a default array
            int[,] A = new int[,] {
            {6, 6},
            {6, 6}
            };

            ResizeArray(ref A, sizeX, sizeY);

            int dim01 = A.GetLowerBound(0);
            int dim02 = A.GetUpperBound(0);
            int dim11 = A.GetLowerBound(1);
            int dim12 = A.GetUpperBound(1);

            for (int i = A.GetLowerBound(0); i <= A.GetUpperBound(0); i++)
            {
                for (int j = A.GetLowerBound(1); j <= A.GetUpperBound(1); j++)
                {
                    int randomNumber = random.Next(0, 6);
                    A[i, j] = randomNumber;
                }
            }

            //call the function
            Bitmap result = MatrixAsBitmap(A);

            //set the image property of pictureBox to result
            MyImage = result;
        }

        bool visible = true;

        private void button1_Click(object sender, EventArgs e)
        {
            if (visible == true)
            {
                panelDraw.Visible = false;
                panel1.Visible = false;
                fractals.Visible = false;
                visible = false;
            }
            else
            {
                panelDraw.Visible = true;
                panel1.Visible = true;
                fractals.Visible = true;
                visible = true;
            }
        }

        private void ResizeArray(ref int[,] Arr, int x, int y)
        {
            int[,] _arr = new int[x, y];
            int minRows = Math.Min(x, Arr.GetLength(0));
            int minCols = Math.Min(y, Arr.GetLength(1));
            for (int i = 0; i < minRows; i++)
                for (int j = 0; j < minCols; j++)
                    _arr[i, j] = Arr[i, j];
            Arr = _arr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Draw();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Draw();
        }

        bool startPaint = false;
        Graphics g;
        //nullable int for storing null value  
        int? initX = null;
        int? initY = null;

        private void panelDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (startPaint)
            {
                //set pen size and color using on-form controls
                Pen p = new Pen(penColor.BackColor, penSize.Value);
                //draw the line
                g.DrawLine(p, new Point(initX ?? e.X, initY ?? e.Y), new Point(e.X, e.Y));
                initX = e.X;
                initY = e.Y;
            }
        }

        private void panelDraw_MouseDown(object sender, MouseEventArgs e)
        {
            startPaint = true;
        }

        private void panelDraw_MouseUp(object sender, MouseEventArgs e)
        {
            startPaint = false;
            initX = null;
            initY = null;
        }

        private void penColor_Click(object sender, EventArgs e)
        {
            //open color dialog and select the color after user has clicked ok
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                penColor.BackColor = c.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //clear the graphics
            g.Clear(panelDraw.BackColor);
            //set the draw panel back color to white
            fractals.BackColor = Color.White;
        }

        // begin snowflake generator code

        // coords of points in Initiator
        private List<PointF> Initiator;

        // angles & distances for the generator
        private float ScaleFactor;
        private List<float> GeneratorDTheta;

        private void btnGo_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            // define the initiator & generator
            Initiator = new List<PointF>();
            float height = 0.75f * (Math.Min(
                fractals.ClientSize.Width,
                fractals.ClientSize.Height) - 20);
            float width = (float)(height / Math.Sqrt(3.0) * 2);
            float y3 = fractals.ClientSize.Height - 10;
            float y1 = y3 - height;
            float x3 = fractals.ClientSize.Height / 2;
            float x1 = x3 - width / 2;
            float x2 = x1 + width;
            Initiator.Add(new PointF(x1, y1));
            Initiator.Add(new PointF(x2, y1));
            Initiator.Add(new PointF(x3, y3));
            Initiator.Add(new PointF(x1, y1));

            ScaleFactor = 1 / 3f;                   // make the sub-segments a third of the size

            GeneratorDTheta = new List<float>();
            float pi_over_3 = (float)(Math.PI / 3f);
            GeneratorDTheta.Add(0);                 // draw in the original direction, then
            GeneratorDTheta.Add(-pi_over_3);        // turn -60 degrees, then
            GeneratorDTheta.Add(2 * pi_over_3);     // turn 120 degrees, then
            GeneratorDTheta.Add(-pi_over_3);        // turn -60 degrees

            // get the parameters
            int depth = fractalDepth.Value;

            Bitmap bm = new Bitmap(panelDraw.ClientSize.Width, panelDraw.ClientSize.Height);
            fractals.Image = bm;

            // draw the snowflake
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                DrawSnowflake(gr, depth);
            }

            this.Cursor = Cursors.Default;
        }

        // draw the complete snowflake
        private void DrawSnowflake(Graphics gr, int depth)
        {
            gr.Clear(fractals.BackColor);

            // draw the snowflake
            for (int i = 1; i < Initiator.Count; i++)
            {
                PointF p1 = Initiator[i - 1];
                PointF p2 = Initiator[i];

                float dx = p2.X - p1.X;
                float dy = p2.Y - p1.Y;
                float length = (float)Math.Sqrt(dx * dx + dy * dy);
                float theta = (float)Math.Atan2(dy, dx);
                DrawSnowflakeEdge(gr, depth, ref p1, theta, length);
            }
        }

        // recursively draw a snowflake, starting at (1, 1), in dir. theta and distance dist.; leave coords of the endpoint at (1, 1)
        private void DrawSnowflakeEdge(Graphics gr, int depth, ref PointF p1, float theta, float dist)
        {
            if (depth == 0)
            {
                PointF p2 = new PointF(
                    (float)(p1.X + dist * Math.Cos(theta)),
                    (float)(p1.Y + dist * Math.Sin(theta)));
                Pen p = new Pen(penColor.BackColor, 1);
                gr.DrawLine(p, p1, p2);
                p1 = p2;
                return;
            }

            // Recursively draw the edge.
            dist *= ScaleFactor;
            for (int i = 0; i < GeneratorDTheta.Count; i++)
            {
                theta += GeneratorDTheta[i];
                DrawSnowflakeEdge(gr, depth - 1, ref p1, theta, dist);
            }
        }

        // end snowflake generation code

        // begin fern generation code

        private float[] Prob = { 0.01f, 0.85f, 0.08f, 0.06f };
        private float[,,] Func =
        {
            {
                {0, 0},
                {0, 0.16f},
            },
            {
                {0.85f, 0.04f},
                {-0.04f, 0.85f},
            },
            {
                {0.2f, -0.26f},
                {0.23f, 0.22f},
            },
            {
                {-0.15f, 0.28f},
                {0.26f, 0.24f},
            },
        };
        private float[,] Plus =
        {
            {0, 0},
            {0, 1.6f},
            {0, 1.6f},
            {0, 0.44f},
        };

        private void MakeFern()
        {
            int wid = fractals.ClientSize.Width;
            int hgt = fractals.ClientSize.Height;
            Bitmap bm = new Bitmap(wid, hgt);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.Clear(fractals.BackColor);

                Random rnd = new Random();
                int func_num = 0, ix, iy;
                float x = 1, y = 1, x1, y1;
                for (int i = 1; i <= 100000; i++)
                {
                    double num = rnd.NextDouble();
                    for (int j = 0; j <= 3; j++)
                    {
                        num = num - Prob[j];
                        if (num <= 0)
                        {
                            func_num = j;
                            break;
                        }
                    }

                    x1 = x * Func[func_num, 0, 0] +
                         y * Func[func_num, 0, 1] +
                         Plus[func_num, 0];
                    y1 = x * Func[func_num, 1, 0] +
                         y * Func[func_num, 1, 1] +
                         Plus[func_num, 1];
                    x = x1;
                    y = y1;

                    const float w_xmin = -4;
                    const float w_xmax = 4;
                    const float w_ymin = -0.1f;
                    const float w_ymax = 10.1f;
                    const float w_wid = w_xmax - w_xmin;
                    const float w_hgt = w_ymax - w_ymin;
                    ix = (int)Math.Round((x - w_xmin) /
                        w_wid * fractals.ClientSize.Width);
                    iy = (int)Math.Round(
                        (fractals.ClientSize.Height - 1) -
                        (y - w_ymin) / w_hgt * hgt);
                    if ((ix >= 0) && (iy >= 0) &&
                        (ix < wid) && (iy < hgt))
                    {
                        bm.SetPixel(ix, iy, penColor.BackColor);
                    }
                }
            }

            // Display the result.
            fractals.Image = bm;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MakeFern();
        }
    }
}
