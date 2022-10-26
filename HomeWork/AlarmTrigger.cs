using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AlarmTrigger : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private float _duration;
    [SerializeField] private Alarm alarm;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        _audioSource.Play();
        if(collision.TryGetComponent<Thief>(out Thief thief))
        alarm.IncreaseVolume(_audioSource, _duration);
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Thief>(out Thief thief))
            alarm.DiscreaseVolume(_audioSource, _duration);

        if (_audioSource.volume == 0)
            _audioSource.Stop();
    }
}
