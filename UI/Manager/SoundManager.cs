using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    private static SoundManager _soundManager;

    [SerializeField]
    private AudioMixer _audioMixer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        if (_soundManager == null)
        {
            _soundManager = this;

            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetAudioVolume(string audioString, float volumeValue)
    {
        Debug.Log(volumeValue);

        _audioMixer.SetFloat(audioString, volumeValue);
    }

    public float GetAudioVolume(string audioString)
    {
        float audioSoundValue = 0;
        _audioMixer.GetFloat(audioString, out audioSoundValue);

        return audioSoundValue;
    }

    public static SoundManager p_soundManager
    {
        get
        {
            if (_soundManager == null)
            {
                return null;
            }
            return _soundManager;
        }

        private set { }
    }
}
