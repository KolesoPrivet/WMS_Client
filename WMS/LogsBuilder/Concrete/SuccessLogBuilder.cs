using WMS.WinformsClient.LogsBuilder.Abstract;
using WMS.WinformsClient.ViewModels;

namespace WMS.WinformsClient.LogsBuilder.Concrete
{
    public class SuccessLogBuilder : LogBuilder
    {
        public override void SetDescription(string additionalDescriptionParam)
        {
            buildingLog.Description = string.Format("Success! {0}", additionalDescriptionParam); //TODO: Success description  
        }      

        public override void SetLevelType()
        {
            buildingLog.LevelType = Level.Success;
        }
    }
}
