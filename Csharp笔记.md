# C# 学习笔记

---

## 一、语法基础

### 1.1 控制台输入输出

`Console.WriteLine()` 输出内容并换行，`Console.Write()` 输出内容不换行，`Console.ReadLine()` 读取用户输入（返回 `string`）。

```csharp
Console.WriteLine("Hello World");
Console.Write("请输入你的名字：");
string name = Console.ReadLine();
Console.WriteLine("你好，" + name);
```

### 1.2 变量与数据类型

变量必须先声明再使用。C# 是强类型语言，声明时需指定类型。

| 类型 | 说明 | 示例 |
|------|------|------|
| `int` | 32位有符号整数 | `int a = 10;` |
| `byte` | 8位无符号整数(0-255) | `byte b = 25;` |
| `float` | 32位浮点数（需加 `f` 后缀） | `float f = 3.14f;` |
| `bool` | 布尔值 | `bool flag = true;` |
| `char` | 单个字符（单引号） | `char c = 'A';` |
| `string` | 字符串（双引号） | `string s = "hello";` |

```csharp
int i = 0;
byte bt = 25;
float f = 3.14159f;      // float 必须加 f 后缀
bool flag = true;
char c = '1';             // char 只能存一个字符
string str = "Hello";
str = "可以重新赋值";

// 一行声明多个变量
int a1 = 1, a2 = 2, a3 = 3;
```

### 1.3 数据类型大小

使用 `sizeof()` 获取值类型占用的字节数。

```csharp
int sbyteSize = sizeof(sbyte);   // 1
int intSize = sizeof(int);       // 4
int shortSize = sizeof(short);   // 2
int longSize = sizeof(long);     // 8
```

常见类型大小：

| 类型 | 字节数 | 范围 |
|------|--------|------|
| `sbyte` | 1 | -128 ~ 127 |
| `short` | 2 | -32768 ~ 32767 |
| `int` | 4 | -21亿 ~ 21亿 |
| `long`  | 8 | 极大范围 |
| `float` | 4 | 约7位精度 |
| `double` | 8 | 约15位精度 |

### 1.4 常量

`const` 声明的变量必须在定义时初始化，之后不可修改。

```csharp
const int a = 0;
Console.WriteLine(a);
// a = 1;   // 编译错误：常量不可修改
```

### 1.5 转义字符与逐字字符串

| 转义符 | 含义 |
|--------|------|
| `\"` | 双引号 |
| `\n` | 换行 |
| `\\` | 反斜杠 |
| `\t` | 制表符 |
| `\a` | 警报声 |

使用 `@` 前缀可忽略转义，称为**逐字字符串**，常用于文件路径。

```csharp
string str = "a s\"\n123132141\\";
Console.WriteLine(str);

str = @"你\t好";   // 逐字字符串，\t 被当作普通字符输出
Console.WriteLine(str);  // 输出：你\t好（不会变成制表符）
```

### 1.6 隐式类型转换

大范围类型可以隐式接收小范围类型的值（自动安全转换）。转换方向：`long` ← `int` ← `short` ← `sbyte`

```csharp
long l = 1;
int i = 0;
sbyte sb = 13;
short s = 2;

l = i;   // int → long 隐式转换 OK
i = s;   // short → int 隐式转换 OK
s = sb;  // sbyte → short 隐式转换 OK
```

---

## 二、流程控制

### 2.1 算术运算符

| 运算符 | 含义 | 示例 |
|--------|------|------|
| `+` | 加 | `a + b` |
| `-` | 减 | `a - b` |
| `*` | 乘 | `a * b` |
| `/` | 除（整数相除得整数） | `a / b` |
| `%` | 取余 | `a % b` |

**自增/自减**：`++` 和 `--`。前置（`++a`）先加后用，后置（`a++`）先用后加。

```csharp
int a = 10, b = 20;

int r1 = ++a + b;    // a先变11, 再算 11+20 = 31
a = 10; b = 20;
int r2 = a + b++;    // 先算 10+20 = 30, b再变21
a = 10; b = 20;
int r3 = a++ + ++b;  // 10 + 21 = 31, a再变11
```

