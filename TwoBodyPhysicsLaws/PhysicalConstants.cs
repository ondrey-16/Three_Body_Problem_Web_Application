using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoBodyPhysicsLaws;
/// <summary>
/// Static class
/// </summary>
public static class PhysicalConstants
{
    /// <summary>
    /// Gravity constant in m^3 / (kg * s^2).
    /// </summary>
    public const double G = 6.6743015e-11;
    /// <summary>
    /// Earth mass in kg.
    /// </summary>
    public const double Me = 5.97219e24;
    /// <summary>
    /// Moon mass in kg.
    /// </summary>
    public const double Mm = 7.347673e22;
    /// <summary>
    /// Sun mass in kg.
    /// </summary>
    public const double Ms = 1.98855e30;
    /// <summary>
    /// Average distance between Earth and Sun in meters.
    /// </summary>
    public const double Au = 1.49597871e11;
    /// <summary>
    /// Average distance between Earth and Moon in meters.
    /// </summary>
    public const double MEDistance = 3.844e8;
}
