using WMS.WinformsClient.LogsBuilder.Abstract;
using WMS.WinformsClient.ViewModels;

namespace WMS.WinformsClient.LogsBuilder.Concrete
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
