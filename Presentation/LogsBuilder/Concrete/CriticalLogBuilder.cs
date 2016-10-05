using Presentation.LogsBuilder.Abstract;
using Presentation.ViewModels;

namespace Presentation.LogsBuilder.Concrete
{
    public class CriticalLogBuilder : LogBuilder
    {   
        public override void SetDescription(string additionalDescriptionParam)
        {
            buildingLog.Description = string.Format( "Description \n{0}", additionalDescriptionParam ); //TODO: Critical description
        }

        public override void SetLevelType()
        {
            buildingLog.LevelType = Level.Critical;
        }
    }
}
