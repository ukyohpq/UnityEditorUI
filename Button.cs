using System;
using UnityEngine;

namespace Emmy.self_ui
{
    public class Button:Sprite
    {
        private string _label;
        public Button(string label)
        {
            this._label = label;
            this.Width = 50;
            this.Height = 20;
        }

        protected override void DoDraw()
        {
            base.DoDraw();
            if (GUI.Button(this._rect, this._label))
            {
                
            }
        }
    }
}