using System.Collections.Generic;
using UnityEngine;

public class ChunkPlacer : MonoBehaviour
{
    public Transform Player;
   // public Chunk[] ChunkPrefabs;
    public Chunk FirstChunk;
    /*public Chunk upChunk;
    public Chunk downChunk;
    public Chunk leftChunk;
    public Chunk rightChunk;*/
    public Chunk lastXChunk;
    public Chunk lastZChunk;


    //private int PChunkX;
   // private int PChunkZ;
    //int[][] nums = new int[3][];
  //  [System.Serializable]
    //public Chunk[,] spawnedChunks2;
    //public Chunk [,] spawnedChunks = new Chunk[3,3];


    private List<Chunk> spawnedChunks = new List<Chunk>();
    private List<Chunk> shownChunks = new List<Chunk>();

    // Start is called before the first frame update
   /* void PlayersChunk(){
        //Chunk PChunk;
        for (int i=0; i<spawnedChunks.Count; i++){
            float px = Player.position.z;
            float pz = Player.position.x;
            float cx1 = spawnedChunks[i].beginX.position.x;
            float cx2 = spawnedChunks[i].endX.position.x;
            float cz1 = spawnedChunks[i].beginZ.position.z;
            float cz2 = spawnedChunks[i].endZ.position.z;
            if((cx1 <= px)&&(px <= cx2)&&(cz1 <= pz)&&(pz <= cz2))
            {
                PChunk = i;
            }
        }
        
    }*/
    void Start()
    {
        //spawnedChunks[1, 1]= FirstChunk;
       // PChunkX = 1;
       // PChunkZ = 1;
       /* FirstChunk.downChunk.Show(false);
        FirstChunk.upChunk.Show(false);
        FirstChunk.leftChunk.Show(false);
        FirstChunk.rightChunk.Show(false);*/ 

    }
    
