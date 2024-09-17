using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

class Building
{
    public int _x {get; set;}
    public int _y { get; set; }
    public int _largeur { get; set; }
    public int _profondeur { get; set; }
    public string _color { get; set; }

    public Building(int x, int y, int largeur, int profondeur, string color)
    {
        _x = x;
        _y = y;
        _largeur = largeur;
        _profondeur = profondeur;
        _color = color;
    }

    public void Render(BufferedGraphics drawingSpace)
    {
        drawingSpace.Graphics.DrawEllipse(droneBrush, new Rectangle(x - 4, y - 2, 8, 8));
        drawingSpace.Graphics.DrawString($"{this}", TextHelpers.drawFont, TextHelpers.writingBrush, x + 5, y - 5);
    }


}