**变量交换**（两种方法）：

```csharp
// 方法1：借第三变量
int temp = a; a = b; b = temp;

// 方法2：算术交换
a = a + b; b = a - b; a = a - b;
```

### 2.2 逻辑运算符与短路求值

| 运算符 | 含义 |
|--------|------|
| `&&` | 逻辑与（两边都为 true 才为 true） |
| `\|\|` | 逻辑或（任意一边为 true 即为 true） |
| `!` | 逻辑非（取反） |

**关键：短路求值**

- `A && B`：如果 A 为 `false`，B 不会被执行（结果已确定为 false）
- `A || B`：如果 A 为 `true`，B 不会被执行（结果已确定为 true）

```csharp
int i = 1;
bool result = i > 0 || ++i > 2;
// i > 0 为 true，右边 ++i 不会执行
Console.WriteLine(result);  // True
Console.WriteLine(i);       // 1（i 没有被自增）
```

### 2.3 三目运算符

`条件 ? 值1 : 值2` —— 条件为真返回值1，为假返回值2。

```csharp
string str = true ? "你好" : "好在哪？";
Console.WriteLine(str);  // 输出：你好
```

### 2.4 位运算符

对整数的二进制位进行操作。

| 运算符 | 含义 | 示例 |
|--------|------|------|
| `&` | 按位与 | `5 & 3` = 1 |
| `\|` | 按位或 | `5 \| 3` = 7 |
| `^` | 按位异或 | `5 ^ 3` = 6 |
| `~` | 按位取反 | `~5` = -6 |
| `<<` | 左移 | `5 << 1` = 10 |
| `>>` | 右移 | `5 >> 1` = 2 |

```csharp
int a = 5, b = 5;
int c = a & b;      // 0101 & 0101 = 0101 = 5
Console.WriteLine(c);
```

### 2.5 条件语句

**if-else：**

```csharp
Console.WriteLine("你喜欢的说唱歌手是谁");
string str = Console.ReadLine();
if (str != null && str.Equals("Asen", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("阿里嘎多");
}
else
{
    Console.WriteLine("感觉不如kiZz");
}
```

> **注意**：字符串比较用 `.Equals()` 方法。`StringComparison.OrdinalIgnoreCase` 忽略大小写。

**switch-case：**

```csharp
int a = 1;
switch (a)
{
    case 1:
        Console.WriteLine("一");
        break;
    case 2:
        Console.WriteLine("二");
        break;
    default:
        Console.WriteLine("其他");
        break;
}
```

每个 `case` 必须以 `break` 结尾（C# 不允许 `case` 穿透），`default` 是可选的。

### 2.6 循环语句

**while 循环**：先判断条件，满足则执行。

```csharp
int a = 10;
while (a > 5)
{
    a -= 2;   // 等价于 a = a - 2
}
Console.WriteLine(a);  // 4
```

**for 循环**：适合已知循环次数的情况。

```csharp
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
```

### 2.7 异常处理

`try-catch-finally`：用于捕获和处理运行时的异常。`finally` 块无论是否发生异常都会执行。

```csharp
try
{
    string str = Console.ReadLine();
    int i = int.Parse(str);        // 输入非法字符会抛异常
    Console.WriteLine(i);
}
catch
{
    Console.WriteLine("请输入合法数字");
}
finally
{
    Console.WriteLine("程序结束");  // 始终执行
}
```

---

## 三、复合数据类型

### 3.1 字符串操作

**string.Format 格式化：**

```csharp
string str = string.Format("迎面走来的{0}让{1}如此心动，这种感觉{2}曾未有", "你", "我", "我");
Console.WriteLine(str);

// Console.WriteLine 也支持直接使用占位符
Console.WriteLine("我叫{0}，今年{1}岁", "kiZz", 18);
```

### 3.2 值类型 vs 引用类型

这是 C# 中区分数据类型的两大类：

