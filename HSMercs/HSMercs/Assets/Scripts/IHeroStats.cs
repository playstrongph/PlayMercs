public interface IHeroStats
{
    int Health { get; }
    int Attack { get; }
    int Defense { get; }
    int Speed { get; }
    int FocusPoints { get; }
    int CriticalHitChance { get; }
    int CriticalHitDamage { get; }
    int Effectiveness { get; }
    int EffectResistance { get; }
    int DualAttackChance { get; }
    int HitChance { get; }
}