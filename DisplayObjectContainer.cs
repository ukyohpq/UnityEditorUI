using System.Collections.Generic;
using LuaInterface;

namespace Emmy.self_ui
{
    public class DisplayObjectContainer : DisplayObject
    {
        private List<DisplayObject> _children;

        public int NumChildren
        {
            get { return this._children.Count; }
        }
        
        public DisplayObjectContainer()
        {
            this._children = new List<DisplayObject>();
        }

        public DisplayObject AddChild(DisplayObject child)
        {
            this._children.Add(child);
            child._parent = this;
            this.isModi = true;
            return child;
        }

        public void AddChildAt(DisplayObject child, int index)
        {
            this._children.Insert(index, child);
        }
        
        protected override void DoDraw()
        {
            int length = this._children.Count;
            for (int i = 0; i < length; i++)
            {
                this._children[i].Draw();
            }
        }
    }
}