| | 值类型 | 引用类型 |
|------|------|------|
| **存储位置** | 栈(Stack) | 堆(Heap)，栈上存引用指针 |
| **赋值行为** | 复制值，独立副本 | 复制引用，指向同一对象 |
| **典型类型** | `int`, `float`, `bool`, `struct`, `enum` | `string`, `class`, `int[]`, `object` |

```csharp
// 值类型：赋值是独立拷贝
int a = 0;
int b = a;
b = 999;
Console.WriteLine(a);  // 0，a 不受影响

// 引用类型：赋值是共享同一对象
int[] arr = new int[] { 1, 2, 3, 4 };
int[] arr2 = arr;
arr2[0] = 999;
Console.WriteLine(arr[0]);  // 999，arr 和 arr2 指向同一数组

// 用 new 断开引用
arr2 = new int[] { 1, 2, 3, 4 };
Console.WriteLine(arr[0]);  // 999，arr 不受影响
```

### 3.3 数组

数组是定长的同类型元素集合。声明时必须指定类型，长度确定后不可变。

**五种声明方式：**

```csharp
int[] arr1;                           // 仅声明，未初始化
int[] arr2 = new int[5];              // 长度为5的空数组（元素为0）
int[] arr3 = new int[5] { 1, 2, 3, 4, 5 };  // 声明大小并初始化
int[] arr4 = new int[] { 1, 2, 3, 4 };      // 初始化列表推断大小
int[] arr5 = { 10, 9, 41, 421 };            // 最简写法
```

**常用操作：**

```csharp
int[] array = { 1, 2, 3, 4, 5 };

Console.WriteLine(array.Length);  // 获取长度：5
Console.WriteLine(array[0]);      // 访问元素：1 （索引从0开始）
array[1] = 99;                    // 修改元素

// 遍历
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
```

**动态增删**（C# 数组不可变长，需手动创建新数组）：

```csharp
// 增加元素
int[] newArray = new int[array.Length + 1];
for (int i = 0; i < array.Length; i++)
    newArray[i] = array[i];
newArray[newArray.Length - 1] = 6;
array = newArray;  // 指向新数组
```

### 3.4 选择排序

经典排序算法：每一轮找到未排序部分的最大（小）值，放到已排序位置。

```csharp
int[] arr = new int[] { 8, 7, 1, 5, 6, 2, 4, 3, 9 };

for (int j = 0; j < arr.Length; j++)
{
    int index = 0;
    for (int i = 1; i < arr.Length - j; i++)
    {
        if (arr[index] < arr[i])
            index = i;     // 找到最大值的位置
    }
    // 将最大值交换到当前未排序部分的末尾
    if (index != arr.Length - 1 - j)
    {
        int temp = arr[index];
        arr[index] = arr[arr.Length - 1 - j];
        arr[arr.Length - 1 - j] = temp;
    }
}
```

### 3.5 随机数

使用 `Random` 类生成随机数。`Next(max)` 返回 `[0, max)` 范围内的整数。

```csharp
Random r = new Random();
int i = r.Next(20);      // 0 到 19 之间的随机整数
Console.WriteLine(i);
int damage = r.Next(5, 15);  // 5 到 14 之间
```

### 3.6 枚举

`enum` 是一组命名的整数常量，默认从 0 开始递增。约定命名前缀为 `E_` 或 `E`。

```csharp
// 命名空间内声明
enum E_MonsterType
{
    Normal,  // 0
    Boss,    // 1
}

enum E_PlayerType
{
    Main,   // 0
    Other,  // 1
}
```

**枚举与整数/字符串互转：**

```csharp
E_PlayerType playerType = E_PlayerType.Main;

int i = (int)playerType;           // 枚举 → int：0
string str = playerType.ToString(); // 枚举 → string："Main"

// 解析字符串为枚举
E_PlayerType type = (E_PlayerType)Enum.Parse(typeof(E_PlayerType), "Other");
```

**枚举配合 switch：**

```csharp
switch (monsterType)
{
    case E_MonsterType.Normal:
        Console.WriteLine("普通怪物");
        break;
    case E_MonsterType.Boss:
        Console.WriteLine("Boss怪物");
        break;
}
```

### 3.7 结构体

