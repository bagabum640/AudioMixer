using UnityEngine;
using UnityEngine.Audio;

public class MuteMasterSound : MonoBehaviour
{
    private const float DefaultVolume = 0f;
    private const float MinVolume = -80f;
    private const string MuteVolume = "MasterVolume";

    [SerializeField] private AudioMixer _audioMixer;

    public void MuteMusic(bool enabled)
    {
        if (enabled)
            _audioMixer.SetFloat(MuteVolume, MinVolume);
        else
            _audioMixer.SetFloat(MuteVolume, DefaultVolume);
    }
}