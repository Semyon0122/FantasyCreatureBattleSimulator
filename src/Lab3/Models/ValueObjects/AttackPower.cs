namespace Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

public record AttackPower
{
    public int Value { get; }

    public AttackPower(int value)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(value, "Attack power is positive!");

        Value = value;
    }

    public static AttackPower Max(AttackPower left, AttackPower right) => new(Math.Max(left.Value, right.Value));

    public static AttackPower Max(AttackPower left, HealthPoints right) => new(Math.Max(left.Value, right.Value));

    public static AttackPower operator +(AttackPower left, AttackPower right) => new(left.Value + right.Value);

    public static AttackPower operator +(AttackPower left, HealthPoints right) => new(left.Value + right.Value);

    public static AttackPower operator +(AttackPower left, int right) => new(left.Value + right);

    public static AttackPower operator -(AttackPower left, AttackPower right) => new(left.Value - right.Value);

    public static AttackPower operator -(AttackPower left, HealthPoints right) => new(left.Value - right.Value);

    public static AttackPower operator -(AttackPower left, int right) => new(left.Value - right);

    public static AttackPower operator *(AttackPower left, AttackPower right) => new(left.Value * right.Value);

    public static AttackPower operator *(AttackPower left, HealthPoints right) => new(left.Value * right.Value);

    public static AttackPower operator *(AttackPower left, int right) => new(left.Value * right);

    public static AttackPower operator /(AttackPower left, AttackPower right) => new(left.Value / right.Value);

    public static AttackPower operator /(AttackPower left, HealthPoints right) => new(left.Value / right.Value);

    public static AttackPower operator /(AttackPower left, int right) => new(left.Value / right);

    public static bool operator >(AttackPower left, AttackPower right) => left.Value > right.Value;

    public static bool operator >(AttackPower left, HealthPoints right) => left.Value > right.Value;

    public static bool operator >(AttackPower left, int right) => left.Value > right;

    public static bool operator <(AttackPower left, AttackPower right) => left.Value < right.Value;

    public static bool operator <(AttackPower left, HealthPoints right) => left.Value < right.Value;

    public static bool operator <(AttackPower left, int right) => left.Value < right;

    public static bool operator >=(AttackPower left, AttackPower right) => left.Value >= right.Value;

    public static bool operator >=(AttackPower left, HealthPoints right) => left.Value >= right.Value;

    public static bool operator >=(AttackPower left, int right) => left.Value >= right;

    public static bool operator <=(AttackPower left, AttackPower right) => left.Value <= right.Value;

    public static bool operator <=(AttackPower left, HealthPoints right) => left.Value <= right.Value;

    public static bool operator <=(AttackPower left, int right) => left.Value <= right;
}