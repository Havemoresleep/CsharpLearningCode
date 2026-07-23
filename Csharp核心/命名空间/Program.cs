using MyGame;//引用myGame命名空间
//using MyGame2;
using MyGame.Game;//引用myGame命名空间下的Game命名空间
namespace 命名空间
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("命名空间");
            //不同命名空间中互相使用 需要引用命名空间或指明出处
            GameObject g = new GameObject(); //重复时，只能用指明出处
            MyGame.Player p = new MyGame.Player(); //没用using MyGame; 需要指明出处

            MyGame.UI.Image img1 = new MyGame.UI.Image();
            Image image1 = new Image();//using MyGame.Game; 引用myGame命名空间下的Game命名空间

        }
    }
}

namespace MyGame 
{
    class GameObject 
    {
    
    }
}

namespace MyGame
{ 
    class Player : GameObject
    {

    }
}

namespace MyGame2 
{ 
    class GameObject
    {

    }
}
//同一命名空间不能有同名类
//不同命名空间可以有同名类

namespace MyGame 
{
    namespace UI 
    {
        class Image
        {

        }
    }

    namespace Game 
    {
        class Image
        {

        }
    }
}
//命名空间可以包含命名空间

#region 关于修饰类的访问修饰符
//命名空间下的类的访问修饰符有：public、internal、abstract、sealed、partial
//命名空间下的类默认是internal，类的访问修饰符不能是protected、private、protected internal、private protected
#endregion