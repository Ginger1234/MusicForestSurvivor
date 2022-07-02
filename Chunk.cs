using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    public GameObject food;
    public int NumberOfFooditems;
    public float HeigeightOfSpawningFood;


    public Transform beginX;
    public Transform beginZ;
    public Transform endX;
    public Transform endZ;
    public GameObject lvl1;
    public GameObject lvl2;
    public GameObject lvl3;
    public GameObject lvl4;

    public Chunk leftChunk;
    public Chunk rightChunk;
    public Chunk upChunk;
    public Chunk downChunk;
    //public Chunk CurrentChunk;
    public List<Chunk> Chunks = new List<Chunk>();

    public bool isActive;
    

    // Start is called before the first frame update
    void Start()
    {
       // Debug.Log(gameObject.transform.position.x);
        
        beginX = transform.Find("beginX");
        beginZ = transform.Find("beginZ");
        endX = transform.Find("endX");
        endZ = transform.Find("endZ");
       // Instantiate(food, new Vector3(-2593, HeigeightOfSpawningFood, 1885), new Quaternion(0, 0 , 0, 1));
        //string nameL="Terrain_(" + (gameObject.transform.position.x-1000).ToString() + ".0, 0.0, -1500.0)";
        string nameL="Terrain_(" + (gameObject.transform.position.x-1000).ToString() + ".0, 0.0, " + (gameObject.transform.position.z).ToString() + ".0)";
        string nameR="Terrain_(" + (gameObject.transform.position.x+1000).ToString() + ".0, 0.0, " + (gameObject.transform.position.z).ToString() + ".0)";
        string nameU="Terrain_(" + (gameObject.transform.position.x).ToString() + ".0, 0.0, " + (gameObject.transform.position.z+1000).ToString() + ".0)";
        string nameD="Terrain_(" + (gameObject.transform.position.x).ToString() + ".0, 0.0, " + (gameObject.transform.position.z-1000).ToString() + ".0)";
        
        if (lvl1.transform.Find(nameL)!=null)
            leftChunk = lvl1.transform.Find(nameL).GetComponent<Chunk>();
        if(lvl1.transform.Find(nameR)!=null)
            rightChunk = lvl1.transform.Find(nameR).GetComponent<Chunk>();
        if(lvl1.transform.Find(nameU)!=null)
            upChunk = lvl1.transform.Find(nameU).GetComponent<Chunk>();
        if (lvl1.transform.Find(nameD)!=null)
            downChunk = lvl1.transform.Find(nameD).GetComponent<Chunk>();
        

        if (lvl2.transform.Find(nameL)!=null)
            leftChunk = lvl2.transform.Find(nameL).GetComponent<Chunk>();
        if(lvl2.transform.Find(nameR)!=null)
            rightChunk = lvl2.transform.Find(nameR).GetComponent<Chunk>();
        if(lvl2.transform.Find(nameU)!=null)
            upChunk = lvl2.transform.Find(nameU).GetComponent<Chunk>();
        if (lvl2.transform.Find(nameD)!=null)
            downChunk = lvl2.transform.Find(nameD).GetComponent<Chunk>();


        if (lvl3.transform.Find(nameL)!=null)
            leftChunk = lvl3.transform.Find(nameL).GetComponent<Chunk>();
        if(lvl3.transform.Find(nameR)!=null)
            rightChunk = lvl3.transform.Find(nameR).GetComponent<Chunk>();
        if(lvl3.transform.Find(nameU)!=null)
            upChunk = lvl3.transform.Find(nameU).GetComponent<Chunk>();
        if (lvl3.transform.Find(nameD)!=null)
            downChunk = lvl3.transform.Find(nameD).GetComponent<Chunk>();

        
        if (lvl4.transform.Find(nameL)!=null)
            leftChunk = lvl4.transform.Find(nameL).GetComponent<Chunk>();
        if(lvl4.transform.Find(nameR)!=null)
            rightChunk = lvl4.transform.Find(nameR).GetComponent<Chunk>();
        if(lvl4.transform.Find(nameU)!=null)
            upChunk = lvl4.transform.Find(nameU).GetComponent<Chunk>();
        if (lvl4.transform.Find(nameD)!=null)
            downChunk = lvl4.transform.Find(nameD).GetComponent<Chunk>();


        spawnFood(NumberOfFooditems);


        //leftChunk = GameObject.Find(nameL).GetComponent<Chunk>();
        

        /*for (int i =0; i< Chunks.Count; i++){
            if (((gameObject.transform.position.x-1000)==Chunks[i].transform.position.x )&&(Chunks[i].transform.position.z==gameObject.transform.position.z))
                leftChunk = Chunks[i];
            if (((gameObject.transform.position.x+1000)==Chunks[i].transform.position.x )&&(Chunks[i].transform.position.z==gameObject.transform.position.z))
                rightChunk = Chunks[i];
            if (((gameObject.transform.position.z-1000)==Chunks[i].transform.position.z )&&(Chunks[i].transform.position.x==gameObject.transform.position.x))
                downChunk = Chunks[i];
            if (((gameObject.transform.position.z+1000)==Chunks[i].transform.position.z )&&(Chunks[i].transform.position.x==gameObject.transform.position.x))
                upChunk = Chunks[i];
        }*/
        
    }
    void spawnFood(int num)
    {
        for (int i =0; i<num;i++)
        {
            float pearX =Random.Range(gameObject.transform.position.x-500, gameObject.transform.position.x+500);
            float pearZ = Random.Range(gameObject.transform.position.z-500, gameObject.transform.position.z+500);
            //float pearX =Random.Range(gameObject.transform.position.x-500-500, gameObject.transform.position.x-500+500);
           // float pearZ = Random.Range(gameObject.transform.position.z+3500-500, gameObject.transform.position.z+3500+500);
            Instantiate(food, new Vector3(pearX, HeigeightOfSpawningFood, pearZ), new Quaternion(0, 0 , 0, 1));
            //Debug.Log(pearX);
           // Debug.Log(pearZ);
        }
        
    }

    public void Show(bool flag)
    {
        gameObject.SetActive(flag); 
    }
}