`struct` 是**值类型**（存储在栈上），适合表示轻量级数据对象。声明在 `namespace` 或 `class` 内部。

```csharp
struct Student
{
    // 字段 — 结构体中不能直接初始化
    public int age;
    public bool sex;
    public int number;
    public string name;

    // 方法
    public void Speak()
    {
        Console.WriteLine("我叫{0}，今年{1}岁", name, age);
    }

    // 构造函数
    public Student(int age, bool sex, int number, string name)
    {
        this.age = age;
        this.sex = sex;
        this.number = number;
        this.name = name;
    }
}
```

**使用方式：**

```csharp
// 方式1：逐字段赋值
Student s1;
s1.age = 10;
s1.sex = false;
s1.number = 1;
s1.name = "kiZz";
s1.Speak();

// 方式2：构造函数初始化
Student s2 = new Student(18, true, 2, "kiZoverlxrd");
```

---

## 四、方法与函数

### 4.1 成员方法

方法定义在类中，包含访问修饰符、返回类型、方法名、参数列表和方法体。

```csharp
public void Speak(string str)
{
    Console.WriteLine("{0}说：{1}", name, str);
}

public bool IsAdult()
{
    return age >= 18;
}

// 方法返回值为 void 表示不返回任何东西
```

### 4.2 变长参数与默认值

**默认参数值**：给参数指定默认值，调用时可省略。

**params（变长参数）**：允许向方法传递任意数量的同类型参数。

```csharp
// 默认参数值
void PrintInfo(string name, int age = 18)
{
    Console.WriteLine("{0}，{1}岁", name, age);
}
PrintInfo("kiZz");           // age 使用默认值 18
PrintInfo("kiZz", 25);       // age 指定为 25

// params 变长参数
void TestFun(params int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i]);
}
TestFun(1, 2, 3, 4, 5);  // 传入任意多个参数
```

### 4.3 递归函数

函数内部调用自身。必须包含**终止条件**，否则会无限递归导致栈溢出。

```csharp
// 阶乘递归
int Factorial(int n)
{
    if (n <= 1)
        return 1;                   // 终止条件
    return n * Factorial(n - 1);     // 递归调用
}
Console.WriteLine(Factorial(5));     // 120

// 斐波那契递归
int Fib(int n)
{
    if (n <= 1) return n;
    return Fib(n - 1) + Fib(n - 2);
}
```

### 4.4 拓展方法

在不修改原类型代码的情况下，为已有类型"添加"新方法。**必须定义在静态类中**，第一个参数用 `this` 指定要拓展的类型。

```csharp
static class Tools
{
    // 为 int 类型拓展方法
    public static void SpeakValue(this int value)
    {
        Console.WriteLine("int的值是：" + value);
    }

    // 为 string 类型拓展方法
    public static void PrintInfo(this string str, string info)
    {
        Console.WriteLine("字符串：" + str + "，信息：" + info);
    }

    // 为自定义类型拓展方法
    public static void CustomMethod(this Test t)
    {
        Console.WriteLine("为Test拓展的方法");
    }
}

// 调用方式 — 就像实例方法一样
int i = 10;
i.SpeakValue();                     // int的值是：10

string s = "hello";
s.PrintInfo("world");              // 字符串：hello，信息：world
```

---

## 五、面向对象编程

### 5.1 类与对象、成员变量、访问修饰符

类是对象的模板，通过 `new` 创建实例。成员变量（字段）存储在类的实例中。

**默认值**：数值类型默认 `0`，`bool` 默认 `false`，引用类型默认 `null`。

| 访问修饰符 | 含义 |
|-----------|------|
| `public` | 任意位置可访问 |
| `private` | 仅类内部可访问（默认） |
| `protected` | 类内部和子类可访问 |
| `internal` | 同一程序集内可访问 |

```csharp
class Person
{
    public string name = "kiZz";     // 初始化的成员
    public int age;                  // 默认值 0
    public E_SexType sex;            // 默认值 第一个枚举值
    public Person girlfriend;        // 默认值 null
    public Person[] friends;         // 默认值 null
}
```

### 5.2 构造函数与析构函数

