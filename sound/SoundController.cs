using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    [SerializeField]
    private string _mixerString;

    [SerializeField]
    private Slider _slider;

    //[SerializeField]
    //private Button _checkButton;

    private float _volumeTemp;
    private bool _isPlaySound;
    private float _soundMinimum;

    // Start is called before the first frame update
    void Start()
    {
        _isPlaySound = true;
        _soundMinimum = -100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetVolume()
    {
        SoundManager.p_soundManager.SetAudioVolume(_mixerString, _slider.value);
        _isPlaySound = true;
    }

    public void OnClickToggleButton()
    {
        if(_isPlaySound == true)
        {
            _volumeTemp = SoundManager.p_soundManager.GetAudioVolume(_mixerString);
            SoundManager.p_soundManager.SetAudioVolume(_mixerString, _soundMinimum);
            _isPlaySound = false;
        }
        else
        {
            SoundManager.p_soundManager.SetAudioVolume(_mixerString, _volumeTemp);
            _isPlaySound = true;
        }
    }
}
