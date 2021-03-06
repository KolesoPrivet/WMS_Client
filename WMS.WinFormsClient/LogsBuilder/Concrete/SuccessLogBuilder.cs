﻿namespace WMS.WinFormsClient
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
