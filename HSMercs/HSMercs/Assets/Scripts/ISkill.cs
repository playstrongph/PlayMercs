using UnityEngine;

public interface ISkill
{
    ISkillVisual SkillVisual { get; }
    ISkillAttributes SkillAttributes { get; }
    GameObject ThisGameObject { get;}
    
    IHero Hero { get; set; }


}