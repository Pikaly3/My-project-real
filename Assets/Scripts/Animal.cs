using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    protected Color color;
    private float weight;
    public string name;

    public void ejemploPublic(int damage, string attackName)
    {
        damage++;
    }

    private void ejemploPrivado()
    {

    }

    public void ejemploProtector()
    {

    }

}
