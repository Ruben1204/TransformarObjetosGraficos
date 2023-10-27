using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformacionesGrafics.Graficos
{
    internal class EstrellaTranslate : IDrawable
    {
        public void Draw(ICanvas superficie, RectF dirtyRect)
        {
            PathF trazo = new PathF();
            for(int i = 0; i < 11; i++)
            {
                double angulo = 5 * i * 2 * Math.PI/11;
                PointF punto = new PointF(100 * (float)Math.Sin(angulo), - 100 * (float)Math.Cos(angulo));

                if (i == 0)
                    trazo.MoveTo(punto);
                else
                    trazo.LineTo(punto);
            }

            superficie.FillColor = Colors.Red;
            superficie.Translate(150, 150);
            superficie.FillPath(trazo);
        }
    }
}
