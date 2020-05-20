using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using System.Threading;
using System.Drawing;
using Cosmos.System.Graphics;
using Point = Cosmos.System.Graphics.Point;
using System.Linq;
using Cosmos.HAL;
using IL2CPU.API.Attribs;

namespace OSProject
{

    class Paint
    {
        private Canvas canvas;
        private Bitmap bitmap;
        public void main()
        {
            bitmap = new Bitmap(10, 10,
               new byte[] { 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0,
                    255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255,
                    0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255,
                    0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 23, 59, 88, 255,
                    23, 59, 88, 255, 0, 255, 243, 255, 0, 255, 243, 255, 23, 59, 88, 255, 23, 59, 88, 255, 0, 255, 243, 255, 0,
                    255, 243, 255, 0, 255, 243, 255, 23, 59, 88, 255, 153, 57, 12, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255,
                    243, 255, 0, 255, 243, 255, 153, 57, 12, 255, 23, 59, 88, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243,
                    255, 0, 255, 243, 255, 0, 255, 243, 255, 72, 72, 72, 255, 72, 72, 72, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0,
                    255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 72, 72,
                    72, 255, 72, 72, 72, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255,
                    10, 66, 148, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255,
                    243, 255, 10, 66, 148, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 10, 66, 148, 255, 10, 66, 148, 255,
                    10, 66, 148, 255, 10, 66, 148, 255, 10, 66, 148, 255, 10, 66, 148, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255,
                    243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 10, 66, 148, 255, 10, 66, 148, 255, 10, 66, 148, 255, 10, 66, 148,
                    255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255,
                    0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, }, ColorDepth.ColorDepth32);

            canvas = FullScreenCanvas.GetFullScreenCanvas();
            canvas.Clear(Color.Blue);

            try
            {
                // MODE - 1.

                // A red Point 
                Pen pen = new Pen(Color.Red);
                canvas.DrawPoint(pen, 69, 69);
                // A GreenYellow horizontal line 
                pen.Color = Color.GreenYellow;
                canvas.DrawLine(pen, 250, 100, 400, 100);
                // An IndianRed vertical line 
                pen.Color = Color.IndianRed;
                canvas.DrawLine(pen, 350, 150, 350, 250);
                // A MintCream diagonal line 
                pen.Color = Color.MintCream;
                canvas.DrawLine(pen, 250, 150, 400, 250);
                // A PaleVioletRed rectangle 
                pen.Color = Color.PaleVioletRed;
                canvas.DrawRectangle(pen, 350, 350, 80, 60);
                pen.Color = Color.Chartreuse;
                canvas.DrawCircle(pen, 69, 69, 10);
                pen.Color = Color.LightSalmon;
                canvas.DrawEllipse(pen, 400, 300, 100, 150);
                pen.Color = Color.MediumPurple;
                canvas.DrawPolygon(pen, new Point(200, 250), new Point(250, 300), new Point(220, 350), new Point(210, 275));
                canvas.DrawImage(bitmap, new Point(20, 20));

                Console.ReadKey();


                // MODE - 2.

                canvas.Mode = new Mode(800, 600, ColorDepth.ColorDepth32);
                // If the background is not redrawn, it gets corrupted
                canvas.Clear(Color.Blue);
                // A LimeGreen rectangle 
                pen.Color = Color.LimeGreen;
                canvas.DrawRectangle(pen, 450, 450, 80, 60);
                // A filled rectange
                pen.Color = Color.Chocolate;
                canvas.DrawFilledRectangle(pen, 200, 150, 400, 300);

                Console.ReadKey();


                // END.

                Sys.Power.Shutdown(); // May need to fix here to go back to main menu.
            }
            catch (Exception e)
            {
                Console.WriteLine($"Got fatal exception {e.Message}");
            }
        }
    }
}
