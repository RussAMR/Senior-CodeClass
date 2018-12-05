using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using Object = UnityEngine.Object;

public enum SoundEffect
{
    Jump11,
    Bgm
}
public class AudioManager
{
    static AudioManager instance;
    private Dictionary<SoundEffect, AudioClip> SoundEffects
    { get; set; }
    private AudioSource soundEffectSource
    { get; set; }
    private AudioSource BGMSource
    { get; set; }
    public static AudioManager Instance
    { get { return instance ?? (instance = new AudioManager());  } }
    private AudioManager()
    {
        SoundEffects = Resources.LoadAll<AudioClip>("")
            .ToDictionary(t => (SoundEffect)Enum.Parse(typeof(SoundEffect), t.name, true));
        soundEffectSource = new GameObject("SoundEffectSource", typeof(AudioSource)).GetComponent<AudioSource>();
        Object.DontDestroyOnLoad(soundEffectSource.gameObject);

        BGMSource = new GameObject("BGMSource", typeof(AudioSource)).GetComponent<AudioSource>();
        BGMSource.volume = .25f;
        BGMSource.loop = true;
        Object.DontDestroyOnLoad(BGMSource.gameObject);
        ChangeBGM(Resources.Load<AudioClip>("C:/Users/195712/Documents/Platformer_Arussell/Assets/Resources/Bgm"));
    }
    public void PlayOneShot(SoundEffect sound,float volumescale = 1)
    {
        soundEffectSource.PlayOneShot(SoundEffects[sound],volumescale);
    }
    public void ChangeBGM(AudioClip clip)
    {
        BGMSource.clip = clip;
        BGMSource.Play();
    }
}

