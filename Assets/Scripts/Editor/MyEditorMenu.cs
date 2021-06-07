using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MyEditorMenu : ScriptableWizard
{
    public Type type;
    public enum Type
    {
        선택한_것만, 
        디렉토리에_있는것을_대상으로

    }

    protected override bool DrawWizardGUI()
    {
        base.DrawWizardGUI();
        if (GUILayout.Button("쉐이더 교체"))
        {
            ChangeSelctedShader();
        }
        if (GUILayout.Button("설정 복사"))
        {
            CopyShaderConfig();
        }
        if (GUILayout.Button("설정 붙여넣기"))
        {
            PasteShaderConfig();
        }

        return true;

        static void CopyShaderConfig()
        {
            CopyShaderConfig();
        }

        static void PasteShaderConfig()
        {
            PasteShaderConfig();
        }
    }

    private void ChangeSelctedShader()
    {
        //내가 선택한 오브젝트의 쉐이더를 내가 지정한 쉐이더로 교체하자.
        /*Selection.objects */// 내가 선택한 모든 오브젝트 들어가 있다.
        foreach (var item in Selection.objects)
        {
            GameObject go = (GameObject)item;
            //렌더러 접근 -> 메테리얼 접근 -> 쉐이더 교체
            var renderer = go.GetComponent<Renderer>();

            if (renderer)
                renderer.sharedMaterial.shader = toShader;

           
        }
        //메테리얼의 설정을 모두 복사하자
        Debug.Assert(Selction.object.Length == 1, $"선택된 오브젝트의 개수가 {Selection.objects.Length}개 입니다");
        Renderer renderer = Selection.activeGameObject.GetComponent<Renderer>();
        Shader toshader = renderer.material.shader;
        renderer.sharedMaterial = new List<ShaderPropertyInfo>(count);


    }


    public Shader toShader;
    
    public float myFloat;
    public string myString = "기본값";
    public bool myBool;

    public Material meterial;
    public Shader shader; 
    
    [MenuItem("Assets/MyMenu", false, 1)]
    static void MyMenu()
    { 
        Debug.Log("나의 메뉴 실행됨, UI를 열자");
        DisplayWizard<MyEditorMenu>("나의 메뉴", "닫기");
    }

}
