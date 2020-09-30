﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SoundTransitorBase : MonoBehaviour
{
    //base class for serial & parallel classes

    [SerializeField] protected AudioClip[] _audioClips;
    protected int _currentClipIndex = 0;

    protected virtual void Awake()
    {
        if(_audioClips.Length == 0)
        {
            Debug.LogWarning("There is no audio clips to start.");
        }
    }
    protected abstract void UpdateSourceClip();
    protected virtual void RaiseIndex(int count)
    {
        if(_audioClips.Length == 0)
        {
            return;
        }
        _currentClipIndex = (_currentClipIndex + count) % _audioClips.Length;
    }
}
