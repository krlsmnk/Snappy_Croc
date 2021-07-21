
/// <summary>
/// Responsible for controlling the time elpased between updates to the recorder and playback functionality. Record and Play defaults to using <a page="EliCDavis.RecordAndPlay.Time.BasicTimeProvider">BasicTimeProvider</a>, which just uses Unity3D's <b>Time.time</b>.
///
/// Games that have their own "time" independent of unity will want to implement the <a page="EliCDavis.RecordAndPlay.Time.ITimeProvider">ITimeProvider</a> to ensure the recording software captures the proper time values. An exanple of this would be a fighting game that operates at a locked 24 FPS for input, regaurdless of actual update lifecycle speed. 
/// </summary>
namespace RecordAndPlay.Time
{

    /// <summary>
    /// The way Record and Play can retrieve the current time. Kind of 
    /// neccessary with how many different ways you can query "time" inside of
    /// Unity.
    /// </summary>
    public interface ITimeProvider
    {

        /// <summary>
        /// The current game time.
        /// </summary>
        /// <returns>The current game time.</returns>
        float CurrentTime();

    }

}