﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void Loader(int level)
    {
        SceneManager.LoadScene(level);
    }
    
}
