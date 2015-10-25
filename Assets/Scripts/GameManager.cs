using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {


    /// <summary>
    /// The Singleton
    /// </summary>
    #region Singleton
    static private GameManager s_Instance;
    static public GameManager instance
    {
        get
        {
            return s_Instance;
        }
    }

    void Awake()
    {
        if (s_Instance == null)
            s_Instance = this;
        //DontDestroyOnLoad(this);
    }
    #endregion


    public int m_Size;

    private int m_GBX;
    private int m_GBY;

    

    //Double Tableau
    private GameObject[,] GameBoard;



    public GameObject m_EarthPrefab;
    private GameObject m_EarthInstance;

    // Use this for initialization
    void Start ()
    {
        m_Size = 11;
        m_GBX = m_Size;
        m_GBY = m_Size;
        GameBoard = new GameObject[m_GBX, m_GBY];

        float x = -m_GBX / 2;
        float z =  m_GBY/2;
        for(int i=0;i< m_GBX;i++)
        {
            for (int j = 0; j < m_GBY; j++)
            {
                m_EarthInstance = Instantiate(m_EarthPrefab, new Vector3(x+j, m_EarthPrefab.transform.position.y, z-i), m_EarthPrefab.transform.rotation) as GameObject;
                GameBoard[i, j] = m_EarthInstance;
            }
        }
	}

}
