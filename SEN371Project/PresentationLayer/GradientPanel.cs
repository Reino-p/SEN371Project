using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class GradientPanel : Panel
{
    public Color Color1 { get; set; } = ColorTranslator.FromHtml("#ABD9DA");
    public Color Color2 { get; set; } = ColorTranslator.FromHtml("#005F6B");
    public float Transparency { get; set; } = 0.5f;  // Transparency level (0.0 to 1.0)

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Apply the transparency level to the colors
        Color color1 = Color.FromArgb((int)(Transparency * 255), Color1);
        Color color2 = Color.FromArgb((int)(Transparency * 255), Color2);

        // Create a rectangle to fill the panel's client area
        Rectangle rectangle = new Rectangle(0, 0, this.Width, this.Height);

        // Create a LinearGradientBrush with the specified colors and fill direction
        using (LinearGradientBrush brush = new LinearGradientBrush(rectangle, color1, color2, LinearGradientMode.Vertical))
        {
            // Fill the background with the gradient
            e.Graphics.FillRectangle(brush, rectangle);
        }
    }
}