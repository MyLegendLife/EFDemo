using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ClientManage
{
    public class SetWindowRegion
    {
        public SetWindowRegion()
        {
        }

        public SetWindowRegion(Form frm)
        {
            System.Drawing.Drawing2D.GraphicsPath FormPath;
            FormPath = new System.Drawing.Drawing2D.GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, frm.Width, frm.Height );//- 22
            FormPath = GetRoundedRectPath(rect, 30);
            frm.Region = new Region(FormPath);
        }

        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            int diameter = radius;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));
            GraphicsPath path = new GraphicsPath();

            path.AddArc(arcRect, 180, 90); //   左上角           
            arcRect.X = rect.Right - diameter; //   右上角 
            path.AddArc(arcRect, 270, 90);
            arcRect.Y = rect.Bottom - diameter;//   右下角    
            path.AddArc(arcRect, 0, 90);
            arcRect.X = rect.Left;//   左下角  
            path.AddArc(arcRect, 90, 90);

            path.CloseFigure();

            return path;
        }
    }
}
