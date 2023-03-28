using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    public partial class CTextBox : UserControl
    {
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlineStyle = false;
        private Color borderFocusColor = Color.HotPink;
        private bool isFocused = false;
        public CTextBox()
        {
            InitializeComponent();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e); // Vẽ lại các thành phần cơ bản trước khi vẽ viền
            Graphics graph = e.Graphics;
            using (Pen penBoder = new Pen(borderColor, borderSize) ) // Vẽ viền
            {
                penBoder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset; // Vẽ viền nhưng nằm ở bên trong control (Inset)
                if (underlineStyle) // Vẽ gạch chân 
                {
                    graph.DrawLine(penBoder, 0, this.Height - 1, this.Width, this.Height - 1);
                }
                else // VIền chữ nhật
                {
                    graph.DrawRectangle(penBoder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e); //UPdate lại size control khi trong trạng thái design
            if (this.DesignMode) UpdateControlHeight();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e); // Update lại size control khi trong trạng thái khởi tạo
            UpdateControlHeight();
        }
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1; // Tính toán kích thước viền
                textBox1.Multiline = true; // 
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }
        
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        public bool UnderlinedStyle
        {
            get { return underlineStyle; }
            set
            {
                underlineStyle = value;
                this.Invalidate();
            }
        }


        public bool PasswordChar
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }
        }

        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }

        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }

        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }

        public string Texts
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public HorizontalAlignment TextAlign
        {
            get
            {
                return textBox1.TextAlign;
            }
            set { textBox1.TextAlign = value; }
        }

        public Color BorderFocusColor
        {
            get { return borderFocusColor; }
            set { borderFocusColor = value; }
        }
        //Change border color in focus mode
        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
        }
    }
}
