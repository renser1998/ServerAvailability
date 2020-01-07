using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace ServerAvailability.Controls
{
    [DefaultEvent("Click")]
    public partial class GBut : UserControl
    {

        public GBut()
        {

            InitializeComponent();
            normal = Color.FromArgb(67, 211, 128);//new Color(Color.FromArgb(67, 211, 128));
            down = Color.FromArgb(89, 235, 151);
            enter = Color.FromArgb(44, 189, 106);
            border = Color.FromArgb(65, 184, 93);
            //NORMAL = Themes.GeneralAndNormal;
            //DOWN = Themes.Down;
            //ENTER = Themes.Enter;
            //BORDER = Themes.Border;
            this.BackColor = normal;


            //LoadFont();
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int leftRect, int topRect, int rightRect, int bottomRect, int wEllipse, int hEllipse);
        Color normal, down, enter, border;
        int wEllipse = 3, hEllipse = 3;
        String txt = "Кнопка";
        Font font = new Font("Arial", 11);

        //[Description("Test text displayed in the textbox"), Category("Внешний вид")]
        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public override string Text
        {
            get { return txt; }
            set
            {
                txt = value;
                Invalidate();
            }
        }
        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override Font Font
        {
            get
            {
                return font;
            }
            set
            {
                font = value;
                Invalidate();
            }
        }
        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true),
DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public Color NORMAL
        {
            get
            {
                return normal;
            }
            set
            {
                normal = value;
                BackColor = normal;
                Invalidate();
            }
        }
        public Color DOWN
        {
            get
            {
                return down;
            }
            set
            {
                down = value;
                Invalidate();
            }
        }
        public Color ENTER
        {
            get
            {
                return enter;
            }
            set
            {
                enter = value;
                Invalidate();
            }
        }
        public Color BORDER
        {
            get
            {
                return border;
            }
            set
            {
                border = value;
                Invalidate();
            }
        }
        public int hRound
        {
            get
            {
                return hEllipse;
            }
            set
            {
                hEllipse = value;
            }
        }
        public int wRound
        {
            get
            {
                return wEllipse;
            }
            set
            {
                wEllipse = value;
            }
        }
        public void DrawRoundRect(Graphics g, Pen p, float X, float Y, float width, float height, float radius)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddLine(X + radius, Y, X + width - (radius * 2), Y);
            gp.AddArc(X + width - (radius * 2), Y, radius * 2, radius * 2, 270, 90);
            gp.AddLine(X + width, Y + radius, X + width, Y + height - (radius * 2));
            gp.AddArc(X + width - (radius * 2), Y + height - (radius * 2), radius * 2, radius * 2, 0, 90);
            gp.AddLine(X + width - (radius * 2), Y + height, X + radius, Y + height);
            gp.AddArc(X, Y + height - (radius * 2), radius * 2, radius * 2, 90, 90);
            gp.AddLine(X, Y + height - (radius * 2), X, Y + radius);
            gp.AddArc(X, Y, radius * 2, radius * 2, 180, 90);
            gp.CloseFigure();
            g.DrawPath(p, gp);
            gp.Dispose();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, wEllipse, hEllipse));
            e.Graphics.DrawString(txt, font, new SolidBrush(Color.Gray), new PointF(this.Width / 2 - TextRenderer.MeasureText(txt, font).Width / 2, this.Height / 2 - TextRenderer.MeasureText(txt, font).Height / 2));
            DrawRoundRect(e.Graphics, new Pen(border), 0, 0, this.Width - 2, this.Height - 2, wEllipse);
            //e.Graphics.DrawRectangle(new Pen(border), 0, 0, this.Width - 1, this.Height - 1);
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            this.BackColor = down;
            base.OnMouseDown(e);
            //this.Invalidate();
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            this.BackColor = enter;
            base.OnMouseEnter(e);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            this.BackColor = normal;
            base.OnMouseLeave(e);
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            this.BackColor = enter;
            base.OnMouseUp(e);
        }
    }
}
