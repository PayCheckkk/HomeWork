using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using DG.Tweening;

public class Alarm : MonoBehaviour
{
    public void IncreaseVolume(AudioSource audioSource, float interval)
    {
        audioSource.DOFade(1, interval);
    }

    public void DiscreaseVolume(AudioSource audioSource, float interval)
    {
        audioSource.DOFade(0, interval);
    }
}
