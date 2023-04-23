namespace SOAssets
{
    public interface IHeroClassAsset
    {
        
        string ClassName { get;}
        void SetClassColor(IHeroGraphics heroGraphics);

        void SetSkillPanelClassColor(IHero hero);

        void SetSkillPreviewFrameColor(ISkill skill);
    }
}