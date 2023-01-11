using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomVariateGeneratorLibrary
{
    public class DESElement
    {
        public static int Handle_Size = 3;

        public static Font Element_Font { get; set; } = new Font("Arial", 12);


        public Rectangle Bound { get; set; } = new Rectangle(10, 10, 100, 50);
        public Color Back_Color = Color.White;

        public virtual void Draw(Graphics g, Rectangle client_Rectangle)
        {
            g.DrawRectangle(Pens.Gray, Bound);
        }

        public void Draw_Selection_Handles(Graphics g)
        {
            Rectangle rect = Rectangle.Empty;
            rect.Width = rect.Height = Handle_Size + Handle_Size;
            rect.X = Bound.Left - Handle_Size;
            rect.Y = Bound.Top - Handle_Size;


            g.FillRectangle(Brushes.Black, rect);
            rect.Y = Bound.Bottom - Handle_Size;
            g.FillRectangle(Brushes.Black, rect);
            rect.X = Bound.Right - Handle_Size;
            g.FillRectangle(Brushes.Black, rect);
            rect.Y = Bound.Top - Handle_Size;
            g.FillRectangle(Brushes.Black, rect);

            //rect.Y = Bound.Left - Handle_Size;
        }
    }
}
