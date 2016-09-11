using Presentation.LogsBuilder.Abstract;
using Presentation.ViewModels;

namespace Presentation.LogsBuilder.Concrete
{
    public class ErrorLogBuilder : LogBuilder
    {
        public override void SetDescription(string additionalDescriptionParam)
        {
            buildingLog.Description = string.Format( "Error! {0}", additionalDescriptionParam ); //TODO: Error description        
        }

        public override void SetLevelType()
        {
            buildingLog.LevelType = Level.Error;
        }
    }
}
