namespace Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

public record HealthPoints
{
    private readonly int _value;

    public HealthPoints(int value)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(value, "Health points are positive!");

        _value = value;
    }

    public static HealthPoints Max(HealthPoints left, HealthPoints right) => new(Math.Max(left._value, right._value));

    public static HealthPoints operator +(HealthPoints left, HealthPoints right) => new(left._value + right._value);

    public static HealthPoints operator +(HealthPoints left, int right) => new(left._value + right);

    public static HealthPoints operator -(HealthPoints left, HealthPoints right) => new(left._value - right._value);

    public static HealthPoints operator -(HealthPoints left, int right) => new(left._value - right);

    public static HealthPoints operator *(HealthPoints left, HealthPoints right) => new(left._value * right._value);

    public static HealthPoints operator *(HealthPoints left, int right) => new(left._value * right);

    public static HealthPoints operator /(HealthPoints left, HealthPoints right) => new(left._value / right._value);

    public static HealthPoints operator /(HealthPoints left, int right) => new(left._value / right);

    public static bool operator >(HealthPoints left, HealthPoints right) => left._value > right._value;

    public static bool operator >(HealthPoints left, int right) => left._value > right;

    public static bool operator <(HealthPoints left, HealthPoints right) => left._value < right._value;

    public static bool operator <(HealthPoints left, int right) => left._value < right;

    public static bool operator >=(HealthPoints left, HealthPoints right) => left._value >= right._value;

    public static bool operator >=(HealthPoints left, int right) => left._value >= right;

    public static bool operator <=(HealthPoints left, HealthPoints right) => left._value <= right._value;

    public static bool operator <=(HealthPoints left, int right) => left._value <= right;
}