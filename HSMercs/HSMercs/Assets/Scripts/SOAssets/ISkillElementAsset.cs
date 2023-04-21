namespace SOAssets
{
    public interface ISkillElementAsset
    {
        string ElementName { get; }

        /// <summary>
        /// Set text of Hero Race in the hero preview
        /// </summary>
        /// <param name="skill"></param>
        void SetElement(ISkill skill);
    }
}