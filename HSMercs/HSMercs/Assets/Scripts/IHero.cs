using UnityEngine;

public interface IHero
{
    IHeroVisual HeroVisual { get; }
    Transform HeroTransform { get;  }
    IHeroInformation HeroInformation { get;  }
    IBaseHeroStats BaseHeroStats { get;  }
    IHeroStats HeroStats { get;  }

    GameObject GameObjectName { get; }

}