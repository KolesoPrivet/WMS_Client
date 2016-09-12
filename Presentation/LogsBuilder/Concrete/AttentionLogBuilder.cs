using Presentation.LogsBuilder.Abstract;
using Presentation.ViewModels;

namespace Presentation.LogsBuilder.Concrete
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
