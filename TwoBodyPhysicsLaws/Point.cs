using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoBodyPhysicsLaws;

/// <summary>
/// Represents a placement in two-dimensional space dimension (the third dimension is constant).
/// </summary>
public struct Point
{
    private double _x;
    private double _y;
    /// <summary>
    /// The first space dimension.
    /// </summary>
    public double X { get { return _x; } set { _x = value; } }
    /// <summary>
    /// The second space dimension.
    /// </summary>
    public double Y { get { return _y; } set { _y = value; } }
    public Point (double x = .0, double y = .0)
    {
        _x = x;
        _y = y;
    }
}
