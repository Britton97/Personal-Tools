using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Wave_Base_Class : ScriptableObject
{
    [SerializeField, Range(0,1)] public float waveStrength = 1;
    [SerializeField] public GameObject myParent;
    public abstract float Wave(float x, float z, float t);

    public abstract void Prerequisite(Test context);
}