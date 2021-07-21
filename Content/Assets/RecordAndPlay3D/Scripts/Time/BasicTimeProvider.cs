
namespace RecordAndPlay.Time
{

    /// <summary>
    /// Uses UnityEngine.Time.time
    /// </summary>
    public class BasicTimeProvider : ITimeProvider
    {

        public float CurrentTime(){
            return UnityEngine.Time.time;
        }

    }

}