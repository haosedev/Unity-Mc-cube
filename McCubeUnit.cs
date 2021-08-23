using UnityEngine;
using System.Collections; 

//Cube 脚本，需要自己放好贴图，材质取材是自己本身的贴图
//以目录内的图片做例图材质

public class McCubeUnit : MonoBehaviour{  

  void Start(){
      
    //gameObject.GetComponent<MeshRenderer>().material = mat; 
    Mesh mesh = GetComponent<MeshFilter>().mesh;

    //六个面贴不同的图片
    Vector2[] uvs = new Vector2[mesh.vertices.Length]; 
    float t = 1 / 3f; 
    //back OK
    uvs[0]  = new Vector2(0, 0);
    uvs[1]  = new Vector2(t, 0);
    uvs[2]  = new Vector2(0, t);
    uvs[3]  = new Vector2(t, t);
    //top ok
    uvs[8]  = new Vector2(t, 0);
    uvs[9]  = new Vector2(2 * t, 0); 
    uvs[4]  = new Vector2(t, t); 
    uvs[5]  = new Vector2(2 * t, t); 
    //front ok
    uvs[10] = new Vector2(2 * t, 0);  
    uvs[11] = new Vector2(1, 0);      
    uvs[6]  = new Vector2(2 * t, t);  
    uvs[7]  = new Vector2(1, t);      
    //bottom ok
    uvs[12] = new Vector2(0, t);      
    uvs[13] = new Vector2(t, t);      
    uvs[15] = new Vector2(0, 2 * t);  
    uvs[14] = new Vector2(t, 2 * t);  
    //left OK
    uvs[16] = new Vector2(t, t);      
    uvs[19] = new Vector2(2 * t, t);  
    uvs[17] = new Vector2(t, 2 * t);  
    uvs[18] = new Vector2(2 * t, 2 * t);  
    
    uvs[20] = new Vector2(2 * t, t);      
    uvs[23] = new Vector2(1, t);          
    uvs[21] = new Vector2(2 * t, 2 * t);  
    uvs[22] = new Vector2(1, 2 * t);      

    mesh.uv = uvs;  
  }     

}