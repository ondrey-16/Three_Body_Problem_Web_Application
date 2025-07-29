using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoBodyPhysicsLaws;
/// <summary>
/// Represents a physical body in two-dimensional space (the third dimension is constant).
/// </summary>
public struct Body
{
    private double _mass;
    private Point _point;
    private double _a;
    /// <summary>
    /// Mass of body.
    /// </summary>
    public double Mass { get { return _mass; } set { _mass = value; } }
    /// <summary>
    /// Placement of body in space.
    /// </summary>
    public Point Point { get { return _point; } set { _point = value; } }
    /// <summary>
    /// Acceleration of body.
    /// </summary>
    public double A { get { return _a; } set { _a = value; } }
    public Body(double mass, Point point, double a)
    {
        _mass = mass;
        _point = point;
        _a = a;
    }
}
