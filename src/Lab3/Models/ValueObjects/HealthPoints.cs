namespace Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

public record HealthPoints
{
    public int Value { get; }

    public HealthPoints(int value)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(value, "Health points are positive!");

        Value = value;
    }

    public static HealthPoints Max(HealthPoints left, HealthPoints right) => new(Math.Max(left.Value, right.Value));

    public static HealthPoints Max(HealthPoints left, AttackPower right) => new(Math.Max(left.Value, right.Value));

    public static HealthPoints operator +(HealthPoints left, HealthPoints right) => new(left.Value + right.Value);

    public static HealthPoints operator +(HealthPoints left, AttackPower right) => new(left.Value + right.Value);

    public static HealthPoints operator +(HealthPoints left, int right) => new(left.Value + right);

    public static HealthPoints operator -(HealthPoints left, HealthPoints right) => new(left.Value - right.Value);

    public static HealthPoints operator -(HealthPoints left, AttackPower right) => new(left.Value - right.Value);

    public static HealthPoints operator -(HealthPoints left, int right) => new(left.Value - right);

    public static HealthPoints operator *(HealthPoints left, HealthPoints right) => new(left.Value * right.Value);

    public static HealthPoints operator *(HealthPoints left, AttackPower right) => new(left.Value * right.Value);

    public static HealthPoints operator *(HealthPoints left, int right) => new(left.Value * right);

    public static HealthPoints operator /(HealthPoints left, HealthPoints right) => new(left.Value / right.Value);

    public static HealthPoints operator /(HealthPoints left, AttackPower right) => new(left.Value / right.Value);

    public static HealthPoints operator /(HealthPoints left, int right) => new(left.Value / right);

    public static bool operator >(HealthPoints left, HealthPoints right) => left.Value > right.Value;

    public static bool operator >(HealthPoints left, AttackPower right) => left.Value > right.Value;

    public static bool operator >(HealthPoints left, int right) => left.Value > right;

    public static bool operator <(HealthPoints left, HealthPoints right) => left.Value < right.Value;

    public static bool operator <(HealthPoints left, AttackPower right) => left.Value < right.Value;

    public static bool operator <(HealthPoints left, int right) => left.Value < right;

    public static bool operator >=(HealthPoints left, HealthPoints right) => left.Value >= right.Value;

    public static bool operator >=(HealthPoints left, AttackPower right) => left.Value >= right.Value;

    public static bool operator >=(HealthPoints left, int right) => left.Value >= right;

    public static bool operator <=(HealthPoints left, HealthPoints right) => left.Value <= right.Value;

    public static bool operator <=(HealthPoints left, AttackPower right) => left.Value <= right.Value;

    public static bool operator <=(HealthPoints left, int right) => left.Value <= right;
}