﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormI2C
{
    public partial class Display : UserControl
    {
        public Display()
        {
            InitializeComponent();
        }

        private Bitmap bitmap;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (bitmap == null)
            {
                bitmap = new Bitmap(this.Width, this.Height);
            }
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        double last_point = 0;
        int index = 0;
        public void DrawBitmap(List<byte[]> list, int id)
        {
            Bitmap buffer = (Bitmap)bitmap.Clone();
            Graphics g = Graphics.FromImage(bitmap);
            g.TranslateTransform(0, bitmap.Height / 2);
            g.Clear(Color.Transparent);
            g.DrawImage(buffer, 10 * list.Count, -bitmap.Height / 2);
            index = list.Count;
            foreach (byte[] b in list)
            {
                int y = (int)b[id];
                g.DrawLine(Pens.Red, new Point(index * 10, (int)last_point), new Point((index - 1) * 10, (int)y));
                last_point = y;
                index--;
            }
            g.Dispose();
            buffer.Dispose();
            base.Invalidate();
        }
    }
}