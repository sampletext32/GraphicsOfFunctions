using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace GraphicsNamespace
{
    public partial class MainForm : Form
    {
        List<Equation> equations = new List<Equation>();
        Color colorofAxis = Color.Black;
        Color colorofLines = Color.LightGray;
        HashSet<Point> AxisCollisionPoints = new HashSet<Point>();

        PointF SelectedPointOfEquation = new PointF(int.MinValue, int.MinValue);
        PointF MinFuncPoint = new PointF(int.MinValue, int.MinValue);
        PointF MaxFuncPoint = new PointF(int.MinValue, int.MinValue);

        MovingPoint currentMovingPoint = null;

        Equation_ByPoints CurrentCreatingEquation = null;

        Bitmap PngBITMAP;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayEquations();
            PngBITMAP = new Bitmap(pictureBoxMainField.Width, pictureBoxMainField.Height);
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            float scaleX = (float)numericUpDownScaleX.Value;
            float scaleY = (float)numericUpDownScaleY.Value;
            float centerX = pictureBoxMainField.Width / 2;
            float centerY = pictureBoxMainField.Height / 2;

            Graphics g = Graphics.FromImage(PngBITMAP);

            float drawCoordX = centerX;

            while (drawCoordX >= 0)
            {
                drawCoordX -= scaleX;
                e.Graphics.DrawLine(new Pen(colorofLines), drawCoordX, 0, drawCoordX, pictureBoxMainField.Height);
                g.DrawLine(new Pen(colorofLines), drawCoordX, 0, drawCoordX, pictureBoxMainField.Height);
            }
            drawCoordX = centerX;
            while (drawCoordX <= pictureBoxMainField.Width)
            {
                drawCoordX += scaleX;
                e.Graphics.DrawLine(new Pen(colorofLines), drawCoordX, 0, drawCoordX, pictureBoxMainField.Height);
                g.DrawLine(new Pen(colorofLines), drawCoordX, 0, drawCoordX, pictureBoxMainField.Height);
            }

            float drawCoordY = centerY;
            while (drawCoordY >= 0)
            {
                drawCoordY -= scaleY;
                e.Graphics.DrawLine(new Pen(colorofLines), 0, drawCoordY, pictureBoxMainField.Width, drawCoordY);
                g.DrawLine(new Pen(colorofLines), 0, drawCoordY, pictureBoxMainField.Width, drawCoordY);
            }
            drawCoordY = centerY;
            while (drawCoordY <= pictureBoxMainField.Height)
            {
                drawCoordY += scaleY;
                e.Graphics.DrawLine(new Pen(colorofLines), 0, drawCoordY, pictureBoxMainField.Width, drawCoordY);
                g.DrawLine(new Pen(colorofLines), 0, drawCoordY, pictureBoxMainField.Width, drawCoordY);
            }
            //нарисовать оси
            e.Graphics.DrawLine(new Pen(colorofAxis), 0, centerY, pictureBoxMainField.Width, centerY);
            e.Graphics.DrawLine(new Pen(colorofAxis), centerX, 0, centerX, pictureBoxMainField.Height);

            g.DrawLine(new Pen(colorofAxis), 0, centerY, pictureBoxMainField.Width, centerY);
            g.DrawLine(new Pen(colorofAxis), centerX, 0, centerX, pictureBoxMainField.Height);
            for (int i = 0; i < equations.Count; i++)
            {
                if (equations[i] is Equation_ByPoints)
                {
                    for (int j = 1; j < (equations[i] as Equation_ByPoints).Points.Count; j++)
                    {
                        e.Graphics.DrawLine(equations[i].DrawPen, (centerX + (equations[i] as Equation_ByPoints).Points[j - 1].X * scaleX), (centerY - (equations[i] as Equation_ByPoints).Points[j - 1].Y * scaleY), (centerX + (equations[i] as Equation_ByPoints).Points[j].X * scaleX), (centerY - (equations[i] as Equation_ByPoints).Points[j].Y * scaleY));
                        g.DrawLine(equations[i].DrawPen, (centerX + (equations[i] as Equation_ByPoints).Points[j - 1].X * scaleX), (centerY - (equations[i] as Equation_ByPoints).Points[j - 1].Y * scaleY), (centerX + (equations[i] as Equation_ByPoints).Points[j].X * scaleX), (centerY - (equations[i] as Equation_ByPoints).Points[j].Y * scaleY));
                    }
                    continue;
                }
                float prevX = equations[i].FromX;
                if (equations[i] is Sqrt_Equation && prevX < 0)
                {
                    prevX = 0f;
                }
                float prevY = equations[i].GetValueInPoint(prevX);
                while (prevX <= equations[i].ToX)
                {
                    float curX = prevX + 0.01f;
                    float curY = equations[i].GetValueInPoint(curX);
                    if (float.IsNaN(curY))
                    {
                        prevX += 0.01f;
                        continue;
                    }
                    if (float.IsNaN(prevY))
                    {
                        continue;
                    }
                    e.Graphics.DrawLine(equations[i].DrawPen, (centerX + prevX * scaleX), (centerY - prevY * scaleY), (centerX + curX * scaleX), (centerY - curY * scaleY));
                    g.DrawLine(equations[i].DrawPen, (centerX + prevX * scaleX), (centerY - prevY * scaleY), (centerX + curX * scaleX), (centerY - curY * scaleY));
                    prevX = curX;
                    prevY = curY;
                }
            }
            if (CurrentCreatingEquation != null && CurrentCreatingEquation.Points.Count >= 2)
            {
                for (int i = 1; i < CurrentCreatingEquation.Points.Count; i++)
                {
                    e.Graphics.DrawLine(CurrentCreatingEquation.DrawPen, (centerX + CurrentCreatingEquation.Points[i - 1].X * scaleX), (centerY - CurrentCreatingEquation.Points[i - 1].Y * scaleY), (centerX + CurrentCreatingEquation.Points[i].X * scaleX), (centerY - CurrentCreatingEquation.Points[i].Y * scaleY));
                    g.DrawLine(CurrentCreatingEquation.DrawPen, (centerX + CurrentCreatingEquation.Points[i - 1].X * scaleX), (centerY - CurrentCreatingEquation.Points[i - 1].Y * scaleY), (centerX + CurrentCreatingEquation.Points[i].X * scaleX), (centerY - CurrentCreatingEquation.Points[i].Y * scaleY));
                }
            }
            for (int i = 0; i < AxisCollisionPoints.Count; i++)
            {
                e.Graphics.FillEllipse(Brushes.Red, (centerX + (AxisCollisionPoints.ElementAt(i).X/100f)*scaleX) - 5f, (centerY - (AxisCollisionPoints.ElementAt(i).Y/ 100f)*scaleY) - 5f, 10, 10);
                //g.FillEllipse(Brushes.Red, (centerX + (AxisCollisionPoints.ElementAt(i).X / 100f) * scaleX) - 5f, (centerY - (AxisCollisionPoints.ElementAt(i).Y / 100f) * scaleY) - 5f, 10, 10);
            }
            if (SelectedPointOfEquation.X != int.MinValue && SelectedPointOfEquation.Y != int.MinValue)
            {
                e.Graphics.FillEllipse(Brushes.LightGreen, (centerX + (SelectedPointOfEquation.X) * scaleX) - 5f, (centerY - (SelectedPointOfEquation.Y) * scaleY) - 5f, 10, 10);
                //g.FillEllipse(Brushes.LightGreen, (centerX + (SelectedPointOfEquation.X) * scaleX) - 5f, (centerY - (SelectedPointOfEquation.Y) * scaleY) - 5f, 10, 10);
            }
            if (MinFuncPoint.X != int.MinValue && MinFuncPoint.Y != int.MinValue)
            {
                e.Graphics.FillEllipse(Brushes.Coral, (centerX + (MinFuncPoint.X) * scaleX) - 5f, (centerY - (MinFuncPoint.Y) * scaleY) - 5f, 10, 10);
                //g.FillEllipse(Brushes.Coral, (centerX + (MinFuncPoint.X) * scaleX) - 5f, (centerY - (MinFuncPoint.Y) * scaleY) - 5f, 10, 10);
            }
            if (MaxFuncPoint.X != int.MinValue && MaxFuncPoint.Y != int.MinValue)
            {
                e.Graphics.FillEllipse(Brushes.Coral, (centerX + (MaxFuncPoint.X) * scaleX) - 5f, (centerY - (MaxFuncPoint.Y) * scaleY) - 5f, 10, 10);
                //g.FillEllipse(Brushes.Coral, (centerX + (MinFuncPoint.X) * scaleX) - 5f, (centerY - (MinFuncPoint.Y) * scaleY) - 5f, 10, 10);
            }

            if (currentMovingPoint != null)
            {
                PointF currentPoint = currentMovingPoint.GetCurrentDisplayPoint();
                e.Graphics.FillEllipse(Brushes.Black, (centerX + (currentPoint.X) * scaleX) - 5f, (centerY - (currentPoint.Y) * scaleY) - 5f, 10, 10);
            }
        }
        private void NumericUpDownScaleY_ValueChanged(object sender, System.EventArgs e)
        {
            pictureBoxMainField.Refresh();
        }
        private void NumericUpDownScaleX_ValueChanged(object sender, System.EventArgs e)
        {
            pictureBoxMainField.Refresh();
        }
        private void DisplayEquations()
        {
            listBoxEquations.Items.Clear();
            for (int i = 0; i < equations.Count; i++)
            {
                listBoxEquations.Items.Add(equations[i].ToString());
            }
        }
        private void comboBoxSelectNewEquationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxNewCoef1.Text = "0";
            textBoxNewCoef2.Text = "0";
            textBoxNewVerticalOffset.Text = "0";
            if (comboBoxSelectNewEquationType.SelectedIndex == -1)
            {
                groupBoxNewDF.Visible = false;
            }
            else
            {
                groupBoxNewDF.Visible = true;
            }
            //y = a
            //y = kx + b
            //y = ax ^ 2 + bx + c
            //y = a / x + b
            //y = sqrt(a * x) + b
            switch (comboBoxSelectNewEquationType.SelectedIndex)
            {
                case -1:
                    labelNewCoef1.Visible = false;
                    labelNewCoef2.Visible = false;
                    labelNewVerticalOffset.Visible = false;

                    textBoxNewCoef1.Visible = false;
                    textBoxNewCoef2.Visible = false;
                    textBoxNewVerticalOffset.Visible = false;
                    break;
                case 0:
                    labelNewCoef1.Visible = false;
                    labelNewCoef2.Visible = false;
                    labelNewVerticalOffset.Visible = true;

                    textBoxNewCoef1.Visible = false;
                    textBoxNewCoef2.Visible = false;
                    textBoxNewVerticalOffset.Visible = true;
                    break;
                case 1:
                    labelNewCoef1.Visible = true;
                    labelNewCoef2.Visible = false;
                    labelNewVerticalOffset.Visible = true;

                    textBoxNewCoef1.Visible = true;
                    textBoxNewCoef2.Visible = false;
                    textBoxNewVerticalOffset.Visible = true;
                    break;
                case 2:
                    labelNewCoef1.Visible = true;
                    labelNewCoef2.Visible = true;
                    labelNewVerticalOffset.Visible = true;

                    textBoxNewCoef1.Visible = true;
                    textBoxNewCoef2.Visible = true;
                    textBoxNewVerticalOffset.Visible = true;
                    break;
                case 3:
                    labelNewCoef1.Visible = true;
                    labelNewCoef2.Visible = false;
                    labelNewVerticalOffset.Visible = true;

                    textBoxNewCoef1.Visible = true;
                    textBoxNewCoef2.Visible = false;
                    textBoxNewVerticalOffset.Visible = true;
                    break;
                case 4:
                    labelNewCoef1.Visible = true;
                    labelNewCoef2.Visible = false;
                    labelNewVerticalOffset.Visible = true;

                    textBoxNewCoef1.Visible = true;
                    textBoxNewCoef2.Visible = false;
                    textBoxNewVerticalOffset.Visible = true;
                    break;
                default:
                    break;
            }
            numericUpDownNewStartX.Value = -60;
            numericUpDownNewToX.Value = 60;
        }

        private void buttonAddNewEquation_Click(object sender, EventArgs e)
        {
            if (comboBoxSelectNewEquationType.SelectedIndex == -1)
            {
                MessageBox.Show("Сначала выберите тип графика");
                return;
            }
            if (textBoxNewCoef1.Text.Length == 0 || textBoxNewCoef2.Text.Length == 0 || textBoxNewVerticalOffset.Text.Length == 0) 
            {
                MessageBox.Show("Не заполнен один из коэффициентов");
                return;
            }
            switch (comboBoxSelectNewEquationType.SelectedIndex)
            {
                case 0:
                    equations.Add(new Numeric_Equation(float.Parse(textBoxNewCoef1.Text.Replace('.', ',')), (float)numericUpDownNewStartX.Value, (float)numericUpDownNewToX.Value));
                    comboBoxSelectNewEquationType.SelectedIndex = -1;
                    break;
                case 1:
                    equations.Add(new Linear_Equation(float.Parse(textBoxNewCoef1.Text.Replace('.', ',')), float.Parse(textBoxNewCoef2.Text.Replace('.', ',')), (float)numericUpDownNewStartX.Value, (float)numericUpDownNewToX.Value));
                    comboBoxSelectNewEquationType.SelectedIndex = -1;
                    break;
                case 2:
                    equations.Add(new Quad_Equation(float.Parse(textBoxNewCoef1.Text.Replace('.', ',')), float.Parse(textBoxNewCoef2.Text.Replace('.', ',')), float.Parse(textBoxNewVerticalOffset.Text.Replace('.', ',')), (float)numericUpDownNewStartX.Value, (float)numericUpDownNewToX.Value));
                    comboBoxSelectNewEquationType.SelectedIndex = -1;
                    break;
                case 3:
                    equations.Add(new Giperbolic_Equation(float.Parse(textBoxNewCoef1.Text.Replace('.', ',')), float.Parse(textBoxNewCoef2.Text.Replace('.', ',')), (float)numericUpDownNewStartX.Value, (float)numericUpDownNewToX.Value));
                    comboBoxSelectNewEquationType.SelectedIndex = -1;
                    break;
                case 4:
                    equations.Add(new Sqrt_Equation(float.Parse(textBoxNewCoef1.Text.Replace('.', ',')), float.Parse(textBoxNewCoef2.Text.Replace('.', ',')), (float)numericUpDownNewStartX.Value, (float)numericUpDownNewToX.Value));
                    comboBoxSelectNewEquationType.SelectedIndex = -1;
                    break;
                default:
                    break;
            }
            
            DisplayEquations();
            pictureBoxMainField.Refresh();
        }

        private void listBoxEquations_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSelCoef1.Text = "0";
            textBoxSelCoef2.Text = "0";
            textBoxSelVerticalOffset.Text = "0";

            groupBoxWorkWithPoint.Visible = true;


            if (listBoxEquations.SelectedIndex == -1)
            {
                labelSelCoef1.Visible = false;
                labelSelCoef2.Visible = false;
                labelSelVerticalOffset.Visible = false;

                textBoxSelCoef1.Visible = false;
                textBoxSelCoef2.Visible = false;
                textBoxSelVerticalOffset.Visible = false;

                buttonDelete.Visible = false;
                buttonSaveSelected.Visible = false;
                buttonUnselectEquation.Visible = false;
                buttonSelColor.Visible = false;

                groupBoxNewDF.Visible = false;

                groupBoxWorkWithPoint.Visible = false;

                groupBoxSelDF.Visible = false;

                groupBoxAxisCollision.Visible = false;
                groupBoxWorkWithPoint.Visible = false;
                groupBoxFindMinAndMax.Visible = false;
                groupBoxFindMinAndMax.Visible = false;
                groupBoxMovePointByWay.Visible = false;

                return;
            }

            groupBoxSelDF.Visible = true;

            numericUpDownSelStartX.Value = (decimal)equations[listBoxEquations.SelectedIndex].FromX;
            numericUpDownSelToX.Value = (decimal)equations[listBoxEquations.SelectedIndex].ToX;

            groupBoxAxisCollision.Visible = true;
            groupBoxWorkWithPoint.Visible = true;
            groupBoxFindMinAndMax.Visible = true;
            groupBoxFindMinAndMax.Visible = true;
            groupBoxMovePointByWay.Visible = true;

            textBoxFindMinAndMax_Min.Text = equations[listBoxEquations.SelectedIndex].FromX.ToString("0.00");
            textBoxFindMinAndMax_Max.Text = equations[listBoxEquations.SelectedIndex].ToX.ToString("0.00");


            if (equations[listBoxEquations.SelectedIndex] is Quad_Equation)
            {
                labelSelCoef1.Visible = true;
                labelSelCoef2.Visible = true;
                labelSelVerticalOffset.Visible = true;
                
                textBoxSelCoef1.Visible = true;
                textBoxSelCoef2.Visible = true;
                textBoxSelVerticalOffset.Visible = true;

                textBoxSelCoef1.Text = (equations[listBoxEquations.SelectedIndex] as Quad_Equation).A.ToString();
                textBoxSelCoef2.Text = (equations[listBoxEquations.SelectedIndex] as Quad_Equation).B.ToString();
                textBoxSelVerticalOffset.Text = (equations[listBoxEquations.SelectedIndex] as Quad_Equation).OffsetY.ToString();

                buttonDelete.Visible = true;
                buttonSaveSelected.Visible = true;
                buttonUnselectEquation.Visible = true;
                buttonSelColor.Visible = true;
            }
            else if (equations[listBoxEquations.SelectedIndex] is Linear_Equation)
            {
                labelSelCoef1.Visible = true;
                labelSelCoef2.Visible = false;
                labelSelVerticalOffset.Visible = true;

                textBoxSelCoef1.Visible = true;
                textBoxSelCoef2.Visible = false;
                textBoxSelVerticalOffset.Visible = true;
                textBoxSelCoef1.Text = (equations[listBoxEquations.SelectedIndex] as Linear_Equation).K.ToString();
                textBoxSelVerticalOffset.Text = (equations[listBoxEquations.SelectedIndex] as Linear_Equation).OffsetY.ToString();

                buttonDelete.Visible = true;
                buttonSaveSelected.Visible = true;
                buttonUnselectEquation.Visible = true;
                buttonSelColor.Visible = true;
            }
            else if (equations[listBoxEquations.SelectedIndex] is Numeric_Equation)
            {
                labelSelCoef1.Visible = false;
                labelSelCoef2.Visible = false;
                labelSelVerticalOffset.Visible = true;

                textBoxSelCoef1.Visible = false;
                textBoxSelCoef2.Visible = false;
                textBoxSelVerticalOffset.Visible = true;
                textBoxSelVerticalOffset.Text = (equations[listBoxEquations.SelectedIndex] as Numeric_Equation).OffsetY.ToString();

                buttonDelete.Visible = true;
                buttonSaveSelected.Visible = true;
                buttonUnselectEquation.Visible = true;
                buttonSelColor.Visible = true;
            }
            else if (equations[listBoxEquations.SelectedIndex] is Giperbolic_Equation)
            {
                labelSelCoef1.Visible = true;
                labelSelCoef2.Visible = false;
                labelSelVerticalOffset.Visible = true;

                textBoxSelCoef1.Visible = true;
                textBoxSelCoef2.Visible = false;
                textBoxSelVerticalOffset.Visible = true;
                textBoxSelCoef1.Text = (equations[listBoxEquations.SelectedIndex] as Giperbolic_Equation).A.ToString();
                textBoxSelVerticalOffset.Text = (equations[listBoxEquations.SelectedIndex] as Giperbolic_Equation).OffsetY.ToString();

                buttonDelete.Visible = true;
                buttonSaveSelected.Visible = true;
                buttonUnselectEquation.Visible = true;
                buttonSelColor.Visible = true;
            }
            else if (equations[listBoxEquations.SelectedIndex] is Sqrt_Equation)
            {
                labelSelCoef1.Visible = true;
                labelSelCoef2.Visible = false;
                labelSelVerticalOffset.Visible = false;

                textBoxSelCoef1.Visible = true;
                textBoxSelCoef2.Visible = false;
                textBoxSelVerticalOffset.Visible = true;
                textBoxSelCoef1.Text = (equations[listBoxEquations.SelectedIndex] as Sqrt_Equation).A.ToString();
                textBoxSelVerticalOffset.Text = (equations[listBoxEquations.SelectedIndex] as Sqrt_Equation).OffsetY.ToString();

                buttonDelete.Visible = true;
                buttonSaveSelected.Visible = true;
                buttonUnselectEquation.Visible = true;
                buttonSelColor.Visible = true;
            }
            else if (equations[listBoxEquations.SelectedIndex] is FromExpresssion_Equation)
            {
                labelSelCoef1.Visible = false;
                labelSelCoef2.Visible = false;
                labelSelVerticalOffset.Visible = false;

                textBoxSelCoef1.Visible = false;
                textBoxSelCoef2.Visible = false;
                textBoxSelVerticalOffset.Visible = false;

                textBoxSelCoef1.Text = (equations[listBoxEquations.SelectedIndex] as FromExpresssion_Equation).Expr.ExpressionString;

                numericUpDownSelStartX.Value = (decimal)equations[listBoxEquations.SelectedIndex].FromX;
                numericUpDownSelToX.Value = (decimal)equations[listBoxEquations.SelectedIndex].ToX;

                buttonDelete.Visible = true;
                buttonSaveSelected.Visible = true;
                buttonUnselectEquation.Visible = true;
                buttonSelColor.Visible = true;
            }
        }

        private void buttonUnselectEquation_Click(object sender, EventArgs e)
        {
            listBoxEquations.SelectedIndex = -1;
            listBoxEquations.Enabled = true;
        }

        private void buttonSaveSelected_Click(object sender, EventArgs e)
        {
            if (textBoxSelCoef1.Text.Length == 0 || textBoxSelCoef2.Text.Length == 0 || textBoxSelVerticalOffset.Text.Length == 0)
            {
                MessageBox.Show("Не заполнен один из коэффициентов");
                return;
            }

            if (equations[listBoxEquations.SelectedIndex] is Quad_Equation)
            {
                (equations[listBoxEquations.SelectedIndex] as Quad_Equation).A = float.Parse(textBoxSelCoef1.Text.Replace('.', ','));
                (equations[listBoxEquations.SelectedIndex] as Quad_Equation).B = float.Parse(textBoxSelCoef2.Text.Replace('.', ','));
                (equations[listBoxEquations.SelectedIndex] as Quad_Equation).OffsetY = float.Parse(textBoxSelVerticalOffset.Text.Replace('.', ','));
            }
            else if (equations[listBoxEquations.SelectedIndex] is Linear_Equation)
            {
                (equations[listBoxEquations.SelectedIndex] as Linear_Equation).K = float.Parse(textBoxSelCoef1.Text.Replace('.', ','));
                (equations[listBoxEquations.SelectedIndex] as Linear_Equation).OffsetY = float.Parse(textBoxSelVerticalOffset.Text.Replace('.', ','));
            }
            else if (equations[listBoxEquations.SelectedIndex] is Numeric_Equation)
            {
                (equations[listBoxEquations.SelectedIndex] as Numeric_Equation).OffsetY = float.Parse(textBoxSelVerticalOffset.Text.Replace('.', ','));
            }
            else if (equations[listBoxEquations.SelectedIndex] is Giperbolic_Equation)
            {
                (equations[listBoxEquations.SelectedIndex] as Giperbolic_Equation).A = float.Parse(textBoxSelCoef1.Text.Replace('.', ','));
                (equations[listBoxEquations.SelectedIndex] as Giperbolic_Equation).OffsetY = float.Parse(textBoxSelVerticalOffset.Text.Replace('.', ','));
            }
            else if (equations[listBoxEquations.SelectedIndex] is Sqrt_Equation)
            {
                (equations[listBoxEquations.SelectedIndex] as Sqrt_Equation).A = float.Parse(textBoxSelCoef1.Text.Replace('.', ','));
                (equations[listBoxEquations.SelectedIndex] as Sqrt_Equation).OffsetY = float.Parse(textBoxSelVerticalOffset.Text.Replace('.', ','));
            }
            else if (equations[listBoxEquations.SelectedIndex] is FromExpresssion_Equation)
            {
                equations[listBoxEquations.SelectedIndex] = new FromExpresssion_Equation(textBoxSelCoef1.Text);
                (equations[listBoxEquations.SelectedIndex] as FromExpresssion_Equation).FromX = (float)numericUpDownSelStartX.Value;
                (equations[listBoxEquations.SelectedIndex] as FromExpresssion_Equation).ToX = (float)numericUpDownSelToX.Value;
            }
            equations[listBoxEquations.SelectedIndex].FromX = (float)numericUpDownSelStartX.Value;
            equations[listBoxEquations.SelectedIndex].ToX = (float)numericUpDownSelToX.Value;
            listBoxEquations.SelectedIndex = -1;
            DisplayEquations();
            listBoxEquations.Enabled = true;
            pictureBoxMainField.Refresh();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить этот график?\nЭто действие нельзя отменить!", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                equations.RemoveAt(listBoxEquations.SelectedIndex);
                listBoxEquations.Enabled = true;
            }
            labelSelCoef1.Visible = false;
            labelSelCoef2.Visible = false;
            labelSelVerticalOffset.Visible = false;

            textBoxSelCoef1.Visible = false;
            textBoxSelCoef2.Visible = false;
            textBoxSelVerticalOffset.Visible = false;

            buttonDelete.Visible = false;
            buttonSaveSelected.Visible = false;
            buttonUnselectEquation.Visible = false;
            buttonSelColor.Visible = false;

            groupBoxNewDF.Visible = false;

            groupBoxWorkWithPoint.Visible = false;

            groupBoxSelDF.Visible = false;

            groupBoxAxisCollision.Visible = false;
            groupBoxWorkWithPoint.Visible = false;
            groupBoxFindMinAndMax.Visible = false;
            groupBoxFindMinAndMax.Visible = false;
            groupBoxMovePointByWay.Visible = false;

            AxisCollisionPoints.Clear();
            SelectedPointOfEquation = new PointF(int.MinValue, int.MinValue);
            DisplayEquations();
            pictureBoxMainField.Refresh();
        }

        private void buttonSelColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                equations[listBoxEquations.SelectedIndex].DrawPen = new Pen(cd.Color, 3);
            }
            pictureBoxMainField.Refresh();
        }

        private void buttonCreateDefaultEquations_Click(object sender, EventArgs e)
        {
            equations.Add(new Quad_Equation(2, 0, -2, -60, 60));
            //equations.Add(new Quad_Equation(-1, 0, 0, -60, 60));
            //equations.Add(new Linear_Equation(1, 0, -60, 60));
            //equations.Add(new Giperbolic_Equation(1, 0, -60, 60));
            //equations.Add(new Numeric_Equation(5, -60, 60));
            DisplayEquations();
            pictureBoxMainField.Refresh();
        }

        private void buttonColorOfAxis_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                colorofAxis = cd.Color;
            }
            pictureBoxMainField.Refresh();
        }

        private void buttonColorOfLines_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                colorofLines = cd.Color;
            }
            pictureBoxMainField.Refresh();
        }

        private void textBoxSelCoef1_TextChanged(object sender, EventArgs e)
        {
            listBoxEquations.Enabled = false;
        }

        private void numericUpDownSelStartX_ValueChanged(object sender, EventArgs e)
        {
            listBoxEquations.Enabled = false;
        }

        private void textBoxSelCoef1_KeyDown(object sender, KeyEventArgs e)
        {
            listBoxEquations.Enabled = false;
        }

        private void buttonIsUpperOrLower_Click(object sender, EventArgs e)
        {
            Equation eq = equations[listBoxEquations.SelectedIndex];
            float pointX = float.Parse(textBoxPointX.Text.Replace('.', ','));
            float pointY = float.Parse(textBoxPointY.Text.Replace('.', ','));
            if (eq.GetValueInPoint(pointX) > pointY)
            {
                MessageBox.Show("Точка ниже графика");
            }
            else if (eq.GetValueInPoint(pointX) < pointY)
            {
                MessageBox.Show("Точка выше графика");
            }
            else if (eq.GetValueInPoint(pointX) == pointY)
            {
                MessageBox.Show("Точка принадлежит графику");
            }
        }

        private void buttonFuncValueInPoint_Click(object sender, EventArgs e)
        {
            Equation eq = equations[listBoxEquations.SelectedIndex];
            
            float pointX = float.Parse(textBoxPointX.Text.Replace('.',','));
            if (eq.FromX > pointX || eq.ToX < pointX)
            {
                MessageBox.Show("Выбранная координата не принадлежит области определения");
                return;
            }
            float valueInPoint = eq.GetValueInPoint(pointX);
            if (!float.IsNaN(valueInPoint))
            {
                SelectedPointOfEquation = new PointF(pointX, valueInPoint);
                pictureBoxMainField.Refresh();
                MessageBox.Show("Значение функции в точке " + pointX.ToString("0;00") + " = " + valueInPoint.ToString("0"));
            }
            else
            {
                MessageBox.Show("Значение функции в точке " + pointX.ToString("0;00") + " " + "не существует");
            }
        }

        private void buttonGetAxisCollisionPoints_Click(object sender, EventArgs e)
        {
            Equation eq = equations[listBoxEquations.SelectedIndex];
            float prevX = eq.FromX;
            if (eq is Sqrt_Equation && prevX < 0)
            {
                prevX = 0f;
            }
            float step = (float)numericUpDownAxisCollisionPointsAccuracy.Value;
            if (numericUpDownAxisCollisionPointsAccuracy.Value == 0)
            {
                step = 1;
            }
            float prevY = eq.GetValueInPoint(prevX);
            while (prevX <= eq.ToX)
            {
                float curX = prevX + 1 / step;
                float curY = eq.GetValueInPoint(curX);
                if (float.IsNaN(curY))
                {
                    prevX += 1 / step;
                    continue;
                }
                if ((int)(curX*100) == 0 && !float.IsNaN(curY))
                {
                    AxisCollisionPoints.Add(new Point((int)(curX * 100), (int)(curY * 100)));
                }
                if ((int)(curY * 100) == 0)
                {
                    AxisCollisionPoints.Add(new Point((int)(curX * 100), (int)(curY * 100)));
                }
                prevX = curX;
                prevY = curY;
            }
            pictureBoxMainField.Refresh();
            if (AxisCollisionPoints.Count > 0)
            {
                MessageBox.Show("Точки пересечения графика с осями координат\n" + String.Join("\n", AxisCollisionPoints.Select(t => t.X.ToString("0.00") + "; " + t.Y.ToString("0.00"))));
            }
            else
            {
                MessageBox.Show("Точки пересечения графика с осями координат не найдены");
            }
           
        }

        private void buttonDeleteAxisCollisionPoints_Click(object sender, EventArgs e)
        {
            if (AxisCollisionPoints.Count > 0)
            {
                AxisCollisionPoints.Clear();
            }
            pictureBoxMainField.Refresh();
        }

        private void buttonDeleteFuncValueInPoint_Click(object sender, EventArgs e)
        {
            SelectedPointOfEquation = new PointF(int.MinValue, int.MinValue);
            pictureBoxMainField.Refresh();
        }

        private void buttonFindMinAndMax_Click(object sender, EventArgs e)
        {
            float Lowest = float.MaxValue;
            float Highest = float.MinValue;

            Equation eq = equations[listBoxEquations.SelectedIndex];
            float prevX = eq.FromX;

            float step = 100f;
            
            float prevY = eq.GetValueInPoint(prevX);
            while (prevX <= eq.ToX)
            {
                float curX = prevX + 1 / step;
                float curY = eq.GetValueInPoint(curX);
                if (float.IsNaN(curY))
                {
                    prevX += 1 / step;
                    continue;
                }
                if (curY < Lowest)
                {
                    Lowest = curY;
                    MinFuncPoint = new PointF(curX, Lowest);
                }
                if (curY > Highest)
                {
                    Highest = curY;
                    MaxFuncPoint = new PointF(curX, Highest);
                }
                prevX = curX;
                prevY = curY;
            }
            pictureBoxMainField.Refresh();
            MessageBox.Show("Минимальное значение на заданном промежутке\n"+Lowest.ToString("0.00")+ "\nМаксимальное значение на заданном промежутке\n"+Highest.ToString("0.00"));
        }

        private void buttonMinAndMaxPoints_Delete_Click(object sender, EventArgs e)
        {
            MinFuncPoint = new PointF(int.MinValue, int.MinValue);
            MaxFuncPoint = new PointF(int.MinValue, int.MinValue);
            DisplayEquations();
            pictureBoxMainField.Refresh();
        }

        private void buttonAddOwnEquationPoint_Click(object sender, EventArgs e)
        {
            if (CurrentCreatingEquation == null)
            {
                float FromX = 0f;
                float ToX = 0f;
                CurrentCreatingEquation = new Equation_ByPoints(FromX, ToX);
                buttonFinishOwnEquationBuild.Visible = true;
            }
            float NewPointX = float.Parse(textBoxBuildOwnEquationX.Text.Replace('.', ','));
            float NewPointY = float.Parse(textBoxBuildOwnEquationY.Text.Replace('.', ','));
            CurrentCreatingEquation.AddNewPoint(new PointF(NewPointX, NewPointY));
            pictureBoxMainField.Refresh();
        }

        private void buttonFinishOwnEquationBuild_Click(object sender, EventArgs e)
        {
            if (CurrentCreatingEquation.Points.Count >= 2)
            {
                equations.Add(CurrentCreatingEquation);
                CurrentCreatingEquation = null;
                MessageBox.Show("Созданная функция сохранена");
            }
            else
            {
                MessageBox.Show("В созданной вами функции недостаточно точек");
            }
            buttonFinishOwnEquationBuild.Visible = false;
            DisplayEquations();
            pictureBoxMainField.Refresh();
        }

        private void buttonCreateEquationFromExpression_Click(object sender, EventArgs e)
        {
            if (textBoxEquationExpression.Text.Length > 0)
            {
                FromExpresssion_Equation eq = new FromExpresssion_Equation(textBoxEquationExpression.Text);
                equations.Add(eq);
                DisplayEquations();
                pictureBoxMainField.Refresh();
            }
        }

        private void buttonStartMovingPoint_Click(object sender, EventArgs e)
        {
            currentMovingPoint = new MovingPoint(equations[listBoxEquations.SelectedIndex], float.Parse(textBoxMovePointStartX.Text.Replace('.', ',')), float.Parse(textBoxMovePointFinishX.Text.Replace('.', ',')), float.Parse(textBoxMovingPointSpeed.Text.Replace('.', ',')));
            timerPointMover.Start();
        }

        private void timerPointMover_Tick(object sender, EventArgs e)
        {
            if (currentMovingPoint != null)
            {
                if (!currentMovingPoint.ReachedFinish)
                {
                    currentMovingPoint.Move();
                }
                else
                {
                    timerPointMover.Stop();
                    MessageBox.Show("Движение завершено");
                }
                pictureBoxMainField.Refresh();
            }
        }
        
        private void buttonSaveAsImage_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            PngBITMAP.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            File.WriteAllBytes("FieldCopy.png", ms.ToArray());
            Process.Start(new ProcessStartInfo("FieldCopy.png"));
        }

        private void buttonSaveBinary_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("equations.bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
                        
            bf.Serialize(fs, equations);
            fs.Close();
        }

        private void buttonLoadBinary_Click(object sender, EventArgs e)
        {
            if (File.Exists("equations.bin"))
            {
                if (MessageBox.Show("При загрузке новых графиков\nстарые будут потеряны!\n\nПродолжить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FileStream fs = new FileStream("equations.bin", FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();

                    equations = bf.Deserialize(fs) as List<Equation>;
                    fs.Close();

                    DisplayEquations();
                    pictureBoxMainField.Refresh();
                }
            }
        }
    }
}
