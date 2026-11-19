using UnityEngine;
using Gamekit3D;
using FMODUnity;
using FMOD.Studio;
using STOP_MODE = FMOD.Studio.STOP_MODE;

public class WS : MonoBehaviour
{

    private float timer;
    
    public EventInstance eventInstance;
    public EventReference eventReference;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        eventInstance = RuntimeManager.CreateInstance(eventReference);
        eventInstance.start();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer <= 0f)
        {
            //eventInstance.stop(STOP_MODE.ALLOWFADEOUT);
            eventInstance.setParameterByName("Day-Night Cycle", 1);
        }
    }
}