构造函数在 `new` 创建对象时自动调用，用于初始化对象。构造函数名与类名相同，无返回类型。

```csharp
class Person
{
    public string name;
    public int age;

    // 无参构造函数
    public Person()
    {
        name = "kiZz";
        age = 18;
    }

    // 有参构造函数
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // 构造函数链 — 用 this() 调用自身其他构造函数
    public Person(string name, int age, string city) : this(name, age)
    {
        Console.WriteLine("城市：" + city);
    }
}
```

> **重要**：如果自定义了有参构造函数，则默认无参构造函数会被取消，除非手动再定义。

C# 有垃圾回收（GC），不需要手动释放内存。当对象不再被引用时，GC 会自动回收。

```csharp
Person p = new Person();
p = null;   // 原对象成为垃圾，等待 GC 回收
```

### 5.3 成员属性

属性是字段的封装，通过 `get`/`set` 访问器控制读写，可以在访问时添加验证或处理逻辑。

```csharp
class Person
{
    private int money;   // 私有字段

    public int Money
    {
        get
        {
            // 读取时解密
            return (money - 5) / 8;
        }
        set
        {
            // 写入时加密并验证
            if (value < 0)
            {
                value = 0;
                Console.WriteLine("金额不能为负，已设为0");
            }
            money = value * 8 + 5;
        }
    }
}
```

**自动属性**（无额外逻辑时）：

```csharp
public string Name { get; set; }              // 可读可写
public int Age { get; private set; }           // 外部只读
public float Height { get; private set; }      // 外部只读
```

### 5.4 静态成员与静态类

`static` 成员属于类本身，不属于任何实例。通过 `类名.成员` 访问。

```csharp
class MathHelper
{
    public const float G = 9.8f;           // const 编译时常量
    public static float PI = 3.14159f;      // static 字段

    // 静态方法只能访问静态成员
    public static float CalcCircleArea(float r)
    {
        return PI * r * r;
    }
}

// 调用（无需实例化）
float area = MathHelper.CalcCircleArea(5);
Console.WriteLine(MathHelper.PI);
```

**静态类**：用 `static class` 声明，不能实例化，所有成员必须是静态的。

```csharp
static class StaticClass
{
    public static int testInt = 100;

    static StaticClass()  // 静态构造函数：仅调用一次，在首次使用前自动执行
    {
        Console.WriteLine("静态类初始化");
    }
}
```

> 普通类也可以有静态构造函数：在首次实例化或访问静态成员时自动调用一次。

### 5.5 索引器

让对象能像数组一样用 `[]` 语法访问数据。

```csharp
class Person
{
    private string name;
    private int age;
    private Person[] friends;
    private int[,] array;

    // 按 int 索引，访问 friends 数组
    public Person this[int index]
    {
        get { return friends[index]; }
        set { friends[index] = value; }
    }

    // 二维索引器
    public int this[int i, int j]
    {
        get { return array[i, j]; }
        set { array[i, j] = value; }
    }

    // 按 string 索引，访问指定字段
    public string this[string fieldName]
    {
        get
        {
            switch (fieldName)
            {
                case "name": return name;
                case "age": return age.ToString();
                default: return "";
            }
        }
    }
}

// 使用
Person p = new Person();
p[0] = new Person();         // 调用 int 索引器 set
Console.WriteLine(p[0]);     // 调用 int 索引器 get
Console.WriteLine(p["name"]); // 调用 string 索引器 get
```

### 5.6 继承基本规则

C# 只支持**单继承**（一个类只能继承一个父类），但可以**多层继承**。子类获得父类所有 `public` 和 `protected` 成员。

```csharp
class Teacher
{
    public string name;
    public int number;

    public void SpeakName()
    {
        Console.WriteLine(name);
    }
}

// TeachingTeacher 继承 Teacher
class TeachingTeacher : Teacher
{
    public string subject;

    public void SpeakSubject()
    {
        Console.WriteLine("我是{0}老师", subject);
    }
}

// RapTeacher 继承 TeachingTeacher，形成三级继承链
class RapTeacher : TeachingTeacher
{
    public void Skill()
    {
        Console.WriteLine("{0}老师教你科目：{1}", name, subject);
        // 可以访问祖父类 Teacher 的 name 字段
    }
}
```

