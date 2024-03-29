﻿public interface IHeroStats
{
    int Health { get; set; }
    int Attack { get; set;}
    int Defense { get; set;}
    int Speed { get; set;}
    int Armor { get; set;}
    int FocusPoints { get; set;}
    int CriticalHitChance { get; set;}
    int CriticalHitDamage { get; set;}
    int Effectiveness { get; set;}
    int EffectResistance { get; set;}
    int DualAttackChance { get; set;}
    int HitChance { get; set;}
}