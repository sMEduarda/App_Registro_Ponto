using Microsoft.Maui.Devices.Sensors;

namespace App_Registro_Ponto.Services
{
    public class GeolocationService
    {
        public async Task<Location?> GetLocation()
        {
            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Medium);
                var location = await Geolocation.GetLocationAsync(request);

                return location;
            }
            catch
            {
                return null;
            }
        }
    }
}