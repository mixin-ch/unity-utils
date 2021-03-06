using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : Singleton
{
    [SerializeField] private ApplicationManager _applicationManager;
    [SerializeField] private AudioManager _audioManager;
    [SerializeField] private Mixin.SceneManager _sceneManager;

}
