using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10
{
    public partial class CursorPositionControl : UserControl
    {
        public CursorPositionControl()
        {
            InitializeComponent();
        }

        public void UpdateCursorCharacters(int totalCharacters)
        {
            lblCount.Text = $"Количество символов: {totalCharacters}";
        }

        public void UpdateCursorPosition(Vector2 CursorPosition)
        {
            lblPosition.Text = $"Позиция: X: {CursorPosition.X}, Y: {CursorPosition.Y}";
        }
    }
}
