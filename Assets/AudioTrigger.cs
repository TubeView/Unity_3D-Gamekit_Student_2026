using UnityEngine;
using Gamekit3D;
using FMODUnity;
using FMOD.Studio;
using STOP_MODE = FMOD.Studio.STOP_MODE;

public class AudioTrigger : MonoBehaviour
{

    public EventInstance eventInstance;
    public EventReference eventReference;

    public enum TimeOfDay
    {
        Morning,
        Day,
        Evening,
        Night
    }

    public TimeOfDay timeOfDay;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        eventInstance = RuntimeManager.CreateInstance(eventReference);
        eventInstance.start();
    }

    // Update is called once per frame
    void Update()
    {
        //eventInstance.stop(STOP_MODE.ALLOWFADEOUT);
        switch (timeOfDay)
        {
            case TimeOfDay.Morning:
                eventInstance.setParameterByNameWithLabel("TimeOfDay","Morning");
                break;
            case TimeOfDay.Day:
                eventInstance.setParameterByNameWithLabel("TimeOfDay","Day");
                break;
            case TimeOfDay.Evening:
                eventInstance.setParameterByNameWithLabel("TimeOfDay","Evening");
                break;
            case TimeOfDay.Night:
                eventInstance.setParameterByNameWithLabel("TimeOfDay","Night");
                break;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        eventInstance.setParameterByName("Progression",1);
    }
    public void OnTriggerExit(Collider other)
    {
        eventInstance.setParameterByName("Progression",0);
    }
    
}