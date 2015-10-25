using UnityEngine;
using System.Collections;

public class EarthScript : MonoBehaviour {

    private BreakMaterial m_BreakMaterial;

    public int m_Life;

    const int MAXLIFE = 10;


	// Use this for initialization
	void Start () {
        //Access to the BreakMaterial on the Child
        m_BreakMaterial = this.transform.GetChild(0).gameObject.GetComponent<BreakMaterial>();

        m_BreakMaterial.SetTexture(MAXLIFE - m_Life);
    }

    void SetLife(int i)
    {
        m_Life = i;
    }

    public void SubLife(int i)
    {
        m_Life -= i;
        m_BreakMaterial.SetTexture(MAXLIFE - m_Life);

        if(m_Life<=0)
        {
            Invoke("DestroyThis", 1);
        }
    }

    void DestroyThis()
    {
        Destroy(this.gameObject);
    }
    

}
