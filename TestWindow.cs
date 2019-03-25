using DG.Tweening.Core;
using UnityEditor;
using UnityEditor.UI;

namespace Emmy.self_ui
{
    public class TestWindow:MyWindow
    {
        private static TestWindow _window;
        [MenuItem("Window/测试功能")]
        private static void ShowWindow()
        {
            if (_window == null)
            {
                _window = CreateInstance<TestWindow>();
            }

            _window.Show();
        }

        private DisplayObject tf;
        public TestWindow()
        {
            var sp = new Sprite();
            var tf = new TextField("hello world");
            sp.AddChild(tf);
            tf.X = 0;
            tf.Y = 100;
            tf.Width = 100;
            tf.Height = 100;
            this.AddChild(sp);
            sp.X = 100;
//            sp.Y = 0;
//            sp.Width = 0;
//            sp.Height = 0;
            var button = new Button("test");
            button.Y = 100;
            sp.AddChild(button);
        }

    }
}