// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string e;
int t;
int f;
string port;
string port2;
int b = 0;
bool ahoj = true;
int v = 0;
e = Console.ReadLine();
float p;
string l;
var inputs = e.Split('/');
List<int> check = new List<int>();
List<string> c = new List<string>();
int i;
i = int.Parse(inputs[0]) / int.Parse(inputs[1]);
int j;
j = int.Parse(inputs[0]) - i* int.Parse(inputs[1]);
while (ahoj == true)
{
    j = j * 10;
    i = j / int.Parse(inputs[1]);
    j = j - i * int.Parse(inputs[1]);
    
    
    
    if (check.Contains(j))
    {
        b = j;
       t = check.IndexOf(j);
        
        ahoj = false;
    }
    c.Add(i.ToString());
    check.Add(j);
    v++;
    if (j == 0)
    {
        p = int.Parse(inputs[0]) / int.Parse(inputs[1]);
        l = p.ToString() + ".";
        l += string.Join("", c);
        Console.WriteLine(l);
        Console.ReadKey();
        Environment.Exit(0);

    }
}

p = int.Parse(inputs[0]) / int.Parse(inputs[1]);
l = p.ToString() + ".";

ahoj = false;
f = check.IndexOf(j);
//string port3 = c[c.IndexOf(j.ToString())];
c[f] = "("+c[f];
f++;
while (v-1 >= f) {
    port2 = c[f];
   // c[f] = port.ToString();
    f++;
    port = port2;
}
c[v-1]= ")";
// pridej sem ze to vyhleda to c.j a pak ze kazdy dalsi o jedno posune
l += string.Join("",c);


//p = float.Parse(inputs[0]) / float.Parse(inputs[1]);
//var inputs2 = p.ToString().Split('.');
//var inputs3 = inputs2[1].ToString().Split();


Console.WriteLine(l);
