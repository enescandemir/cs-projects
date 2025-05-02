using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

public class IconTopMaterialButton : MaterialButton
{
    private const int TextHeight = 24;
    private const int PaddingBetween = 8;

    private static readonly Font RobotoMedium10 = new Font("Roboto", 10, FontStyle.Regular);
    private bool _isPressed = false;
    private bool _isHovered = false;

    public IconTopMaterialButton()
    {
        Size = new Size(120, 120);
        TextImageRelation = TextImageRelation.ImageAboveText;

        MouseEnter += (s, e) => { _isHovered = true; Invalidate(); };
        MouseLeave += (s, e) => { _isHovered = false; _isPressed = false; Invalidate(); };
        MouseDown += (s, e) => { _isPressed = true; Invalidate(); };
        MouseUp += (s, e) => { _isPressed = false; Invalidate(); };
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        var g = pevent.Graphics;
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        g.Clear(Parent?.BackColor ?? Color.White);

        Color baseColor = UseAccentColor ? SkinManager.ColorScheme.AccentColor : SkinManager.ColorScheme.PrimaryColor;

        Color bgColor;
        if (!Enabled)
        {
            bgColor = GetDisabledColor(baseColor);
        }
        else if (_isPressed)
        {
            bgColor = AdjustBrightness(baseColor, 0.90f);
        }
        else if (_isHovered)
        {
            bgColor = ControlPaint.Light(SkinManager.ColorScheme.PrimaryColor);
        }
        else
        {
            bgColor = baseColor;
        }

        using (var bgBrush = new SolidBrush(bgColor))
        {
            g.FillRectangle(bgBrush, ClientRectangle);
        }

        if (Icon != null)
        {
            int iconSize = GetDynamicIconSize();
            int iconTop;

            if (string.IsNullOrEmpty(Text))
            {
                iconTop = (Height - iconSize) / 2;
            }
            else
            {
                iconTop = (Height - iconSize - TextHeight - PaddingBetween) / 2;
            }

            var iconRect = new Rectangle(
                (Width - iconSize) / 2,
                iconTop,
                iconSize,
                iconSize
            );

            g.DrawImage(Icon, iconRect);
        }

        if (!string.IsNullOrEmpty(Text))
        {
            var textRect = new Rectangle(4, Height - TextHeight - 8, Width - 8, TextHeight);
            using (var textBrush = new SolidBrush(Enabled
                ? SkinManager.ColorScheme.TextColor
                : GetDisabledColor(SkinManager.ColorScheme.TextColor)))
            {
                var sf = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                g.DrawString(Text, RobotoMedium10, textBrush, textRect, sf);
            }
        }
    }

    private int GetDynamicIconSize()
    {
        int minSide = Math.Min(Width, Height);
        return Math.Max(24, (int)(minSide * 0.64));
    }

    private Color GetDisabledColor(Color baseColor)
    {
        return Color.FromArgb(150, baseColor.R, baseColor.G, baseColor.B);
    }

    private Color AdjustBrightness(Color color, float correctionFactor)
    {
        int red = (int)(color.R * correctionFactor);
        int green = (int)(color.G * correctionFactor);
        int blue = (int)(color.B * correctionFactor);

        red = Math.Min(255, Math.Max(0, red));
        green = Math.Min(255, Math.Max(0, green));
        blue = Math.Min(255, Math.Max(0, blue));

        return Color.FromArgb(color.A, red, green, blue);
    }
}
