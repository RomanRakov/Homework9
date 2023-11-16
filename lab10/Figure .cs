using System;
namespace lab10
{
    public class Figure : IGeometricFigure
    {
        private string color;
        private bool isVisible;
        public Figure(string color, bool isVisible)
        {
            this.color = color;
            this.isVisible = isVisible;
        }
        public void MoveHorizontal(double distance)
        {
            Console.WriteLine($"Фигура перемещена по горизонтали на {distance} единицы");
        }
        public void MoveVertical(double distance)
        {
            Console.WriteLine($"Фигура перемещена по вертикали на {distance} единицы");
        }
        public void ChangeColor(string color)
        {
            this.color = color;            
        }
        public bool IsVisible()
        {
            return isVisible;
        }
        public void DisplayState()
        {
            Console.WriteLine($"Цвет фигуры: {color}");
            Console.WriteLine($"Фигура видима: {isVisible}");
        }
    }
}
