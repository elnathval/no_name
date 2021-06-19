using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterScript : MonoBehaviour
{
    public ButtonScript a;
    public Text contador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string Counting = a.Counter.ToString();
        contador.text = Counting;
    }
}
