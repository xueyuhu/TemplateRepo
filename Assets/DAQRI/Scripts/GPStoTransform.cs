using UnityEngine;

//https://stackoverflow.com/questions/639695/how-to-convert-latitude-or-longitude-to-meters
//
//For approximating short distances between two coordinates I used formulas from http://en.wikipedia.org/wiki/Lat-lon:
//
//m_per_deg_lat = 111132.954 - 559.822 * cos( 2 * latMid ) + 1.175 * cos( 4 * latMid);
//m_per_deg_lon = 111132.954 * cos(latMid );
//
//In the code below I've left the raw numbers to show their relation to the formula from wikipedia.
//
//double latMid, m_per_deg_lat, m_per_deg_lon, deltaLat, deltaLon, dist_m;
//
//latMid = (Lat1+Lat2 )/2.0;  // or just use Lat1 for slightly less accurate estimate
//
//m_per_deg_lat = 111132.954 - 559.822 * cos( 2.0 * latMid ) + 1.175 * cos( 4.0 * latMid);
//m_per_deg_lon = (3.14159265359/180 ) * 6367449 * cos(latMid );
//
//deltaLat = fabs(Lat1 - Lat2);
//deltaLon = fabs(Lon1 - Lon2);
//
//dist_m = sqrt(pow(deltaLat* m_per_deg_lat,2) + pow(deltaLon* m_per_deg_lon, 2) );
//The wikipedia entry states that the distance calcs are within 0.6m for 100km longitudinally and 1cm for 100km latitudinally but I have not verified this as anywhere near that accuracy is fine for my use.
public class GPStoTransform : MonoBehaviour
{
    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    /// <summary>
    /// GPSs to transform.
    /// </summary>
    /// <param name="coordinates">The coordinates.</param>
    /// <returns></returns>
    public Vector3 GPSToTransform(GPSCoordinatePair coordinates)
    {
        Vector3 returnMe = new Vector3();

        //coordinates.Latitude.Degrees* Constants.DegreesMultiplier;
        //coordinates.Latitude.Minutes* Constants.MinutesMultiplier;
        //coordinates.Latitude.Seconds* Constants.SecondsMultiplier;

        return returnMe;
    }

    /// <summary>
    /// generally used geo measurement function
    /// </summary>
    /// <param name="one"></param>
    /// <param name="two"></param>
    /// <returns></returns>
    public Vector3 GetDistance(GPSCoordinatePair one, GPSCoordinatePair two)
    {
        Vector3 returnMe = new Vector3();

        //float dLat = RadiansToDegrees(two.Latitude) - RadiansToDegrees(one.Latitude);
        //float dLon = RadiansToDegrees(two.Longitude) - RadiansToDegrees(one.Longitude);
        //float a = Mathf.Sin(dLat / 2) * Mathf.Sin(dLat / 2) +
        //Mathf.Cos(RadiansToDegrees(one.Latitude)) * Mathf.Cos(RadiansToDegrees(two.Latitude)) *
        //Mathf.Sin(dLon / 2) * Mathf.Sin(dLon / 2);
        //float c = 2 * Mathf.Atan2(Mathf.Sqrt(a), Mathf.Sqrt(1 - a));
        //float d = Constants.EarthRadius * c;
        //return d * 1000; // meters

        returnMe.x = 0;
        returnMe.y = 0;
        returnMe.z = 0;

        return returnMe;
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="radians"></param>
    /// <returns></returns>
    private float RadiansToDegrees(float radians)
    {
        return radians * Mathf.PI / 180;
    }
}

/// <summary>
///
/// </summary>
public class GPSCoordinatePair
{
    public GPSCoordinate Latitude { get; set; }
    public GPSCoordinate Longitude { get; set; }

    public GPSCoordinatePair()
    {
    }
}

/// <summary>
///
/// </summary>
public class GPSCoordinate
{
    public float Degrees { get; set; }
    public float Minutes { get; set; }
    public float Seconds { get; set; }

    public GPSCoordinate()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="GPSCoordinate" /> class.
    /// </summary>
    /// <param name="degrees">The degrees.</param>
    /// <param name="minutes">The minutes.</param>
    /// <param name="seconds">The seconds.</param>
    public GPSCoordinate(float degrees, float minutes, float seconds)
    {
        Degrees = degrees;
        Minutes = minutes;
        Seconds = seconds;
    }
}

/// <summary>
///
/// </summary>
public static class Constants
{
    public const float DegreesMultiplier = 0;
    public const float MinutesMultiplier = 0;
    public const float SecondsMultiplier = 0;
    public const float EarthRadius = 6378.137f; // Radius of earth in KM
}

