using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateTextScript : MonoBehaviour {

    Text txtBox;
    public GameObject NMEAManager;
    private NMEANetworkReader reader;
    

	// Use this for initialization
	void Start () {
        txtBox = gameObject.GetComponent<Text>();
        reader = NMEAManager.GetComponent<NMEANetworkReader>();
        
	}

    // Update is called once per frame
    void Update()
    {
        if (reader.getLatestPayload() != null)
        {
            txtBox.text = reader.getLatestPayload().ToString();
        }
    }
}
