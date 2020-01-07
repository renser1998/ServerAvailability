using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace ServerAvailability
{
    class Arm:PictureBox
    {
        bool enable = true;
        string ip = "0.0.0.0";
        string name = "arm";
        int prior = 2;
        PictureBox pic = new PictureBox();
        public int Priority 
        { 
            get { return prior; } 
            set { prior = value;
                this.Invalidate(); 
            }
        }
        public Image ArmPicture { get { return pic.BackgroundImage; } set { pic.BackgroundImage = value; } }
        public bool ArmEnable { get { return enable; } 
            set { 
                enable = value;
                Invalidate();
            } 
        }
        public string ArmIp { get { return labelIp.Text; } set { labelIp.Text = value; SetProportions(); } }
        public string ArmName { get { return labelName.Text; } set { labelName.Text = value; SetProportions(); } }
        Label labelIp = new Label();
        Label labelName = new Label();

        protected override void OnPaint(PaintEventArgs pe)
        {
            Color qadr = Color.Gray;
            if (enable)
                pe.Graphics.DrawRectangle(new Pen(Color.FromArgb(255, 0, 250, 154), 2),1,1,Width-2,Height-2);
            else
                pe.Graphics.DrawRectangle(new Pen(Color.Red,2), 1, 1, Width - 2, Height - 2);
            switch(prior)
            {
                case 0:qadr = Color.Red; break;
                case 1: qadr = Color.FromArgb(240, 212, 5); break;
                case 2:qadr = Color.Gray; break;
                   
            }
            pe.Graphics.FillEllipse(new SolidBrush(qadr), 2, this.Height - 12, 10,10);
            base.OnPaint(pe);
        }
        private void ClickClick(object sender,EventArgs e)
        {
            this.OnClick(new EventArgs());
        }
        public Arm():base()
        {
            this.MinimumSize = new Size(90, 100);
            labelIp.AutoSize = labelName.AutoSize = true;
            labelIp.Text = this.ip;
            labelName.Text = this.name;
            SetProportions();
            labelIp.BackColor = labelName.BackColor = Color.Transparent;
            pic.BackgroundImageLayout = ImageLayout.Stretch;


            pic.Click += ClickClick;
            labelIp.Click += ClickClick;
            labelName.Click += ClickClick;

            this.Controls.Add(pic);
            this.Controls.Add(labelIp);
            this.Controls.Add(labelName);
        }
        void SetProportions()
        {
            labelIp.Left = this.Width / 2 - labelIp.Width / 2;
            labelName.Left = this.Width / 2 - labelName.Width / 2;
            labelIp.Top = Height - labelIp.Height - 5;
            labelName.Top = Height - (2 * labelIp.Height) - 10;
            pic.Size = new Size(this.Width-4, labelName.Top);
            pic.Location = new Point(2, 2);
        }
        protected override void OnResize(EventArgs e)
        {
            SetProportions();
            base.OnResize(e);
        }
        protected override void OnCreateControl()
        {
            SetProportions();
            base.OnCreateControl();
        }
    }
}
