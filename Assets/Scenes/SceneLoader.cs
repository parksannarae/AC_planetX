// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class SceneLoader : MonoBehaviour
// {
//     // 호출할 씬과 씬 로드 방식을 저장할 딕셔너리
//     public Dictionary loadScenes = new Dictionary();

//     //호출 할 씬의 정보 설정
//     void InitSceneInfo()
//     {
//         //호출 할 씬의 정보를 딕셔너리에 추가
//         loadScenes.Add("1F", LoadSceneMode.Additive);
//     }
//     IEnumerator Start()
//     {
//         InitSceneInfo();

//         foreach (var -loadScenes in loadScenes)
//         {
//             yield return StartCoroutine(loadScenes(_loadScene.Key, _loadScene.Value));
//         }
//     }

//     IEnumerator LoadScene(string sceneName, LoadSceneMode mode)
//     {
//         yield return new WaitForSeconds(3.0f);

//         //기존의 씬을 언로드
//         if (sceneName == "")

//         else if(sceneName == "")
//     }

//     // Update is called once per frame
    