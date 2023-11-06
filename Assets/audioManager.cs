using UnityEngine.Audio;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    public Sound[] sounds;
    public static audioManager instance;
    void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);

        foreach(Sound s in sounds)
        {
           s.source =  gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
