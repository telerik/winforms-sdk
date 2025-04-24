using System.Collections.Generic;

namespace RadMapCustomAzureProvider_NET48.Azure_Provider
{
    public static class AzureTileSetIdProvider
    {
        public static Dictionary<string, string> TileSetIdMap;

        static AzureTileSetIdProvider()
        {
            TileSetIdMap = new Dictionary<string, string>();
            TileSetIdMap.Add(AzureTileSet.DarkGrey.ToString(), "microsoft.base.darkgrey");
            TileSetIdMap.Add(AzureTileSet.HybridDarkGrey.ToString(), "microsoft.base.hybrid.darkgrey");
            TileSetIdMap.Add(AzureTileSet.HybridRoad.ToString(), "microsoft.base.hybrid.road");
            TileSetIdMap.Add(AzureTileSet.LabelsDarkGrey.ToString(), "microsoft.base.labels.darkgrey");
            TileSetIdMap.Add(AzureTileSet.LabelsRoad.ToString(), "microsoft.base.labels.road");
            TileSetIdMap.Add(AzureTileSet.Road.ToString(), "microsoft.base.road");
            TileSetIdMap.Add(AzureTileSet.TrafficAbsoluteMain.ToString(), "microsoft.traffic.absolute.main");
            TileSetIdMap.Add(AzureTileSet.TrafficDelayMain.ToString(), "microsoft.traffic.delay.main");
            TileSetIdMap.Add(AzureTileSet.TrafficReducedMain.ToString(), "microsoft.traffic.reduced.main");
            TileSetIdMap.Add(AzureTileSet.TrafficRelativeDark.ToString(), "microsoft.traffic.relative.dark");
            TileSetIdMap.Add(AzureTileSet.TrafficRelativeMain.ToString(), "microsoft.traffic.relative.main");
            TileSetIdMap.Add(AzureTileSet.WeatherInfraredMain.ToString(), "microsoft.weather.infrared.main");
            TileSetIdMap.Add(AzureTileSet.WeatherRadarMain.ToString(), "microsoft.weather.radar.main");
        }
    }
}
