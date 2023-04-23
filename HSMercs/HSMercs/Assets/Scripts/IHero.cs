using UnityEngine;

public interface IHero
{
    IHeroVisual HeroVisual { get; }
    Transform HeroTransform { get;  }
    IHeroInformation HeroInformation { get;  }
    IBaseHeroStats BaseHeroStats { get;  }
    IHeroStats HeroStats { get;  }

    IHeroSkills HeroSkills { get; set; }

    GameObject GameObjectName { get; }
    
    IPlayer Player { get; set; }

}