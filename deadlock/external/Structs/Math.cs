using System;
using System.Drawing;
using deadlock;


public struct Vector3
{
    public float X { get; set; }
    public float Y { get; set; }
    public float Z { get; set; }

    public Vector3(float x, float y, float z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public static Vector3 Zero => new Vector3(0f, 0f, 0f);    public bool IsZero()
    
    {
        return X == 0f && Y == 0f && Z == 0f;
    }

    public PointF ToPointF()
    {
        return new PointF(X, Y);
    }

    public static float Distance(Vector3 v1, Vector3 v2)
    {
        float dx = v1.X - v2.X;
        float dy = v1.Y - v2.Y;
        float dz = v1.Z - v2.Z;
        return MathF.Sqrt(dx * dx + dy * dy + dz * dz);
    }

    public static float Distance2D(Vector3 v1, Vector3 v2)
    {
        float dx = v1.X - v2.X;
        float dy = v1.Y - v2.Y;
        return MathF.Sqrt(dx * dx + dy * dy);
    }

    public static Vector3 Normalize(Vector3 vec)
    {
        return vec / Length(vec);
    }

    public static float Length(Vector3 vec)
    {
        return MathF.Sqrt(Dot(vec, vec));
    }

    public static float Dot(Vector3 v1, Vector3 v2)
    {
        return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
    }

    public static Vector3 operator /(Vector3 v, float value)
    {
        return new Vector3(v.X / value, v.Y / value, v.Z / value);
    }

    public static Vector3 operator *(Vector3 v, float value)
    {
        return new Vector3(v.X * value, v.Y * value, v.Z * value);
    }

    public static Vector3 operator *(Vector3 v1, Vector3 v2)
    {
        return new Vector3(v1.X * v2.X, v1.Y * v2.Y, v1.Z * v2.Z);
    }

    public static Vector3 operator +(Vector3 v1, Vector3 v2)
    {
        return new Vector3(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
    }

    public static Vector3 operator -(Vector3 v1, Vector3 v2)
    {
        return new Vector3(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
    }

    public static Vector3 Cross(Vector3 v1, Vector3 v2)
    {
        return new Vector3(
            (v1.Y * v2.Z) - (v1.Z * v2.Y),
            (v1.Z * v2.X) - (v1.X * v2.Z),
            (v1.X * v2.Y) - (v1.Y * v2.X)
        );
    }
}
public struct Matrix
{
    public float M11, M12, M13, M14;
    public float M21, M22, M23, M24;
    public float M31, M32, M33, M34;
    public float M41, M42, M43, M44;

    public static Matrix operator *(Matrix m1, Matrix m2)
    {
        Matrix result = new Matrix();
        result.M11 = m1.M11 * m2.M11 + m1.M12 * m2.M21 + m1.M13 * m2.M31 + m1.M14 * m2.M41;
        result.M12 = m1.M11 * m2.M12 + m1.M12 * m2.M22 + m1.M13 * m2.M32 + m1.M14 * m2.M42;
        result.M13 = m1.M11 * m2.M13 + m1.M12 * m2.M23 + m1.M13 * m2.M33 + m1.M14 * m2.M43;
        result.M14 = m1.M11 * m2.M14 + m1.M12 * m2.M24 + m1.M13 * m2.M34 + m1.M14 * m2.M44;

        result.M21 = m1.M21 * m2.M11 + m1.M22 * m2.M21 + m1.M23 * m2.M31 + m1.M24 * m2.M41;
        result.M22 = m1.M21 * m2.M12 + m1.M22 * m2.M22 + m1.M23 * m2.M32 + m1.M24 * m2.M42;
        result.M23 = m1.M21 * m2.M13 + m1.M22 * m2.M23 + m1.M23 * m2.M33 + m1.M24 * m2.M43;
        result.M24 = m1.M21 * m2.M14 + m1.M22 * m2.M24 + m1.M23 * m2.M34 + m1.M24 * m2.M44;

        result.M31 = m1.M31 * m2.M11 + m1.M32 * m2.M21 + m1.M33 * m2.M31 + m1.M34 * m2.M41;
        result.M32 = m1.M31 * m2.M12 + m1.M32 * m2.M22 + m1.M33 * m2.M32 + m1.M34 * m2.M42;
        result.M33 = m1.M31 * m2.M13 + m1.M32 * m2.M23 + m1.M33 * m2.M33 + m1.M34 * m2.M43;
        result.M34 = m1.M31 * m2.M14 + m1.M32 * m2.M24 + m1.M33 * m2.M34 + m1.M34 * m2.M44;

        result.M41 = m1.M41 * m2.M11 + m1.M42 * m2.M21 + m1.M43 * m2.M31 + m1.M44 * m2.M41;
        result.M42 = m1.M41 * m2.M12 + m1.M42 * m2.M22 + m1.M43 * m2.M32 + m1.M44 * m2.M42;
        result.M43 = m1.M41 * m2.M13 + m1.M42 * m2.M23 + m1.M43 * m2.M33 + m1.M44 * m2.M43;
        result.M44 = m1.M41 * m2.M14 + m1.M42 * m2.M24 + m1.M43 * m2.M34 + m1.M44 * m2.M44;
        return result;
    }

    public bool Transform(ref Vector3 vec)
    {
        float wInv = 1f / (M14 * vec.X + M24 * vec.Y + M34 * vec.Z + M44);
        Vector3 result = new Vector3(
            (M11 * vec.X + M21 * vec.Y + M31 * vec.Z + M41) * wInv,
            (M12 * vec.X + M22 * vec.Y + M32 * vec.Z + M42) * wInv,
            (M13 * vec.X + M23 * vec.Y + M33 * vec.Z + M43) * wInv
        );

        vec = result;
        return result.Z < 1f;
    }
}
public struct Plane3D
{
    public Vector3 Normal { get; set; }
    public float Distance { get; set; }

    public Plane3D(Vector3 normal, float distance)
    {
        Normal = Vector3.Normalize(normal);
        Distance = distance;
    }

    public static Plane3D FromPoint(Vector3 normal, Vector3 point)
    {
        return new Plane3D(normal, -Vector3.Dot(normal, point));
    }

    public (Vector3 PlaneOrigin, Vector3 ProjectedVector) ProjectVector(Vector3 vec)
    {
        Vector3 planeOrigin = ProjectPoint(Vector3.Zero);
        return (planeOrigin, ProjectPoint(vec) - planeOrigin);
    }

    private Vector3 ProjectPoint(Vector3 point)
    {
        float dot = Vector3.Dot(Normal, point) + Distance;
        return point - (Normal * dot);
    }
}
