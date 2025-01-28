﻿namespace Gizmo.Web.Components
{
    public struct Point
    {
        public double X { get; set; }

        public double Y { get; set; }

        public override string ToString()
        {
            return $"X: {X}, Y: {Y}";
        }
    }
}