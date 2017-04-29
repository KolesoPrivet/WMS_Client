using WMS.WinFormsClient;

namespace WMS.WinFormsClient
{
    class AttentionLogBuilder : LogBuilder
    {
        public override void SetDescription(string additionalDescriptionParam)
        {
            buildingLog.Description = string.Format( "Attention! {0}", additionalDescriptionParam ); ; //TODO: Attention description
        }

        public override void SetLevelType()
        {
            buildingLog.LevelType = Level.Attention;
        }
    }
}
