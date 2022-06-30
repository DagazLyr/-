using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using Тестирование_по_общим_дисциплинам.MyButton;

namespace Тестирование_по_общим_дисциплинам
{
   public class MyButton1 : Control
    {
        private StringFormat SF = new StringFormat();

        private bool MouseEntered = false;
        private bool MousePressed = false;

        Animation CurtianButtonAnim = new Animation();
        Animation RippleButtonAnim = new Animation();

        Point ClickLocation = new Point();

        private bool roundinEnable = false;
        public bool RoundingEnable
        {
            get => roundinEnable;
            set
            {
                roundinEnable = value;

                Refresh();
            }
        }

        private int roundingPercetn = 100;
        public int Rounding
        {
            get => roundingPercetn;
            set
            {
                if(value >= 0 && value <= 100)
                {
                    roundingPercetn = value;

                    Refresh();
                }
            }
        }
        
        public MyButton1()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            Size = new Size(100,30);

            SF.Alignment = StringAlignment.Center;
            SF.LineAlignment = StringAlignment.Center;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.HighQuality;

            graph.Clear(Parent.BackColor);

            Rectangle rect = new Rectangle(0,0, Width - 1, Height - 1);
            Rectangle rectCurtain = new Rectangle(0, 0, (int)CurtianButtonAnim.Value, Height - 1);
            Rectangle rectRipple = new Rectangle(ClickLocation.X - (int)RippleButtonAnim.Value / 2, ClickLocation.Y - (int)RippleButtonAnim.Value / 2, (int)RippleButtonAnim.Value, (int)RippleButtonAnim.Value);

            //Закругление
            float roundingValue = 0.1F;
            if(RoundingEnable && roundingPercetn > 0)
            {
                roundingValue = Height / 100F * roundingPercetn;
            }
            GraphicsPath rectPath = Drawer.RoundedRectangle(rect, roundingValue);
            GraphicsPath rectCurtainPath = Drawer.RoundedRectangle(rectCurtain, roundingValue);

            //Основной прямоугольник
            graph.DrawPath(new Pen(BackColor), rectPath);
            graph.FillPath(new SolidBrush(BackColor), rectPath);

            graph.SetClip(rectPath);

            //Доп. прямоугольник - шторка
            
                graph.DrawPath(new Pen(Color.FromArgb(100, Color.White)), rectCurtainPath);
                graph.FillPath(new SolidBrush(Color.FromArgb(100, Color.White)), rectCurtainPath);

                

            // Эффект волны           
            if (RippleButtonAnim.Value > 0 && RippleButtonAnim.Value < RippleButtonAnim.TargetValue)
            {
                graph.DrawEllipse(new Pen(Color.FromArgb(30, Color.Black)), rectRipple);
                graph.FillEllipse(new SolidBrush(Color.FromArgb(30, Color.Black)), rectRipple);
            }
            else if (RippleButtonAnim.Value == RippleButtonAnim.TargetValue)
            {
                RippleButtonAnim.Value = 0;
            }

            graph.DrawString(Text, Font,new SolidBrush( ForeColor), rect, SF);
        }

        private void ButtonRippleAction()
        {
            RippleButtonAnim = new Animation("ButtonRipple_" + Handle, Invalidate, 0, Width);

            Animator.Request(RippleButtonAnim, true);
        }
         
        private void ButtonCurtainAction()
        {
            if (MouseEntered)
            {
                CurtianButtonAnim = new Animation("ButtonCurtain_" + Handle, Invalidate, CurtianButtonAnim.Value, Width - 1);
            }
            else
            {
                CurtianButtonAnim = new Animation("ButtonCurtain_" + Handle, Invalidate, CurtianButtonAnim.Value, 0);

            }

            Animator.Request(CurtianButtonAnim, true);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            MouseEntered = true;

            ButtonCurtainAction();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            MouseEntered = false;

            ButtonCurtainAction();

        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            MousePressed = true;

            CurtianButtonAnim.Value = CurtianButtonAnim.TargetValue;

            ClickLocation = e.Location;
            ButtonRippleAction();

        }
        protected override void OnMouseUp(MouseEventArgs e) 
        {
            base.OnMouseUp(e);

            MousePressed = false;

        }
    }
}
