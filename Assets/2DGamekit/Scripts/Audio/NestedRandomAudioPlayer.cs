using Gamekit2D;
using System.Collections;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Assets._2DGamekit.Scripts.Audio
{
    public class NestedRandomAudioPlayer : RandomAudioPlayer
    {

        [Header("Clips for nested")]
        public AudioClip beforeClip;
        public AudioClip afterClip;

        public void BeforePlaySound(TileBase surface = null)
        {
            m_Source.PlayOneShot(beforeClip);
        }

        public void AfterPlaySound(TileBase surface = null)
        {
            Debug.Log("Play After sound");
            m_Source.PlayOneShot(afterClip);
        }
    }
}