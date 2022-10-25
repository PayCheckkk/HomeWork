using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ThiefInHouse : MonoBehaviour
{
    //[SerializeField] private UnityEvent _thiefBrokeHouse = new UnityEvent();
    //[SerializeField] private UnityEvent _thiefLeftHouse = new UnityEvent();

    //public event UnityAction OnThiefBrokeHouse
    //{
    //    add => _thiefBrokeHouse.AddListener(value);
    //    remove => _thiefBrokeHouse.RemoveListener(value);
    //}

    //public event UnityAction OnThiefLeftHouse
    //{
    //    add => _thiefLeftHouse.AddListener(value);
    //    remove => _thiefLeftHouse.RemoveListener(value);
    //}

    //public void OnTriggerEnter2D(Collider2D collision)
    //{
    //    //if (collision.TryGetComponent<Thief>(out Thief thief))
    //    //{
    //    //    //_thiefBrokeHouse.Invoke();
    //    //}
    //}

    //public void OnTriggerExit2D(Collider2D collision)
    //{
    //    //if(collision.TryGetComponent<Thief>(out Thief thief))
    //    //{
    //    //    _thiefLeftHouse.Invoke();
    //    //}
    //}

    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private float _duration;

    private float _currentVolume;
    private float _targetVolume;
    private float _maxVolume = 1;
    private float _minVolume = 0;
    private float _runningTime;

    private void Update()
    {
        _runningTime += Time.deltaTime;
        _audioSource.volume = Mathf.Lerp(_currentVolume, _targetVolume, _runningTime / _duration);

        if (_audioSource.volume == 0)
            _audioSource.Stop();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        _audioSource.Play();

        if (collision.TryGetComponent<Thief>(out Thief thief))
        {
            _currentVolume = _audioSource.volume;
            _runningTime = 0;
            _targetVolume = _maxVolume;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Thief>(out Thief thief))
        {
            _currentVolume = _audioSource.volume;
            _runningTime = 0;
            _targetVolume = _minVolume;
        }
    }
}
