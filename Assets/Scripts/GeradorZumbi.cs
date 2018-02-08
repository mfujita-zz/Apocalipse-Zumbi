using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorZumbi : MonoBehaviour 
{
    public GameObject Zumbi;
    private float contadorTempo = 0;
    public float TempoGerarZumbi;

	void Update () 
    {
        

        contadorTempo += Time.deltaTime;
        if (contadorTempo >= TempoGerarZumbi)
        {
            Zumbi.transform.position = new Vector3(Random.Range(-28, 16), transform.position.y, Random.Range(-30, 33));
            //Instantiate(Zumbi, transform.position, transform.rotation);
            Instantiate(Zumbi, Zumbi.transform.position, transform.rotation);
            contadorTempo = 0;
        }
	}
}
