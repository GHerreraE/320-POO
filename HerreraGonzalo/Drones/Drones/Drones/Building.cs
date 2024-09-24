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
        drawingSpace.Graphics.DrawEllipse(GetDroneBrush(), new Rectangle(_x - 4, _y - 2, 8, 8));
        drawingSpace.Graphics.DrawString($"{this}", GetTextHelpers().drawFont, TextHelpers.writingBrush, _x + 5, _y - 5);
    }

    private static object GetTextHelpers()
    {
        return TextHelpers;
    }

    private static object GetDroneBrush()
    {
        return GetDroneBrush;
    }
}