using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{       

    public float veloc;
    public bool podeAtirar = true;
    public float tempoEntreTiros;
    public GameObject pfLaser;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float entradaVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * veloc * Time.deltaTime * entradaVertical);

        float entradaHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * veloc * Time.deltaTime * entradaHorizontal);

        if (Input.GetKeyDown(KeyCode.Space)&& podeAtirar == true){
            podeAtirar = false;
            Instantiate(pfLaser,transform.position + new Vector3(0,-0.2f,0),Quaternion.identity);
            Invoke("CDTiro", tempoEntreTiros);
        }

    }
    private void CDTiro(){
        podeAtirar = true;
    }
}
