using UnityEngine;

namespace DecoratorPattern
{
    public class AudioPlayer : MonoBehaviourSingleton<AudioPlayer>
    {
        [SerializeField] private AudioSource audioSource;

        public void Play(AudioClip audioClip)
        {
            audioSource.clip = audioClip;
            audioSource.Play();
        }
    }
}