    void Update()
    {
       if(spawnedChunks.Count>5){
                    if(spawnedChunks[0]!=null){
                        spawnedChunks[0].Show(false);
                        spawnedChunks[0].isActive =false;
                        spawnedChunks.Remove(spawnedChunks[0]);
                        Debug.Log("too many");
                    }
        }
                        
        
        if ((FirstChunk.endZ.position.z - Player.position.z) < 100)
        {
            //Debug.Log("up");
            if (FirstChunk.upChunk != null){
                if (FirstChunk.upChunk.isActive == false){
                    FirstChunk.upChunk.Show(true);
                    FirstChunk.upChunk.isActive = true;
                    spawnedChunks.Add(FirstChunk.upChunk);
                    Debug.Log(spawnedChunks.Count);
                }
                    
                
                /*
                if(spawnedChunks.Count>11){
                    if(spawnedChunks[10]!=null)
                        if (HideFarawayChunks(spawnedChunks[11]))
                            spawnedChunks.RemoveAt(10);
                }
                if((FirstChunk.downChunk != null) && (FirstChunk.downChunk.downChunk != null))
                    HideFarawayChunks(FirstChunk.downChunk.downChunk);
                    //FirstChunk.downChunk.downChunk.Show(false);*/
            }
                
        }
       // Debug.Log((spawnedChunks[1, 1].endZ.position.z - Player.position.z));
        if ((FirstChunk.beginZ.position.z - Player.position.z) > -100 )
        {
            //Debug.Log("down");
            if (FirstChunk.downChunk != null){
                
                if (FirstChunk.downChunk.isActive == false){
                    FirstChunk.downChunk.Show(true);
                    FirstChunk.downChunk.isActive = true;
                    spawnedChunks.Add(FirstChunk.downChunk);
                    Debug.Log(spawnedChunks.Count);

                }
                
                /*
                if(spawnedChunks.Count>11){
                    if(spawnedChunks[10]!=null)
                        if (HideFarawayChunks(spawnedChunks[11]))
                            spawnedChunks.RemoveAt(10);
                }
                if ((FirstChunk.upChunk != null) && (FirstChunk.upChunk.upChunk != null))
                   HideFarawayChunks(FirstChunk.upChunk.upChunk);*/
            }
        }
        if ((FirstChunk.endX.position.x - Player.position.x) < 100)
        {
            //Debug.Log("right");
            if (FirstChunk.rightChunk != null){
                if (FirstChunk.rightChunk.isActive == false){
                    FirstChunk.rightChunk.Show(true);
                    FirstChunk.rightChunk.isActive = true;
                    spawnedChunks.Add(FirstChunk.rightChunk);
                    Debug.Log(spawnedChunks.Count);

                }
                
               /* if(spawnedChunks.Count>11){
                    if(spawnedChunks[10]!=null)
                        if (HideFarawayChunks(spawnedChunks[11]))
                            spawnedChunks.RemoveAt(10);
                }
                if ((FirstChunk.leftChunk != null) && (FirstChunk.leftChunk.leftChunk != null))
                   HideFarawayChunks(FirstChunk.leftChunk.leftChunk);*/
            }
        }
       // Debug.Log((spawnedChunks[1, 1].endZ.position.z - Player.position.z));
        if ((FirstChunk.beginX.position.x - Player.position.x) > -100 )
        {
            if (FirstChunk.leftChunk != null){
                if (FirstChunk.leftChunk.isActive == false){
                    FirstChunk.leftChunk.Show(true);
                    FirstChunk.leftChunk.isActive = true;
                    spawnedChunks.Add(FirstChunk.leftChunk);
                    Debug.Log(spawnedChunks.Count);
                }
                
               
                /*if(spawnedChunks.Count>11){
                    if(spawnedChunks[10]!=null)
                        if (HideFarawayChunks(spawnedChunks[11]))
                            spawnedChunks.RemoveAt(10);
                }
                
               if((FirstChunk.rightChunk != null) && (FirstChunk.rightChunk.rightChunk != null))
                  HideFarawayChunks(FirstChunk.rightChunk.rightChunk);*/

            }
        }
       // Debug.Log(Player.position.x);
        //Debug.Log(FirstChunk.endX.position.x);

        if(Player.position.x>FirstChunk.endX.position.x)
        {
            if (FirstChunk.rightChunk != null)
            {
                FirstChunk = FirstChunk.rightChunk;
                if ((FirstChunk.leftChunk != null) && (FirstChunk.leftChunk.leftChunk != null))
                {
                    FirstChunk.leftChunk.leftChunk.Show(false);
                    FirstChunk.leftChunk.leftChunk.isActive = false;
                    spawnedChunks.Remove(FirstChunk.leftChunk.leftChunk);
                }

               // HideFarawayChunks();
            }
           // Debug.Log(FirstChunk.endX.position.x); 

            //Debug.Log(FirstChunk.rightChunk.beginX.position.x); 
        }
        if(Player.position.x<FirstChunk.beginX.position.x)
        {
             if (FirstChunk.leftChunk != null)
             {
                FirstChunk = FirstChunk.leftChunk;
                if((FirstChunk.rightChunk != null) && (FirstChunk.rightChunk.rightChunk != null))
                {    
                    FirstChunk.rightChunk.rightChunk.Show(false);
                    FirstChunk.rightChunk.rightChunk.isActive = false;

                    spawnedChunks.Remove(FirstChunk.rightChunk.rightChunk);
                }
                    
                
               // HideFarawayChunks();

             }

            //Debug.Log(FirstChunk.beginX.position.x); 
        }
        if(Player.position.z>FirstChunk.endZ.position.z)
        {
            if (FirstChunk.upChunk != null)
            {
                FirstChunk = FirstChunk.upChunk;
                if((FirstChunk.downChunk != null) && (FirstChunk.downChunk.downChunk != null))
                {
                    FirstChunk.downChunk.downChunk.Show(false);
                    FirstChunk.downChunk.downChunk.isActive = false;
                    spawnedChunks.Remove(FirstChunk.downChunk.downChunk);

                }    
              //  HideFarawayChunks();

            }
            //Debug.Log(FirstChunk.endZ.position.z); 

            //Debug.Log(FirstChunk.rightChunk.beginX.position.x); 
        }
        if(Player.position.z<FirstChunk.beginZ.position.z)
        {
            if (FirstChunk.downChunk != null)
            {
                FirstChunk = FirstChunk.downChunk;
                if ((FirstChunk.upChunk != null) && (FirstChunk.upChunk.upChunk != null))
                {
                     FirstChunk.upChunk.upChunk.Show(false);
                     FirstChunk.upChunk.upChunk.isActive = false;

                     spawnedChunks.Remove(FirstChunk.upChunk.upChunk);
                     Debug.Log("deleted");

                }   
               // HideFarawayChunks();

            }

           // Debug.Log(FirstChunk.beginZ.position.z); 
        }
    }
    private void deleteChunk(Chunk HideThis){
        for(int i =0; i<spawnedChunks.Count; i++){
            if (spawnedChunks[i]==HideThis)
            {
                spawnedChunks.RemoveAt(i);
                //Debug.Log(spawnedChunks.Count);

            }  
        }
    }