### 5.7 继承中的构造函数

创建子类对象时，构造函数从顶层父类开始逐级向下执行。如果父类没有无参构造函数，子类必须用 `base()` 显式调用父类构造函数。

```csharp
class GameObject
{
    public GameObject() { Console.WriteLine("GameObject构造"); }
}

class Player : GameObject
{
    public Player() { Console.WriteLine("Player构造"); }
}

class MainPlayer : Player
{
    public MainPlayer() { Console.WriteLine("MainPlayer构造"); }
}

// new MainPlayer() 输出：
// GameObject构造
// Player构造
// MainPlayer构造
```

**base() 调用父类指定构造函数：**

```csharp
class Father
{
    public Father(int i)
    {
        Console.WriteLine("父类构造函数：" + i);
    }
}

class Son : Father
{
    public Son(int i) : base(i)   // 必须调用 base，因为 Father 没有无参构造
    {
        Console.WriteLine("子类构造函数");
    }
}
```

### 5.8 密封类

`sealed` 修饰的类**不能被继承**。

```csharp
sealed class Father { }

// class Son : Father { }   // 编译错误：无法继承密封类
```

### 5.9 抽象类与抽象方法

`abstract` 类不能实例化，只能被继承。抽象方法没有方法体，子类必须用 `override` 实现。

```csharp
abstract class Fruits
{
    public string name;

    public abstract void Bad();   // 抽象方法：无实现体
}

class Apple : Fruits
{
    public override void Bad()    // 必须 override 实现
    {
        Console.WriteLine("苹果坏了");
    }
}

// Fruits f = new Fruits();   // 错误：抽象类不能实例化
Fruits f = new Apple();      // 正确：通过父类引用子类对象
```

**抽象方法规则：**

- 只能在抽象类中声明
- 不能是 `private`
- 没有方法体（只有声明）

### 5.10 多态

多态允许父类引用调用子类重写的方法，运行时决定具体调用哪个版本。

**virtual + override（真正的多态）：**

```csharp
class GameObject
{
    public virtual void Atk()
    {
        Console.WriteLine("游戏对象攻击");
    }
}

class Player : GameObject
{
    public override void Atk()
    {
        base.Atk();                    // 调用父类版本
        Console.WriteLine("玩家的攻击");
    }
}

// 多态行为
GameObject p = new Player("kiZz");
p.Atk();  // 输出：游戏对象攻击  +  玩家的攻击
          // 运行时调用的是 Player 的版本
```

**new 方法隐藏（不是多态）：**

```csharp
class Son : Father
{
    public new void SpeakName()
    {
        Console.WriteLine("Son的方法");
    }
}

Father f = new Son();
f.SpeakName();            // 输出："Father的方法"（父类引用调父类方法）
(f as Son).SpeakName();   // 输出："Son的方法"（必须转成子类才调子类方法）
```

> `new` 只是隐藏，不是覆盖。父类引用仍然调用父类方法。只有 `virtual + override` 才是真正的运行时多态。

### 5.11 接口

接口声明了一组功能契约，实现接口的类必须实现其中所有成员。接口不能有成员变量和方法实现。

```csharp
interface IFly
{
    void Fly();
    string Name { get; set; }       // 属性声明
    int this[int index] { get; set; } // 索引器声明
}
```

**接口规则：**

- 不能包含成员变量（字段）
- 只能有方法、属性、索引器、事件的声明
- 成员不能有实现体
- 所有成员隐式为 `public`
- 接口可以继承其他接口（但不能继承类）
- 类可以同时实现多个接口

```csharp
class Person : Animal, IFly    // 继承类 + 实现接口
{
    public void Fly() { }
    public string Name { get; set; }
    public int this[int index]
    {
        get { return 0; }
        set { }
    }
}
```

**接口继承接口：**

```csharp
interface IMove : IFly, IWalk   // 接口可多继承
{
    void Run();
}
```

