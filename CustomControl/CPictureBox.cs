using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace CustomControl
{
    public class CPictureBox : PictureBox
    {
        private int borderSize = 2; // Độ dày của border
        private Color borderColor = Color.RoyalBlue; // màu 1
        private Color borderColor2 = Color.HotPink; // màu 2
        // chỉ style cho viền.
        private DashStyle borderLineStyle = DashStyle.Solid; // solid: 1 đường liền , dash: là gạch gạch, dot: chấm chấm, dashdot: gạch chấm, dash dot dot: gạch chấm chấm, custom: tự cus
        private DashCap borderCapStyle = DashCap.Flat; // Hình dạng ban đầu của borderCapsty
      
        private float gradientAngle = 50F; // Góc quay
        public CPictureBox()
        {
            this.Size = new Size(100, 100); // tạo size và mode ban đầu cho ảnh
            this.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        public int BorderSize
        {
            get
            {
                return borderSize;
            }

            set
            {
                borderSize = value;
                this.Invalidate(); // Vô hiệu hóa bề mặt và làm cho điều khiển vẽ lại
            }
        }

        public Color BorderColor
        {
            get
            {
                return borderColor;
            }

            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        public Color BorderColor2
        {
            get
            {
                return borderColor2;
            }

            set
            {
                borderColor2 = value;
                this.Invalidate();
            }
        }

        public DashStyle BorderLineStyle
        {
            get
            {
                return borderLineStyle;
            }

            set
            {
                borderLineStyle = value;
                this.Invalidate();
            }
        }

        public DashCap BorderCapStyle
        {
            get
            {
                return borderCapStyle;
            }

            set
            {
                borderCapStyle = value;
                this.Invalidate();
            }
        }

        public float GradientAngle
        {
            get
            {
                return gradientAngle;
            }

            set
            {
                gradientAngle = value;
                this.Invalidate();
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e); // size mới bằng width, size mới bằng width
            this.Size = new Size(this.Width, this.Width);
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe); // Vẽ lại cách thành phần cơ bản trước
            //Fields
            var graph = pe.Graphics;
            // Hình chữ nhật bao quanh đường tròn cần vẽ
            var rectContourSmooth = Rectangle.Inflate(this.ClientRectangle, -1, -1);
            // Hình chữ nhật bao quanh đường tròn ở trên cách nhau một cái bordersize
            var rectBorder = Rectangle.Inflate(rectContourSmooth, -borderSize, -borderSize);

            var smoothSize = borderSize > 0 ? borderSize * 3 : 1;
            using (var borderGColor = new LinearGradientBrush(rectBorder, borderColor, borderColor2, gradientAngle))
            using (var pathRegion = new GraphicsPath())
            using (var penSmooth = new Pen(this.Parent.BackColor, smoothSize))
            using (var penBorder = new Pen(borderGColor, borderSize))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                penBorder.DashStyle = borderLineStyle;
                penBorder.DashCap = borderCapStyle;
                pathRegion.AddEllipse(rectContourSmooth);
                //Set rounded region 
                this.Region = new Region(pathRegion);

                //Drawing
                graph.DrawEllipse(penSmooth, rectContourSmooth);//Draw contour smoothing
                if (borderSize > 0) //Draw border
                    graph.DrawEllipse(penBorder, rectBorder);
            }
        }
    }
}