    /*private bool HideFarawayChunks(Chunk HideThis){
        bool result = false;
        shownChunks.Add(FirstChunk);
        if(FirstChunk.leftChunk!=null){
            shownChunks.Add(FirstChunk.leftChunk);
            if (FirstChunk.leftChunk.upChunk!=null)
                shownChunks.Add(FirstChunk.leftChunk.upChunk);
            if(FirstChunk.leftChunk.downChunk!=null)
                shownChunks.Add(FirstChunk.leftChunk.downChunk);
        }
        
        if (FirstChunk.upChunk!=null)
            shownChunks.Add(FirstChunk.upChunk);
        if (FirstChunk.downChunk!=null)
            shownChunks.Add(FirstChunk.downChunk);

        if (FirstChunk.rightChunk!=null){
            shownChunks.Add(FirstChunk.rightChunk);
            if (FirstChunk.rightChunk.upChunk != null)
                shownChunks.Add(FirstChunk.rightChunk.upChunk);
            if (FirstChunk.rightChunk.downChunk != null)
                shownChunks.Add(FirstChunk.rightChunk.downChunk);
        }
        //for (int i=0; i<shownChunks.Count; i++){
           // shownChunks[i].Show(true);
        //}
        //for (int i=0; i<spawnedChunks.Count; i++){
            for (int j=0; j<shownChunks.Count; j++){
                if (HideThis != shownChunks[j]){
                    HideThis.Show(false);
                    result = true;
                }
            }
            
        //}
        return result;
    }*/




        





        //Chunk newChunk = Instantiate(ChunkPrefabs[Random.Range(0, ChunkPrefabs.Length)]);
       // newChunk.transform.position = spawnedChunks[spawnedChunks.Count - 1].endZ.position - newChunk.beginZ.localPosition;
       // spawnedChunks.Add(newChunk);
       // Debug.Log("spawned");
      //  if (spawnedChunks.Count >=10){
       //     Destroy(spawnedChunks[0].gameObject);
       //     spawnedChunks.RemoveAt(0);
       // }
    
    private void SpawnChunkBZ(){
       // Chunk newChunk = Instantiate(ChunkPrefabs[Random.Range(0, ChunkPrefabs.Length)]);
       // newChunk.transform.position = spawnedChunks[spawnedChunks.Count - 1].beginZ.position - newChunk.endZ.localPosition;
       // spawnedChunks.Add(newChunk);
       // Debug.Log("spawned");
        //if (spawnedChunks.Count >=10){
       //     Destroy(spawnedChunks[0].gameObject);
       //     spawnedChunks.RemoveAt(0);
       // }
    }
    private void SpawnChunkEX(){
       // Chunk newChunk = Instantiate(ChunkPrefabs[Random.Range(0, ChunkPrefabs.Length)]);
      //  newChunk.transform.position = spawnedChunks[spawnedChunks.Count - 2].endX.position - newChunk.beginX.localPosition;
      //  spawnedChunks.Add(newChunk);
      //  Debug.Log("spawned");
      //  if (spawnedChunks.Count >=10){
       //     Destroy(spawnedChunks[0].gameObject);
      //      spawnedChunks.RemoveAt(0);
       // }
    }
    private void SpawnChunkBX(){
      //  Chunk newChunk = Instantiate(ChunkPrefabs[Random.Range(0, ChunkPrefabs.Length)]);
     //   newChunk.transform.position = spawnedChunks[spawnedChunks.Count - 2].beginX.position - newChunk.endX.localPosition;
     //   spawnedChunks.Add(newChunk);
      //  Debug.Log("spawned");
      //  if (spawnedChunks.Count >=10){
     //      Destroy(spawnedChunks[0].gameObject);
      //      spawnedChunks.RemoveAt(0);
      //  }
    }
}


    
