using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pindah : MonoBehaviour
{
    public void pindahKeScene(string namaScene)
    {
        Application.LoadLevel(namaScene);
    }
}
