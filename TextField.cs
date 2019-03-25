using System;
using UnityEditor;
using UnityEngine;

namespace Emmy.self_ui
{
    public class TextField:DisplayObject
    {
        private string _text;

        public string Text
        {
            get { return this._text; }
            set {
                if (this._text != value)
                {
                    this._text = value;
                    this.isModi = true;
                } 
            }
        }
        public TextField(string text):base()
        {
            this.Text = text;
            this.X = 10;
            this.Y = 10;
            this.Width = 100;
            this.Height = 100;
        }

        protected override void DoDraw()
        {
//            GUI.Label(new Rect(0, 0, 10, 10), this._text);
            GUI.Label(this._rect, this._text);
        }
    }
}