using System;
using UnityEngine;

namespace Emmy.self_ui
{
    public class DisplayObject:EventDispatcher
    {
        private bool _needResize;

        public bool NeedResize
        {
            get { return this._needResize; }
        }
        
        protected bool isModi;

        public bool IsModi
        {
            get { return isModi; }
        }

        internal DisplayObjectContainer _parent;

        public DisplayObjectContainer Parent
        {
            get { return this._parent; }
        }

        private float _x;
        public float X
        {
            get { return this._x; }
            set
            {
                this._x = value;
                this._needResize = true;
            }
        }

        private float _y;
        public float Y
        {
            get { return this._y; }
            set
            {
                this._y = value;
                this._needResize = true;
            }
        }

        private float _width;
        public float Width
        {
            get { return this._width; }
            set
            {
                this._width = value;
                this._needResize = true;
            }
        }

        private float _height;
        public float Height
        {
            get { return this._height; }
            set
            {
                this._height = value;
                this._needResize = true;
            }
        }

        protected Rect _rect;
        protected DisplayObject():base()
        {
            this.isModi = false;
            this._needResize = false;
            this._rect = new Rect();
        }
        
        
        public void Draw()
        {
            if (!this.isModi)
            {
//                TODO 如果return了，就不绘制了，不知道该如何保持绘制的ui不变，因此必须一直绘制ui
//                return;
            }

            this.ReCalculateSize();
            this.DoDraw();
            this.isModi = false;
        }

        protected virtual void DoDraw()
        {
            throw new Exception("must be override!");
        }

        private void ReCalculateSize()
        {
            if (this._needResize)
            {
                this._rect.x = this._parent._rect.x + this._x;
                this._rect.y = this._parent._rect.y + this._y;
                this._rect.width = this._parent._rect.width + this._width;
                this._rect.height = this._parent._rect.height + this._height;
                this._needResize = false;
            }
        }
    }
}