using DG.Tweening.Core;
using UnityEditor;
using UnityEngine;

namespace Emmy.self_ui
{
    
    public class MyWindow:EditorWindow
    {
        private readonly DisplayObjectContainer _stage;

        public MyWindow()
        {
            this._stage = new DisplayObjectContainer();
            
        }

        private void OnGUI()
        {
            _stage.Draw();
            this.HandleEvent();
        }

        private void HandleEvent()
        {
//            Debugger.Log(UnityEngine.Event.current.type);
//            Debugger.Log(UnityEngine.Event.current.mousePosition);
        }
        
        protected DisplayObject AddChild(DisplayObject child)
        {
            return this._stage.AddChild(child);
        }

        protected void AddChildAt(DisplayObject child, int index)
        {
            this._stage.AddChildAt(child, index);
        }
    }
}