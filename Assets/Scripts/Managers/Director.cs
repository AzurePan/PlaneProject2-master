using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director : Singleton<Director> {
    [SerializeField]
    private GameObject mainPlane;
    [SerializeField]
    private int score;

    private EnemyFactoryBase enemyFactoryBase;

    public  int  Score
    {
        get { return score; }
        set
        {
            score = value;
        }
       
    }
    void Awake () {
        enemyFactoryBase = new EnemyFactoryBase();
        enemyFactoryBase.CreateEnemy(EnemyType.NormalEnemy);
        enemyFactoryBase.CreateEnemy(EnemyType.Boss);

    }
    private void Start()
    {
        Instantiate(mainPlane, transform.position, mainPlane.transform.rotation);
    }

	
	void Update () {
		
	}
}