**显式接口实现**（解决命名冲突）：

```csharp
class Player : IAtk, ISuperAtk
{
    void IAtk.Atk()            // 显式实现，不能加 public
    {
        Console.WriteLine("普通攻击");
    }
    void ISuperAtk.Atk()
    {
        Console.WriteLine("大招攻击");
    }
}

Player p = new Player();
(p as IAtk).Atk();        // "普通攻击"
(p as ISuperAtk).Atk();   // "大招攻击"
```

> 显式实现用于两个接口有同名方法时区分调用。调用时必须转换为对应接口类型。

### 5.12 内部类与分部类

**内部类（嵌套类）**：类定义在另一个类的内部。用 `OuterClass.InnerClass` 访问。

```csharp
class Person
{
    public class Body
    {
        class Arm { }    // 甚至可多层嵌套
    }
}

Person.Body body = new Person.Body();
```

**分部类（partial）**：同一个类拆分到多个文件中声明，编译时自动合并。

```csharp
partial class Student
{
    public bool sex;
    public string name;

    partial void Speak();       // 分部方法：只声明
}

partial class Student
{
    public int number;

    partial void Speak()        // 分部方法：实现
    {
        Console.WriteLine("Student的方法");
    }
}
```

### 5.13 密封方法

`sealed override` 阻止子类进一步重写已被 `override` 的方法。

```csharp
class Person : Animal
{
    public override void Eat()
    {
        Console.WriteLine("人吃饭");
    }

    public override void Speak()
    {
        Console.WriteLine("人说话");
    }
}

class WhitePerson : Person
{
    public sealed override void Eat()
    {
        base.Eat();    // 调用 Person.Eat
    }
    public sealed override void Speak()
    {
        base.Speak();  // 调用 Person.Speak
    }
}
// WhitePerson 的子类无法再 override Eat 和 Speak
```

---

## 六、设计原则

### 6.1 里氏替换原则（LSP）

核心思想：**父类容器可以装子类对象**，子类可以替换父类出现的位置，且程序行为不变。

```csharp
// 父类容器装子类对象
GameObject player = new Player();
GameObject monster = new Monster();
GameObject boss = new Boss();

// 多态数组
GameObject[] objects = new GameObject[]
{
    new Player(),
    new Monster(),
    new Boss()
};

// 使用 is 类型检查 + as 安全转换
if (player is Player)
{
    (player as Player).PlayerAtk();   // 调用子类特有方法
}
```

### 6.2 万物之父与装箱拆箱

`object` 是所有类型的基类（C# 中一切皆派生自 `object`）。

```csharp
// object 可以引用任何类型
object o1 = 3;
object o2 = "hello";
object o3 = new Person();
```

**装箱**：值类型 → `object`（数据从栈移到堆）  
**拆箱**：`object` → 值类型（数据从堆移到栈）

```csharp
// 装箱
int a = 42;
object obj = a;        // 装箱：值类型包装成 object

// 拆箱
int b = (int)obj;      // 拆箱：object 还原为 int
```

> 装箱拆箱有性能开销，应避免在热路径中频繁使用。

**类型检查与安全转换：**

```csharp
object o = new Son();

// is：判断是否为某类型
if (o is Son)
{
    (o as Son).Speak();  // as：安全转换（失败返回 null，不抛异常）
}
```

---

## 七、高级特性

### 7.1 运算符重载

通过 `operator` 关键字为自定义类型定义运算符行为。必须是 `public static` 方法。

```csharp
class Point
{
    public int X;
    public int Y;

    // Point + Point
    public static Point operator +(Point p1, Point p2)
    {
        return new Point { X = p1.X + p2.X, Y = p1.Y + p2.Y };
    }

    // Point + int
    public static Point operator +(Point p1, int value)
    {
        return new Point { X = p1.X + value, Y = p1.Y + value };
    }
}

// 使用
Point p1 = new Point { X = 1, Y = 2 };
Point p2 = new Point { X = 3, Y = 4 };
Point p3 = p1 + p2;     // X=4, Y=6
Point p4 = p1 + 5;      // X=6, Y=7
```
